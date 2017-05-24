using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Invoker;
using Receiver;

namespace CommandPattern
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 實現角色(client) & 角色附有招式(Command)
            Knight knight = new Knight();
            Swordsman swordsman = new Swordsman();

            // 實現招式插槽(Invoker)
            ISlot moveSlot = new MoveSlot();

            // 實現怪物(Receiver)
            IMonster monster = new Slime();

            // 注入招式(Command)至招式插槽(Invoker)
            moveSlot.SetMovesSlot(1, knight.MoveList[2]);
            moveSlot.SetMovesSlot(3, swordsman.MoveList[1]);

            // 透過招式插槽(Invoker)打擊怪物(Receiver)
            moveSlot.Moves[0].Cast(monster);
            moveSlot.Moves[1].Cast(monster);
        }
    }
}
