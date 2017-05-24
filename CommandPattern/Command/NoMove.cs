using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class NoMove : MoveBase
    {
        public override string Describe { get { return "未設定招式"; } }

        public override int Injure { get { return 0; } }
    }
}
