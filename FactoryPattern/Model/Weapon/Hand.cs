using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon
{
    /// <summary>
    /// 赤手空拳
    /// </summary>
    public class Hand : IWeapon
    {
        public string Description
        {
            get { return "赤手空拳"; }
        }

        public int ATK
        {
            get { return 0; }
        }

        public int DEF
        {
            get { return 0; }
        }

        public int RNG
        {
            get { return 0; }
        }

        public int SPD
        {
            get { return 0; }
        }
    }
}
