using Model.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Weapon
{
    /// <summary>
    /// 武器
    /// </summary>
    public interface IWeapon
    {
        /// <summary>
        /// 攻擊力
        /// </summary>
        int ATK { get; }

        /// <summary>
        /// 防禦力
        /// </summary>
        int DEF { get; }

        /// <summary>
        /// 耐久度
        /// </summary>
        int DUR { get; }

        /// <summary>
        /// 製作過程備註
        /// </summary>
        List<string> Log { get; }

        IMaterial Material { get; }
    }
}
