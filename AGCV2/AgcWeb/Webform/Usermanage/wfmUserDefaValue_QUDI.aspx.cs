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
using CommFunc4WebForm;
//using SqlSv; 
using com.taishsoft.commdb;

using System.Collections.Generic;

using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// wfmUserDefaValue_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmUserDefaValue_QUDI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				//1��Ϊ��������������Դ�����б�����
				wucUserDefaValue1.SetDdl_DefaValNameId();
				//2����ʾ�������ı�������DATAGRID��
				BindDg_UserDefaValue();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				Session.Add("Function","");
			}
			
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
			if (this.txtMIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserDefaValue.MId='" + this.txtMIdq.Text.Trim()+"'";
			}
			if (this.txtDefaValNameIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserDefaValue.DefaValNameId='" + this.txtDefaValNameIdq.Text.Trim()+"'";
			}
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserDefaValue.UserId='" + this.txtUserIdq.Text.Trim()+"'";
			}
			if (this.txtUserDefaValueq.Text.Trim()!="")
			{
				strWhereCond += " and UserDefaValue.UserDefaValue='" + this.txtUserDefaValueq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_UserDefaValue()
		{
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //	4������DATAGRID������Դ(DataSource)��
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //StringBuilder strSQL = new StringBuilder();
            ////	1����Ͻ�����������
            ////string strWhereCond = CombineCondition();
            ////	2��������������ȡ�ñ�����������DataTable��
            //strSQL.Append("select SysDefaValName.DefaValNameId,SysDefaValName.PrjId,SysDefaValName.DefaValName,");
            //strSQL.Append(" SysDefaValName.SysDefaValue,UserDefaValue.UserDefaValue,UserDefaValue.Memo,UserDefaValue.mId ");
            //strSQL.Append(" from SysDefaValName " );
            //strSQL.Append(" left OUTER JOIN dbo.UserDefaValue ");
            //strSQL.Append(" ON dbo.SysDefaValName.DefaValNameId = dbo.UserDefaValue.DefaValNameId ");
            //strSQL.AppendFormat(" AND dbo.UserDefaValue.UserId = '{0}'", objUser.UserId);	
            string strCondition = " 1=1 ";
			System.Data.DataTable objDT = clsUserDefaValue_LocalBL.GetDataTable(strCondition);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgUserDefaValue.PageSize);
			if (intPages==0) 
			{
				this.dgUserDefaValue.CurrentPageIndex = 0;
			}
			else if (this.dgUserDefaValue.CurrentPageIndex > intPages - 1) 
			{
				this.dgUserDefaValue.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			this.dgUserDefaValue.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgUserDefaValue.DataBind();
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
			this.dgUserDefaValue.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_UserDefaValue();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgUserDefaValue_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgUserDefaValue.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_UserDefaValue();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="lngMId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strDefaValNameId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
////			if (lngMId == 0) return ;		//����ؼ���Ϊ�վͷ����˳�
//			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
//			if (clsSysDefaValNameBL.IsExist(strDefaValNameId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
//			{
//				string ss = "�ؼ���Ϊ��" + lngMId + "�Ĳ�����!";
//				clsCommonJsFunc.Alert(this, ss);
//				return ;
//			}
//			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
//			clsSysDefaValNameEN objSysDefaValName = new clsSysDefaValNameEN(strDefaValNameId);
//			//4����ȡ�������������ԣ�
//			objSysDefaValName.GetSysDefaValName();
//			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
//			GetDataFromSysDefaValName(objSysDefaValName);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjUserDefaValue">��ʵ�������</param>
		private void GetDataFromSysDefaValName(clsSysDefaValNameEN pobjSysDefaValName)
		{
//			ArrayList arrList = new ArrayList();
//			wucUserDefaValue1.DefaValNameId = pobjSysDefaValName.DefaValNameId;
////			wucUserDefaValue1.UserId = pobjSysDefaValName.UserId;
//
//			wucUserDefaValue1.UserDefaValue = pobjUserDefaValue.UserDefaValue;
//			wucUserDefaValue1.Memo = pobjUserDefaValue.Memo;
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
			clsUserDefaValue_LocalEN objUserDefaValue;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			if(Session["Function"].ToString() =="AddNew")
			{
				strCommandText = "ȷ�����";
				Session["FuncTion"] = "";
			}
			
			switch(strCommandText)
			{
				case "���":
					btnOKUpd.Text = "ȷ�����";
					wucUserDefaValue1.UserId = clsCommonSession.objQxUser.UserId;
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
					if (!wucUserDefaValue1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsUserDefaValue_LocalEN objUserDefaValue;	//�������
					objUserDefaValue = new clsUserDefaValue_LocalEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToUserDefaValueClass(objUserDefaValue);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsUserDefaValue_LocalBL .CheckPropertyNew(objUserDefaValue);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsUserDefaValue_LocalBL .AddNewRecordBySql2(objUserDefaValue) == false) 
					{
						strMsg = "�޸Ĳ��ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�޸ļ�¼���ɹ�!";
					}
					else
					{
						strMsg = "�޸ļ�¼�ɹ�!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "�޸ļ�¼�ɹ�!";
					}
					//7��������ļ�¼������ʾ��DATAGRID��
					BindDg_UserDefaValue();
					wucUserDefaValue1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "�޸�";
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
					if (!wucUserDefaValue1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					string strCondition = " UserId = '" + clsCommonSession.objQxUser.UserId + "'"+" and DefaValNameId = '" + 
						wucUserDefaValue1.DefaValNameId + "'";

                 
                    List<string> arrList =  clsUserDefaValue_LocalBL.GetPrimaryKeyID_S(strCondition);

//					if(arrList ==null)
//					{
//						strMsg = "�޸ļ�¼���ɹ�!";
//						clsCommonJsFunc.Alert(this, strMsg);
//						lblMsg.Text = "�޸ļ�¼���ɹ�!";
//						wucUserDefaValue1.Clear();
//						btnOKUpd.Text = "��  ��";
//						return;
//					}
					long lngMId = long.Parse(arrList[0].ToString());
					objUserDefaValue= new clsUserDefaValue_LocalEN(lngMId);
					PutDataToUserDefaValueClass(objUserDefaValue);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�

                    try
                    {
                        clsUserDefaValue_LocalBL.CheckPropertyNew(objUserDefaValue);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsUserDefaValue_LocalBL .UpdateBySql2(objUserDefaValue) == false) 
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
					BindDg_UserDefaValue();
					wucUserDefaValue1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjUserDefaValue">���ݴ����Ŀ�������</param>
		private void PutDataToUserDefaValueClass(clsUserDefaValue_LocalEN pobjUserDefaValue)
		{
			pobjUserDefaValue.DefaValNameId = wucUserDefaValue1.DefaValNameId;
			pobjUserDefaValue.UserId = wucUserDefaValue1.UserId;
			pobjUserDefaValue.UserDefaValue = wucUserDefaValue1.UserDefaValue;
			pobjUserDefaValue.Memo = wucUserDefaValue1.Memo;
		}

		protected void dgUserDefaValue_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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

		protected void dgUserDefaValue_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			//long lngMId;
			string strCommandName;
			string strDefaValNameId;
            List<string> arrList = new List<string>();
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				
				strDefaValNameId = e.Item.Cells[0].Text.ToString();
				string strCondition = " UserId = '" + clsCommonSession.objQxUser.UserId+ "'"+" and DefaValNameId = '" + 
					strDefaValNameId + "'";
				switch(strCommandName)
				{
					case "Delete":
						//lngMId = long.Parse(e.Item.Cells[0].Text);
						clsUserDefaValue_LocalBL.DelUserDefaValue_LocalsByCond(strCondition);
						BindDg_UserDefaValue();
						wucUserDefaValue1.Clear();
						btnOKUpd.Text = "��  ��";
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						if(!clsUserDefaValue_LocalBL.IsExistRecord(strCondition))
						{
							//							strMsg = "�û������ֵΪ�գ������޸�!";
							//							clsCommonJsFunc.Alert(this, strMsg);
							//							return;
							Session["Function"] = "AddNew";
							//strFunction = "ȷ�����";
							wucUserDefaValue1.UserId = clsCommonSession.objQxUser.UserId;
							wucUserDefaValue1.DefaValNameId = strDefaValNameId;
							arrList = ( clsSysDefaValNameBL.GetFldValue("SysDefaValue" , " DefaValNameId = '" + strDefaValNameId + "'"));
							wucUserDefaValue1.UserDefaValue = arrList[0].ToString();
						}
						else
						{
							Session["Function"] = "UPADTE";
							wucUserDefaValue1.UserId = clsCommonSession.objQxUser.UserId;
							wucUserDefaValue1.DefaValNameId = strDefaValNameId;
							arrList = (clsUserDefaValue_LocalBL.GetFldValue("UserDefaValue" , strCondition));
							wucUserDefaValue1.UserDefaValue = arrList[0].ToString();
							arrList = (clsUserDefaValue_LocalBL.GetFldValue("Memo" , strCondition));
							wucUserDefaValue1.Memo = arrList[0].ToString();
						}
//						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
//						ShowData(strDefaValNameId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
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