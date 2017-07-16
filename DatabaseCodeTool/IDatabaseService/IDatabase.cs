using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDatabaseService
{
   public interface IDatabase
    {
        /// <summary>
        /// 获取指定数据库的所有表
        /// </summary>
        /// <param name="databaseName"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        List<string> GetTables(string databaseName, string connection);
        /// <summary>
        /// 获取指定表的所有字段
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        List<string> GetColumns(string databaseName, string tableName, string connection);
    }
}
