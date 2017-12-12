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
    public partial class Product_add : System.Web.UI.Page
    {
        ProductBll bll = new ProductBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string action = Request["action"];
                if (!string.IsNullOrWhiteSpace(action))
                {
                    int pid = Convert.ToInt32(Request["id"]);
                    DataTable dt = bll.GetCommById(pid);
                    if (dt.Rows.Count > 0)
                    {
                        uname.Value = dt.Rows[0]["name"].ToString();
                        Colum.SelectedIndex = Convert.ToInt32(dt.Rows[0]["Colum"]);
                        Brand.Value = dt.Rows[0]["Brand"].ToString();
                        Price.Value = dt.Rows[0]["Price"].ToString();
                        picture.Value = dt.Rows[0]["Picture"].ToString();
                        ProPrice.Value = dt.Rows[0]["ProPrice"].ToString();
                        Introduce.Value = dt.Rows[0]["Introduce"].ToString();
                        KC.Value = dt.Rows[0]["Repertory"].ToString();
                        Describe.Value = dt.Rows[0]["Describe"].ToString();
                        Detail.Value = dt.Rows[0]["detail"].ToString();
                        
                    }
                }
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            if (Request["action"] == "edit")
                Edit();
            else
                Add();
        }
        public void Add()
        {
            string name = uname.Value;
            int colum = Convert.ToInt32(Colum.Value);
            string brand = Brand.Value;
            string image = Proimage.Value;
            double price = Convert.ToDouble(Price.Value);
            double proprice = Convert.ToDouble(ProPrice.Value);
            string introduce = Introduce.Value;
            string describe = Describe.Value;
            string detail = Detail.Value;
            int reper = Convert.ToInt32(KC.Value);
            if (bll.InsertNewComm(name, brand, image, price, proprice, introduce, describe, detail, reper, colum) == 1)
            {
                Response.Write("<script>alert('添加成功')</script>");
                Response.Write("<script>layer_close();</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
            }
        }
        public void Edit()
        {
            int pid = Convert.ToInt32(Request["id"]);
            string name = uname.Value;
            int colum = Convert.ToInt32(Colum.Value);
            string brand = Brand.Value;
            string image = Proimage.Value;
            if (image=="")
            {
                image =picture.Value;
            }
            double price = Convert.ToDouble(Price.Value);
            double proprice = Convert.ToDouble(ProPrice.Value);
            string introduce = Introduce.Value;
            string describe = Describe.Value;
            string detail = Detail.Value;
            int reper = Convert.ToInt32(KC.Value);
            if (bll.UpComm(name, brand, image, price, proprice, introduce, describe, detail, reper, colum,pid) == 1)
            {
                Response.Write("<script>alert('修改成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败')</script>");
            }
        }
    }
}