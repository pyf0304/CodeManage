
///

namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.common;
	using com.taishsoft.commdb;
	using AGC.BusinessLogicEx;
	/// <summary>
	///		wucViewTypeCodeTab ��ժҪ˵����
	/// </summary>
	public partial class wucViewTypeCodeTab : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��

		}
		public int ViewTypeCode
		{
			get
			{
				return int.Parse( txtViewTypeCode.Text.Trim());
			}
			set
			{
				txtViewTypeCode.Text = value.ToString();
			}
		}

		public string ViewTypeName
		{
			get
			{
				return txtViewTypeName.Text.Trim();
			}
			set
			{
				txtViewTypeName.Text = value.ToString();
			}
		}

		public string ViewFunction
		{
			get
			{
				return txtViewFunction.Text.Trim();
			}
			set
			{
				txtViewFunction.Text = value.ToString();
			}
		}

		public string OptProcess
		{
			get
			{
				return txtOptProcess.Text.Trim();
			}
			set
			{
				txtOptProcess.Text = value.ToString();
			}
		}

		public string ViewDetail
		{
			get
			{
				return txtViewDetail.Text.Trim();
			}
			set
			{
				txtViewDetail.Text = value.ToString();
			}
		}

		public int ApplicationTypeId
		{
			get
			{
				if (ddlApplicationTypeId.SelectedValue == "0")
					return 0;
                return int.Parse(ddlApplicationTypeId.SelectedValue.ToString());

            }
            set
			{
				if (value == 0)
				{
					ddlApplicationTypeId.SelectedValue = "0";
				}
				else
				{
                    try
                    {
                        ddlApplicationTypeId.SelectedValue = value.ToString();
                    }
                    catch(Exception objException)
                    {
						clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
					}
				}
			}
		}

		public bool IsHaveAdd
		{
			get
			{
				return chkIsHaveAdd.Checked;
			}
			set
			{
				chkIsHaveAdd.Checked = value;
			}
		}

		public bool IsHaveUpdate
		{
			get
			{
				return chkIsHaveUpdate.Checked;
			}
			set
			{
				chkIsHaveUpdate.Checked = value;
			}
		}

        public bool IsHaveExeAdd
        {
            get
            {
                return chkIsHaveExeAdd.Checked;
            }
            set
            {
                chkIsHaveExeAdd.Checked = value;
            }
        }

        public bool IsHaveExeUpdate
        {
            get
            {
                return chkIsHaveExeUpdate.Checked;
            }
            set
            {
                chkIsHaveExeUpdate.Checked = value;
            }
        }

		public bool IsHaveDel
		{
			get
			{
				return chkIsHaveDel.Checked;
			}
			set
			{
				chkIsHaveDel.Checked = value;
			}
		}

		public bool IsHaveQuery
		{
			get
			{
				return chkIsHaveQuery.Checked;
			}
			set
			{
				chkIsHaveQuery.Checked = value;
			}
		}

		public bool IsHaveExcelExport
		{
			get
			{
				return chkIsHaveExcelExport.Checked;
			}
			set
			{
				chkIsHaveExcelExport.Checked = value;
			}
		}

        public bool IsHaveSetExportExcel
        {
            get
            {
                return chkIsHaveSetExportExcel.Checked;
            }
            set
            {
                chkIsHaveSetExportExcel.Checked = value;
            }
        }
		public bool IsHaveDetail
		{
			get
			{
				return chkIsHaveDetail.Checked;
			}
			set
			{
				chkIsHaveDetail.Checked = value;
			}
		}

        public bool IsHaveMainView
        {
            get
            {
                return chkIsHaveMainView.Checked;
            }
            set
            {
                chkIsHaveMainView.Checked = value;
            }
        }
        public bool IsHaveSubView
        {
            get
            {
                return chkIsHaveSubView.Checked;
            }
            set
            {
                chkIsHaveSubView.Checked = value;
            }
        }

        /// <summary>
        /// �Ƿ�WebӦ��
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsWebApp
        {
            get
            {
                return chkIsWebApp.Checked;
            }
            set
            {
                chkIsWebApp.Checked = value;
            }
        }

        /// <summary>
        /// �Ƿ�WinӦ��
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsWinApp
        {
            get
            {
                return chkIsWinApp.Checked;
            }
            set
            {
                chkIsWinApp.Checked = value;
            }
        }

        /// <summary>
        /// �Ƿ��ƶ��ն�Ӧ��
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsMobileApp
        {
            get
            {
                return chkIsMobileApp.Checked;
            }
            set
            {
                chkIsMobileApp.Checked = value;
            }
        }

        public void SetKeyReadOnly(bool bolReadonly)
		{
			txtViewTypeCode.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtViewTypeCode.Text = "";
			txtViewTypeName.Text = "";
			txtViewFunction.Text = "";
			txtOptProcess.Text = "";
			txtViewDetail.Text = "";
			ddlApplicationTypeId.SelectedIndex = 0;
            chkIsHaveAdd.Checked = false;
            chkIsHaveUpdate.Checked = false;
            chkIsHaveExeAdd.Checked = false;
            chkIsHaveExeUpdate.Checked = false;
            chkIsHaveDel.Checked = false;
			chkIsHaveQuery.Checked = false;
			chkIsHaveExcelExport.Checked = false;
			chkIsHaveDetail.Checked = false;
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
			txtViewTypeCode.Text = "";
			txtViewTypeName.Text = "";
			txtViewFunction.Text = "";
			txtOptProcess.Text = "";
			txtViewDetail.Text = "";
			ddlApplicationTypeId.SelectedIndex = 0;
			chkIsHaveAdd.Checked = false;
			chkIsHaveUpdate.Checked = false;
            chkIsHaveExeAdd.Checked = false;
            chkIsHaveExeUpdate.Checked = false;
            chkIsHaveDel.Checked = false;
			chkIsHaveQuery.Checked = false;
			chkIsHaveExcelExport.Checked = false;
			chkIsHaveDetail.Checked = false;
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
		
		public void SetDdl_ApplicationTypeId()
		{
            clsDropDownList.BindDdl_ApplicationTypeId(ddlApplicationTypeId);
		}
	}
}