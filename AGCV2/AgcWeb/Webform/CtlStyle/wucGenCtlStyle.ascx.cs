
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
	///		wucGenCtlStyle 的摘要说明。
	/// </summary>
	public partial class wucGenCtlStyle : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

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
		/// 校验自定义控件中自子控件的类型数值是否是合法正确的。
		/// 一般规则：
		///		1、首先校验类型：整型、浮点型、日期型等，
		///			这些代码由自动生成代码帮助生成
		///		2、校验最值，即最大值和最小值等
		///			这些代码由自动生成代码帮助生成
		///		这些生成内容可以修改
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
		/// 设置该控件在插入状态下的缺省值
		/// 一般规则：
		///		1、如果是整型就默认为0；
		///		2、如果是浮点型不默认为0.0；
		///		3、如果是日期型就默认为当前的日期；
		///		4、如果是位(bit)型就默认为False;
		///		这些默认值可以再行修改
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
		/// 功能：获取当前日期的字符串
		/// 日期格式：
		///    日期的字符串的格式有三种：
		///		1、YYYYMMDD。	例如20050120
		///		2、YYYY-MM-DD	例如2005-01-20
		///		3、YYYY/MM/DD	例如2005/01/20
		/// </summary>
		/// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
		///							参数不同，函数返回值就不同，
		///							参见上面的日期格式
		///	</param>
		/// <returns>返回当前日期的字符串</returns>
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
		/// 功能：获取当前月的字符串
		/// 月的格式：
		///    月的字符串的格式有三种：
		///		1、YYYYMM。	例如200501
		///		2、YYYY-MM-DD	例如2005-01
		///		3、YYYY/MM/DD	例如2005/01
		/// </summary>
		/// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
		///							参数不同，函数返回值就不同，
		///							参见上面的月的格式
		///	</param>
		/// <returns>返回当前月的字符串</returns>
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