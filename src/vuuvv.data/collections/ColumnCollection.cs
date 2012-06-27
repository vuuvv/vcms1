using System;
using System.Collections.Generic;

using vuuvv.data.schema;

namespace vuuvv.data.collections
{
    public class ColumnCollection
    {
        private OrderedDictionary<string, Column> _dict = new OrderedDictionary<string, Column>();

        public ColumnCollection() { }

        public int Add(Column column)
        {
            return _dict.Add(column.Key, column);
        }

        public void Insert(int index, Column column) 
        {
            _dict.Insert(index, column.Key, column);
        }

        public int Count
        {
            get
            {
                return _dict.Count;
            }
        }

        public void Clear()
        {
            _dict.Clear();
        }

        public bool ContainsKey(string key)
        {
            return _dict.ContainsKey(key);
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public ICollection<string> Keys
        {
            get { return _dict.Keys; }
        }

        public ICollection<Column> Values
        {
            get
            {
                return _dict.Values;
            }
        }

        public int IndexOfKey(string key)
        {
            return _dict.IndexOfKey(key);
        }

        public bool Remove(string key)
        {
            return _dict.Remove(key);
        }

        public Column this[string key]
        {
            get
            {
                return _dict[key];
            }
            set
            {
                _dict[key] = value;
            }
        }

        public Column this[int index]
        {
            get
            {
                return _dict[index];
            }
        }
    }
}
