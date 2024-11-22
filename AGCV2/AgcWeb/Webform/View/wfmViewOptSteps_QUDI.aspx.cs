using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using CommFunc4WebForm;
///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
//using SqlSv; 


using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewOptSteps_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmViewOptSteps_QUDI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			string js = ""; 
			js += "<script>\r\r\n";
			js += "function ld(){\r\r\n";
			js += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n"; 
			js += "if(document.getElementsByName('RadioName')[i].value=="; 
			js += "document.getElementById('" + rd.ClientID + "').value) "; 
			js += "document.getElementsByName('RadioName')[i].checked=true\r\r\n"; 
			js += "}\r\r\n"; 
			js += "window.onload=ld\r\r\n"; 
			js += "</"+"script>\r\r\n";
			ClientScript.RegisterStartupScript(this.GetType(),"js",js); 


			// �ڴ˴������û������Գ�ʼ��ҳ��
			if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
			{
				///����Ӧ�����صĿؼ�����
				///��ʾ������ʾ��Ϣ��----------------------
				DispViewInfo(ViewId);
				///��ʾ������ʾ��Ϣ��======================
				//1��Ϊ��������������Դ�����б�����
				wucViewOptSteps1.SetDdl_ViewId(clsPubVar.CurrSelPrjId);
				//3����ʾ�������ı�������DATAGRID��
				BindDg_ViewOptSteps();
				//4�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
				//   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
				BindDg_ViewRelaTab();
			}
		}
		
		private string ViewId
		{
			get
			{
				string strViewId;
				strViewId = (string)Session["ViewId"];
				if (strViewId==null) 
				{
					strViewId = "";
				}
				return strViewId;
			}
			set
			{
				string strViewId = value;
				Session.Add("ViewId", strViewId);
			}
		}

		private void DispViewInfo(string strViewId)
		{
			//1����ʾ��������
			clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
		
			lblViewName.Text = objViewInfo.ViewName;
			//2����ʾ��������
			string strPrjId = objViewInfo.PrjId;
			clsProjectsEN objProjects = new clsProjectsEN(strPrjId);
			clsProjectsBL.GetProjects(ref objProjects);
			lblPrjName.Text = objProjects.PrjName;
			//4����ʾ���湦��
			lblViewFunction.Text = objViewInfo.ViewFunction;

		}
		
		/// <summary>
		/// �����еĲ�ѯ�ؼ�������ϳ�һ��������
		/// </summary>
		/// <returns>������(strWhereCond)</returns>
		private string CombineCondition()
		{
			//ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
			//���� 1=1 and UserName = '����'
			string strWhereCond=" 1=1 and ViewId = '" + ViewId + "'";
			//����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
			return strWhereCond;
		}
		///���ɰ�DATAGRID�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ViewOptSteps()
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
			System.Data.DataTable objDT = clsViewOptStepsBLEx.GetViewOptStepsT(strWhereCond, "StepIndex");
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewOptSteps.PageSize);
			if (intPages==0) 
			{
				this.dgViewOptSteps.CurrentPageIndex = 0;
			}
			else if (this.dgViewOptSteps.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewOptSteps.CurrentPageIndex = intPages - 1;
			}

			//	4������DATAGRID������Դ(DataSource)��
			this.dgViewOptSteps.DataSource=objDT.DefaultView;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewOptSteps.DataBind();
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
			this.dgViewOptSteps.CurrentPageIndex=0;
			//�ѱ��¼��������ʾ��DATAGRID��
			BindDg_ViewOptSteps();
		}
		/// <summary>
		/// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
		///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewOptSteps_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

