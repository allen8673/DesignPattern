using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command;

namespace Invoker
{
    public class MoveSlot : ISlot
    {
        public MoveSlot()
        {
            _Moves = new IMove[4] { new NoMove(), new NoMove(), new NoMove(), new NoMove() };
        }

        private IMove[] _Moves;
        public IMove[] Moves
        {
            get
            {
                return _Moves;
            }
        }

        public void SetMovesSlot(int slotIndex, IMove move)
        {
            _Moves[slotIndex] = move;
        }


    }
}
