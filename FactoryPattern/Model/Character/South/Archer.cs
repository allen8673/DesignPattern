using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.South
{
    /// <summary>
    /// 南方弓箭手
    /// </summary>
    public class Archer : ICharacter
    {
        public string Description
        {
            get { return "南方弓箭手"; }
        }

        public Profession PRF
        {
            get { return Profession.Archer; }
        }

        public int ATK
        {
            get { return 6; }
        }

        public int DEF
        {
            get { return 6; }
        }

        public int RNG
        {
            get { return 8; }
        }

        public int SPD
        {
            get { return 6; }
        }
    }
}
