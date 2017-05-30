using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Material;
using Model.Weapon;
using TemplateMethod;

namespace TemplateMethodPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IMaterial material1 = new Iron();
            IWeapon weapon1 = new SwortManufacture(material1).Manufacture();

            IMaterial material2 = new Copper();
            IWeapon weapon2 = new SwortManufacture(material2).Manufacture();
        }
    }
}
