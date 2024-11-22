using System;

namespace com.taishsoft.commdbfororacle
{
	/// <summary>
	/// clsOracleDB 的摘要说明。
	/// </summary>
	public class clsOracleDB
	{
		protected string m_sSID; 
		protected string m_sServer;
		protected string m_sUid;
		protected string m_sPassword;
		protected string p_sConnectString;
//		protected OracleConnection m_oConn;

		public clsOracleDB()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public string SID
		{
			get
			{
				return this.m_sSID ;
			}
			set
			{
				if(value!="" && this.m_sSID!=value)
					this.m_sSID=value;
			}
		}
		public string Server
		{
			get
			{
				return this.m_sServer;
			}
			set
			{
				if(value!="" && this.m_sServer!=value)
					this.m_sServer=value;
			}
		}

		public string UserID
		{
			get
			{
				return this.m_sUid ;
			}
			set
			{
				if(value!="" && this.m_sUid !=value)
					this.m_sUid =value;
			}
		}

		public string Password
		{
			get
			{
				return this.m_sPassword  ;
			}
			set
			{
				if(value!="" && this.m_sPassword  !=value)
					this.m_sPassword =value;
			}
		}

		public string ConnectionString
		{
			get
			{
				return this.p_sConnectString ;
			}
			set
			{
				if(value!="" && this.p_sConnectString  !=value)
					this.p_sConnectString  =value;
			}
		}

	}
}
