
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;

	/// <summary>
	///		wucStrutsAction ��ժҪ˵����
	/// </summary>
	public partial class wucStrutsAction : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string ActionId
		{
			get
			{
				return txtActionId.Text.Trim();
			}
			set
			{
				txtActionId.Text = value.ToString();
			}
		}

		public string ActionName
		{
			get
			{
				return txtActionName.Text.Trim();
			}
			set
			{
				txtActionName.Text = value.ToString();
			}
		}

		public string ActionParameter
		{
			get
			{
				return txtActionParameter.Text.Trim();
			}
			set
			{
				txtActionParameter.Text = value.ToString();
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

		public string ActionScope
		{
			get
			{
				return txtActionScope.Text.Trim();
			}
			set
			{
				txtActionScope.Text = value.ToString();
			}
		}

		public string ActionType
		{
			get
			{
				return txtActionType.Text.Trim();
			}
			set
			{
				txtActionType.Text = value.ToString();
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


		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtActionId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtActionId.Text = "";
			txtActionName.Text = "";
			txtActionParameter.Text = "";
			txtActionPath.Text = "";
			txtActionScope.Text = "";
			txtActionType.Text = "";
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
			txtActionId.Text = "";
			txtActionName.Text = "";
			txtActionParameter.Text = "";
			txtActionPath.Text = "";
			txtActionScope.Text = "";
			txtActionType.Text = "";
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
			//string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup where ViewGroupId='00000001'";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
//		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
//		{
//			//Ϊ����Դ�ڱ����������������
//			ListItem li=new ListItem("��ѡ��...","0");
//			System.Data.DataTable objDT = GetViewGroupId();
//			objDDL.DataValueField="ViewGroupId";
//			objDDL.DataTextField="ViewGroupName";
//			objDDL.DataSource = objDT;
//			objDDL.DataBind();
//			objDDL.Items.Insert(0, li);
//			objDDL.SelectedIndex = 0;
//		}

//		public System.Data.DataTable GetUserId()
//		{
//			//��ȡĳѧԺ����רҵ��Ϣ
//			string strSQL = "select UserId, UserName from Users ";
//			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
//			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
//			return objDT;
//		}
//		public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
//		{
//			//Ϊ����Դ�ڱ����������������
//			ListItem li=new ListItem("��ѡ��...","0");
//			System.Data.DataTable objDT = GetUserId();
//			objDDL.DataValueField="UserId";
//			objDDL.DataTextField="UserName";
//			objDDL.DataSource = objDT;
//			objDDL.DataBind();
//			objDDL.Items.Insert(0, li);
//			objDDL.SelectedIndex = 0;
//		}
//		public void SetDdl_ViewGroupId()
//		{
//			BindDdl_ViewGroupId(ddlViewGroupId);
//		}
//		public void SetDdl_PrjId()
//		{
//			clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
//		}
//		public void SetDdl_UserId()
//		{
//			BindDdl_UserId(ddlUserId);
//		}
	}
}