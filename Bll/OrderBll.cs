using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;
using Dal;

namespace Bll
{
    /// <summary>
    /// 订单
    /// </summary>
    public class OrderBll
    {
        OrderDal orderdal = new OrderDal();
        public DataTable BindOrderPro(string uid, string ordernum)
        {
            return orderdal.BindOrderPro(uid, ordernum);
        }

        public DataTable BindOrder(string uid)
        {
            return orderdal.BindOrder(uid);
        }
        public DataTable BindOrder(string uid, string type)
        {
            return orderdal.BindOrder(uid, type);
        }
        public int DeleteOrder(string uid, string ordernum)
        {
            return orderdal.DeleteOrder(uid, ordernum);
        }
 
        public int UpdateOrder(string uid, string ordernum, string type)
        {
            return orderdal.UpdateOrder(uid, ordernum, type);
        }
    }
}
