using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;

namespace Dal
{
    public class AddressDal
    {
        //查询默认收货地址
        public DataTable SelectAddress(string name)
        {
            string sql = $"select * from address where uname='{name}' and type=0";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        /// <summary>
        /// 查询账户下所有地址
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable SelectAddByName(string name)
        {
            string sql = $"select * from address where uname='{name}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        /// <summary>
        /// 添加收货地址
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="city"></param>
        /// <param name="county"></param>
        /// <param name="details"></param>
        /// <param name="name"></param>
        /// <param name="uname"></param>
        /// <param name="type"></param>
        /// <param name="tel"></param>
        /// <returns></returns>
        public int AddAddress(string pro, string city, string county, string details,string name,string uname,int type,string tel)
        {
            string sql = $"insert into address(province,city,county,details,name,uname,type,tel) values('{pro}','{city}','{county}','{details}','{name}','{uname}','{type}','{tel}')";
            return SqlHelper.ExNonQuery(sql);
        }

        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uname"></param>
        /// <returns></returns>
        public int DelAddress( int id,string uname)
        {
            string sql = $"Delete address where id={id} and uname='{uname}'";
            return SqlHelper.ExNonQuery(sql);
        }

        /// <summary>
        /// 查询默认地址ID
        /// </summary>
        /// <returns></returns>
        public int SelectAddByType()
        {
            string sql = "select id from address where type=0";
            return Convert.ToInt32( SqlHelper.ExScalar(sql));
        }

        /// <summary>
        /// 修改默认地址
        /// </summary>
        /// <returns></returns>
        public int UpdateAddress(int type, string uname, int id)
        {
            string sql = $"update address set type='{type}' where uname='{uname}' and id='{id}' ";
            return SqlHelper.ExNonQuery(sql);
        }

        public int UpdateType()
        {
            string sql = $"update address set type=1 where type=0";
            return SqlHelper.ExNonQuery(sql);
        }
    }
}
