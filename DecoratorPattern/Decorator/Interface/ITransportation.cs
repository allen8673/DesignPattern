using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Interface
{
    public interface ITransportation
    {
        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; }

        /// <summary>
        /// 平均速度
        /// </summary>
        double Speed { get; }

        /// <summary>
        /// 平均滿油可行駛距離
        /// </summary>
        double Distance { get; }

        /// <summary>
        /// 載客人數
        /// </summary>
        int PassengerCount { get; }
        
    }
}
