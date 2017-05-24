using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.North
{
    /// <summary>
    /// 北方劍士
    /// </summary>
    public class Swordsman : ICharacter
    {
        public string Description
        {
            get { return "北方劍士"; }
        }

        public Profession PRF
        {
            get { return Profession.Swordsman; }
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
            get { return 7; }
        }

        public int SPD
        {
            get { return 7; }
        }
    }
}
