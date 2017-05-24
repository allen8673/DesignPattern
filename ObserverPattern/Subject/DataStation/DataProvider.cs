using Subject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject.DataStation
{
    public class DataProvider : PropertyChangedModel<DataProvider>, IDataProvider
    {
        public DataProvider(int t, int p, int h)
        {
            this.Temperature = t;
            this.Pressure = p;
            this.Humidity = h;
        }

        /// <summary>
        /// 氣溫
        /// </summary>
        private int _Temperature;
        public int Temperature
        {
            get { return  base.GetValue<int>(); }
            private set { base.SetValue<int>(value); }
        }

        /// <summary>
        /// 氣壓
        /// </summary>
        private int _Pressure;
        public int Pressure
        {
            get { return base.GetValue<int>(); }
            private set { base.SetValue<int>(value); }
        }

        /// <summary>
        /// 濕度
        /// </summary>
        private int _Humidity;
        public int Humidity
        {
            get { return base.GetValue<int>(); }
            private set { base.SetValue<int>(value); }
        }

        public void ChangeTemperature(int value)
        {
            this.Temperature = value;
        }

        public void ChangePressure(int value)
        {
            this.Pressure = value;
        }

        public void ChangeHumidity(int value)
        {
            this.Humidity = value;
        }
    }
}
