using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225446_TranDuyNam_Real02_Iterator
{
    public class Collection : IAbstractCollection
    {
        private List<Item> items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
