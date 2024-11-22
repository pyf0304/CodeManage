
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
	///		wucDataGridStyle ��ժҪ˵����
	/// </summary>
	public partial class wucDataGridStyle : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string DgStyleId
		{
			get
			{
				return txtDgStyleId.Text.Trim();
			}
			set
			{
				txtDgStyleId.Text = value.ToString();
			}
		}

		public string DgStyleName
		{
			get
			{
				return txtDgStyleName.Text.Trim();
			}
			set
			{
				txtDgStyleName.Text = value.ToString();
			}
		}

		public string Runat
		{
			get
			{
				return txtRunat.Text.Trim();
			}
			set
			{
				txtRunat.Text = value.ToString();
			}
		}

		public string FontSize
		{
			get
			{
				return txtFontSize.Text.Trim();
			}
			set
			{
				txtFontSize.Text = value.ToString();
			}
		}

		public string FontName
		{
			get
			{
				return txtFontName.Text.Trim();
			}
			set
			{
				txtFontName.Text = value.ToString();
			}
		}

		public bool AllowPaging
		{
			get
			{
				return chkAllowPaging.Checked;
			}
			set
			{
				chkAllowPaging.Checked = value;
			}
		}

		public int PageSize
		{
			get
			{
				return int.Parse(txtPageSize.Text.Trim());
			}
			set
			{
				txtPageSize.Text = value.ToString();
			}
		}

		public bool AutoGenerateColumns
		{
			get
			{
				return chkAutoGenerateColumns.Checked;
			}
			set
			{
				chkAutoGenerateColumns.Checked = value;
			}
		}

		public bool AllowSorting
		{
			get
			{
				return chkAllowSorting.Checked;
			}
			set
			{
				chkAllowSorting.Checked = value;
			}
		}

		public bool IsRadio
		{
			get
			{
				return chkIsRadio.Checked;
			}
			set
			{
				chkIsRadio.Checked = value;
			}
		}

		public bool IsCheck
		{
			get
			{
				return chkIsCheck.Checked;
			}
			set
			{
				chkIsCheck.Checked = value;
			}
		}

		public bool IsJumpPage
		{
			get
			{
				return chkIsJumpPage.Checked;
			}
			set
			{
				chkIsJumpPage.Checked = value;
			}
		}

		public bool IsHaveUpdBtn
		{
			get
			{
				return chkIsHaveUpdBtn.Checked;
			}
			set
			{
				chkIsHaveUpdBtn.Checked = value;
			}
		}

		public bool IsHaveDelBtn
		{
			get
			{
				return chkIsHaveDelBtn.Checked;
			}
			set
			{
				chkIsHaveDelBtn.Checked = value;
			}
		}

		public bool IsHaveDetailBtn
		{
			get
			{
				return chkIsHaveDetailBtn.Checked;
			}
			set
			{
				chkIsHaveDetailBtn.Checked = value;
			}
		}

		public bool IsInTab
		{
			get
			{
				return chkIsInTab.Checked;
			}
			set
			{
				chkIsInTab.Checked = value;
			}
		}

		public int StyleZindex
		{
			get
			{
				return int.Parse(txtStyleZindex.Text.Trim());
			}
			set
			{
				txtStyleZindex.Text = value.ToString();
			}
		}

		public int StyleLeft
		{
			get
			{
				return int.Parse(txtStyleLeft.Text.Trim());
			}
			set
			{
				txtStyleLeft.Text = value.ToString();
			}
		}

		public string StylePosition
		{
			get
			{
				return txtStylePosition.Text.Trim();
			}
			set
			{
				txtStylePosition.Text = value.ToString();
			}
		}

		public int StyleTop
		{
			get
			{
				return int.Parse(txtStyleTop.Text.Trim());
			}
			set
			{
				txtStyleTop.Text = value.ToString();
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

		public string Style
		{
			get
			{
				return txtStyle.Text.Trim();
			}
			set
			{
				txtStyle.Text = value.ToString();
			}
		}

		public bool IsDefault
		{
			get
			{
				return chkIsDefault.Checked;
			}
			set
			{
				chkIsDefault.Checked = value;
			}
		}



		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtDgStyleId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtDgStyleId.Text = "";
			txtDgStyleName.Text = "";
			txtRunat.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			chkAllowPaging.Checked = false;
			txtPageSize.Text = "0";
			chkAutoGenerateColumns.Checked = false;
			chkAllowSorting.Checked = false;
			chkIsRadio.Checked = false;
			chkIsCheck.Checked = false;
			chkIsJumpPage.Checked = false;
			chkIsHaveUpdBtn.Checked = false;
			chkIsHaveDelBtn.Checked = false;
			chkIsHaveDetailBtn.Checked = false;
			chkIsInTab.Checked = false;
			txtStyleZindex.Text = "0";
			txtStyleLeft.Text = "0";
			txtStylePosition.Text = "";
			txtStyleTop.Text = "0";
			txtWidth.Text = "0";
			txtHeight.Text = "0";
			txtStyle.Text = "";
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
			ComValid_PageSize.Validate();
			if (!ComValid_PageSize.IsValid) return false;
			ComValid_StyleZindex.Validate();
			if (!ComValid_StyleZindex.IsValid) return false;
			ComValid_StyleLeft.Validate();
			if (!ComValid_StyleLeft.IsValid) return false;
			ComValid_StyleTop.Validate();
			if (!ComValid_StyleTop.IsValid) return false;
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
			txtDgStyleId.Text = "";
			txtDgStyleName.Text = "";
			txtRunat.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			chkAllowPaging.Checked = false;
			txtPageSize.Text = "0";
			chkAutoGenerateColumns.Checked = false;
			chkAllowSorting.Checked = false;
			chkIsRadio.Checked = false;
			chkIsCheck.Checked = false;
			chkIsJumpPage.Checked = false;
			chkIsHaveUpdBtn.Checked = false;
			chkIsHaveDelBtn.Checked = false;
			chkIsHaveDetailBtn.Checked = false;
			chkIsInTab.Checked = false;
			txtStyleZindex.Text = "0";
			txtStyleLeft.Text = "0";
			txtStylePosition.Text = "";
			txtStyleTop.Text = "0";
			txtWidth.Text = "0";
			txtHeight.Text = "0";
			txtStyle.Text = "";
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
		
	}
}