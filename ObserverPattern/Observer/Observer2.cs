using Subject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer2 : IOberserver
    {
        public string Display { get; private set; }
        public void Update(int temperature, int pressure, int humidity)
        {
            this.Display = $"{temperature}/{pressure}/{humidity}";
        }
    }
}
