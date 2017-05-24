using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Character;
using Model.Weapon;
using Model.Weapon.North;

namespace Factory.Workshop
{
    /// <summary>
    /// 北方工坊應該有屬於自己的武器清單
    /// </summary>
    class NorthWorkshop : BaseWorkshop
    {
        protected override Dictionary<Profession, IWeapon> GetWeaponList()
        {
            return new Dictionary<Profession, IWeapon>
            {
                { Profession.None, new Hand()},
                { Profession.Swordsman, new Sword()},
                { Profession.Knight, new Spear()},
                { Profession.Archer, new Bow()},
                { Profession.Thieves, new Dagger()},
            };
        }
    }
}
