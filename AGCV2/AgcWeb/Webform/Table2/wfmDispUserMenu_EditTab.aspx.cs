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
using System.Configuration;


using CommFunc4WebForm;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
using System.Collections.Generic;


namespace AGC.Webform
{
    /// <summary>
    /// wfmTestMenu ��ժҪ˵����
    /// </summary>
    public partial class wfmDispUserMenu_EditTab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)
            {
                BindPrjTabAccordion(clsPubVar.CurrSelPrjId);
                BindPrjViewAccordion(clsPubVar.CurrSelPrjId);

            }
        }
        private void BindPrjTabAccordion(string strPrjId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}'", strPrjId);

            //clsPrjTabBLEx objPrjMenuBLEx = new clsPrjTabBLEx();
            //List<clsvPrjTabEN> arrPrjTabObjLst = null;
            List<clsvFuncModule_AgcEN> arrFuncModuleObjLst
               = clsvFuncModule_AgcBLEx.GetFuncModuleObjLst(strPrjId);// new clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
            ArrayList arrTabTypeNames = new ArrayList();
         
            //clsObjectTypeEN objObjectType2 = new clsObjectTypeEN();
            //objObjectType2.ObjectTypeId = clsSQLDSTypeBLEx.SQLVIEW;
            //objObjectType2.ObjectType = "��ͼ(View)";
            //arrTabTypeNames.Add(objObjectType2);

            //MenuItem miTab = new MenuItem();
            //miTab.Text = "��(Table)";
            //mnuPrjTab.Items.Add(miTab);

            accPrjTab.SelectedIndex = -1;
            //int i = 0;
           
        }
        private void BindPrjViewAccordion(string strPrjId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}'", strPrjId);

            //clsPrjTabBLEx objPrjMenuBLEx = new clsPrjTabBLEx();
            //List<clsvPrjTabEN> arrPrjTabObjLst = null;
            List<clsvFuncModule_AgcEN> arrFuncModuleObjLst
               = clsvFuncModule_AgcBLEx.GetFuncModuleObjLst(strPrjId);// new clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
            ArrayList arrTabTypeNames = new ArrayList();
            //clsObjectTypeEN objObjectType1 = new clsObjectTypeEN();
            //objObjectType1.ObjectTypeId = clsSQLDSTypeBLEx.SQLTAB;
            //objObjectType1.ObjectType = "��(Table)";
            //arrTabTypeNames.Add(objObjectType1);
          

            //MenuItem miTab = new MenuItem();
            //miTab.Text = "��(Table)";
            //mnuPrjTab.Items.Add(miTab);

            accPrjTab.SelectedIndex = -1;
            //int i = 1;
       
        }
        /// <summary>
        /// ��ȡδ֪ģ��ı���
        /// </summary>
        /// <param name="arrPrjTabObjLst"></param>
        /// <returns></returns>
        private int GetNullModuleTabNum(List<clsvPrjTabEN> arrPrjTabObjLst)
        {
            int intCount = 0;
            foreach (clsvPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                
                if (string.IsNullOrEmpty(objPrjTabEN.FuncModuleAgcId))
                {
                    intCount++;
                }
            }
            return intCount;
        }
        private void ReturnLoginView()
        {
            Session.Clear();
            string strMsg;
            strMsg = "�Բ������Ȩ�޲����������µ�¼!";
            clsCommonJsFunc.Alert(this, strMsg);
            string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
            //			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
            //			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
            Response.Write(ss);
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
        protected void lbRefresh_Click(object sender, EventArgs e)
        {
  
            //clsPrjTabBLEx.arrPrjTabObjLst = null;
            //clsPrjTabBLEx.arrPrjViewObjLst = null;
            BindPrjTabAccordion(clsPubVar.CurrSelPrjId);
            BindPrjViewAccordion(clsPubVar.CurrSelPrjId);

        }
}
}
