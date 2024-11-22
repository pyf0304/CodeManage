
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
    using AGC.FunClass;

    /// <summary>
    ///		wucViewDgInfo ��ժҪ˵����
    /// </summary>
    public partial class wucViewDgInfo : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string ViewDgID
		{
			get
			{
				return txtViewDgID.Text.Trim();
			}
			set
			{
				txtViewDgID.Text = value.ToString();
			}
		}

		public string ViewDgName
		{
			get
			{
				return txtViewDgName.Text.Trim();
			}
			set
			{
				txtViewDgName.Text = value.ToString();
			}
		}

		public string ViewId
		{
			get
			{
				return txtViewId.Text.Trim();
			}
			set
			{
				txtViewId.Text = value.ToString();
			}
		}

		public string SqlDsTypeId
		{
			get
			{
				if (ddlSqlDsTypeId.SelectedValue == "0")
					return "";
				return ddlSqlDsTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlSqlDsTypeId.SelectedValue = "0";
				}
				else
				{
					ddlSqlDsTypeId.SelectedValue = value;
				}
			}
		}

		public string SqlDsId
		{
			get
			{
				if (ddlSqlDsId.SelectedValue == "0")
					return "";
				return ddlSqlDsId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlSqlDsId.SelectedValue = "0";
				}
				else
				{
					ddlSqlDsId.SelectedValue = value;
				}
			}
		}
		

		public string DgStyleId
		{
			get
			{
				if (ddlDgStyleId.SelectedValue == "0")
					return "";
				return ddlDgStyleId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDgStyleId.SelectedValue = "0";
				}
				else
				{
					ddlDgStyleId.SelectedValue = value;
				}
			}
		}

		public int Width
		{
			get
			{
				return int.Parse(txtWidth.Text.Trim());
			}
			set
			{
				txtWidth.Text = value.ToString();
			}
		}

		public int Height
		{
			get
			{
				return int.Parse(txtHeight.Text.Trim());
			}
			set
			{
				txtHeight.Text = value.ToString();
			}
		}


		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtViewDgID.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtViewDgID.Text = "";
			txtViewDgName.Text = "";
			txtViewId.Text = "";
			ddlSqlDsTypeId.SelectedIndex = 0;
			ddlSqlDsId.SelectedIndex = 0;
			ddlDgStyleId.SelectedIndex = 0;
			txtWidth.Text = "0";
			txtHeight.Text = "0";
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
			ComValid_Width.Validate();
			if (!ComValid_Width.IsValid) return false;
			ComValid_Height.Validate();
			if (!ComValid_Height.IsValid) return false;
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
			txtViewDgID.Text = "";
			txtViewDgName.Text = "";
			txtViewId.Text = "";
			ddlSqlDsTypeId.SelectedIndex = 0;
			ddlSqlDsId.SelectedIndex = 0;
			ddlDgStyleId.SelectedIndex = 0;
			txtWidth.Text = "0";
			txtHeight.Text = "0";
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
		
		public System.Data.DataTable GetSqlDsTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select SqlDsTypeId, SqlDsTypeName from SQLDSType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_SqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetSqlDsTypeId();
			objDDL.DataValueField="SqlDsTypeId";
			objDDL.DataTextField="SqlDsTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
	
		public System.Data.DataTable GetPrjViewId(string strPrjId)
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select SqlViewId, SqlViewName from PrjView where PrjId = '" + strPrjId + "'";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_SqlDsId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = null;
			if (ddlSqlDsTypeId.SelectedValue == "01")
			{
				//objDT = GetPrjTabId(strPrjId);
				//objDDL.DataValueField="TabId";
				//objDDL.DataTextField="TabName";
			}
			else
			{
				objDT = GetPrjViewId(strPrjId);
				objDDL.DataValueField="SqlViewId";
				objDDL.DataTextField="SqlViewName";
			}
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetDgStyleId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select DgStyleId, DgStyleName from DataGridStyle ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DgStyleId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetDgStyleId();
			objDDL.DataValueField="DgStyleId";
			objDDL.DataTextField="DgStyleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_SqlDsTypeId()
		{
			BindDdl_SqlDsTypeId(ddlSqlDsTypeId);
		}
		public void SetDdl_SqlDsId(string strPrjId)
		{
			BindDdl_SqlDsId(ddlSqlDsId, strPrjId);
		}
		public void SetDdl_DgStyleId()
		{
			BindDdl_DgStyleId(ddlDgStyleId);
		}

		protected void ddlSqlDsTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            SetDdl_SqlDsId(clsPubVar.CurrSelPrjId);
		}
	}
}