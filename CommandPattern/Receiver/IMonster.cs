using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    public interface IMonster
    {
        string Describe { get; }

        /// <summary>
        /// 全血量
        /// </summary>
        int FullHP { get; }

        /// <summary>
        /// 當前血量
        /// </summary>
        int CurrentHP { get; set; }
    }
}
