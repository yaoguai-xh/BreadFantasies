using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data;

namespace Web
{
    public class PageGoodsData
    {
        public string goodsId;           //商品ID
        public string goodsName;        //商品名字
        public string batching;         //配料
        public string introduce;        //介绍
        public string toBadTime;        //保质期
        public double price;            //价格
        //public int    type;             //蛋糕1、面包2、点心3
        public int    size;             //大号1、中号2、小号3

        public PageGoodsData(Goodss goods)
        {
            this.goodsId = goods.goodsId;
            this.goodsName = goods.goodsName;
            this.batching = goods.batching;
            this.introduce = goods.introduce;
            this.toBadTime = goods.toBadTime;
            this.price = goods.price;
            //this.type = goods.type;
            this.size = goods.size;
        }
    }
    public class PageData
    {
        public short count1 = 0;    //蛋糕的数量
        public short count2 = 0;    //面包的数量
        public short count3 = 0;    //点心的数量
        public List<PageGoodsData> data1 = new List<PageGoodsData>();      //蛋糕的数据
        public List<PageGoodsData> data2 = new List<PageGoodsData>();      //面包的数据
        public List<PageGoodsData> data3 = new List<PageGoodsData>();      //点心的数据
        public PageData()
        {
            DataManager datas = new DataManager(1);
            foreach (var dataTemp in datas.goodss)
            {
                PageGoodsData temp = new PageGoodsData(dataTemp);
                if (dataTemp.type == 1)
                {
                    data1.Add(temp);
                    count1++;
                }
                else if (dataTemp.type == 2)
                {
                    data2.Add(temp);
                    count2++;
                }
                else
                {
                    data3.Add(temp);
                    count3++;
                }
            }
        }
    }
}