using Factory.Church;
using Factory.Workshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Village
{
    public class NorthVillage : NoviceVillage
    {
        /// <summary>
        /// 北方新手村建立屬於自己的工廠
        /// </summary>
        protected override void SetBuilding()
        {
            _Church = new NorthChurch();
            _Workshop = new NorthWorkshop();
        }
    }
}
