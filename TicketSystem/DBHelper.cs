using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    /// <summary>
    /// 数据库帮助类
    /// </summary>
    public class DBHelper
    {
        private static string ConnStr = "server=.;uid=sa;pwd=111111;database=TicketSystemDB";

        public static int ExcuteNonQuery(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                //打开链接
                conn.Open();
                //创建执行脚本的对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(paras);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        /// <summary>
        /// 执行SQL并返回第一行 第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
        }
        /// <summary>
        /// 执行SQL返回SQLDATAREADER对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);//命令行为
            }
        }

        public static DataRow GetDataRow(string sql, params SqlParameter[] paras)
        {
            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(paras);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            }
        }
    }
}
