using IDatabaseService;
using MySqlDatabaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Common
{
    class DatabaseFactory
    {
        private static Dictionary<string, IDatabase> _services = new Dictionary<string, IDatabase>();
        public static IDatabase GetIDatabase(string databaseType)
        {
            if (!_services.ContainsKey(databaseType))
            {
                switch (databaseType)
                {
                    case "mysql":
                        _services.Add(databaseType, new MysqlDatabaseServer());
                        break;
                    default:
                        break;
                }
            }
            return _services[databaseType];
        }
    }
}
