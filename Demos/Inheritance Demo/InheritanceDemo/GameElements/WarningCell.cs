using System;

namespace InheritanceDemo.GameElements
{
    public class WarningCell : AbstractCell
    {
        public WarningCell()
        {
            Symbol = '!';
        }
        public override char Symbol { get; protected set; }
    }
}
