
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
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

//using CommFunc4WebForm;
namespace AGC.Webform
{
	/// <summary>
	/// wfmDataTypeAbbr_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
	/// </summary>
	public partial class wfmDataTypeAbbr_QUDI : System.Web.UI.Page
	{

		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				//1��Ϊ��������������Դ�����б�����
				strSortBy = "DataTypeId Asc";
				//2����ʾ�������ı�������DATAGRID��
				BindDg_DataTypeAbbr();
				//3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				wucDataTypeAbbr1.SetKeyReadOnly(true);
			}
		}

		

		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 && UserName = '����'
			string strWhereCond=" 1=1 ";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			if (this.txtDataTypeIdq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.DataTypeId='" + this.txtDataTypeIdq.Text.Trim()+"'";
			}
			if (this.txtDataTypeNameq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.DataTypeName='" + this.txtDataTypeNameq.Text.Trim()+"'";
			}
			if (this.txtDataCnNameq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.DataCnName='" + this.txtDataCnNameq.Text.Trim()+"'";
			}
			if (this.txtDataTypeAbbrq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.DataTypeAbbr='" + this.txtDataTypeAbbrq.Text.Trim()+"'";
			}
			if (this.txtNetSysTypeq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.NetSysType='" + this.txtNetSysTypeq.Text.Trim()+"'";
			}
			if (this.txtVbNetTypeq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.VbNetType='" + this.txtVbNetTypeq.Text.Trim()+"'";
			}
			if (this.txtCsTypeq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.CsType='" + this.txtCsTypeq.Text.Trim()+"'";
			}
			if (this.txtJavaTypeq.Text.Trim()!="")
			{
				strWhereCond += " And DataTypeAbbr.JavaType='" + this.txtJavaTypeq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_DataTypeAbbr()
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
            System.Data.DataTable objDT = clsDataTypeAbbrBL.GetDataTable_DataTypeAbbr(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgDataTypeAbbr.PageSize);
			if (intPages==0) 
			{
				this.dgDataTypeAbbr.CurrentPageIndex = 0;
			}
			else if (this.dgDataTypeAbbr.CurrentPageIndex > intPages - 1) 
			{
				this.dgDataTypeAbbr.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
			this.dgDataTypeAbbr.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgDataTypeAbbr.DataBind();

			
			//��ǰ��¼��
			this.lblDataTypeAbbrRecCount.Text = objDT.Rows.Count.ToString(); 
			//��ǰҳ��
			this.lblDataTypeAbbrAllPages.Text = this.dgDataTypeAbbr.PageCount.ToString(); 
			//��ǰҳ����
			this.lblDataTypeAbbrCurrentPage.Text=(this.dgDataTypeAbbr.CurrentPageIndex+1).ToString();
			//��ǰ����������ҳ����
			this.txtDataTypeAbbrJump2Page.Text=(this.dgDataTypeAbbr.CurrentPageIndex+1).ToString();
			//�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
			if(this.dgDataTypeAbbr.CurrentPageIndex==0) 
			{
				btnDataTypeAbbrPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnDataTypeAbbrPrevPage.Enabled=true; 
			} 
			//�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
			if(this.dgDataTypeAbbr.CurrentPageIndex==this.dgDataTypeAbbr.PageCount-1) 
			{ 
				btnDataTypeAbbrNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnDataTypeAbbrNextPage.Enabled=true; 
			} 
			//7�������沿����ʾ����ʾ �������ǰDataGrid�еļ�¼��Ϊ0������ʾ��ǰ����ҳ������
			if(objDT.Rows.Count>0) 
			{ 
				this.tabDataTypeAbbrJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabDataTypeAbbrJumpPage.Visible = false; 
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
			this.dgDataTypeAbbr.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_DataTypeAbbr();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgDataTypeAbbr_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgDataTypeAbbr.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_DataTypeAbbr();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="strDataTypeId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(string strDataTypeId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (strDataTypeId == "") return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsDataTypeAbbrBL.IsExist(strDataTypeId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + strDataTypeId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId(strDataTypeId);
			//4����ȡ�������������ԣ�
            //clsDataTypeAbbrBL.GetDataTypeAbbr();
			Session.Add("objDataTypeAbbrEN", objDataTypeAbbrEN);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromDataTypeAbbrClass(objDataTypeAbbrEN);
		}
		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjDataTypeAbbr">��ʵ�������</param>
		private void GetDataFromDataTypeAbbrClass(clsDataTypeAbbrEN pobjDataTypeAbbr)
		{
			wucDataTypeAbbr1.DataTypeId = pobjDataTypeAbbr.DataTypeId;
			wucDataTypeAbbr1.DataTypeName = pobjDataTypeAbbr.DataTypeName;
			wucDataTypeAbbr1.DataCnName = pobjDataTypeAbbr.DataCnName;
			wucDataTypeAbbr1.DataTypeAbbr = pobjDataTypeAbbr.DataTypeAbbr;
			wucDataTypeAbbr1.NetSysType = pobjDataTypeAbbr.NetSysType;
			wucDataTypeAbbr1.VbNetType = pobjDataTypeAbbr.VbNetType;
			wucDataTypeAbbr1.CsType = pobjDataTypeAbbr.CsType;
            wucDataTypeAbbr1.JavaType = pobjDataTypeAbbr.JavaType;
            wucDataTypeAbbr1.OraDbType = pobjDataTypeAbbr.OraDbType;
            wucDataTypeAbbr1.SqlParaType = pobjDataTypeAbbr.SqlParaType;
            wucDataTypeAbbr1.IsNeedQuote = pobjDataTypeAbbr.IsNeedQuote;
			wucDataTypeAbbr1.Memo = pobjDataTypeAbbr.Memo;
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
			clsDataTypeAbbrEN objDataTypeAbbrEN;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					wucDataTypeAbbr1.SetKeyReadOnly(false);
					btnOKUpd.Text = "ȷ�����";
                    //wucDataTypeAbbr1.DataTypeId = clsDataTypeAbbr.GetMaxStrId("DataTypeAbbr","DataTypeId", 2, "");
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
					if (!wucDataTypeAbbr1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsDataTypeAbbrEN objDataTypeAbbrEN;	//�������
					objDataTypeAbbrEN = new clsDataTypeAbbrEN(wucDataTypeAbbr1.DataTypeId);	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsDataTypeAbbrBL.IsExist(objDataTypeAbbrEN.DataTypeId))	//�ж��Ƿ�����ͬ�Ĺؼ���
					{
						strMsg = "�ؼ����ֶ�������ͬ��ֵ";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToDataTypeAbbrClass(objDataTypeAbbrEN);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDataTypeAbbrBL.CheckPropertyNew(objDataTypeAbbrEN);
                    }
                    catch(Exception objException)
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6��������ʵ�������ݴ��������ݿ���
                    if (clsDataTypeAbbrBL.AddNewRecordBySql2(objDataTypeAbbrEN) == false) 
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
					BindDg_DataTypeAbbr();
					wucDataTypeAbbr1.Clear();		//��տؼ�������
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
					if (!wucDataTypeAbbr1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objDataTypeAbbrEN = (clsDataTypeAbbrEN) Session["objDataTypeAbbrEN"];
					PutDataToDataTypeAbbrClass(objDataTypeAbbrEN);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsDataTypeAbbrBL.CheckPropertyNew(objDataTypeAbbrEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsDataTypeAbbrBL.UpdateBySql2(objDataTypeAbbrEN) == false) 
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
					BindDg_DataTypeAbbr();
					wucDataTypeAbbr1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjDataTypeAbbr">���ݴ����Ŀ�������</param>
		private void PutDataToDataTypeAbbrClass(clsDataTypeAbbrEN pobjDataTypeAbbr)
		{
			pobjDataTypeAbbr.DataTypeId = wucDataTypeAbbr1.DataTypeId;
			pobjDataTypeAbbr.DataTypeName = wucDataTypeAbbr1.DataTypeName;
			pobjDataTypeAbbr.DataCnName = wucDataTypeAbbr1.DataCnName;
			pobjDataTypeAbbr.DataTypeAbbr = wucDataTypeAbbr1.DataTypeAbbr;
			pobjDataTypeAbbr.NetSysType = wucDataTypeAbbr1.NetSysType;
			pobjDataTypeAbbr.VbNetType = wucDataTypeAbbr1.VbNetType;
			pobjDataTypeAbbr.CsType = wucDataTypeAbbr1.CsType;
            pobjDataTypeAbbr.JavaType = wucDataTypeAbbr1.JavaType;
            pobjDataTypeAbbr.OraDbType = wucDataTypeAbbr1.OraDbType;
            pobjDataTypeAbbr.SqlParaType = wucDataTypeAbbr1.SqlParaType;
            pobjDataTypeAbbr.IsNeedQuote = wucDataTypeAbbr1.IsNeedQuote;
			pobjDataTypeAbbr.Memo = wucDataTypeAbbr1.Memo;
		}

		protected void dgDataTypeAbbr_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
				for(int i=0;i<this.dgDataTypeAbbr.Columns.Count;i++)
				{
					strSortEx = this.dgDataTypeAbbr.Columns[i].SortExpression;
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

		protected void dgDataTypeAbbr_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strDataTypeId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strDataTypeId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsDataTypeAbbrBL.DelRecord(strDataTypeId);
						BindDg_DataTypeAbbr();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(strDataTypeId);
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucDataTypeAbbr1.SetKeyReadOnly(true);
						btnOKUpd.Text = "ȷ���޸�";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		
		protected void dgDataTypeAbbr_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//�ж��Ƿ����µ������ֶ�
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_DataTypeAbbr();
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
			BindDg_DataTypeAbbr();
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

		//���ɸ������SESSION������Ժ���
		protected void btnDataTypeAbbrPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgDataTypeAbbr.CurrentPageIndex -=1; 
			this.BindDg_DataTypeAbbr(); 
		}

		protected void btnDataTypeAbbrNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgDataTypeAbbr.CurrentPageIndex +=1; 
			this.BindDg_DataTypeAbbr(); 
		}

		protected void btnDataTypeAbbrJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtDataTypeAbbrJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtDataTypeAbbrJump2Page.Text)>0 && 
				int.Parse(this.txtDataTypeAbbrJump2Page.Text)-1<this.dgDataTypeAbbr.PageCount) 
			{ 
				this.dgDataTypeAbbr.CurrentPageIndex=int.Parse(this.txtDataTypeAbbrJump2Page.Text)-1; 
			} 
			this.BindDg_DataTypeAbbr();
		}

		protected void dgDataTypeAbbr_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 10;
				iNum[1] = 7;
				for (int i = 0; i<1; i++)
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
	}
}