using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Hit : MoveBase
    {
        public override string Describe { get { return "打擊"; } }

        public override int Injure { get { return 5; } }
    }
}
