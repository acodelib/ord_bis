using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace BISystem.AppLogic
{
    public static class DbParser
    {
        public static String getConnectionFromDetails(ORM.Connection target_conn){            

            switch (target_conn.db_type_id)
            {
                case 1:
                    return buildSQLServerConnectionString(target_conn);
                    break;
                default:                    
                    throw new Exception("Unknown type of db connection. Please define new DB Type and rebuild. Check AppLogic/getConnectionFromDetails");
                    break;
            }
            return "";
            
        }

        private static String buildSQLServerConnectionString (ORM.Connection target_conn){
            StringBuilder conn_str = new StringBuilder();
            conn_str.Append("Data Source=" + target_conn.host);
            conn_str.Append(";Initial Catalog=" + target_conn.database_name);
            conn_str.Append(";User=" + target_conn.db_user);
            conn_str.Append(";Password=" + target_conn.password);
            conn_str.Append(";MultipleActiveResultSets=true");

            return conn_str.ToString();
        }

    }
}