using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InheritanceDemo.GameElements;
using InheritanceDemo.GameUI;

namespace InheritanceDemo
{
    public class GameEngine
    {
        private IUserInterface UI { get; set; }
        public bool IsOver { get; private set; }

        /// <summary>
        /// Initializes a new instance of the GameEngine class.
        /// </summary>
        public GameEngine(IUserInterface userInterface)
        {
            UI = userInterface;
        }

        public void Play()
        {
            GameBoard board = new GameBoard(5);

            do
            {
                UI.Refresh(board);
                int row = UI.GetRow();
                int column = UI.GetColumn();
                board.Surface[row, column].IsVisible = true;
                if (board.Surface[row, column].IsSafe)
                    UI.ShowMessage("Whew!");
                else
                    IsOver = true;
            } while (!IsOver);
            UI.Refresh(board);
            UI.ShowMessage("Game Over!!");
            UI.ShowMessage("Thank you for playing Mine Weeper!");
        }
    }
}
