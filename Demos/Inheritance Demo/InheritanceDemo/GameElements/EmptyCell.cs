using System;

namespace InheritanceDemo.GameElements
{
    public class EmptyCell : AbstractCell
    {
        public EmptyCell()
        {
            Symbol = '.';
        }
        public override char Symbol { get; protected set; }
    }
}
