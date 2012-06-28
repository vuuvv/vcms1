using System;
using System.Collections.Generic;

using vuuvv.data.schema;

namespace vuuvv.data.expressions.ddl
{
    public class CreateTable
    {
        public Table Table { get; set; }

        public CreateTable(Table table) 
        {
            Table = table;
        }
    }
}
