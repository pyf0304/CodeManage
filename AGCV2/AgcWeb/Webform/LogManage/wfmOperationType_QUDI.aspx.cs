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
using com.taishsoft.commdb;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;


using com.taishsoft.common;

namespace AGC
{
	/// <summary>
	/// wfmOperationType_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmOperationType_QUDI : CommWebPageBase
    {

		

		//�����йصı����������
		private const string ViewId4Potence="00260203";		//������


		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{

				//����Ȩ���й��ж�Ȩ�޵Ĵ���
				//���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô���ܣ��ȼ���ŷ�ʽ��1Ϊ���2��Σ���������
				switch (strPotenceLevel)
				{
					case "0":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "1":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "2":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "3":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "4":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "9":
						break;
					default:
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
				}

				//1��Ϊ��������������Դ�����б�����
				strSortOperationTypeBy = "OpTypeId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_OperationType();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucOperationType1.SetKeyReadOnly(true);
			}
		}

		//����Ȩ�޵ȼ�������
		private string  strPotenceLevel
		{
			get
			{
				string sPotenceLevel;
				sPotenceLevel = (string)ViewState["PotenceLevel"];
				if (sPotenceLevel==null) 
				{
					//					sPotenceLevel=new TzGeneralPlatformDll.MenuAndPotence(clsSysParaEN.ConfigFileName).Get_PotenceLevel(ViewId4Potence);
					sPotenceLevel = "9";
					ViewState.Add("PotenceLevel", sPotenceLevel);
				}
				return sPotenceLevel;
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
		///private clsUsersEN objUserBak
		///{
		///get
		///{
		///clsUsersEN pobjUser;
		///pobjUser = (clsUsersEN)Session["objUser"];
		///if (pobjUser==null) 
		///{
		///pobjUser = null;
		///}
		///return pobjUser;
		///}
		///set
		///{
		///clsUsersEN pobjUser = value;
		///Session.Add("objUser", pobjUser);
		///}
		///}


		

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineOperationTypeCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtOperationTypeq.Text.Trim()!="")
			{
				strWhereCond += " And OperationType.OptTypeId like '%" + this.txtOperationTypeq.Text.Trim()+"%'";
			}
			if (this.txtOperationTypeNameq.Text.Trim()!="")
			{
				strWhereCond += " And OperationType.OptTypeName like '%" + this.txtOperationTypeNameq.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_OperationType()
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
			string strWhereCond = CombineOperationTypeCondition();
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsOperationTypeBL.GetDataTable_OperationType(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgOperationType.PageSize);
			if (intPages==0) 
			{
				this.dgOperationType.CurrentPageIndex = 0;
			}
			else if (this.dgOperationType.CurrentPageIndex > intPages - 1) 
			{
				this.dgOperationType.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortOperationTypeBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgOperationType.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgOperationType.DataBind();

			
			//��ǰ��¼��
			this.lblOperationTypeRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblOperationTypeAllPages.Text = this.dgOperationType.PageCount.ToString(); 
			//��ǰҳ����
			this.lblOperationTypeCurrentPage.Text=(this.dgOperationType.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtOperationTypeJump2Page.Text=(this.dgOperationType.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgOperationType.CurrentPageIndex==0) 
			{
				btnOperationTypePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnOperationTypePrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgOperationType.CurrentPageIndex==this.dgOperationType.PageCount-1) 
			{ 
				btnOperationTypeNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnOperationTypeNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabOperationTypeJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabOperationTypeJumpPage.Visible = false; 
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

		/// <summary>
		/// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
			//��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
			this.dgOperationType.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_OperationType();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgOperationType_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgOperationType.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_OperationType();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strOperationType">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strOperationType)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strOperationType == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsOperationTypeBL.IsExist(strOperationType) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strOperationType + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsOperationTypeEN objOperationType = new clsOperationTypeEN(strOperationType);
            //4����ȡ�������������ԣ�
            clsOperationTypeBL .GetOperationType(ref objOperationType);
			Session.Add("objOperationType", objOperationType);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromOperationTypeClass(objOperationType);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjOperationType">��ʵ�������</param>
		private void GetDataFromOperationTypeClass(clsOperationTypeEN pobjOperationType)
		{
			wucOperationType1.OpTypeId = pobjOperationType.OpTypeId;
			wucOperationType1.OpTypeName = pobjOperationType.OpTypeName;
			wucOperationType1.Memo = pobjOperationType.Memo;
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
			string strResult=" ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
			string strCommandText;
			clsOperationTypeEN objOperationType;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucOperationType1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
					wucOperationType1.OpTypeId = clsOperationTypeBL.GetMaxStrId_S();
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
					if (!wucOperationType1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsOperationTypeEN objOperationType;	//�������
					objOperationType = new clsOperationTypeEN(wucOperationType1.OpTypeId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					if (clsOperationTypeBL.IsExist(wucOperationType1.OpTypeId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToOperationTypeClass(objOperationType);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�

                    try
                    {
                        clsOperationTypeBL .CheckPropertyNew(objOperationType);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsOperationTypeBL .AddNewRecordBySql2(objOperationType) == false) 
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
					BindDg_OperationType();
					wucOperationType1.Clear();		//��տؼ�������
					///�ָ�<ȷ�����>���<���>
					btnOKUpd.Text = "���";
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
					if (!wucOperationType1.IsValid(ref strResult))
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objOperationType = (clsOperationTypeEN) Session["objOperationType"];
					PutDataToOperationTypeClass(objOperationType);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsOperationTypeBL.CheckPropertyNew(objOperationType);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsOperationTypeBL .UpdateBySql2(objOperationType) == false) 
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
					BindDg_OperationType();
					wucOperationType1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjOperationType">���ݴ����Ŀ�������</param>
		private void PutDataToOperationTypeClass(clsOperationTypeEN pobjOperationType)
		{
			pobjOperationType.OpTypeId = wucOperationType1.OpTypeId;
			pobjOperationType.OpTypeName = wucOperationType1.OpTypeName;
			pobjOperationType.Memo = wucOperationType1.Memo;
		}

		protected void dgOperationType_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortOperationTypeBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
			{
				string strSortEx;
				for(int i=0;i<this.dgOperationType.Columns.Count;i++)
				{
					strSortEx = this.dgOperationType.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortOperationTypeBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
						intIndex = strSortOperationTypeBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
						e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
						break;
					}
				}
			}
		}

		protected void dgOperationType_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strOperationType;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strOperationType = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsOperationTypeBL.DelRecord(strOperationType);
						BindDg_OperationType();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strOperationType);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucOperationType1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		
		protected void dgOperationType_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortOperationTypeBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortOperationTypeBy = e.SortExpression + " Asc";
				BindDg_OperationType();
				return ;
			}
			//���ԭ��������
			intIndex = strSortOperationTypeBy.IndexOf(" Asc");
			if (intIndex == -1)		//���ԭ���������������Ϊ����
			{
				strSortOperationTypeBy = e.SortExpression + " Asc";
			}
			else			///��������Ϊ����
			{
				strSortOperationTypeBy = e.SortExpression + " Desc";
			}
			BindDg_OperationType();
		}

		private string strSortOperationTypeBy
		{
			get
			{
				string sSortOperationTypeBy;
				sSortOperationTypeBy = (string)ViewState["SortOperationTypeBy"];
				if (sSortOperationTypeBy==null) 
				{
					sSortOperationTypeBy = "";
				}
				return sSortOperationTypeBy;
			}
			set
			{
				string sSortOperationTypeBy = value;
				ViewState.Add("SortOperationTypeBy", sSortOperationTypeBy);
			}
		}

		//���ɸ������SESSION������Ժ���
		protected void btnOperationTypePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgOperationType.CurrentPageIndex -=1; 
			this.BindDg_OperationType(); 
		}

		protected void btnOperationTypeNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgOperationType.CurrentPageIndex +=1; 
			this.BindDg_OperationType(); 
		}

		protected void btnOperationTypeJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtOperationTypeJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtOperationTypeJump2Page.Text)>0 && 
				int.Parse(this.txtOperationTypeJump2Page.Text)-1<this.dgOperationType.PageCount) 
			{ 
				this.dgOperationType.CurrentPageIndex=int.Parse(this.txtOperationTypeJump2Page.Text)-1; 
			} 
			this.BindDg_OperationType();
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