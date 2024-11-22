///���ɲ�ѯ���޸ģ�ɾ�������Ӽ�¼�Ŀ��Ʋ����
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


using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// wfmPrjUserRole_QUDI ��ժҪ˵��������Q������ѯ��U�����޸�
	/// </summary>
	public partial class wfmPrjUserRole_QUDI : System.Web.UI.Page
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{

				//1��Ϊ��������������Դ�����б�����
				//2����ʾ�������ı�������DATAGRID��
				BindDg_UserRole();
				//3�����ñ��ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucPrjUserRole1.SetKeyReadOnly(true);
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
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "������������,
			//���� 1=1 and UserName = '����'
            string strWhereCond = "PrjId='" + clsPubVar.CurrSelPrjId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ�����������ӵ����������С�
			if (this.txtRoleIdq.Text.Trim()!="")
			{
				strWhereCond += " and RoleId='" + this.txtRoleIdq.Text.Trim()+"'";
			}
			if (this.txtRoleq.Text.Trim()!="")
			{
				strWhereCond += " and RoleName='" + this.txtRoleq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ����¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_UserRole()
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
			System.Data.DataTable objDT = clsPrjUserRoleBL.GetDataTable_PrjUserRole(strWhereCond);
			//	3������DATAGRID������Դ(DataSource)��
			this.dgUserRole.DataSource=objDT.DefaultView;
			//	4����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgUserRole.DataBind();
			//	5�����ü�¼����״̬��
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
		}

		/// <summary>
		/// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ���¼���ݵĵ�һ�������ݡ�
			this.dgUserRole.CurrentPageIndex=0;
			//�ѱ���¼��������ʾ��DATAGRID��
			BindDg_UserRole();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgUserRole_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgUserRole.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_UserRole();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ�������ؼ���
		/// </summary>
		/// <param name="strRoleId">����¼�Ĺؼ��֣���ʾ�ñ��ؼ��ֵ�����</param>
		private void ShowData(string strRoleId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ��ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strRoleId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsPrjUserRoleBL.IsExist(strRoleId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strRoleId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsPrjUserRoleEN objPrjUserRole = new clsPrjUserRoleEN(strRoleId);
            //4����ȡ�������������ԣ�
            clsPrjUserRoleBL .GetPrjUserRole(ref objPrjUserRole);
			Session.Add("objPrjUserRole", objPrjUserRole);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ��ؼ���
			GetDataFromUserRoleClass(objPrjUserRole);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjPrjUserRole">��ʵ�������</param>
		private void GetDataFromUserRoleClass(clsPrjUserRoleEN pobjPrjUserRole)
		{
			wucPrjUserRole1.RoleId = pobjPrjUserRole.RoleId;
			wucPrjUserRole1.RoleName = pobjPrjUserRole.RoleName;
			wucPrjUserRole1.Memo = pobjPrjUserRole.Memo;
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
            //string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
			string strCommandText;
			clsPrjUserRoleEN objPrjUserRole;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "����":
					wucPrjUserRole1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ������";
                    wucPrjUserRole1.RoleId = clsPrjUserRoleBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
					break;				
				case "ȷ������":
					//����һ�������Ĳ���Ĵ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					//�������裺
					//1�����ؼ����������������Ƿ���ȷ
					//2��������󲢳�ʼ������
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					//6��������ʵ�������ݴ��������ݿ���
					//7���������ļ�¼������ʾ��DATAGRID��
					//1�����ؼ����������������Ƿ���ȷ
					if (!wucPrjUserRole1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsPrjUserRoleEN objPrjUserRole;	//�������
					objPrjUserRole = new clsPrjUserRoleEN(wucPrjUserRole1.RoleId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsPrjUserRoleBL.IsExist(wucPrjUserRole1.RoleId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToUserRoleClass(objPrjUserRole);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsPrjUserRoleBL .CheckPropertyNew(objPrjUserRole);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsPrjUserRoleBL .AddNewRecordBySql2(objPrjUserRole) == false) 
					{
						strMsg = "���Ӳ��ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "���Ӽ�¼���ɹ�!";
					}
					else
					{
						strMsg = "���Ӽ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "���Ӽ�¼�ɹ�!";
					}
					//7���������ļ�¼������ʾ��DATAGRID��
					BindDg_UserRole();
					wucPrjUserRole1.Clear();		//��տؼ�������
					///�ָ�<ȷ������>���<����>
					btnOKUpd.Text = "����";
					break;
				case "ȷ���޸�":
					//����һ���������޸ĵĴ��룬�����߼���̫�򵥣�
					//�Ͱ��߼���ϲ������Ʋ�,
					//�������裺
					//1�����ؼ����������������Ƿ���ȷ
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					//4��������ʵ�������ݴ��������ݿ���
					//5�����޸ĺ��������ʾ��DATAGRID��
					//1�����ؼ����������������Ƿ���ȷ
					if (!wucPrjUserRole1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objPrjUserRole = (clsPrjUserRoleEN) Session["objPrjUserRole"];
					PutDataToUserRoleClass(objPrjUserRole);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsPrjUserRoleBL.CheckPropertyNew(objPrjUserRole);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsPrjUserRoleBL .UpdateBySql2(objPrjUserRole) == false) 
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
					BindDg_UserRole();
					wucPrjUserRole1.Clear();//���տؼ��е�����
					//�ָ�<ȷ���޸�>���<����>
					btnOKUpd.Text = "����";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjPrjUserRole">���ݴ����Ŀ�������</param>
		private void PutDataToUserRoleClass(clsPrjUserRoleEN pobjPrjUserRole)
		{
            pobjPrjUserRole.PrjId = clsPubVar.CurrSelPrjId;
			pobjPrjUserRole.RoleId = wucPrjUserRole1.RoleId;
			pobjPrjUserRole.RoleName = wucPrjUserRole1.RoleName;
			pobjPrjUserRole.Memo = wucPrjUserRole1.Memo;
		}

		protected void dgUserRole_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex+1).ToString() + " ����');");
			}
		}

		protected void dgUserRole_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strRoleId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strRoleId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsPrjUserRoleBL.DelRecord(strRoleId);
						BindDg_UserRole();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strRoleId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucPrjUserRole1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		

	}
}