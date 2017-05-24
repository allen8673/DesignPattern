using Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class MoveBase : IMove
    {
        internal MoveBase() { }

        public abstract string Describe { get; }

        public abstract int Injure { get; }

        public void Cast(IMonster target)
        {
            target.CurrentHP -= Injure;
        }
    }
}
