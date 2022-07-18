using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeFire.Enums
{
    /// <summary>
    /// Data Providers
    /// </summary>
    public enum DataAccessProviderTypes
    {
        /// <summary>
        /// SQL SERVER
        /// </summary>
        SqlServer=1,
        /// <summary>
        ///  SQL LITE
        /// </summary>
        SqLite,
        /// <summary>
        /// MYSQL
        /// </summary>
        MySql,
        /// <summary>
        /// POSTGREE
        /// </summary>
        PostgreSql,
        /// <summary>
        /// OLEDB
        /// </summary>
        OleDb,
#if NETFULL
        
    SqlServerCompact
#endif
    }

}
