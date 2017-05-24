using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public interface ICharacter
    {
        string Describe { get; }

        /// <summary>
        /// 全血量
        /// </summary>
        int FullHP { get; }

        /// <summary>
        /// 當前血量
        /// </summary>
        int CurrentHP { get; }

        /// <summary>
        /// 腳色招式表
        /// </summary>
        IMove[] MoveList { get; }

        
    }
}
