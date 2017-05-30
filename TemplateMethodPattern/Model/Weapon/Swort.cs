using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Material;

namespace Model.Weapon
{
    public class Swort : IWeapon
    {
        public Swort(IMaterial material)
        {
            this.Material = material;
            this.Log = new List<string>();
        }

        public int ATK { get { return 30; } }

        public int DEF { get { return 25; } }

        public int DUR { get { return 45; } }

        public List<string> Log { get; private set; }

        public IMaterial Material { get; private set; }
    }
}
