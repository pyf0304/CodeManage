using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmFieldTab_BackUp_QUDI :CommWebPageBase
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				lbDelFld.Attributes.Add("onclick", "return confirm('�����Ҫɾ����ѡ�ļ�¼��');");
				//1��Ϊ��������������Դ�����б�����
				wucFieldTab1.SetDdl_PrjId();
				wucFieldTab1.SetDdl_FldType();
				wucFieldTab1.SetDdl_IsNull();
//				wucFieldTab1.SetDdl_IsPrimaryKey();
				wucFieldTab1.SetDdl_CodeTab();

                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
				BindDdl_IsNull(ddlIsNullq);
				BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;

        
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId);
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
				wucFieldTab1.SetDdl_FldStateId();
                clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);

				ddlFldStateIdq.SelectedValue = "01";

				strSortBy = "FldName Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_FieldTab();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucFieldTab1.SetKeyReadOnly(true);
				tabLayout.Visible = false;
			
				
				
			}
		}


       
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
                    string strErrMessage = "�û�����Ϊ��,���ܲ���ʱ�䳬ʱ,Session��ʧ,��Ҫ���µ�¼!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim()+"%'";
			}
			if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
				strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue+"'";
			}
			if (this.ddlIsNullq.SelectedValue=="��")
			{
				strWhereCond += " and IsNull='1'";
			}
			else if (this.ddlIsNullq.SelectedValue=="��")
			{
				strWhereCond += " and IsNull='0'";
			}
			if (this.ddlIsPrimaryKeyq.SelectedValue=="��")
			{
				strWhereCond += " and IsPrimaryKey='1'" ;
			}
			else if (this.ddlIsPrimaryKeyq.SelectedValue=="��")
			{
					strWhereCond += " and IsPrimaryKey='0'" ;
			}
			if (this.txtAppliedScopeq.Text.Trim()!="")
			{
				strWhereCond += " and AppliedScope='" + this.txtAppliedScopeq.Text.Trim()+"'";
			}
			if (this.ddlFldStateIdq.SelectedValue!="" && this.ddlFldStateIdq.SelectedValue!="0")
			{
				strWhereCond += " And FldStateId='" + this.ddlFldStateIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_FieldTab()
		{
			//�������裺(��5��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//	4������DATAGRID������Դ(DataSource)��
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			//	6�����ü�¼����״̬��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

			//	1����Ͻ�����������
			string strWhereCond = CombineCondition();
			//	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgFieldTab.PageSize);
			if (intPages==0) 
			{
				this.dgFieldTab.CurrentPageIndex = 0;
			}
			else if (this.dgFieldTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgFieldTab.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;
			this.dgFieldTab.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgFieldTab.DataBind();
			//	6�����ü�¼����״̬��
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
		}

		/// <summary>
		/// ���ܣ�����DataGrid��ҳ��
		/// </summary>
		/// <param name="intRecCount">�ܹ��ļ�¼��</param>
		/// <param name="intPageSize">ÿҳ�ļ�¼��</param>
		/// <returns>���������ҳ��</returns>
		private int CalcPages(int intRecCount, int intPageSize)
		{
			int intPages;
			intPages = intRecCount / intPageSize;
			if (intRecCount % intPageSize !=0) intPages ++;
			return intPages;
		}
		private string strSortBy
		{
			get
			{
				string sSortBy;
				sSortBy = (string)ViewState["SortBy"];
				if (sSortBy==null) 
				{
					sSortBy = "";
				}
				return sSortBy;
			}
			set
			{
				string sSortBy = value;
				ViewState.Add("SortBy", sSortBy);
			}
		}                   

		/// <summary>
		/// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
			this.dgFieldTab.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_FieldTab();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgFieldTab.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_FieldTab();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strFldID">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strFldID)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strFldID == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsFieldTabBL.IsExist(strFldID) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strFldID + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldID);
			Session.Add("objFieldTabEN", objFieldTabEN);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromFieldTabClass(objFieldTabEN);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjFieldTab">��ʵ�������</param>
		private void GetDataFromFieldTabClass(clsFieldTabEN pobjFieldTab)
		{
			wucFieldTab1.FldId = pobjFieldTab.FldId;
			wucFieldTab1.PrjId = pobjFieldTab.PrjId;
			wucFieldTab1.FldName = pobjFieldTab.FldName;
			wucFieldTab1.DataTypeId = pobjFieldTab.DataTypeId;
            wucFieldTab1.FldLength = pobjFieldTab.FldLength;
            wucFieldTab1.FldPrecision = pobjFieldTab.FldPrecision ?? 0;
            wucFieldTab1.Caption = pobjFieldTab.Caption;
			wucFieldTab1.FldInfo = pobjFieldTab.FldInfo;
			wucFieldTab1.IsNull = pobjFieldTab.IsNull;
			wucFieldTab1.IsPrimaryKey = pobjFieldTab.IsPrimaryKey;
			wucFieldTab1.MaxValue = pobjFieldTab.MaxValue;
			wucFieldTab1.MinValue = pobjFieldTab.MinValue;
			wucFieldTab1.DefaultValue = pobjFieldTab.DefaultValue;
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(pobjFieldTab.FldId, pobjFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                wucFieldTab1.IsNeedTransCode = true;
                wucFieldTab1.CodeTabId = objFieldTab4CodeConv.CodeTabId;
                wucFieldTab1.CodeTabNameId = objFieldTab4CodeConv.CodeTabNameId;
                wucFieldTab1.CodeTabCodeId = objFieldTab4CodeConv.CodeTabCodeId;
            }			
			wucFieldTab1.FldStateId = pobjFieldTab.FldStateId;

			///���ö����б�
            List<ObjStruct> arrLst = new List<ObjStruct>();
			StringBuilder strSQL = new StringBuilder();
			strSQL.Append("SELECT dbo.FldObjTab.ObjId, dbo.PrjObjects.ObjName");
			strSQL.Append(" FROM dbo.FldObjTab left OUTER JOIN");
			strSQL.Append(" dbo.PrjObjects ON dbo.FldObjTab.ObjId = dbo.PrjObjects.ObjId");
			strSQL.AppendFormat(" WHERE (dbo.FldObjTab.FldId = '{0}')", pobjFieldTab.FldId);
			DataTable objDT = clsGeneralTab2.GetDataTable(strSQL.ToString());
			ObjStruct objStruct;
			if (objDT !=null)
			{
				foreach(DataRow objRow in objDT.Rows)
				{
					objStruct.strObjId = objRow["ObjId"].ToString();
					objStruct.strObjName = objRow["ObjName"].ToString();
					arrLst.Add(objStruct);
				}
				wucFieldTab1.TabList = arrLst;
			}
		}

		/// <summary>
		/// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
		///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strMsg;	//ר�����ڴ�����Ϣ�ı���
			string strCommandText;
			clsFieldTabEN objFieldTabEN;
	
			List<ObjStruct> arrObjStructLst;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;

			switch(strCommandText)
			{
				case "���":
					wucFieldTab1.SetKeyReadOnly(false);
                    wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
					btnOKUpd.Text = "ȷ�����";
					break;				
				case "ȷ�����":
					//����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					//�������裺
					//1�����ؼ����������������Ƿ���ȷ
					//2��������󲢳�ʼ������
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					//6��������ʵ�������ݴ��������ݿ���
					//7��������ļ�¼������ʾ��DATAGRID��
					//1�����ؼ����������������Ƿ���ȷ
					if (!wucFieldTab1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsFieldTabEN objFieldTabEN;	//�������
					objFieldTabEN = new clsFieldTabEN(wucFieldTab1.FldId);	//��ʼ���¶���
		
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToFieldTabClass(objFieldTabEN);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
                    if (objFieldTabEN.AddRecordEx() == false) 
					{
						strMsg = "��Ӳ��ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼���ɹ�!";
					}
					else
					{
						strMsg = "��Ӽ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "��Ӽ�¼�ɹ�!";

                        arrObjStructLst = wucFieldTab1.TabList;
                        List<string> arrTarTabIdLst = new List<string>();
                        foreach (ObjStruct objTab in arrObjStructLst)
                        {
                            arrTarTabIdLst.Add(objTab.strObjId);
                        }
                        clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);
                                              
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindDg_FieldTab();
					wucFieldTab1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "���";
					tabLayout.Visible = false;
					tabQuery.Visible = true;

					break;
				case "ȷ���޸�":
					//����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					//�������裺
					//1�����ؼ����������������Ƿ���ȷ
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					//4��������ʵ�������ݴ��������ݿ���
					//5�����޸ĺ��������ʾ��DATAGRID��
					//1�����ؼ����������������Ƿ���ȷ
					if (!wucFieldTab1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objFieldTabEN = (clsFieldTabEN) Session["objFieldTabEN"];
					if (clsFieldTabBLEx.IsCanDelUpd(objFieldTabEN.FldId) == false) 
					{
						strMsg = "�ü�¼�Ѻ�ʵ��鵵�������޸�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�ü�¼�Ѻ�ʵ��鵵�������޸�!";
						//return ;
					}
					else
					{
						PutDataToFieldTabClass(objFieldTabEN);		//�ѽ����ֵ����
						//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                        try
                        {
                            clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
						//4��������ʵ���������޸�ͬ�������ݿ���
                        if (objFieldTabEN.UpdateRecordEx() == false) 
						{
							strMsg = "�޸ļ�¼���ɹ�!";
							clsCommonJsFunc.Alert(this, strMsg);
							lblMsg.Text = "�޸ļ�¼���ɹ�!";
						}
						else
						{
							strMsg = "�޸ļ�¼�ɹ�!";
							clsCommonJsFunc.Alert(this, strMsg);
							lblMsg.Text = "�޸ļ�¼�ɹ�!";
						

                            arrObjStructLst = wucFieldTab1.TabList;
                            List<string> arrTarTabIdLst = new List<string>();
                            foreach (ObjStruct objTab in arrObjStructLst)
                            {
                                arrTarTabIdLst.Add(objTab.strObjId);
                            }
                            clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);
                                                       
						}
						//5�����޸ĺ��������ʾ��DATAGRID��
						BindDg_FieldTab();
						wucFieldTab1.Clear();//��տؼ��е�����
					}
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					tabLayout.Visible = false;
					tabQuery.Visible = true;
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjFieldTab">���ݴ����Ŀ�������</param>
		private void PutDataToFieldTabClass(clsFieldTabEN pobjFieldTab)
		{
			pobjFieldTab.FldId = wucFieldTab1.FldId;
			pobjFieldTab.PrjId = wucFieldTab1.PrjId;
			pobjFieldTab.FldName = wucFieldTab1.FldName;
			pobjFieldTab.DataTypeId = wucFieldTab1.DataTypeId;
			pobjFieldTab.FldLength = wucFieldTab1.FldLength;
			pobjFieldTab.Caption = wucFieldTab1.Caption;
			pobjFieldTab.FldInfo = wucFieldTab1.FldInfo;
			pobjFieldTab.IsNull = wucFieldTab1.IsNull;
			pobjFieldTab.IsPrimaryKey = wucFieldTab1.IsPrimaryKey;
			pobjFieldTab.MaxValue = wucFieldTab1.MaxValue;
			pobjFieldTab.MinValue = wucFieldTab1.MinValue;
			pobjFieldTab.DefaultValue = wucFieldTab1.DefaultValue;
			//pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
			//pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
			//pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
			//pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
			pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
			pobjFieldTab.UpdUser = wucFieldTab1.UserId;

			pobjFieldTab.FldStateId = wucFieldTab1.FldStateId;
		}

		protected void dgFieldTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");
			}
				int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgFieldTab.Columns.Count;i++)
				{
					strSortEx = this.dgFieldTab.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
			
		}

		protected void dgFieldTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strFldID;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strFldID = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						if (clsFieldTabBLEx.IsCanDelUpd(strFldID) == false) return ;
						clsFieldTabBL.DelRecord(strFldID);
						BindDg_FieldTab();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						tabLayout.Visible = true;
						tabQuery.Visible = false;
						ShowData(strFldID);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucFieldTab1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						break;
					default:
						// Do nothing.
						break;
				}
			}

			if (e.Item.ItemType == ListItemType.Header)
			{
				System.Web.UI.WebControls.LinkButton lbSelAll;
				lbSelAll = (LinkButton)e.CommandSource;
				if (lbSelAll.CommandName != "lbSelAll")
				{
					return ;
				}
				if (lbSelAll.Text == "ȫѡ")
				{
					Set_DataGridAllChecked(dgFieldTab, true);
					lbSelAll.Text = "��ѡ";
				}
				else if (lbSelAll.Text == "��ѡ")
				{
					Set_DataGridAllChecked(dgFieldTab, false);
					lbSelAll.Text = "ȫѡ";
				}
			}
		}

		private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
		{
			if(objDg.Items.Count==0 )
			{
				return;
			}
			else 
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("chkCheckRec");
					if(cb!=null )
					{
						cb.Checked=IsSelected;
					}
				}

			}
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

		protected void dgFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
