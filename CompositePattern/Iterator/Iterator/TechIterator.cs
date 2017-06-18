using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 科技葉迭代器: 實作Iterator Pattern
    /// </summary>
    public class TechIterator<T> : IEnumerable<T>
        where T:TechLeaf
    {
        /// <summary>
        /// 紀錄陣列資料
        /// </summary>
        private T[] _Items = new T[] { };

        /// <summary>
        /// 建構式
        /// </summary>
        public TechIterator() { }

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="items"></param>
        public TechIterator(params T[] items)
        {
            _Items = items;
        }

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="items"></param>
        public TechIterator(IEnumerable<T> items)
        {
            _Items = items.ToArray();
        }


        /// <summary>
        /// 新增陣列資料
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            _Items = _Items.Concat(new T[] { item }).ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new TechLeafEnum<T>(_Items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TechLeafEnum<T>(_Items);
        }

        /// <summary>
        /// 複寫Operator
        /// </summary>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static TechIterator<T> operator +(TechIterator<T> items, T item)
        {
            items.Add(item);
            return items;
        }

        /// <summary>
        /// 複寫Operator
        /// </summary>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static TechIterator<T> operator +(T item, TechIterator<T> items)
        {
            items.Add(item);
            return items;
        }

        /// <summary>
        /// 複寫Operator
        /// </summary>
        /// <param name="items1"></param>
        /// <param name="items2"></param>
        /// <returns></returns>
        public static TechIterator<T> operator +(TechIterator<T> items1, TechIterator<T> items2)
        {
            return new TechIterator<T>(items1.Concat(items2));
        }
    }
}
