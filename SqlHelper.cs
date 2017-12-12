using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//数据访问层
namespace Shop
{
    /// <summary>
    /// 数据库操作类
    /// </summary>
    public static class SqlHelper
    {
        #region 连接字符串

        static string constr = "Data Source=.;Initial Catalog=ShopData;Integrated Security=True";
        static SqlConnection con;

        #endregion

        #region 对数据源操作的通用方法

        /// <summary>
            /// 静态构造函数初始化连接对象
        /// </summary>
        static SqlHelper()
        {
            con = new SqlConnection(constr);
        }

        /// <summary>
        ///打开连接对象
        /// </summary>
        static void Open()
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        /// <summary>
        /// 关闭连接对象
        /// </summary>
        static void Close()
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
        }

        /// <summary>
        /// 对数据源执行增 删 改操作的通用方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="mess">操作命令</param>
        /// <param name="pa">SQL语句中的参数</param>
        //public static int ExNonQuery(string sql, string mess, params object[] pa)
        //{
        //    int k;
        //    //using语句创建的对象可以自动销毁
        //    //con.CreateCommand()表示在连接对象下创建执行对象
        //    using (SqlCommand cmd=con.CreateCommand())
        //    {
        //        cmd.CommandText=sql;
        //        if (pa.Length>0&&pa!=null)
        //        {
        //            for (int i = 0; i < pa.Length; i++)
        //            {
        //                SqlParameter sp = new SqlParameter("@" + i, pa[i]);//构建SQL语句中的参数
        //                cmd.Parameters.Add(sp);
        //            }
        //        }
        //        Open();
        //        k = cmd.ExecuteNonQuery();
        //        Close();
        //    }
        //    //if (k>0)
        //    //{
        //    //    MessageBox.Show(mess + "成功");
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show(mess + "失败");
        //    //}
        //    return k;
        //}

            /// <summary>
        /// 对数据源执行增 删 改操作 并返回int类型的通用方法
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="pa"></param>
            /// <returns></returns>
        public static int ExNonQuery(string sql, params object[] pa)
        {
            int k;
            //using语句创建的对象可以自动销毁
            //con.CreateCommand()表示在连接对象下创建执行对象
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = sql;
                if (pa.Length > 0 && pa != null)
                {
                    for (int i = 0; i < pa.Length; i++)
                    {
                        SqlParameter sp = new SqlParameter("@" + i, pa[i]);//构建SQL语句中的参数
                        cmd.Parameters.Add(sp);
                    }
                }
                Open();
                k = cmd.ExecuteNonQuery();
                Close();
            }
            return k;
        }

        /// <summary>
        /// 封装了执行对象数据库进行只读查询并返回数据阅读器SqlDataReader的通用方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="pa">SQL语句中的参数</param>
        /// <returns>SqlDataReader数据阅读器</returns>
        public static SqlDataReader ExReader(string sql, params object[] pa)
        {
            SqlDataReader result;
            using (SqlCommand cmd=con.CreateCommand())
            {
                cmd.CommandText=sql;
                if (pa.Length>0&&pa!=null)
                {
                    for (int i = 0; i < pa.Length; i++)
                    {
                        SqlParameter sp = new SqlParameter("@" + i, pa[i]);//构建SQL语句中的参数
                        cmd.Parameters.Add(sp);
                    }
                }
                Open();
                result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            return result;
        }

        /// <summary>
        /// 封装了执行对象数据库进行查询并返回数据适配器DataSet的通用方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="pa">SQL语句中的参数</param>
        /// <returns>数据适配器DataSet</returns>
        public static DataSet  FillSet(string sql, params object[] pa)
        {
            DataSet result=new DataSet ();
            using (SqlDataAdapter da =new SqlDataAdapter(sql,con))
            {
                if (pa.Length > 0 && pa != null)
                {
                    for (int i = 0; i < pa.Length; i++)
                    {
                        SqlParameter sp = new SqlParameter("@" + i, pa[i]);//构建SQL语句中的参数
                        da.SelectCommand.Parameters.Add(sp);
                    }
                }
                Open();
                da.Fill(result);
            }
            return result;
        }

        /// <summary>
        /// 封装了执行对数据库进行聚合查询操作并返回第一行第一列的通用方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="pa">SQL语句中的参数</param>
        /// <returns>第一行第一列</returns>
        public static object ExScalar(string sql, params object[] pa)
        {
            object result;
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = sql;
                if (pa.Length > 0 && pa != null)
                {
                    for (int i = 0; i < pa.Length; i++)
                    {
                        SqlParameter sp = new SqlParameter("@" + i, pa[i]);//构建SQL语句中的参数
                        cmd.Parameters.Add(sp);
                    }
                }
                Open();
                result = cmd.ExecuteScalar();
                Close();
            }
            return result;
        }

        #endregion
    }
}
