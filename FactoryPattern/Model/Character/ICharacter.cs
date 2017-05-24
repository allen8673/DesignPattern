using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character
{
    /// <summary>
    /// 角色資料
    /// </summary>
    public interface ICharacter
    {
        /// <summary>
        /// 角色敘述
        /// </summary>
        string Description { get; }

        /// <summary>
        /// 攻擊力
        /// </summary>
        int ATK { get; }

        /// <summary>
        /// 防禦力
        /// </summary>
        int DEF { get; }

        /// <summary>
        /// 速度
        /// </summary>
        int SPD { get; }

        /// <summary>
        /// 攻擊範圍
        /// </summary>
        int RNG { get; }

        /// <summary>
        /// 職業
        /// </summary>
        Profession PRF { get; }
    }

    public enum Profession
    {
        /// <summary>
        /// 無職業
        /// </summary>
        None,
        /// <summary>
        /// 劍士
        /// </summary>
        Swordsman,
        /// <summary>
        /// 騎士
        /// </summary>
        Knight,
        /// <summary>
        /// 弓箭手
        /// </summary>
        Archer,
        /// <summary>
        /// 盜賊
        /// </summary>
        Thieves
    }
}
