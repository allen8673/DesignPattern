using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.North
{
    /// <summary>
    /// 北方盜賊
    /// </summary>
    public class Thieves : ICharacter
    {
        public string Description
        {
            get { return "北方盜賊"; }
        }

        public Profession PRF
        {
            get { return Profession.Thieves; }
        }

        public int ATK
        {
            get { return 4; }
        }

        public int DEF
        {
            get { return 3; }
        }

        public int RNG
        {
            get { return 7; }
        }

        public int SPD
        {
            get { return 10; }
        }
    }
}
