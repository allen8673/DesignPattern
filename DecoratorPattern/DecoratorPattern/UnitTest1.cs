using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator.Interface;
using Decorator.Transportation;
using Decorator.Equipment;

namespace DecoratorPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IEquipment engin = new Engine();
            ITransportation car = new Car();
            ITransportation rv = new RV();

            engin.Load(car);
            engin.Load(rv);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ITransportation car = new Car();
            IEquipment engine = new Engine();
            IEquipment tank = new Tank();

            engine.Load(car);
            tank.Load(engine);

            ITransportation rv = new RV();
            engine.Load(rv);
        }
    }
}
