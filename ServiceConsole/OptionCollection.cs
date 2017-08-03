using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ServiceConsole
{
    class OptionCollection: IEnumerable<IOption>
    {
        List<IOption> items = new List<IOption>();

        public bool Add(IOption item)
        {
            if (!items.Exists(x => x.Key.Equals(item.Key)))
            {
                items.Add(item);
            }
            return false;
        }

        public void Clear()
        {
            items.Clear();
        }

        public IEnumerator<IOption> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)items).GetEnumerator();
        }
    }
}
