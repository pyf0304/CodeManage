
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
	using CommFunc4WebForm;
    
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
	/// <summary>
	///		wucViewGroup ��ժҪ˵����
	/// </summary>
	public partial class wucViewGroup : System.Web.UI.UserControl
	{
		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string ViewGroupId
		{
			get
			{
				return txtViewGroupId.Text.Trim();
			}
			set
			{
				txtViewGroupId.Text = value.ToString();
			}
		}

		public string ViewGroupName
		{
			get
			{
				return txtViewGroupName.Text.Trim();
			}
			set
			{
				txtViewGroupName.Text = value.ToString();
			}
		}
		public string ActionPath
		{
			get
			{
				return txtActionPath.Text.Trim();
			}
			set
			{
				txtActionPath.Text = value.ToString();
			}
		}
		public string InRelaTabId
		{
			get
			{
				if (ddlInRelaTabId.SelectedValue == "0")
					return "";
				return ddlInRelaTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlInRelaTabId.SelectedValue = "0";
				}
				else
				{
					ddlInRelaTabId.SelectedValue = value;
				}
			}
		}

		public string InSqlDsTypeId
		{
			get
			{
				if (ddlInSqlDsTypeId.SelectedValue == "0")
					return "";
				return ddlInSqlDsTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlInSqlDsTypeId.SelectedValue = "0";
				}
				else
				{
					ddlInSqlDsTypeId.SelectedValue = value;
				}
				if (ddlInSqlDsTypeId.SelectedIndex != 0)
				{
                    clsDropDownList.BindDdl_RelaTabId(ddlInRelaTabId, ddlInSqlDsTypeId.SelectedValue, clsPubVar.CurrSelPrjId);
				}
			}
		}

		public string OutSqlDsTypeId
		{
			get
			{
				if (ddlOutSqlDsTypeId.SelectedValue == "0")
					return "";
				return ddlOutSqlDsTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlOutSqlDsTypeId.SelectedValue = "0";
				}
				else
				{
					ddlOutSqlDsTypeId.SelectedValue = value;
				}
				if (ddlOutSqlDsTypeId.SelectedIndex != 0)
				{
                    clsDropDownList.BindDdl_RelaTabId(ddlOutRelaTabId, ddlOutSqlDsTypeId.SelectedValue, clsPubVar.CurrSelPrjId);
				}
			}
		}

		public string OutRelaTabId
		{
			get
			{
				if (ddlOutRelaTabId.SelectedValue == "0")
					return "";
				return ddlOutRelaTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlOutRelaTabId.SelectedValue = "0";
				}
				else
				{
					ddlOutRelaTabId.SelectedValue = value;
				}
			}
		}

		public string PrjDomain
		{
			get
			{
				return txtPrjDomain.Text.Trim();
			}
			set
			{
				txtPrjDomain.Text = value.ToString();
			}
		}

	
		

		

		public string Memo
		{
			get
			{
				return txtMemo.Text.Trim();
			}
			set
			{
				txtMemo.Text = value.ToString();
			}
		}
		public string TableNameForProg
		{
			get
			{
				return txtTableNameForProg.Text.Trim();
			}
			set
			{
				txtTableNameForProg.Text = value.ToString();
			}
		}

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtViewGroupId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtViewGroupId.Text = "";
			txtViewGroupName.Text = "";
			ddlInRelaTabId.SelectedIndex = 0;
			ddlInSqlDsTypeId.SelectedIndex = 0;
			ddlOutSqlDsTypeId.SelectedIndex = 0;
			ddlOutRelaTabId.SelectedIndex = 0;
			txtPrjDomain.Text = "";
			txtActionPath.Text = "";
			txtMemo.Text = "";
			txtTableNameForProg.Text = "";
		}
		/// <summary>
		/// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�
		/// һ�����
		///		1������У�����ͣ����͡������͡������͵ȣ�
		///			��Щ�������Զ����ɴ����������
		///		2��У����ֵ�������ֵ����Сֵ��
		///			��Щ�������Զ����ɴ����������
		///		��Щ�������ݿ����޸�
		/// </summary>
		/// <returns></returns>
		public bool IsValid(ref string strResult)
		{
			return true;
		}
		/// <summary>
		/// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
		/// һ�����
		///		1����������;�Ĭ��Ϊ0��
		///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
		///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
		///		4�������λ(bit)�;�Ĭ��Ϊfalse;
		///		��ЩĬ��ֵ���������޸�
		/// </summary>
		public void SetDefaultValue()
		{
			txtViewGroupId.Text = "";
			txtViewGroupName.Text = "";
			ddlInRelaTabId.SelectedIndex = 0;
			ddlInSqlDsTypeId.SelectedIndex = 0;
			ddlOutSqlDsTypeId.SelectedIndex = 0;
			ddlOutRelaTabId.SelectedIndex = 0;
			txtPrjDomain.Text = "";
			txtActionPath.Text = "";
			txtMemo.Text = "";
			txtTableNameForProg.Text = "";
		}
		/// <summary>
		/// ���ܣ���ȡ��ǰ���ڵ��ַ���
		/// ���ڸ�ʽ��
		///    ���ڵ��ַ����ĸ�ʽ�����֣�
		///		1��YYYYMMDD��	����20050120
		///		2��YYYY-MM-DD	����2005-01-20
		///		3��YYYY/MM/DD	����2005/01/20
		/// </summary>
		/// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
		///							������ͬ����������ֵ�Ͳ�ͬ��
		///							�μ���������ڸ�ʽ
		///	</param>
		/// <returns>���ص�ǰ���ڵ��ַ���</returns>
		public string getTodayStr(int intFormat)
		{
			string strToday;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			intYear = System.DateTime.Today.Year;
			intMonth = System.DateTime.Today.Month;
			intDay = System.DateTime.Today.Day;
			strYear = intYear.ToString().Trim();
			if (intMonth>9) strMonth = intMonth.ToString().Trim();
			else strMonth = "0" + intMonth.ToString().Trim();
			if (intDay>9) strDay = intDay.ToString().Trim();
			else strDay = "0" + intDay.ToString().Trim();
			strToday = strYear + strMonth + strDay;
			switch(intFormat)
			{
				case 0:
					strToday = strYear + strMonth + strDay;
					break;
				case 1:
					strToday =strYear + "-" + strMonth + "-" + strDay;
					break;
				case 2:
					strToday =strYear + "/" + strMonth + "/" + strDay;
					break;
			}
			return strToday;
		}
		/// <summary>
		/// ���ܣ���ȡ��ǰ�µ��ַ���
		/// �µĸ�ʽ��
		///    �µ��ַ����ĸ�ʽ�����֣�
		///		1��YYYYMM��	����200501
		///		2��YYYY-MM-DD	����2005-01
		///		3��YYYY/MM/DD	����2005/01
		/// </summary>
		/// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
		///							������ͬ����������ֵ�Ͳ�ͬ��
		///							�μ�������µĸ�ʽ
		///	</param>
		/// <returns>���ص�ǰ�µ��ַ���</returns>
		public string getCurrMonth(int intFormat)
		{
			string strCurrMonth;
			string strYear, strMonth;
			int intYear, intMonth;
			intYear = System.DateTime.Today.Year;
			intMonth = System.DateTime.Today.Month;
			strYear = intYear.ToString().Trim();
			if (intMonth>9) strMonth = intMonth.ToString().Trim();
			else strMonth = "0" + intMonth.ToString().Trim();
			strCurrMonth = strYear + strMonth;
			switch(intFormat)
			{
				case 0:
					strCurrMonth = strYear + strMonth;
					break;
				case 1:
					strCurrMonth =strYear + "-" + strMonth;
					break;
				case 2:
					strCurrMonth =strYear + "/" + strMonth;
					break;
			}
			return strCurrMonth;
		}
		/// <summary>
		/// �ж��Ƿ�������
		/// </summary>
		/// <param name="strValue">��Ҫ�жϵ��ַ���</param>
		/// <returns>True/False</returns>
		public bool IsDigit(string strValue)
		{
			int intLen = strValue.Length;
			for(int i = 0; i<intLen; i++)
			{
				if (char.IsDigit(strValue, i) == false)
				{
					return false;
				}
			}
			return true;
		}
		/// <summary>
		/// �ж��Ƿ��Ǹ�������ֵ
		/// </summary>
		/// <param name="strValue">��Ҫ�жϵ��ַ���</param>
		/// <returns>True/False</returns>
		public bool IsFloat(string strValue)
		{
			int intPointNum = 0;
			char [] arrChar = strValue.ToCharArray();
			int intLen = strValue.Length;
			for(int i = 0; i<intLen; i++)
			{
				if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
				{
				}
				else
				{
					return false;
				}
				if (arrChar[i] == '.') intPointNum++;
			}
			//����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
			if (intPointNum>1) return false;
			return true;
		}
		/// <summary>
		/// �ж��Ƿ���������ֵ
		/// </summary>
		/// <param name="strValue">��Ҫ�жϵ��ַ���</param>
		/// <returns>True/False</returns>
		public bool IsNumeric(string strValue)
		{
			int intLen = strValue.Length;
			for(int i = 0; i<intLen; i++)
			{
				if (char.IsDigit(strValue, i) == false)
				{
					return false;
				}
			}
			return true;
		}
		
		public System.Data.DataTable GetInSqlDsTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select SqlDsTypeId, SqlDsTypeName from SQLDSType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_InSqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetInSqlDsTypeId();
			objDDL.DataValueField="SqlDsTypeId";
			objDDL.DataTextField="SqlDsTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
	
	
		public System.Data.DataTable GetUserId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetUserId();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_InRelaTabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlInRelaTabId, strPrjId);
		}
		public void SetDdl_InSqlDsTypeId()
		{
			clsSQLDSTypeBLEx.BindDdl_SqlDsTypeIdCache(ddlInSqlDsTypeId);
		}
		public void SetDdl_OutSqlDsTypeId()
		{
			clsSQLDSTypeBLEx.BindDdl_SqlDsTypeIdCache(ddlOutSqlDsTypeId);
		}
		public void SetDdl_OutRelaTabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlOutRelaTabId, strPrjId);
		}

		protected void ddlOutSqlDsTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlOutSqlDsTypeId.SelectedIndex != 0)
			{
                clsDropDownList.BindDdl_RelaTabId(ddlOutRelaTabId, ddlOutSqlDsTypeId.SelectedValue, clsPubVar.CurrSelPrjId);
			}
		}

		protected void ddlInSqlDsTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlInSqlDsTypeId.SelectedIndex != 0)
			{
                clsDropDownList.BindDdl_RelaTabId(ddlInRelaTabId, ddlInSqlDsTypeId.SelectedValue, clsPubVar.CurrSelPrjId);
			}
		}
	}
}