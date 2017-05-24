using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon
{
    /// <summary>
    /// 武器資料
    /// </summary>
    public interface IWeapon
    {
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

    }
}
