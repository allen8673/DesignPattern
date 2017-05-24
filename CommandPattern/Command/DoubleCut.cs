using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DoubleCut : MoveBase
    {
        public override string Describe { get { return "雙重砍擊"; } }

        public override int Injure { get { return 6; } }
    }
}
