using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Enjoy.MS.Entities;
using System.Data;
using Enjoy.MS.EntityFactory;

namespace Enjoy.DataAccess
{
	public class T_AccountDataAccess
	{
		#region 字段

        //private MemberDataAccess m_MemberDataAccess;
		#endregion

		#region 构造函数与工厂

		private T_AccountDataAccess() { }

		private T_AccountDataAccess(SqlConnection p_SqlConnection)
		{

		}

		private T_AccountDataAccess(SqlTransaction p_SqlTransaction)
		{

		}

		public static T_AccountDataAccess GetInstance(SqlConnection p_SqlConnection)
		{ 
			T_AccountDataAccess _instance = new T_AccountDataAccess(p_SqlConnection);
			//_instance.MemberDataAccess = new MemberDataAccess(p_SqlConnection);

			return _instance;
		}

		public static T_AccountDataAccess GetInstance(SqlTransaction p_SqlTransaction)
		{
			T_AccountDataAccess _instance = new T_AccountDataAccess(p_SqlTransaction);
			//_instance.MemberDataAccess = new MemberDataAccess(p_SqlTransaction);

			return _instance;
		}

		private static T_AccountDataAccess GetInstance()
		{
			
			T_AccountDataAccess _instance = new T_AccountDataAccess();
			return _instance;
		}

