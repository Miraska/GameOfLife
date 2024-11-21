using System;

namespace GameOfLife
{
	public class GameEngine
	{
		private bool[,] field;
		private readonly int rows;
		private readonly int cols;

		public int CurrentGeneration { get; private set; } = 0;

		public GameEngine(int rows, int cols, int density)
		{
			Random random = new Random();
			this.rows = rows;
			this.cols = cols;
			field = new bool[cols, rows];

			for (int x = 0; x < cols; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					field[x, y] = random.Next(density) == 0;
				}
			}
		}

		private int CountNeighbors(int x, int y)
		{
			int count = 0;

			for (int i = -1; i < 2; i++)
			{
				for (int j = -1; j < 2; j++)
				{
					int col = (x + i + cols) % cols;
					int row = (y + j + rows) % rows;
					bool isSelfCheking = col == x && row == y;
					bool hasLife = field[col, row];

					if (hasLife && !isSelfCheking)
						count++;
				}
			}

			return count;
		}

		public void NextGeneration()
		{
			var newField = new bool[cols, rows];

			for (int x = 0; x < cols; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					int neighborsCount = CountNeighbors(x, y);
					bool hasLife = field[x, y];

					if (!hasLife && neighborsCount == 3)
					{
						newField[x, y] = true;
					}

					else if (hasLife && (neighborsCount < 2 || neighborsCount > 3))
					{
						newField[x, y] = false;
					}
					else
					{
						newField[x, y] = field[x, y];
					}
				}
			}

			field = newField;
			CurrentGeneration++;
		}

		public bool[,] GetCurrentGenration()
		{
			var result = new bool[cols, rows];

			for (int x = 0; x < cols; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					result[x, y] = field[x, y];
				}
			}

			return result;
		}

		private bool ValidateCellPosition(int x, int y)
		{
			return x >= 0 && y >= 0 && x < cols && y < rows;
		}

		private void UpdateCell(int x, int y, bool state)
		{
            if (ValidateCellPosition(x, y))
            {
				field[x, y] = state;
            }
        }

		public void AddCell(int x, int y)
		{
			UpdateCell(x, y, true);
		}

		public void RemoveCell(int x, int y)
		{
			UpdateCell(x, y, false);
		}
	}
}
