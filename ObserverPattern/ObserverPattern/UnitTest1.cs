using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Subject.DataStation;
using Subject.Interface;
using Subject;
using Observer;

namespace ObserverPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTest()
        {
            IDataProvider dataProvider = new DataProvider(32, 102, 30);

            ISubject subject = new WeatherData(dataProvider);

            IOberserver o1 = new Observer1();
            IOberserver o2 = new Observer2();
            IOberserver o3 = new Observer3();

            subject.RegisterObserver(o1);
            subject.RegisterObserver(o2);
            subject.RegisterObserver(o3);

            dataProvider.ChangeTemperature(36);
            dataProvider.ChangePressure(110);
            dataProvider.ChangeTemperature(80);

            subject.RemoveObserver(o3);


            dataProvider.ChangeTemperature(31);
        }
    }
}
