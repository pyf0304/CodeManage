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
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;



using com.taishsoft.common;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmFieldTab_U : CommWebPageBase
    {
        /// <summary>
        /// ����:1�����ֶ��޸ģ�Update;
        ///      2�������ֶ��޸ģ�UpdateInTab, Ӧ��������TabId, ObjId, FldId
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        
        /// <summary>
        /// ����:1�����ֶ��޸ģ�Update;
        ///      2�������ֶ��޸ģ�UpdateInTab, Ӧ��������TabId, ObjId, FldId
        /// </summary>
        private string qsObjId
        {
            get
            {
                string strObjId = Request.QueryString["ObjId"] ?? "".ToString();
                if ((strObjId != null) && (strObjId != ""))
                {
                    return strObjId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// ͨ��QueryString���ݹ�����UserId��������������������ҿ��Բο����������
        /// ������
        /// ���ڣ�
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// ����:1�����ֶ��޸ģ�Update;
        ///      2�������ֶ��޸ģ�UpdateInTab, Ӧ��������TabId, ObjId, FldId
        /// </summary>
        private string qsFldId
        {
            get
            {
                string strFldId = Request.QueryString["FldId"] ?? "".ToString();
                if ((strFldId != null) && (strFldId != ""))
                {
                    return strFldId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {
                try
                {
                    //Ԥ����QueryString��Session�����״̬��Ϣ
                    rf_PretreatmentQueryString();
                    if (string.IsNullOrEmpty(qsOperator) == true)
                    {
                        clsCommonJsFunc.Alert(this, "��������Ϊ�գ�����");
                        return;
                    }
                    //1��Ϊ��������������Դ�����б�����
                    wucFieldTab1.SetDdl_PrjId();
                    wucFieldTab1.SetDdl_FldType();
                    wucFieldTab1.SetDdl_IsNull();
                    //				wucFieldTab1.SetDdl_IsPrimaryKey();
                    wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);
                    wucFieldTab1.SetDdl_CodeTab();
                    wucFieldTab1.SetDdl_FldStateId();
                    wucFieldTab1.SetDdl_FieldTypeId();
                    wucFieldTab1.SetDdl_HomologousFldId(clsPubVar.CurrSelPrjId);

                    //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                    //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                    wucFieldTab1.SetKeyReadOnly(true);
                    btnOKUpd.Text = "ȷ���޸�";
                    ShowData(vsFldId);
                }
                catch(Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    return;
                }
            }
        }
        /// <summary>
        /// ���溯����Ԥ����QueryString��Session�����״̬��Ϣ��
        /// ע�ͣ����溯��-Regular Function
        ///       Ԥ����-Pretreatment
        /// </summary>
        private void rf_PretreatmentQueryString()
        {
            try
            {
                if (string.IsNullOrEmpty(qsFldId) == false)
                {
                    vsFldId = qsFldId.ToString();
                }
                else if (string.IsNullOrEmpty(seFldId) == false)
                {
                    vsFldId = seFldId;
                }
                if (string.IsNullOrEmpty(vsFldId) == true)
                {
                    clsCommonJsFunc.Alert(this, "��Ҫ�޸ĵĹؼ���Ϊ�գ�");
                    throw new Exception("��Ҫ�޸ĵĹؼ���Ϊ�գ�");
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        //���ɷ������Ӵ���Session����
        protected string BackPageLinkStrFromUpdField
        {
            get
            {
                string strBackPageLinkStrFromUpdField;
                strBackPageLinkStrFromUpdField = (string)Session["BackPageLinkStrFromUpdField"];
                if (strBackPageLinkStrFromUpdField == null)
                {
                    strBackPageLinkStrFromUpdField = "";
                }
                return strBackPageLinkStrFromUpdField;
            }
            set
            {
                string strBackPageLinkStrFromUpdField = value;
                Session.Add("BackPageLinkStrFromUpdField", strBackPageLinkStrFromUpdField);
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
        
      

   
        /// <summary>
        /// ��¼���û�ID�����ڼ���û�Ȩ��
        /// </summary>
        protected string vsFldId
        {
            get
            {
                string strFldId;
                strFldId = (string)ViewState["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                ViewState.Add("FldId", strFldId);
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

        private string seFldId
        {
            get
            {
                string strFldId;
                strFldId = (string)Session["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                Session.Add("FldId", strFldId);
            }
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
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldID);
            //4����ȡ�������������ԣ�
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
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
            wucFieldTab1.FieldTypeId = pobjFieldTab.FieldTypeId;
            wucFieldTab1.HomologousFldId = pobjFieldTab.HomologousFldId;


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

                        ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                        try
                        {
                            clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }

                        ///3.2����鴫��ȥ�Ķ��������Ƿ����߼��Դ���
                        if (clsFieldTabBLEx.CheckFieldTabNnUpdate(objFieldTabEN) == false)
                        {
                            clsCommonJsFunc.Alert(this, objFieldTabEN.Memo);
                            return;
                        }
                        StringBuilder sbCondition = new StringBuilder();
                        sbCondition.AppendFormat("PrjId='{0}' and FldName='{1}' and DataTypeId = '{2}' And FldId<>'{3}'",
                            objFieldTabEN.PrjId,
                            objFieldTabEN.FldName,
                            objFieldTabEN.DataTypeId, objFieldTabEN.FldId);
                        if (objFieldTabEN.CheckUniqueness() == true)//���Ϸ���������Ψһ������
                        {
                            if (qsOperator == "UpdateInTab")
                            {
                                while (true)
                                {
                                    if (string.IsNullOrEmpty(clsCommonSession.qsTabId) == true)
                                    {
                                        break;
                                    }
                                    string strFldId = clsFieldTabBL.GetFirstID_S(sbCondition.ToString());

                                    if (string.IsNullOrEmpty(strFldId) == true)
                                    {
                                        break;
                                    }
                                    string strFldId_S = qsFldId;

                                    try
                                    {
                                        clsPrjTabFldBLEx.ReplaceFieldInPrjTabFld(clsCommonSession.qsTabId, strFldId_S, strFldId);


                                    }
                                    catch (Exception objException)
                                    {
                                        clsCommonSession.seErrMessage = "�޸��ֶΣ��滻�ֶΣ����ɹ�!�������Ա��ϵ��\r\n" + objException.Message;
                                        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                                        clsPubFun4Web.AccessError(this, conCurrPageName);
                                    }
                                    ReturnParentPage();
                                }
                            }
                            else
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�ڹ��̣�{0}�У�", clsProjectsBL.GetPrjNameByPrjIdCache(objFieldTabEN.PrjId));
                                sbMsg.AppendFormat("�ֶ�����{0}��", objFieldTabEN.FldName);
                                sbMsg.AppendFormat("�ֶ����ͣ�{0}�Ѿ����ڣ���ӵ�ǰ���ֶ���ɾ�����ֶΣ���������µ��ֶΡ�", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId));

                                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                                return;
                            }
                        }
                        else
                        {
                            StringBuilder sbMsg = new StringBuilder();
                            sbMsg.AppendFormat("�ڹ��̣�{0}�У�", clsProjectsBL.GetPrjNameByPrjIdCache(objFieldTabEN.PrjId));
                            sbMsg.AppendFormat("�ֶ�����{0}��", objFieldTabEN.FldName);
                            sbMsg.AppendFormat("�ֶ����ͣ�{0}�Ѿ����ڣ���ӵ�ǰ���ֶ���ɾ�����ֶΣ���������µ��ֶΡ�", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId));

                            clsCommonJsFunc.Alert(this, sbMsg.ToString());
                            return;
                        }
                        //4��������ʵ���������޸�ͬ�������ݿ���
                        if (objFieldTabEN.UpdateRecordEx() == false)
                        {
                           strMsg = "�޸ļ�¼���ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "�޸ļ�¼���ɹ�!";
                        }
                        else
                        {
                            var objFieldTab4CodeConv = new clsFieldTab4CodeConvEN(objFieldTabEN.FldId);  //��ʼ���¶���
                            PutDataToFieldTab4CodeConvClass(objFieldTab4CodeConv);      //�ѽ����ֵ����
                                                                                        //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                                                                                        ///
                            try
                            {
                                clsFieldTab4CodeConvBL.CheckPropertyNew(objFieldTab4CodeConv);
                            }
                            catch (Exception objException)
                            {
                                clsCommonJsFunc.Alert(this, objException.Message);
                                return;
                            }
                            if (objFieldTab4CodeConv.EditRecordEx() == false)
                            {
                                strMsg = "�޸ļ�¼���ɹ�!";
                                clsCommonJsFunc.Alert(this, strMsg);
                                lblMsg.Text = "�޸ļ�¼���ɹ�!";
                                return;
                            }

                            clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(objFieldTabEN.FldId, clsCommonSession.UserId);
                            clsFieldTabBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                            clsPubFun4BLEx.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);
                            strMsg = "�޸ļ�¼�ɹ�!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "�޸ļ�¼�ɹ�!";
                       

                            arrObjStructLst = wucFieldTab1.TabList;
                            List<string> arrTarTabIdLst = new List<string>();
                            foreach (ObjStruct objTab in arrObjStructLst)
                            {
                                arrTarTabIdLst.Add(objTab.strObjId);
                            }
                            clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);

                        }
                        wucFieldTab1.Clear();//��տؼ��е�����
                    }
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
                    //�ָ�<ȷ���޸�>���<���>
                    //					btnOKUpd.Text = "���";
                    //					tabLayout.Visible = false;
                    ReturnParentPage();
                    break;
            }
        }
        private void PutDataToFieldTab4CodeConvClass(clsFieldTab4CodeConvEN pobjFieldTab)
        {
            pobjFieldTab.FldId = wucFieldTab1.FldId;
            pobjFieldTab.PrjId = wucFieldTab1.PrjId;

            pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
            pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
            pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
            pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
            pobjFieldTab.UpdUser = wucFieldTab1.UserId;

        }
        private void ReturnToParentPage1()
        {
            

            string strBackLinkStr = new clsCommonSession().BackPageEditFldLinkStr;

            if (strBackLinkStr != "")
            {
                Response.Redirect(strBackLinkStr + "?FromWebForm=FieldTab_U");
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
            pobjFieldTab.FieldTypeId = wucFieldTab1.FieldTypeId;
            pobjFieldTab.HomologousFldId = wucFieldTab1.HomologousFldId;


        }

        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            //������ҳ��
            ReturnParentPage(); 
            if (string.IsNullOrEmpty(BackPageLinkStrFromUpdField) == false)
            {
                Response.Redirect(BackPageLinkStrFromUpdField);
            }
            else if (string.IsNullOrEmpty(new clsCommonSession().BackPageEditFldLinkStr) == false)
            {
                Response.Redirect(new clsCommonSession().BackPageEditFldLinkStr);
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
                case "wfmEditTabAndObjectFields.aspx|":
                case "wfmEditTabAndObjectFields.aspx|wfmPrjTab_QUDI3.aspx":
                    string strTabId = clsCommonSession.TabId;
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, strTabId, strCurrPageName);
                        return;
                    }
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
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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