
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogicEx;
    using AGC.FunClass;

    /// <summary>
    ///		wucViewFldInfo ��ժҪ˵����
    /// </summary>
    public partial class wucViewFldInfo : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			tabHidden.Visible=false;

		}

	

		public string FldId
		{
			get
			{
				return ddlFldID.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFldID.SelectedValue = "0";
				}
				else
				{
					ddlFldID.SelectedValue = value;
				}
			}
		}

		public string ViewId
		{
			get
			{
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

		public string TabId
		{
			get
			{
				return ddlTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlTabId.SelectedValue = "0";
				}
				else
				{
					ddlTabId.SelectedValue = value;
				}
			}
		}

		public string CtlTypeId
		{
			get
			{
				return ddlCtlTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlCtlTypeId.SelectedValue = "0";
				}
				else
				{
					ddlCtlTypeId.SelectedValue = value;
				}
			}
		}

		public string DDLItemsOption
		{
			get
			{
				return ddlDDLItemsOption.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDDLItemsOption.SelectedValue = "0";
				}
				else
				{
					ddlDDLItemsOption.SelectedValue = value;
					ddlDDLItemsOption_SelectedIndexChanged(new object(), new System.EventArgs());
				}
			}
		}

		public string ItemsString
		{
			get
			{
				return txtItemsString.Text.Trim();
			}
			set
			{
				txtItemsString.Text = value.ToString();
			}
		}
		public string DsTabName
		{
			get
			{
				return ddlDsTabName.SelectedItem.Text;
			}
			set
			{
				if (value == "")
				{
					ddlDsTabName.SelectedValue = "0";
				}
				else
				{
//					ddlDsTabName.SelectedItem.Text = value;
					for (int i = 0; i<ddlDsTabName.Items.Count; i++)
					{
						if (ddlDsTabName.Items[i].Text == value)
						{
							ddlDsTabName.SelectedIndex = i;
							break;
						}
					}
					ddlDsTabName_SelectedIndexChanged(new object(), new System.EventArgs());
				}
			}
		}

		public string DsDataValueField
		{
			get
			{
				return ddlDsDataValueField.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataValueField.SelectedValue = "0";
				}
				else
				{
					foreach(System.Web.UI.WebControls.ListItem ss in ddlDsDataValueField.Items)
					{
						if (ss.Value == value)
						{
							ddlDsDataValueField.SelectedValue = value;
							break;
						}
					}
				}
			}
		}
		public string DsDataTextField
		{
			get
			{
				return ddlDsDataTextField.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataTextField.SelectedValue = "0";
				}
				else
				{
					foreach(System.Web.UI.WebControls.ListItem ss in ddlDsDataValueField.Items)
					{
						if (ss.Value == value)
						{
							ddlDsDataTextField.SelectedValue = value;
							break;
						}
					}
				}
			}
		}

		public string DsCondStr
		{
			get
			{
				return txtDsCondStr.Text.Trim();
			}
			set
			{
				txtDsCondStr.Text = value.ToString();
			}
		}

		public string DsSqlStr
		{
			get
			{
				return txtDsSqlStr.Text.Trim();
			}
			set
			{
				txtDsSqlStr.Text = value.ToString();
			}
		}

		public bool IsQuery
		{
			get
			{
				return chkIsQuery.Checked;
			}
			set
			{
				chkIsQuery.Checked = value;
			}
		}

		public bool IsDataGrid
		{
			get
			{
				return chkIsDataGrid.Checked;
			}
			set
			{
				chkIsDataGrid.Checked = value;
			}
		}

		public bool IsNeedSort
		{
			get
			{
				return chkIsNeedSort.Checked;
			}
			set
			{
				chkIsNeedSort.Checked = value;
			}
		}

		public string QueryOption
		{
			get
			{
				return ddlQueryOption.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlQueryOption.SelectedValue = "0";
				}
				else
				{
					ddlQueryOption.SelectedValue = value;
				}
			}
		}

		public bool IsCtlField
		{
			get
			{
				return chkIsCtlField.Checked;
			}
			set
			{
				chkIsCtlField.Checked = value;
			}
		}

		public string UpdDate
		{
			get
			{
				return txtUpdDate.Text.Trim();
			}
			set
			{
				txtUpdDate.Text = value.ToString();
			}
		}

		public string UserId
		{
			get
			{
				return txtUserId.Text.Trim();
			}
			set
			{
				txtUserId.Text = value.ToString();
			}
		}


		public void Clear()
		{
			ddlFldID.SelectedIndex = 0;
			ddlViewId.SelectedIndex = 0;
			ddlTabId.SelectedIndex = 0;
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDDLItemsOption.SelectedIndex = 0;
			txtItemsString.Text = "";
			ddlDsTabName.SelectedIndex = 0;
			ddlDsDataValueField.SelectedIndex = 0;
			ddlDsDataTextField.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			txtDsSqlStr.Text = "";
			chkIsQuery.Checked = false;
			chkIsDataGrid.Checked = false;
			chkIsNeedSort.Checked = false;
			ddlQueryOption.SelectedIndex = 0;
			chkIsCtlField.Checked = false;
			txtUpdDate.Text = "";
			txtUserId.Text = "";
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
			ddlFldID.SelectedIndex = 0;
			ddlViewId.SelectedIndex = 0;
			ddlTabId.SelectedIndex = 0;
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDDLItemsOption.SelectedIndex = 0;
			txtItemsString.Text = "";
			ddlDsTabName.SelectedIndex = 0;
			ddlDsDataValueField.SelectedIndex = 0;
			ddlDsDataTextField.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			txtDsSqlStr.Text = "";
			chkIsQuery.Checked = false;
			chkIsDataGrid.Checked = false;
			chkIsNeedSort.Checked = false;
			ddlQueryOption.SelectedIndex = 0;
			chkIsCtlField.Checked = false;
			txtUpdDate.Text = "";
			txtUserId.Text = "";
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
		
	
		public System.Data.DataTable GetDDLItemsOption()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select DdlItemsOptionId, DDLItemsOption from DDLItemsOption ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DDLItemsOption(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetDDLItemsOption();
			objDDL.DataValueField="DdlItemsOptionId";
			objDDL.DataTextField="DDLItemsOption";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetQueryOption()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select QueryOptionId, QueryOptionName from QueryOption ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_QueryOption(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetQueryOption();
			objDDL.DataValueField="QueryOptionId";
			objDDL.DataTextField="QueryOptionName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_FldID(string strPrjId)
		{
            clsFieldTabBLEx.BindDdl_FldIDEx(ddlFldID, strPrjId);
		}
		public void SetDdl_ViewId(string strPrjId)
        {
            clsViewInfoBLEx.BindDdl_ViewIdEx(ddlViewId, strPrjId);
		}
		public void SetDdl_TabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, strPrjId);
		}
		public void SetDdl_CtlTypeId(bool bolIsForApple)
		{
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
		}
		public void SetDdl_DDLItemsOption()
		{
			BindDdl_DDLItemsOption(ddlDDLItemsOption);
		}
		public void SetDdl_QueryOption()
		{
			BindDdl_QueryOption(ddlQueryOption);
		}
		public void SetDdl_DsTabName(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDsTabName, strPrjId);
		}
		public void SetDdl_DsDataValueField(string strTabId)
		{
			clsDropDownList.BindDdl_DsDataValueField(ddlDsDataValueField, strTabId);
		}
		public void SetDdl_DsDataTextField(string strTabId)
		{
			clsDropDownList.BindDdl_DsDataTextField(ddlDsDataTextField, strTabId);
		}

		protected void ddlDsTabName_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetDdl_DsDataTextField(ddlDsTabName.SelectedValue);
			SetDdl_DsDataValueField(ddlDsTabName.SelectedValue);
		}

		protected void ddlDDLItemsOption_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlDDLItemsOption.SelectedValue == "02")//����Դ��02��
			{
				ddlDsTabName.Enabled = true;
				ddlDsDataTextField.Enabled = true;
				ddlDsDataValueField.Enabled = true;
                SetDdl_DsTabName(clsPubVar.CurrSelPrjId);
			}
		}
	}
}