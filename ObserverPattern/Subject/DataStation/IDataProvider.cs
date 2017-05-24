using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject.DataStation
{
    public interface IDataProvider
    {
        void Register(Action<object, EventArgs> act);
        int Temperature { get; }
        int Pressure { get; }
        int Humidity { get; }

        void ChangeTemperature(int value);
        void ChangePressure(int value);
        void ChangeHumidity(int value);


    }
}
