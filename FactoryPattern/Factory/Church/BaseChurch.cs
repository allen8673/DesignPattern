using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Character;

namespace Factory.Church
{
    /// <summary>
    /// 所有教堂都會做的事
    /// </summary>
    abstract class BaseChurch: IChurch
    {
        /// <summary>
        /// 不同的教堂應該要設計屬於自己的角色清單
        /// </summary>
        /// <returns></returns>
        protected abstract Dictionary<Profession, ICharacter> GetCharacterList();

        /// <summary>
        /// 選擇角色
        /// </summary>
        /// <param name="profession"></param>
        /// <returns></returns>
        public ICharacter ChoiseProfession(Profession profession)
        {
            ICharacter character = GetCharacterList()[profession];
            this.Training();
            return character;
        }

        /// <summary>
        /// 訓練角色
        /// </summary>
        protected void Training()
        {
            Console.WriteLine("訓練中...");
        }
    }
}
