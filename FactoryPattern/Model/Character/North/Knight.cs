using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.North
{
    /// <summary>
    /// 北方騎士
    /// </summary>
    public class Knight : ICharacter
    {
        public string Description
        {
            get { return "北方騎士"; }
        }

        public Profession PRF
        {
            get { return Profession.Knight; }
        }

        public int ATK
        {
            get { return 5; }
        }

        public int DEF
        {
            get { return 8; }
        }

        public int RNG
        {
            get { return  6; }
        }

        public int SPD
        {
            get { return 2; }
        }
    }
}
