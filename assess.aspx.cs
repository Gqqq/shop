using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Common;
using Bll;

namespace Shop
{
    public partial class assess : System.Web.UI.Page
    {
        SystemBll bll = new SystemBll();
        public string Assess = string.Empty;
        public int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = bll.GetAllAssess();
            if (dt.Rows.Count<1)
            {
                Assess = "未找到匹配项";
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                Assess += "<tr class='text-c'>" +
                                $"<td>{row["id"]}</td>" +
                                $"<td>{row["username"]}</td>" +
                                $"<td>{row["comId"]}</td>" +
                                $"<td>{row["count"]}</td>" +
                                $"<td class='text-l'>{row["time"]}</td>" +
                                $"<td class='td-manage'><a title='删除' href='javascript:;' onclick='member_del(this,'{row["id"]}')' class='ml-5' style='text-decoration:none'>" + "<i class='Hui-iconfont'>&#xe6e2;</i></a></td>" +
                            "</tr>";
                count++;
            }
            
        }
    }
}