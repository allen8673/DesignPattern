using Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IMove
    {
        /// <summary>
        /// 招式描述
        /// </summary>
        string Describe { get; }

        /// <summary>
        /// 傷害
        /// </summary>
        int Injure { get; }

        /// <summary>
        /// 施放招式
        /// </summary>
        /// <param name="target">對手</param>
        void Cast(IMonster target);
    }
}
