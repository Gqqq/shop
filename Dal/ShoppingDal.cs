using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;

namespace Dal
{
    public class ShoppingDal
    {

        /// <summary>
        ///添加到购物车
        /// </summary>
        /// <param name="Uname"></param>
        /// <param name="Pid"></param>
        /// <param name="Count"></param>
        /// <param name="Color"></param>
        /// <returns></returns>
        public int InsertShopCart(string Uname,string Pid,string Count,string Color)
        {
            string sql = $"insert into Shoppingcart (UserName,Pid,Count,Color) values('{Uname}','{Pid}','{Count}','{Color}')";
            return SqlHelper.ExNonQuery(sql,Uname,Pid,Count,Color);
        }

        /// <summary>
        /// 查询账户下购物车
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public DataTable SelectShopCart(string username)
        {
            string sql = $"select * from Shoppingcart shop join Commodity comm on  shop.Pid= comm.Id where Username='{username}' order by shop.DataTime desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        /// <summary>
        /// 检查商品ID是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public object SelectCommByid(string id,string username)
        {
            string sql = $"select count(*) from Shoppingcart where Pid={id} and UserName='{username}'";
            return SqlHelper.ExScalar(sql);
        }

        /// <summary>
        /// 多次添加相同商品更改数量
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public int UpShopCartCount(string id, string username)
        {
            string sql = $"update Shoppingcart set Count+=1 where UserName='{username}' and Pid='{id}'";
            return SqlHelper.ExNonQuery(sql);
        }

        /// <summary>
        /// 根据用户与商品ID删除购物车
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelShopCart(string username,string id)
        {
            string sql = $"delete Shoppingcart where UserName='{username}' and Pid='{id}'";
            return SqlHelper.ExNonQuery(sql);
        }

        /// <summary>
        /// 查询用户下购物车最新添加的3条数据
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public DataTable SelectTopShopCart(string username)
        {
            string sql = $"select top 3 * from Shoppingcart shop join Commodity comm on  shop.Pid= comm.Id where Username='{username}' order by shop.DataTime desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        /// <summary>
        /// 根据用户名删除所有商品
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int DelShopCart(string username)
        {
            string sql = $"delete Shoppingcart where UserName='{username}'";
            return SqlHelper.ExNonQuery(sql);
        }

        //订单
        public DataTable GetCarProducts(string uname)
        {
            string sql = $" select c.id,c.name,c.ProPrice,c.Picture,b.Count from users a join Shoppingcart b on a.username=b.UserName join Commodity c on b.pid=c.id where a.username='{uname}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        //绑定订单
        public DataTable BindOrder(string uid)
        {
            string sql = $"select * from orders where uid='{uid}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        //根据订单状态绑定订单
        public DataTable BindOrder(string uid, string type)
        {
            string sql = $"select * from orders where uid='{uid}' and type='{type}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }
        //删除订单
        public int DeleteOrder(string uid, string ordernum)
        {
            string sql = $"delete orders where uid='{uid}' and orderNum='{ordernum}'";
            return SqlHelper.ExNonQuery(sql);
        }
        //添加到订单
        public int InsertToOrder(string uid, int pid, string ordernum, int num, string type,int addressid)
        {
            string sql = $"insert into orders(uid,pid,orderNum,num,type,address) values('{uid}',{pid},'{ordernum}',{num},'{type}','{addressid}')";
            return SqlHelper.ExNonQuery(sql);
        }
        //清空购物车
        public int DelCar(string uid)
        {
            string sql = $"delete Shoppingcart where username='{uid}'";
            return SqlHelper.ExNonQuery(sql);
        }
        //修改订单状态
        public int UpdateOrder(string uid, string ordernum, string type)
        {
            string sql = $"update orders set type='{type}' where uid='{uid}' and orderNum='{ordernum}'";
            return SqlHelper.ExNonQuery(sql);
        }
    }
}
