using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using System.Data;
using Bll;

namespace Shop
{
    public partial class HouUsers : System.Web.UI.Page
    {
        public string Root="未找到匹配项";
        public int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["uname"] == null)
                {
                    Response.Write("<script>window.location.href='index.aspx'</script>");
                }
                SystemBll bll = new SystemBll();
                DataTable dt = bll.AllUsers();
                if (dt.Rows.Count>0)
                {
                    Root = "";
                }
                
                foreach (DataRow row in dt.Rows)
                {
                    string root = Convert.ToInt32(row["UserLevel"]) == 0 ? "超级管理员" : "普通用户";
                    Root += $@"<tr class='text-c'>"+
				                $"<td>{row["username"]}</td>"+
				                $"<td>{row["Phone"]}</td>"+
				                $"<td>{row["Email"]}</td>"+
				                $"<td>{root}</td>"+
				                $"<td>{row["RegDate"]}</td>"+
				                $"<td class='td-manage'><a title='删除' href='javascript:;' onclick=\"admin_del(this,'{row["username"]}')\" class='ml-5' style='text-decoration:none'><i class='Hui-iconfont'>&#xe6e2;</i></a></td>"+
			                "</tr>";
                    count++;
                }
            }
        }
    }
}