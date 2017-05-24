using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Character;
using Model.Character.South;

namespace Factory.Church
{
    /// <summary>
    /// 南方教堂應該有屬於自己的角色清單
    /// </summary>
    class SouthChurch : BaseChurch
    {
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
