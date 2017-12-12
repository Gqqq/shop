using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Bll;
using Common;

namespace Shop
{
    public partial class Product_list : System.Web.UI.Page
    {
        public string Products="未找到匹配项";
        public int count = 0;
        ProductBll bll = new ProductBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = bll.AllComm();
            if (dt.Rows.Count>0)
            {
                Products = "";
            }
            foreach (DataRow row in dt.Rows)
            {
                string pic = row["Picture"].ToString().Split(';')[0];
                Products += $"<tr class='text-c'>"+
					                $"<td>{row["Id"]}</td>"+
                                    $"<td class='text-c'>{row["Name"]}</td>" +
                                    $"<td>{row["Brand"]}</td>"+
					                $"<td style='height:140px; overflow:hidden'><a href='Products.aspx?id={row["id"]}' target='_blank' ><img class='picture-thumb' src='images/{pic}'style='height:140px;'></a></td>"+
					                $"<td class=''>{row["Detail"]}</td>"+
                                    $"<td>{row["Repertory"]}</td>" +
                                    $"<td>{row["SalesVolume"]}</td>" +
                                    $"<td>{row["Time"]}</td>"+
					                //"<td class='td-status'><span class='label label-success radius'>已发布</span></td>"+
					                $"<td class='td-manage'>"+
//<a style='text-decoration:none' onClick=\"picture_stop(this,'{row["id"]}')\" href='javascript:;' title='下架'><i class='Hui-iconfont'>&#xe6de;</i></a>"+ 
                                        $"<button style='text-decoration:none; background-color:rgba(0, 0, 0, 0); border:none'class='ml-5' onClick=\"picture_edit('产品编辑','Product-add.aspx?id={row["id"]}&&action=edit','10001')\" title='编辑'><i class='Hui-iconfont'>&#xe6df;</i></button>" + 
                                        $"<button style='text-decoration:none;background-color:rgba(0, 0, 0, 0); border:none'name='del' class='ml-5' data-id='{row["id"]}'  title='删除'><i class='Hui-iconfont'>&#xe6e2;</i></button></td>" +
				                "</tr>";
                count++;
            }
        }
    }
}