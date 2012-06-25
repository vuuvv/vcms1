using System;
using System.IO;
using System.Data;
using System.Web;
using System.Data.Common;
using System.Data.SQLite;
using System.Runtime.Remoting.Messaging;

namespace vuuvv.data
{
    public class DBHepler
    {
        public static string dbpath = "App_Data/cms.db";

        private const string TRANSACTION_KEY = "CONTEXT_TRANSACTION";
        private const string CONNECTION_KEY = "CONTEXT_CONNECTION";

        private static DbProviderFactory _factory;
        private static DbProviderFactory factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = DbProviderFactories.GetFactory("System.Data.SQLite");
                }
                return _factory;
            }
        }

        public static DbConnection connection
        {
            get
            {
                var conn = context_connection;
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    conn = factory.CreateConnection();
                    conn.ConnectionString = string.Format("Data Source={0}", dbpath);
                    conn.Open();
                }
                return conn;
            }
        }

        private static DbConnection context_connection
        {
            get
            {
                return get_context<DbConnection>(CONNECTION_KEY);
            }
            set
            {
                set_context(CONNECTION_KEY, value);
            }
        }

        private static DbTransaction context_transaction
        {
            get
            {
                return get_context<DbTransaction>(TRANSACTION_KEY);
            }
            set
            {
                set_context(TRANSACTION_KEY, value);
            }
        }

        private static T get_context<T>(string key)
        {
            if (in_web_context)
                return (T)HttpContext.Current.Items[key];
            else
                return (T)CallContext.GetData(key);
        }

        private static void set_context(string key, object value)
        {
            if (in_web_context)
                HttpContext.Current.Items[key] = value;
            else
                CallContext.SetData(key, value);
        }

        private static bool in_web_context
        {
            get
            {
                return HttpContext.Current != null;
            }
        }
    }
}
