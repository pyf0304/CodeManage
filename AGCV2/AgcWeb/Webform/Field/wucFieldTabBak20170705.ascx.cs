
namespace AGC.Webform
{
    using System;
    using System.Collections;
    using System.Data;
    using System.Drawing;
    using System.Configuration;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using System.Collections.Generic;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    

    /// <summary>
    ///		wucFieldTab ��ժҪ˵����
    /// </summary>
    public partial class wucFieldTabBak20170705 : System.Web.UI.UserControl
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			tabHidden.Visible = false;

		}
        public UpdatePanelUpdateMode UpdateMode
        {
            get { return this.FieldTabUpdatePanel.UpdateMode; }
            set { this.FieldTabUpdatePanel.UpdateMode = value; }
        }

		public string FldId
		{
			get
			{
				return txtFldID.Text.Trim();
			}
			set
			{
				txtFldID.Text = value.ToString();
			}
		}
        public List<ObjStruct> ObjList
		{
			get
			{
                List<ObjStruct> arrLst = new List<ObjStruct>();
				int intLen = lstObjList.Items.Count;
				for ( int i = 0; i<intLen; i++)
				{
                    ObjStruct obj = new ObjStruct();
                    obj.strObjId = lstObjList.Items[i].Value;
                    obj.strObjName = lstObjList.Items[i].Text;

                    arrLst.Add(obj);
				}
				return arrLst;
			}
			set
			{
				ListItem li;
				lstObjList.Items.Clear();
				foreach ( ObjStruct objStruct in value)
				{
					li=new ListItem(objStruct.strObjName, objStruct.strObjId);
					lstObjList.Items.Add(li);
				}
			}
		}
		public string PrjId
		{
			get
			{
				return ddlPrjId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlPrjId.SelectedValue = "0";
				}
				else
				{
					ddlPrjId.SelectedValue = value;
				}
			}
		}

		public string FldName
		{
			get
			{
				return txtFldName.Text.Trim();
			}
			set
			{
				txtFldName.Text = value.ToString();
			}
		}

		public string DataTypeId
		{
			get
			{
				if (ddlFldType.SelectedValue == "0")
				{
					return "";
				}
				return ddlFldType.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFldType.SelectedValue = "0";
				}
				else
				{
					ddlFldType.SelectedValue = value;
				}
			}
		}
        /// <summary>
        /// �ֶγ���
        /// </summary>
		public int FldLength
		{
			get
			{
				return int.Parse(txtFldLength.Text.Trim());
			}
			set
			{
				txtFldLength.Text = value.ToString();
			}
		}
        /// <summary>
        /// Сλλ��-FldPrecision
        /// </summary>
        public int FldPrecision
        {
            get
            {
                if (string.IsNullOrEmpty(txtFldPrecision.Text.Trim()) == true) return 0;
                return int.Parse(txtFldPrecision.Text.Trim());
            }
            set
            {
                txtFldPrecision.Text = value.ToString();
            }
        }
		public string Caption
		{
			get
			{
				return txtCaption.Text.Trim();
			}
			set
			{
				txtCaption.Text = value.ToString();
			}
		}

		public string FldInfo
		{
			get
			{
				return txtFldInfo.Text.Trim();
			}
			set
			{
				txtFldInfo.Text = value.ToString();
			}
		}

		public bool IsNull
		{
			get
			{
				if (ddlIsNull.SelectedItem.Text == "��")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == true)
				{
					ddlIsNull.SelectedValue = "��";
				}
				else
				{
					ddlIsNull.SelectedValue = "��";
				}
			}
		}

		public bool IsPrimaryKey
		{
			get
			{
				return chkIsPrimaryKey.Checked;
			}
			set
			{
				chkIsPrimaryKey.Checked = value;
			}
		}
		public bool IsIdentity
		{
			get
			{
				return chkIsIdentity.Checked;
			}
			set
			{
				chkIsIdentity.Checked = value;
			}
		}

		public string FldName_G
		{
			get
			{
				return txtFldName_G.Text.Trim();
			}
			set
			{
				txtFldName_G.Text = value.ToString();
			}
		}

		public string FldName_B
		{
			get
			{
				return txtFldName_B.Text.Trim();
			}
			set
			{
				txtFldName_B.Text = value.ToString();
			}
		}


		public bool IsNationStandard
		{
			get
			{
				return chkIsNationStandard.Checked;
			}
			set
			{
				chkIsNationStandard.Checked = value;
			}
		}
		public string FldStateId
		{
			get
			{
				if (ddlFldStateId.SelectedValue == "0")
					return "";
				return ddlFldStateId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFldStateId.SelectedValue = "0";
				}
				else
				{
					ddlFldStateId.SelectedValue = value;
				}
			}
		}


		public string MaxValue
		{
			get
			{
				return txtMaxValue.Text.Trim();
			}
			set
			{
				txtMaxValue.Text = value.ToString();
			}
		}

		public string MinValue
		{
			get
			{
				return txtMinValue.Text.Trim();
			}
			set
			{
				txtMinValue.Text = value.ToString();
			}
		}

		public string DefaultValue
		{
			get
			{
				return txtDefaultValue.Text.Trim();
			}
			set
			{
				txtDefaultValue.Text = value.ToString();
			}
		}

		public bool IsNeedTransCode
		{
			get
			{
				return chkIsNeedTransCode.Checked;
			}
			set
			{
				chkIsNeedTransCode.Checked = value;
				SetForIsNeedTransCode_CheckedChanged();
			}
		}

		public string CodeTabId
		{
			get
			{
				if (chkIsNeedTransCode.Checked == false)
					return "";
				if (ddlCodeTab.SelectedItem.Text =="��ѡ��...")
				{
					return "";
				}
				return ddlCodeTab.SelectedValue;
			}
			set
			{
				if (value=="")
				{
					if (ddlCodeTab.Items.Count>0)
					{
						ddlCodeTab.SelectedIndex = 0;
					}
				}
				else
				{
					ddlCodeTab.SelectedValue = value;
				}
				SetForCodeTab_SelectedIndexChanged();
			}
		}
		public string CodeTabNameId
		{
			get
			{
				if (chkIsNeedTransCode.Checked == false)
					return "";
				return ddlCodeTabName.SelectedValue;
			}
			set
			{
				if (value != "")
				{
                    try
                    {
                        ddlCodeTabName.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {

						clsPubVar.objLog.WriteDebugLog(objException.Message);
					}
				}
				
			}
		}
		public string CodeTabCodeId
		{
			get
			{
				if (chkIsNeedTransCode.Checked == false)
					return "";
				return ddlCodeTabCode.SelectedValue;
			}
			set
			{
				if (value != "")
				{
                    try
                    {
                        ddlCodeTabCode.SelectedValue = value;
                    }
                    catch(Exception objException)
					{
						clsPubVar.objLog.WriteDebugLog(objException.Message);

					}
				}
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

		public string AppliedScope
		{
			get
			{
				return txtAppliedScope.Text.Trim();
			}
			set
			{
				txtAppliedScope.Text = value.ToString();
			}
		}



		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtFldID.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtFldID.Text = "";
            ddlPrjId.SelectedIndex = 0;
			txtFldName.Text = "";
			ddlFldType.SelectedIndex = 0;
			txtFldLength.Text = "0";
			txtCaption.Text = "";
			txtFldInfo.Text = "";
			ddlIsNull.SelectedIndex = 0;
//			ddlIsPrimaryKey.SelectedIndex = 0;
			txtMaxValue.Text = "";
			txtMinValue.Text = "";
			txtDefaultValue.Text = "";
			chkIsNeedTransCode.Checked = false;
			
			ddlCodeTab.Visible=false;
			ddlCodeTabName.Visible=false;
			ddlCodeTabCode.Visible=false;
			ddlCodeTab.SelectedIndex=0;
            if (ddlCodeTabName.Items.Count > 0)
            {
                ddlCodeTabName.SelectedIndex = 0;
            }
            if (ddlCodeTabCode.Items.Count > 0)
            {
                ddlCodeTabCode.SelectedIndex = 0;
            }
			txtUpdDate.Text = "";
			txtUserId.Text = "";
			txtAppliedScope.Text = "";
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
			ComValid_FldLength.Validate();
			if (!ComValid_FldLength.IsValid) return false;
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
			txtFldID.Text = "";
            ddlPrjId.SelectedIndex = 0;
			txtFldName.Text = "";
			ddlFldType.SelectedIndex = 0;
			txtFldLength.Text = "0";
			txtCaption.Text = "";
			txtFldInfo.Text = "";
			ddlIsNull.SelectedIndex = 0;
//			ddlIsPrimaryKey.SelectedIndex = 0;
			txtMaxValue.Text = "";
			txtMinValue.Text = "";
			txtDefaultValue.Text = "";
			chkIsNeedTransCode.Checked = false;
			ddlCodeTab.Visible=false;
			ddlCodeTabName.Visible=false;
			ddlCodeTabCode.Visible=false;
			ddlCodeTab.SelectedIndex=0;
			ddlCodeTabName.SelectedIndex=0;
			ddlCodeTabCode.SelectedIndex=0;
			txtUpdDate.Text = "";
			txtUserId.Text = "";
			txtAppliedScope.Text = "";
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
		
		
	
		public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("��ѡ��...","0");
			objDDL.Items.Add("��");
			objDDL.Items.Add("��");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//Ϊ�������������ݵ�����������������б�����ֱ����ӵ�
			///objDDL.Items.Add("��");
			///objDDL.Items.Add("Ů");
		}
		public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("��ѡ��...","0");
			objDDL.Items.Add("��");
			objDDL.Items.Add("��");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//Ϊ�������������ݵ�����������������б�����ֱ����ӵ�
			///objDDL.Items.Add("��");
			///objDDL.Items.Add("Ů");
		}
		public void SetDdl_PrjId()
		{
            clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}
		public void SetDdl_FldType()
		{
           clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldType);
		}
		public void SetDdl_IsNull()
		{
			BindDdl_IsNull(ddlIsNull);
		}
		public void SetDdl_IsPrimaryKeyBak()
		{
//			BindDdl_IsPrimaryKey(ddlIsPrimaryKey);
		}
		public void BingDdl_DS_TabColumn(string strTabId, System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ������רҵ��������	
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT =clsDropDownList.GetDsDataTextField(strTabId);
			if (objDT.Rows.Count >0 )
			{
				objDDL.DataValueField= conFieldTab.FldId;
				objDDL.DataTextField= conFieldTab.FldName;
				objDDL.DataSource = objDT;
				objDDL.DataBind();
			}
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;

		}

		private void SetForCodeTab_SelectedIndexChanged()
		{
			string strTabId = ddlCodeTab.SelectedValue;
			BingDdl_DS_TabColumn(strTabId, ddlCodeTabCode);
			BingDdl_DS_TabColumn(strTabId, ddlCodeTabName);
		}
        //private string strPrjId
        //{
        //    get
        //    {
        //        string pstrPrjId;
        //        pstrPrjId = (string)Session["P1rjId"];
        //        if (pstrPrjId==null) 
        //        {
        //            pstrPrjId = "";
        //        }
        //        return pstrPrjId;
        //    }
        //    set
        //    {
        //        string pstrPrjId = value;
        //        Session.Add("PrjId", pstrPrjId);
        //    }
        //}
		public void SetDdl_CodeTab()
		{
            //Ϊ����ת������������
            //Ϊ������רҵ��������	
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlCodeTab, clsPubVar.CurrSelPrjId);
        }

        /// <summary>
        /// Ϊ����ID�������������
        /// </summary>
        public void SetLB_ObjId(string strPrjId)
		{
            //Ϊ����ת������������
            //Ϊ������רҵ��������	
            //clsvPrjObjects4DdlBLEx.BindLB_ObjId(lstSouObjList, strPrjId);
		}

		//public void BindDdl_ObjId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
		//{
		//	//Ϊ����Դ�ڱ����������������
		//	ListItem li=new ListItem("��ѡ��...","0");
		//	System.Data.DataTable objDT = GetObjId(strPrjId);
		//	objDDL.DataValueField="ObjId";
		//	objDDL.DataTextField="ObjName";
		//	objDDL.DataSource = objDT;
		//	objDDL.DataBind();
		//	objDDL.Items.Insert(0, li);
		//	objDDL.SelectedIndex = 0;
		//}
		
		private void SetForIsNeedTransCode_CheckedChanged()
		{
			if (chkIsNeedTransCode.Checked == true)
			{
				ddlCodeTab.Visible=true;
				ddlCodeTabName.Visible=true;
				ddlCodeTabCode.Visible=true;
				SetDdl_CodeTab();
			}
			else
			{
				ddlCodeTab.Visible=false;
				ddlCodeTabName.Visible=false;
				ddlCodeTabCode.Visible=false;
			}
		}

		protected void chkIsNeedTransCode_CheckedChanged(object sender, System.EventArgs e)
		{
			SetForIsNeedTransCode_CheckedChanged();
		}

		protected void ddlCodeTab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetForCodeTab_SelectedIndexChanged();
		}

		protected void lbAddObject_Click(object sender, System.EventArgs e)
		{
			if (lstSouObjList.SelectedIndex>0)
			{
				lstObjList.Items.Add(lstSouObjList.SelectedItem);
			}
		}

		protected void lbDelObject_Click(object sender, System.EventArgs e)
		{
			lstObjList.Items.Remove(lstObjList.SelectedItem);
		}
		
		
		public void SetDdl_FldStateId()
		{
            clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateId);
		}

        protected void lbEditTab_Click(object sender, EventArgs e)
        {
            string strObjName = lstObjList.SelectedItem.Text;
            string strCondition = string.Format("ObjName='{0}' And PrjId='{1}'", strObjName, clsPubVar.CurrSelPrjId);
            //string strObjId = clsPrjObjectsBL.GetFirstID_S(strCondition);
//            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            //clsPubFun4Web.JumpToEditTabAndObjectFieldsBak0170705(this.Page, "", strObjId, "");

        }

	}
}