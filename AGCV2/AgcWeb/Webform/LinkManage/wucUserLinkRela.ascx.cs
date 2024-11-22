
namespace AGC
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;

	/// <summary>
	///		wucUserLinkRela ��ժҪ˵����
	/// </summary>
	public partial class wucUserLinkRela : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string DataBaseTypeId
		{
			get
			{
				if (ddlDataBaseTypeId.SelectedValue == "0")
					return "";
				return ddlDataBaseTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDataBaseTypeId.SelectedValue = "0";
				}
				else
				{
					ddlDataBaseTypeId.SelectedValue = value;
				}
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

		public string IpAddress
		{
			get
			{
				return txtIpAddress.Text.Trim();
			}
			set
			{
				txtIpAddress.Text = value.ToString();
			}
		}

		public string DataBasePwd
		{
			get
			{
				return txtDataBasePwd.Text.Trim();
			}
			set
			{
				txtDataBasePwd.Text = value.ToString();
			}
		}

		public string DataBaseUserId
		{
			get
			{
				return txtDataBaseUserId.Text.Trim();
			}
			set
			{
				txtDataBaseUserId.Text = value.ToString();
			}
		}

		public string DataBaseName
		{
			get
			{
				return txtDataBaseName.Text.Trim();
			}
			set
			{
				txtDataBaseName.Text = value.ToString();
			}
		}

		public string Sid
		{
			get
			{
				return txtSid.Text.Trim();
			}
			set
			{
				txtSid.Text = value.ToString();
			}
		}

		public string ConnectionString
		{
			get
			{
				return txtConnectionString.Text.Trim();
			}
			set
			{
				txtConnectionString.Text = value.ToString();
			}
		}

		public string LinkName
		{
			get
			{
				return txtLinkName.Text.Trim();
			}
			set
			{
				txtLinkName.Text = value.ToString();
			}
		}


		public void Clear()
		{
			ddlDataBaseTypeId.SelectedIndex = 0;
			txtMemo.Text = "";
			txtIpAddress.Text = "";
			txtDataBasePwd.Text = "";
			txtDataBaseUserId.Text = "";
			txtDataBaseName.Text = "";
			txtSid.Text = "";
			txtConnectionString.Text = "";
			txtLinkName.Text = "";
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
			ddlDataBaseTypeId.SelectedIndex = 0;
			txtMemo.Text = "";
			txtIpAddress.Text = "";
			txtDataBasePwd.Text = "";
			txtDataBaseUserId.Text = "";
			txtDataBaseName.Text = "";
			txtSid.Text = "";
			txtConnectionString.Text = "";
			txtLinkName.Text = "";
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
		
		public System.Data.DataTable GetDataBaseTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetDataBaseTypeId();
			objDDL.DataValueField="DataBaseTypeId";
			objDDL.DataTextField="DataBaseTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_DataBaseTypeId()
		{
			BindDdl_DataBaseTypeId(ddlDataBaseTypeId);
		}
	}
}