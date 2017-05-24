using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Character;
using Factory.Village;
using Model;

namespace FactoryPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //建立南北新手村
            NoviceVillage southVillage = new SouthVillage();
            NoviceVillage northVillage = new NorthVillage();

            //新增個體
            Individual player_1 = new Individual
            {
                AGI = 5,
                DEX = 5,
                STR = 8,
                VIT = 6
            };

            Individual player_2 = new Individual
            {
                AGI = 7,
                DEX = 7,
                STR = 5,
                VIT = 4
            };

            //Factory Pattern
            //player_1歸屬南方 成為劍士
            southVillage.Register(player_1, Profession.Swordsman);
            //player_2歸屬北方 成為弓箭手
            northVillage.Register(player_2, Profession.Archer);
        }
    }
}
