using System;

namespace InheritanceDemo.GameElements
{
    public class BombCell : AbstractCell
    {
        public BombCell()
        {
            Symbol = '*';
        }
        public override char Symbol { get; protected set; }
        public override bool IsSafe
        {
            get
            {
                return false;
            }
        }
    }
}
