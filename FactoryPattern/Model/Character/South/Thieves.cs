using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.South
{
    /// <summary>
    /// 南方盜賊
    /// </summary>

    public class Thieves : ICharacter
    {
        public string Description
        {
            get { return "南方盜賊"; }
        }

        public Profession PRF
        {
            get { return Profession.Thieves; }
        }

        public int ATK
        {
            get { return 6; }
        }

        public int DEF
        {
            get { return 3; }
        }

        public int RNG
        {
            get { return 6; }
        }

        public int SPD
        {
            get { return 9; }
        }
    }
}
