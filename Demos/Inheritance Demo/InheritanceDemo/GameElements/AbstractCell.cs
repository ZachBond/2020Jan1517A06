using System;

namespace InheritanceDemo.GameElements
{
    public abstract class AbstractCell
    {
        public bool IsVisible { get; set; }
        public abstract char Symbol { get; protected set; }
        public virtual bool IsSafe {
            get
            {
                return true;
            }
        }
    }
}