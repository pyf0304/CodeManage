///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using com.taishsoft.commdb;
using CommFunc4WebForm;

using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;


using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmFieldTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmFieldTab_Disp : CommWebPageBase
    {

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				//1��Ϊ��������������Դ�����б�����
				wucFieldTab1.SetDdl_PrjId();
				wucFieldTab1.SetDdl_FldType();
				wucFieldTab1.SetDdl_IsNull();
//				wucFieldTab1.SetDdl_IsPrimaryKey();
				wucFieldTab1.SetDdl_CodeTab();
                wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);

				clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
				BindDdl_IsNull(ddlIsNullq);
				BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);

                //				clsDropDownList.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

				ddlFldStateIdq.SelectedValue = "01";


				strSortBy = "FldName Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindGv_FieldTab();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucFieldTab1.SetKeyReadOnly(true);
				tabLayout.Visible = false;
				
				
			}
		}

        private string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }
        private string ErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
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
		private string CombineFieldTabCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 and PrjId='" + clsPubVar.CurrSelPrjId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim()+"%'";
			}
			if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
				strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue+"'";
			}
			if (this.ddlObjIdq.SelectedValue!="" && this.ddlObjIdq.SelectedValue!="0")
			{
				strWhereCond += " and Fldid in (select fldid from FldObjTab where ObjId='" + this.ddlObjIdq.SelectedValue+"')";
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
        protected void BindGv_FieldTab()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombineFieldTabCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortFieldTabBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            this.gvFieldTab.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvFieldTab.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            if (lblRecCount != null)
            {
                //��ǰ��¼��
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //��ǰҳ��
                lblAllPages.Text = this.gvFieldTab.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvFieldTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvFieldTab.PageIndex == this.gvFieldTab.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
            }
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
			this.gvFieldTab.PageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindGv_FieldTab();
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
			///���ö����б�
            List<ObjStruct> arrLst = new List<ObjStruct>();
            string strCondition = string.Format("{0} = '{1}'", 
                convPrjTabFld.FldId,
                pobjFieldTab.FldId);

            List<clsvPrjTabFldEN> arrvPrjTabFldLst = clsvPrjTabFldBL.GetObjLst(strCondition);
			ObjStruct objStruct;
			if (arrvPrjTabFldLst.Count>0)
			{
				foreach(clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldLst)
				{
					objStruct.strObjId = objvPrjTabFldEN.TabId;
					objStruct.strObjName = objvPrjTabFldEN.TabName;
					arrLst.Add(objStruct);
				}
				wucFieldTab1.TabList = arrLst;
			}
		}
        protected string GetFirstCheckedItemFromGv(GridView objGv)
        {
            if (objGv.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                    if (chkCheckRec != null && chkCheckRec.Checked)
                    {
                        return di.Cells[1].Text;
                    }
                }
            }
            return "";
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
			
            List<ObjStruct> arrLst;
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
						arrLst = wucFieldTab1.TabList;
						//foreach(ObjStruct strObjId in arrLst)
						//{
						//	objFldObjTab.ObjId = strObjId.strObjId;
						//	if (clsFldObjTabBL .AddNewRecordBySql2(objFldObjTab) == false) break;
						//}
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindGv_FieldTab();
					wucFieldTab1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "���";
					tabLayout.Visible = false;
					tabQuery.Visible = true;

					break;
				case "�ر�":
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
            //var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(pobjFieldTab.FldId, pobjFieldTab.PrjId);
            //if (objFieldTab4CodeConv != null)
            //{

            //    pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
            //    pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
            //    pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
            //    pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
            //}
			pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
			pobjFieldTab.UpdUser = wucFieldTab1.UserId;

        }

		protected void gvFieldTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
