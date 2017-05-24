using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character
{
    public class NoneCharacter : ICharacter
    {
        public string Description
        {
            get { return "無職業"; }
        }

        public Profession PRF
        {
            get { return Profession.None; }
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
