using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Interface
{
    public interface IEquipment : ITransportation
    {
        /// <summary>
        /// 改裝交通工具
        /// </summary>
        ITransportation Transportation { get; }

        /// <summary>
        /// 改裝配備
        /// </summary>
        /// <returns></returns>
        void Load(ITransportation transportation);

    }
}
