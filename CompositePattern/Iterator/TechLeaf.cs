using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 科技資訊
    /// </summary>
    public abstract class TechLeaf
    {
        /// <summary>
        /// 科技名
        /// </summary>
        public string TechName { get; set; }

        /// <summary>
        /// 科技點
        /// </summary>
        public int TechPoint { get; set; }

        /// <summary>
        /// 開發點數
        /// </summary>
        public int DevelopePoint { get; set; }

        /// <summary>
        /// 可以使用
        /// </summary>
        public bool Useable { get; set; }
    }
}
