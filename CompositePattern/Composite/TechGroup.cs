using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator;

namespace Composite
{
    /// <summary>
    /// 科技群組
    /// </summary>
    public class TechGroup : TechComposite
    {
        private TechIterator<TechComposite> _DevelopableTech = new TechIterator<TechComposite>();
        private TechComposite _OwnerTech;

        public TechGroup(TechComposite owner, TechIterator<TechComposite> list)
        {
            _OwnerTech = owner;
            _DevelopableTech = list;
        }

        public TechGroup(TechIterator<TechComposite> list)
        {
            _DevelopableTech = list;
        }


        public override TechIterator<TechComposite> DevelopableTech
        {
            get
            {
                return _DevelopableTech;
            }
        }

        public override bool IsTechLeaf { get { return false; } }


        public override void DevelopeTech(TechLeaf tech)
        {
            if (!this.Useable 
                || this.TechPoint < _DevelopableTech.Sum(i => i.DevelopePoint) 
                || !_DevelopableTech.Any(i => i == tech)) return;

            foreach (var item in _DevelopableTech)
            {
                item.UseableTech(_OwnerTech);
            }
        }
    }
}
