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


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmFieldTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmFieldTab_Archive : CommWebPageBase
    {
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
                //1��Ϊ��������������Դ�����б�����

                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
				BindDdl_IsNull(ddlIsNullq);
				BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);

                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
				clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);

				ddlFldStateIdq.SelectedValue = "01";

				strSortBy = "FldName Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_FieldTab();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
			
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
                strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue + "'";
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

		protected void dgFieldTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
//				System.Web.UI.WebControls.LinkButton myDeleteButton;
//				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
//			
//				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");
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
			System.Web.UI.WebControls.CheckBox chkIsChecked, chkIsArchive;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 7;
				iNum[1] = 8;
				iNum[2] = 9;
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
				chkIsChecked = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsChecked");
				string strIsChecked = e.Item.Cells[17].Text;
				chkIsChecked.Checked = bool.Parse(strIsChecked);

				chkIsArchive = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsArchive");
				string strIsArchive = e.Item.Cells[19].Text;
				chkIsArchive.Checked = bool.Parse(strIsArchive);

			}
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


		protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromSQL.aspx");
		
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

		protected void lbSetArchive_Click(object sender, System.EventArgs e)
		{
			//�������裺
			//1����DG����ѭ��
			//2�����ÿһ���е�<�Ƿ�����><�Ƿ��ѯ>���ֶεı༭������д���
			//3����ѭ���г�ʼ��һ��clsFieldTabEN�������ùؼ���MID
			//4����ֵ��
			//5������
			///
			System.Web.UI.WebControls.CheckBox chkIsChecked;
			System.Web.UI.WebControls.CheckBox chkIsArchive;
			string strFldId;
			bool bolIsChecked, bolIsArchive;
			clsFieldTabEN objFieldTabEN;
			int intDgNum, intIndex;
			DataGridItem item;
			//1����DG����ѭ��
			intDgNum = dgFieldTab.Items.Count;

			for (intIndex = 0; intIndex <intDgNum; intIndex++)
			{
				item = dgFieldTab.Items[intIndex];
				strFldId = item.Cells[1].Text;
				//2�����ÿһ���е�<�Ƿ�����><�Ƿ��ѯ>���ֶεı༭������д���
				//3����ѭ���г�ʼ��һ��clsFieldTabEN�������ùؼ���MID
                objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

				//4����ֵ��
				
				chkIsChecked = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsChecked");
				bolIsChecked= chkIsChecked.Checked ;

				chkIsArchive = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsArchive");
				bolIsArchive = chkIsArchive.Checked;

				objFieldTabEN.IsChecked = bolIsChecked;
				objFieldTabEN.IsArchive = bolIsArchive;
				//5������
                if (objFieldTabEN.UpdateRecordEx() == false)
				{
					return ;
				}
			}
			BindDg_FieldTab();
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