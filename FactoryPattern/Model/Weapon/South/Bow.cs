using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon.South
{
    /// <summary>
    /// 南方弓箭
    /// </summary>
    public class Bow : IWeapon
    {
        public string Description
        {
            get { return "南方弓箭"; }
        }

        public int ATK
        {
            get { return 7; }
        }

        public int DEF
        {
            get { return 2; }
        }

        public int RNG
        {
            get { return 8; }
        }

        public int SPD
        {
            get { return 7; }
        }
    }
}
