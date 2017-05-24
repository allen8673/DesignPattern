using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class HeavyCut : MoveBase
    {
        public override string Describe { get { return "重砍擊"; } }

        public override int Injure { get { return 9; } }
    }
}
