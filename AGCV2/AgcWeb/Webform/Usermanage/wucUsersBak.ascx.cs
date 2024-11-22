
namespace AGC
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
	///		wucUsers ��ժҪ˵����
	/// </summary>
	public partial class wucUsersBak : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string UserId
		{
			get
			{
				return txtUserId.Text.Trim();
			}
			set
			{
				txtUserId.Text = value.ToString();
			}
		}

		public string UserName
		{
			get
			{
				return txtUserName.Text.Trim();
			}
			set
			{
				txtUserName.Text = value.ToString();
			}
		}

		public string DepartmentId
		{
			get
			{
				return ddlDepartmentId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDepartmentId.SelectedValue = "0";
				}
				else
				{
                    try
                    {
                        ddlDepartmentId.SelectedValue = value;
                    }
                    catch (Exception objException)
                    {
                        clsPubVar.objLog.WriteDebugLog(objException.Message);
                    }
				}
			}
		}

		public string UserStateId
		{
			get
			{
				return ddlUserStateId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlUserStateId.SelectedValue = "0";
				}
				else
				{
					ddlUserStateId.SelectedValue = value;
				}
			}
		}

		public string PassWord
		{
			get
			{
				return txtPassWord.Text.Trim();
			}
			set
			{
				txtPassWord.Text = value.ToString();
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

		public int qxdj
		{
			get
			{
				return int.Parse(txtqxdj.Text.Trim());
			}
			set
			{
				txtqxdj.Text = value.ToString();
			}
		}

		public string RoleId
		{
			get
			{
				return ddlRoleId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlRoleId.SelectedValue = "0";
				}
				else
				{
					ddlRoleId.SelectedValue = value;
				}
			}
		}

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtUserId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtUserId.Text = "";
			txtUserName.Text = "";
			ddlDepartmentId.SelectedIndex = 0;
			ddlUserStateId.SelectedIndex = 0;
			txtPassWord.Text = "";
			txtMemo.Text = "";
			txtqxdj.Text = "0";
			ddlRoleId.SelectedIndex = 0;
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
		public bool IsValid()
		{
			ComValid_qxdj.Validate();
			if (!ComValid_qxdj.IsValid) return false;
			return true;
		}
		/// <summary>
		/// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
		/// һ�����
		///		1����������;�Ĭ��Ϊ0��
		///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
		///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
		///		4�������λ(bit)�;�Ĭ��ΪFalse;
		///		��ЩĬ��ֵ���������޸�
		/// </summary>
		public void SetDefaultValue()
		{
			txtUserId.Text = "";
			txtUserName.Text = "";
			ddlDepartmentId.SelectedIndex = 0;
			ddlUserStateId.SelectedIndex = 0;
			txtPassWord.Text = "";
			txtMemo.Text = "";
			txtqxdj.Text = "0";
			ddlRoleId.SelectedIndex = 0;
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
		
	
		public System.Data.DataTable GetUserStateId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select UserStateId, UserStateName from UserState ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetUserStateId();
			objDDL.DataValueField="UserStateId";
			objDDL.DataTextField="UserStateName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		public void SetDdl_DepartmentId()
		{
            clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId);
		}
		public void SetDdl_UserStateId()
		{
			BindDdl_UserStateId(ddlUserStateId);
		}
		public void SetDdl_RoleId()
		{
            clsUserRolesBL.BindDdl_RoleId(ddlRoleId);
		}
	}
}