//				System.Web.UI.WebControls.LinkButton myDeleteButton;
//				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
//				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");
			}
			int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.gvFieldTab.Columns.Count;i++)
				{
					strSortEx = this.gvFieldTab.Columns[i].SortExpression;
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

		/// <summary>
		/// ����Excel�ļ����ֶ�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromExcel.aspx");
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


		protected void gvFieldTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindGv_FieldTab();
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
			BindGv_FieldTab();

		}
        
        protected void gvFieldTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = vsSortFieldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
                BindGv_FieldTab();
                return;
            }
            //���ԭ��������
            intIndex = vsSortFieldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                vsSortFieldTabBy = e.SortExpression + " Desc";
            }
            BindGv_FieldTab();
        }

		protected void btnExportExcel_Click(object sender, System.EventArgs e)
		{
			//	1����Ͻ�����������
			string strWhereCond = CombineFieldTabCondition();
			//	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "�����ֶα���Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("FldId"); arrCnName.Add("�ֶ�ID");
			arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
			arrColName.Add("Caption"); arrCnName.Add("����");
			arrColName.Add("DataTypeName"); arrCnName.Add("�ֶ�����");
			arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
			arrColName.Add("IsNull"); arrCnName.Add("�Ƿ�ɿ�");
			arrColName.Add("IsPrimaryKey"); arrCnName.Add("�Ƿ�����");
			arrColName.Add("IsIdentity"); arrCnName.Add("�Ƿ�Identity");
			arrColName.Add("MaxValue"); arrCnName.Add("���ֵ");
			arrColName.Add("MinValue"); arrCnName.Add("��Сֵ");
			arrColName.Add("DefaultValue"); arrCnName.Add("ȱʡֵ");
			arrColName.Add("PrjName"); arrCnName.Add("��������");
			arrColName.Add("CodeTab"); arrCnName.Add("�����");
			arrColName.Add("CodeTabName"); arrCnName.Add("�����_����");
			arrColName.Add("CodeTabCode"); arrCnName.Add("�����_����");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
			DownLoadFile(strDownLoadFileName);

		}
		/// <summary>
		/// ���ܣ������ļ����ӷ����������ļ����ͻ��������
		/// </summary>
		/// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
		/// <returns></returns>
		private bool DownLoadFile(string strDownLoadFileName)
		{
			//			string path = "D:\\�Ŀ�����������Լ��.doc";		//WORD�ļ�����ֱ������
			///			string path = "D:\\1000010811.JPG";	//JPG�ļ���������ʾ���һ�����
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			//Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End(); 
			return true;
		}

		protected void ddlFuncModuleId_q_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlFuncModuleIdq.SelectedIndex>0)
			{
				string strFuncModuleId = ddlFuncModuleIdq.SelectedValue;
            //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
			}
		}
        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFieldTab.PageCount)
                {
                    this.gvFieldTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_FieldTab();
            }
        }
        protected void gvFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];

                iNum[0] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsNull); //8;
                iNum[1] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsPrimaryKey); //9;
                for (int i = 0; i < 2; i++)
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
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvFieldTab.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_FieldTab();
        }
        ///ɾ����¼���̴���for C#
        protected void gvFieldTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFieldTab.PageIndex = e.NewPageIndex;
                this.BindGv_FieldTab();
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvFieldTab_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Row.RowIndex + 1).ToString() + " ����');");
                }
            }
            int intIndex;
            if (vsSortFieldTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvFieldTab.Columns.Count; i++)
                {
                    strSortEx = this.gvFieldTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortFieldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = vsSortFieldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }
        ///����GridView��������¼�����
        protected void gvFieldTab_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "ȫѡ")
                    {
                        Set_GridViewAllChecked(gvFieldTab, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        Set_GridViewAllChecked(gvFieldTab, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }

        protected string vsSortFieldTabBy
        {
            get
            {
                string sSortFieldTabBy;
                sSortFieldTabBy = (string)ViewState["SortFieldTabBy"];
                if (sSortFieldTabBy == null)
                {
                    sSortFieldTabBy = "";
                }
                return sSortFieldTabBy;
            }
            set
            {
                string sSortFieldTabBy = value;
                ViewState.Add("SortFieldTabBy", sSortFieldTabBy);
            }
        }
        protected void Set_GridViewAllChecked(GridView objGv, bool IsSelected)
        {
            if (objGv.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            string strFldID = GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            tabLayout.Visible = true;
            tabQuery.Visible = false;
            ShowData(strFldID);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "�ر�";
            lblMsg.Text = "";
        }
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
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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