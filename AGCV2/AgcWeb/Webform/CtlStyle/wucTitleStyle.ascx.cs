
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
	///		wucTitleStyle ��ժҪ˵����
	/// </summary>
	public partial class wucTitleStyle : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public string TitleStyleId
		{
			get
			{
				return txtTitleStyleId.Text.Trim();
			}
			set
			{
				txtTitleStyleId.Text = value.ToString();
			}
		}

		public string TitleStyleName
		{
			get
			{
				return txtTitleStyleName.Text.Trim();
			}
			set
			{
				txtTitleStyleName.Text = value.ToString();
			}
		}

		public string ImgFile
		{
			get
			{
				return txtImgFile.Text.Trim();
			}
			set
			{
				txtImgFile.Text = value.ToString();
			}
		}

		public int TabHeight
		{
			get
			{
				return int.Parse(txtTabHeight.Text.Trim());
			}
			set
			{
				txtTabHeight.Text = value.ToString();
			}
		}

		public int TabWidth
		{
			get
			{
				return int.Parse(txtTabWidth.Text.Trim());
			}
			set
			{
				txtTabWidth.Text = value.ToString();
			}
		}

		public string TitleTypeId
		{
			get
			{
				return ddlTitleTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlTitleTypeId.SelectedValue = "0";
				}
				else
				{
					ddlTitleTypeId.SelectedValue = value;
				}
			}
		}

		public string BackColor
		{
			get
			{
				return txtBackColor.Text.Trim();
			}
			set
			{
				txtBackColor.Text = value.ToString();
			}
		}

		public string ForeColor
		{
			get
			{
				return txtForeColor.Text.Trim();
			}
			set
			{
				txtForeColor.Text = value.ToString();
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
			txtTitleStyleId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtTitleStyleId.Text = "";
			txtTitleStyleName.Text = "";
			txtImgFile.Text = "";
			txtTabHeight.Text = "0";
			txtTabWidth.Text = "0";
			ddlTitleTypeId.SelectedIndex = 0;
			txtBackColor.Text = "";
			txtForeColor.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			txtPrjId.Text = "";
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
			ComValid_TabHeight.Validate();
			if (!ComValid_TabHeight.IsValid) return false;
			ComValid_TabWidth.Validate();
			if (!ComValid_TabWidth.IsValid) return false;
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
			txtTitleStyleId.Text = "";
			txtTitleStyleName.Text = "";
			txtImgFile.Text = "";
			txtTabHeight.Text = "0";
			txtTabWidth.Text = "0";
			ddlTitleTypeId.SelectedIndex = 0;
			txtBackColor.Text = "";
			txtForeColor.Text = "";
			txtFontSize.Text = "";
			txtFontName.Text = "";
			txtPrjId.Text = "";
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
		
		public System.Data.DataTable GetTitleTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select TitleTypeId, TitleTypeName from TitleType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_TitleTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetTitleTypeId();
			objDDL.DataValueField="TitleTypeId";
			objDDL.DataTextField="TitleTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_TitleTypeId()
		{
			BindDdl_TitleTypeId(ddlTitleTypeId);
		}
	}
}