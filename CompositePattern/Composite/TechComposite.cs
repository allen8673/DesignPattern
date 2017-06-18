using Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 科技葉合成: 實作合成模式
    /// </summary>
    public abstract class TechComposite : TechLeaf
    {
        /// <summary>
        /// 是否為科技葉節點:
        /// 合成模式基礎型別會同時是【葉節點(Leaf Node)】以及【合成節點(Composite Node)】共同的基礎型別
        /// </summary>
        public abstract bool IsTechLeaf { get; }

        /// <summary>
        /// 可發展科技
        /// </summary>
        public abstract TechIterator<TechComposite> DevelopableTech { get; }

        /// <summary>
        /// 發展科技
        /// </summary>
        /// <param name="tech"></param>
        public abstract void DevelopeTech(TechLeaf tech);

        /// <summary>
        /// 允許使用科技
        /// </summary>
        public void UseableTech(TechComposite parantTech)
        {
            if (Useable || parantTech.TechPoint < this.DevelopePoint) return;

            parantTech.TechPoint -= this.DevelopePoint;
            Useable = true;
        }

        public string ShowTechTree(string index = "1")
        {
            StringBuilder strBuilder = new StringBuilder();

            int subIndex = 0;
            string indexStr;
            foreach (var item in DevelopableTech)
            {
                indexStr = this.IsTechLeaf ? $"{index}.{++subIndex}" : $"{index}" ;

                if (item.IsTechLeaf)
                    strBuilder.AppendLine($"{(item.Useable ? "" : "【未演進】")} {indexStr} {item.TechName}");

                strBuilder.AppendLine($"{item.ShowTechTree(indexStr)}");

            }

            return strBuilder.ToString();
        }

    }
}
