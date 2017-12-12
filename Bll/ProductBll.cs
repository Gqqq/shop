using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dal;

/// <summary>
/// 商品
/// </summary>
namespace Bll
{
    /// <summary>
    /// 商品
    /// </summary>
    public class ProductBll
    {
        ProductDal dal = new ProductDal();


        /// <summary>
        /// 所有商品
        /// </summary>
        /// <returns></returns>
        public DataTable AllComm()
        {
            return dal.SelectAllComm();
        }

        /// <summary>
        /// 新品
        /// </summary>
        /// <returns></returns>
        public DataTable NewTopComm()
        {
            return dal.SelectNewComm();
        }

        /// <summary>
        /// 最热
        /// </summary>
        /// <returns></returns>
        public DataTable BestHotComm()
        {
            return dal.SelectBestHotComm();
        }

        /// <summary>
        /// 品牌
        /// </summary>
        /// <param name="count">查询数据条数</param>
        /// <returns></returns>
        public DataTable BrandComm(int count)
        {
            return dal.SelectBrandComm(count);
        }

        /// <summary>
        /// 热销
        /// </summary>
        /// <returns></returns>
        public DataTable HotComm()
        {
            return dal.SelectHotComm();
        }

        /// <summary>
        /// 获取所有品牌 
        /// </summary>
        /// <returns></returns>
        public DataTable Brand()
        {
            return dal.SelectBrand();
        }

        /// <summary>
        /// 根据编号查询商品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetCommById(int id)
        {
            return dal.SelectCommById(id);
        }

        /// <summary>
        /// 获取相同品牌下的不同热卖商品
        /// </summary>
        /// <returns></returns>
        public DataTable GetBrandDeComm(string brand, int id)
        {
            return dal.SelectBrandDeComm(brand,id);
        }

        /// <summary>
        /// 获取所有品牌
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllBrand()
        {
            return dal.SelectAllBrand();
        }

        /// <summary>
        /// 获取品牌下的所有商品
        /// </summary>
        /// <returns></returns>
        public DataTable GetCommByBrand(string brand)
        {
            return dal.SelectCommByBrand(brand);
        }

        /// <summary>
        /// 获取推荐商品中的销量最高的3种产品
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public DataTable GetTopCommByBrand()
        {
            return dal.SelecttopCommByBrand();
        }

        /// <summary>
        /// 获取品牌下销量最高的8种商品
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public DataTable GetHotByBrand(string brand)
        {
            return dal.SelectHotByBrand(brand);
        }

        /// <summary>
        /// 获取品牌下最新上架的8种商品
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public DataTable GetNewByBrand(string brand)
        {
            return dal.SelectNewByBrand(brand);
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="pic"></param>
        /// <param name="price"></param>
        /// <param name="proprice"></param>
        /// <param name="intro"></param>
        /// <param name="desc"></param>
        /// <param name="detail"></param>
        /// <param name="reper"></param>
        /// <param name="colum"></param>
        /// <returns></returns>
        public int InsertNewComm(string name, string brand, string pic, double price, double proprice, string intro, string desc, string detail, int reper, int colum)
        {
            return dal.InsertNewComm(name, brand, pic, price, proprice, intro, desc, colum,detail,reper);
        }


        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="name">名</param>
        /// <param name="brand">品牌</param>
        /// <param name="pic">图</param>
        /// <param name="price">价</param>
        /// <param name="proprice">促销价</param>
        /// <param name="intro">摘要</param>
        /// <param name="desc">详情</param>
        /// <param name="detail">简介</param>
        /// <param name="reper">库存</param>
        /// <param name="colum">栏目</param>
        /// <returns></returns>
        public int UpComm(string name, string brand, string pic, double price, double proprice, string intro, string desc, string detail, int reper, int colum,int pid)
        {
            return dal.UpdateComm(name, brand, pic, price, proprice, intro, desc, colum, detail, reper,pid);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <returns></returns>
        public int DelComm(int pid)
        {
            return dal.DelComm(pid);
        }

        /// <summary>
        /// 根据商品获取商品评价
        /// </summary>
        /// <param name="Pid">商品编号</param>
        /// <returns></returns>
        public DataTable GetAssByCommID(int Pid)
        {
            return dal.SelectAssByCommID(Pid);
        }
    }
}