//			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 8;
				iNum[1] = 9;
				iNum[2] = 10;
				for (int i = 0; i<3; i++)
				{
					if (e.Item.Cells[iNum[i]].Text == "True")
					{
						e.Item.Cells[iNum[i]].Text = "��";
						e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
					}
					else
					{
						e.Item.Cells[iNum[i]].Text = "��";
						e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
					};
				}
			}
		}
/// <summary>
/// ����Excel�ļ����ֶ�
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
		{
//�������裺
//1����ȡ��ѡ�ļ�¼�б�
//2�������߼���ĺ������ݱ�ѡ�ֶ�
///
			ArrayList arrRec = clsCommForWebForm.Get_DgCheckedArr(dgFieldTab);
			if (clsFieldTabBLEx.BackupFldInfo(arrRec) == true)
			{
				lblMsg3.Text = "��ѡ�ֶα��ݳɹ�!";
			}
			else
			{
				lblMsg3.Text = "��ѡ�ֶα���ʧ�ܣ����ԭ��!";
			}
			BindDg_FieldTab();
		}

		protected void lbAddNewFld_Click(object sender, System.EventArgs e)
		{
			tabQuery.Visible = false;
			tabLayout.Visible = true;
			wucFieldTab1.SetKeyReadOnly(false);
            wucFieldTab1.PrjId = clsPubVar.CurrSelPrjId;
            
            wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
			btnOKUpd.Text = "ȷ�����";
		}

		protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromSQL.aspx");
		
		}

		protected void lbDispFieldList_Click(object sender, System.EventArgs e)
		{
			tabQuery.Visible = true;
			tabLayout.Visible = false;
		}

		
	
		protected void dgFieldTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_FieldTab();
				return ;
			}
			//���ԭ��������
			intIndex = strSortBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortBy = e.SortExpression + " Desc";
			}
			BindDg_FieldTab();

		}

		protected void lbDelFld_Click(object sender, System.EventArgs e)
		{
            ArrayList objArr = new ArrayList();
			objArr = clsCommForWebForm.Get_DgCheckedArr(this.dgFieldTab);
            List<string> objArr2 = clsArray.CopyArrayListToList_String(objArr);
            clsFieldTabBLEx.DelFieldTabEx(objArr2);
			BindDg_FieldTab();
//			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");
		}

		//protected void ddlObjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
		//{
		//	string strObjId = ddlObjIdq.SelectedValue;
  //          List<string> arrLst = new List<string>();
  //          arrLst = clsGeneralTab2.funGetFldValue("PrjTab", "TabName", "ObjId = '" + strObjId + "'");
		//	if (arrLst == null || arrLst.Count == 0)
		//		return ;
		//	lblRelaTab.Text = "��ر�" + arrLst[0].ToString();
		//}
		/// <summary>
		/// ����ѡ����������ֶΣ����Ƶ���ر��У�ͬʱɾ��������û�е��ֶ�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
		//{
		//	//�������裺
		//	//1����ȡ��ǰ��ID����ض���ID��
		//	//2����ȡ��ض���ID���ֶ�ID��DataTable;
		//	//3���Ըñ����ѭ�������ֶ���Ϣ���뵽һ��ArrayList
		//	//4���ڲ�������У�Ҫע���ֶ�ID���ظ������ܲ����ظ�
		//	//			string strWhereCond;
		//	string strObjId;
		//	//1����ȡ��ǰ��ID����ض���ID��
		//	strObjId = ddlObjIdq.SelectedValue;
		//	if (strObjId == null || strObjId.Length ==0)
		//	{
		//		return ;
		//	}
  //          if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
		//	{
		//		Response.Write("<script>alert('����ض������ֶ���Ϣ�ɹ�����')</script>");
		//	}
		//	else
		//	{
		//		Response.Write("<script>alert('�ö���������ر�ͬ��������������ԣ����߸ö���û����ص��ֶΣ���')</script>");
		//	}
		
        #region ����ҳ����Ϣ�Լ���ת������ҳ��

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    
                    
                    //{
                    
                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// ��ת������ҳ��
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion ����ҳ����Ϣ

        /// <summary>
        /// ����:��ǰҳ������
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}