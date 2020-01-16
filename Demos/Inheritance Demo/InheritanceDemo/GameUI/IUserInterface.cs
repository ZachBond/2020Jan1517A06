using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceDemo.GameUI
{
    public interface IUserInterface
    {
        void Refresh(GameElements.GameBoard board);
        void ShowMessage(string message);
        int GetRow();
        int GetColumn();
    }
}
