using System;
using System.Collections.Generic;
using System.Text;

using vuuvv.data.expressions.ddl;
using vuuvv.data.schema;

namespace vuuvv.data.visitors
{
    public class DDLCompiler : Compiler
    {
        public string visit(CreateSchema ddl)
        {
            return "";
        }

        public string visit(DropSchema ddl)
        {
            return "";
        }

        public string visit(CreateTable ddl)
        {
            Table table = ddl.Table;
            StringBuilder sb = new StringBuilder();
            string pattern = "\r\nCREATE TABLE {0} (\r\n{1}\r\n)";
            foreach (var column in table.Columns.Values)
            {
                sb.Append("\t");
            }
            return pattern;
        }

        public string visit(DropTable ddl)
        {
            return "";
        }

        public string visit(CreateSequence ddl)
        {
            return "";
        }

        public string visit(DropSequence ddl)
        {
            return "";
        }

        public string visit(CreateConstraint ddl)
        {
            return "";
        }

        public string visit(DropConstraint ddl)
        {
            return "";
        }

        public string visit(CreateIndex ddl)
        {
            return "";
        }

        public string visit(DropIndex ddl)
        {
            return "";
        }
    }
}
