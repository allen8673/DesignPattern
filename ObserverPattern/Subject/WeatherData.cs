using Subject.DataStation;
using Subject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    public class WeatherData : ISubject
    {
        private IDataProvider Provider;
        private List<IOberserver> Oberservers;

        public WeatherData(IDataProvider provider)
        {
            Oberservers = new List<IOberserver>();
            Provider = provider;
            Provider.Register(ProviderDataChanged);
        }

        private void ProviderDataChanged(object sender, EventArgs e)
        {
            this.NotifyObserver();
        }

        public void NotifyObserver()
        {
            Oberservers.ForEach(o =>
            {
                o.Update(Provider.Temperature, Provider.Pressure, Provider.Humidity);
            });
        }

        public void RegisterObserver(IOberserver o)
        {
            Oberservers.Add(o);
        }

        public void RemoveObserver(IOberserver o)
        {
            Oberservers.Remove(o);

        }
    }
}
