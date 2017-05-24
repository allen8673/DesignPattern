using Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Church
{
    interface IChurch
    {
        ICharacter ChoiseProfession(Profession profession);
    }
}
