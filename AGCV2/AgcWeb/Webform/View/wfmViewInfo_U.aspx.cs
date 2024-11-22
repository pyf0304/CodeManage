///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using com.taishsoft.common;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;
using AGC.Entity;



namespace AGC.Webform
{
    /// <summary>
    /// wfmViewInfo_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmViewInfo_U : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            //            this.RegisterStartupScript("js", js); 
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {

                //1��Ϊ��������������Դ�����б�����
                wucViewInfo1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                wucViewInfo1.SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_DetailTabId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_PrjId();
                wucViewInfo1.SetDdl_ApplicationTypeId();
                //				wucViewInfo1.SetDdl_ViewTypeCode();
                wucViewInfo1.SetDdl_ViewGroupId(clsPubVar.CurrSelPrjId);
                wucViewInfo1.SetDdl_InSqlDsTypeId();
                wucViewInfo1.SetDdl_OutSqlDsTypeId();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                wucViewInfo1.SetKeyReadOnly(true);
                //if (clsPubVar.objCurrSelProject.ApplicationTypeId != 3)
                //{
                //    wucViewInfo1.HideViewGroup();
                //}
                //�༭��������
                UpdateViewInfo();

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


        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
            }
        }

        private string ViewTypeCode
        {
            get
            {
                string intViewTypeCode;
                intViewTypeCode = (string)Session["ViewTypeCode"];
                if (intViewTypeCode == null)
                {
                    intViewTypeCode = "";
                }
                return intViewTypeCode;
            }
            set
            {
                string intViewTypeCode = value;
                Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        private string ViewName
        {
            get
            {
                string strViewName;
                strViewName = (string)Session["ViewName"];
                if (strViewName == null)
                {
                    strViewName = "";
                }
                return strViewName;
            }
            set
            {
                string strViewName = value;
                Session.Add("ViewName", strViewName);
            }
        }
        private void UpdateViewInfo()
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            string strViewId = getViewId;

            if (string.IsNullOrEmpty( strViewId) == true)
            {
                lblMsg.Text = "û��ѡ����棬��ѡ��һ����Ч�Ľ����¼!";
                return;
            }
            clsCommonSession.ViewId = strViewId;
            lblMsg.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(strViewId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucViewInfo1.SetKeyReadOnly(true);
            btnOKUpd.Text = "ȷ���޸�";
            lblMsg.Text = "";
        }

        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="strViewId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(string strViewId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (strViewId == "") return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsViewInfoBL.IsExist(strViewId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + strViewId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsViewInfoEN objViewInfo = new clsViewInfoEN(strViewId);
            //4����ȡ�������������ԣ�
            clsViewInfoBL.GetViewInfo(ref objViewInfo);
            Session.Add("objViewInfo", objViewInfo);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromViewInfoClass(objViewInfo);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjViewInfo">��ʵ�������</param>
        private void GetDataFromViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            wucViewInfo1.ViewId = pobjViewInfo.ViewId;
            wucViewInfo1.ViewName = pobjViewInfo.ViewName;
            wucViewInfo1.ViewCnName = pobjViewInfo.ViewCnName;
            wucViewInfo1.FileName = pobjViewInfo.FileName;
            wucViewInfo1.FilePath = pobjViewInfo.FilePath;
            wucViewInfo1.DefaMenuName = pobjViewInfo.DefaMenuName;
            wucViewInfo1.ApplicationTypeId = pobjViewInfo.ApplicationTypeId;
            wucViewInfo1.ViewGroupId = pobjViewInfo.ViewGroupId;

            wucViewInfo1.FuncModuleAgcId = pobjViewInfo.FuncModuleAgcId;

            wucViewInfo1.DataBaseName = pobjViewInfo.DataBaseName;
            wucViewInfo1.MainTabId = pobjViewInfo.MainTabId;
            wucViewInfo1.DetailTabId = pobjViewInfo.DetailTabId;
            wucViewInfo1.KeyForMainTab = pobjViewInfo.KeyForMainTab;
            wucViewInfo1.KeyForDetailTab = pobjViewInfo.KeyForDetailTab;
            wucViewInfo1.IsNeedSort = pobjViewInfo.IsNeedSort;
            wucViewInfo1.IsNeedTransCode = pobjViewInfo.IsNeedTransCode;
            wucViewInfo1.UserId = pobjViewInfo.UserId;
            wucViewInfo1.PrjId = pobjViewInfo.PrjId;
            wucViewInfo1.ViewFunction = pobjViewInfo.ViewFunction;
            wucViewInfo1.ViewDetail = pobjViewInfo.ViewDetail;
            wucViewInfo1.InSqlDsTypeId = pobjViewInfo.InSqlDsTypeId;
            wucViewInfo1.InRelaTabId = pobjViewInfo.InRelaTabId;
            wucViewInfo1.OutSqlDsTypeId = pobjViewInfo.OutSqlDsTypeId;
            wucViewInfo1.OutRelaTabId = pobjViewInfo.OutRelaTabId;
            wucViewInfo1.IsNeedSetExportFld = pobjViewInfo.IsNeedSetExportFld;
            wucViewInfo1.KeyId4Test = pobjViewInfo.KeyId4Test;
            wucViewInfo1.ViewMasterId = pobjViewInfo.ViewMasterId;


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
            clsViewInfoEN objViewInfo;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    wucViewInfo1.SetKeyReadOnly(false);
                    btnOKUpd.Text = "ȷ�����";
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucViewInfo1.UserId = clsCommonSession.UserId;
                    wucViewInfo1.PrjId = clsPubVar.CurrSelPrjId;
                    wucViewInfo1.FilePath = "webform/";
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
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsViewInfoEN objViewInfo;	//�������
                    wucViewInfo1.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);

                    objViewInfo = new clsViewInfoEN(wucViewInfo1.ViewId);	//��ʼ���¶���
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsViewInfoBL .IsExist(objViewInfo.ViewId))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //����ڵ�ǰ�������Ƿ���ͬ����������
                    if (clsViewInfoBL.IsExistRecord("PrjId = '" + clsPubVar.CurrSelPrjId + "' and ViewName = '" + wucViewInfo1.ViewName + "'"))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "����Ŀ���Ѵ���ͬ���Ľ�������!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToViewInfoClass(objViewInfo);		//�ѽ����ֵ����

                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�

                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    try
                    {
                        if (clsViewInfoBL .AddNewRecordBySql2(objViewInfo) == false)
                        {
                            strMsg = "��Ӳ��ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "��Ӽ�¼���ɹ�!";
                        }
                        else
                        {
                            //���Ĭ�ϵĽ���ģʽ
                            clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                            strMsg = "��Ӽ�¼�ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "��Ӽ�¼�ɹ�!";
                        }
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

                    //7��������ļ�¼������ʾ��DATAGRID��
                    wucViewInfo1.Clear();		//��տؼ�������
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
                    if (!wucViewInfo1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objViewInfo = (clsViewInfoEN)Session["objViewInfo"];
                    //����ڵ�ǰ�������Ƿ���ͬ����������
                    StringBuilder sbCondition = new StringBuilder();
                    sbCondition.AppendFormat("PrjId = '{0}'", clsPubVar.CurrSelPrjId);
                    sbCondition.AppendFormat(" and ViewName = '{0}'", wucViewInfo1.ViewName);
                    sbCondition.AppendFormat(" and {0} = {1}", conViewInfo.ApplicationTypeId,  wucViewInfo1.ApplicationTypeId);
                    sbCondition.AppendFormat(" and ViewId <> '{0}'", wucViewInfo1.ViewId);

                    if (clsViewInfoBL.IsExistRecord(sbCondition.ToString()))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "����Ŀ���Ѵ���ͬ���Ľ�������!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }

                    PutDataToViewInfoClass(objViewInfo);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                        clsViewInfoBL .CheckPropertyNew(objViewInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsViewInfoBL.UpdateBySql2(objViewInfo) == false)
                    {
                        strMsg = "�޸ļ�¼���ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�޸ļ�¼���ɹ�!";
                    }
                    else
                    {
                        //���Ĭ�ϵĽ���ģʽ
                        clsViewInfoBLEx.AddDefaultViewStyle(clsPubVar.CurrSelPrjId, objViewInfo.ViewId);
                        strMsg = "�޸ļ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�޸ļ�¼�ɹ�!";
                    }
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    wucViewInfo1.Clear();//��տؼ��е�����
                    //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    break;

            }
        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjViewInfo">���ݴ����Ŀ�������</param>
        private void PutDataToViewInfoClass(clsViewInfoEN pobjViewInfo)
        {
            pobjViewInfo.ViewId = wucViewInfo1.ViewId;
            pobjViewInfo.ViewName = wucViewInfo1.ViewName;
            pobjViewInfo.ViewCnName = wucViewInfo1.ViewCnName;
            pobjViewInfo.FileName = wucViewInfo1.FileName;
            pobjViewInfo.FilePath = wucViewInfo1.FilePath;
            pobjViewInfo.DefaMenuName = wucViewInfo1.DefaMenuName;
            pobjViewInfo.ApplicationTypeId = wucViewInfo1.ApplicationTypeId;
            pobjViewInfo.ViewGroupId = wucViewInfo1.ViewGroupId;
            pobjViewInfo.FuncModuleAgcId = wucViewInfo1.FuncModuleAgcId;
            pobjViewInfo.DataBaseName = wucViewInfo1.DataBaseName;
            pobjViewInfo.MainTabId = wucViewInfo1.MainTabId;
            pobjViewInfo.DetailTabId = wucViewInfo1.DetailTabId;
            pobjViewInfo.KeyForMainTab = wucViewInfo1.KeyForMainTab;
            pobjViewInfo.KeyForDetailTab = wucViewInfo1.KeyForDetailTab;
            pobjViewInfo.IsNeedSort = wucViewInfo1.IsNeedSort;
            pobjViewInfo.IsNeedTransCode = wucViewInfo1.IsNeedTransCode;
            pobjViewInfo.UserId = wucViewInfo1.UserId;
            pobjViewInfo.PrjId = wucViewInfo1.PrjId;
            pobjViewInfo.ViewFunction = wucViewInfo1.ViewFunction;
            pobjViewInfo.ViewDetail = wucViewInfo1.ViewDetail;
            pobjViewInfo.InRelaTabId = wucViewInfo1.InRelaTabId;
            pobjViewInfo.InSqlDsTypeId = wucViewInfo1.InSqlDsTypeId;
            pobjViewInfo.OutSqlDsTypeId = wucViewInfo1.OutSqlDsTypeId;
            pobjViewInfo.OutRelaTabId = wucViewInfo1.OutRelaTabId;
            pobjViewInfo.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            pobjViewInfo.UpdUserId = clsCommonSession.UserId;
            pobjViewInfo.IsNeedSetExportFld = wucViewInfo1.IsNeedSetExportFld;
            pobjViewInfo.KeyId4Test = wucViewInfo1.KeyId4Test;
            pobjViewInfo.ViewMasterId = wucViewInfo1.ViewMasterId;

        }



        public System.Data.DataTable GetViewTypeCode()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetViewTypeCode();
            objDDL.DataValueField = "ViewTypeCode";
            objDDL.DataTextField = "ViewTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 11;
                iNum[1] = 12;
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


        //��������洫����ViewId
        private string qsViewId
        {
            get
            {
                string strViewId = Request.QueryString["ViewId"] ?? "".ToString();
                if ((strViewId != null) && (strViewId != ""))
                {
                    return strViewId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }


        /// <summary>
        /// ���ݴ��ݲ�����ѡ����������Ŀγ�Id
        /// ���ܣ����ѡ�������Ϊ�գ��ͷ���ѡ������γ�Id��
        ///       ����ͷ��ش��ݲ����γ�Id
        /// </summary>
        protected string getViewId
        {
            get
            {
                if (string.IsNullOrEmpty(qsViewId) == false) return qsViewId;
                if (string.IsNullOrEmpty(clsCommonSession.ViewId4get) == false) return clsCommonSession.ViewId4get;
        
                return "";
            }
            //set
            //{
            //    clsCommonSession.ViewId4get = value;
            //}
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