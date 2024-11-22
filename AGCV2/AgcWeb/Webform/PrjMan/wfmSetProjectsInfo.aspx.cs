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
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;

using com.taishsoft.common;

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.datetime;
using System.Collections.Generic;

namespace AGC.Webform
{
	/// <summary>
	/// wfmProjects_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmSetProjectsInfo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			clsUsersEN objUsers;
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				objUsers = (clsUsersEN)Session["objUser"];
				if (objUsers == null) 
				{
					ReturnLoginView();
					return ;
				}
				if (objUsers.RoleId != "0001")	//һ���û�����ô������ʾ��ǰ�û��Ĺ���
				{
					txtUserIDq.Text = objUsers.UserId;
					txtUserIDq.ReadOnly = true;
				}
				//1��Ϊ��������������Դ�����б�����
				//2����ʾ�������ı�������DATAGRID��
				strSortBy = "PrjName Asc";
				BindDg_Projects();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucProjects1.SetKeyReadOnly(true);
				tabLayout.Visible = false;
			}
		}
		private void ReturnLoginView()
		{
			Session.Clear();
			string strMsg;
			strMsg = "�Բ������Ȩ�޲����������µ�¼!";
			clsCommonJsFunc.Alert(this, strMsg);
			string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
			//			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
			//			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
			Response.Write(ss);
		}

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
			if (this.txtPrjIdq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjId='" + this.txtPrjIdq.Text.Trim()+"'";
			}
			if (this.txtPrjNameq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjName like '%" + this.txtPrjNameq.Text.Trim()+"%'";
			}
			if (this.txtPrjDomainq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjDomain='" + this.txtPrjDomainq.Text.Trim()+"'";
			}
			if (this.txtPrjDataBaseNameq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjDataBaseName='" + this.txtPrjDataBaseNameq.Text.Trim()+"'";
			}
			if (this.txtDataBaseUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.DataBaseUserId='" + this.txtDataBaseUserIdq.Text.Trim()+"'";
			}
			if (this.txtUserIDq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.UserID='" + this.txtUserIDq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_Projects()
		{
			//�������裺(��5��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������DATAGRID������Դ(DataSource)��
			//	4����DATAGRID������DataTable��������ʾ��DATAGRID��
			//	5�����ü�¼����״̬��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

			//	1����Ͻ�����������
			string strWhereCond = CombineCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvProjectsBL.GetDataTable(strWhereCond);
			//	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgProjects.PageSize);
			if (intPages==0) 
			{
				this.dgProjects.CurrentPageIndex = 0;
			}
			else if (this.dgProjects.CurrentPageIndex > intPages - 1) 
			{
				this.dgProjects.CurrentPageIndex = intPages - 1;
			}

			
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;
			this.dgProjects.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgProjects.DataBind();
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

		/// <summary>
		/// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
			this.dgProjects.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_Projects();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgProjects_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgProjects.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_Projects();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strPrjId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strPrjId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strPrjId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsProjectsBL.IsExist(strPrjId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strPrjId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsProjectsEN objProjects = new clsProjectsEN(strPrjId);
			//4����ȡ�������������ԣ�
			clsProjectsBL.GetProjects(ref objProjects);
			Session.Add("objProjects", objProjects);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromProjectsClass(objProjects);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjProjects">��ʵ�������</param>
		private void GetDataFromProjectsClass(clsProjectsEN pobjProjects)
		{
			wucProjects1.PrjId = pobjProjects.PrjId;
			wucProjects1.PrjName = pobjProjects.PrjName;
			wucProjects1.PrjDomain = pobjProjects.PrjDomain;
            //wucProjects1.PrjDataBaseName = pobjProjects.PrjDataBaseName;
            //wucProjects1.DatabaseOwner = pobjProjects.DatabaseOwner;
            //wucProjects1.IpAddress = pobjProjects.IpAddress;
            //wucProjects1.DataBaseUserId = pobjProjects.DataBaseUserId;
            //wucProjects1.DataBasePwd = pobjProjects.DataBasePwd;
            //wucProjects1.ApplicationTypeId = pobjProjects.ApplicationTypeId;//    �޸�����
            //wucProjects1.SoftStructureId = pobjProjects.SoftStructureId;//    �û�ID
            //wucProjects1.PrjDataBaseId = pobjProjects.PrjDataBaseId;//    �û�ID
            wucProjects1.Memo = pobjProjects.Memo;
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
			clsProjectsEN objProjects;
            string strResult = "";    

			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucProjects1.SetKeyReadOnly(false);
					wucProjects1.PrjId = clsProjectsBL.GetMaxStrId_S();
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
                    
					if (!wucProjects1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsProjectsEN objProjects;	//�������
					objProjects = new clsProjectsEN(wucProjects1.PrjId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsProjectsBL.IsExist(objProjects.PrjId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToProjectsClass(objProjects);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsProjectsBL.CheckPropertyNew(objProjects);
                    }
                    catch(Exception objException)
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6��������ʵ�������ݴ��������ݿ���
					if (clsProjectsBL.AddNewRecordBySql2(objProjects) == false) 
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
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindDg_Projects();
					wucProjects1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "���";
					tabProjectsDg.Visible = true;
					tabLayout.Visible = false;
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
                    ///
                    
					if (!wucProjects1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objProjects = (clsProjectsEN) Session["objProjects"];
					PutDataToProjectsClass(objProjects);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsProjectsBL.CheckPropertyNew(objProjects);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsProjectsBL.UpdateBySql2(objProjects) == false) 
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
					}
					//5�����޸ĺ��������ʾ��DATAGRID��
					BindDg_Projects();
					wucProjects1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					tabProjectsDg.Visible = true;
					tabLayout.Visible = false;

					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjProjects">���ݴ����Ŀ�������</param>
		private void PutDataToProjectsClass(clsProjectsEN pobjProjects)
		{
			pobjProjects.PrjId = wucProjects1.PrjId;
			pobjProjects.PrjName = wucProjects1.PrjName;
			pobjProjects.PrjDomain = wucProjects1.PrjDomain;
            //pobjProjects.PrjDataBaseName = wucProjects1.PrjDataBaseName;
            //pobjProjects.DatabaseOwner = wucProjects1.DatabaseOwner;
            //pobjProjects.IpAddress = wucProjects1.IpAddress;
            //pobjProjects.DataBaseUserId = wucProjects1.DataBaseUserId;
            //if (wucProjects1.DataBasePwd.Length>0)
            //{
            //    pobjProjects.DataBasePwd = wucProjects1.DataBasePwd;
            //}
            pobjProjects.UpdDate = clsDateTime.getTodayStr(0);//    �޸�����
            pobjProjects.UserId = clsCommonSession.UserId;//    �û�ID
            //pobjProjects.ApplicationTypeId = wucProjects1.ApplicationTypeId;//    ˵��
            //pobjProjects.SoftStructureId = wucProjects1.SoftStructureId;//    ˵��
            //pobjProjects.PrjDataBaseId = wucProjects1.PrjDataBaseId;//    ˵��
            pobjProjects.Memo = wucProjects1.Memo;
		}

		protected void dgProjects_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
				for(int i=0;i<this.dgProjects.Columns.Count;i++)
				{
					strSortEx = this.dgProjects.Columns[i].SortExpression;
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

		protected void dgProjects_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strPrjId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strPrjId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsProjectsBL.DelRecord(strPrjId);
						BindDg_Projects();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strPrjId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucProjects1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						tabLayout.Visible = true;
						tabProjectsDg.Visible = false;
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}

		protected void dgProjects_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_Projects();
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
			BindDg_Projects();
		}

		protected void lbAddNewRec_Click(object sender, System.EventArgs e)
		{
			tabLayout.Visible = true;
			tabProjectsDg.Visible = false;
			btnOKUpd_Click(btnOKUpd, new System.EventArgs());
		}

		protected void lbDispPrjList_Click(object sender, System.EventArgs e)
		{
			tabProjectsDg.Visible = true;
			tabLayout.Visible = false;
		}

		protected void lbExportForTeachCircs_Click(object sender, System.EventArgs e)
		{
			
			//	1����Ͻ�����������
			string strWhereCond = CombineCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsProjectsBL.GetDataTable_Projects(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "Projects��Ϣ����.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("PrjId"); arrCnName.Add("����ID");
			arrColName.Add("PrjName"); arrCnName.Add("��������");
			arrColName.Add("PrjDomain"); arrCnName.Add("��������");
			arrColName.Add("PrjDataBaseName"); arrCnName.Add("�����ݿ�");
			arrColName.Add("IpAddress"); arrCnName.Add("������");
			arrColName.Add("DataBaseUserId"); arrCnName.Add("���ݿ���û�ID");
			arrColName.Add("DataBasePwd"); arrCnName.Add("���ݿ���û�����");
			arrColName.Add("UserId"); arrCnName.Add("�û�ID");
			arrColName.Add("UpdDate"); arrCnName.Add("�޸�ʱ��");
			arrColName.Add("Memo"); arrCnName.Add("˵��");
			arrColName.Add("DatabaseOwner"); arrCnName.Add("���ݿ�ӵ����");
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
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End();
			return true;
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

	}
}