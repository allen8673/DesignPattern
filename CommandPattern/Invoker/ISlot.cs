using Command;
using Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoker
{
    public interface ISlot
    {
        /// <summary>
        /// 招式插槽
        /// </summary>
        IMove[] Moves { get; }

        /// <summary>
        /// 設定招式
        /// </summary>
        /// <param name="moveIndex"></param>
        /// <param name="move"></param>
        void SetMovesSlot(int slotIndex, IMove move);
    }
}
