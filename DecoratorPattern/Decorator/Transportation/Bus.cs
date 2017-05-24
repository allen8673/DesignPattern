using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Transportation
{
    public class Bus : ITransportation
    {
        public string Description { get { return "Bus"; } }

        public double Distance { get { return 732.7; } }

        public int PassengerCount { get { return 35; } }

        public double Speed { get { return 50; } }
    }
}
