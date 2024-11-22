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
using System.Text;
using CommFunc4WebForm;
using com.taishsoft.common;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;

using com.taishsoft.datetime;



namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjFunction_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPrjFunction_QUDI : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
                ///����Ӧ�����صĿؼ�����
                tabHidden.Visible = false;


                //1��Ϊ��������������Դ�����б�����
                wucPrjFunction1.SetDdl_ReturnTypeID();
                wucPrjFunction1.SetDdl_FuncTypeID();
                clsDropDownList.BindDdl_ReturnTypeID(ddlReturnTypeIDq);
                clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeIDq);
                ///��ʾ��¼�û���Ĭ�Ϲ���
                string strPrjId_Opt;
                strPrjId_Opt = Request.QueryString["PrjId_Opt"];
                if (strPrjId_Opt != null && strPrjId_Opt != "")
                {
                    PrjId_Opt = strPrjId_Opt;
                }
                else
                {
                    PrjId_Opt = "";
                }
                if (PrjId_Opt == "")
                {
                    PrjId_Opt = clsPubVar.CurrSelPrjId;
                }
                txtPrjIdq.Text = clsProjectsBL.GetPrjNameByPrjIdCache(PrjId_Opt);
                //2����ʾ�������ı�������DATAGRID��
                strSortBy = "FuncName Asc";
                BindDg_PrjFunction();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                wucPrjFunction1.SetKeyReadOnly(true);
            }
        }

        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
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
                if (pobjUser == null)
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

        private string PrjId_Opt
        {
            get
            {
                string strPrjId;
                strPrjId = (string)Session["PrjId_Opt"];
                if (strPrjId == null)
                {
                    strPrjId = "";
                    clsCommForWebForm.CheckPrjId(strPrjId, this);
                }
                return strPrjId;
            }
            set
            {
                string strPrjId = value;
                Session.Add("PrjId_Opt", strPrjId);
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
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.txtFuncIdq.Text.Trim() != "")
            {
                strWhereCond += " and FuncId='" + this.txtFuncIdq.Text.Trim() + "'";
            }
            if (this.txtFuncName.Text.Trim() != "")
            {
                strWhereCond += " and FuncName='" + this.txtFuncName.Text.Trim() + "'";
            }
            if (this.txtPrjIdq.Text.Trim() != "")
            {

                strWhereCond += " and PrjId='" + PrjId_Opt + "'";
            }
            if (this.ddlReturnTypeIDq.SelectedValue != "" && this.ddlReturnTypeIDq.SelectedValue != "0")
            {
                strWhereCond += " and ReturnTypeID='" + this.ddlReturnTypeIDq.SelectedValue + "'";
            }
            if (this.ddlFuncTypeIDq.SelectedValue != "" && this.ddlFuncTypeIDq.SelectedValue != "0")
            {
                strWhereCond += " and FuncTypeId='" + this.ddlFuncTypeIDq.SelectedValue + "'";
            }
            if (this.txtIsTemplateq.Text.Trim() != "")
            {
                strWhereCond += " and IsTemplate='" + this.txtIsTemplateq.Text.Trim() + "'";
            }
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_PrjFunction()
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
            System.Data.DataTable objDT = clsvPrjFunctionBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgPrjFunction.PageSize);
            if (intPages == 0)
            {
                this.dgPrjFunction.CurrentPageIndex = 0;
            }
            else if (this.dgPrjFunction.CurrentPageIndex > intPages - 1)
            {
                this.dgPrjFunction.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortBy;
            this.dgPrjFunction.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgPrjFunction.DataBind();
            //	6�����ü�¼����״̬��
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
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
            if (intRecCount % intPageSize != 0) intPages++;
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
            this.dgPrjFunction.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_PrjFunction();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgPrjFunction_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgPrjFunction.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_PrjFunction();
        }
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="strFuncId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(string strFuncId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (strFuncId == "") return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsPrjFunctionBL.IsExist(strFuncId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + strFuncId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN(strFuncId);
            //4����ȡ�������������ԣ�
            clsPrjFunctionBL.GetPrjFunction(ref objPrjFunctionEN);
            Session.Add("objPrjFunctionEN", objPrjFunctionEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromPrjFunctionClass(objPrjFunctionEN);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjPrjFunction">��ʵ�������</param>
        private void GetDataFromPrjFunctionClass(clsPrjFunctionEN pobjPrjFunction)
        {
            wucPrjFunction1.FuncId = pobjPrjFunction.FuncId;
            wucPrjFunction1.FuncName = pobjPrjFunction.FuncName;
            wucPrjFunction1.PrjId = pobjPrjFunction.PrjId;
            wucPrjFunction1.ReturnTypeID = pobjPrjFunction.ReturnTypeId;
            wucPrjFunction1.FuncTypeId = pobjPrjFunction.FuncTypeId;
            wucPrjFunction1.IsTemplate = pobjPrjFunction.IsTemplate;
            wucPrjFunction1.FuncCode = pobjPrjFunction.FuncCode;
            wucPrjFunction1.Memo = pobjPrjFunction.Memo;
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
            StringBuilder strCondition = new StringBuilder();
            clsPrjFunctionEN objPrjFunctionEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    wucPrjFunction1.SetKeyReadOnly(true);
                    btnOKUpd.Text = "ȷ�����";
                    wucPrjFunction1.FuncId = clsPrjFunctionBL.GetMaxStrIdByPrefix_S(PrjId_Opt);
                    wucPrjFunction1.PrjId = PrjId_Opt;
                    lblMsg.Text = "";
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
                    if (!wucPrjFunction1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsPrjFunctionEN objPrjFunctionEN;	//�������
                    objPrjFunctionEN = new clsPrjFunctionEN(wucPrjFunction1.FuncId);	//��ʼ���¶���
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    ///3.1���ж��Ƿ�����ͬ�ĺ������ƴ��ڡ�					
                    if (clsPrjFunctionBLEx.IsExistSameFunName(PrjId_Opt, wucPrjFunction1.FuncName))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "��ͬ�ĺ��������Ѿ�����!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToPrjFunctionClass(objPrjFunctionEN);		//�ѽ����ֵ����
                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsPrjFunctionBL.CheckPropertyNew(objPrjFunctionEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    if (clsPrjFunctionBL.AddNewRecordBySql2(objPrjFunctionEN) == false)
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
                    BindDg_PrjFunction();
                    wucPrjFunction1.Clear();		//��տؼ�������
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
                    if (!wucPrjFunction1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objPrjFunctionEN = (clsPrjFunctionEN)Session["objPrjFunctionEN"];
                    ///�ѵ�ǰ��¼�浽��ʷ����
                    if (clsPrjFunctionBLEx.SaveToHistory(objPrjFunctionEN, clsCommonSession. objQxUser.UserId) == false)
                    {
                        lblMsg.Text = "��ǰ��¼����ʷ���ɹ�!";
                        return;
                    };
                    PutDataToPrjFunctionClass4His(objPrjFunctionEN);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsPrjFunctionBL.CheckPropertyNew(objPrjFunctionEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsPrjFunctionBL.UpdateBySql2(objPrjFunctionEN) == false)
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
                    BindDg_PrjFunction();
                    wucPrjFunction1.Clear();//��տؼ��е�����
                    //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    break;
            }
        }

        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjPrjFunction">���ݴ����Ŀ�������</param>
        private void PutDataToPrjFunctionClass(clsPrjFunctionEN pobjPrjFunction)
        {
            pobjPrjFunction.FuncId = wucPrjFunction1.FuncId;
            pobjPrjFunction.FuncName = wucPrjFunction1.FuncName;
            pobjPrjFunction.PrjId = wucPrjFunction1.PrjId;
            pobjPrjFunction.ReturnTypeId = wucPrjFunction1.ReturnTypeID;
            pobjPrjFunction.FuncTypeId = wucPrjFunction1.FuncTypeId;
            pobjPrjFunction.IsTemplate = wucPrjFunction1.IsTemplate;
            pobjPrjFunction.FuncCode = wucPrjFunction1.FuncCode;
            pobjPrjFunction.Memo = wucPrjFunction1.Memo;
            pobjPrjFunction.UserId = clsCommonSession.objQxUser.UserId;
            pobjPrjFunction.UpdDate = clsDateTime.getTodayStr(0);
            pobjPrjFunction.UpdUser = clsCommonSession.UserId;
        }


        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjPrjFunction">���ݴ����Ŀ�������</param>
        private void PutDataToPrjFunctionClass4His(clsPrjFunctionEN pobjPrjFunction)
        {
            pobjPrjFunction.FuncId = wucPrjFunction1.FuncId;
            pobjPrjFunction.FuncName = wucPrjFunction1.FuncName;
            pobjPrjFunction.PrjId = wucPrjFunction1.PrjId;
            pobjPrjFunction.ReturnTypeId = wucPrjFunction1.ReturnTypeID;
            pobjPrjFunction.FuncTypeId = wucPrjFunction1.FuncTypeId;
            pobjPrjFunction.IsTemplate = wucPrjFunction1.IsTemplate;
            pobjPrjFunction.FuncCode = wucPrjFunction1.FuncCode;
            pobjPrjFunction.Memo = wucPrjFunction1.Memo;
            pobjPrjFunction.UpdUser = clsCommonSession.UserId;
            pobjPrjFunction.UpdDate = clsDateTime.getTodayStr(0);
        }

        protected void dgPrjFunction_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
                myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Item.ItemIndex + 1).ToString() + " ����');");
            }
            int intIndex;
            if (strSortBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgPrjFunction.Columns.Count; i++)
                {
                    strSortEx = this.dgPrjFunction.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }

        }

        protected void dgPrjFunction_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            string strFuncId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                strFuncId = e.Item.Cells[0].Text;
                switch (strCommandName)
                {
                    case "Delete":
                        lblMsg2.ForeColor = System.Drawing.Color.Black;
                        lblMsg2.Text = "";
                        if ( clsPrjFunctionBL.GetObjByFuncId(strFuncId).UserId != clsCommonSession.objQxUser.UserId)
                        {
                            lblMsg2.Text = "�ú��������㽨��������ɾ��!";
                            lblMsg2.ForeColor = System.Drawing.Color.Red;
                            return;
                        }
                        clsPrjFunctionBL.DelRecord(strFuncId);
                        BindDg_PrjFunction();
                        lblMsg2.Text = "����ID��" + clsPrjFunctionBL.GetObjByFuncId(strFuncId).FuncName + " ɾ���ɹ�!";
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        //�������裺���ܹ�2����
                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        ShowData(strFuncId);
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                        clsPubFun.SetButtonEnabled(btnOKUpd, true);
                        wucPrjFunction1.SetKeyReadOnly(true);
                        btnOKUpd.Text = "ȷ���޸�";
                        lblMsg.Text = "";
                        tabQuery.Visible = false;
                        tabEdit.Visible = true;
                        break;

                    default:
                        // Do nothing.
                        break;
                }
            }
        }
        
        protected void dgPrjFunction_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortBy = e.SortExpression + " Asc";
                BindDg_PrjFunction();
                return;
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
            BindDg_PrjFunction();
        }

        protected void lbDispFieldList_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = true;
            tabEdit.Visible = false;
        }

        protected void lbAddNewFunction_Click(object sender, System.EventArgs e)
        {
            btnOKUpd.Text = "���";
            btnOKUpd_Click(btnOKUpd, new System.EventArgs());
            
            tabQuery.Visible = false;
            tabEdit.Visible = true;
        }

        protected void dgPrjFunction_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 4;
                iNum[1] = 9;
                iNum[2] = 10;
                for (int i = 0; i < 1; i++)
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

        private string strSortBy
        {
            get
            {
                string sSortBy;
                sSortBy = (string)ViewState["SortBy"];
                if (sSortBy == null)
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