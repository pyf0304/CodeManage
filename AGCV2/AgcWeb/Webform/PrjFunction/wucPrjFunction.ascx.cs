
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using CommFunc4WebForm;
    //using SqlSv;
    using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucPrjFunction ��ժҪ˵����
    /// </summary>
    public partial class wucPrjFunction : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)
			{
				tabHidden.Visible= false;
			}

		}
		public string FuncId
		{
			get
			{
				return txtFuncId.Text.Trim();
			}
			set
			{
				txtFuncId.Text = value.ToString();
			}
		}

		public string FuncName
		{
			get
			{
				return txtFuncName.Text.Trim();
			}
			set
			{
				txtFuncName.Text = value.ToString();
			}
		}

		public string PrjId
		{
			get
			{
				return txtPrjId.Text.Trim();
			}
			set
			{
				txtPrjId.Text = value.ToString();
			}
		}

		public string ReturnTypeID
		{
			get
			{
				return ddlReturnTypeID.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlReturnTypeID.SelectedValue = "0";
				}
				else
				{
					ddlReturnTypeID.SelectedValue = value;
				}
			}
		}

		public string FuncTypeId
		{
			get
			{
				return ddlFuncTypeID.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFuncTypeID.SelectedValue = "0";
				}
				else
				{
					ddlFuncTypeID.SelectedValue = value;
				}
			}
		}

		public bool IsTemplate
		{
			get
			{
				return chkIsTemplate.Checked;
			}
			set
			{
				chkIsTemplate.Checked = value;
			}
		}

		public string FuncCode
		{
			get
			{
				return txtFuncCode.Text.Trim();
			}
			set
			{
				txtFuncCode.Text = value.ToString();
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
			txtFuncId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtFuncId.Text = "";
			txtFuncName.Text = "";
			txtPrjId.Text = "";
			ddlReturnTypeID.SelectedIndex = 0;
			ddlFuncTypeID.SelectedIndex = 0;
			chkIsTemplate.Checked = false;
			txtFuncCode.Text = "";
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
			txtFuncId.Text = "";
			txtFuncName.Text = "";
			txtPrjId.Text = "";
			ddlReturnTypeID.SelectedIndex = 0;
			ddlFuncTypeID.SelectedIndex = 0;
			chkIsTemplate.Checked = false;
			txtFuncCode.Text = "";
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

		public void SetDdl_ReturnTypeID()
		{
			clsDropDownList.BindDdl_ReturnTypeID(ddlReturnTypeID);
		}
		public void SetDdl_FuncTypeID()
		{
	clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeID);
		}
	}
}