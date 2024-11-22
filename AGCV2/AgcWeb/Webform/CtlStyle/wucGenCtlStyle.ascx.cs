
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
	///		wucGenCtlStyle ��ժҪ˵����
	/// </summary>
	public partial class wucGenCtlStyle : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string GenCtlStyleId
		{
			get
			{
				return txtGenCtlStyleId.Text.Trim();
			}
			set
			{
				txtGenCtlStyleId.Text = value.ToString();
			}
		}

		public string GenCtlStyleName
		{
			get
			{
				return txtGenCtlStyleName.Text.Trim();
			}
			set
			{
				txtGenCtlStyleName.Text = value.ToString();
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

		public string TextMode
		{
			get
			{
				return txtTextMode.Text.Trim();
			}
			set
			{
				txtTextMode.Text = value.ToString();
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


		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtGenCtlStyleId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtGenCtlStyleId.Text = "";
			txtGenCtlStyleName.Text = "";
			txtStyle.Text = "";
			txtRunat.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			txtWidth.Text = "0";
			txtHeight.Text = "0";
			txtTextMode.Text = "";
			txtStyleZindex.Text = "0";
			txtStyleLeft.Text = "0";
			txtStylePosition.Text = "";
			txtStyleTop.Text = "0";
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
			ComValid_StyleZindex.Validate();
			if (!ComValid_StyleZindex.IsValid) return false;
			ComValid_StyleLeft.Validate();
			if (!ComValid_StyleLeft.IsValid) return false;
			ComValid_StyleTop.Validate();
			if (!ComValid_StyleTop.IsValid) return false;
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
			txtGenCtlStyleId.Text = "";
			txtGenCtlStyleName.Text = "";
			txtStyle.Text = "";
			txtRunat.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			txtWidth.Text = "0";
			txtHeight.Text = "0";
			txtTextMode.Text = "";
			txtStyleZindex.Text = "0";
			txtStyleLeft.Text = "0";
			txtStylePosition.Text = "";
			txtStyleTop.Text = "0";
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