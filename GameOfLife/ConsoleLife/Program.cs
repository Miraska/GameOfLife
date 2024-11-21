using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameOfLife;

namespace ConsoleLife
{
	internal class Program
	{
		private static int Rows = Console.WindowHeight - 2;
		private static int Cols = Console.WindowWidth;
		
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			GameEngine gameEngine = new GameEngine(Rows, Cols, 5);
			Console.SetCursorPosition(0, 0);

			while(true)
			{
				Thread.Sleep(60);
				bool[,] field = gameEngine.GetCurrentGenration();

				for (int y = 0; y < field.GetLength(1); y++)
				{
					char[] str = new char[field.GetLength(0)];

					for (int x = 0; x < field.GetLength(0); x++)
					{
						if (field[x, y])
							str[x] = '#';
						else
							str[x] = ' ';
					}
                    Console.WriteLine(str);
                }
				Console.SetCursorPosition(0, 0);
				gameEngine.NextGeneration();
			}
		}
	}
}
