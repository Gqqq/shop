using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;
using Dal;

namespace Bll
{
    public class ShoppingBll
    {
        ShoppingDal dal = new ShoppingDal();

        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <param name="Uname">用户名</param>
        /// <param name="Pid">商品ID</param>
        /// <param name="Count">数量</param>
        /// <param name="Color">商品颜色</param>
        /// <returns></returns>
        public int AddShopCart(string Uname, string Pid, string Count, string Color)
        {
            return dal.InsertShopCart(Uname, Pid, Count, Color);
        }

        /// <summary>
        /// 查询账户下的购物车
        /// </summary>
        /// <param name="username">账户名</param>
        /// <returns></returns>
        public DataTable GetShopCart(string username)
        {
            return dal.SelectShopCart(username);
        }

        /// <summary>
        /// 检查商品ID是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckPid(string id, string username)
        {
            return Convert.ToInt32(dal.SelectCommByid(id,username))==1;
        }


        /// <summary>
        /// 添加相同商品到购物车时，原数量+1
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public int UpShopCount(string id, string username)
        {
            return dal.UpShopCartCount(id, username);
        }

        /// <summary>
        /// 删除购物车中的商品
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="id">要删除的商品ID</param>
        /// <returns></returns>
        public int DelShopByPid(string username, string id)
        {
            return dal.DelShopCart(username, id);
        }

        /// <summary>
        /// 查询账户最新添加的三条数据
        /// </summary>
        /// <param name="username">账户名</param>
        /// <returns></returns>
        public DataTable GetTopShopCart(string username)
        {
            return dal.SelectTopShopCart(username);
        }

        /// <summary>
        /// 清空购物车
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int ClearShopCart(string username)
        {
            return dal.DelShopCart(username);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <returns></returns>
        public DataTable GetCarProducts(string uname)
        {
            return dal.GetCarProducts(uname);
        }
        public DataTable BindOrder(string uid)
        {
            return dal.BindOrder(uid);
        }
        public DataTable BindOrder(string uid, string type)
        {
            return dal.BindOrder(uid, type);
        }
        public int DeleteOrder(string uid, string ordernum)
        {
            return dal.DeleteOrder(uid, ordernum);
        }
        public int InsertToOrder(string uid, int pid, string ordernum, int num, string type,int addressid)
        {
            return dal.InsertToOrder(uid, pid, ordernum, num, type,addressid);
        }
        public int DelCar(string uid)
        {
            return dal.DelCar(uid);
        }
        public int UpdateOrder(string uid, string ordernum, string type)
        {
            return dal.UpdateOrder(uid, ordernum, type);
        }
    }
}
