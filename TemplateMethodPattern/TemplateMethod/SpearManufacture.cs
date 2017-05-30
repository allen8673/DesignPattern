using Model.Material;
using Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SpearManufacture : WeaponManufacture
    {
        public SpearManufacture(IMaterial material)
        {
            base._Material = material;
        }

        public override void Forging(IWeapon weapon)
        {
            weapon.Log.Add("鍛造槍");
        }

        public override IWeapon Mold()
        {
            return new Spear(this._Material);
        }
    }
}
