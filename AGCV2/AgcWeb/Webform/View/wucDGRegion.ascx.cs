
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
    using AGC.BusinessLogic;

    /// <summary>
    ///		wucDGRegion ��ժҪ˵����
    /// </summary>
    public partial class wucDGRegion : System.Web.UI.UserControl
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			tabHidden.Visible = false;

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

		public string DGStyleId
		{
			get
			{
				if (ddlDGStyleId.SelectedValue == "0")
					return "";
				return ddlDGStyleId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDGStyleId.SelectedValue = "0";
				}
				else
				{
					ddlDGStyleId.SelectedValue = value;
				}
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
				return rbIsRadio.Checked;
			}
			set
			{
				if (value == true)
				{
					rbIsRadio.Checked = true;
				}
			}
		}

		public bool IsCheck
		{
			get
			{
				return rbIsCheck.Checked;
			}
			set
			{
				if (value == true)
				{
					rbIsCheck.Checked = true;
				}
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

		public int Style_Zindex
		{
			get
			{
				return int.Parse(txtStyle_Zindex.Text.Trim());
			}
			set
			{
				txtStyle_Zindex.Text = value.ToString();
			}
		}

		public int Style_Left
		{
			get
			{
				return int.Parse(txtStyle_Left.Text.Trim());
			}
			set
			{
				txtStyle_Left.Text = value.ToString();
			}
		}

		public string Style_Position
		{
			get
			{
				return txtStyle_Position.Text.Trim();
			}
			set
			{
				txtStyle_Position.Text = value.ToString();
			}
		}

		public int Style_Top
		{
			get
			{
				return int.Parse(txtStyle_Top.Text.Trim());
			}
			set
			{
				txtStyle_Top.Text = value.ToString();
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
			txtViewDgName.Text = "";
			ddlDGStyleId.SelectedIndex = 0;
			txtRunat.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			chkAllowPaging.Checked = false;
			txtPageSize.Text = "0";
			chkAutoGenerateColumns.Checked = false;
			chkAllowSorting.Checked = false;
			chkIsJumpPage.Checked = false;
			chkIsHaveUpdBtn.Checked = false;
			chkIsHaveDelBtn.Checked = false;
			chkIsHaveDetailBtn.Checked = false;
			chkIsInTab.Checked = false;
			rbNoSelRecordMode.Checked = false;
			rbIsCheck.Checked = false;
			rbIsRadio.Checked = false;
			txtStyle_Zindex.Text = "0";
			txtStyle_Left.Text = "0";
			txtStyle_Position.Text = "";
			txtStyle_Top.Text = "0";
			txtWidth.Text = "0";
			txtHeight.Text = "0";
			txtStyle.Text = "";
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
			ComValid_PageSize.Validate();
			if (!ComValid_PageSize.IsValid) return false;
			ComValid_Style_Zindex.Validate();
			if (!ComValid_Style_Zindex.IsValid) return false;
			ComValid_Style_Left.Validate();
			if (!ComValid_Style_Left.IsValid) return false;
			ComValid_Style_Top.Validate();
			if (!ComValid_Style_Top.IsValid) return false;
			ComValid_Width.Validate();
			if (!ComValid_Width.IsValid) return false;
			ComValid_Height.Validate();
			if (!ComValid_Height.IsValid) return false;
			if (IsNumeric(txtPageSize.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
			if (IsNumeric(txtStyle_Zindex.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
			if (IsNumeric(txtStyle_Left.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
			if (IsNumeric(txtStyle_Top.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
			if (IsNumeric(txtWidth.Text) == false)
			{
				strResult = "��������ȷ������!";
				return false;
			}
			if (IsNumeric(txtHeight.Text) == false)
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
			txtViewDgName.Text = "";
			ddlDGStyleId.SelectedIndex = 0;
			txtRunat.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			chkAllowPaging.Checked = false;
			txtPageSize.Text = "0";
			chkAutoGenerateColumns.Checked = false;
			chkAllowSorting.Checked = false;
			chkIsJumpPage.Checked = false;
			chkIsHaveUpdBtn.Checked = false;
			chkIsHaveDelBtn.Checked = false;
			chkIsHaveDetailBtn.Checked = false;
			chkIsInTab.Checked = false;
			txtStyle_Zindex.Text = "0";
			txtStyle_Left.Text = "0";
			txtStyle_Position.Text = "";
			txtStyle_Top.Text = "0";
			txtWidth.Text = "0";
			txtHeight.Text = "0";
			txtStyle.Text = "";
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
		
	
		public void SetDdl_DGStyleId()
		{
            clsDataGridStyleBL.BindDdl_DGStyleId_Cache(ddlDGStyleId);
		}
	}
}