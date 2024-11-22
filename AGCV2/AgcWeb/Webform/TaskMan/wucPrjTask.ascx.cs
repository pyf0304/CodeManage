
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using AGC.BusinessLogicEx;
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucPrjTask ��ժҪ˵����
    /// </summary>
    public partial class wucPrjTask : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string PrjTaskId
		{
			get
			{
				return txtPrjTaskId.Text.Trim();
			}
			set
			{
				txtPrjTaskId.Text = value.ToString();
			}
		}

		public string TaskName
		{
			get
			{
				return txtTaskName.Text.Trim();
			}
			set
			{
				txtTaskName.Text = value.ToString();
			}
		}

		public string TaskDesc
		{
			get
			{
				return txtTaskDesc.Text.Trim();
			}
			set
			{
				txtTaskDesc.Text = value.ToString();
			}
		}

		public string Executor
		{
			get
			{
				if (ddlExecutor.SelectedValue == "0")
				{
					return "";
				}
				return ddlExecutor.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlExecutor.SelectedValue = "0";
				}
				else
				{
					ddlExecutor.SelectedValue = value;
				}
			}
		}

		public string DepartmentId
		{
			get
			{
				if (ddlDepartmentId.SelectedValue == "0")
				{
					return "";
				}
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
					ddlDepartmentId.SelectedValue = value;
				}
			}
		}

	

		public string PlanBeginDate
		{
			get
			{
				if (txtPlanBeginDate.Text.Trim() == "")
					return "";
				System.DateTime dtDay;
				dtDay = System.DateTime.Parse(txtPlanBeginDate.Text.Trim());
				string strDay = getDateStr(dtDay, 0);
				return strDay;
			}
			set
			{
				if (value.Length<8)
					txtPlanBeginDate.Text = "";
				System.DateTime dtDate = TransDateStr(value);

				txtPlanBeginDate.Text = getDateStr(dtDate, 1);
			}
		}

		public string PlanEndDate
		{
			get
			{
				if (txtPlanEndDate.Text.Trim() == "")
					return "";
				System.DateTime dtDay;
				dtDay = System.DateTime.Parse(txtPlanEndDate.Text.Trim());
				string strDay = getDateStr(dtDay, 0);
				return strDay;
			}
			set
			{
				if (value.Length<8)
					txtPlanEndDate.Text = "";
				System.DateTime dtDate = TransDateStr(value);
				txtPlanEndDate.Text = getDateStr(dtDate, 1);
			}
		}

		public int PlanNeedHours
		{
			get
			{
				return int.Parse(txtPlanNeedHours.Text.Trim());
			}
			set
			{
				txtPlanNeedHours.Text = value.ToString();
			}
		}

		public string ViewId
		{
			get
			{
				if (ddlViewId.SelectedValue == "0")
				{
					return "";
				}
				return ddlViewId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlViewId.SelectedValue = "0";
				}
				else
				{
					ddlViewId.SelectedValue = value;
				}
			}
		}

		public string PrjProcessId
		{
			get
			{
				if (ddlPrjProcessId.SelectedValue == "0")
				{
					return "";
				}
				return ddlPrjProcessId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlPrjProcessId.SelectedValue = "0";
				}
				else
				{
					ddlPrjProcessId.SelectedValue = value;
				}
			}
		}

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtPrjTaskId.ReadOnly = bolReadonly;
		}
		public void SetRequireField(bool bolReadonly)
		{
			RequiredField_PlanNeedHours.Enabled = bolReadonly;
		}
		public void Clear()
		{
			txtPrjTaskId.Text = "";
			txtTaskName.Text = "";
			txtTaskDesc.Text = "";
			ddlExecutor.SelectedIndex = 0;
			ddlDepartmentId.SelectedIndex = 0;
			txtPlanBeginDate.Text = "";
			txtPlanEndDate.Text = "";
			txtPlanNeedHours.Text = "0";
			ddlViewId.SelectedIndex = 0;
			ddlPrjProcessId.SelectedIndex = 0;
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
			ComValid_PlanNeedHours.Validate();
			if (!ComValid_PlanNeedHours.IsValid) return false;
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
			txtPrjTaskId.Text = "";
			txtTaskName.Text = "";
			txtTaskDesc.Text = "";
			ddlExecutor.SelectedIndex = 0;
			ddlDepartmentId.SelectedIndex = 0;
			txtPlanBeginDate.Text = "";
			txtPlanEndDate.Text = "";
			txtPlanNeedHours.Text = "0";
			ddlViewId.SelectedIndex = 0;
			ddlPrjProcessId.SelectedIndex = 0;
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
		/// ���ܣ���ȡ�������ڵ��ַ���
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
		public string getDateStr(System.DateTime dtDay,  int intFormat)
		{
			string strToday;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			intYear = dtDay.Year;
			intMonth = dtDay.Month;
			intDay = dtDay.Day;
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
		/// ���ܣ���ȡ�������ڵ��ַ���
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
		public System.DateTime TransDateStr(string strDate)
		{
			string strTransDate;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			if (strDate.Length != 8)
				return System.DateTime.Today;
			strYear = strDate.Substring(0,4);
			intYear = int.Parse(strYear);
			strMonth = strDate.Substring(4,2);
			intMonth = int.Parse(strMonth);
			if (intMonth>12 || intMonth<1)
				return System.DateTime.Today;
			strDay = strDate.Substring(6,2);
			intDay = int.Parse(strDay);
			
			if (intDay>31 || intDay<1)
				return System.DateTime.Today;
			strTransDate =strYear + "-" + strMonth + "-" + strDay;
			System.DateTime dtDate = System.DateTime.Parse(strTransDate);
			return dtDate;
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
		
		public System.Data.DataTable GetExecutor()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_Executor(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetExecutor();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
	
		
		public System.Data.DataTable GetPrjProcessId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select PrjProcessId, PrjProcessName from PrjProcess ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_PrjProcessId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetPrjProcessId();
			objDDL.DataValueField="PrjProcessId";
			objDDL.DataTextField="PrjProcessName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_Executor()
		{
			BindDdl_Executor(ddlExecutor);
		}
		public void SetDdl_DepartmentId()
		{
            clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId);
		}
		public void SetDdl_ViewId(string strPrjId)
		{
	clsViewInfoBLEx.		BindDdl_ViewIdEx(ddlViewId, strPrjId);
		}
		public void SetDdl_PrjProcessId()
		{
			BindDdl_PrjProcessId(ddlPrjProcessId);
		}
	}
}