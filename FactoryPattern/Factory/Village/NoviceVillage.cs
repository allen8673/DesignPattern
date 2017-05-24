using Factory.Church;
using Factory.Workshop;
using Model;
using Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Village
{
    /// <summary>
    /// 新手村
    /// </summary>
    public abstract class NoviceVillage
    {
        internal IChurch _Church;
        internal IWorkshop _Workshop;

        /// <summary>
        /// 不同的新手村要有屬於自己的教堂(職業工廠)和工坊(武器工廠)
        /// </summary>
        protected abstract void SetBuilding();

        public NoviceVillage()
        {
            SetBuilding();
        }

        /// <summary>
        /// 個體可以透過方法選擇陣營和職業
        /// </summary>
        /// <param name="player"></param>
        /// <param name="profession"></param>
        public void Register(Individual player, Profession profession)
        {
            this.ChoiseProfession(player, profession);
            this.LoadWeapon(player);

        }

        /// <summary>
        /// 選擇職業
        /// </summary>
        /// <param name="player"></param>
        /// <param name="profession"></param>
        /// <returns></returns>
        protected void ChoiseProfession(Individual player, Profession profession)
        {
            //個體透過教堂(職業工廠)產生職業
            player.Character = _Church.ChoiseProfession(profession);
        }

        /// <summary>
        /// 裝備武器
        /// </summary>
        /// <param name="player"></param>
        protected void LoadWeapon(Individual player)
        {
            //個體透過工坊(武器工廠)取得相對自己職業的武器
            player.Weapon = _Workshop.BuyWeapon(player.Character);
        }
    }
}
