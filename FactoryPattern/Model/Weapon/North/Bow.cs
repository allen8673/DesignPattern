using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon.North
{
    /// <summary>
    /// 北方弓箭
    /// </summary>
    public class Bow : IWeapon
    {
        public string Description
        {
            get { return "北方弓箭"; }
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
            get { return 10; }
        }

        public int SPD
        {
            get { return 7; }
        }
    }
}
