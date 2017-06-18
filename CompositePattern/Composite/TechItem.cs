using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator;

namespace Composite
{
    /// <summary>
    /// 單一科技
    /// </summary>
    public class TechItem : TechComposite
    {

        private TechIterator<TechComposite> _DevelopableTech = new TechIterator<TechComposite>();

        public TechItem() { }

        public TechItem(TechIterator<TechComposite> developableTech)
        {
            _DevelopableTech = new TechIterator<TechComposite>(
                                   developableTech.Where(i => i.IsTechLeaf)
                                   .Concat(developableTech
                                           .Where(i => !i.IsTechLeaf)
                                           .Select(i => new TechGroup(this, i.DevelopableTech))));
        }


        public void AddDevelopableTech(TechComposite tech)
        {
            _DevelopableTech.Add(tech);
        }

        public TechComposite GetDevelopableTech(string techName)
        {
            return _DevelopableTech.FirstOrDefault(i => i.TechName == techName);
        }

        public override TechIterator<TechComposite> DevelopableTech { get { return _DevelopableTech; } }

        public override bool IsTechLeaf { get { return true; } }

        /// <summary>
        /// 可以發展的科技
        /// </summary>
        /// <param name="tech"></param>
        public override void DevelopeTech(TechLeaf tech)
        {
            if (!this.Useable
                || !_DevelopableTech.Any(i => i == tech)
                || this.TechPoint < tech.DevelopePoint) return;

            _DevelopableTech.First(i => i == tech).UseableTech(this);
            this.TechPoint -= tech.DevelopePoint;
        }
    }
}
