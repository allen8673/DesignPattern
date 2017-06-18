using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;
using Iterator;

namespace CompositePattern
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            //物件國科技樹
            TechTree techTree = new TechTree
            {
                Root = new TechItem(new TechIterator<TechComposite>
                {
                    new TechItem(new TechIterator<TechComposite> {
                        new TechItem() { TechName = "銅器", DevelopePoint = 30 } ,
                        new TechItem() { TechName = "青銅器", DevelopePoint = 40 } ,
                        new TechItem() { TechName = "鐵器", DevelopePoint = 50 }
                    }) { TechName = "金屬具", TechPoint = 300, DevelopePoint = 50 } ,
                    new TechItem(new TechIterator<TechComposite> {
                        new TechItem() { TechName = "民宅", DevelopePoint = 30 },
                        new TechItem() { TechName = "城牆", DevelopePoint = 40 },
                        new TechItem() { TechName = "城鎮中心", DevelopePoint = 50 }
                    }) { TechName = "建築", TechPoint = 300, DevelopePoint = 50 , Useable = true} ,
                    new TechItem(new TechIterator<TechComposite> {
                        new TechItem() { TechName = "稻田", DevelopePoint = 30 },
                        new TechItem() { TechName = "果園", DevelopePoint = 40 },
                        new TechItem() { TechName = "牧場", DevelopePoint = 50 },
                    }) { TechName = "農業", TechPoint = 300, DevelopePoint = 50 } ,
                    new TechGroup(new TechIterator<TechComposite> {
                        new TechItem() { TechName = "步兵", DevelopePoint = 30 } ,
                        new TechItem() { TechName = "騎兵", DevelopePoint = 50 } ,
                        new TechItem() { TechName = "弓兵", DevelopePoint = 40 } ,
                    }) {  TechName = "軍事"}
                })
                { TechName = "科技種子", TechPoint = 300, DevelopePoint = 0, Useable = true, }
            };

            string tree = techTree.Root.ShowTechTree();
        }
    }

    /// <summary>
    /// 科技術
    /// </summary>
    class TechTree
    {
        public TechItem Root { get; set; }
    }
}
