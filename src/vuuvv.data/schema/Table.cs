using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using vuuvv.data.collections;

namespace vuuvv.data.schema
{
    public class Table : SchemaItem
    {
        public string Name { get; set; }
        public MetaData MetaData { get; set; }
        private List<Column> _columns = new List<Column>();
        public List<Column> Columns 
        { 
            get { return _columns; } 
        }
        private List<ForeignKey> _foreignkeys = new List<ForeignKey>();
        public List<ForeignKey> ForeignKeys 
        {
            get { return _foreignkeys; }
        }
        private List<Index> _indexes = new List<Index>();
        public List<Index> Indexes 
        {
            get { return _indexes; }
        }
        private List<Constraint> _constraints = new List<Constraint>();
        public List<Constraint> Constraints 
        {
            get { return _constraints; }
        }

        public Table(string name, MetaData metadata, params SchemaItem[] items)
        {
            Name = name;
            MetaData = metadata;
            foreach (var item in items)
            {
                item.SetParent(this);
            }
        }

        public override void SetParent(MetaData parent)
        {
            MetaData = parent;
            parent.Tables.Add(Name, this);
        }

        public void Append(Column column)
        {
            column.SetParent(this);
        }

        public void Append(Constraint constraint)
        {
            constraint.SetParent(constraint);
        }
    }
}
