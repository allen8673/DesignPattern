using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Character;
using Model.Character.North;

namespace Factory.Church
{
    class NorthChurch : BaseChurch
    {
        /// <summary>
        /// 北方教堂應該有屬於自己的角色清單
        /// </summary>
        /// <returns></returns>
        protected override Dictionary<Profession, ICharacter> GetCharacterList()
        {
            return new Dictionary<Profession, ICharacter>
            {
                { Profession.None, new NoneCharacter() },
                { Profession.Swordsman, new Swordsman() },
                { Profession.Knight, new Knight() },
                { Profession.Archer, new Archer() },
                { Profession.Thieves, new Thieves() },
            };
        }
    }
}
