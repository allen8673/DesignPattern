using Model.Material;
using Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 武器製作方法(樣板方法)
    /// </summary>
    public abstract class WeaponManufacture
    {
        protected IMaterial _Material { get; set; }

        public IWeapon Manufacture()
        {
            this.PrepareFurnace();
            IWeapon weapon = this.Mold();
            this.Forging(weapon);
            this.Polishing(weapon);
            this.ManufactureEnding(weapon);

            return weapon;
        }

        /// <summary>
        /// 準備熔爐
        /// </summary>
        public void PrepareFurnace()
        {
            Console.WriteLine("開爐");
        }

        /// <summary>
        /// 開模
        /// </summary>
        public abstract IWeapon Mold();

        /// <summary>
        /// 鍛造
        /// </summary>
        public abstract void Forging(IWeapon weapon);

        /// <summary>
        /// 拋光
        /// </summary>
        public void Polishing(IWeapon weapon)
        {
            weapon.Log.Add("拋光");
        }

        /// <summary>
        /// 鍛造收尾(Hook method)
        /// </summary>
        public virtual void ManufactureEnding(IWeapon weapon)
        {
        }
    }
}
