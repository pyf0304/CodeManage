
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.FunClass;
using AGC.WebSrv;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using System;
using System.Data;
using System.Text;
using System.Web.UI;

namespace AGC.Webform
{
    /// <summary>
    /// roles ��ժҪ˵����
    /// </summary>
    public partial class wfmSelectProject : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

            if (!IsPostBack)
            {
                clsPubFun.AddReferencedAssemblies(this);
                if (this.UserId == "0")
                {
                    this.ReturnLoginView();
                }
                if (clsCommonSession.CurrPrjId == "0")
                {
                    this.ReturnLoginView();
                }
                this.BindDg_UserPrjGrant();
                this.Check_UserRole();
            }
        }


        public string UserId
        {
            get
            {
                if (Session["UserId"] != null)
                {
                    return Session["UserId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                Session.Add("UserId", value);

            }

        }

        public string UserStateId
        {
            get
            {
                if (Session["UserStateId"] != null)
                {
                    return Session["UserStateId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                Session.Add("UserStateId", value);

            }
        }




        private void BindDg_UserPrjGrant()
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
            //string strWhereCond = CombineCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            string strWhereCond = string.Format("UserId='{0}' order by {1} desc, visitednum desc",
                UserId,
                convUserPrjGrant.LastVisitedDate);
            //System.Data.DataTable objDT = clsUserPrjGrantBL.GetUserPrjGrantT(strWhereCond);
            System.Data.DataTable objDT = clsvUserPrjGrantBL.GetDataTable(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            this.dgUserPrjGrant.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgUserPrjGrant.DataBind();
            //	6�����ü�¼����״̬��
        }

        protected void dgUserPrjGrant_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            //string strMid = this.dgUserPrjGrant.SelectedItem.Cells[0].Text;
            //long lngMid = long.Parse(strMid);
            //try
            //{
   
            //    clsCommonSession.RoleId = objUserLoginInfo.RoleId;
            //    //Response.Redirect("../FrameSet.htm");  //�����������Լ����̵�����ܽ���

            //    clsPubVar.objLog.WriteDebugLog(clsSysParaEN.getAllSysPara());
            //    clsPubVar.objLog.WriteDebugLog(clsCommonSession.getAllCommonSession());


            //}
            //catch (Exception objException)
            //{
            //    clsCommonSession.seErrMessage = objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //    return;
            //}
            //Response.Redirect("~/Frame1/Admin/index.aspx");
            string strMid = this.dgUserPrjGrant.SelectedItem.Cells[0].Text;
            long lngMid = long.Parse(strMid);
            stuUserLoginInfo objUserLoginInfo = clsUserPrjGrantBLEx.GetUserLoginInfo(lngMid);
            clsUserPrjGrantEN objUserPrjGrant = null;
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.AppendFormat("Update {0} ", "UserPrjGrant");
                sbSql.AppendFormat(" Set VisitedNum = VisitedNum + 1, {1}='{2}' where Mid = {0} ", 
                    lngMid,
                    conUserPrjGrant.LastVisitedDate,
                    clsDateTime.getTodayDateTimeStr(1));
                clsSpecSQLforSql objSql = new clsSpecSQLforSql();
                objSql.ExecSql(sbSql.ToString());
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ķ��ʴ������ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //clsPrjTabBLEx.arrPrjTabObjLst = null;
            //clsPrjTabBLEx.arrPrjViewObjLst = null;
            objUserPrjGrant = clsUserPrjGrantBL.GetObjBymId(lngMid);
            new clsCommFun4BL4PrjTab().ReFreshCache(objUserPrjGrant.PrjId);
    
          
            clsPubVar.CurrSelPrjId = objUserPrjGrant.PrjId;
            WS_FieldName.autoCompleteWordList = null;
            WS_FieldName.strPrjId = objUserPrjGrant.PrjId;

            //clsPubVar.CurrSelPrjId = PrjId;
            //clsSysParaEN.strCurrPrjConnectString = clsPubVar.objCurrSelProject.ConnectString;
            ///����Ĭ�ϵ����ݿ�
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objUserPrjGrant.PrjId);
            clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsUserDefaPrjDataBaseBLEx.GetvUserDefaPrjDataBaseObjByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            if (objvUserDefaPrjDataBaseEN != null)
            {
                clsPubVar.CurrPrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId;
                new clsCommonSession().PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName;
            }
            else
            {
                string strDefaPrjDataBaseId = "";
                string strCondition = string.Format("PrjId='{0}'", clsPubVar.CurrSelPrjId);
                clsProjectDatabaseRelEN objProjectDatabaseRelEN = clsProjectDatabaseRelBL.GetFirstObj_S(strCondition);
                if (objProjectDatabaseRelEN == null)
                {
                    string strMsg = string.Format("���̣�{0}({1})û������������ݿ⣬�������Ա��ϵ��", objProject.PrjName, objProject.PrjId);

                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                strDefaPrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId, strDefaPrjDataBaseId);
                clsPubVar.CurrPrjDataBaseId = strDefaPrjDataBaseId;
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsPubVar.CurrDataBaseTypeId = objPrjDataBase.DataBaseTypeId;
                string strPrjDataBaseName;
                strPrjDataBaseName = objPrjDataBase.DataBaseName;
                new clsCommonSession().PrjDataBaseName = strPrjDataBaseName;
            }
            try
            {
                clsSqlViewBLEx.p_Set_InitLog4CreateView4Sql(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
      
                clsDataBaseModuleRelaBLEx.SetDefaDataBaseModuleRela(objProject.PrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("wfmSelectProject", "dgUserPrjGrant_SelectedIndexChanged", objException.Message, clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            Response.Write("<script>alert('��½�ɹ���')</script>");
            clsCommonSession.RoleId = objUserPrjGrant.RoleId;
            //Response.Redirect("../FrameSet.htm");  //�����������Լ����̵�����ܽ���

            clsPubVar.objLog.WriteDebugLog(clsSysParaEN.getAllSysPara());
            clsPubVar.objLog.WriteDebugLog(clsCommonSession.getAllCommonSession());

            Response.Redirect("~/Frame1/Admin/index.aspx");
        }

        private void Check_UserRole()
        {
            if (this.dgUserPrjGrant.Items.Count == 0)
            {
                this.ReturnLoginView();
            }
            else if (this.dgUserPrjGrant.Items.Count == 1)
            {
                clsCommonSession.RoleId = this.dgUserPrjGrant.Items[0].Cells[2].Text;
                Response.Redirect("../FrameSet.htm"); //�����������Լ����̵�����ܽ���
            }
        }

        private void ReturnLoginView()
        {

            Session.Clear();
            string strMsg;
            strMsg = "�Բ�������ʺ�״̬����ȷ�������µ�¼!";
            clsCommonJsFunc.Alert(this, strMsg);
            string ss = "<script language='javascript'> parent.window.location.href='../Index.aspx'</script>";
            Response.Write(ss);
            //			Response.Redirect("index.aspx"); //����������״����ʱ�����ص���½����

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
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage,                         
                        clsStackTrace.GetCurrClassFunction()));
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
