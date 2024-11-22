///���ɲ�ѯ�޸ļ�¼�Ŀ��Ʋ����
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
using com.taishsoft.commdb;
using CommFunc4WebForm;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;



using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmUsers_Q ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmUserPrjGrant_Q : CommWebPageBase
    {

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				// �ڴ˴�����һЩ�û���ʼ������Ĵ��룬�������������������Դ��
				//wucStudent1.SetDdl_College();
				//1��Ϊ��������������Դ�����б�����
                clsUserRolesBL.BindDdl_RoleId(ddlRoleIdq);
                clsUserRolesBL.BindDdl_RoleId(ddlRoleId_New);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				//2����ʾ�������ı�������DATAGRID��
				//				string strSortBy = " Asc";
				strSortUserPrjGrantBy = "UserName Asc";

				BindDg_UserPrjGrant();
			}
		}

		/// <summary>
		/// ר�����ڴ洢��ǰ�����е�˽�б������û�ID
		/// �������Թ��̺�SESSION���洢�����е�˽�б�����
		///		����һ�����ɣ�Ҳ�Ǳ���˾�ı�̹滮�ͷ�������ʱ���Թ��̵ĵ�һ����ĸ���á�p��
		/// </summary>
		private string UserId
		{
			get
			{
				string strUserId;
				strUserId = (string)Session["UserId"];
				if (strUserId==null) 
				{
					strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
				return strUserId;
			}
			set
			{
				string strUserId = value;
				Session.Add("UserId", strUserId);
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
				}
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}
		
		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
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
				if (strErrMessage==null) 
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
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim()+"'";
			}
			if (this.txtUserNameq.Text.Trim()!="")
			{
				strWhereCond += " and UserName='" + this.txtUserNameq.Text.Trim()+"'";
			}
			if (this.ddlRoleIdq.SelectedValue!="" && this.ddlRoleIdq.SelectedValue!="0")
			{
				strWhereCond += " and RoleId='" + this.ddlRoleIdq.SelectedValue+"'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		private void BindDg_UserPrjGrant()
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
//			string strWhereCond = " 1=1 vUserPrjGrant.UserId='" + UserId +"'";
			//System.Data.DataTable objDT = clsUserPrjGrantBL.GetUserPrjGrantT(strWhereCond);
			System.Data.DataTable objDT = clsvUserPrjGrantBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgUserPrjGrant.PageSize);
			if (intPages==0) 
			{
				this.dgUserPrjGrant.CurrentPageIndex = 0;
			}
			else if (this.dgUserPrjGrant.CurrentPageIndex > intPages - 1) 
			{
				this.dgUserPrjGrant.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			this.dgUserPrjGrant.DataSource=objDV;
			objDV.Sort = strSortUserPrjGrantBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������

			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgUserPrjGrant.DataBind();
			//	6�����ü�¼����״̬��
			this.txtRecCount1.Text= objDT.Rows.Count.ToString();
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

		/// <summary>
		/// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
			this.dgUserPrjGrant.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_UserPrjGrant();
		}
	
		
		public System.Data.DataTable GetDepartmentId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select DepartmentId, DepartmentName from Departments ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetDepartmentId();
			objDDL.DataValueField="DepartmentId";
			objDDL.DataTextField="DepartmentName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetUserStateId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select UserStateId, UserStateName from UserState ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			ListItem li=new ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetUserStateId();
			objDDL.DataValueField="UserStateId";
			objDDL.DataTextField="UserStateName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgUserPrjGrant_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortUserPrjGrantBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgUserPrjGrant.Columns.Count;i++)
				{
					strSortEx = this.dgUserPrjGrant.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortUserPrjGrantBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortUserPrjGrantBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}

		}

		protected void dgUserPrjGrant_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngMId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngMId = long.Parse(e.Item.Cells[0].Text);
				switch(strCommandName)
				{
					case "Delete":
						clsUserPrjGrantBL.DelRecord(lngMId);
						BindDg_UserPrjGrant();
						break;
					case "Update":	//Ϊ�û������µĽ�ɫ
						SetNewRoleForUser(lngMId);
						break;

					default:
						// Do nothing.
						break;
				}
			}
		
		}
		private void SetNewRoleForUser(long lngMId)
		{
			string strNewRoleId = ddlRoleId_New.SelectedValue;
			if (strNewRoleId == "")
			{
				lblMsg2.Text = "�½�ɫ����Ϊ��!";
			}
lblMsg2.Text = "";
//��ȡ��ǰ�û�ID����ǰ����ID
			try
			{
				clsUserPrjGrantEN objUserPrjGrant = clsUserPrjGrantBL.GetObjBymId(lngMId);
				objUserPrjGrant.RoleId = strNewRoleId;
				clsUserPrjGrantBL .UpdateBySql2(objUserPrjGrant);
				BindDg_UserPrjGrant();

			}
			catch(Exception objException)
			{
				if (objException.Message.Length<30)
				{
					lblMsg2.Text = objException.Message;
				}
				else
				{
					clsCommonSession.seErrMessage = objException.Message;
					clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
					clsPubFun4Web.AccessError(this, conCurrPageName);				
				}
			}
		}
		protected void dgUserPrjGrant_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgUserPrjGrant.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_UserPrjGrant();
		}
		
		private void Get_ObjectPrjArrylist(DataGrid objDg, ArrayList objArr)
		{
			if(objArr==null || objDg.Items.Count==0)
			{
				return;//�ж�DataGrid�ļ�¼�Ƿ�Ϊ�ջ��߶��еļ�¼Ϊ�գ�
			}
			else 
			{
				objArr.Clear();//��ն���
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");//����һ��CheckBox����ȼ���
					if(cb!=null && cb.Checked)					//DataGrid�е�CheckBox
					{
						objArr.Add(di.Cells[1].Text);//���򹴵�CheckBox���ڼ�¼�Ĺؼ��ַ������
						cb.Checked = false;			//��CheckBox��ԭ
					}
				}
		
			}
		
		}
		private string GetFirstCheckedItemFromDg(DataGrid objDg)
		{
			if(objDg.Items.Count==0)
			{
				return null;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox chkCheckRec=(CheckBox)di.FindControl("ckb1");
					if(chkCheckRec!=null && chkCheckRec.Checked)
					{
						return di.Cells[1].Text;
					}
				}
			}
			return "";
		}

		protected void dgUserPrjGrant_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortUserPrjGrantBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortUserPrjGrantBy = e.SortExpression + " Asc";
				BindDg_UserPrjGrant();
				return ;
			}
			//���ԭ��������
			intIndex = strSortUserPrjGrantBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortUserPrjGrantBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortUserPrjGrantBy = e.SortExpression + " Desc";
			}
			BindDg_UserPrjGrant();

		}
		
		private string strSortUserPrjGrantBy
		{
			get
			{
				string sstrSortUserPrjGrantBy;
				sstrSortUserPrjGrantBy = (string)ViewState["strSortUserPrjGrantBy"];
				if (sstrSortUserPrjGrantBy==null) 
				{
					sstrSortUserPrjGrantBy = "";
				}
				return sstrSortUserPrjGrantBy;
			}
			set
			{
				string sstrSortUserPrjGrantBy = value;
				ViewState.Add("strSortUserPrjGrantBy", sstrSortUserPrjGrantBy);
			}
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


