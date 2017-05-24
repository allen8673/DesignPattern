using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Transportation
{
    public class RV : ITransportation
    {
        public string Description { get { return "RV"; } }

        public double Distance { get { return 708.3; } }

        public int PassengerCount { get { return 6; } }

        public double Speed { get { return 100; } }
    }
}
