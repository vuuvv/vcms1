using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vuuvv.data.schema
{
    public abstract class SchemaItem
    {
        public virtual void SetHost(MetaData parent)
        {
            throw new NotImplementedException();
        }
        public virtual void SetHost(Table parent) 
        {
            throw new NotImplementedException();
        }
        public virtual void SetHost(Column parent)
        {
            throw new NotImplementedException();
        }

        public void SetParent(SchemaItem parent)
        {
            Type type = parent.GetType();
            if (type == typeof(MetaData))
                SetHost(parent as MetaData);
            else if (type == typeof(Table))
                SetHost(parent as Table);
            else if (type == typeof(Column))
                SetHost(parent as Column);
            else
                throw new ArgumentException("Argument parent's type should be one of [MetaData, Table, Column]");
        }
    }
}
