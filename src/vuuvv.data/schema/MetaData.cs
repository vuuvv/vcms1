using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vuuvv.data.schema
{
    public class MetaData : SchemaItem
    {
        private Dictionary<string, Table> _tables = new Dictionary<string,Table>(); 
        public Dictionary<string, Table> Tables 
        {
            get { return _tables; }
        }

        public void AddTable(Table table)
        {
            _tables.Add(table.Name, table);
        }
    }
}
