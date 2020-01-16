using System;

namespace InheritanceDemo.GameElements
{
    public class GameBoard
    {
        private static Random _rnd = new Random();
        public AbstractCell[,] Surface { get; private set; }
        public int Size { get; private set; }
        public int BombCount { get; private set; }

        /// <summary>
        /// Initializes a new instance of the GameBoard class.
        /// </summary>
        public GameBoard(int size)
        {
            if (size < 4 || size > 9)
                throw new ArgumentException("Invalid size; game board must be between 4x4 and 9x9");
            Size = size;
            BombCount = Size / 2;

            // Init Board
            InitializeEmptyBoard();
            PlaceBombsAndWarnings();
        }

        private void InitializeEmptyBoard()
        {
            Surface = new AbstractCell[Size, Size];
            for (int rowIndex = 0; rowIndex < Size; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Size; columnIndex++)
                {
                    Surface[rowIndex, columnIndex] = new EmptyCell();
                }
            }
        }

        private void PlaceBombsAndWarnings()
        {
            for (int counter = 0; counter < BombCount; counter++)
            {
                int column;
                int row;
                do
                {
                    column = _rnd.Next(Size);
                    row = _rnd.Next(Size);
                } while (Surface[row, column].GetType() == typeof(BombCell));
                Surface[row, column] = new BombCell();
                PlaceWarningCell(row - 1, column);
                PlaceWarningCell(row + 1, column);
                PlaceWarningCell(row, column - 1);
                PlaceWarningCell(row, column + 1);
            }
        }

        private void PlaceWarningCell(int row, int column)
        {
            // only place a warning cell if the row/column is inside the GameBoard's grid
            if (row >= 0 && row < Size && column >= 0 && column < Size)
                Surface[row, column] = new WarningCell();
        }
    }
}
