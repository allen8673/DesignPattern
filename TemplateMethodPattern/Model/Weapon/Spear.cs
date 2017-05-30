using Model.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon
{
    public class Spear : IWeapon
    {
        public Spear(IMaterial material)
        {
            this.Material = material;
            this.Log = new List<string>();
        }

        public int ATK { get { return 40; } }

        public int DEF { get { return 20; } }

        public int DUR { get { return 40; } }

        public List<string> Log { get; private set; }

        public IMaterial Material {  get; private set; }
    }
}
