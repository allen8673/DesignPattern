using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Equipment
{
    public class Interior : IEquipment
    {
        public ITransportation Transportation { get; private set; }
        public string Description { get { return $"{this.Transportation?.Description} Load Interior"; } }
        public double Distance { get { return this.Transportation?.Distance - 5 ?? 0; } }
        public int PassengerCount { get { return this.Transportation?.PassengerCount + 3 ?? 0; } }
        public double Speed { get { return this.Transportation?.Speed ?? 0; } }

        void IEquipment.Load(ITransportation transportation)
        {
            this.Transportation = transportation;
            transportation = this;
        }
    }
}
