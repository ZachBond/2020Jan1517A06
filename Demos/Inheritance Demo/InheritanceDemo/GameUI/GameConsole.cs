using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceDemo.GameUI
{
    public class GameConsole : IUserInterface
    {
        void IUserInterface.Refresh(GameElements.GameBoard board)
        {
            Console.Clear();
            Console.Write("R C ");
            for (int columns = 0; columns < board.Size; columns++)
            {
                Console.Write(columns);
                Spacer();
            }
            Console.WriteLine();
            for (int rowCount = 0; rowCount < board.Size; rowCount++)
            {
                Console.Write(rowCount);
                Console.Write("   ");
                for (int columnCount = 0; columnCount < board.Size; columnCount++)
                {
                    if (board.Surface[rowCount, columnCount].IsVisible)
                        Console.Write(board.Surface[rowCount, columnCount].Symbol);
                    else
                        Console.Write("O");
                   Spacer();
                }
                Console.WriteLine();
            }
        }

        private static void Spacer()
        {
            Console.Write(" ");
        }

         int IUserInterface.GetRow()
        {
            int row;
            do
            {
                Console.Write("Enter a row: ");
            } while (! int.TryParse(Console.In.ReadLine(), out row));

            return row;
        }

         int IUserInterface.GetColumn()
        {
            int column;
            do
            {
                Console.Write("Enter a column: ");
            } while (! int.TryParse(Console.In.ReadLine(), out column));

            return column;
        }


         void IUserInterface.ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
