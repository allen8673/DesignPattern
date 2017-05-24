using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon.South
{
    /// <summary>
    /// 南方劍
    /// </summary>
    public class Sword : IWeapon
    {
        public string Description
        {
            get { return "南方劍"; }
        }

        public int ATK
        {
            get { return 7; }
        }

        public int DEF
        {
            get { return 6; }
        }

        public int RNG
        {
            get { return 7; }
        }

        public int SPD
        {
            get { return 7; }
        }
    }
}
