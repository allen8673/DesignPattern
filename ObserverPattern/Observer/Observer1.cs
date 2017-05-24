using Subject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer1 : IOberserver
    {
        public int Temperature { get; private set; }
        public int Pressure { get; private set; }
        public int Humidity { get; private set; }
        public void Update(int temperature, int pressure, int humidity)
        {
            this.Temperature = temperature;
            this.Pressure = pressure;
            this.Humidity = humidity;
        }
    }
}
