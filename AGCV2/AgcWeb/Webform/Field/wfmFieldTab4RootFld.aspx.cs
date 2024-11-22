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
using com.taishsoft.common;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;

using com.taishsoft.datetime;



//public class ObjStruct
//{
//    public string strObjId;
//    public string strObjName;
//}

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmFieldTab4RootFld : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
                lbDelFld.Attributes.Add("onclick", "return confirm('�����Ҫɾ����ѡ�ļ�¼��');");
                //1��Ϊ��������������Դ�����б�����
                wucFieldTab1.SetDdl_PrjId();
                wucFieldTab1.SetDdl_FldType();
                wucFieldTab1.SetDdl_IsNull();
                //				wucFieldTab1.SetDdl_IsPrimaryKey();
                wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);
                wucFieldTab1.SetDdl_CodeTab();
                wucFieldTab1.SetDdl_FldStateId();

                //clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
                BindDdl_IsNull(ddlIsNullq);
                BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);
                clsDropDownList.BindDdl_TrueAndFalse(ddlIsRootFld);
                //ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;

                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldType);
                BindDdl_IsNull(ddlIsNull);
                BindDdl_IsPrimaryKey(ddlIsPrimaryKey);
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);
                //				clsDropDownList.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                clsFieldTabBLEx.BindDdl_FldID4RootEx(ddlFldId4Root, clsPubVar.CurrSelPrjId);
                ddlFldStateIdq.SelectedValue = "01";

                vsSortFieldTabBy = "FldName Asc";
                //2����ʾ�������ı�������DATAGRID��
                BindGv_vFieldTab4RootFld();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                wucFieldTab1.SetKeyReadOnly(true);
                tabLayout.Visible = false;
                txtFldLength.Text = "0";
                HideAdvanceQuery();

                if (clsCommonSession.RoleId == "00050001" || clsCommonSession.RoleId == "00050006")
                {
                    lbDelFieldTabEx.Visible = true;
                }
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
        //        if (strPrjId == null)
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
        ///����ר�����ڼ�¼GridView�е�ÿҳ��¼��
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
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
        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombinevFieldTab4RootFldCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = string.Format(" 1=1 And PrjId='{0}'", clsPubVar.CurrSelPrjId);
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�

            if (this.txtFldNameq.Text.Trim() != "")
            {
                strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim() + "%'";
            }
            if (this.txtCaptionq.Text.Trim() != "")
            {
                strWhereCond += " and Caption like '%" + this.txtCaptionq.Text.Trim() + "%'";
            }
            if (this.ddlFldTypeq.SelectedValue != "" && this.ddlFldTypeq.SelectedValue != "0")
            {
                strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue + "'";
            }
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                //      strWhereCond += " and Fldid in (select fldid from PrjTabFld where TabId='" + this.ddlTabIdq.SelectedValue + "')";
                strWhereCond += string.Format(" and TabId='{0}'",
                    this.ddlTabIdq.SelectedValue);
            }
            if (this.ddlIsNullq.SelectedValue == "��")
            {
                strWhereCond += " and IsNull='1'";
            }
            else if (this.ddlIsNullq.SelectedValue == "��")
            {
                strWhereCond += " and IsNull='0'";
            }
            if (this.ddlIsPrimaryKeyq.SelectedValue == "��")
            {
                strWhereCond += " and IsPrimaryKey='1'";
            }
            else if (this.ddlIsPrimaryKeyq.SelectedValue == "��")
            {
                strWhereCond += " and IsPrimaryKey='0'";
            }
            if (this.ddlIsRootFld.SelectedValue == "��")
            {
                strWhereCond += string.Format(" and {0}='1'", conFieldTab4RootFld.IsRootFld);
            }
            else if (this.ddlIsRootFld.SelectedValue == "��")
            {
                strWhereCond += string.Format(" and {0}='0'", conFieldTab4RootFld.IsRootFld);
            }
            if (this.ddlFldStateIdq.SelectedValue != "" && this.ddlFldStateIdq.SelectedValue != "0")
            {
                strWhereCond += " And FldStateId='" + this.ddlFldStateIdq.SelectedValue + "'";
            }

            return strWhereCond;
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
            this.wucvFieldTab4RootFld4Gv1.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_vFieldTab4RootFld();
        }

        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="strFldID">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(string strFldID)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (strFldID == "") return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsFieldTabBL.IsExist(strFldID) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + strFldID + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldID);
            Session.Add("objFieldTabEN", objFieldTabEN);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromFieldTabClass(objFieldTabEN);
        }

        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjFieldTab">��ʵ�������</param>
        private void GetDataFromFieldTabClass(clsFieldTabEN pobjFieldTab)
        {
            wucFieldTab1.FldId = pobjFieldTab.FldId;
            wucFieldTab1.PrjId = pobjFieldTab.PrjId;
            wucFieldTab1.FldName = pobjFieldTab.FldName;
            wucFieldTab1.DataTypeId = pobjFieldTab.DataTypeId;
            wucFieldTab1.FldLength = pobjFieldTab.FldLength;
            wucFieldTab1.FldPrecision = pobjFieldTab.FldPrecision ?? 0;

            wucFieldTab1.Caption = pobjFieldTab.Caption;
            wucFieldTab1.FldInfo = pobjFieldTab.FldInfo;
            wucFieldTab1.IsNull = pobjFieldTab.IsNull;
            wucFieldTab1.IsPrimaryKey = pobjFieldTab.IsPrimaryKey;
            wucFieldTab1.IsIdentity = pobjFieldTab.IsIdentity;
            wucFieldTab1.MaxValue = pobjFieldTab.MaxValue;
            wucFieldTab1.MinValue = pobjFieldTab.MinValue;
            wucFieldTab1.DefaultValue = pobjFieldTab.DefaultValue;
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(pobjFieldTab.FldId, pobjFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                wucFieldTab1.IsNeedTransCode = true;
                wucFieldTab1.CodeTabId = objFieldTab4CodeConv.CodeTabId;
                wucFieldTab1.CodeTabNameId = objFieldTab4CodeConv.CodeTabNameId;
                wucFieldTab1.CodeTabCodeId = objFieldTab4CodeConv.CodeTabCodeId;
            }          
            wucFieldTab1.FldStateId = pobjFieldTab.FldStateId;

            ///���ö����б�
            List<ObjStruct> arrLst = new List<ObjStruct>();
            string strCondition = string.Format("{0} = '{1}'",
             convPrjTabFld.FldId,
             pobjFieldTab.FldId);

            List<clsvPrjTabFldEN> arrvPrjTabFldLst = clsvPrjTabFldBL.GetObjLst(strCondition);
            ObjStruct objStruct;
            if (arrvPrjTabFldLst.Count > 0)
            {
                foreach (clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldLst)
                {
                    objStruct.strObjId = objvPrjTabFldEN.TabId;
                    objStruct.strObjName = objvPrjTabFldEN.TabName;
                    arrLst.Add(objStruct);
                }
                wucFieldTab1.TabList = arrLst;
            }
            
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
            clsFieldTabEN objFieldTabEN;

            List<ObjStruct> arrObjStructLst;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            
            switch (strCommandText)
            {
                case "���":
                    wucFieldTab1.SetKeyReadOnly(false);
                    wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
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
                    if (!wucFieldTab1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsFieldTabEN objFieldTabEN;	//�������
                    objFieldTabEN = new clsFieldTabEN(wucFieldTab1.FldId);	//��ʼ���¶���
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                        strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToFieldTabClass(objFieldTabEN);		//�ѽ����ֵ����
                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    ///
                    try
                    {
                        clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    if (objFieldTabEN.AddRecordEx() == false)
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
                        arrObjStructLst = wucFieldTab1.TabList;
                        foreach (ObjStruct objObjStruct in arrObjStructLst)
                        {
                            if (clsPrjTabFldBLEx .Add_FieldTabToPrjTabFld(objObjStruct.strObjId, objFieldTabEN.FldId, clsCommonSession.UserId) == false) break;
                        }
                    }
                    //7��������ļ�¼������ʾ��DATAGRID��
                    BindGv_vFieldTab4RootFld();
                    wucFieldTab1.Clear();		//��տؼ�������
                    ///�ָ�<ȷ�����>���<���>
                    btnOKUpd.Text = "���";
                    tabLayout.Visible = false;
                    tabQuery.Visible = true;
                    try
                    {
                        //�����־
                        string strUserId = clsCommonSession.UserId;
                        string strUserIp = Request.UserHostAddress;
                        string strUserName = clsUsersBL.GetObjByUserId(strUserId).UserName;
                        string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //ɾ����¼;
                        string strTableName = "FieldTab";
                        string strTableKey = objFieldTabEN.FldId;
                        string strJournal = "ִ������Ӳ�������ӱ�FieldTab! �ֶ�����"
                            + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                        
                        bool IsSuccesful = true;
                        IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                            strUserIp,
                            strOperationType,
                            strTableName,
                            strTableKey,
                            strJournal,
                            clsPubVar.CurrSelPrjId);
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = "��Ӽ�¼�������־���ɹ�!\r\n" + objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

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
                    if (!wucFieldTab1.IsValid())
                    {
                        lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objFieldTabEN = (clsFieldTabEN)Session["objFieldTabEN"];
                    if (clsFieldTabBLEx.IsCanDelUpd(objFieldTabEN.FldId) == false)
                    {
                        strMsg = "�ü�¼�Ѻ�ʵ��鵵�������޸�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        lblMsg.Text = "�ü�¼�Ѻ�ʵ��鵵�������޸�!";
                        //return ;
                    }
                    else
                    {
                        PutDataToFieldTabClass(objFieldTabEN);		//�ѽ����ֵ����
                        //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                        try
                        {
                            clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                           
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
                        try
                        {
                            if (objFieldTabEN.CheckUniqueness() == false)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�ڹ��̣�{0}�У�", clsProjectsBL.GetPrjNameByPrjIdCache(objFieldTabEN.PrjId));
                                sbMsg.AppendFormat("�ֶ�����{0}��", objFieldTabEN.FldName);
                                sbMsg.AppendFormat("�ֶ����ͣ�{0}�Ѿ����ڣ���ӵ�ǰ���ֶ���ɾ�����ֶΣ���������µ��ֶΡ�", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId));

                                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                                return;
                            }

                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
                       
                        //4��������ʵ���������޸�ͬ�������ݿ���
                        try
                        {
                            if (objFieldTabEN.UpdateRecordEx() == false)
                            {
                                strMsg = "�޸ļ�¼���ɹ�!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "�޸ļ�¼���ɹ�!";
                            }
                            else
                            {
                                clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(objFieldTabEN.FldId, clsCommonSession.UserId);

                                strMsg = "�޸ļ�¼�ɹ�!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "�޸ļ�¼�ɹ�!";
                           
                                arrObjStructLst = wucFieldTab1.TabList;
                                List<string> arrTarTabIdLst = new List<string>();
                                foreach(ObjStruct objTab in arrObjStructLst)
                                {
                                    arrTarTabIdLst.Add(objTab.strObjId);
                                }
                                clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);

                            }
                            //5�����޸ĺ��������ʾ��DATAGRID��
                            BindGv_vFieldTab4RootFld();
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
//                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
                        wucFieldTab1.Clear();//��տؼ��е�����
                    }
                    //�ָ�<ȷ���޸�>���<���>
                    btnOKUpd.Text = "���";
                    tabLayout.Visible = false;
                    tabQuery.Visible = true;
                    try
                    {
                        //�����־
                        string strUserId = clsCommonSession.UserId;
                        string strUserIp = Request.UserHostAddress;
                        string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                        string strOperationType = clsOperationTypeBLEx.UPDATE_RECORD; //ɾ����¼;
                        string strTableName = "FieldTab";
                        string strTableKey = objFieldTabEN.FldId;
                        string strJournal = "ִ�����޸Ĳ������޸ı�FieldTab! �ֶ�����"
                            + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                        
                        bool IsSuccesful = true;
                        IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                            strUserIp,
                            strOperationType,
                            strTableName,
                            strTableKey,
                            strJournal,
                            clsPubVar.CurrSelPrjId);
                    }
                    catch (Exception objException)
                    {
                        clsCommonSession.seErrMessage = "�޸ļ�¼�����־���ɹ�!\r\n" + objException.Message;
                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                    }

                    break;
            }
        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjFieldTab">���ݴ����Ŀ�������</param>
        private void PutDataToFieldTabClass(clsFieldTabEN pobjFieldTab)
        {
            pobjFieldTab.FldId = wucFieldTab1.FldId;
            pobjFieldTab.PrjId = wucFieldTab1.PrjId;
            pobjFieldTab.FldName = wucFieldTab1.FldName;
            pobjFieldTab.DataTypeId = wucFieldTab1.DataTypeId;
            pobjFieldTab.FldLength = wucFieldTab1.FldLength;
            pobjFieldTab.FldPrecision = wucFieldTab1.FldPrecision;

            pobjFieldTab.Caption = wucFieldTab1.Caption;
            pobjFieldTab.FldInfo = wucFieldTab1.FldInfo;
            pobjFieldTab.IsNull = wucFieldTab1.IsNull;
            pobjFieldTab.IsPrimaryKey = wucFieldTab1.IsPrimaryKey;
            pobjFieldTab.IsIdentity = wucFieldTab1.IsIdentity;
            pobjFieldTab.MaxValue = wucFieldTab1.MaxValue;
            pobjFieldTab.MinValue = wucFieldTab1.MinValue;
            pobjFieldTab.DefaultValue = wucFieldTab1.DefaultValue;
            //pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
            //pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
            //pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
            //pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
            pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
            pobjFieldTab.UpdUser = wucFieldTab1.UserId;
      
            pobjFieldTab.FldStateId = wucFieldTab1.FldStateId;
       
        }

        private void DeleteRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                clsFieldTabBL.DelRecord(strFldId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFieldTab4RootFld();

        }
        private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
        {
            if (objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }

            }
        }


        
     
       
        public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("��ѡ��...", "0");
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
            ListItem li = new ListItem("��ѡ��...", "0");
            objDDL.Items.Add("��");
            objDDL.Items.Add("��");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //Ϊ�������������ݵ�����������������б�����ֱ����ӵ�
            ///objDDL.Items.Add("��");
            ///objDDL.Items.Add("Ů");
        }

        protected void gvFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 8;
                iNum[1] = 9;
                iNum[2] = 10;
                for (int i = 0; i < 3; i++)
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
        /// <summary>
        /// ����Excel�ļ����ֶ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
        {
           Response.Redirect("wfmImportFldInfoFromExcel.aspx");
        }

        protected void lbAddNewFld_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = false;
            tabLayout.Visible = true;
            wucFieldTab1.Clear();
            wucFieldTab1.SetKeyReadOnly(false);
            wucFieldTab1.PrjId = clsPubVar.CurrSelPrjId;
            
            wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            btnOKUpd.Text = "ȷ�����";
        }

        protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmImportFldInfoFromSQL.aspx");

        }

        protected void lbDispFieldList_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = true;
            tabLayout.Visible = false;
        }

        protected void lbInsNewRec_Click(object sender, System.EventArgs e)
        {
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
            //2��������󲢳�ʼ������

            string strMsg;
            string strFldId;
            lblMsg4AddRecord.Text = "";
            clsFieldTabEN objFieldTabEN;
            strFldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
            objFieldTabEN = new clsFieldTabEN(strFldId);	//��ʼ���¶���
            //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//�ж��Ƿ�����ͬ�Ĺؼ���
            {
                strMsg = "�ؼ����ֶ�������ͬ��ֵ";
                lblMsg4AddRecord.Text = strMsg;
                //                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //����Ƿ������ͬ�ֶ���
            string strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' And DataTypeId='{2}'",
                      clsPubVar.CurrSelPrjId, FldName, DataTypeId);

            if (clsFieldTabBL.IsExistRecord(strCondition))	//�ж��Ƿ�����ͬ�Ĺؼ���
            {
                strMsg = "�ڵ�ǰ�������Ѵ�����ͬ���ֶ����ƣ������»�һ���ֶ�����!";
                lblMsg4AddRecord.Text = strMsg;
                //                clsCommonJsFunc.Alert(this, strMsg);
                strFldId = clsFieldTabBLEx.GetFldId(clsPubVar.CurrSelPrjId, FldName, DataTypeId);

                BindGv_vFieldTab4RootFld();
                return;
            }

            //4����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToFieldTabClass2(objFieldTabEN);		//�ѽ����ֵ����
            //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return;
            }
            try
            {
                //6��������ʵ�������ݴ��������ݿ���
                if (objFieldTabEN.AddRecordEx() == false)
                {
                    strMsg = "��Ӳ��ɹ�!";
                    //                clsCommonJsFunc.Alert(this, strMsg);
                    lblMsg.Text = "��Ӽ�¼���ɹ�!";
                }
                else
                {
                    lblMsg.Text = "��Ӽ�¼�ɹ�!";
                }
                //7��������ļ�¼������ʾ��DATAGRID��
                BindGv_vFieldTab4RootFld();
            }
            catch (Exception objException)
            {
                lblMsg4AddRecord.Text = objException.Message;
                return;
            }
            wucFieldTab1.Clear();		//��տؼ�������
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //ɾ����¼;
                string strTableName = "FieldTab";
                string strTableKey = objFieldTabEN.FldId;
                string strJournal = "ִ������Ӳ�������ӱ�FieldTab! �ֶ�����"
                    + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                
                bool IsSuccesful = true;
                IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                    strUserIp,
                    strOperationType,
                    strTableName,
                    strTableKey,
                    strJournal,
                    clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��Ӽ�¼�������־���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }


            ///�ָ�<ȷ�����>���<���>
            //			btnOKUpd.Text = "���";
            //			tabLayout.Visible = false;
            //			tabQuery.Visible = true;

        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjFieldTab">���ݴ����Ŀ�������</param>
        private void PutDataToFieldTabClass2(clsFieldTabEN pobjFieldTab)
        {
            pobjFieldTab.PrjId = clsPubVar.CurrSelPrjId;
            pobjFieldTab.FldName = FldName;
            pobjFieldTab.DataTypeId = DataTypeId;
            pobjFieldTab.FldLength = FldLength;
            pobjFieldTab.FldPrecision = FldPrecision;

            pobjFieldTab.Caption = Caption;
            //			pobjFieldTab.FldInfo = wucFieldTab1.FldInfo;
            pobjFieldTab.IsNull = IsNull;
            pobjFieldTab.IsPrimaryKey = IsPrimaryKey;
            //			pobjFieldTab.MaxValue = wucFieldTab1.MaxValue;
            //			pobjFieldTab.MinValue = wucFieldTab1.MinValue;
            //			pobjFieldTab.DefaultValue = wucFieldTab1.DefaultValue;
            //			pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
            //			pobjFieldTab.CodeTab = wucFieldTab1.CodeTab;
            //			pobjFieldTab.CodeTabName = wucFieldTab1.CodeTabName;
            //			pobjFieldTab.CodeTabCode = wucFieldTab1.CodeTabCode;
            pobjFieldTab.UpdDate = wucFieldTab1.getTodayStr(0);
            pobjFieldTab.UpdUser = clsCommonSession.UserId;
            pobjFieldTab.FldStateId = "01";
   
            //			pobjFieldTab.AppliedScope = wucFieldTab1.AppliedScope;
        }


        protected void lbDelFld_Click(object sender, System.EventArgs e)
        {
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //ɾ����¼;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in lstFldID)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    string strJournal = "ִ����ɾ��������ɾ����FieldTab! �ֶ�����"
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                        clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼�����־���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                string strObjId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex >= 1)
                {
                    foreach (string strFldId in lstFldID)
                    {
                        clsFieldTabBLEx.DelFieldTabBySp(strFldId, strObjId);
                    }
                    //string strMsg = "��ѡ��һ�����ʵĶ�����!";
                    //clsCommonJsFunc.Alert(this, strMsg);
                    //return;
                }
                else
                {
                    foreach (string strFldId in lstFldID)
                    {
                        clsFieldTabBL.DelRecord(strFldId);
                    }
                }
                //clsFieldTabBLEx.DelFieldTabEx(objArr);

            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFieldTab4RootFld();

            //			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");
        }

        //protected void ddlObjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    string strObjId = ddlTabIdq.SelectedValue;
        //    List<string> arrLst = new List<string>();
        //    arrLst = clsGeneralTab2.funGetFldValue("PrjTab", "TabName", "ObjId = '" + strObjId + "'");
        //    if (arrLst == null || arrLst.Count == 0)
        //        return;
          
        //}
        /// <summary>
        /// ����ѡ����������ֶΣ����Ƶ���ر��У�ͬʱɾ��������û�е��ֶ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
        {
            //�������裺
            //1����ȡ��ǰ��ID����ض���ID��
            //2����ȡ��ض���ID���ֶ�ID��DataTable;
            //3���Ըñ����ѭ�������ֶ���Ϣ���뵽һ��ArrayList
            //4���ڲ�������У�Ҫע���ֶ�ID���ظ������ܲ����ظ�
            //			string strWhereCond;
            string strObjId;
            //1����ȡ��ǰ��ID����ض���ID��
            strObjId = ddlTabIdq.SelectedValue;
            if (strObjId == null || strObjId.Length == 0)
            {
                return;
            }
            //if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
            //{
            //    Response.Write("<script>alert('����ض������ֶ���Ϣ�ɹ�����')</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('�ö���������ر�ͬ��������������ԣ����߸ö���û����ص��ֶΣ���')</script>");
            //}



        }

        protected void btnQueryForAdvanced_Click(object sender, System.EventArgs e)
        {
            //��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
            //��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
            this.wucvFieldTab4RootFld4Gv1.PageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindGv_vFieldTab4RootFld();
        }
        private void DispAdvanceQuery()
        {
            tabAdvanceQuery.Visible = true;
        }
        private void HideAdvanceQuery()
        {
            tabAdvanceQuery.Visible = false;
        }

        protected void lbAdvanceQuery_Click(object sender, System.EventArgs e)
        {
            DispAdvanceQuery();
        }

        protected void lbHideAdvanceQuery_Click(object sender, System.EventArgs e)
        {
            HideAdvanceQuery();
        }

        protected void ddlFuncModuleId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlFuncModuleIdq.SelectedIndex > 0)
            {
                string strFuncModuleId = ddlFuncModuleIdq.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
            }
        }

        protected void lbDelFieldTabEx_Click(object sender, System.EventArgs e)
        {
            string strUserIp = Request.UserHostAddress;
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
        
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //ɾ����¼;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in lstFldID)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

                    string strJournal = "ִ����ɾ��������ɾ����FieldTab! �ֶ�����"
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                        clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼�����־���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                if (strUserIp =="::1" || strUserIp == "127.0.0.1" 
                    || strUserIp == "59.78.151.114" || strUserIp == "59.78.151.116")
                {
                    clsFieldTabBLEx.DelFieldTabEx2(lstFldID);
                }
                else
                {
                    clsCommonJsFunc.Alert(this, "ɾ�����ֶ�Ӧ�����ض���IP��ַ�������ڣ�" + strUserIp);
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFieldTab4RootFld();

            //			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");

        }

        public string FldName
        {
            get
            {
                return txtFldName.Text.Trim();
            }
            set
            {
                txtFldName.Text = value.ToString();
            }
        }

        public string DataTypeId
        {
            get
            {
                if (ddlFldType.SelectedValue == "0")
                {
                    return "";
                }
                return ddlFldType.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFldType.SelectedValue = "0";
                }
                else
                {
                    ddlFldType.SelectedValue = value;
                }
            }
        }

        public int FldLength
        {
            get
            {
                return int.Parse(txtFldLength.Text.Trim());
            }
            set
            {
                txtFldLength.Text = value.ToString();
            }
        }
        /// <summary>
        /// С��λ��
        /// </summary>
        public int FldPrecision
        {
            get
            {
                return int.Parse(txtFldPrecision.Text.Trim());
            }
            set
            {
                txtFldPrecision.Text = value.ToString();
            }
        }

        public string Caption
        {
            get
            {
                return txtCaption.Text.Trim();
            }
            set
            {
                txtCaption.Text = value.ToString();
            }
        }
        public bool IsNull
        {
            get
            {
                if (ddlIsNull.SelectedItem.Text == "��")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlIsNull.SelectedValue = "��";
                }
                else
                {
                    ddlIsNull.SelectedValue = "��";
                }
            }
        }

        public bool IsPrimaryKey
        {
            get
            {
                if (ddlIsPrimaryKey.SelectedItem.Text == "��")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlIsPrimaryKey.SelectedValue = "��";
                }
                else
                {
                    ddlIsPrimaryKey.SelectedValue = "��";
                }
            }
        }
        //public string ObjId
        //{
        //    get
        //    {
        //        if (ddlObjId.SelectedValue == "0")
        //        {
        //            return "";
        //        }
        //        return ddlObjId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            ddlObjId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            ddlObjId.SelectedValue = value;
        //        }
        //    }

        //}

        protected void lbUpdate_Click(object sender, EventArgs e)
        {
            string strFldID = wucvFieldTab4RootFld4Gv1.GetFirstCheckedKeyFromGv();
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(strFldID);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "ȷ���޸�";
            DispEditFieldTabRegion();
        }
       
        ///�޸Ĵ���׼�����̴��� for C#
        private void UpdateFieldTabRecordSave(clsFieldTabEN objFieldTabEN)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucFieldTab1.IsValid())
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToFieldTabClass(objFieldTabEN);		//�ѽ����ֵ����
            //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                //6��������ʵ�������ݴ��������ݿ���
                objFieldTabEN.UpdateRecordEx();
                clsPubFun4BLEx.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);

            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg.Text = "�޸ļ�¼�ɹ�!";
            wucFieldTab1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_vFieldTab4RootFld();
            DispFieldTabListRegion();
        }
        private void UpdateFieldTabRecord(string strFldID)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(strFldID);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "ȷ���޸�";
            lblMsg.Text = "";
            DispEditFieldTabRegion();
        }
        private void DispFieldTabListRegion()
        {
            tabQuery.Visible = true;
            tabLayout.Visible = false;
        }
        private void DispEditFieldTabRegion()
        {
            tabQuery.Visible = false;
            tabLayout.Visible = true;
        }
       
        /// <summary>
        /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��GridView�С�
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vFieldTab4RootFld()
        {
            //��������:(��5��)
            //	1����Ͻ�����������
            //	2�����ÿؼ��еİ�GridView����;
            //	3������Gv�ؼ���ĳЩ�в��ɼ�;

            try
            {
                //	1����Ͻ�����������
                string strWhereCond = CombinevFieldTab4RootFldCondition();
                //	2�����ÿؼ��еİ�GridView������
                wucvFieldTab4RootFld4Gv1.BindGv_FieldTab(strWhereCond);
                //	3������Gv�ؼ���ĳЩ�в��ɼ���
                //wucvFieldTab4RootFld4Gv1.SetGvVisibility(constwucvFieldTab4RootFld4Gv.UpdDate, false);
                //wucvFieldTab4RootFld4Gv1.SetGvVisibility(constFieldTab.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)��GridView����!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }
      

        protected string vsSortFieldTabBy
        {
            get
            {
                string sSortFieldTabBy;
                sSortFieldTabBy = (string)ViewState["SortFieldTabBy"];
                if (sSortFieldTabBy == null)
                {
                    sSortFieldTabBy = "";
                }
                return sSortFieldTabBy;
            }
            set
            {
                string sSortFieldTabBy = value;
                ViewState.Add("SortFieldTabBy", sSortFieldTabBy);
            }
        }
   
        protected void Set_GridViewAllChecked(GridView objGv, bool IsSelected)
        {
            if (objGv.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }
        protected string GetFirstCheckedItemFromGv(GridView objGv)
        {
            if (objGv.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                //foreach (GridViewRow di in objGv.Rows)
                //{
                //    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                //    if (chkCheckRec != null && chkCheckRec.Checked)
                //    {
                //        return di.Cells[1].Text;

                //    }
                //}
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                    if (chkCheckRec != null && chkCheckRec.Checked)
                    {
                        return objGv.DataKeys[iRow].Value.ToString();
                    }
                }
            }
            return "";
        }
        protected ArrayList GetAllCheckedItemFromGv1(System.Web.UI.WebControls.GridView objGv, string strChkName)
        {
            ArrayList arr = new ArrayList();
            if (objGv.Rows.Count == 0)
            {
                return arr;
            }
            else
            {
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox cb = (CheckBox)di.Cells[0].FindControl(strChkName);
                    if (cb != null && cb.Checked)
                    {
                        arr.Add(objGv.DataKeys[iRow].Value.ToString());
                    }
                }
                return arr;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void DeleteFieldTabRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                //�ж��Ƿ���ѡ�еĶ���ID
                string strTabId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex < 1)
                {
                    string strMsg = "��ѡ��һ�����ʵı���!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                clsFieldTabBLEx.DelFieldTabBySp(strFldId, strTabId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "ɾ����¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vFieldTab4RootFld();
        }
       
        
        protected void lbCheckField_Click(object sender, EventArgs e)
        {
            CheckField();
            BindGv_vFieldTab4RootFld();
        }
        protected void lbCopyField_Click(object sender, EventArgs e)
        {
            //�����ֶ�
            CopyField();
        }

        protected void btnExportExcel4Gv_Click(object sender, EventArgs e)
        {
            //����Excel����
            ExportExcel();
        }

        ///����ר�����ڵ���Excel����ش���
        private void ExportExcel()
        {
            //	1����Ͻ�����������
            string strWhereCond = CombinevFieldTab4RootFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FieldTab��Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("FldId"); arrCnName.Add("�ֶ�ID");
            arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("Caption"); arrCnName.Add("����");
            arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
            arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
            arrColName.Add("IsNull"); arrCnName.Add("�Ƿ�ɿ�");
            arrColName.Add("IsPrimaryKey"); arrCnName.Add("�Ƿ�����");
            arrColName.Add("IsIdentity"); arrCnName.Add("�Ƿ�Identity");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("�Ƿ�Ψһ");
            arrColName.Add("TabNum"); arrCnName.Add("����");

            arrColName.Add("MaxValue"); arrCnName.Add("���ֵ");
            arrColName.Add("MinValue"); arrCnName.Add("��Сֵ");
            arrColName.Add("DefaultValue"); arrCnName.Add("ȱʡֵ");
            arrColName.Add("FldName_G"); arrCnName.Add("�ֶ���_����");
            arrColName.Add("FldName_B"); arrCnName.Add("�ֶ���_��");
            arrColName.Add("IsNationStandard"); arrCnName.Add("�Ƿ����");

            arrColName.Add("IsNeedTransCode"); arrCnName.Add("�Ƿ���Ҫת������");
            arrColName.Add("CodeTab"); arrCnName.Add("�����");
            arrColName.Add("CodeTabName"); arrCnName.Add("�����_����");
            arrColName.Add("CodeTabCode"); arrCnName.Add("�����_����");
            arrColName.Add("AppliedScope"); arrCnName.Add("Ӧ�÷�Χ");
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("IsArchive"); arrCnName.Add("�Ƿ�浵");
            arrColName.Add("OraDbType"); arrCnName.Add("Ora��������");
            arrColName.Add("FldBName_B"); arrCnName.Add("FldBName_B");
            arrColName.Add("FldInfo"); arrCnName.Add("�ֶ���Ϣ");
            
            arrColName.Add("UpdDate"); arrCnName.Add("�޸�����");
            arrColName.Add("IsChecked"); arrCnName.Add("�Ƿ��ʵ");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            arrColName.Add("PrjId"); arrCnName.Add("����ID");
            arrColName.Add("PrjName"); arrCnName.Add("��������");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2��������������ȡ�ñ�����������DataTable��
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }

        protected void lbRefreshUpdDate4RelaTab_Click(object sender, EventArgs e)
        {

            string strFldID = wucvFieldTab4RootFld4Gv1.GetFirstCheckedKeyFromGv();
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            try
            {
                clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(strFldID, clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, "ˢ����ر��޸�������ɣ�");
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnSetIsRootFld_Click(object sender, EventArgs e)
        {
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFldID in lstFldID)
                {
                    //clsFieldTab4RootFldEN objFieldTabEN = clsFieldTab4RootFldBLEx.GetObjBy(strFldID);
                    //if (objFieldTabEN.IsRootFld == true)
                    //{
                    //    objFieldTabEN.IsRootFld = false;
                    //}
                    //else
                    //{
                    //    objFieldTabEN.IsRootFld = true;
                    //}
                    //objFieldTabEN.UpdateRecordEx();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "�����Ƿ���ֶβ��ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFieldTab4RootFld();
        }

        protected void btnSetRootFld_Click(object sender, EventArgs e)
        {
            if (ddlFldId4Root.SelectedIndex<=0)
            {
                ddlFldId4Root.Focus();
                string strMsg = "��ѡ����ֶ�!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strFldId4Root = ddlFldId4Root.SelectedValue;
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                foreach (string strFldID in lstFldID)
                {
                    //clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldID);                    
                    //    objFieldTabEN.RootFldId = strFldId4Root;
                    //objFieldTabEN.UpdateRecordEx();
                }
            }
            catch (Exception objException)
            {
                string strMsg = "���ø��ֶβ��ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                return;
            }
            BindGv_vFieldTab4RootFld();
        }

        protected void lbAutoSetRootFld_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}' order by {4}", 
                conPrjTab.PrjId, clsCommonSession.CurrSelPrjId, 
                conPrjTab.TabStateId, enumTabState.Normal_01,
                conPrjTab.SqlDsTypeId);
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);
            foreach(clsPrjTabEN objInFor in arrPrjTabObjLst)
            {                
                List<clsPrjTabFldEN> arrPrjTabFldObjLst = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objInFor.TabId, objInFor.PrjId);
                foreach(clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjLst)
                {
                    strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                       conFieldTab4RootFld.TabId, objInFor.TabId,
                       conFieldTab4RootFld.FldId, objPrjTabFldEN.FldId);

                    clsFieldTab4RootFldEN objFieldTab = clsFieldTab4RootFldBL.GetFirstObj_S(strCondition);
                    bool bolIsExist = true;
                    if (objFieldTab == null)
                    {
                        objFieldTab = new clsFieldTab4RootFldEN();
                        objFieldTab.TabId = objInFor.TabId;
                        objFieldTab.FldId = objPrjTabFldEN.FldId;
                        objFieldTab.PrjId = objInFor.PrjId;
                        bolIsExist = false;
                    }

                    if (objPrjTabFldEN.FldId == objInFor.KeyFldId())
                    {
                   
                        objFieldTab.IsRootFld = true;
                        objFieldTab.Root4TabId = objInFor.TabId;
                        objFieldTab.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                        objFieldTab.UpdUser = clsCommonSession.UserId;
                        if (bolIsExist == true)
                        {
                            clsFieldTab4RootFldBL.UpdateBySql2(objFieldTab);
                        }
                        else
                        {
                            clsFieldTab4RootFldBL.AddNewRecordBySql2(objFieldTab);
                        }
                    }
                    else
                    {                    
                        objFieldTab.RootFldId = objInFor.KeyFldId();
                        objFieldTab.RootTabId = objInFor.TabId;
                        objFieldTab.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                        objFieldTab.UpdUser = clsCommonSession.UserId;
                        if (bolIsExist == true)
                        {
                            clsFieldTab4RootFldBL.UpdateBySql2(objFieldTab);
                        }
                        else
                        {
                            clsFieldTab4RootFldBL.AddNewRecordBySql2(objFieldTab);
                        }
                    }
                }
            }

            BindGv_vFieldTab4RootFld();
            clsCommonJsFunc.Alert(this, "�Զ����ø��ֶ���ɣ�");
        }
    }
    public partial class wfmFieldTab4RootFld : CommWebPageBase
    {
        private void CheckField()
        {
            string strWhereCond = CombinevFieldTab4RootFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            List<clsFieldTabEN> arrFieldTabObjList = clsFieldTabBL.GetObjLst(strWhereCond);
            foreach (clsFieldTabEN objFieldTabEN in arrFieldTabObjList)
            {
                clsFieldTabBLEx.CheckFieldTab(objFieldTabEN.FldId, clsPubVar.CurrSelPrjId);
            }
        }
        /// <summary>
        /// �����ֶ�
        /// </summary>
        private void CopyField()
        {
            string strMsg;
            //�ж��Ƿ���ѡ�еĶ���ID
            string strObjId = ddlTabIdq.SelectedValue;
            if (ddlTabIdq.SelectedIndex < 1)
            {
                strMsg = "��ѡ��һ�����ʵĶ�����!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            List<string> lstFldID = wucvFieldTab4RootFld4Gv1.GetAllCheckedKeysFromGv();
            if (lstFldID == null) return;
            lblMsgList.Text = "";
            try
            {
                //�����־
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                //string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                foreach (string strFldId in lstFldID)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

                    //clsFieldTabBLEx.CopyField2Bak20170705(clsPubVar.CurrSelPrjId, strFldId,
                        //objFieldTabEN.FldName + "_Copy", strObjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�����ֶβ��ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_vFieldTab4RootFld();

            //			Response.Write("<script>alert('��ѡ�ֶ��Ѿ�ɾ����')</script>");

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