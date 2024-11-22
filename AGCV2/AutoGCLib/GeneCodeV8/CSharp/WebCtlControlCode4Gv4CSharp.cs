using System;
using System.Text;
using System.IO;
using com.taishsoft.file;

using System.Collections;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using AGC.Entity;

using AGC.BusinessLogic;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using TzAdvancedLib;

namespace AutoGCLib
{
    /// <summary>
    /// �Զ����ɽ�����Ʋ�Ĵ�����(Control of Mvc)
    /// </summary>
    public class WebCtlControlCode4Gv4CSharp : clsGeneCodeBase
    {
        private string strTabName_Out = "";
        private string strTabId_Out = "";

        protected bool mbolIsUseCtl = true;
        public WebCtlControlCode4Gv4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
      
        public WebCtlControlCode4Gv4CSharp(string strViewId)
     : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public WebCtlControlCode4Gv4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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

        public string Gen_Wuc4Gv_CS_seErrMessage()
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
        
        public string Gen_Wuc4Gv_CS_vsPageSize()
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

      
        public string Gen_Wuc4Gv_CS_vsPageIndex()
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

        public string Gen_Wuc4Gv_CS_vsPageCount()
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

        public string Gen_Wuc4Gv_CS_vsRecCount()
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

        public string Gen_Wuc4Gv_CS_seBackErrPageLinkStr()
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
        public string Gen_Wuc4Gv_CS_BindGvByFuncBak()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}ByFunc(string strWhereCond)", strTabName_Out);
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
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsWhereCond = strWhereCond;");
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                    strTabName_Out);
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
                strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                    strTabName_Out);
                }
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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


        public string Gen_Wuc4Gv_CS_BindGv()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}(string strWhereCond)", strTabName_Out);
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
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsWhereCond = strWhereCond;");
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSort{0}By);",
                    strTabName_Out);
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
                strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                    strTabName_Out);
                }
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                

                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = objDV;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_BindGvCache()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}Cache(cls{0}EN obj{0}Cond)", strTabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0} = null;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //strTabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = obj{0}Cond.GetCombineCondition();", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "vsobj{0}Cond = obj{0}Cond;", strTabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                    strTabName_Out);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "��ȡ��ҳ�����б�(����)���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})��ȡ��ҳ�����б�(����)���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                
                strCodeForCs.Append("\r\n" + "//	4������GRIDView������Դ(DataSource)��");
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                //    strTabName_Out);
                //}
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arr{0};",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_BindGvByFunc()
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
                strCodeForCs.AppendFormat("\r\n" + "public void BindGv_{0}ByFunc(cls{0}EN obj{0}Cond)", strTabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0} = null;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}ENEx> arr{0}Ex = null;", strTabName_Out);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                // strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                //strTabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "vsWhereCond = obj{0}Cond.GetCombineCondition();", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "vsobj{0}Cond = obj{0}Cond;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intRecCount = cls{0}BL.GetRecCountByCond(vsWhereCond);",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "vsRecCount = intRecCount;");
                strCodeForCs.Append("\r\n" + "intPageCount = GetPageCount(intRecCount, vsPageSize);");
                strCodeForCs.Append("\r\n" + "vsPageCount = intPageCount;");

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                if (objViewInfoENEx.OutSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                        strTabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "arr{0} = cls{0}BL.GetObjLstByPagerCache(vsPageIndex, vsPageSize, obj{0}Cond, vsSort{0}By).ToList();",
                    strTabName_Out);
                }
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Ex = arr{0}.Select(this.CopyToEx).ToList();",                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebUserCtlClassName, "BindGv_{0}", "��ȡ��ҳ�����б�(����)���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "seErrMessage = \"(errid:{0})��ȡ��ҳ�����б�(����)���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "//	4������GRIDView������Դ(DataSource)��");
                //strCodeForCs.Append("\r\n" + "DataView objDV = objDT.DefaultView;");
                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "objDV.Sort = vsSort{0}By; ///ע����һ�д����п�����Ҫע�͵�,Ŀǰ���н����ڵ����Ĳ�ѯ������������",
                //    strTabName_Out);
                //}
                strCodeForCs.Append("\r\n ///����GridView��ÿҳ�ļ�¼��");
                strCodeForCs.Append("\r\n" + "if (vsPageSize > 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intPageSize = vsPageSize;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = intPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "vsPageSize = 15;");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.PageSize = vsPageSize;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataSource = arr{0}Ex;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//	5����GridView,����DataTable��������ʾ��GridView��");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.DataBind();",
                strTabName_Out);
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




        public string Gen_Wuc4Gv_CS_GridView_Sorting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intIndex;");
                strCodeForCs.Append("\r\n" + "//�ж��Ƿ����µ������ֶ�");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(e.SortExpression);",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                strTabName_Out);

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));


                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//���ԭ��������");
                strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\" Asc\");",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "if (intIndex == -1)		//���ԭ���������������Ϊ����");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Asc\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else			///��������Ϊ����");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = e.SortExpression + \" Desc\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڼ�¼GridView�еĵ�ǰ������ʽ,�Ա������һ��������,���ǽ�������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsSort{0}By",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = (string)ViewState[\"Sort{0}By\"];",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "if (sSort{0}By == null) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sSort{0}By = \"\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sSort{0}By;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sSort{0}By = value;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"Sort{0}By\", sSort{0}By);",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_vsWhereCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڼ�¼GridView�еĵ�ǰ������ʽ,�Ա������һ��������,���ǽ�������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string vsWhereCond",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = (string)ViewState[\"whereCond\"];",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "if (sWhereCond == null) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "sWhereCond = \"\";",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return sWhereCond;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string sWhereCond = value;",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"whereCond\", sWhereCond);",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_SetGvVisibility()
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
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_CS_SetGvVisibility_AllShow()
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
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty( x.FldId ) == false))
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{0}.{1}, true);",
                    strTabName_Out, objDGRegionFldsEx.ObjFieldTabENEx.FldName);
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

        public string Gen_Wuc4Gv_CS_SetGvVisibility_AllHide()
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
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet.FindAll(x => string.IsNullOrEmpty(x.FldId) == false))                    
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetGvVisibility(gv{0}, con{0}.{1}, false);",
                    strTabName_Out,  objDGRegionFldsEx.ObjFieldTabENEx.FldName);
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


        public string Gen_Wuc4Gv_CS_SetVisible()
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
                    strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_CS_SetSortBy()
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
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(vsSort{0}By) == true)", strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "vsSort{0}By = strSortBy;", strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_SetCheckedItemForGv()
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
                    strTabName_Out,
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
        public string Gen_Wuc4Gv_CS_SetCheckedItemsForGv()
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
                        strTabName_Out,
                        objKeyField.PrivFuncListName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.SetCheckedItemsForGv(gv{0}, 1, {1});",
                    strTabName_Out,
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


        public string GenBinggv_JumpPage()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n ///����ר������BindGv�е���ҳ��ش���");

                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;",
                strTabName_Out);
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
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//��ǰҳ��");
                strCodeForCs.AppendFormat("\r\n" + "lblAllPages.Text = intPageCount.ToString(); ",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//��ǰҳ����");
                strCodeForCs.AppendFormat("\r\n" + "lblCurrentPage.Text = vsPageIndex.ToString();",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//��ǰ����������ҳ����");
                strCodeForCs.AppendFormat("\r\n" + "txtJump2Page.Text = vsPageIndex.ToString();",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "//�����ǰҳ����Ϊ0,��<ǰһҳ>��ť��Ч");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == 1) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = false; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnPrevPage.Enabled = true; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "//�����ǰҳ������Ϊ���һҳ,��<ǰһҳ>��ť��Ч");
                strCodeForCs.AppendFormat("\r\n" + "if(vsPageIndex == intPageCount) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = false; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + "else ");
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "btnNextPage.Enabled = true; ",
                strTabName_Out);
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
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.BottomPagerRow.Visible = true;", strTabName_Out);
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


  

        public string Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv()
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
                            strTabName_Out,
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



        public string Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv()
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
                            strTabName_Out,
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
        public string Gen_Wuc4Gv_CS_btnJumpPage_Click(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "GridViewRow pagerRow = gv{0}.BottomPagerRow;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "TextBox txtJump2Page = (TextBox)pagerRow.FindControl(\"txtJump2Page\");");
                strCodeForCs.Append("\r\n" + "if (txtJump2Page != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if(txtJump2Page.Text.Trim()!= \"\" && ",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)>0 && ",
                strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "int.Parse(txtJump2Page.Text)-1<this.gv{0}.PageCount) ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{ ");
                strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = int.Parse(txtJump2Page.Text)-1; ",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "} ");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));
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
        public string Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));
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
        private string Gen_Wuc4Gv_CS_ReBindGv(bool bolIsInWuc4Gv)
        {
            string strCodeForCs = "";
            if (bolIsInWuc4Gv == true)
            {
                if (this.IsUseFunc)
                {
                    strCodeForCs = string.Format("\r\n" + "BindGv_{0}ByFunc(vsobj{0}Cond);", strTabName_Out);
                }
                else if ( objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true)
                {
                    strCodeForCs = string.Format("\r\n" + "BindGv_{0}Cache(vsobj{0}Cond);", strTabName_Out);
                }
                else
                {
                    strCodeForCs = string.Format("\r\n" + "BindGv_{0}(vsWhereCond);",
                        strTabName_Out);
                }
            }
            else
            {
                strCodeForCs = string.Format("\r\n" + "BindGv_{0}();", strTabName_Out);
            }
            return strCodeForCs;
        }

        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv{1}", strTabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
            return strClsName;
        }
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''�ù�����Ҫ���������صĿؼ�����,���������ļ�,;
            //һ���ǿؼ��Ľ����ļ�, ;
            //��һ����֮��صĽ������ļ�;
            strTabName_Out = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
            strTabId_Out = objViewInfoENEx.objViewRegion_List.TabId;
            this.objViewInfoENEx = objViewInfoENEx;
            //if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strViewName = objViewInfoENEx.ViewName;
            //    sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.GridRegion_0002);
            
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            
            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = this.ClsName; 

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx.cs", this.ClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


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
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.UserControl", this.ClsName);
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

                //���ɸ��ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,����ʾ��GridView��;
                if (this.IsUseFunc == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGvByFunc();
                    strCodeForCs.Append(strTemp);
                }
                else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGvCache();
                    strCodeForCs.Append(strTemp);
                }
                else
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGv();
                    strCodeForCs.Append(strTemp);
                }
               


                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_btnJumpPage_Click(objViewInfoENEx, true));
                    /// ���ɸı�GridView��ÿҳ��¼������������غ���
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, true));

                }

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView���н����¼�����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel
                && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }

                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView��ҳ�Ÿı��¼�����
                    strTemp = Gen_Wuc4Gv_CS_GridView_PageIndexChanging(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                { 
                    //GridView�����޸��¼�����
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowUpdating(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);

                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    //GridView����ɾ���¼�����
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowDeleting(objViewInfoENEx, true);
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
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageSize());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageIndex());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsRecCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "#region ������غ���");

                ///������GridView������صĴ���;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_Sorting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#endregion ������غ���");
                strTemp = Gen_Wuc4Gv_CS_vsWhereCond();
                strCodeForCs.Append(strTemp);


                // ���ɴ�����Ϣ��SESSION������Ժ���
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seErrMessage());
                // ���ɷ������ӵ�SESSION������Ժ���
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seBackErrPageLinkStr());

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllShow());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllHide());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetVisible());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemsForGv());
                strCodeForCs.Append("\r\n" + "");
                //strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged());
                //strCodeForCs.Append("\r\n" + "");
                //strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetSortBy());
              
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        throw objException;
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
                            strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindDdl_{0}({1});",
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

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }
     
      

        //����GridViewҳ�ŷ����仯ʱ���¼�����
        public string Gen_Wuc4Gv_CS_GridView_PageIndexChanging(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��2��)");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "if (e.NewPageIndex != -1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.AppendFormat("\r\n" + "gv{0}.pageIndex = e.NewPageIndex;",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(bolIsInWuc4Gv));
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
        public string Gen_Wuc4Gv_CS_GridView_RowCreated()
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
                strTabName_Out);
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
                    //						strTabName_Out);
                    //					strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "int intIndex;");
                    strCodeForCs.AppendFormat("\r\n" + "if (vsSort{0}By == \"\") return ;",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strSortEx;");
                    strCodeForCs.AppendFormat("\r\n" + "for(int i = 0;i<this.gv{0}.Columns.Count;i++)",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strSortEx = this.gv{0}.Columns[i].SortExpression;",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "if (strSortEx == \"\") continue;");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(strSortEx + \" \");",
                    strTabName_Out);
                    strCodeForCs.Append("\r\n" + "if(intIndex >= 0) //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "Label lblSort = new Label();");
                    strCodeForCs.Append("\r\n" + "lblSort.Font.Name = \"webdings\";//��������,��\"webdings\"��5��������,6�������ǣ�");
                    strCodeForCs.AppendFormat("\r\n" + "intIndex = vsSort{0}By.IndexOf(\"Asc\");",
                    strTabName_Out);
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
        public string Gen_Wuc4Gv_CS_GridView_RowCommand()
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
                strTabName_Out);
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"��ѡ\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (lbSelAll.Text == \"��ѡ\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);",
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "lbSelAll.Text = \"ȫѡ\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"NextPage\":");
                strCodeForCs.Append("\r\n" + "//1�����õ�ǰҳ��ҳ����,�����µ�����ҳ����������ǰҳ����");
                strCodeForCs.Append("\r\n" + "                    if (vsPageIndex < vsPageCount) vsPageIndex += 1;");
                strCodeForCs.Append("\r\n" + "//2�����°�GridView,ʹ֮���ݸ���,�仯���µ�ҳ");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(true));

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

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ReBindGv(true));

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
        public string Gen_Wuc4Gv_CS_GridView_RowDeleting(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                strTabName_Out,
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                strTabName_Out,
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                strTabName_Out,
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
        public string Gen_Wuc4Gv_CS_GridView_RowUpdating(clsViewInfoENEx objViewInfoENEx, bool bolIsInWuc4Gv)
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                {
                    if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "long {1} = long.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else if (objPrjTabFldEN.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "int {1} = int.Parse(str{0});",
                        objPrjTabFldEN.ObjFieldTabENEx.FldName, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {1} = gv{0}.DataKeys[e.RowIndex][\"{2}\"].ToString();",
                        strTabName_Out, objPrjTabFldEN.ObjFieldTabENEx.PrivFuncName, objPrjTabFldEN.ObjFieldTabENEx.FldName);
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
                        strTabName_Out,
                        objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {
                    //strStd1Id = "";
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                    strTabName_Out,
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
                    strTabName_Out);

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
                    strTabName_Out);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged()
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
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, true);", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.Set_GridViewAllChecked(gv{0}, false);", strTabName_Out);
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
                strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                strTabName_Out);
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

        public string Gen_Wuc4Gv_CS_GetPageCount()
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WebCtlControlCode4Gv4CSharp);
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
                this.ClsName = string.Format("wuc{0}4Gv", strTabName_Out);
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
        public string Gen_Wuc4Gv_CS_vsCondObject()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڼ�¼GridView�еĵ�ǰ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected cls{0}EN vsobj{0}Cond", strTabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "sobj{0}Cond = (cls{0}EN)ViewState[\"obj{0}Cond\"];", strTabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "return sobj{0}Cond;", strTabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN sobj{0}Cond = value;", strTabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"obj{0}Cond\", sobj{0}Cond);", strTabName_Out);
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
        public string Gen_Wuc4Gv_CS_Code4ListRegion()
        {
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.GridRegion_0002);

            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            string strTemp;
            objViewInfoENEx.WebUserCtlClassName = ClsName4WucTabName4Gv();

            objViewInfoENEx.WebUserCtlCsFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx.cs", ClsName4WucTabName4Gv());
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlClassName;

            //strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            //strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

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
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGvCache();
                    strCodeForCs.Append(strTemp);
                }
                else
                {
                    strTemp = Gen_Wuc4Gv_CS_BindGv();
                    strCodeForCs.Append(strTemp);
                }



                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_btnJumpPage_Click(objViewInfoENEx, true));
                    /// ���ɸı�GridView��ÿҳ��¼������������غ���
                    strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_ddlPagerRecCount_SelectedIndexChanged(objViewInfoENEx, true));

                }

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCommand();
                    strCodeForCs.Append(strTemp);
                }

                //GridView���н����¼�����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel
                && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowCreated();
                    strCodeForCs.Append(strTemp);
                }

                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    //GridView��ҳ�Ÿı��¼�����
                    strTemp = Gen_Wuc4Gv_CS_GridView_PageIndexChanging(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)
                {
                    //GridView�����޸��¼�����
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowUpdating(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);

                }
                if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
                {
                    //GridView����ɾ���¼�����
                    strTemp = Gen_Wuc4Gv_CS_GridView_RowDeleting(objViewInfoENEx, true);
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
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageSize());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageIndex());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_vsRecCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetPageCount());

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "#region ������غ���");

                ///������GridView������صĴ���;
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strTemp = Gen_Wuc4Gv_CS_GridView_Sorting(objViewInfoENEx, true);
                    strCodeForCs.Append(strTemp);
                }
                strCodeForCs.Append("\r\n" + "#endregion ������غ���");
                strTemp = Gen_Wuc4Gv_CS_vsWhereCond();
                strCodeForCs.Append(strTemp);

                strTemp = Gen_Wuc4Gv_CS_vsCondObject();
                strCodeForCs.Append(strTemp);

                // ���ɴ�����Ϣ��SESSION������Ժ���
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seErrMessage());
                // ���ɷ������ӵ�SESSION������Ժ���
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_seBackErrPageLinkStr());

                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllShow());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility_AllHide());
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetGvVisibility());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetVisible());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetAllCheckedKeysFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_GetFirstCheckedKeyFromGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetCheckedItemsForGv());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_chkSelAll_CheckedChanged());
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + Gen_Wuc4Gv_CS_SetSortBy());
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

        public string Gen_Wuc4Gv_CS_CopyToEx()
        {
            
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", strTabName_Out);
            strBuilder.AppendFormat("\r\n /// <returns>Ŀ�����=>cls{0}EN:obj{0}ENT</returns>", strTabName_Out);
            strBuilder.AppendFormat("\r\n public cls{0}ENEx CopyToEx(cls{0}EN obj{0}ENS)", strTabName_Out);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}ENEx obj{0}ENT = new cls{0}ENEx();", strTabName_Out);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.CopyTo(obj{0}ENS, obj{0}ENT);",
                    strTabName_Out);
            List<clsDGRegionFldsENEx> arrDGRegionFld_Sel = objViewInfoENEx.arrDGRegionFldSet.FindAll(x => x.IsUseFunc() == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.PrjId);
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFld_Sel)
            {
                strBuilder.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(strTabId_Out, objDGRegionFldsEx.FldId, 1, objViewInfoENEx.PrjId);
                if (objDataNode_Curr == null)
                {
                    string strMsg = string.Format("TabId={0},FldId=[{1}], VersionNo=1, PrjId={2}�Ľ��Ϊ��,����!", strTabId_Out, objDGRegionFldsEx.FldId, objViewInfoENEx.PrjId);
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDGRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
                string strLastVarName = "";
                

                var arrPath = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, objDGRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
                foreach(var objInFor in arrPath)
                {
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}ENT.{1}", strTabName_Out,  objCacheClassifyField.FldName);
                            }
                            strBuilder.AppendFormat("\r\n const {0} = cls{1}BL.func(con{1}.{2}, con{1}.{3}, {4} {5});", 
                                objDataNode_End.DataNodeName, 
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);

                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName )
                            {
                                case "equal":
                            
                                if (objDataNode_Start.TabId == strTabId_Out)
                                {
                                    strBuilder.AppendFormat("\r\n const {0} = obj{1}ENT.{2};", objDataNode_End.DataNodeName, 
                                        strTabName_Out,
                                        objFieldTab_Start.FldName);
                                }
                                else
                                {
                                    strBuilder.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                }
                                strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out)
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}ENT.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out,
                                        objFieldTab_Start.FldName);
                                    }
                                    else
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out)
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out,
                                        objFieldTab_Start.FldName,
                                        objDNFun.DnFunctionName);
                                    }
                                    else
                                    {
                                        strBuilder.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }
               
                }
                strBuilder.AppendFormat("\r\n obj{0}ENT.{1} = {2};", 
                                    strTabName_Out,
                                    objDGRegionFldsEx.DataPropertyName(),
                                    strLastVarName);
                strBuilder.Append("\r\n" + "};");
            }



            strBuilder.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "CopyToEx", "Copy��Ex:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
       
    }
}