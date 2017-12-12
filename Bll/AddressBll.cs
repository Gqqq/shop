using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;
using Dal;

namespace Bll
{
    public class AddressBll
    {
        AddressDal dal = new AddressDal();

        /// <summary>
        /// 获取默认地址
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable GetAddress(string name)
        {
            return dal.SelectAddress(name);
        }

        /// <summary>
        /// 获取账户下所有收货地址
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable GetAddByName(string name)
        {
            return dal.SelectAddByName(name);
        }

        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="pro">省</param>
        /// <param name="city">市</param>
        /// <param name="county">县/区</param>
        /// <param name="details">详细地址</param>
        /// <param name="name">收货人姓名</param>
        /// <param name="uname">用户名</param>
        /// <param name="type">是否设为默认地址</param>
        /// <param name="tel">电话</param>
        /// <returns></returns>
        public int AddAddress(string pro, string city, string county, string details, string name, string uname, int type, string tel)
        {
            return dal.AddAddress(pro, city, county, details, name, uname, type, tel);
        }

        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uname"></param>
        /// <returns></returns>
        public int DelAddress(int id, string uname)
        {
            return dal.DelAddress(id, uname);
        }

        /// <summary>
        /// 查询默认地址ID
        /// </summary>
        /// <returns></returns>
        public int GetAddByType()
        {
            return dal.SelectAddByType();
        }

        /// <summary>
        /// 修改默认地址
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uname"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateAddress(int type, string uname, int id)
        {
            return dal.UpdateAddress(type, uname, id);
        }

        /// <summary>
        /// 变原默认地址为非默认
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int UpdateType()
        {
            return dal.UpdateType();
        }
    }
}
