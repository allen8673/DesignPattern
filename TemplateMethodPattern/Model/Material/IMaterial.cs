using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Material
{
    /// <summary>
    /// 材料
    /// </summary>
    public interface IMaterial
    {
        string Describe { get; }
        int Price { get; }
    }
}
