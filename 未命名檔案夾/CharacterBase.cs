using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public abstract class CharacterBase : ICharacter
    {
        public abstract string Describe { get; }
        public abstract int CurrentHP { get; internal set; }
        public abstract int FullHP { get; }
        public abstract IMove[] MoveList { get; }
    }
}
