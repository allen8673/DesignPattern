using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Weapon;
using Model.Material;

namespace TemplateMethod
{
    public class SwortManufacture : WeaponManufacture
    {
        public SwortManufacture(IMaterial material)
        {
            base._Material = material;
        }

        public override void Forging(IWeapon weapon)
        {
            weapon.Log.Add("鍛造劍");
        }

        public override IWeapon Mold()
        {
            return new Swort(this._Material);
        }
    }
}
