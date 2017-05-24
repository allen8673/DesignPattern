using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character.North
{
    /// <summary>
    /// 北方弓箭手
    /// </summary>
    public class Archer : ICharacter
    {
        public string Description
        {
            get { return "北方弓箭手"; }
        }

        public Profession PRF
        {
            get { return Profession.Archer; }
        }

        public int ATK
        {
            get { return 5; }
        }

        public int DEF
        {
            get { return 4; }
        }

        public int RNG
        {
            get { return 10; }
        }

        public int SPD
        {
            get { return 8; }
        }

        
    }
}
