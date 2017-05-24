using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon.South
{
    /// <summary>
    /// 南方槍
    /// </summary>
    public class Spear : IWeapon
    {
        public string Description
        {
            get { return "南方槍"; }
        }

        public int ATK
        {
            get { return 7; }
        }

        public int DEF
        {
            get { return 9; }
        }

        public int RNG
        {
            get { return 7; }
        }

        public int SPD
        {
            get { return 4; }
        }
    }
}
