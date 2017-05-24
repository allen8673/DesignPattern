using Model.Character;
using Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 個體
    /// </summary>
    public class Individual
    {
        public Individual()
        {
            this.Character = new NoneCharacter();
            this.Weapon = new Hand();
        }
        
        /// <summary>
        /// 力量
        /// </summary>
        public int STR
        {
            get { return _STR + Character.ATK + Weapon.ATK; }
            set { this._STR = value; }
        }
        int _STR;

        /// <summary>
        /// 敏捷
        /// </summary>
        public int DEX
        {
            get { return _DEX + Character.SPD + Weapon.SPD; }
            set { this._DEX = value; }
        }
        int _DEX;

        /// <summary>
        /// 靈巧
        /// </summary>
        public int AGI
        {
            get { return _AGI + Character.RNG + Weapon.RNG; }
            set { this._AGI = value; }
        }
        int _AGI;

        /// <summary>
        /// 耐力
        /// </summary>
        public int VIT
        {
            get { return _VIT + Character.DEF + Weapon.DEF; }
            set { this._VIT = value; }
        }
        int _VIT;

        /// <summary>
        /// 角色
        /// </summary>
        public ICharacter Character { get; set; }

        /// <summary>
        /// 武器
        /// </summary>
        public IWeapon Weapon { get; set; }
    }
}
