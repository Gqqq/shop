using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using System.Data;
using Common;

namespace Shop
{
    public partial class Product_Brand : System.Web.UI.Page
    {
        public string Tr = "未找到匹配项";
        public int Count = 0;
        ProductBll bll = new ProductBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = bll.Brand();
            if (dt.Rows.Count>0)
            {
                Tr = "";
            }
            foreach (DataRow row in dt.Rows)
            {
                Tr += $@"<tr class='text-c'>"+
					        $"<td>{row["Alias"]}</td>"+
					        $"<td class='text-l'>{row["BName"]}</td>"+
                            $"<td style='height:100px; overflow:hidden'><img src='images/logo/{row["Logo"]}' style='height:100px;'/></td>"+
					        $"<td class='f-14 product-brand-manage'><a style='text-decoration:none' onClick=\" product_brand_edit('品牌编辑','codeing.html','1')\" href='javascript:;' title='编辑'><i class='Hui-iconfont'>&#xe6df;</i></a> <a style='text-decoration:none' class='ml-5' onClick=\" active_del(this,'10001')\" href='javascript:;' title='删除'><i class='Hui-iconfont'>&#xe6e2;</i></a></td>"+
                            "</tr>";
                Count++;
            }
        }
    }
}