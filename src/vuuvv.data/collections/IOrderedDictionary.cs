using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace vuuvv.data.collections
{
    public interface IOrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        new int Add(TKey key, TValue value);
        void Insert(int index, TKey key, TValue value);
        TValue this[int index]
        {
            get;
        }
    }
}
