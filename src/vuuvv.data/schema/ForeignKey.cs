using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vuuvv.data.schema
{
    public class ForeignKey : SchemaItem
    {
        public string ColumnSpecification { get; set; }
        public Column Host { get; set; }
        private Column _referent;
        public Column Referent 
        {
            get
            {
                if (_referent == null)
                {
                }
                return _referent;
            }
            set
            {
            }
        }

        public MetaData MetaData
        {
            get
            {
                return Host.Host.Host;
            }
        }

        public ForeignKey(string specification)
        {
            ColumnSpecification = specification;
        }

        public ForeignKey(Column referent)
        {
            _referent = referent;
        }

        public override void SetHost(Column host)
        {
            if (Host != null)
            {
                if (Host == host)
                    return;
                throw new InvalidOperationException("This ForeignKey already has a host");
            }
            Host = host;
            Host.ForeignKeys.Add(this);
        }
    }
}
