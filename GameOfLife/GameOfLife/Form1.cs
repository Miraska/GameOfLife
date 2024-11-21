using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
	public partial class Form1 : Form
	{
		private Graphics _graphics;
		private int _resolution;
		private GameEngine _engine;

		public Form1()
		{
			InitializeComponent();
			radioButtonFps30.Checked = true;
		}
		private void StartGame()
		{
			if (timer1.Enabled == true)
				return;

			nudResolution.Enabled = false;
			nudDensity.Enabled = false;
			radioButtonFps30.Enabled = false;
			radioButtonFps10.Enabled = false;
			_resolution = (int)nudResolution.Value;

			_engine = new GameEngine
			(
				rows: pictureBox1.Height / _resolution,
				cols: pictureBox1.Width / _resolution,
				density: (int)nudDensity.Minimum + (int)nudDensity.Maximum - (int)nudDensity.Value
			);

			Text = $"Current Generation {_engine.CurrentGeneration}";


			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			_graphics = Graphics.FromImage(pictureBox1.Image);

			if(radioButtonFps30.Checked)
				timer1.Interval = 1000/30;
			else if(radioButtonFps10.Checked)
				timer1.Interval = 1000/10;

			timer1.Start();
		}
		private void StopGame()
		{
			if (!timer1.Enabled)
				return;

			timer1.Stop();

			nudResolution.Enabled = true;
			nudDensity.Enabled = true;
			radioButtonFps30.Enabled = true;
			radioButtonFps10.Enabled = true;
		}
		private void DrawNextGeneration()
		{
			_graphics.Clear(Color.Black);
			var field = _engine.GetCurrentGenration();

			for(int x = 0; x < field.GetLength(0); x++)
			{
				for(int y = 0; y < field.GetLength(1); y++)
				{
					if (field[x, y])
						_graphics.FillRectangle(Brushes.Crimson, x * _resolution, y * _resolution, _resolution - 1, _resolution - 1);
				}
			}

			pictureBox1.Refresh();
			Text = $"Next Genration {_engine.CurrentGeneration}";

			_engine.NextGeneration();
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			DrawNextGeneration();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			StartGame();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			StopGame();
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (!timer1.Enabled)
				return;

			if (e.Button == MouseButtons.Left)
			{
				int x = e.Location.X / _resolution;
				int y = e.Location.Y / _resolution;

				_engine.AddCell(x, y);
			}

			if (e.Button == MouseButtons.Right)
			{
				int x = e.Location.X / _resolution;
				int y = e.Location.Y / _resolution;

				_engine.RemoveCell(x, y);
			}
		}
	}
}