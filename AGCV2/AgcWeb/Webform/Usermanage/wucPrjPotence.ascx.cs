
namespace AGC
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucPrjPotence ��ժҪ˵����
    /// </summary>
    public partial class wucPrjPotence : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string PotenceId
		{
			get
			{
				return PId.Text.Trim()+txtPotenceId.Text.Trim();
			}
			set
			{
//				txtPotenceId.Text = value.ToString();
				PId.Text = value.ToString().Trim().Substring(0,4);
				txtPotenceId.Text = value.ToString().Trim().Substring(4,4);
			}
		}

		public string PrjId
		{
			get
			{
				if (ddlPrjId.SelectedValue == "0")
					return "";
				return ddlPrjId.SelectedValue;
			}
			set
			{
				ddlPrjId.SelectedValue = value;
			}
		}

		public string FLM
		{
			get
			{
				if (ddlFLM.SelectedValue == "0")
					return "";
				return ddlFLM.SelectedValue;
			}
			set
			{
				ddlFLM.SelectedValue = value;
			}
		}

		public string PotenceName
		{
			get
			{
				return txtPotenceName.Text.Trim();
			}
			set
			{
				txtPotenceName.Text = value.ToString();
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
			txtPotenceId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			PId.Text = "";
			txtPotenceId.Text = "";
			ddlPrjId.SelectedIndex = 0;
			ddlFLM.SelectedIndex = 0;
			txtPotenceName.Text = "";
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
		public bool IsValid()
		{
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
			txtPotenceId.Text = "";
			ddlPrjId.SelectedIndex = 0;
			ddlFLM.SelectedIndex = 0;
			txtPotenceName.Text = "";
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
	
		public System.Data.DataTable GetFLM(string prjid)
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select FLM, FLMC from PotenceFL where PrjId = '"+prjid+"' ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_FLM(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetFLM(PrjId);
			objDDL.DataValueField="FLM";
			objDDL.DataTextField="FLMC";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_PrjId()
		{
			clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}
		public void SetDdl_FLM()
		{
			BindDdl_FLM(ddlFLM);
		}

		protected void ddlPrjId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		   SetDdl_FLM();
			PId.Text=ddlPrjId.SelectedValue;
		}
	}
}