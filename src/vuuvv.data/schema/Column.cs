using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vuuvv.data.schema
{
    public class Column : SchemaItem
    {
        public Table Host { get; set; }
        public string Name { get; set; }
        public object Type { get; set; }
        public bool AutoIncrement { get; set; }
        public object Default { get; set; }
        public string Key { get; set; }
        public bool Index { get; set; }
        public bool Nullable { get; set; }
        public bool PrimaryKey { get; set; }
        public bool Unique { get; set; }

        private List<Constraint> _constraints = new List<Constraint>();
        public List<Constraint> Constraints
        {
            get { return _constraints; }
        }
        private List<ForeignKey> _foreignkeys = new List<ForeignKey>();
        public List<ForeignKey> ForeignKeys
        {
            get { return _foreignkeys; }
        }

        public Column(string name, object type)
        {
            Name = name;
            Type = type;
        }

        public Column(string name, ForeignKey fk)
        {
            Name = name;
            fk.SetHost(this);
        }

        public override void SetHost(Table table)
        {
            if (Name == null)
            {
                throw new ArgumentException("Column must be constructed with a non-blank name or assign a no-blank .name before adding to a Table.");
            }

            if (Key == null)
            {
                Key = Name;
            }

            if (Host == null)
            {
                throw new ArgumentException(string.Format(
                    "Column object already assigned to Table {0}", Host.Name));
            }
        }
    }
}