using Model.Character;
using Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Workshop
{
    /// <summary>
    /// 所有工坊都會做的事
    /// </summary>
    abstract class BaseWorkshop : IWorkshop
    {
        /// <summary>
        /// 不同的工坊應該要設計屬於自己的武器清單
        /// </summary>
        /// <returns></returns>
        protected abstract Dictionary<Profession, IWeapon> GetWeaponList();

        /// <summary>
        /// 購買武器
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public IWeapon BuyWeapon(ICharacter character)
        {
            IWeapon weapon = GetWeaponList()[character.PRF];
            this.Forging();
            return weapon;
        }

        /// <summary>
        /// 鍛造武器
        /// </summary>
        protected void Forging()
        {
            Console.WriteLine("武器鍛造中...");
        }
    }
}