//			if(Request.Form["RadioName"] != null) 
//			{ 
//				rd.Value =  Request.Form["RadioName"].ToString(); 
//			}

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewOptSteps.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewOptSteps();
		}
		/// <summary>
		/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
		///������     �������ǰ�ֵ������ؼ���
		/// </summary>
		/// <param name="lngMId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
		private void ShowData(long lngMId)
		{
			//�������裺
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			//4����ȡ�������������ԣ�
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

			//1�����ؼ����Ƿ�Ϊ�գ�
			if (lngMId == 0) return ;		//����ؼ���Ϊ�վͷ����˳�
			//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
			if (clsViewOptStepsBL.IsExist(lngMId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
			{
				string ss = "�ؼ���Ϊ��" + lngMId + "�Ĳ�����!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
			clsViewOptStepsEN objViewOptSteps = new clsViewOptStepsEN(lngMId);
            //4����ȡ�������������ԣ�
            clsViewOptStepsBL .GetViewOptSteps(ref objViewOptSteps);
			Session.Add("objViewOptSteps", objViewOptSteps);
			//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
			GetDataFromViewOptStepsClass(objViewOptSteps);
		}


		///���ɴ��߼�������ݴ��䵽�����ĺ�������
		/// <summary>
		/// �������ܣ�������������������ʾ��������
		///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
		///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
		/// </summary>
		/// <param name="pobjViewOptSteps">��ʵ�������</param>
		private void GetDataFromViewOptStepsClass(clsViewOptStepsEN pobjViewOptSteps)
		{
			wucViewOptSteps1.ViewId = pobjViewOptSteps.ViewId;
			wucViewOptSteps1.StepIndex = pobjViewOptSteps.StepIndex;
			wucViewOptSteps1.StepName = pobjViewOptSteps.StepName;
			wucViewOptSteps1.StepDetail = pobjViewOptSteps.StepDetail;
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
			clsViewOptStepsEN objViewOptSteps;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "���":
					btnOKUpd.Text = "ȷ�����";
					wucViewOptSteps1.ViewId = ViewId;
					int intStepsNum =(clsViewOptStepsBL.GetRecCountByCond("ViewId='" + ViewId + "'"));
					wucViewOptSteps1.StepIndex = intStepsNum + 1;
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
					if (!wucViewOptSteps1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2��������󲢳�ʼ������
					//clsViewOptStepsEN objViewOptSteps;	//�������
					objViewOptSteps = new clsViewOptStepsEN();	//��ʼ���¶���
					//3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
					//4����ֵ�ӽ���㴫���߼��������ʵ���
					PutDataToViewOptStepsClass(objViewOptSteps);		//�ѽ����ֵ����
					//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
				

                    try
                    {
                        clsViewOptStepsBL .CheckPropertyNew(objViewOptSteps);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6��������ʵ�������ݴ��������ݿ���
					if (clsViewOptStepsBL .AddNewRecordBySql2(objViewOptSteps) == false) 
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
					BindDg_ViewOptSteps();
					wucViewOptSteps1.Clear();		//��տؼ�������
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
					if (!wucViewOptSteps1.IsValid())
					{
						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
						return ;
					}
					//2����ֵ�ӽ���㴫���߼��������ʵ���
					objViewOptSteps = (clsViewOptStepsEN) Session["objViewOptSteps"];
					PutDataToViewOptStepsClass(objViewOptSteps);		//�ѽ����ֵ����
					//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
					

                    try
                    {
                        clsViewOptStepsBL.CheckPropertyNew(objViewOptSteps);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4��������ʵ���������޸�ͬ�������ݿ���
					if (clsViewOptStepsBL .UpdateBySql2(objViewOptSteps) == false) 
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
					BindDg_ViewOptSteps();
					wucViewOptSteps1.Clear();//��տؼ��е�����
					//�ָ�<ȷ���޸�>���<���>
					btnOKUpd.Text = "���";
					break;
			}
		}
		
		/// <summary>
		/// �������ܣ��ѽ����ϵ��������ݴ����������
		/// </summary>
		/// <param name="pobjViewOptSteps">���ݴ����Ŀ�������</param>
		private void PutDataToViewOptStepsClass(clsViewOptStepsEN pobjViewOptSteps)
		{
			pobjViewOptSteps.ViewId = wucViewOptSteps1.ViewId;
			pobjViewOptSteps.StepIndex = wucViewOptSteps1.StepIndex;
			pobjViewOptSteps.StepName = wucViewOptSteps1.StepName;
			pobjViewOptSteps.StepDetail = wucViewOptSteps1.StepDetail;
		}


		protected void dgViewOptSteps_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngMId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngMId = long.Parse(dgViewOptSteps.DataKeys[e.Item.ItemIndex].ToString());
				switch(strCommandName)
				{
					case "Delete":
						clsViewOptStepsBLEx.DelRecordEx(lngMId);
						BindDg_ViewOptSteps();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//�������裺���ܹ�2����
						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

						//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
						ShowData(lngMId);
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
		

		protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			int intStepIndex, intNextStepIndex;
			if(Request.Form["RadioName"] != null) 
			{ 
				rd.Value =  Request.Form["RadioName"].ToString(); 
				intStepIndex =int.Parse(rd.Value);
				bool bolIsSuccess = (new clsViewOptStepsBLEx().DownOrderByOne(ViewId, intStepIndex));
				if (bolIsSuccess == true)
				{
					
					intNextStepIndex = intStepIndex + 1;
					rd.Value = intNextStepIndex.ToString();

					///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
					///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��

					///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
					int intPages = CalcPages(intNextStepIndex, this.dgViewOptSteps.PageSize);
					///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��
					if (this.dgViewOptSteps.CurrentPageIndex < intPages-1 ) 
					{
						this.dgViewOptSteps.CurrentPageIndex = intPages-1;
					}
					BindDg_ViewOptSteps();
				}
			}

		}

		protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			int intStepIndex, intPrevStepIndex;
			if(Request.Form["RadioName"] != null) 
			{ 
				rd.Value =  Request.Form["RadioName"].ToString(); 
				intStepIndex =int.Parse(rd.Value);
				bool bolIsSuccess = (new clsViewOptStepsBLEx().UpOrderByOne(ViewId, intStepIndex));
				if (bolIsSuccess == true)
				{
					intPrevStepIndex = intStepIndex - 1;
					rd.Value = intPrevStepIndex.ToString();
					///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
					///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��

					///ͨ��intNextStepIndex���㵱ǰ������ҳ��P1
					int intPages = CalcPages(intPrevStepIndex, this.dgViewOptSteps.PageSize);
					///���DATAGRID�ĵ�ǰҳ��С��P1�����ӵ�ǰ��ǰҳ��
					if (this.dgViewOptSteps.CurrentPageIndex > intPages-1 ) 
					{
						this.dgViewOptSteps.CurrentPageIndex = intPages-1;
					}
					BindDg_ViewOptSteps();
				}
			}
		}

		protected void dgViewOptSteps_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��DATAGRID�С�
		/// </summary>
		private void BindDg_ViewRelaTab()
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
			string strWhereCond = " ViewId='" + ViewId + "'";
			//	2��������������ȡ�ñ�����������DataTable��
			System.Data.DataTable objDT = clsvViewRelaTabBL.GetDataTable(strWhereCond);
			//	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
			//		3.1 ���ȼ���ҳ����
			//		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewRelaTab.PageSize);
			if (intPages==0) 
			{
				this.dgViewRelaTab.CurrentPageIndex = 0;
			}
			else if (this.dgViewRelaTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewRelaTab.CurrentPageIndex = intPages - 1;
			}
			//	4������DATAGRID������Դ(DataSource)��
			DataView objDV = objDT.DefaultView;
			this.dgViewRelaTab.DataSource=objDV;
			//	5����DATAGRID������DataTable��������ʾ��DATAGRID��
			this.dgViewRelaTab.DataBind();
		}

		protected void dgViewRelaTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�������裺����2����
			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

			//1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
			this.dgViewRelaTab.CurrentPageIndex=e.NewPageIndex;
			//2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
			BindDg_ViewRelaTab();
		}

		protected void btnUpdStep_Click(object sender, System.EventArgs e)
		{
            List<string> arrLst = new List<string>();
			int intStepIndex;
			long lngIdForCurrStep;
			if(Request.Form["RadioName"] == null) 
			{ 
				return ;
			}
			rd.Value =  Request.Form["RadioName"].ToString(); 
			intStepIndex =int.Parse(rd.Value);
			//2����ȡ��ǰ��¼(���������)�Ĺؼ���(lngIdForCurrStep)��
			arrLst = clsViewOptStepsBL.GetFldValue("ViewOptSteps", "mId",  "ViewId='" + ViewId + "' and StepIndex=" + intStepIndex.ToString());
			lngIdForCurrStep =long.Parse(arrLst[0].ToString());
			ShowData(lngIdForCurrStep);
			//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "ȷ���޸�";
			lblMsg.Text = "";

		}

		protected void btnDelStep_Click(object sender, System.EventArgs e)
		{
            List<string> arrLst = new List<string>();
			int intStepIndex;
			long lngIdForCurrStep;
			if(Request.Form["RadioName"] == null) 
			{ 
				return ;
			}
			rd.Value =  Request.Form["RadioName"].ToString(); 
			intStepIndex =int.Parse(rd.Value);
			//2����ȡ��ǰ��¼(���������)�Ĺؼ���(lngIdForCurrStep)��
			arrLst = clsViewOptStepsBL.GetFldValue("ViewOptSteps", "mId",  "ViewId='" + ViewId + "' and StepIndex=" + intStepIndex.ToString());
			lngIdForCurrStep =long.Parse(arrLst[0].ToString());
			clsViewOptStepsBLEx.DelRecordEx(lngIdForCurrStep);
			BindDg_ViewOptSteps();
		}

		protected void lbReturn_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmViewSetOptStepAndFunc.aspx");
		}

	}
}