using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225446_TranDuynam_Pattern02_Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private List<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Get item count
        public int Count
        {
            get { return items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
