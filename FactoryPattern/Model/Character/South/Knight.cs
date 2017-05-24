using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.South
{
    /// <summary>
    /// 南方騎士
    /// </summary>
    public class Knight : ICharacter
    {
        public string Description
        {
            get { return "南方騎士"; }
        }

        public Profession PRF
        {
            get { return Profession.Knight; }
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
            get { return 6; }
        }

        public int SPD
        {
            get { return 2; }
        }
    }
}
