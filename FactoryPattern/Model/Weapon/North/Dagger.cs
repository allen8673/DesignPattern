using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon.North
{
    /// <summary>
    /// 北方匕首
    /// </summary>
    public class Dagger : IWeapon
    {
        public string Description
        {
            get { return "北方匕首"; }
        }

        public int ATK
        {
            get { return 5; }
        }

        public int DEF
        {
            get { return 2; }
        }

        public int RNG
        {
            get { return 3; }
        }

        public int SPD
        {
            get { return 10; }
        }
    }
}
