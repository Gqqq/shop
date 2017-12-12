using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;

/// <summary>
/// 商品
/// </summary>
namespace Dal
{
    public class ProductDal
    {
        public DataTable SelectAllComm()
        {
            string sql = "select * from Commodity where PutUp=1";
            return SqlHelper.FillSet(sql).Tables[0];
        }
        public DataTable SelectNewComm()
        {
            string sql = "select top 6 *  from Commodity where PutUp=1 order by Time desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectBestHotComm()
        {
            string sql = "select top 1 * from Commodity where PutUp=1 order by SalesVolume desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectBrandComm(int count)
        {
            string sql = $"select top {count} * from Commodity where PutUp=1 order by Time desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectHotComm()
        {
            string sql = "select top 8 * from Commodity where PutUp=1 order by SalesVolume desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectBrand()
        {
            string sql = "select * from ProBrand";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectCommById(int id)
        {
            string sql = $"select * from Commodity a join ProBrand b on a.Brand=b.Alias  where a.Id={id}";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectBrandDeComm(string brand,int id)
        {
            string sql = $"select top 8 * from Commodity where Brand='{brand}' and id!='{id}' order by SalesVolume desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectAllBrand()
        {
            string sql = "select * from ProBrand";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectCommByBrand(string brand)
        {
            string sql = $"select * from Commodity where Brand='{brand}' and PutUp=1";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelecttopCommByBrand()
        {
            string sql= $"select top 3 * from Commodity where Colum='3' and PutUp=1 order by SalesVolume desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectHotByBrand(string brand)
        {
            string sql = $"select top 8 * from Commodity where PutUp=1 and Brand='{brand}' order by SalesVolume desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectNewByBrand(string brand)
        {
            string sql = $"select top 8 * from Commodity where PutUp=1 and Brand='{brand}' order by Time desc";
            return SqlHelper.FillSet(sql).Tables[0];
        }
        public int InsertNewComm(string name,string brand,string pic,double price,double proprice,string intro,string desc,int colum, string detail, int reper)
        {
            string sql = $"insert into Commodity (Sort,Name, Brand,Picture,Price,ProPrice,Introduce,Describe,detail,Repertory,Colum) values(1,'{name}','{brand}','{pic}',{price},{proprice},'{intro}','{desc}','{detail}','{reper}',{colum})";
            return SqlHelper.ExNonQuery(sql);
        }
        public int UpdateComm(string name, string brand, string pic, double price, double proprice, string intro, string desc, int colum, string detail, int reper,int pid)
        {
            string sql = $"update Commodity set Name='{name}',Brand='{brand}',Picture='{pic}',Price='{price}',ProPrice='{proprice}',Introduce='{intro}',Describe='{desc}',detail='{detail}',Sort='1',Colum='{colum}',Repertory='{reper}' where id={pid}";
            return SqlHelper.ExNonQuery(sql);
        }
        public int DelComm(int pid )
        {
            string sql = $"delete Commodity where id={pid}";
            return SqlHelper.ExNonQuery(sql);
        }

        public DataTable SelectAssByCommID(int pid)
        {
            string sql = $"select * from Assess where comid='{pid}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }
    }
}