        public static MemberInfoEntity LoadForeignKey(DataRow p_DataRow)
		{
            MemberInfoEntity _entity = new MemberInfoEntity();
            string _table_prefix = string.Empty;// "T_Account_";

			_entity.CardNo = ObjectFactory<long>.GetFromField(p_DataRow, _table_prefix + "CardNo");
			_entity.Name = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "Name");
			_entity.CertNo = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "CertNo");
			_entity.VDate = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "VDate");
			_entity.CardType = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "CardType");
			_entity.RegTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, _table_prefix + "RegTime");
			_entity.YaJin = ObjectFactory<long>.GetFromField(p_DataRow, _table_prefix + "YaJin");
			_entity.BiPi = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "Bipi");
			_entity.Piao = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "Piao");
			_entity.Cash = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "Cash");
			_entity.JiFen = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "Jifen");
			_entity.CardBNo = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "CardBNo");
			_entity.State = ObjectFactory<byte>.GetFromField(p_DataRow, _table_prefix + "State");
            _entity.CardState_Card = ObjectFactory<byte>.GetFromField(p_DataRow, _table_prefix + "CardState_Card");
			_entity.LastCardTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, _table_prefix + "LastCardTime");
			_entity.LPTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, _table_prefix + "LPTime");
            _entity.AddChongZhi = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddChongZhi");
			_entity.AddB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddB");
			_entity.AddZengB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddZengB");
			_entity.AddTouB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddTouB");
			_entity.AddTuiB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddTuiB");
			_entity.AddOutP = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddOutP");
			_entity.AddExCP = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddExCP");
			_entity.AddTiB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddTiB");
			_entity.AddCB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddCB");
			_entity.AddGiftExB = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddGiftExB");
			_entity.AddGiftExJiFen = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "AddGiftExJiFen");
			_entity.TelNum = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "TelNum");
			_entity.Birthday = ObjectFactory<DateTime>.GetFromField(p_DataRow, _table_prefix + "Birthday");
            _entity.AccountNo = ObjectFactory<Guid>.GetFromField(p_DataRow, _table_prefix + "AccountNo");
            _entity.RoamingIP = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "RoamingIP");
            _entity.ChainStoreID = ObjectFactory<int>.GetFromField(p_DataRow, _table_prefix + "ChainStoreID");
            _entity.RoamingState = ObjectFactory<byte>.GetFromField(p_DataRow, _table_prefix + "RoamingState");
            _entity.RoamingName = ObjectFactory<string>.GetFromField(p_DataRow, _table_prefix + "RoamingName");
            _entity.OwnerShopID = ObjectFactory<byte>.GetFromField(p_DataRow, _table_prefix + "OwnerShopID");
			return _entity;
		
		}

		internal MemberEntity LoadEntity(DataRow p_DataRow)
		{
			MemberEntity _entity = new MemberEntity();

			_entity.CardSn = ObjectFactory<long>.GetFromField(p_DataRow, "CardSn");
			_entity.CardNo = ObjectFactory<long>.GetFromField(p_DataRow, "CardNo");
			_entity.LastBID = ObjectFactory<string>.GetFromField(p_DataRow, "LastBID");
			_entity.Name = ObjectFactory<string>.GetFromField(p_DataRow, "Name");
			_entity.CertType = ObjectFactory<int>.GetFromField(p_DataRow, "CertType");
			_entity.CertNo = ObjectFactory<string>.GetFromField(p_DataRow, "CertNo");
			_entity.Sex = ObjectFactory<bool>.GetFromField(p_DataRow, "Sex");
			_entity.VDate = ObjectFactory<DateTime?>.GetFromField(p_DataRow, "VDate");
			_entity.Pass = ObjectFactory<string>.GetFromField(p_DataRow, "Pass");
			_entity.CardType = ObjectFactory<string>.GetFromField(p_DataRow, "CardType");
			_entity.RegTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, "RegTime");
			_entity.YaJin = ObjectFactory<long>.GetFromField(p_DataRow, "YaJin");
			_entity.Bipi = ObjectFactory<int>.GetFromField(p_DataRow, "Bipi");
			_entity.Piao = ObjectFactory<int>.GetFromField(p_DataRow, "Piao");
			_entity.Cash = ObjectFactory<int>.GetFromField(p_DataRow, "Cash");
			_entity.Jifen = ObjectFactory<int>.GetFromField(p_DataRow, "Jifen");
			_entity.CardBNo = ObjectFactory<int>.GetFromField(p_DataRow, "CardBNo");
			_entity.State = ObjectFactory<byte>.GetFromField(p_DataRow, "State");
			_entity.CardState = ObjectFactory<byte>.GetFromField(p_DataRow, "CardState");
			_entity.LastCardTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, "LastCardTime");
			_entity.LPTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, "LPTime");
			_entity.DeviceID = ObjectFactory<string>.GetFromField(p_DataRow, "DeviceID");
			_entity.AddChongZhi = ObjectFactory<double>.GetFromField(p_DataRow, "AddChongZhi");
			_entity.AddB = ObjectFactory<int>.GetFromField(p_DataRow, "AddB");
			_entity.AddZengB = ObjectFactory<int>.GetFromField(p_DataRow, "AddZengB");
			_entity.CurZengB = ObjectFactory<int>.GetFromField(p_DataRow, "CurZengB");
			_entity.AddTouB = ObjectFactory<int>.GetFromField(p_DataRow, "AddTouB");
			_entity.AddTuiB = ObjectFactory<int>.GetFromField(p_DataRow, "AddTuiB");
			_entity.AddChongCash = ObjectFactory<double>.GetFromField(p_DataRow, "AddChongCash");
			_entity.AddTouCash = ObjectFactory<double>.GetFromField(p_DataRow, "AddTouCash");
			_entity.AddTuiCash = ObjectFactory<double>.GetFromField(p_DataRow, "AddTuiCash");
			_entity.AddOutP = ObjectFactory<int>.GetFromField(p_DataRow, "AddOutP");
			_entity.AddExCP = ObjectFactory<int>.GetFromField(p_DataRow, "AddExCP");
			_entity.AddTiB = ObjectFactory<int>.GetFromField(p_DataRow, "AddTiB");
			_entity.AddCB = ObjectFactory<int>.GetFromField(p_DataRow, "AddCB");
			_entity.AddGiftExB = ObjectFactory<int>.GetFromField(p_DataRow, "AddGiftExB");
			_entity.AddGiftExJiFen = ObjectFactory<int>.GetFromField(p_DataRow, "AddGiftExJiFen");
			_entity.AddJifen = ObjectFactory<int>.GetFromField(p_DataRow, "AddJifen");
			_entity.IsFormat = ObjectFactory<bool>.GetFromField(p_DataRow, "IsFormat");
			_entity.Comment = ObjectFactory<string>.GetFromField(p_DataRow, "Comment");
			_entity.TelNum = ObjectFactory<string>.GetFromField(p_DataRow, "TelNum");
			_entity.Birthday = ObjectFactory<DateTime>.GetFromField(p_DataRow, "Birthday");
			_entity.ZSType = ObjectFactory<byte>.GetFromField(p_DataRow, "ZSType");
			_entity.ZSBi = ObjectFactory<int>.GetFromField(p_DataRow, "ZSBi");
			_entity.Pe_Birth = ObjectFactory<DateTime>.GetFromField(p_DataRow, "Pe_Birth");
			_entity.Pe_Circle = ObjectFactory<DateTime>.GetFromField(p_DataRow, "Pe_Circle");
			_entity.Pe_CircleCount = ObjectFactory<int>.GetFromField(p_DataRow, "Pe_CircleCount");
			_entity.AddBackCash = ObjectFactory<int>.GetFromField(p_DataRow, "AddBackCash");
			_entity.RemainZBi = ObjectFactory<int>.GetFromField(p_DataRow, "RemainZBi");
			_entity.NextDate = ObjectFactory<DateTime>.GetFromField(p_DataRow, "NextDate");
			_entity.LastActiveRule = ObjectFactory<int>.GetFromField(p_DataRow, "LastActiveRule");
			_entity.LastActiveDate = ObjectFactory<DateTime>.GetFromField(p_DataRow, "LastActiveDate");
			_entity.RenZhengTime = ObjectFactory<DateTime>.GetFromField(p_DataRow, "RenZhengTime");
			_entity.CardVer = ObjectFactory<byte>.GetFromField(p_DataRow, "CardVer");
			_entity.QCDate = ObjectFactory<DateTime>.GetFromField(p_DataRow, "QCDate");
			_entity.YanzhengMa = ObjectFactory<string>.GetFromField(p_DataRow, "YanzhengMa");
            _entity.AccountNo = ObjectFactory<Guid>.GetFromField(p_DataRow, "AccountNo");
            _entity.FingerData = ObjectFactory<byte[]>.GetFromField(p_DataRow, "FingerData");
            _entity.RoamingTime = ObjectFactory<DateTime?>.GetFromField(p_DataRow, "RoamingTime");
            _entity.RoamingIP = ObjectFactory<string>.GetFromField(p_DataRow, "RoamingIP");
            _entity.ChainStoreID = ObjectFactory<int>.GetFromField(p_DataRow, "ChainStoreID");
            _entity.RoamingState = ObjectFactory<byte>.GetFromField(p_DataRow, "RoamingState");
            _entity.RoamingName = ObjectFactory<string>.GetFromField(p_DataRow, "RoamingName");
            _entity.OwnerShopID = ObjectFactory<byte>.GetFromField(p_DataRow, "OwnerShopID");
			return _entity;
		}

		#endregion

		#region 属性

        //protected MemberDataAccess MemberDataAccess
        //{
        //    set
        //    {
        //        m_MemberDataAccess = value;
        //    }
        //    get
        //    {
        //        return m_MemberDataAccess;
        //    }
        //}

		#endregion

		#region 公共方法

		public MemberEntity SelectByCardNo(long p_CardNo)
		{
			long _CardNo = p_CardNo;
			string _sql =
			@"
			SELECT 
				T_Account.* ,
				T_AcLiushui.RID as T_AcLiushui_RID,
				T_AcLiushui.CardNo as T_AcLiushui_CardNo,
				T_AcLiushui.qianbaoType as T_AcLiushui_qianbaoType,
				T_AcLiushui.QCDate as T_AcLiushui_QCDate,
				T_AcLiushui.jyValue as T_AcLiushui_jyValue,
				T_AcLiushui.yuE as T_AcLiushui_yuE,
				T_AcLiushui.JYType as T_AcLiushui_JYType,
				T_AcLiushui.JYNo as T_AcLiushui_JYNo,
				T_AcLiushui.UPdateTime as T_AcLiushui_UPdateTime,
				T_AcLiushui.SHState as T_AcLiushui_SHState
			FROM T_Account
			LEFT JOIN T_AcLiushui ON T_AcLiushui.CardNo=T_Account.CardNo
			WHERE T_Account.CardNo=@CardNo
			";

			SqlParameter[] _params = new SqlParameter[]
			{
				new SqlParameter("@CardNo",_CardNo)
			};

			DataSet _dataset;
			if (this.SqlTran != null)
			{
				_dataset = SqlHelper.ExecuteDataset(this.SqlTran, CommandType.Text, _sql, _params);
			}
			else
			{
				_dataset = SqlHelper.ExecuteDataset(CommandType.Text, _sql, _params);
			}

			DataTable _datatable = _dataset.Tables[0];
			if (_datatable.Rows.Count == 0)
			{
				return null;
			}

			MemberEntity _entity = LoadEntity(_datatable.Rows[0]);
			
			foreach (DataRow _row in _datatable.Rows)
			{
				_entity.LiuShui.Add(TransLiushuiDataAccess.LoadForeignKeyEntity(_row));
			}

			return _entity;

		}

		public int Update(MemberEntity p_CurrentEntity)
        {
            MemberEntity accountInfo = p_CurrentEntity;

            #region SQL

            string sql =
            @"
            UPDATE [Icgamedb].[dbo].[T_Account]
               SET [CardSn] = @CardSn
                  ,[CardNo] = @CardNo
                  ,[LastBID] = @LastBID
                  ,[Name] = @Name
                  ,[CertType] = @CertType
                  ,[CertNo] = @CertNo
                  ,[Sex] = @Sex
                  ,[VDate] = @VDate
                  ,[Pass] = @Pass
                  ,[CardType] = @CardType
                  ,[RegTime] = @RegTime
                  ,[YaJin] = @YaJin
                  ,[Bipi] = @Bipi
                  ,[Piao] = @Piao
                  ,[Cash] = @Cash
                  ,[Jifen] = @Jifen
                  ,[CardBNo] = @CardBNo
                  ,[State] = @State
                  ,[CardState] = @CardState
                  ,[LastCardTime] = @LastCardTime
                  ,[LPTime] = @LPTime
                  ,[DeviceID] = @DeviceID
                  ,[AddChongZhi] = @AddChongZhi
                  ,[AddB] = @AddB
                  ,[AddZengB] = @AddZengB
                  ,[CurZengB] = @CurZengB
                  ,[AddTouB] = @AddTouB
                  ,[AddTuiB] = @AddTuiB
                  ,[AddChongCash] = @AddChongCash
                  ,[AddTouCash] = @AddTouCash
                  ,[AddTuiCash] = @AddTuiCash
                  ,[AddOutP] = @AddOutP
                  ,[AddExCP] = @AddExCP
                  ,[AddTiB] = @AddTiB
                  ,[AddCB] = @AddCB
                  ,[AddGiftExB] = @AddGiftExB
                  ,[AddGiftExJiFen] = @AddGiftExJiFen
                  ,[AddJifen] = @AddJifen
                  ,[IsFormat] = @IsFormat
                  ,[Comment] = @Comment
                  ,[TelNum] = @TelNum
                  ,[Birthday] = @Birthday
                  ,[ZSType] = @ZSType
                  ,[ZSBi] = @ZSBi
                  ,[Pe_Birth] = @Pe_Birth
                  ,[Pe_Circle] = @Pe_Circle
                  ,[Pe_CircleCount] = @Pe_CircleCount
                  ,[AddBackCash] = @AddBackCash
                  ,[RemainZBi] = @RemainZBi
                  ,[NextDate] = @NextDate
                  ,[LastActiveRule] = @LastActiveRule
                  ,[LastActiveDate] = @LastActiveDate
                  ,[RenZhengTime] = @RenZhengTime
                  ,[CardVer] = @CardVer
                  ,[QCDate] = @QCDate
                  ,[YanzhengMa] = @YanzhengMa
                  ,[RoamingTime] = @RoamingTime
                  ,[RoamingIP] = @RoamingIP
                  ,[ChainStoreID] = @ChainStoreID
                  ,[RoamingState] = @RoamingState
                  ,[RoamingName] = @RoamingName
                  ,[FingerData] = @FingerData
                  ,[OwnerShopID]=@OwnerShopID
             WHERE [AccountNo]=@AccountNo
            ";

            #endregion

            #region Params

            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@AccountNo",accountInfo.AccountNo),
                new SqlParameter("@AddB",accountInfo.AddB),
                new SqlParameter("@AddBackCash",accountInfo.AddBackCash),
                new SqlParameter("@AddCB",accountInfo.AddCB),
                new SqlParameter("@AddChongCash",accountInfo.AddChongCash),
                new SqlParameter("@AddChongZhi",accountInfo.AddChongZhi),
                new SqlParameter("@AddExCP",accountInfo.AddExCP),
                new SqlParameter("@AddGiftExB",accountInfo.AddGiftExB),
                new SqlParameter("@AddGiftExJiFen",accountInfo.AddGiftExJiFen),
                new SqlParameter("@AddJifen",accountInfo.AddJifen),
                new SqlParameter("@AddOutP",accountInfo.AddOutP),
                new SqlParameter("@AddTiB",accountInfo.AddTiB),
                new SqlParameter("@AddTouB",accountInfo.AddTouB),
                new SqlParameter("@AddTouCash",accountInfo.AddTouCash),
                new SqlParameter("@AddTuiB",accountInfo.AddTuiB),
                new SqlParameter("@AddTuiCash",accountInfo.AddTuiCash),
                new SqlParameter("@AddZengB",accountInfo.AddZengB),
                new SqlParameter("@Bipi",accountInfo.Bipi),
                new SqlParameter("@Birthday",getDbDateTime(accountInfo.Birthday)),
                new SqlParameter("@CardBNo",accountInfo.CardBNo),
                new SqlParameter("@CardNo",accountInfo.CardNo),
                new SqlParameter("@CardSn",accountInfo.CardSn),
                new SqlParameter("@CardState",accountInfo.CardState),
                new SqlParameter("@CardType",accountInfo.CardType),
                new SqlParameter("@CardVer",accountInfo.CardVer),
                new SqlParameter("@Cash",accountInfo.Cash),
                new SqlParameter("@CertNo",accountInfo.CertNo),
                new SqlParameter("@CertType",accountInfo.CertType),
                new SqlParameter("@Comment",accountInfo.Comment),
                new SqlParameter("@CurZengB",accountInfo.CurZengB),
                new SqlParameter("@DeviceID",accountInfo.DeviceID),
                new SqlParameter("@FingerData", accountInfo.FingerData),
                new SqlParameter("@IsFormat",accountInfo.IsFormat),
                new SqlParameter("@Jifen",accountInfo.Jifen),
                new SqlParameter("@LastActiveDate",getDbDateTime(accountInfo.LastActiveDate)),
                new SqlParameter("@LastActiveRule",accountInfo.LastActiveRule),
                new SqlParameter("@LastBID",accountInfo.LastBID),
                new SqlParameter("@LastCardTime",getDbDateTime(accountInfo.LastCardTime)),
                new SqlParameter("@LPTime",getDbDateTime(accountInfo.LPTime)),
                new SqlParameter("@Name",accountInfo.Name),
                new SqlParameter("@NextDate",getDbDateTime(accountInfo.NextDate)),
                new SqlParameter("@Pass",accountInfo.Pass),
                new SqlParameter("@Pe_Birth",getDbDateTime(accountInfo.Pe_Birth)),
                new SqlParameter("@Pe_Circle",getDbDateTime(accountInfo.Pe_Circle)),
                new SqlParameter("@Pe_CircleCount",accountInfo.Pe_CircleCount),
                new SqlParameter("@Piao",accountInfo.Piao),
                new SqlParameter("@QCDate",getDbDateTime(accountInfo.QCDate)),
                new SqlParameter("@RegTime",getDbDateTime(accountInfo.RegTime)),
                new SqlParameter("@RemainZBi",accountInfo.RemainZBi),
                new SqlParameter("@RenZhengTime",getDbDateTime(accountInfo.RenZhengTime)),
                new SqlParameter("@Sex",accountInfo.Sex),
                new SqlParameter("@State",accountInfo.State),
                new SqlParameter("@TelNum",accountInfo.TelNum),
                new SqlParameter("@VDate",accountInfo.VDate.HasValue?getDbDateTime(accountInfo.VDate.Value):accountInfo.VDate),
                new SqlParameter("@YaJin",accountInfo.YaJin),
                new SqlParameter("@YanzhengMa",accountInfo.YanzhengMa),
                new SqlParameter("@ZSBi",accountInfo.ZSBi),
                new SqlParameter("@ZSType",accountInfo.ZSType),
                new SqlParameter("@RoamingIP",accountInfo.RoamingIP),
                new SqlParameter("@RoamingName",accountInfo.RoamingName),
                new SqlParameter("@RoamingState",accountInfo.RoamingState),
                new SqlParameter("@RoamingTime",accountInfo.RoamingTime.HasValue?getDbDateTime(accountInfo.RoamingTime.Value):accountInfo.RoamingTime),
                new SqlParameter("@ChainStoreID",accountInfo.ChainStoreID),
                new SqlParameter("@OwnerShopID",accountInfo.OwnerShopID),
            };

            #endregion

            int result = 0;

            if (SqlTran != null)
            {
                result = SqlHelper.ExecuteNonQuery(SqlTran, CommandType.Text, sql, parameters);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(SqlConn, CommandType.Text, sql, parameters);
            }
            return result;
		}

        private object getDbDateTime(DateTime? dateTime)
        {
            if (dateTime == null 
                || dateTime.Equals(DateTime.MinValue) 
                || dateTime.Equals(DateTime.MaxValue) 
                || dateTime.Equals(Convert.ToDateTime("1753-1-1 13:00:00")))
            {
                return DBNull.Value;
                //return Convert.ToDateTime("1753-1-1 13:00:00");
            }

            return dateTime;
        }

		public int Insert(MemberEntity p_NewMemberEntity)
		{
            MemberEntity accountInfo = p_NewMemberEntity;

            Delete(accountInfo);
            #region SQL
            string sql =
            @"
            INSERT INTO [Icgamedb].[dbo].[T_Account]
                       ([CardSn]
                       ,[CardNo]
                       ,[LastBID]
                       ,[Name]
                       ,[CertType]
                       ,[CertNo]
                       ,[Sex]
                       ,[VDate]
                       ,[Pass]
                       ,[CardType]
                       ,[RegTime]
                       ,[YaJin]
                       ,[Bipi]
                       ,[Piao]
                       ,[Cash]
                       ,[Jifen]
                       ,[CardBNo]
                       ,[State]
                       ,[CardState]
                       ,[LastCardTime]
                       ,[LPTime]
                       ,[DeviceID]
                       ,[AddChongZhi]
                       ,[AddB]
                       ,[AddZengB]
                       ,[CurZengB]
                       ,[AddTouB]
                       ,[AddTuiB]
                       ,[AddChongCash]
                       ,[AddTouCash]
                       ,[AddTuiCash]
                       ,[AddOutP]
                       ,[AddExCP]
                       ,[AddTiB]
                       ,[AddCB]
                       ,[AddGiftExB]
                       ,[AddGiftExJiFen]
                       ,[AddJifen]
                       ,[IsFormat]
                       ,[Comment]
                       ,[TelNum]
                       ,[Birthday]
                       ,[ZSType]
                       ,[ZSBi]
                       ,[Pe_Birth]
                       ,[Pe_Circle]
                       ,[Pe_CircleCount]
                       ,[AddBackCash]
                       ,[RemainZBi]
                       ,[NextDate]
                       ,[LastActiveRule]
                       ,[LastActiveDate]
                       ,[RenZhengTime]
                       ,[CardVer]
                       ,[QCDate]
                       ,[YanzhengMa]
                       ,[RoamingTime]
                       ,[RoamingIP]
                       ,[ChainStoreID]
                       ,[RoamingState]
                       ,[RoamingName]
                       ,[FingerData]
                        ,[OwnerShopID]
                    )
                 VALUES
                       (@CardSn
                       ,@CardNo
                       ,@LastBID
                       ,@Name
                       ,@CertType
                       ,@CertNo
                       ,@Sex
                       ,@VDate
                       ,@Pass
                       ,@CardType
                       ,@RegTime
                       ,@YaJin
                       ,@Bipi
                       ,@Piao
                       ,@Cash
                       ,@Jifen
                       ,@CardBNo
                       ,@State
                       ,@CardState
                       ,@LastCardTime
                       ,@LPTime
                       ,@DeviceID
                       ,@AddChongZhi
                       ,@AddB
                       ,@AddZengB
                       ,@CurZengB
                       ,@AddTouB
                       ,@AddTuiB
                       ,@AddChongCash
                       ,@AddTouCash
                       ,@AddTuiCash
                       ,@AddOutP
                       ,@AddExCP
                       ,@AddTiB
                       ,@AddCB
                       ,@AddGiftExB
                       ,@AddGiftExJiFen
                       ,@AddJifen
                       ,@IsFormat
                       ,@Comment
                       ,@TelNum
                       ,@Birthday
                       ,@ZSType
                       ,@ZSBi
                       ,@Pe_Birth
                       ,@Pe_Circle
                       ,@Pe_CircleCount
                       ,@AddBackCash
                       ,@RemainZBi
                       ,@NextDate
                       ,@LastActiveRule
                       ,@LastActiveDate
                       ,@RenZhengTime
                       ,@CardVer
                       ,@QCDate
                       ,@YanzhengMa
                       ,@RoamingTime
                       ,@RoamingIP
                       ,@ChainStoreID
                       ,@RoamingState
                       ,@RoamingName
                       ,@FingerData
                        ,@OwnerShopID)
            ";
            #endregion

            #region Params

            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@AccountNo",accountInfo.AccountNo),
                new SqlParameter("@AddB",accountInfo.AddB),
                new SqlParameter("@AddBackCash",accountInfo.AddBackCash),
                new SqlParameter("@AddCB",accountInfo.AddCB),
                new SqlParameter("@AddChongCash",accountInfo.AddChongCash),
                new SqlParameter("@AddChongZhi",accountInfo.AddChongZhi),
                new SqlParameter("@AddExCP",accountInfo.AddExCP),
                new SqlParameter("@AddGiftExB",accountInfo.AddGiftExB),
                new SqlParameter("@AddGiftExJiFen",accountInfo.AddGiftExJiFen),
                new SqlParameter("@AddJifen",accountInfo.AddJifen),
                new SqlParameter("@AddOutP",accountInfo.AddOutP),
                new SqlParameter("@AddTiB",accountInfo.AddTiB),
                new SqlParameter("@AddTouB",accountInfo.AddTouB),
                new SqlParameter("@AddTouCash",accountInfo.AddTouCash),
                new SqlParameter("@AddTuiB",accountInfo.AddTuiB),
                new SqlParameter("@AddTuiCash",accountInfo.AddTuiCash),
                new SqlParameter("@AddZengB",accountInfo.AddZengB),
                new SqlParameter("@Bipi",accountInfo.Bipi),
                new SqlParameter("@Birthday",getDbDateTime(accountInfo.Birthday)),
                new SqlParameter("@CardBNo",accountInfo.CardBNo),
                new SqlParameter("@CardNo",accountInfo.CardNo),
                new SqlParameter("@CardSn",accountInfo.CardSn),
                new SqlParameter("@CardState",accountInfo.CardState),
                new SqlParameter("@CardType",accountInfo.CardType),
                new SqlParameter("@CardVer",accountInfo.CardVer),
                new SqlParameter("@Cash",accountInfo.Cash),
                new SqlParameter("@CertNo",accountInfo.CertNo),
                new SqlParameter("@CertType",accountInfo.CertType),
                new SqlParameter("@Comment",accountInfo.Comment),
                new SqlParameter("@CurZengB",accountInfo.CurZengB),
                new SqlParameter("@DeviceID",accountInfo.DeviceID),
                new SqlParameter("@FingerData",accountInfo.FingerData),
                new SqlParameter("@IsFormat",accountInfo.IsFormat),
                new SqlParameter("@Jifen",accountInfo.Jifen),
                new SqlParameter("@LastActiveDate",getDbDateTime(accountInfo.LastActiveDate)),
                new SqlParameter("@LastActiveRule",accountInfo.LastActiveRule),
                new SqlParameter("@LastBID",accountInfo.LastBID),
                new SqlParameter("@LastCardTime",getDbDateTime(accountInfo.LastCardTime)),
                new SqlParameter("@LPTime",getDbDateTime(accountInfo.LPTime)),
                new SqlParameter("@Name",accountInfo.Name),
                new SqlParameter("@NextDate",getDbDateTime(accountInfo.NextDate)),
                new SqlParameter("@Pass",accountInfo.Pass),
                new SqlParameter("@Pe_Birth",getDbDateTime(accountInfo.Pe_Birth)),
                new SqlParameter("@Pe_Circle",getDbDateTime(accountInfo.Pe_Circle)),
                new SqlParameter("@Pe_CircleCount",accountInfo.Pe_CircleCount),
                new SqlParameter("@Piao",accountInfo.Piao),
                new SqlParameter("@QCDate",getDbDateTime(accountInfo.QCDate)),
                new SqlParameter("@RegTime",getDbDateTime(accountInfo.RegTime)),
                new SqlParameter("@RemainZBi",accountInfo.RemainZBi),
                new SqlParameter("@RenZhengTime",getDbDateTime(accountInfo.RenZhengTime)),
                new SqlParameter("@Sex",accountInfo.Sex),
                new SqlParameter("@State",accountInfo.State),
                new SqlParameter("@TelNum",accountInfo.TelNum),
                new SqlParameter("@VDate",accountInfo.VDate.HasValue?getDbDateTime(accountInfo.VDate.Value):accountInfo.VDate),
                new SqlParameter("@YaJin",accountInfo.YaJin),
                new SqlParameter("@YanzhengMa",accountInfo.YanzhengMa),
                new SqlParameter("@ZSBi",accountInfo.ZSBi),
                new SqlParameter("@ZSType",accountInfo.ZSType),
                new SqlParameter("@RoamingIP",accountInfo.RoamingIP),
                new SqlParameter("@RoamingName",accountInfo.RoamingName),
                new SqlParameter("@RoamingState",accountInfo.RoamingState),
                new SqlParameter("@RoamingTime",accountInfo.RoamingTime.HasValue?getDbDateTime(accountInfo.RoamingTime.Value):accountInfo.RoamingTime),
                new SqlParameter("@ChainStoreID",accountInfo.ChainStoreID),
                new SqlParameter("@OwnerShopID",accountInfo.OwnerShopID),
            };

            #endregion

            object result = 0;

            if (SqlTran != null)
            {
                result = SqlHelper.ExecuteNonQuery(SqlTran, CommandType.Text, sql, parameters);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(SqlConn, CommandType.Text, sql, parameters);
            }

            return Convert.ToInt32(result);

			//return Convert.ToInt32(this.MemberDataAccess.AddMemberAccount(p_NewMemberEntity));
		}

        public int Delete(MemberEntity p_OldMemberEntity)
        {
            MemberEntity entity = p_OldMemberEntity;
            string sql = @"DELETE FROM T_Account WHERE CardNo=@CardNo";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CardNo",entity.CardNo)
            };

            int result = 0;
            if (SqlTran != null)
            {
                result = SqlHelper.ExecuteNonQuery(SqlTran, CommandType.Text, sql, parameters);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(SqlConn, CommandType.Text, sql, parameters);
            }

            return result;
        }

        public List<MemberInfoEntity> SelectAllByNone()
		{
			string _sql =
			@"
			SELECT  V_Account.*  FROM V_Account
			";

			DataSet _dataset;
			if (this.SqlTran != null)
			{
				_dataset = SqlHelper.ExecuteDataset(this.SqlTran, CommandType.Text, _sql);
			}
			else
			{
				_dataset = SqlHelper.ExecuteDataset(CommandType.Text, _sql);
			}

			DataTable _datatable = _dataset.Tables[0];
			if (_datatable.Rows.Count == 0)
			{
				return null;
			}

            List<MemberInfoEntity> _list = new List<MemberInfoEntity>();
			foreach (DataRow _row in _datatable.Rows)
			{
                MemberInfoEntity _entity = MemberInfoEntityFactory.Fill(_row);
				_list.Add(_entity);
			}

			return _list;

		}

        public List<MemberInfoEntity> SelectByLPTime(DateTime p_StartTime, DateTime p_EndTime)
        {
            string _sql =
            @"
			SELECT  V_Account.*  FROM V_Account WHERE LPTime BETWEEN @StartTime AND @EndTime
			";
            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@StartTime",p_StartTime),
                new SqlParameter("@EndTime",p_EndTime),
            
            };
            DataSet _dataset;
            if (this.SqlTran != null)
            {
                _dataset = SqlHelper.ExecuteDataset(this.SqlTran, CommandType.Text, _sql, parameters);
            }
            else
            {
                _dataset = SqlHelper.ExecuteDataset(this.SqlConn,CommandType.Text, _sql, parameters);
            }

            List<MemberInfoEntity> _list = new List<MemberInfoEntity>();

            DataTable _datatable = _dataset.Tables[0];
            if (_datatable.Rows.Count == 0)
            {
                return _list;
            }
            else
            {
                foreach (DataRow _row in _datatable.Rows)
                {
                    MemberInfoEntity _entity = MemberInfoEntityFactory.Fill(_row);
                    _list.Add(_entity);
                }
            }

            return _list;
        }

        public List<MemberEntity> SelectByRegTime(DateTime p_StartTime, DateTime p_EndTime)
        {
            string _sql =
            @"
			SELECT  T_Account.*  FROM T_Account WHERE RegTime BETWEEN @StartTime AND @EndTime
			";
            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@StartTime",p_StartTime),
                new SqlParameter("@EndTime",p_EndTime),
            
            };
            DataSet _dataset;
            if (this.SqlTran != null)
            {
                _dataset = SqlHelper.ExecuteDataset(this.SqlTran, CommandType.Text, _sql, parameters);
            }
            else
            {
                _dataset = SqlHelper.ExecuteDataset(this.SqlConn, CommandType.Text, _sql, parameters);
            }

            List<MemberEntity> _list = new List<MemberEntity>();

            DataTable _datatable = _dataset.Tables[0];
            if (_datatable.Rows.Count == 0)
            {
                return _list;
            }
            else
            {
                foreach (DataRow _row in _datatable.Rows)
                {
                    MemberEntity _entity = LoadEntity(_row);
                    _list.Add(_entity);
                }
            }

            return _list;
        }

		#endregion

        #region 其他方法

        /// <summary>
        /// 如果不存在，进行插入；否则更新
        /// </summary>
        /// <param name="Entity">实体对象</param>
        /// <param name="ErrStr">失败原因</param>
        /// <returns>返回是否成功</returns>
        public override bool InsertUpdate(EntityBase Entity, out string ErrStr)
        {
            ErrStr = "";
            string sqlStr = "select count(CardNo) from T_Account where CardNo='" + (Entity as GameHall.Entity.AccountEntity).CardNo + "'";

            try
            {
                int Count = ExecSqlToCount(sqlStr, null);
                return Count > 0 ? (Update((GameHall.Entity.AccountEntity)Entity) > 0) : (Insert((GameHall.Entity.AccountEntity)Entity) > 0);
            }
            catch (Exception E)
            {
                ErrStr = E.Message;
                return false;
            }
        }


        public int Update(GameHall.Entity.AccountEntity accountInfo)
        {
            #region SQL

            string sql =
            @"
            UPDATE [Icgamedb].[dbo].[T_Account]
               SET [CardSn] = @CardSn
                  ,[CardNo] = @CardNo
                  ,[LastBID] = @LastBID
                  ,[Name] = @Name
                  ,[CertType] = @CertType
                  ,[CertNo] = @CertNo
                  ,[Sex] = @Sex
                  ,[VDate] = @VDate
                  ,[Pass] = @Pass
                  ,[CardType] = @CardType
                  ,[RegTime] = @RegTime
                  ,[YaJin] = @YaJin
                  ,[Bipi] = @Bipi
                  ,[Piao] = @Piao
                  ,[Cash] = @Cash
                  ,[Jifen] = @Jifen
                  ,[CardBNo] = @CardBNo
                  ,[State] = @State
                  ,[CardState] = @CardState
                  ,[LastCardTime] = @LastCardTime
                  ,[LPTime] = @LPTime
                  ,[DeviceID] = @DeviceID
                  ,[AddChongZhi] = @AddChongZhi
                  ,[AddB] = @AddB
                  ,[AddZengB] = @AddZengB
                  ,[CurZengB] = @CurZengB
                  ,[AddTouB] = @AddTouB
                  ,[AddTuiB] = @AddTuiB
                  ,[AddChongCash] = @AddChongCash
                  ,[AddTouCash] = @AddTouCash
                  ,[AddTuiCash] = @AddTuiCash
                  ,[AddOutP] = @AddOutP
                  ,[AddExCP] = @AddExCP
                  ,[AddTiB] = @AddTiB
                  ,[AddCB] = @AddCB
                  ,[AddGiftExB] = @AddGiftExB
                  ,[AddGiftExJiFen] = @AddGiftExJiFen
                  ,[AddJifen] = @AddJifen
                  ,[IsFormat] = @IsFormat
                  ,[Comment] = @Comment
                  ,[TelNum] = @TelNum
                  ,[Birthday] = @Birthday
                  ,[ZSType] = @ZSType
                  ,[ZSBi] = @ZSBi
                  ,[Pe_Birth] = @Pe_Birth
                  ,[Pe_Circle] = @Pe_Circle
                  ,[Pe_CircleCount] = @Pe_CircleCount
                  ,[AddBackCash] = @AddBackCash
                  ,[RemainZBi] = @RemainZBi
                  ,[NextDate] = @NextDate
                  ,[LastActiveRule] = @LastActiveRule
                  ,[LastActiveDate] = @LastActiveDate
                  ,[RenZhengTime] = @RenZhengTime
                  ,[CardVer] = @CardVer
                  ,[QCDate] = @QCDate
                  ,[YanzhengMa] = @YanzhengMa
                  ,[RoamingTime] = @RoamingTime
                  ,[RoamingIP] = @RoamingIP
                  ,[ChainStoreID] = @ChainStoreID
                  ,[RoamingState] = @RoamingState
                  ,[RoamingName] = @RoamingName
                  ,[OwnerShopID] = @OwnerShopID
             WHERE [CardNo]=@CardNo
            ";

            #endregion

            #region Params

            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@AccountNo",accountInfo.AccountNo),
                new SqlParameter("@AddB",accountInfo.AddB),
                new SqlParameter("@AddBackCash",accountInfo.AddBackCash),
                new SqlParameter("@AddCB",accountInfo.AddCB),
                new SqlParameter("@AddChongCash",accountInfo.AddChongCash),
                new SqlParameter("@AddChongZhi",accountInfo.AddChongZhi),
                new SqlParameter("@AddExCP",accountInfo.AddExCP),
                new SqlParameter("@AddGiftExB",accountInfo.AddGiftExB),
                new SqlParameter("@AddGiftExJiFen",accountInfo.AddGiftExJiFen),
                new SqlParameter("@AddJifen",accountInfo.AddJifen),
                new SqlParameter("@AddOutP",accountInfo.AddOutP),
                new SqlParameter("@AddTiB",accountInfo.AddTiB),
                new SqlParameter("@AddTouB",accountInfo.AddTouB),
                new SqlParameter("@AddTouCash",accountInfo.AddTouCash),
                new SqlParameter("@AddTuiB",accountInfo.AddTuiB),
                new SqlParameter("@AddTuiCash",accountInfo.AddTuiCash),
                new SqlParameter("@AddZengB",accountInfo.AddZengB),
                new SqlParameter("@Bipi",accountInfo.Bipi),
                new SqlParameter("@Birthday",getDbDateTime(accountInfo.Birthday)),
                new SqlParameter("@CardBNo",accountInfo.CardBNo),
                new SqlParameter("@CardNo",accountInfo.CardNo),
                new SqlParameter("@CardSn",accountInfo.CardSn),
                new SqlParameter("@CardState",accountInfo.CardState),
                new SqlParameter("@CardType",accountInfo.CardType),
                new SqlParameter("@CardVer",accountInfo.CardVer),
                new SqlParameter("@Cash",accountInfo.Cash),
                new SqlParameter("@CertNo",accountInfo.CertNo),
                new SqlParameter("@CertType",accountInfo.CertType),
                new SqlParameter("@Comment",accountInfo.Comment),
                new SqlParameter("@CurZengB",accountInfo.CurZengB),
                new SqlParameter("@DeviceID",accountInfo.DeviceID),
                new SqlParameter("@IsFormat",accountInfo.IsFormat),
                new SqlParameter("@Jifen",accountInfo.Jifen),
                new SqlParameter("@LastActiveDate",getDbDateTime(accountInfo.LastActiveDate)),
                new SqlParameter("@LastActiveRule",accountInfo.LastActiveRule),
                new SqlParameter("@LastBID",accountInfo.LastBID),
                new SqlParameter("@LastCardTime",getDbDateTime(accountInfo.LastCardTime)),
                new SqlParameter("@LPTime",getDbDateTime(accountInfo.LPTime)),
                new SqlParameter("@Name",accountInfo.Name),
                new SqlParameter("@NextDate",getDbDateTime(accountInfo.NextDate)),
                new SqlParameter("@Pass",accountInfo.Pass),
                new SqlParameter("@Pe_Birth",getDbDateTime(accountInfo.Pe_Birth)),
                new SqlParameter("@Pe_Circle",getDbDateTime(accountInfo.Pe_Circle)),
                new SqlParameter("@Pe_CircleCount",accountInfo.Pe_CircleCount),
                new SqlParameter("@Piao",accountInfo.Piao),
                new SqlParameter("@QCDate",getDbDateTime(accountInfo.QCDate)),
                new SqlParameter("@RegTime",getDbDateTime(accountInfo.RegTime)),
                new SqlParameter("@RemainZBi",accountInfo.RemainZBi),
                new SqlParameter("@RenZhengTime",getDbDateTime(accountInfo.RenZhengTime)),
                new SqlParameter("@Sex",accountInfo.Sex),
                new SqlParameter("@State",accountInfo.State),
                new SqlParameter("@TelNum",accountInfo.TelNum),
                new SqlParameter("@VDate",accountInfo.VDate.HasValue?getDbDateTime(accountInfo.VDate.Value):accountInfo.VDate),
                new SqlParameter("@YaJin",accountInfo.YaJin),
                new SqlParameter("@YanzhengMa",accountInfo.YanzhengMa),
                new SqlParameter("@ZSBi",accountInfo.ZSBi),
                new SqlParameter("@ZSType",accountInfo.ZSType),
                new SqlParameter("@RoamingIP",accountInfo.RoamingIP),
                new SqlParameter("@RoamingName",accountInfo.RoamingName),
                new SqlParameter("@RoamingState",accountInfo.RoamingState),
                new SqlParameter("@RoamingTime",accountInfo.RoamingTime.HasValue?getDbDateTime(accountInfo.RoamingTime.Value):accountInfo.RoamingTime),
                new SqlParameter("@ChainStoreID",accountInfo.ChainStoreID),
                new SqlParameter("@OwnerShopID",accountInfo.OwnerShopID)
            };

            #endregion

            int result = 0;

            if (SqlTran != null)
            {
                result = SqlHelper.ExecuteNonQuery(SqlTran, CommandType.Text, sql, parameters);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(SqlConn, CommandType.Text, sql, parameters);
            }
            return result;
        }

        public int Insert(GameHall.Entity.AccountEntity accountInfo)
        {
            MemberEntity Entity=new MemberEntity();
            Entity.CardNo = accountInfo.CardNo;
            Delete(Entity);
            #region SQL
            string sql =
            @"
            INSERT INTO [Icgamedb].[dbo].[T_Account]
                       ([CardSn]
                       ,[CardNo]
                       ,[LastBID]
                       ,[Name]
                       ,[CertType]
                       ,[CertNo]
                       ,[Sex]
                       ,[VDate]
                       ,[Pass]
                       ,[CardType]
                       ,[RegTime]
                       ,[YaJin]
                       ,[Bipi]
                       ,[Piao]
                       ,[Cash]
                       ,[Jifen]
                       ,[CardBNo]
                       ,[State]
                       ,[CardState]
                       ,[LastCardTime]
                       ,[LPTime]
                       ,[DeviceID]
                       ,[AddChongZhi]
                       ,[AddB]
                       ,[AddZengB]
                       ,[CurZengB]
                       ,[AddTouB]
                       ,[AddTuiB]
                       ,[AddChongCash]
                       ,[AddTouCash]
                       ,[AddTuiCash]
                       ,[AddOutP]
                       ,[AddExCP]
                       ,[AddTiB]
                       ,[AddCB]
                       ,[AddGiftExB]
                       ,[AddGiftExJiFen]
                       ,[AddJifen]
                       ,[IsFormat]
                       ,[Comment]
                       ,[TelNum]
                       ,[Birthday]
                       ,[ZSType]
                       ,[ZSBi]
                       ,[Pe_Birth]
                       ,[Pe_Circle]
                       ,[Pe_CircleCount]
                       ,[AddBackCash]
                       ,[RemainZBi]
                       ,[NextDate]
                       ,[LastActiveRule]
                       ,[LastActiveDate]
                       ,[RenZhengTime]
                       ,[CardVer]
                       ,[QCDate]
                       ,[YanzhengMa]
                       ,[RoamingTime]
                       ,[RoamingIP]
                       ,[ChainStoreID]
                       ,[RoamingState]
                       ,[RoamingName]
                       ,[OwnerShopID])
                 VALUES
                       (@CardSn
                       ,@CardNo
                       ,@LastBID
                       ,@Name
                       ,@CertType
                       ,@CertNo
                       ,@Sex
                       ,@VDate
                       ,@Pass
                       ,@CardType
                       ,@RegTime
                       ,@YaJin
                       ,@Bipi
                       ,@Piao
                       ,@Cash
                       ,@Jifen
                       ,@CardBNo
                       ,@State
                       ,@CardState
                       ,@LastCardTime
                       ,@LPTime
                       ,@DeviceID
                       ,@AddChongZhi
                       ,@AddB
                       ,@AddZengB
                       ,@CurZengB
                       ,@AddTouB
                       ,@AddTuiB
                       ,@AddChongCash
                       ,@AddTouCash
                       ,@AddTuiCash
                       ,@AddOutP
                       ,@AddExCP
                       ,@AddTiB
                       ,@AddCB
                       ,@AddGiftExB
                       ,@AddGiftExJiFen
                       ,@AddJifen
                       ,@IsFormat
                       ,@Comment
                       ,@TelNum
                       ,@Birthday
                       ,@ZSType
                       ,@ZSBi
                       ,@Pe_Birth
                       ,@Pe_Circle
                       ,@Pe_CircleCount
                       ,@AddBackCash
                       ,@RemainZBi
                       ,@NextDate
                       ,@LastActiveRule
                       ,@LastActiveDate
                       ,@RenZhengTime
                       ,@CardVer
                       ,@QCDate
                       ,@YanzhengMa
                       ,@RoamingTime
                       ,@RoamingIP
                       ,@ChainStoreID
                       ,@RoamingState
                       ,@RoamingName
                       ,@OwnerShopID)
            ";
            #endregion

            #region Params

            SqlParameter[] parameters = new SqlParameter[] 
            {
                new SqlParameter("@AccountNo",accountInfo.AccountNo),
                new SqlParameter("@AddB",accountInfo.AddB),
                new SqlParameter("@AddBackCash",accountInfo.AddBackCash),
                new SqlParameter("@AddCB",accountInfo.AddCB),
                new SqlParameter("@AddChongCash",accountInfo.AddChongCash),
                new SqlParameter("@AddChongZhi",accountInfo.AddChongZhi),
                new SqlParameter("@AddExCP",accountInfo.AddExCP),
                new SqlParameter("@AddGiftExB",accountInfo.AddGiftExB),
                new SqlParameter("@AddGiftExJiFen",accountInfo.AddGiftExJiFen),
                new SqlParameter("@AddJifen",accountInfo.AddJifen),
                new SqlParameter("@AddOutP",accountInfo.AddOutP),
                new SqlParameter("@AddTiB",accountInfo.AddTiB),
                new SqlParameter("@AddTouB",accountInfo.AddTouB),
                new SqlParameter("@AddTouCash",accountInfo.AddTouCash),
                new SqlParameter("@AddTuiB",accountInfo.AddTuiB),
                new SqlParameter("@AddTuiCash",accountInfo.AddTuiCash),
                new SqlParameter("@AddZengB",accountInfo.AddZengB),
                new SqlParameter("@Bipi",accountInfo.Bipi),
                new SqlParameter("@Birthday",getDbDateTime(accountInfo.Birthday)),
                new SqlParameter("@CardBNo",accountInfo.CardBNo),
                new SqlParameter("@CardNo",accountInfo.CardNo),
                new SqlParameter("@CardSn",accountInfo.CardSn),
                new SqlParameter("@CardState",accountInfo.CardState),
                new SqlParameter("@CardType",accountInfo.CardType),
                new SqlParameter("@CardVer",accountInfo.CardVer),
                new SqlParameter("@Cash",accountInfo.Cash),
                new SqlParameter("@CertNo",accountInfo.CertNo),
                new SqlParameter("@CertType",accountInfo.CertType),
                new SqlParameter("@Comment",accountInfo.Comment),
                new SqlParameter("@CurZengB",accountInfo.CurZengB),
                new SqlParameter("@DeviceID",accountInfo.DeviceID),
                new SqlParameter("@IsFormat",accountInfo.IsFormat),
                new SqlParameter("@Jifen",accountInfo.Jifen),
                new SqlParameter("@LastActiveDate",getDbDateTime(accountInfo.LastActiveDate)),
                new SqlParameter("@LastActiveRule",accountInfo.LastActiveRule),
                new SqlParameter("@LastBID",accountInfo.LastBID),
                new SqlParameter("@LastCardTime",getDbDateTime(accountInfo.LastCardTime)),
                new SqlParameter("@LPTime",getDbDateTime(accountInfo.LPTime)),
                new SqlParameter("@Name",accountInfo.Name),
                new SqlParameter("@NextDate",getDbDateTime(accountInfo.NextDate)),
                new SqlParameter("@Pass",accountInfo.Pass),
                new SqlParameter("@Pe_Birth",getDbDateTime(accountInfo.Pe_Birth)),
                new SqlParameter("@Pe_Circle",getDbDateTime(accountInfo.Pe_Circle)),
                new SqlParameter("@Pe_CircleCount",accountInfo.Pe_CircleCount),
                new SqlParameter("@Piao",accountInfo.Piao),
                new SqlParameter("@QCDate",getDbDateTime(accountInfo.QCDate)),
                new SqlParameter("@RegTime",getDbDateTime(accountInfo.RegTime)),
                new SqlParameter("@RemainZBi",accountInfo.RemainZBi),
                new SqlParameter("@RenZhengTime",getDbDateTime(accountInfo.RenZhengTime)),
                new SqlParameter("@Sex",accountInfo.Sex),
                new SqlParameter("@State",accountInfo.State),
                new SqlParameter("@TelNum",accountInfo.TelNum),
                new SqlParameter("@VDate",accountInfo.VDate.HasValue?getDbDateTime(accountInfo.VDate.Value):accountInfo.VDate),
                new SqlParameter("@YaJin",accountInfo.YaJin),
                new SqlParameter("@YanzhengMa",accountInfo.YanzhengMa),
                new SqlParameter("@ZSBi",accountInfo.ZSBi),
                new SqlParameter("@ZSType",accountInfo.ZSType),
                new SqlParameter("@RoamingIP",accountInfo.RoamingIP),
                new SqlParameter("@RoamingName",accountInfo.RoamingName),
                new SqlParameter("@RoamingState",accountInfo.RoamingState),
                new SqlParameter("@RoamingTime",accountInfo.RoamingTime.HasValue?getDbDateTime(accountInfo.RoamingTime.Value):accountInfo.RoamingTime),
                new SqlParameter("@ChainStoreID",accountInfo.ChainStoreID),
                new SqlParameter("@OwnerShopID",accountInfo.OwnerShopID)
            };

            #endregion

            object result = 0;

            if (SqlTran != null)
            {
                result = SqlHelper.ExecuteNonQuery(SqlTran, CommandType.Text, sql, parameters);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(SqlConn, CommandType.Text, sql, parameters);
            }

            return Convert.ToInt32(result);

            //return Convert.ToInt32(this.MemberDataAccess.AddMemberAccount(p_NewMemberEntity));
        }

        /// <summary>
        /// 查找第一个满足条件的会员账户信息
        /// </summary>
        /// <param name="p_AccountNo"></param>
        /// <returns></returns>
        public MemberEntity SelectByAccountNo(Guid p_AccountNo)
        {
            Guid accountNo = p_AccountNo;
            string sql =
            @"
			SELECT  T_Account.*  FROM T_Account WHERE T_Account.AccountNo=@AccountNo
			";

            SqlParameter[] _params = new SqlParameter[]
			{
				new SqlParameter("@AccountNo",accountNo)
			};

            try
            {
                DataSet _dataset;
                if (this.SqlTran != null)
                {
                    _dataset = SqlHelper.ExecuteDataset(this.SqlTran, CommandType.Text, sql, _params);
                }
                else
                {
                    _dataset = SqlHelper.ExecuteDataset(CommandType.Text, sql, _params);
                }

                DataTable _datatable = _dataset.Tables[0];
                if (_datatable.Rows.Count == 0)
                {
                    return null;
                }

                MemberEntity _entity = LoadEntity(_datatable.Rows[0]);

                return _entity;
            }
            catch (Exception ex)
            {
                WriteSqlLog(sql, ex.Message);
                throw ex;
            }
        }

        public bool UpdateAccountRoaming(GameHall.Entity.AccountEntity account, out string ErrStr)
        {
            //漫游状态、连锁店IP（取连接）、连锁店名称、连锁店店号、漫游操作时间
            string sql = "update T_Account set RoamingTime=@RoamingTime,RoamingIP=@RoamingIP," +
            " RoamingState=@RoamingState,RoamingName=@RoamingName,ChainStoreID=@ChainStoreID " +
            " where  CardNo=@CardNo";
            SqlParameter[] sqlparams = new SqlParameter[]
            {
            new SqlParameter("@RoamingTime",account.RoamingTime),
            new SqlParameter("@RoamingIP",account.RoamingIP),
            new SqlParameter("@RoamingState",account.RoamingState),
            new SqlParameter("@RoamingName",account.RoamingName),
            new SqlParameter("@ChainStoreID",account.ChainStoreID),
            new SqlParameter("@CardNo",account.CardNo)
            };
            try
            {
                return ExecSqlWithParms(sql, sqlparams, out ErrStr);
            }
            catch (Exception E)
            {
                ErrStr = E.Message;
                return false;
            }
        }

        #endregion
    }
}
