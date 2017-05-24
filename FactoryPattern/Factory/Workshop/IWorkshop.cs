using Model.Character;
using Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Workshop
{
    interface IWorkshop
    {
        IWeapon BuyWeapon(ICharacter character);
    }
}
