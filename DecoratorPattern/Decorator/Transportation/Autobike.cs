using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Transportation
{
    public class Autobike : ITransportation
    {
        public string Description { get { return "Autobike"; } }

        public double Distance { get { return 355.3; } }

        public int PassengerCount { get { return 2; } }

        public double Speed { get { return 80; } }
    }
}
