using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Enjoy.MS.EntityFactory;

namespace Enjoy.MS.Entities
{
    /// <summary>
    /// 表示一种会员信息的实体类
    /// </summary>
    public class MemberInfoEntity
    {
        public MemberInfoEntity() 
        {
        }

        public long CardNo{ set; get;}

        public long CardSN { set; get; }

        public string Name { set; get; }

        public DateTime RegTime { set; get; }

        public float YaJin { set; get; }

        public int JiFen { set; get; }

        public string GName { set; get; }

        public int State { set; get; }

        public string CardType { set; get; }

        public string CertNo { set; get; }

        public string TelNum { set; get; }

        public int BiPi { set; get; }

        public int Piao { set; get; }

        public int Cash { set; get; }

        public string VDate { set; get; }

        public string CardState { set; get; }

        public int CardState_Card { set; get; }

        public DateTime LastCardTime { set; get; }

        public int CardBNo { set; get; }

        public DateTime LPTime { set; get; }

        public int AddChongZhi { set; get; }

        public int AddB { set; get; }

        public int AddZengB { set; get; }

        public int AddTiB { set; get; }

        public int AddGiftExB { set; get; }

        public int AddTouB { set; get; }

        public int AddTuiB { set; get; }

        public int AddChongCash { set; get; }

        public int AddCB { set; get; }

        public int AddTouCash { set; get; }

        public int AddTuiCash { set; get; }

        public int AddOutP { set; get; }

        public int AddExCP { set; get; }

        public int AddJiFen { set; get; }

        public int AddGiftExJiFen { set; get; }

        public int BiDeFen { set; get; }

        public int ABiDeFen { set; get; }
        public DateTime Birthday { set; get; }
      
        /// <summary>
        /// 会员帐号
        /// </summary>
        public Guid AccountNo
        {
            get;
            set;
        }
     
        /// <summary>
        /// 归属店号
        /// </summary>
        public byte OwnerShopID
        {
            get;
            set;
        }

        public string MemberType { set; get; }

        public int isFormat { set; get; }

        public DateTime RengZhengTime { set; get; }

        /// <summary>
        ///分店IP
        /// </summary>
        public string RoamingIP
        {
            set;
            get;
        }
        /// <summary>
        ///漫游分店名称
        /// </summary>
        public string RoamingName
        {
            set;
            get;
        }

        /// <summary>
        ///分店ID
        /// </summary>
        public int ChainStoreID
        {
            set;
            get;
        }

        /// <summary>
        ///漫游状态
        /// </summary>
        public byte RoamingState
        {
            set;
            get;
        }

        public string RoamingTime
        {
            set;
            get;
        }
        
    }

    /// <summary>
    /// 会员账户信息实体工厂类
    /// </summary>
    public sealed class MemberInfoEntityFactory
    {
        private MemberInfoEntityFactory() { }

        public static MemberInfoEntity fill(object datasource)
        {
            if (datasource is DataRow)
            {
                DataRow row = datasource as DataRow;
                MemberInfoEntity entity = ObjectFactory<MemberInfoEntity>.GetInstance();

                entity.CardNo = ObjectFactory<long>.GetFromField(row, "CardNo");
                entity.ABiDeFen = ObjectFactory<int>.GetFromField(row, "ABiDeFen");
                entity.AddB = ObjectFactory<int>.GetFromField(row, "AddB");
                entity.AddCB = ObjectFactory<int>.GetFromField(row, "AddCB");
                entity.AddChongCash = ObjectFactory<int>.GetFromField(row, "AddChongCash");
                entity.AddChongZhi = ObjectFactory<int>.GetFromField(row, "AddChongZhi");
                entity.AddExCP = ObjectFactory<int>.GetFromField(row, "AddExCP");
                entity.AddGiftExB = ObjectFactory<int>.GetFromField(row, "AddGiftExB");
                entity.AddGiftExJiFen = ObjectFactory<int>.GetFromField(row, "AddGiftExJiFen");
                entity.AddJiFen = ObjectFactory<int>.GetFromField(row, "AddJifen");
                entity.AddOutP = ObjectFactory<int>.GetFromField(row, "AddOutP");
                entity.AddTiB = ObjectFactory<int>.GetFromField(row, "AddTiB");
                entity.AddTouB = ObjectFactory<int>.GetFromField(row, "AddTouB");
                entity.AddTouCash = ObjectFactory<int>.GetFromField(row, "AddTouCash");
                entity.AddTuiB = ObjectFactory<int>.GetFromField(row, "AddTuiB");
                entity.AddTuiCash = ObjectFactory<int>.GetFromField(row, "AddTuiCash");
                entity.AddZengB = ObjectFactory<int>.GetFromField(row, "AddZengB");
                entity.BiDeFen = ObjectFactory<int>.GetFromField(row, "BiDeFen");
                entity.BiPi = ObjectFactory<int>.GetFromField(row, "BiPi");
                entity.CardBNo = ObjectFactory<int>.GetFromField(row, "CardBNo");
                entity.CardSN = ObjectFactory<long>.GetFromField(row, "CardSN");
                entity.CardState = ObjectFactory<string>.GetFromField(row, "CardState");
                entity.CardState_Card = ObjectFactory<int>.GetFromField(row, "CardState_Card");
                entity.CardType = ObjectFactory<string>.GetFromField(row, "CardType");
                entity.Cash = ObjectFactory<int>.GetFromField(row, "Cash");
                entity.CertNo = ObjectFactory<string>.GetFromField(row, "CertNo");
                entity.GName = ObjectFactory<string>.GetFromField(row, "GName");
                entity.JiFen = ObjectFactory<int>.GetFromField(row, "JiFen");
                entity.LastCardTime = ObjectFactory<DateTime>.GetFromField(row, "LastCardTime");
                entity.LPTime = ObjectFactory<DateTime>.GetFromField(row, "LPTime");
                entity.Name = ObjectFactory<string>.GetFromField(row, "Name");
                entity.Piao = ObjectFactory<int>.GetFromField(row, "Piao");
                entity.RegTime = ObjectFactory<DateTime>.GetFromField(row, "RegTime");
                entity.State = ObjectFactory<int>.GetFromField(row, "State");
                entity.TelNum = ObjectFactory<string>.GetFromField(row, "TelNum");
                entity.VDate = ObjectFactory<string>.GetFromField(row, "VDate");
                entity.YaJin = ObjectFactory<long>.GetFromField(row, "YaJin");
                if (row.Table.Columns.Contains("Birthday") && row["Birthday"] != DBNull.Value)
                    entity.Birthday = Convert.ToDateTime(row["Birthday"]);
                entity.AccountNo = ObjectFactory<Guid>.GetFromField(row, "AccountNo");
                entity.OwnerShopID = ObjectFactory<byte>.GetFromField(row, "OwnerShopID");
                entity.MemberType = ObjectFactory<string>.GetFromField(row, "MemberType");
                entity.isFormat = ObjectFactory<int>.GetFromField(row, "isFormat");
                entity.RengZhengTime = ObjectFactory<DateTime>.GetFromField(row, "RenZhengTime");
                entity.ChainStoreID = ObjectFactory<int>.GetFromField(row, "ChainStoreID");
                entity.RoamingIP = ObjectFactory<string>.GetFromField(row, "RoamingIP");
                entity.RoamingName = ObjectFactory<string>.GetFromField(row, "RoamingName");
                entity.RoamingState = ObjectFactory<byte>.GetFromField(row, "RoamingState");
                entity.RoamingTime = ObjectFactory<string>.GetFromField(row, "RoamingTime");
                return entity;
            }
            return null;
        }
    }
}
