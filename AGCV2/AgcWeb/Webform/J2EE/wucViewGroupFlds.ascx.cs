
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

	/// <summary>
	///		wucViewGroupFlds ��ժҪ˵����
	/// </summary>
	public partial class wucViewGroupFlds : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string ViewGroupId
		{
			get
			{
				if (ddlViewGroupId.SelectedValue == "0")
					return "";
				return ddlViewGroupId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlViewGroupId.SelectedValue = "0";
				}
				else
				{
					ddlViewGroupId.SelectedValue = value;
				}
			}
		}

		public long TabFldId
		{
			get
			{
				return long.Parse(txtTabFldId.Text.Trim());
			}
			set
			{
				txtTabFldId.Text = value.ToString();
			}
		}

		public string CtlTypeId
		{
			get
			{
				if (ddlCtlTypeId.SelectedValue == "0")
					return "";
				return ddlCtlTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlCtlTypeId.SelectedValue = "0";
				}
				else
				{
					ddlCtlTypeId.SelectedValue = value;
				}
			}
		}

		public string DdlItemsOptionId
		{
			get
			{
				if (ddlDdlItemsOptionId.SelectedValue == "0")
					return "";
				return ddlDdlItemsOptionId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDdlItemsOptionId.SelectedValue = "0";
				}
				else
				{
					ddlDdlItemsOptionId.SelectedValue = value;
				}
			}
		}

		public string DsCondStr
		{
			get
			{
				return txtDsCondStr.Text.Trim();
			}
			set
			{
				txtDsCondStr.Text = value.ToString();
			}
		}

		public string DsDataTextFieldId
		{
			get
			{
				if (ddlDsDataTextFieldId.SelectedValue == "0")
					return "";
				return ddlDsDataTextFieldId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataTextFieldId.SelectedValue = "0";
				}
				else
				{
					ddlDsDataTextFieldId.SelectedValue = value;
				}
			}
		}

		public string DsDataValueFieldId
		{
			get
			{
				if (ddlDsDataValueFieldId.SelectedValue == "0")
					return "";
				return ddlDsDataValueFieldId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataValueFieldId.SelectedValue = "0";
				}
				else
				{
					ddlDsDataValueFieldId.SelectedValue = value;
				}
			}
		}

		public string DsSqlStr
		{
			get
			{
				return txtDsSqlStr.Text.Trim();
			}
			set
			{
				txtDsSqlStr.Text = value.ToString();
			}
		}

		public string DsTabId
		{
			get
			{
				if (ddlDsTabId.SelectedValue == "0")
					return "";
				return ddlDsTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsTabId.SelectedValue = "0";
				}
				else
				{
					ddlDsTabId.SelectedValue = value;
				}
			}
		}

		public string ItemsString
		{
			get
			{
				return txtItemsString.Text.Trim();
			}
			set
			{
				txtItemsString.Text = value.ToString();
			}
		}

		public int SeqNum
		{
			get
			{
				return int.Parse(txtSeqNum.Text.Trim());
			}
			set
			{
				txtSeqNum.Text = value.ToString();
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


		public void Clear()
		{
			ddlViewGroupId.SelectedIndex = 0;
			txtTabFldId.Text = "0";
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDdlItemsOptionId.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			ddlDsDataTextFieldId.SelectedIndex = 0;
			ddlDsDataValueFieldId.SelectedIndex = 0;
			txtDsSqlStr.Text = "";
			ddlDsTabId.SelectedIndex = 0;
			txtItemsString.Text = "";
			txtSeqNum.Text = "0";
			txtMemo.Text = "";
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
			ComValid_SeqNum.Validate();
			if (!ComValid_SeqNum.IsValid) return false;
			if (IsNumeric(txtTabFldId.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
			if (IsNumeric(txtSeqNum.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
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
			ddlViewGroupId.SelectedIndex = 0;
			txtTabFldId.Text = "0";
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDdlItemsOptionId.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			ddlDsDataTextFieldId.SelectedIndex = 0;
			ddlDsDataValueFieldId.SelectedIndex = 0;
			txtDsSqlStr.Text = "";
			ddlDsTabId.SelectedIndex = 0;
			txtItemsString.Text = "";
			txtSeqNum.Text = "0";
			txtMemo.Text = "";
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
		
		public System.Data.DataTable GetViewGroupId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetViewGroupId();
			objDDL.DataValueField="ViewGroupId";
			objDDL.DataTextField="ViewGroupName";
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
		public void SetDdl_ViewGroupId()
		{
			BindDdl_ViewGroupId(ddlViewGroupId);
		}
		public void SetDdl_CtlTypeId(bool bolIsForApple)
		{
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
		}

		public void SetDdl_DdlItemsOptionId()
		{
            clsDDLItemsOptionBL.BindDdl_DdlItemsOptionIdCache(ddlDdlItemsOptionId);
		}
		public void SetDdl_DsDataTextFieldId(string strPrjId)
		{
clsFieldTabBLEx.BindDdl_FldIDEx(ddlDsDataTextFieldId, strPrjId);
        }
        public void SetDdl_DsDataValueFieldId(string strPrjId)
        {
            clsFieldTabBLEx.BindDdl_FldIDEx(ddlDsDataValueFieldId, strPrjId);
		}
		public void SetDdl_DsTabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDsTabId, strPrjId);
		}
		public void SetDdl_UserId()
		{
            //BindDdl_UserId(ddlUserId);
		}
	}
}