using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Swordsman : CharacterBase
    {
        public Swordsman()
        {
            _CurrentHP = FullHP;
        }

        public override string Describe { get { return "劍士"; } }

        public override int FullHP { get { return 120; } }

        private int _CurrentHP;
        public override int CurrentHP
        {
            get
            {
                return _CurrentHP;
            }
            internal set
            {
                _CurrentHP = value;
            }
        }

        public override IMove[] MoveList
        {
            get
            {
                return new IMove[] {
                    new Cut(),
                    new HeavyCut(),
                    new Hit(),
                    new Stab()
                };
            }
        }


    }
}
