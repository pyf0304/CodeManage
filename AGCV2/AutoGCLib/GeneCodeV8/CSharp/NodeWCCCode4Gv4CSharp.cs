using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// �Զ����ɽ�����Ʋ�Ĵ�����(Control of Mvc)
    /// </summary>
    public class NodeWCCCode4Gv4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        protected bool mbolIsUseCtl = true;
        public NodeWCCCode4Gv4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
      
        public NodeWCCCode4Gv4CSharp(string strViewId)
     : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public NodeWCCCode4Gv4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
      : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
    
        }
   
     
        /// <summary>
        // ����Ȩ���йصı����������
        /// </summary>
        /// <returns></returns>

        /// <summary>
        // ����Ȩ���йصı����������
        /// </summary>
        /// <returns></returns>
        public string GenPotenceRelaVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����Ľ��湦������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����ĵ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString����:ͨ��QueryString���ݹ�����UserId����������������,��ҿ��Բο����������");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefProperty_vsPotenceLevel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefConst_ViewId4Potence()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefProperty_seUserId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:��¼���û�ID,���ڼ���û�Ȩ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId;");
                strCodeForCs.Append("\r\n" + "strUserId = (string)Session[\"UserId\"];");
                strCodeForCs.Append("\r\n" + "if (strUserId == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strUserId = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"UserId\", strUserId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                ////				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                //strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_CS_DefProperty_qsUserId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString����:ͨ��QueryString���ݹ�����UserId����������������,��ҿ��Բο����������");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                //strCodeForCs.Append("\r\n" + "/// <summary>");
                //strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n" + "/// </summary>");
                //strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                ////				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                //strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        

        public string Gen_WebView_CS_DefProperty_vsTabName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����ĵ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        
        public string Gen_WebView_CS_DefProperty_vsViewName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����Ľ��湦������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        // ����Ȩ���й��ж�Ȩ�޵Ĵ���
        /// </summary>
        /// <returns></returns>
        public string GenPotenceRelaCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.AppendFormat("\r\n" + "vsViewName = \"{0}\";", objViewInfoENEx.ViewCnName);
                strCodeForCs.AppendFormat("\r\n" + "vsTabName = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                  objViewInfoENEx.TabName_Out, "{", "}");

                strCodeForCs.Append("\r\n" + "//����Ȩ���й��ж�Ȩ�޵Ĵ���");
                //��ȡ��ǰ�û���Ȩ�޵ȼ����
                strCodeForCs.Append("\r\n" + "//���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô����,�ȼ���ŷ�ʽ:1Ϊ���2���,��������");
                strCodeForCs.Append("\r\n" + "switch (vsPotenceLevel)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"0\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"1\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"2\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"3\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"4\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"9\":");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        // ����Ȩ���й�Ȩ�޵ȼ��Ĵ���
        /// </summary>
        /// <returns></returns>
        public string GenPotenceLevelProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ViewState����:���ڼ�¼��ǰ�û��ڵ�ǰ�����Ȩ�޵ȼ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //��ȡ��ǰ�û���Ȩ�޵ȼ����
                strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = (string)ViewState[\"PotenceLevel\"];");
                strCodeForCs.Append("\r\n" + "if (sPotenceLevel == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = \"9\";");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PotenceLevel\", sPotenceLevel);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɵ�¼�û����û���Session
        /// </summary>
        /// <returns></returns>
        public string GenLoginUserSession()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//���ɵ�¼�û����û���Session");
                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:��¼���û�ID,���ڼ���û�Ȩ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId;");
                strCodeForCs.Append("\r\n" + "strUserId = (string)Session[\"UserId\"];");
                strCodeForCs.Append("\r\n" + "if (strUserId == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strUserId = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"UserId\", strUserId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n ///protected clsUsersEN objUser");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///get");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser;");
                strCodeForCs.Append("\r\n ///pobjUser = (clsUsersEN)Session[\"objUser\"];");
                strCodeForCs.Append("\r\n ///if (pobjUser == null) ");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///pobjUser = null;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///return pobjUser;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///set");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser = value;");
                strCodeForCs.Append("\r\n ///Session.Add(\"objUser\", pobjUser);");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenErrMessageSession()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:������Ϣ��Session����,��Session���ݸ���ʾ����ҳ��,��ʾ��Ӧ�Ĵ������ݡ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seErrMessage");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage;");
                strCodeForCs.Append("\r\n" + "strErrMessage = (string)Session[\"ErrMessage\"];");
                strCodeForCs.Append("\r\n" + "if (strErrMessage == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strErrMessage = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strErrMessage;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"ErrMessage\", strErrMessage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        
        public string GenPageSizeViewState()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ר�����ڼ�¼GridView�е�ÿҳ��¼��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageSize");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize;");
                strCodeForCs.Append("\r\n" + "strPageSize = (string)ViewState[\"PageSize\"];");
                strCodeForCs.Append("\r\n" + "if (strPageSize == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageSize = \"\";");
                strCodeForCs.Append("\r\n" + "return 15;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PageSize\", strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

      
        public string Gen_PageIndex()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�е�ҳ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageIndex");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex;");
                strCodeForCs.Append("\r\n" + "strPageIndex = (string)ViewState[\"pageIndex\"];");
                strCodeForCs.Append("\r\n" + "if (strPageIndex == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageIndex = \"\";");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageIndex);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"pageIndex\", strPageIndex);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_PageCount()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�е���ҳ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageCount");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageCount;");
                strCodeForCs.Append("\r\n" + "strPageCount = (string)ViewState[\"PageCount\"];");
                strCodeForCs.Append("\r\n" + "if (strPageCount == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageCount = \"\";");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageCount = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PageCount\", strPageCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_RecCount()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�е���ҳ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsRecCount");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strRecCount;");
                strCodeForCs.Append("\r\n" + "strRecCount = (string)ViewState[\"RecCount\"];");
                strCodeForCs.Append("\r\n" + "if (strRecCount == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strRecCount = \"\";");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strRecCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strRecCount = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"RecCount\", strRecCount);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBackLinkStrSession()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:�������Ӵ���Session����,��Session���ڸ��߳���ҳ��,��һ��ҳ������Ҫ���ص�ҳ�档");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string seBackErrPageLinkStr");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = (string)Session[\"BackErrPageLinkStr\"];");
                strCodeForCs.Append("\r\n" + "if (strBackErrPageLinkStr == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"BackErrPageLinkStr\", strBackErrPageLinkStr);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenBindGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}()", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	4������GridView������Դ(DataSource)��");
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "//	6�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable(strWhereCond);",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable_{1}(strWhereCond);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}", "��ȡ���ݱ�(DataTable)���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})��ȡ���ݱ�(DataTable)���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                ;
                strCodeForCs.Append("\r\n" + "//	4������GRIDView������Դ(DataSource)��");
                strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(PageSize) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = int.Parse(PageSize);");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PageSize = \"10\";");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = 10;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenBinggv_JumpPage());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//	6�����ü�¼����״̬,");
                    strCodeForCs.Append("\r\n" + "this.txtRecCount.Text = objDT.Rows.Count.ToString();");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ����:����DataGrid��ҳ��");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">�ܹ��ļ�¼��</param>");
                //strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ÿҳ�ļ�¼��</param>");
                //strCodeForCs.Append("\r\n /// <returns>���������ҳ��</returns>");
                //strCodeForCs.Append("\r\n" + "protected int CalcPages(int intRecCount, int intPageSize)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "int intPages;");
                //strCodeForCs.Append("\r\n" + "intPages = intRecCount / intPageSize;");
                //strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize != 0) intPages ++;");
                //strCodeForCs.Append("\r\n" + "return intPages;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenBindGridView4WucInPage()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ�;");
                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView����;");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ���");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdDate, false);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdUser, false);",
                    ClsName4WucTabName4Gv(),
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                      objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView������");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(vsobj{2}Cond);",
                  objViewInfoENEx.TabName, ClsName4WucTabName4Gv(), objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
               

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}", "��GridView����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})��GridView����!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBindGridView4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}(cls{1}EN obj{1}Cond)", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	4������GridView������Դ(DataSource)��");
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "//	6�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + " int intRecCount = 0;");
                strCodeForCs.Append("\r\n" + "int intPageCount = 0;");
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = JsonConvert.SerializeObject(obj{0}Cond);", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = {0}GetRecCountByCond(obj{0}Cond);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ����������Ķ����б�");
                strCodeForCs.Append("\r\n" + "stuPagerPara objPagerPara = new stuPagerPara()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "pageIndex = vsPageIndex,");
                strCodeForCs.Append("\r\n" + "PageSize = vsPageSize,");
                strCodeForCs.AppendFormat("\r\n" + "whereCond = JsonConvert.SerializeObject(obj{0}Cond),", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "OrderBy = vsSort{0}By", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "};");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = {0}GetObjLstByPager(objPagerPara);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = {0}GetObjLstByPager(objPagerPara);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "��ȡ���ݱ�(DataTable)���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})��ȡ���ݱ�(DataTable)���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                ;
                strCodeForCs.Append("\r\n" + "//	4������GRIDView������Դ(DataSource)��");
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                //    objViewInfoENEx.TabName);
                //}
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                

                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arrObjLst;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenBinggv_JumpPage());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//	6�����ü�¼����״̬,");
                    strCodeForCs.Append("\r\n" + "this.txtRecCount.Text = objDT.Rows.Count.ToString();");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ����:����DataGrid��ҳ��");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">�ܹ��ļ�¼��</param>");
                //strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ÿҳ�ļ�¼��</param>");
                //strCodeForCs.Append("\r\n /// <returns>���������ҳ��</returns>");
                //strCodeForCs.Append("\r\n" + "protected int CalcPages(int intRecCount, int intPageSize)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "int intPages;");
                //strCodeForCs.Append("\r\n" + "intPages = intRecCount / intPageSize;");
                //strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize != 0) intPages ++;");
                //strCodeForCs.Append("\r\n" + "return intPages;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBindGridView4WucCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}Cache(cls{1}EN obj{1}Cond)", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	4������GridView������Դ(DataSource)��");
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "//	6�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + " int intRecCount = 0;");
                strCodeForCs.Append("\r\n" + "int intPageCount = 0;");
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = JsonConvert.SerializeObject(obj{0}Cond);", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = {0}GetRecCountByCond(obj{0}Cond);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ����������Ķ����б�");
                strCodeForCs.Append("\r\n" + "stuPagerPara objPagerPara = new stuPagerPara()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "pageIndex = vsPageIndex,");
                strCodeForCs.Append("\r\n" + "PageSize = vsPageSize,");
                strCodeForCs.AppendFormat("\r\n" + "whereCond = JsonConvert.SerializeObject(obj{0}Cond),", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "OrderBy = vsSort{0}By", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "};");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = {0}GetObjLstByPager(objPagerPara);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = {0}GetObjLstByPager(objPagerPara);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "��ȡ���ݱ�(DataTable)���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})��ȡ���ݱ�(DataTable)���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                ;
                strCodeForCs.Append("\r\n" + "//	4������GRIDView������Դ(DataSource)��");
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                //    objViewInfoENEx.TabName);
                //}
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arrObjLst;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenBinggv_JumpPage());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//	6�����ü�¼����״̬,");
                    strCodeForCs.Append("\r\n" + "this.txtRecCount.Text = objDT.Rows.Count.ToString();");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ����:����DataGrid��ҳ��");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">�ܹ��ļ�¼��</param>");
                //strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ÿҳ�ļ�¼��</param>");
                //strCodeForCs.Append("\r\n /// <returns>���������ҳ��</returns>");
                //strCodeForCs.Append("\r\n" + "protected int CalcPages(int intRecCount, int intPageSize)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "int intPages;");
                //strCodeForCs.Append("\r\n" + "intPages = intRecCount / intPageSize;");
                //strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize != 0) intPages ++;");
                //strCodeForCs.Append("\r\n" + "return intPages;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_GridView_Sorting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,������ͷ�����������������¼�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_Sorting(object sender, GridViewSortEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intIndex;");
                strCodeForCs.Append("\r\n" + "//�ж��Ƿ����µ������ֶ�");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(e.SortExpression);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                objViewInfoENEx.TabName);
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }

                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//���ԭ��������");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\" Asc\");",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)		//���ԭ���������������Ϊ����");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else			///��������Ϊ����");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Desc\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڼ�¼GridView�еĵ�ǰ������ʽ,�Ա������һ��������,���ǽ�������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsSort{0}By",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = (string)ViewState[\"Sort{0}By\"];",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (sSort{0}By == null) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = \"\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sSort{0}By;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By = value;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"Sort{0}By\", sSort{0}By);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_vsWhereCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڼ�¼GridView�еĵ�ǰ������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsWhereCond",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = (string)ViewState[\"whereCond\"];",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (sWhereCond == null) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = \"\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sWhereCond;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond = value;",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"whereCond\", sWhereCond);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_vsCondObject()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڼ�¼GridView�еĵ�ǰ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected cls{0}EN vsobj{0}Cond", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond;", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sobj{0}Cond = (cls{0}EN)ViewState[\"obj{0}Cond\"];", objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "return sobj{0}Cond;", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond = value;", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"obj{0}Cond\", sobj{0}Cond);", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetGvVisibility()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�ֶεĿɼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void SetGvVisibility(string strColumnName, bool bolIsVisible)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, strColumnName, bolIsVisible);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetGvVisibility_AllShow()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�ֶεĿɼ���,�����ֶζ���ʾ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void SetGvVisibility_AllShow()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty(x.FldId) == false))
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{1}.{2}, true);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objDGRegionFldsEx.ObjFieldTabENEx .FldName);
                }

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetGvVisibility_AllHide()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�ֶεĿɼ���,�����ֶζ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public void SetGvVisibility_AllHide()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty( x.FldId ) == false))
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{1}.{2}, false);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out,  objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                }

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_SetVisible()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�Ŀɼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public void SetVisible(bool bolVisible)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.Visible = bolVisible;",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetSortBy()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����GridView�Ŀɼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetSortBy(string strSortBy)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(vsSort{0}By) == true)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = strSortBy;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
           
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_SetCheckedItemForGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������GridView��ѡ��һ����(һ����¼)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public bool SetCheckedItemForGv({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemForGv(gv{0}, 1, {1}.ToString());",
                    objViewInfoENEx.TabName,
                    objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_SetCheckedItemsForGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������GridView��ѡ������(������¼)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public bool SetCheckedItemsForGv(List<{0}> {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncListName);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemsForGv(gv{0}, 1, {1}.Select(x=>x.ToString()).ToList());",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncListName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemsForGv(gv{0}, 1, {1});",
                    objViewInfoENEx.TabName,
                    objKeyField.PrivFuncListName);
                }
                strCodeForCs.AppendFormat("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenCombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected string Combine{0}Condition()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objViewInfoENEx.TabName_Out);


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                      
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///����ؼ���������;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}_q.SelectedIndex == 1)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                             objViewInfoENEx.TabName_Out,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}_q.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             objViewInfoENEx.TabName_Out,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue!= \"\" && this.{1}.SelectedValue!= \"0\")",
                                objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        objViewInfoENEx.TabName_Out,
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = int.Parse( this.{2}.SelectedValue.ToString());",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        objViewInfoENEx.TabName_Out,
                                        "{", "}");
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        objViewInfoENEx.TabName_Out,
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;                   

                        case "TextBox": ///����ؼ��������ı���;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                                    objViewInfoENEx.TabName_Out,
                                   objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());
                                }
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.Text.Trim());",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.CtrlId(),
                             objViewInfoENEx.TabName_Out,
                             "{", "}");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{2}.{0}, this.{1}.Text.Trim());",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId(),
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///��Χ��ѯ;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                objViewInfoENEx.TabName_Out,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.CtrlId(),
                                      objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "Button":
                            break;
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Combine{0}Condition", "����ϲ�ѯ����(Combine{0}Condition)ʱ����!����ϵ����Ա!", "���ɴ���");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{1})����ϲ�ѯ����(Combine{0}Condition)ʱ����!����ϵ����Ա!\" + objException.Message);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenBinggv_JumpPage()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n ///����ר������BindGv�е���ҳ��ش���");

                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (pagerRow == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "Label lblRecCount = (Label)pagerRow.FindControl(\"lblRecCount\");");
                strCodeForCs.Append("\r\n" + "Label lblAllPages = (Label)pagerRow.FindControl(\"lblAllPages\");");
                strCodeForCs.Append("\r\n" + "Label lblCurrentPage = (Label)pagerRow.FindControl(\"lblCurrentPage\");");
                strCodeForCs.Append("\r\n" + "TextBox txtJump2Page = (TextBox)pagerRow.FindControl(\"txtJump2Page\");");
                strCodeForCs.Append("\r\n" + "Button btnNextPage = (Button)pagerRow.FindControl(\"btnNextPage\");");
                strCodeForCs.Append("\r\n" + "Button btnPrevPage = (Button)pagerRow.FindControl(\"btnPrevPage\");");
                strCodeForCs.Append("\r\n" + "Button tabJumpPage = (Button)pagerRow.FindControl(\"tabJumpPage\");");
                strCodeForCs.Append("\r\n" + "DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl(\"ddlPagerRecCount\");");
                strCodeForCs.Append("\r\n" + "if (lblRecCount != null)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "//��ǰ��¼��");
                strCodeForCs.AppendFormat("\r\n" + "lblRecCount.Text = intRecCount.ToString(); ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//��ǰҳ��");
                strCodeForCs.AppendFormat("\r\n" + "lblAllPages.Text = intPageCount.ToString(); ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//��ǰҳ����");
                strCodeForCs.AppendFormat("\r\n" + "lblCurrentPage.Text = vsPageIndex.ToString();",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//��ǰ����������ҳ����");
                strCodeForCs.AppendFormat("\r\n" + "txtJump2Page.Text = vsPageIndex.ToString();",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "//�����ǰҳ����Ϊ0,��<ǰһҳ>��ť��Ч");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == 1) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = false; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = true; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "//�����ǰҳ������Ϊ���һҳ,��<ǰһҳ>��ť��Ч");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == intPageCount) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = false; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = true; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");

                strCodeForCs.Append("\r\n" + "//���÷�ҳ����ÿҳ��¼�����������ֵ");
                strCodeForCs.Append("\r\n" + "if (vsPageSize>0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "ddlPagerRecCount.Text = vsPageSize.ToString();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.Append("\r\n" + "ddlPagerRecCount.Text = vsPageSize.ToString();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.BottomPagerRow.Visible = true;", objViewInfoENEx.TabName);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnAddNewRec4Gv_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n ///����¼�¼���¼�����,�����ڸù����е�����������,��Ҫ��������Ӷ��д��롣");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����¼�¼���¼����� ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                    objViewInfoENEx.TabName);
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
                    objViewInfoENEx.TabName);

                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnExportExcel4Gv_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����Excel ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{0}.Get{0}(strWhereCond);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "string [] strCnName = new string[intColNum];");
                strCodeForCs.Append("\r\n" + "string [] strColName = new string[intColNum];");
                strCodeForCs.Append("\r\n" + "string strFileName = \"TT.xls\";");
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "strFolderName = \"D:\\\\FTP\\\\\";");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����:�����ļ����ӷ����������ļ����ͻ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "protected bool DownLoadFile(string strDownLoadFileName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); ");
                strCodeForCs.Append("\r\n" + "Response.Clear(); ");
                strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Disposition\", \"attachment; filename = \" + HttpUtility.UrlEncode(file.Name)); ");
                strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Length\", file.Length.ToString()); ");
                strCodeForCs.Append("\r\n" + "Response.ContentType = \"application/octet-stream\"; ");
                strCodeForCs.Append("\r\n" + "Response.WriteFile(file.FullName); ");
                strCodeForCs.Append("\r\n" + "Response.End();");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����EXCEL�ļ�,���е������ֶ���ȫ��DataGridһ�¡�
        /// </summary>
        /// <returns></returns>
        public string GenbtnExportExcel4Gv_Click2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �¼�����:�Ѳ�ѯ�����ı��¼,������Excel.");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                //        strCodeForCs.Append("\r\n" + "//����ר�����ڵ���Excel����ش���");
                strCodeForCs.Append("\r\n" + "protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//����Excel����");
                strCodeForCs.Append("\r\n" + "ExportExcel();");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����EXCEL�ļ�,���е������ֶ���ȫ��DataGridһ�¡�ר����Ե����ֶ�
        /// </summary>
        /// <returns></returns>
        public string GenExportExcel4SetExportFld()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //����ר�����ڵ���Excel ����ش���
                strCodeForCs.Append("\r\n /// <summary>");
                
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}��Ϣ����.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ViewName = vsViewName;//��ǰ����");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.TabName = vsTabName;//����Excel���õı������ͼ");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ExportFileName = strFileName;//����Excel���ļ���");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UserId = clsCommonSession.UserId;//��ǰ�û�Id");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//��ǰ����");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;//��ǰ���������ɴ���ϵͳ�����õĹ���Id,Ϊ�˷����ֶ�����������");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrCnName = arrCnName;//�����ֶ���,Ҳ��Excel�ļ��еı�����");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrColName = arrColName;//���ݱ������");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx);");
                strCodeForCs.Append("\r\n" + "strFileName = objExportExcelSetENEx.ExportFileName;//����Excel���ļ���");
                strCodeForCs.Append("\r\n" + "arrCnName = objExportExcelSetENEx.arrCnName;//�����ֶ���,Ҳ��Excel�ļ��еı�����");
                strCodeForCs.Append("\r\n" + "arrColName = objExportExcelSetENEx.arrColName;//���ݱ������");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");




                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "//�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007,���Ի�����һ����䡣");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ����:�����ļ����ӷ����������ļ����ͻ��������");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>");
                //strCodeForCs.Append("\r\n /// <returns></returns>");
                //strCodeForCs.Append("\r\n" + "protected bool DownLoadFile(string strDownLoadFileName)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); ");
                //strCodeForCs.Append("\r\n" + "Response.Clear(); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Disposition\", \"attachment; filename = \" + HttpUtility.UrlEncode(file.Name)); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Length\", file.Length.ToString()); ");
                //strCodeForCs.Append("\r\n" + "Response.ContentType = \"application/octet-stream\"; ");
                //strCodeForCs.Append("\r\n" + "Response.WriteFile(file.FullName); ");
                //strCodeForCs.Append("\r\n" + "Response.End();");
                //strCodeForCs.Append("\r\n" + "return true;");
                //strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GenExportExcel()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == true)
            {
                return GenExportExcel4SetExportFld();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //����ר�����ڵ���Excel ����ش���
                strCodeForCs.Append("\r\n /// <summary>");
                
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                        objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}��Ϣ����.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                List<string> arrColHead = new List<string>();
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    string strColHead = objExcelExportRegionFldsEx.ColCaption;
                    if (arrColHead.Contains(strColHead) == false)
                    {
                        arrColHead.Add(strColHead);
                    }
                    else
                    {
                        string strMsg = string.Format("����Excelʱ,��ͷ�ظ�!�ظ���ͷ:[{0}({2})].(In {1})",
                            strColHead, clsStackTrace.GetCurrClassFunction(),
                            objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName);
                        throw new Exception(strMsg);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = {0}GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���ݳ���,����ϵ����Ա!����:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "  try");
                strCodeForCs.Append("\r\n" + "  {");
                strCodeForCs.Append("\r\n" + "//�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007,���Ի�����һ����䡣");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + " catch (Exception objException)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);");
                
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException2)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"����Excel����,����ϵ����Ա!����:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException2.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenbtnDelete4Gv_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnDelete4Gv_Click4OneKeyword(objViewInfoENEx, bolIsUseWuc4Gv);
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///ɾ����ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "{0}_DelRecord({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "seErrMessage = objException.Message;");
                    strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

  
        public string GetAllCheckedKeysFromGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���б��л�ȡ����ѡ��Ĺؼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>��������ѡ��Ĺؼ����б�</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private List<{0}> GetAllCheckedKeysFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetAllCheckedKeysFromGv(gv{1},{0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetAllCheckedKeysFromGv", "û��ѡ���¼, ��ѡ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return null;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "return lst{0};",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{0}> arr{1}Lst = new List<{0}>();",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                        strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");
                        strCodeForCs.AppendFormat("\r\n" + "foreach (string str{0} in lst{0})",
                       objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(lst{1}[0]);",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                       objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + " arr{0}Lst.Add({1});",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                            objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.AppendFormat("\r\n" + "return arr{0}Lst;",
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GetAllCheckedKeysFromGv4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���б��л�ȡ����ѡ��Ĺؼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>��������ѡ��Ĺؼ����б�</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public List<{0}> GetAllCheckedKeysFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetAllCheckedItemFromGv(gv{1}, \"chkCheckRec\", {0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetAllCheckedKeysFromGv", "û��ѡ���¼, ��ѡ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "clsCommonJsFunc.Alert(this, \"(errid:{0})û��ѡ���¼,��ѡ����Ч�ı��¼!\");", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return null;");
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "return lst{0};",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{0}> arr{1}Lst = new List<{0}>();",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                        strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");
                        strCodeForCs.AppendFormat("\r\n" + "foreach (string str{0} in lst{0})",
                       objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(str{1});",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                       objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + " arr{0}Lst.Add({1});",
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                            objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.AppendFormat("\r\n" + "return arr{0}Lst;",
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// �������ֻ��һ���ؼ��ֵ�ɾ���¼�
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string GenbtnDelete4Gv_Click4OneKeyword(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///ɾ����ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExamTypeId = GetAllCheckedKeysFromGv();
                    //if (lstExamTypeId == null) return;
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         ClsName4WucTabName4Gv());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "{0}_DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string   strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "ɾ����¼���ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);                     
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelete4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelete4Gv_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(vsobj{2}Cond);",
                            objViewInfoENEx.TabName, ClsName4WucTabName4Gv(), objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

     

        public string GenbtnUpdate4Gv_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnUpdate4Gv_Click4OneKeyword(objViewInfoENEx, bolIsUseWuc4Gv);
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///�޸ĵ�ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                    clsViewInfoBLEx.KeyFldNameLstStrWithQuote(objViewInfoENEx), objViewInfoENEx.TabName);


                    strCodeForCs.Append("\r\n" + "if (lstKeyValue.Count == 0) ");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdate4Gv_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");
                    int intKeyIndex = 0;
                    strCodeForCs.Append("\r\n" + "string[] strKeys = lstKeyValue[0].Split(',');");

                    foreach (clsPrjTabFldENEx objKeyPrjTabFld in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(strKeys[{1}]);",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex, objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        intKeyIndex++;
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdate4Gv_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                            objViewInfoENEx.TabName);
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GetFirstCheckedKeyFromGv()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���б��л�ȡѡ��ĵ�һ���ؼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>����ѡ��ĵ�һ���ؼ���</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private {0} GetFirstCheckedKeyFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetFirstCheckedKeyFromGv", "û��ѡ���¼, ��ѡ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.Append("\r\n" + "return 0;");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(lst{1}[0]);",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + " return {0};",
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GetFirstCheckedKeyFromGv4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���б��л�ȡѡ��ĵ�һ���ؼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("/// <returns>����ѡ��ĵ�һ���ؼ���</returns>");
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public {0} GetFirstCheckedKeyFromGv()",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{2} = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                            clsViewInfoBLEx.KeyFldNameLstStrWithEntityConst(objViewInfoENEx),
                            objViewInfoENEx.TabName,
                            objKeyField.ObjFieldTabENEx.FldName_FstUcase);


                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0}.Count == 0) ",
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetFirstCheckedKeyFromGv", "û��ѡ���¼, ��ѡ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "clsCommonJsFunc.Alert(this, \"(errid:{0})û��ѡ���¼,��ѡ����Ч�ı��¼!\");", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.Append("\r\n" + "return 0;");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = lst{1}[0];",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            break;
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(lst{1}[0]);",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + " return {0};",
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnUpdate4Gv_Click4OneKeyword(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///�޸ĵ�ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");
                    //string strExamTypeId = GetFirstCheckedKeyFromGv();
                    //if (string.IsNullOrEmpty(strExamTypeId) == true) return;
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 ClsName4WucTabName4Gv());

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return;",
                                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                        case "int":
                        case "long":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 ClsName4WucTabName4Gv());

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return;",
                          objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                    }

                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdate4Gv_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                            objViewInfoENEx.TabName);
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnSetExportExcel4User_Click()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == false)
            {
                return "";
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���õ�ǰ�û���Excel�����ֶ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");


                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnSetExportExcel4User_Click(object sender, EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\"ViewName = '{" + "0" + "}'\", vsViewName);//��ǰ����");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And TabName = '{" + "0" + "}'\", vsTabName);//��ǰ������ʹ�õı�");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And UserId = '{" + "0" + "}'\", clsCommonSession.UserId);//��ǰ�û�");
                    strCodeForCs.Append("\r\n" + "//����������ȡExcel����Id");
                    strCodeForCs.Append("\r\n" + "string strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());");
                    strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                      objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetMaxStrId_S", "��ϵͳ��û�н���Ϊ{0},���� = {1},�����û� = {2}�ĵ���Excel�û�����,���ȵ���һ��Excel,�ٲ��п������Ա��ϵ!", "���ɴ���");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "sbMsg.AppendFormat(\"(errid:{0})��ϵͳ��û�н���Ϊ[{{0}}]\", vsViewName);", strErrId, "{", "}");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\",���� = '{" + "0" + "}'\", vsTabName);");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"�����û� = '{" + "0" + "}'�ĵ���Excel�û�����,���ȵ���һ��Excel,�ٲ��п������Ա��ϵ!\", clsCommonSession.UserId);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, sbMsg.ToString());");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//��������Excel�ֶν����������");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbScript = new StringBuilder();");

                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"<script language = 'javascript'>\");");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"window.open('\");");
                    strCodeForCs.Append("\r\n" + "sbScript.AppendFormat(\"../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users = {" + "0" + "}\", strid_ExportExcel4Users);");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"','_blank', 'left = 50px,top = 50px,status = no,width = 920px,height = 650px,scrollbars = yes'); </script>\");");
                    strCodeForCs.Append("\r\n" + "Page.ClientScript.RegisterStartupScript(this.GetType(), \"����Excel�ֶ�����\", sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "// Response.Write(sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ɸ������SESSION������Ժ���
        /// </summary>
        /// <returns></returns>
        public string GenParentObjSeesionProp()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.IsTabForeignKey() == true)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                        objQryRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "protected string {0}",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = (string)Session[\"{0}\"];",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null) ",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = \"\";",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.AppendFormat("\r\n" + "return str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = value;",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"{0}\", str{0});",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");

                    }
                }
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ������ҳ��غ���
        /// </summary>
        /// <returns></returns>
        public string GenJumpPage_RelaFunction(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //strCodeForCs.Append("\r\n ///��1������ҳ����غ���");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��������ҳ����غ���.��GridView�ĽŲ�,��������ת��ťʱ�������¼�,��������Ҫ����:��ת��GridView��ĳһ����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void btnJumpPage_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "TextBox txtJump2Page = (TextBox)pagerRow.FindControl(\"txtJump2Page\");");
                strCodeForCs.Append("\r\n" + "if (txtJump2Page != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if(txtJump2Page.Text.Trim()!= \"\" && ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)>0 && ",
                objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)-1<this.gv{0}.PageCount) ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = int.Parse(txtJump2Page.Text)-1; ",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "} ");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ɸı�GridView��ÿҳ��¼������������غ���
        /// </summary>
        /// <returns></returns>
        public string GenddlPagerRecCount_SelectedIndexChanged(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //strCodeForCs.Append("\r\n ///���ɵĸı�GridView��ÿҳ��¼������������غ���");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView�ĽŲ�,��ÿҳ��¼�������������ı�ʱ�������¼�,��������Ҫ����:�ı�GridView��ÿҳ��¼����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.Append("\r\n" + "protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "DropDownList ddlPagerRecCount = (DropDownList)sender;");
                strCodeForCs.Append("\r\n" + "string strPageSize = ddlPagerRecCount.Text;");
                strCodeForCs.Append("\r\n" + "if (clsDateTime.IsNumeric(strPageSize) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = int.Parse(strPageSize);");
                strCodeForCs.Append("\r\n" + "if (intPageSize >= 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = intPageSize;");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string A_GenCtlControlCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''�ù�����Ҫ���������صĿؼ�����,���������ļ�,;
            //һ���ǿؼ��Ľ����ļ�, ;
            //��һ����֮��صĽ������ļ�;

            this.objViewInfoENEx = objViewInfoENEx;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
           
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "B";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		wuc{0}B ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class wuc{0}B : System.Web.UI.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "#region �ؼ�ҳ����������");

                ///�����û��Զ���ؼ�������Page_Load����;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion �ؼ�ҳ����������");

                //�����ֶ�����
                strTemp = Gen_Wuc_CS_FieldProperty4Edit();
                strCodeForCs.Append(strTemp);

                strCodeForCs.Append("\r\n" + "");
                //���ùؼ������޸�ʱ,Ϊֻ��
                strTemp = Gen_Wuc_CS_SetKeyReadOnly();
                strCodeForCs.Append(strTemp);
                //����û��Զ���ؼ���,���пؼ���ֵ
                strTemp = Gen_Wuc_CS_Clear();
                strCodeForCs.Append(strTemp);

                //У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strTemp = Gen_Wuc_CS_IsValid();
                strCodeForCs.Append(strTemp);

                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strTemp = Gen_Wuc_CS_SetDefaultValue();
                strCodeForCs.Append(strTemp);

                //���ɽ������������BIND����,������������б���ĺ���;
                //strTemp = GenDdlBindFunction();
                //strCodeForCs.Append(strTemp);
                //���ɿؼ����������BIND����, �����������;
                strTemp = Gen_Wuc_CS_SetDdl_FldName();
                strCodeForCs.Append(strTemp);
                
               strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''�ù�����Ҫ���������صĿؼ�����,���������ļ�,;
            //һ���ǿؼ��Ľ����ļ�, ;
            //��һ����֮��صĽ������ļ�;

            this.objViewInfoENEx = objViewInfoENEx;
            //if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strViewName = objViewInfoENEx.ViewName;
            //    sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.GridRegion_0002);


            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = ClsName4WucTabName4Gv();

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx.cs", ClsName4WucTabName4Gv());
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} ��ժҪ˵����", ClsName4WucTabName4Gv());
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.UserControl", ClsName4WucTabName4Gv());
                strCodeForCs.Append("\r\n" + "{");
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ��GridView��,����[�޸�]��ťʱ,���������޸��¼�");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvUpdateClick GvUpdateClick;");
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "        /// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ��GridView��,����[ɾ��]��ťʱ,���������޸��¼�");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvDeleteClick GvDeleteClick;");
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "        /// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ��GridView��,����[��ϸ��Ϣ]��ťʱ,���������޸��¼�");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvDetailClick GvDetailClick;");
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "        /// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ��GridView��,����[ѡ��]��ťʱ,���������޸��¼�");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "public event OnGvSelectClick GvSelectClick;");
                }
                strCodeForCs.Append("\r\n" + "#region �ؼ�ҳ����������");

                ///�����û��Զ���ؼ�������Page_Load����;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion �ؼ�ҳ����������");

                ///���ɸ��ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,����ʾ��GridView��;
                strTemp = GenBindGridView4Wuc();
                strCodeForCs.Append(strTemp);

                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + GenJumpPage_RelaFunction(objViewInfoENEx, true));
                    /// ���ɸı�GridView��ÿҳ��¼������������غ���
                    strCodeForCs.Append("\r\n" + GenddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, true));

                }

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView���н����¼�����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel
                && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }

                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView��ҳ�Ÿı��¼�����
                    strTemp = Gen_GridView_PageIndexChanging(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                { 
                    //GridView�����޸��¼�����
                    strTemp = Gen_GridView_RowUpdating(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);

                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    //GridView����ɾ���¼�����
                    strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
                {
                    //GridView����ɾ���¼�����
                    strTemp = Gen_GridView_RowDetailing(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
                {
                    //GridView����ɾ���¼�����
                    strTemp = Gen_GridView_RowSelecting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                // ����ר�����ڼ�¼GridView�е�ÿҳ��¼��
                strCodeForCs.Append("\r\n" + GenPageSizeViewState());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_PageIndex());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_PageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_RecCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + GenGetPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "#region ������غ���");

                ///������GridView������صĴ���;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_GridView_Sorting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#endregion ������غ���");
                strTemp = Gen_vsWhereCond();

                strCodeForCs.Append(strTemp);

                // ���ɴ�����Ϣ��SESSION������Ժ���
                strCodeForCs.Append("\r\n" + Gen_vsCondObject());
                strCodeForCs.Append("\r\n" + GenErrMessageSession());
                // ���ɷ������ӵ�SESSION������Ժ���
                strCodeForCs.Append("\r\n" + GenBackLinkStrSession());

                strCodeForCs.Append("\r\n" + Gen_SetGvVisibility_AllShow());
                strCodeForCs.Append("\r\n" + Gen_SetGvVisibility_AllHide());
                strCodeForCs.Append("\r\n" + Gen_SetGvVisibility());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetVisible());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + GetAllCheckedKeysFromGv4Wuc());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + GetFirstCheckedKeyFromGv4Wuc());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetCheckedItemForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetCheckedItemsForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_chkSelAll_CheckedChanged());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_SetSortBy());
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ר��������ʾ��ӡ�ı�ؼ��ؼ������
        /// </summary>
        /// <returns></returns>
        public string A_GenCtlControlCodeforTab_Disp(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''�ù�����Ҫ���������صĿؼ�����,���������ļ�,;
            //һ���ǿؼ��Ľ����ļ�, ;
            //��һ����֮��صĽ������ļ�;
            this.objViewInfoENEx = objViewInfoENEx;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "B";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B_Disp.ascx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;


            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		wuc{0} ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class wuc{0}_Disp : System.Web.UI.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "#region �ؼ�ҳ����������");

                ///�����û��Զ���ؼ�������Page_Load����;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion �ؼ�ҳ����������");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}",
                      objEditRegionFldsEx.LabelCaption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");

                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;

                        case "DropDownList": ///����ؼ���������;
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == true)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = 1;",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = 2;",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {


                                //string strDS_DataValueField;
                                //string strDS_DataTextField;
                                string strDsTabName;
                                try
                                {
                                    strDsTabName = clsEditRegionFldsBLEx.InitDsTabName4Get(objEditRegionFldsEx);
                                }
                                catch (Exception objException)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ��������:{2}.",
                                    objViewInfoENEx.ViewName, "�༭����", objException.Message);
                                    throw new Exception(sbMsg.ToString());
                                }
                                //try
                                //{
                                //    strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                                //}
                                //catch (Exception objException)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3}.",
                                //    objViewInfoENEx.ViewName, "�༭����", objException.Message, strDsTabName);
                                //    throw new Exception(sbMsg.ToString());
                                //}

                                //try
                                //{
                                //    strDS_DataTextField = clsEditRegionFldsBLEx.InitDs_DataTextField(objEditRegionFldsEx);
                                //}
                                //catch (Exception objException)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3},ֵ�ֶ���Ϊ:{4}.",
                                //    objViewInfoENEx.ViewName, "�༭����", objException.Message, strDsTabName, strDS_DataValueField);
                                //    throw new Exception(sbMsg.ToString());
                                //}


                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == \"\")");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = \"0\";",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                //strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = new cls{1}EN(value, true).{2};",
                                //objEditRegionFldsEx.FldName,
                                //objEditRegionFldsEx.CodeTab,
                                //strDS_DataTextField);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "HyperLink":
                            break;

                        case "Image":
                            break;

                        case "ImageButton":
                            break;

                        case "Label":
                            break;

                        case "Link1Button":
                            break;

                        case "ListBox":
                            break;

                        case "Panel":
                            break;

                        case "RadioButton":
                            break;

                        case "RadioButtonList":
                            break;

                        case "TextBox": ///����ؼ��������ı���;
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = value.ToString();", objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "lbl{0}_Disp.Text = value.ToString();", objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");

                }
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



     
        public string GenDdlBindFunction4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                if ((mbolIsUseCtl == false))
                {
                    ///������ȡ���ݴ�������:private void PutDataToClass;
                }
                else
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                        {
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdlTrueAndFalse(ddl{0}_q);",
                                //            objQryRegionFldsEx.FldName);
                            }
                            else
                            {
                                //string strDS_DataValueField;
                                //string strDS_DataTextField;
                                string strDsTabName;
                                try
                                {
                                    strDsTabName = clsQryRegionFldsBLEx.DsTabName4Get(objQryRegionFldsEx);
                                }
                                catch (Exception objException)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ��������:{2}.",
                                    objViewInfoENEx.ViewName, "��ѯ����", objException.Message);
                                    throw new Exception(sbMsg.ToString());
                                }
                                if (string.IsNullOrEmpty(strDsTabName) == true)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ����Դ����Ϊ��,����!({2}).",
                                    objViewInfoENEx.ViewName, "��ѯ����", clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(sbMsg.ToString());
                                }
                                //try
                                //{
                                //    strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                                //}
                                //catch (Exception objException)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3}.",
                                //    objViewInfoENEx.ViewName, "��ѯ����", objException.Message, strDsTabName);
                                //    throw new Exception(sbMsg.ToString());
                                //}
                                //if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����.<br/>����Դ����Ϊ:{2}.({3})",
                                //        objViewInfoENEx.ViewName, "��ѯ����", strDsTabName,
                                //        clsStackTrace.GetCurrClassFunction());
                                //    throw new Exception(sbMsg.ToString());
                                //}
                                //try
                                //{
                                //    strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                                //}
                                //catch (Exception objException)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3},ֵ�ֶ���Ϊ:{4}.",
                                //    objViewInfoENEx.ViewName, "��ѯ����", objException.Message, strDsTabName, strDS_DataValueField);
                                //    throw new Exception(sbMsg.ToString());
                                //}
                                //if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                                //{
                                //    StringBuilder sbMsg = new StringBuilder();
                                //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����.<br/>����Դ����Ϊ:{2},ֵ�ֶ���Ϊ:{3}.({4})",
                                //          objViewInfoENEx.ViewName, "��ѯ����", strDsTabName, strDS_DataValueField,
                                //          clsStackTrace.GetCurrClassFunction());
                                //    throw new Exception(sbMsg.ToString());
                                //}
                                switch (objQryRegionFldsEx.DdlItemsOptionId)
                                {
                                    case "01": ///�б��;
                                        //									string strTemp2 ;
                                        string delimStr = " ,.:";
                                        char[] delimiter = delimStr.ToCharArray();
                                        //									string words = "one two,three:four.";
                                        string[] split = null;
                                        int iItemNums;
                                        int i;
                                        strCodeForCs.Append("\r\n /// <summary>");
                                        strCodeForCs.AppendFormat("\r\n ///��������:ddl{0}�ĺ�����", objQryRegionFldsEx.FldName);
                                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                        strCodeForCs.Append("\r\n /// </summary>");

                                        strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                            objQryRegionFldsEx.FldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                        split = objQryRegionFldsEx.ItemsString.Split(delimiter);
                                        iItemNums = split.GetUpperBound(0);
                                        for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                        }
                                        strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                        strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                        strCodeForCs.Append("\r\n" + "//Ϊ�������������ݵ�����,����������б�����ֱ����ӵ�");
                                        strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"��\");");
                                        strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"Ů\");");
                                        strCodeForCs.Append("\r\n" + "}");
                                        break;
                                    case "02": ///�б�������Դ��;

                                        strCodeForCs.Append("\r\n" + "/// <summary>");
                                        strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                                          strDsTabName);
                                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                        strCodeForCs.Append("\r\n" + "/// </summary>");
                                        strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable</returns>");
                                        strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()",
                                        objQryRegionFldsEx.FldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");

                                        //try
                                        //{
                                        //    if (objQryRegionFldsEx.DsCondStr.Trim() == "")
                                        //    {
                                        //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                                        //        strDS_DataValueField, strDS_DataTextField, strDsTabName);
                                        //    }
                                        //    else
                                        //    {
                                        //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";",
                                        //        strDS_DataValueField, strDS_DataTextField, strDsTabName, objQryRegionFldsEx.DsCondStr);
                                        //    }
                                        //}
                                        //catch (Exception objException)
                                        //{
                                        //    StringBuilder sbMsg = new StringBuilder();
                                        //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������:{2}�������ִ���,���ڸ�������ɾ�����ֶ�. ����Դ����:{3}, ����Դֵ�ֶ���:{4},����Դ�ı��ֶ���:{5}.������Ϣ:[{6}]",
                                        //    objViewInfoENEx.ViewName, "��ѯ����", strDS_DataValueField, strDsTabName, strDS_DataValueField, strDS_DataTextField,
                                        //    objException.Message);
                                        //    throw new Exception(sbMsg.ToString());
                                        //}
                                        //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", objViewInfoENEx.TabName);

                                        strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                                        strCodeForCs.Append("\r\n" + "return objDT;");
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n /// <summary>");
                                        strCodeForCs.Append("\r\n /// �󶨻���Web��������");
                                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                        strCodeForCs.Append("\r\n /// </summary>");
                                        strCodeForCs.Append("\r\n /// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");

                                        strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                                        strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                        strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                        objQryRegionFldsEx.FldName);
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};",
                                        //  strDsTabName, strDS_DataValueField);
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};",
                                        //  strDsTabName, strDS_DataTextField);
                                        strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                        strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                        strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                        strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                        strCodeForCs.Append("\r\n" + "}");
                                        break;
                                    case "03": ///�б�������ԴSQL��;
                                        strCodeForCs.Append("\r\n" + "/// <summary>");
                                        strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,��Sql��:[{0}]�л�ȡ",
                                           objQryRegionFldsEx.DsSqlStr);
                                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                        strCodeForCs.Append("\r\n" + "/// </summary>");
                                        strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�Զ����Sql�������е����м�¼��¼��DataTable</returns>");

                                        strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                        objQryRegionFldsEx.FldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                                        //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", objViewInfoENEx.TabName);

                                        strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                        objQryRegionFldsEx.DsSqlStr);
                                        strCodeForCs.Append("\r\n" + "return objDT;");
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n /// <summary>");
                                        strCodeForCs.Append("\r\n /// �󶨻���Web��������");
                                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                        strCodeForCs.Append("\r\n /// </summary>");
                                        strCodeForCs.Append("\r\n /// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");

                                        strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                                        strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                        strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                        objQryRegionFldsEx.FldName);
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};",
                                        //  strDsTabName, strDS_DataValueField);
                                        //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};",
                                        //  strDsTabName, strDS_DataTextField);
                                        strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                        strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                        strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                        strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                        strCodeForCs.Append("\r\n" + "}");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenDdlBindFunction4Page_Load()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetDdl{1}();",
                            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdlTrueAndFalse(ddl{0}_q);",
                                        objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դֵ�ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ�ı��ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}

                            //strCodeForCs.AppendFormat("\r\n" + "{2}_BindDdl_{0}(ddl{1}_q);",
                            //        objFieldTab_ValueField.FldName,
                            //        objQryRegionFldsEx.FldName,
                            //        objPrjTabEN_CodeTab.TabName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        ///�����ļ��ؼ��Ŀ��Ʋ����;
        public string GenFileCtlControlCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = "wuc" + objViewInfoENEx.TabName + "OptFile";

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "OptFile.ascx.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;

            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlCsFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		wuc{0} ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class wuc{0} : System.Web.UI.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "#region �ؼ�ҳ����������");

                ///�����û��Զ���ؼ�������Page_Load����;
                strTemp = GenPage_LoadCode4Wuc();
                strCodeForCs.Append(strTemp);
                strCodeForCs.Append("\r\n" + "#endregion �ؼ�ҳ����������");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.IsIdentity == false
                    || objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                        objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///����ؼ���������;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue == \"0\")",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///����ؼ��������ı���;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;

                            default:
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                        break;
                    }
                }
                strCodeForCs.Append("\r\n" + "");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                    strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", "txt" + objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.ObjFieldTabENEx.IsIdentity == false
                    || objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                    objEditRegionFldsEx.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                    objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                objEditRegionFldsEx.CtrlId);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;

                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                 objEditRegionFldsEx.CtrlId, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                ///У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ��;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "DateTime" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "double" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "single")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ComValid_{0}.Validate();",
                        objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (!ComValid_{0}.IsValid) return false;",
                        objEditRegionFldsEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                ///���øÿؼ��ڲ���״̬�µ�ȱʡֵ;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n ///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n ///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.IsIdentity == false
                    || objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                objEditRegionFldsEx.CtrlId);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                    objEditRegionFldsEx.CtrlId, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                           objEditRegionFldsEx.CtrlId, strInitValue);
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                ///��ȡ��ǰ���ڵ��ַ����Լ���ȡ��ǰ�µ��ַ���;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����:��ȡ��ǰ���ڵ��ַ���");
                strCodeForCs.Append("\r\n /// ���ڸ�ʽ:");
                strCodeForCs.Append("\r\n /// ���ڵ��ַ����ĸ�ʽ������:");
                strCodeForCs.Append("\r\n ///		1��YYYYMMDD��	����20050120");
                strCodeForCs.Append("\r\n ///		2��YYYY-MM-DD	����2005-01-20");
                strCodeForCs.Append("\r\n ///		3��YYYY/MM/DD	����2005/01/20");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"intFormat\">���ڸ�ʽ,����3��,�������0,1,2");
                strCodeForCs.Append("\r\n ///							������ͬ,��������ֵ�Ͳ�ͬ,");
                strCodeForCs.Append("\r\n ///							�μ���������ڸ�ʽ");
                strCodeForCs.Append("\r\n ///	</param>");
                strCodeForCs.Append("\r\n /// <returns>���ص�ǰ���ڵ��ַ���</returns>");
                strCodeForCs.Append("\r\n" + "public string getTodayStr(int intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strToday;");
                strCodeForCs.Append("\r\n" + "string strYear, strMonth, strDay;");
                strCodeForCs.Append("\r\n" + "int intYear, intMonth, intDay;");
                strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
                strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
                strCodeForCs.Append("\r\n" + "intDay = System.DateTime.Today.Day;");
                strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "if (intDay>9) strDay = intDay.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "else strDay = \"0\" + intDay.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
                strCodeForCs.Append("\r\n" + "switch(intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case 0:");
                strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 1:");
                strCodeForCs.Append("\r\n" + "strToday = strYear + \"-\" + strMonth + \"-\" + strDay;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 2:");
                strCodeForCs.Append("\r\n" + "strToday = strYear + \"/\" + strMonth + \"/\" + strDay;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strToday;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����:��ȡ��ǰ�µ��ַ���");
                strCodeForCs.Append("\r\n /// �µĸ�ʽ:");
                strCodeForCs.Append("\r\n /// �µ��ַ����ĸ�ʽ������:");
                strCodeForCs.Append("\r\n ///		1��YYYYMM��	����200501");
                strCodeForCs.Append("\r\n ///		2��YYYY-MM-DD	����2005-01");
                strCodeForCs.Append("\r\n ///		3��YYYY/MM/DD	����2005/01");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"intFormat\">�µĸ�ʽ,����3��,�������0,1,2");
                strCodeForCs.Append("\r\n ///							������ͬ,��������ֵ�Ͳ�ͬ,");
                strCodeForCs.Append("\r\n ///							�μ�������µĸ�ʽ");
                strCodeForCs.Append("\r\n ///	</param>");
                strCodeForCs.Append("\r\n /// <returns>���ص�ǰ�µ��ַ���</returns>");
                strCodeForCs.Append("\r\n" + "public string getCurrMonth(int intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCurrMonth;");
                strCodeForCs.Append("\r\n" + "string strYear, strMonth;");
                strCodeForCs.Append("\r\n" + "int intYear, intMonth;");
                strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
                strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
                strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
                strCodeForCs.Append("\r\n" + "switch(intFormat)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case 0:");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 1:");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"-\" + strMonth;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case 2:");
                strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"/\" + strMonth;");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strCurrMonth;");
                strCodeForCs.Append("\r\n" + "}");
                ///���ɽ������������BIND����,������������б���ĺ���;
                strTemp = GenDdlBindFunction();
                strCodeForCs.Append(strTemp);
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.AppendFormat("\r\n" + "/// ���ð�������,����ֶ�:[{0}]",
                          objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "public void SetDdl{0}()", objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_{0}({1});",
                        objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenPrivateVarCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///����˽�д���;
                strCodeForCs.Append("����˽�д���for C#");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    /// strCodeForCs.Append("\r\n" + objEditRegionFldsEx.objPrjTabFldENEx.CsType + " " + objEditRegionFldsEx.DataTypeAbbr + objEditRegionFldsEx.FldName + " = new " + objEditRegionFldsEx.objPrjTabFldENEx.CsType);
                    strCodeForCs.Append("\r\n" + objEditRegionFldsEx.ObjFieldTabENEx.CsType() + " " + objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr + objEditRegionFldsEx.FldName + ";");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc_CS_SetDdl_FldName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///����˽�д���;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            strCodeForCs.Append("\r\n" + "/// <summary>");
                            strCodeForCs.AppendFormat("\r\n" + "/// ���ð�������,����ֶ�:[{0}]",
                              objEditRegionFldsEx.FldName);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n" + "/// </summary>");
                            strCodeForCs.AppendFormat("\r\n" + "public void SetDdl{0}()",
                           objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdlTrueAndFalse(ddl{0});",
                                        objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + "/// <summary>");
                            strCodeForCs.AppendFormat("\r\n" + "/// ���ð�������,����ֶ�:[{0}]",
                              objEditRegionFldsEx.FldName);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n" + "/// </summary>");
                            strCodeForCs.AppendFormat("\r\n" + "public void SetDdl{0}()",
                            objEditRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{2}_BindDdl_{0}({1});",
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabCode,
                            objEditRegionFldsEx.CtrlId,
                            objEditRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                            strCodeForCs.Append("\r\n" + "}");
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_SetDefaultValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1����������;�Ĭ��Ϊ0��");
                strCodeForCs.Append("\r\n ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��");
                strCodeForCs.Append("\r\n ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�");
                strCodeForCs.Append("\r\n ///		4�������λ(bit)�;�Ĭ��Ϊfalse;");
                strCodeForCs.Append("\r\n ///		��ЩĬ��ֵ���������޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "DropDownList": ///����ؼ���������;
                            strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                            objEditRegionFldsEx.CtrlId);
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox": ///����ؼ��������ı���;
                            if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                objEditRegionFldsEx.CtrlId, strInitValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                           objEditRegionFldsEx.CtrlId, strInitValue);
                            break;

                    }

                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_IsValid()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///����˽�д���;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�");
                strCodeForCs.Append("\r\n /// һ�����:");
                strCodeForCs.Append("\r\n ///		1������У������:���͡������͡������͵�,");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		2��У����ֵ,�����ֵ����Сֵ��");
                strCodeForCs.Append("\r\n ///			��Щ�������Զ����ɴ����������");
                strCodeForCs.Append("\r\n ///		��Щ�������ݿ����޸�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DropDownList_06) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "long" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "DateTime" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "double" ||
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "single")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ComValid_{0}.Validate();",
                        objEditRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (!ComValid_{0}.IsValid) return false;",
                        objEditRegionFldsEx.FldName);
                    }
                }
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                        case "short":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text) == false)",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text) == false)",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ�ĸ�����!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text) == false)",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"��������ȷ��������!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc_CS_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ���,���пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                objEditRegionFldsEx.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                objEditRegionFldsEx.CtrlId,
                                objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                            }
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "DropDownList": ///����ؼ���������;
                            strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                            objEditRegionFldsEx.CtrlId);
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox": ///����ؼ��������ı���;
                            if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                objEditRegionFldsEx.CtrlId, strInitValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = {1};",
                                  objEditRegionFldsEx.CtrlId, strInitValue);
                            break;
                    }

                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_SetKeyReadOnly()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.FldName
                         == objKeyField.ObjFieldTabENEx.FldName)
                        {
                            strCodeForCs.Append("\r\n" + "/// <summary>");
                            strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ���,���ùؼ��ֵ�ֵ,�Ƿ�ֻ��");
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n" + "/// </summary>");
                            strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                            strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Wuc_CS_FieldProperty4Edit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///����˽�д���;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ�Ϊ��ʶ�����;����ɸ��ֶοؼ�,����Ͳ�����;
                    ///
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}",
                    objEditRegionFldsEx.LabelCaption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");

                    strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                            objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;

                        case "DropDownList": ///����ؼ���������;
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex == 1)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "return true;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "return false;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == true)");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "int"
                            || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bigint"
                            || objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "short"
                           )
                            {
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue == \"0\")",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "return 0;");
                                strCodeForCs.AppendFormat("\r\n" + "return {1}.Parse({0}.SelectedValue);",
                                objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.ObjFieldTabENEx.CsType());
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == 0)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue == \"0\")",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "if (value == \"\")");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "HyperLink":
                            break;

                        case "Image":
                            break;

                        case "ImageButton":
                            break;

                        case "Label":
                            break;

                        case "Link1Button":
                            break;

                        case "ListBox":
                            break;

                        case "Panel":
                            break;

                        case "RadioButton":
                            break;

                        case "RadioButtonList":
                            break;

                        case "TextBox": ///����ؼ��������ı���;
                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                            {
                                case "int":
                                    strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "short":
                                    strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "double":

                                    strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "DateTime":

                                    strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "bool":
                                    strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "float":
                                    strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "long":
                                    strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:

                            strCodeForCs.Append("\r\n" + "get");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                            {
                                case "int":
                                    strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "short":
                                    strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;

                                case "double":
                                    strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "DateTime":
                                    strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "bool":
                                    strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "float":
                                    strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                case "long":
                                    strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId);
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "set");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");

                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        protected string GenProtectedVarNameList()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɲ�ѯ���������ÿؼ�����;
                //strCodeForCs.Append("\r\n ///���ɿ��Ʋ�Ŀؼ��������б�");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }
        protected string GenRefDomainName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Configuration;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.Text;");
                strCodeForCs.Append("\r\n" + "using System.Web;");
                strCodeForCs.Append("\r\n" + "using System.Web.Security;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls.WebParts;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.HtmlControls;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");

                strCodeForCs.Append("\r\n" + "using Newtonsoft.Json;"); //

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}4WApi;", objProject.PrjDomain);
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }
     
      
        public string GenTransDataBetweenViewAndClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///����ɾ����¼����;
                strCodeForCs.Append("///���ɴ��߼���<-->���������ݴ��亯������");
                if ((mbolIsUseCtl == false))
                {
                    ///������ȡ���ݴ�������:protected void GetDataFromClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ".ToString();");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ";");
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    ///������ȡ���ݴ�������:protected void PutDataToClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "if (txt{0}.Text.Trim() == \"\")", objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = 0;", objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = int.Parse(" + objEditRegionFldsEx.CtrlId + ".Text);");
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = " + objEditRegionFldsEx.CtrlId + ".Text;");
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        ///�����޸ļ�¼����;
        public string GenUpdateRecCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///�����޸ļ�¼����;
                strCodeForCs.Append("\r\n ///�����޸ļ�¼����");
                strCodeForCs.Append("\r\n ///����һ��������޸ļ�¼�Ĵ���,�����߼���̫��,");
                strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//2����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//3��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.Append("\r\n" + "//1����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//2����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.CheckProperty(ref strResult) == false)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strResult);");
                strCodeForCs.Append("\r\n" + "return ; ");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3��������ʵ���������޸�ͬ�������ݿ���");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Update() == false) ", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update", "�޸ļ�¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})�޸ļ�¼���ɹ�!\";", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"�޸ļ�¼���ɹ�!\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"�޸ļ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"�޸ļ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

       

        //���ɲ����¼׼�����̴���
        public string GenAddRecordCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //���ɵĲ����¼׼�����̴���for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�����¼��׼������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}Record()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(false);",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ�����\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ�����\";",
                objViewInfoENEx.TabName);

                //��ȡ���ֵ
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = {0}GetMaxStrId_S();",
                objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();",
                            objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //���ɲ����¼���̹��̴���
        public string GenAddRecordSaveCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //�����¼���̹��̴���for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����¼���̵����ݱ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>�����¼�Ƿ�ɹ���</returns>");

                strCodeForCs.AppendFormat("\r\n" + "protected bool Add{0}RecordSave()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.Append("\r\n" + "//3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.AppendFormat("\r\n" + "if (!wuc{0}B1.IsValid(ref strResult))",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
             objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "�ؼ��������������Ͳ���ȷ����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})�ؼ��������������Ͳ���ȷ����!\";", strErrId);
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}EN obj{1}EN;	//�������", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("wuc{0}B1.", objViewInfoENEx.TabName), objViewInfoENEx);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN({2});	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                }
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "//3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("obj{0}EN.", objViewInfoENEx.TabName), objViewInfoENEx);
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.Append("\r\n" + "");

                        strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,����Ҫ��������Ƿ��Ѿ�����,�����ʱ,�ٻ�ȡ ���ֵ��Ϊ����");
                        strCodeForCs.AppendFormat("\r\n" + "//if ({0}_IsExist({1}))	//�ж��Ƿ�����ͬ�Ĺؼ���",
                            objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                        strCodeForCs.Append("\r\n" + "//{");
                        strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                            objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "�ؼ����ֶ�������ͬ��ֵ", "���ɴ���");

                        strCodeForCs.AppendFormat("\r\n" + "//strMsg = \"(errid:{0})�ؼ����ֶ�������ͬ��ֵ\";", strErrId);

                        strCodeForCs.Append("\r\n" + "//clsCommonJsFunc.Alert(this, strMsg);");
                        strCodeForCs.Append("\r\n" + "//return false;");
                        strCodeForCs.Append("\r\n" + "//}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}_IsExist({1}))	//�ж��Ƿ�����ͬ�Ĺؼ���",
                    objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                        strCodeForCs.Append("\r\n" + "{");


                        strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                            objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "�ؼ����ֶ�������ͬ��ֵ", "���ɴ���");

                        strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})�ؼ����ֶ�������ͬ��ֵ\";", strErrId);

                        strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);

                string strDuplicateInfo = "";
                bool bolIsFirst = true;
                //���Ψһ��------------------------------------------------------
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.IsTabUnique() == true
                    && objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})",
                                  objEditRegionFldsEx.LabelCaption,
                                objEditRegionFldsEx.FldName);
                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})",
                              objEditRegionFldsEx.LabelCaption,
                               objEditRegionFldsEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n ///5.2�����Ψһ��");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"({0})�����ظ�!\";",
                           strDuplicateInfo);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //���Ψһ�� == == == == == == == == == == == == == == == == == == == == == == == == 

              
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,���������ʱ,�Զ���ȡ����ֵ��");
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || {0}_IsExist({2}) == true)",
                        objMainPrjTab.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = {0}GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + " }");
                }
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "��Ӽ�¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})��Ӽ�¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"��Ӽ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"��Ӽ�¼�ɹ�!\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.Clear();		//��տؼ�������",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n ///�ָ�<ȷ�����>���<���>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"���\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���༭\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "return true;");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

      
        //�����޸ļ�¼׼�����̴���
        public string GenUpdateRecordCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //�����޸ļ�¼׼�����̴��� for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�޸ļ�¼��׼������,�Ѹ����ؼ��ֵļ�¼�ֶ�ֵ��ʾ���û��ؼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void Update{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "//��������:(�ܹ�2��)");
                strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���޸�\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //����ɾ����¼���̴���
        public string GenDelRecordCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {                
                //ɾ����¼���̴���for C#"
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ݸ����ؼ���ɾ����¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����ؼ���</param>", objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.AppendFormat("\r\n" + "protected void Delete{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName   );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}_DelRecord({1});",
                objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "ɾ����¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
                //strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //����GridViewҳ�ŷ����仯ʱ���¼�����
        public string Gen_GridView_PageIndexChanging(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɲ����¼����;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,�ڸ���GridView�ĵ�ǰҳ����ʱ�����ĺ�����");
                strCodeForCs.Append("\r\n ///			 ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"source\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_PageIndexChanging(object sender, GridViewPageEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��2��)");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "if (e.NewPageIndex != -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.pageIndex = e.NewPageIndex;",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);",
                        objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                    objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //����GridView�н������¼�����
        public string Gen_GridView_RowCreated()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɲ����¼����;
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,��GeidView�н���ʱ�������¼�,��������Ҫ����:�������д���ɾ��ʱ��ʾ��ʾ��Ϣ,��������ͷ��ʾ�����־��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowCreated(object sender, GridViewRowEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)
                {
                    strCodeForCs.Append("\r\n" + "if (e.Row.RowType == DataControlRowType.DataRow)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "System.Web.UI.WebControls.LinkButton myDeleteButton;");
                    strCodeForCs.Append("\r\n" + "myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl(\"lbDelete\");");
                    strCodeForCs.Append("\r\n" + "if (myDeleteButton != null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "myDeleteButton.Attributes.Add(\"onclick\", \"return confirm('�����Ҫɾ���� \" + (e.Row.RowIndex + 1).ToString() + \" ����');\");");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                }
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)", 
                    //						objViewInfoENEx.TabName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "int intIndex;");
                    strCodeForCs.AppendFormat("\r\n" + "if (vsSort{0}By == \"\") return ;",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strSortEx;");
                    strCodeForCs.AppendFormat("\r\n" + "for(int i = 0;i<this.gv{0}.Columns.Count;i++)",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strSortEx = this.gv{0}.Columns[i].SortExpression;",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "if (strSortEx == \"\") continue;");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(strSortEx + \" \");",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "if(intIndex >= 0) //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "Label lblSort = new Label();");
                    strCodeForCs.Append("\r\n" + "lblSort.Font.Name = \"webdings\";//��������,��\"webdings\"��5��������,6�������ǣ�");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\"Asc\");",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "lblSort.Text = (intIndex>0?\" 5\":\" 6\");//�Ƿ�Ϊ����,����Ϊstring�ͣ�");
                    strCodeForCs.Append("\r\n" + "e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���");
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    //					strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //����GridView��������¼�����
        public string Gen_GridView_RowCommand()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɲ����¼����;
                //        strCodeForCs.Append("\r\n ///����GridView��������¼�����");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,������GeidView���е����ťʱ�������¼�,��������Ҫ����:����ͷ��ʾ����ȫѡ��ťʱȫѡGridView�������С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowCommand(object sender, GridViewCommandEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCommandName = e.CommandName;");
                strCodeForCs.Append("\r\n" + "switch (strCommandName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"lbSelAll\":");
                strCodeForCs.Append("\r\n" + "System.Web.UI.WebControls.LinkButton lbSelAll;");
                strCodeForCs.Append("\r\n" + "lbSelAll = (LinkButton)e.CommandSource;");
                strCodeForCs.Append("\r\n" + "if (lbSelAll.CommandName != \"lbSelAll\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (lbSelAll.Text == \"ȫѡ\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, true);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"��ѡ\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (lbSelAll.Text == \"��ѡ\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"ȫѡ\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"NextPage\":");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.Append("\r\n" + "                    if (vsPageIndex < vsPageCount) vsPageIndex += 1;");
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this.Page, objException.Message);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"PrevPage\":");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.Append("\r\n" + "if (vsPageIndex > 1) vsPageIndex -= 1;");
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}(vsobj{1}Cond);", objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "break;");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //����GridView��ɾ�����¼�����
        public string Gen_GridView_RowDeleting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,������ɾ��(RowDeleting)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowDeleting(object sender, GridViewDeleteEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                    }
                }
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvDeleteClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "};");

                    strCodeForCs.AppendFormat("\r\n" + "GvDeleteClick(this, objEventArgs4Delete);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "Delete{0}Record({1});",
                objViewInfoENEx.TabName,
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //����GridView����ϸ��Ϣ���¼�����
        public string Gen_GridView_RowDetailing(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,��������ϸ��Ϣ(RowDetailing)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowDetailing(object sender, GridViewDetailEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                    }
                }
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvDetailClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Detail objEventArgs4Detail = new clsEventArgs4Detail()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "};");

                    strCodeForCs.AppendFormat("\r\n" + "GvDetailClick(this, objEventArgs4Detail);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "Detail{0}Record({1});",
                objViewInfoENEx.TabName,
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //����GridView����ϸ��Ϣ���¼�����
        public string Gen_GridView_RowSelecting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,��������ϸ��Ϣ(RowSelecting)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowSelecting(object sender, GridViewSelectEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                    }
                }
                if (bolIsInWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (GvSelectClick != null)");
                    strCodeForCs.Append("\r\n" + "{             ");
                    strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Select objEventArgs4Select = new clsEventArgs4Select()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "};");

                    strCodeForCs.AppendFormat("\r\n" + "GvSelectClick(this, objEventArgs4Select);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "Select{0}Record({1});",
                objViewInfoENEx.TabName,
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //����GridView��ɾ�����¼�����
        public string Gen_GridView_RowUpdating(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��GridView��,��GeidView�е����޸�ʱ�������¼�,��������Ҫ����:�������д����޸���ؼ�¼��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void gv{0}_RowUpdating(object sender, GridViewUpdateEventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        objViewInfoENEx.TabName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                    }
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    if (bolIsInWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (GvUpdateClick != null)");
                        strCodeForCs.Append("\r\n" + "{             ");
                        strCodeForCs.AppendFormat("\r\n" + "clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update()");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "KeyId = {0}.ToString()",
                          objKeyField.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "};");


                        strCodeForCs.AppendFormat("\r\n" + "GvUpdateClick(this, objEventArgs4Update);");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {
                    //strStd1Id = "";
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    objViewInfoENEx.TabName,
                    objKeyField.ObjFieldTabENEx.FldName,
                    objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_GvUpdateClick()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��Gv�б�ؼ���,��GeidView�е����޸�ʱ�������¼���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}1_GvUpdateClick(object sender, clsEventArgs4Update e)",
                        ClsName4WucTabName4Gv());
                strCodeForCs.Append("\r\n" + "{");
                        

                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);    ////GridView����ɾ���¼�����
                    //strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, false);
                    //strCodeForCs.Append(strTemp);rjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    }
                strCodeForCs.AppendFormat("\r\n" + "  Update{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_GvDeleteClick()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��Gv�б�ؼ���,��GeidView�е���ɾ��ʱ�������¼���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}1_GvDeleteClick(object sender, clsEventArgs4Delete e)",
                        ClsName4WucTabName4Gv());
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Delete{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_chkSelAll_CheckedChanged()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��Gv�б�ؼ���,��GeidView�е���ȫѡ��ѡ��ʱ�������¼���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void chkSelAll_CheckedChanged(object sender, EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "CheckBox chkSelAll = (CheckBox)sender;");
                strCodeForCs.Append("\r\n" + "if (chkSelAll.Checked == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, true);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //����GridView��ɾ�����¼�����
        public string Gen_lbDispTableList_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��ʾ���б��¼��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void lbDisp{0}List_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //����GridView��ɾ�����¼�����
        public string Gen_btnCancelEdit_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:ȡ���༭״̬,�˻ص��б�״̬");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void btnCancel{0}Edit_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.ViewTypeCode != (int)enumViewTypeCodeTab.Table_Insert_1)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                //    objViewInfoENEx.TabName);
                //}
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����<��ʾ�б��༭����>
        /// </summary>
        /// <returns></returns>
        public string GenDispListRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///�������WebForm�Ĵ���;
            //			string strTemp; ///��ʱ����;
                 
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ֿ��ƺ���,��ʾ�����б���,���������ڱ༭���û��ؼ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void Disp{0}ListRegion()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ����<��ʾ�б��༭����>
        /// </summary>
        /// <returns></returns>
        public string GenDispEditRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///�������WebForm�Ĵ���;
            //			string strTemp; ///��ʱ����;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ֿ��ƺ���,��ʾ���ڱ༭���û��ؼ�,�����������б���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void DispEdit{0}Region()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");         

            return strCodeForCs.ToString();
        }

        ///�����޸ļ�¼����;
        public string GenPage_LoadCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///����������ǳ��α�����,�����ǵ�����ť�¼�������");
                strCodeForCs.Append("\r\n" + "{");
                // ����Ȩ���й��ж�Ȩ�޵Ĵ���
                strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����Page_Load�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + GenDdlBindFunction4Page_Load());

                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
               
                    strCodeForCs.AppendFormat("\r\n" + "{4}1.SetSortBy(string.Format(\"{{0}} Asc\", con{1}.{0}));",
                        objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, "{", "}", ClsName4WucTabName4Gv());
                }

                strCodeForCs.Append("\r\n" + "//2����ʾ�������ı�������GridView��");
                if (bolIsUseWuc4Gv == true)
                {
                    //strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    //   objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {

                    strCodeForCs.Append("\r\n" + "//3�����ñ�ؼ����ֿؼ���ReadOnly����,");
                    strCodeForCs.Append("\r\n" + "// ʹֻ֮��,��Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�");

                    if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "wuc{0}B1.SetKeyReadOnly(true);", objViewInfoENEx.TabName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "//�����߼���Ĺ�������,����������ˢ�º���");
                strCodeForCs.AppendFormat("\r\n" + "//{0}_objCommFun4BL = new clsCommFun4BL4{0}();",
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        ///�����޸ļ�¼����;
        public string GenPage_LoadCode4Wuc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�û�����ؼ�ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenGetPageCount()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:���㵱ǰҳ��,���ݼ�¼����ÿҳ��¼��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"intRecCount\">�ܼ�¼��</param>");
                strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ÿҳ��¼��</param>");
                strCodeForCs.Append("\r\n" + "private int GetPageCount(int intRecCount, int intPageSize)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (intRecCount == 0) return 0;");
                strCodeForCs.Append("\r\n" + "int intPageCount = intRecCount / intPageSize;");
                strCodeForCs.Append("\r\n" + "if (intRecCount % intPageSize == 0) return intPageCount;");
                strCodeForCs.Append("\r\n" + "return intPageCount + 1;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        ///�����޸ļ�¼����;
        public string GenbtnQuery_ClickCode(clsViewInfoENEx objViewInfoENEx, bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<��ѯ>��ťʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��GridView�ĵ�ǰҳ��������Ϊ0,����1ҳ��");
                strCodeForCs.Append("\r\n" + "//��������ѯʱ,������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�");
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " {0}1.vsPageIndex = 1;",
                        ClsName4WucTabName4Gv());
                    strCodeForCs.AppendFormat("\r\n" + "//�ѱ��¼��������ʾ��GridView��");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                     objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = 0;", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�ѱ��¼��������ʾ��GridView��");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        ///�����޸ļ�¼����;
        public string GenbtnOKUpd_ClickCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n /// ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "Button btnTemp;");
                strCodeForCs.Append("\r\n" + "btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"���\":");
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                    objViewInfoENEx.TabName);

                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"ȷ�����\":");
                    strCodeForCs.Append("\r\n" + "//����һ������Ĳ���Ĵ���,�����߼���̫��,");
                    strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"ȷ���޸�\":");
                    strCodeForCs.Append("\r\n" + "//����һ��������޸ĵĴ���,�����߼���̫��,");
                    strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenShowDataCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:���Ըùؼ��ֵļ�¼������ʾ�ڽ�����,");
                    strCodeForCs.Append("\r\n ///������   �������ǰ�ֵ������ؼ���");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">���¼�Ĺؼ���,��ʾ�ñ�ؼ��ֵ�����</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void ShowData({0})",
                    objViewInfoENEx.KeyVarDefineLstStr);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//��������:");
                    strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                    strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objKeyField.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objKeyField.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}_IsExist({1}) == false)		//���ùؼ��ֵļ�¼�Ƿ����",
                    objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "{");


                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "�ڱ�[{1}]��,�ؼ���Ϊ:[{0}]�ļ�¼������!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{2})�ڱ�[{1}]��,�ؼ���Ϊ:[{0}]�ļ�¼������!\";",
                      objKeyField.PrivFuncName,
                      objViewInfoENEx.TabName, strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN = new cls{1}EN({2});",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}Get{1}(ref obj{0}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "����ʾ����ʱ��ȡ��¼���󲻳ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})����ʾ����ʱ��ȡ��¼���󲻳ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"obj{0}EN\", obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{1}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(NodeWCCCode4Gv4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            clsViewRegionENEx obj = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (obj != null && string.IsNullOrEmpty(obj.ClsName) == false)
            {
                this.ClsName = obj.ClsName;
                objViewInfoENEx.ClsName = this.ClsName;
            }
            else
            {
                this.ClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
                objViewInfoENEx.ClsName = this.ClsName;
            }
        }
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

    }
}