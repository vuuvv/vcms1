using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace vuuvv.data.utils
{
    public interface IOrderedDictionary<TKey, TValue> : IOrderedDictionary, IDictionary<TKey, TValue>
    {
        new int Add(TKey key, TValue value);
        void Insert(int index, TKey key, TValue value);
        new TValue this[int index] { get; set; }
    }

    public class OrderedDictionary<TKey, TValue> : IOrderedDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _dict = new Dictionary<TKey,TValue>();
        private List<TKey> _keys = new List<TKey>();

        IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
        {
            return null;
        }
    }
}
