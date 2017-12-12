using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;

namespace Dal
{
    public class OrderDal
    {
        //绑定订单产品
        public DataTable BindOrderPro(string uid, string ordernum)
        {
            string sql = $"select b.*,c.id,c.name,c.Picture,c.ProPrice from users a join orders b on a.username=b.uid join Commodity c on b.pid=c.id where b.uid='{uid}' and b.orderNum='{ordernum}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        //查询用户下的所有订单及订单中的商品
        public DataTable BindOrder(string uid)
        {
            string sql = $"select * from orders where uid='{uid}'  order by orderTime desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        //根据订单状态绑定订单
        public DataTable BindOrder(string uid, string type)
        {
            string sql = $"select * from orders where uid='{uid}' and type='{type}'order by orderTime desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }
        //删除订单
        public int DeleteOrder(string uid, string ordernum)
        {
            string sql = $"delete orders where uid='{uid}' and orderNum='{ordernum}'";
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
