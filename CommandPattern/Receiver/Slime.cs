using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    public class Slime : IMonster
    {
        public Slime()
        {
            _CurrentHP = FullHP;
        }

        public string Describe { get { return "史萊姆"; } }
        public int FullHP { get { return 120; } }

        private int _CurrentHP;
        public int CurrentHP
        {
            get
            {
                return _CurrentHP;
            }
            set
            {
                _CurrentHP = value;
            }
        }

    }
}
