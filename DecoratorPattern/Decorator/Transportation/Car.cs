using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Transportation
{
    public class Car : ITransportation
    {
        public string Description { get { return "Car"; } }

        public double Distance { get { return 632.8; } }

        public int PassengerCount { get { return 4; } }

        public double Speed { get { return 120; } }
    }
}
