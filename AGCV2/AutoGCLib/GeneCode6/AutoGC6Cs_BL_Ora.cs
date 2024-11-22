using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using com.taishsoft.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �����㡣����:
    ///					1)���¼����ӡ�
    ///					2)���¼��ɾ��
    ///					3)���¼���޸�
    ///					4)���¼�Ĳ�ѯ
    ///					5)��ȡĳЩ���¼���й��ֶ�����
    ///					6)���ñ��¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ��������һЩͨ�ò���
    /// </summary>
    class AutoGC6Cs_BL_Ora : AutoGCPubFunc_Ora
    {
        //����
        //private string objPrjTabENEx.ClsName;



        #region ���캯��

        public AutoGC6Cs_BL_Ora()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public AutoGC6Cs_BL_Ora(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        #endregion

    

        /// <summary>
        /// ����ͨ���߼������
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCode(Encoding myEncoding)
        {
            string strFuncName = "";
            string strResult;
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                           objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //���û���������;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Web.Services;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services.Protocols;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.AppendFormat("\r\n" + "using {0};",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbfororacle;"); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} ��ժҪ˵��",
                        objPrjTabENEx.ClsName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //  strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}Service : System.Web.Services.WebService",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                                .OrderBy(x => x.OrderNum); 

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //������д���ļ���;
                //�����ļ������ļ�����,���ж��Ƿ����;
                strFolder = clsString.ParentDir_S(strClassFName);
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN_Local.IsBackupForGeneCode == true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                    {
                        clsFile.FileBackup(strFindFileFullFile, objPrjTabENEx.BackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);

                    }
                }
                //UTF8Encoding utf8 = new UTF8Encoding(false);
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
      
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenBusinessLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strResult;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                              objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            
            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ
                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.OracleClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Globalization;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //  strCodeForCs.Append("\r\n" + "using System.IO.IsolatedStorage;");
                //  strCodeForCs.AppendFormat("\r\n" + "using {0}_SL4WS.ServiceReference{1};",
                //  objProjectsEN.PrjDomain, objPrjTabENEx.TabName);
                //}
                strCodeForCs.Append("\r\n" + "using System.Xml;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbfororacle;"); //
                
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.OracleClient; "); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProjectsENEx.PrjDomain);

                //}

                strCodeForCs.Append("\r\n" + ""); //
                                                  //if (objPrjTabENEx.IsForSilverLight == true)
                                                  //{
                                                  //  strCodeForCs.AppendFormat("\r\n" + "namespace {0}_SL4WS",
                                                  //  objProjectsEN.PrjDomain);
                                                  //}
                                                  //else
                                                  //{
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsENEx.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //  strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����XML����ǩ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �б��XML����ǩ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ���ڼ�¼����ļ�¼��");
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static int intFldNumCache = 0;");


                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                                .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
    
            }
            return strCodeForCs.ToString();
        }
        #region aaa
        #endregion
        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenBusinessLogicCode4View(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strResult;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                               objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

               
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            
            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ
                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.OracleClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Globalization;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.Append("\r\n" + "using System.IO.IsolatedStorage;");
                //    strCodeForCs.AppendFormat("\r\n" + "using {0}_SL4WS.ServiceReference{1};",
                //    objProjectsEN.PrjDomain, objPrjTabENEx.TabName);
                //}
                strCodeForCs.Append("\r\n" + "using System.Xml;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbfororacle;"); //
                

                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsEN.PrjDomain);
                    strCodeForCs.Append("\r\n" + "using System.Data; "); //
                    strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProjectsEN.PrjDomain);
                //}

                strCodeForCs.Append("\r\n" + ""); //
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "namespace {0}_SL4WS",
                //    objProjectsEN.PrjDomain);
                //}
                //else
                //{
                    strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                    objProjectsEN.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����XML����ǩ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �б��XML����ǩ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ���ڼ�¼����ļ�¼��");
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static int intFldNumCache = 0;");
                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                  .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

               
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
           
            }
            return strCodeForCs.ToString();
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AutoGC6Cs_BL_Ora);
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



        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetTopDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetRecordProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecordPropertyV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}Get{0}V(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExistRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExistRecordByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistRecord(\"{0}\", strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExist({2} {1})",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExist({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecordBySQL2();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateBySql2();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecord({2} {1})",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = new cls{0}EN({1}).DelRecordBySP();",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Del{0}s(List<string> arr{1}Lst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Del{0}(arr{1}Lst);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}EN ExposeLogicClass(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicExClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}Ex ExposeLogicExClass(cls{0}Ex obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");
            return strBuilder.ToString();
        }



        public string Gen_4BL_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Ĺ��캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }



        public string Gen_4BL_GetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.GetDataTable(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable", "��ȡ��:{0} ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ���ݳ���!({1}: GetDataTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable", "��ȡ��:{0} ���ݳ���!(�ų��ļ���ַ����б�)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ���ݳ���!(�ų��ļ���ַ����б�)({1}: GetDataTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!(�ų��ļ���ַ����б�)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable", "��ȡ��:{0} ���ݳ���!(�Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ���ݳ���!(�Ƿ���SQL����)({1}: GetDataTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!(�Ƿ���SQL����)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }
        public string Gen_4BL_GetDataTableByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}ByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "����������ȡ��Χ�����ݱ�:{0} ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����������ȡ��Χ�����ݱ�:{0} ���ݳ���!({1}:GetDataTableByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"����������ȡ��Χ�����ݱ�:{0} ���ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}ByRange(strWhereCond, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "����������ȡ��Χ�����ݱ�:{0} ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����������ȡ��Χ�����ݱ�:{0} ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)({1}:GetDataTableByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"����������ȡ��Χ�����ݱ�:{0} ���ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}ByRange(strWhereCond, bolIsCheckSQLAttack, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "����������ȡ��Χ�����ݱ�:{0} ���ݳ���!(ͬʱ����Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����������ȡ��Χ�����ݱ�:{0} ���ݳ���!(ͬʱ����Ƿ���SQL����)({1}:GetDataTableByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"����������ȡ��Χ�����ݱ�:{0} ���ݳ���!(ͬʱ����Ƿ���SQL����)\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSet(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSet", "��ȡ��:{0} ���ݼ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ���ݼ�����!({1}:GetDataSet)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݼ�����!\\r\\n({1}:GetDataSet)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetTopDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetTopDataSet_" + objPrjTabENEx.TabName + "(int intTopSize, string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetTopDataSet_{0}(intTopSize, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetTopDataSet_{0}", "��ȡ��:{0} ���ݼ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ���ݼ�����!({1}:GetTopDataSet_{0})\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݼ�����!\\r\\n({1}:GetDataSet)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCondByRange_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSetByRange(strCondition, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetByRange", "��ȡ��:{0} ����Χ�����ݼ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ����Χ�����ݼ�����!({1}:GetDataSetByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ����Χ�����ݼ�����!\\r\\n({1}:GetDataSetByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��ǰ����ͼ�����ݼ�,��DataSet��ʾ");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetV(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSetV(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetV", "��ȡ��:{0} ��ͼ�����ݼ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�����ݼ�����!({1}:GetDataSetV)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ��ͼ�����ݼ�����!\\r\\n({1}:GetDataSetV)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetDataSetByCondByRange_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSetVByRange(strCondition, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetVByRange", "��ȡ��:{0} ��ͼ�����ݼ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�Ĵ���Χ���ݼ�����!({1}:GetDataSetVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ��ͼ�Ĵ���Χ���ݼ�����!\\r\\n({1}:GetDataSetVByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTableV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��ǰ����ͼ�����ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}V(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "��ȡ��:{0} ��ͼ�����ݼ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�����ݳ���!({1}:GetDataTableV)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ��ͼ�����ݳ���!\\r\\n({1}:GetDataTableV)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ����ͼ,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}V(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "��ȡ��:{0} ��ͼ�����ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�����ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)({1}:GetDataTableV)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ��ͼ�����ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)\\r\\n({1}:GetDataTableV)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}VByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!({1}:GetDataTableVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!\\r\\n({1}:GetDataTableVByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, List<string> lstExclude, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}VByRange(strWhereCond, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)({1}:GetDataTableVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}VByRange(strWhereCond, bolIsCheckSQLAttack, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!(ͬʱ����Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ��:{0} ��ͼ�Ĵ���Χ���ݳ���!(ͬʱ����Ƿ���SQL����)({1}:GetDataTableVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTableV2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}DA.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception (\"��ȡ��View���ݳ���!\\r\\n(cls{0}DA:Get{0})\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_RecObjLstFromDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����ṩ��DataTable��ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objDT\">�ṩ��DataTable</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstFromDataTable(DataTable objDT)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            //strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            //strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            //
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }



        public string Gen_4BL_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"ת��DataRow��clsvFuncParaRelaEN�������, �ؼ���:[{0}]��{1}. (In {2})\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());", 
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strCondition, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strCondition, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strCondition, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strCondition, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetObjLst2()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> {0}List(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecordProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݶ���Ĺؼ���ֵ,��ȡ�����ȫ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��ض���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>�����</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{2}({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                      && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {

                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("GetObjBy{1}", objPrjTabENEx.TabName, objKeyField.FldName),
                        string.Format("�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "���ɴ���");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:Get{1}By{3})\");",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName, strErrId,
                         objKeyField.FldName);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}DA.GetObjBy{1}({2});",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy��:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecord({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "ɾ����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})ɾ����¼����!({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ����¼����!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_DelRecordBySign()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecordBySign({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecordBySign({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySign", "���ݱ�־ɾ����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})���ݱ�־ɾ����¼����!({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ����¼����!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UnDelRecordBySign()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UnDelRecordBySign({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.UnDelRecordBySign({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySign", "���ݱ�־ɾ����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})���ݱ�־ɾ����¼����!({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ����¼����!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelRecordWithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ�ļ�¼,ʹ������");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0}, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecord({1},objOracleConnection,objOracleTransaction);",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "ɾ����¼����!(ʹ������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})ɾ����¼����!(ʹ������)({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ����¼����!(ʹ������)({1}: DelRecord)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_DelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼,ͨ���洢����(SP)��ɾ����");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecordBySP({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySP", "ͨ���洢����ɾ����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})ͨ���洢����ɾ����¼����!({1}:DelRecordBySP)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ͨ���洢����ɾ����¼����!({1}:DelRecordBySP)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            ///public bool Addnew {TabName}BySP() == ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б�ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ���ֵ�б�</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}s(List<string> arr{1}Lst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.Del{0}(arr{1}Lst);",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}s", "ɾ�����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})ɾ�����¼����!({1}:Del{0}s)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ�����¼����!({1}: Del{0}s)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ�����������Ķ�����¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼����</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}DA.Del{0}(strWhereCond);",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCond", "ɾ�����������Ķ�����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})ɾ�����������Ķ�����¼����!({1}:Del{0}sByCond)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ�����������Ķ�����¼����!({1}: Del{0}sByCond)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecordByCondWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ�����������Ķ�����¼.(��������)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ�ɾ���ɹ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}sByCondWithTransaction_S(string strWhereCond, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.Del{0}WithTransaction_S(strWhereCond, objOracleConnection, objOracleTransaction);",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCondWithTransaction_S", "ɾ�����������Ķ�����¼����!(ͬʱ��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})ɾ�����������Ķ�����¼����!(ͬʱ��������)({1}:Del{0}sByCondWithTransaction_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ�����������Ķ�����¼����!(ͬʱ��������)({1}: Del{0}WithTransaction_S)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "��Ӽ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��Ӽ�¼����!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2WithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "��Ӽ�¼����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��Ӽ�¼����!(��������)({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!(��������)({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2WithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ,ͬʱ�����²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3�������²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻��²����¼�Ĺؼ��ֵ�ֵ,����ͱ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = obj{0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "������ֵ����Ӽ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})������ֵ����Ӽ�¼����!({1}:AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"������ֵ����Ӽ�¼����!({1}: AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_AddNewRecordBySql2WithReturnKeyAndTransaction_S()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ,ͬʱ�����²����¼�Ĺؼ��ֵ�ֵ,�ú������Խ���������");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3�������²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql�������</param>");

            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻��²����¼�Ĺؼ��ֵ�ֵ,����ͱ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = obj{0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "������ֵ����Ӽ�¼����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})������ֵ����Ӽ�¼����!(��������)({1}:AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"������ֵ����Ӽ�¼����!(��������)({1}: AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
            //      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,������ԴΪ����ʵ������XML��");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3��ʹ��XML����Դ������");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">����ʵ������XML��</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql_XML", "��Ӽ�¼����!(ʹ��XML)", "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��Ӽ�¼����!(ʹ��XML)({1}: AddNewRecordBySql_XML)\\r\\n\" + objException.Message);",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 strErrId);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_Update()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.Update(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update", "�޸ļ�¼(Update)����!", "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})�޸ļ�¼(Update)����!({1}: Update)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼(UpdateBySql2)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})�޸ļ�¼(UpdateBySql2)����!({1}: UpdateBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySql2WithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ.(��������)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻");
            strBuilder.Append("\r\n /// /// 2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;");
            strBuilder.Append("\r\n /// /// 3��֧��������.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
          objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼(UpdateBySql2)����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})�޸ļ�¼(UpdateBySql2)����!(��������)({1}: UpdateBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"�޸ļ�¼(UpdateBySql2)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ,���������޸ļ�¼");
            strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySqlWithCondition(obj{0}EN, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithCondition", "�޸ļ�¼(UpdateBySqlWithCondition)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})�޸ļ�¼(UpdateBySqlWithCondition)����!({1}: UpdateBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"�޸ļ�¼(UpdateBySqlWithCondition)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySqlWithConditionTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ,���������޸ļ�¼.(��������)");
            strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strCondition, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySqlWithConditionTransaction(obj{0}EN, strCondition, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithConditionTransaction", "�޸ļ�¼(UpdateBySqlWithConditionTransaction)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})�޸ļ�¼(UpdateBySqlWithConditionTransaction)����!({1}: UpdateBySqlWithConditionTransaction)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"�޸ļ�¼(UpdateBySqlWithConditionTransaction)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�ṩXML��������ʵ�����");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">��Ҫ�޸ĵĶ���,��XML����ʾ</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql_XML", "�޸ļ�¼(UpdateBySql_XML)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})�޸ļ�¼(UpdateBySql_XML)����!({1}: UpdateBySql_XML)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"�޸ļ�¼(UpdateBySql_XML)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistRecord(string strCondition)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExistCondRec(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}DA.GetFirstID_S(strCondition);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetFirstID_S", "��ȡFirst�ؼ��ֳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡFirst�ؼ��ֳ���!({1}: GetFirstID_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡFirst�ؼ��ֳ���!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������Ĺؼ���ֵ�б�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������������Ĺؼ����б�ֵ</returns>");

            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID_S(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n List<string> arrList;");
            //strBuilder.AppendFormat("\r\n {0} {1};",
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arrList = new cls{0}DA().GetID(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return arrList;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetPrimaryKeyID_S", "��ȡ�ؼ����б����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ�ؼ����б����!({1}: GetPrimaryKeyID_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡ�ؼ����б����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetMaxStrID_S()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");

            strBuilder.Append("\r\npublic static string GetMaxStrId_S() ");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n string strMax{1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strMax{0} = cls{1}DA.GetMaxStrId();",
            objKeyField.FldName_FstUcase, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return strMax{0};", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrId_S", "��ȡ���ؼ���ֵ(GetMaxStrId)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})��ȡ���ؼ���ֵ(GetMaxStrId)����!({1}: GetMaxStrId_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡ���ؼ���ֵ(GetMaxStrId)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_IsExistTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����Ƿ���ڵ�ǰ��");
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>���ھͷ���True,���򷵻�False</returns>");

            strBuilder.Append("\r\npublic static bool IsExistTable() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n bool bolIsExist;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n bolIsExist = cls{0}DA.IsExistTable();",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistTable", "����Ƿ���ڵ�ǰ��(IsExistTable)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����Ƿ���ڵ�ǰ��(IsExistTable)����!({1}: IsExistTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n throw new Exception(\"����Ƿ���ڵ�ǰ��(IsExistTable)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����Ƿ���ڵ�ǰ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">������</param>");
            strBuilder.Append("\r\n /// <returns>���ھͷ���True,���򷵻�False</returns>");

            strBuilder.Append("\r\npublic static bool IsExistTable(string strTabName) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n bool bolIsExist;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n bolIsExist = cls{0}DA.IsExistTable(strTabName);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistTable", "����Ƿ����ָ����(IsExistTable)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����Ƿ����ָ����(IsExistTable)����!({1}: IsExistTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n throw new Exception(\"����Ƿ����ָ����(IsExistTable)����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ��ؼ�¼����,����ж������,��ȡ���еĵ�һ��,����������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetFirstObject_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ķ���</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetFirstObj_S(string strCondition) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetFirst{0}(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�ڸ���������ȡ��һ������ʱ,����:{{0}},����!({1}: GetFirst{0})\", objException.Message));",
         objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ��ؼ�¼����,����ж������,��ȡ���еĵ�һ��,����������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecValueObjByDataRow_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��DataRowת�������ʵ�����");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">������DataRow</param>");
            strBuilder.Append("\r\n /// <returns>������ص�ʵ�����</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRow objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "����DataRow��¼��ȡ�������!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����DataRow��¼��ȡ�������!({1}: GetObjByDataRow_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"ͨ��DataRow��¼�������!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            //StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��DataRowView(GridView�ж���)ת�������ʵ�����");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">������DataRowView</param>");
            strBuilder.Append("\r\n /// <returns>������ص�ʵ�����</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRowView objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "����DataRowView��¼��ȡ�������!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})����DataRowView��¼��ȡ�������!({1}: GetObjByDataRow_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"ͨ��DataRow��¼�������!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        public string Gen_4BL_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�����Ƿ����?</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {

                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("IsExist", objPrjTabENEx.TabName, objKeyField.FldName),
                    string.Format("�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "���ɴ���");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:IsExist)\");",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName,
                         strErrId);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExist({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_4BL_IsExistByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strId_School\">������ѧУ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�����Ƿ����?</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0}, string strTabName)",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {

                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("IsExistByTabName", objPrjTabENEx.TabName, objKeyField.FldName),
                    string.Format("�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "���ɴ���");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:IsExist)\");",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName,
                         strErrId);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExist({1}, strTabName);",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\n" + "//����¼�Ƿ����");
                    strBuilder.AppendFormat("\r\n" + "bool bolIsUniqueness = cls{0}DA.Check{1}Uniqueness({3}, {5});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n" + "return bolIsUniqueness;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckUniquenessV2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��,�����ֶ�(Uniqueness)--{0}({1})",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}UniquenessSingleField(cls{1}EN obj{1}EN)",
                    objField.ObjFieldTabENEx.FldName,
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\n" + "//����¼�Ƿ����");

                    strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                    objPrjTabENEx.TabName);

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "int":
                        case "long":
                        case "short":
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                            objPrjTabENEx.TabName,
                            objKeyField.FldName);
                            break;
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                            objPrjTabENEx.TabName,
                            objKeyField.PropertyName(this.IsFstLcase));
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                            objPrjTabENEx.TabName,
                            objKeyField.PropertyName(this.IsFstLcase));
                            break;
                    }
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{1}Uniqueness(",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "else");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{1}Uniqueness(",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{2}, obj{0}EN.{1});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "return bolIsUniqueness;");

                    strBuilder.Append("\r\n" + "}");
                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CheckUniquenessV3()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
              objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);

            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ��Ψһ�Ķ���</param>",
                   objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness(cls{0}EN obj{0}EN)",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");

            strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
            objPrjTabENEx.TabName);

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                case "long":
                case "short":
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName);
                    break;
                case "string":
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                    objPrjTabENEx.TabName,
                    objKeyField.PropertyName(this.IsFstLcase));
                    break;
                default:
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                    objPrjTabENEx.TabName,
                    objKeyField.PropertyName(this.IsFstLcase));
                    break;
            }
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{0}Uniqueness(",
            objPrjTabENEx.TabName);
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique = false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                if (bolIsFirst == true)
                {

                    strBuilder.AppendFormat("obj{0}EN.{1}",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    bolIsFirst = false;
                }
                else
                {
                    strBuilder.AppendFormat(", obj{0}EN.{1}",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(");");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{0}Uniqueness(",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("obj{0}EN.{1}",
            objPrjTabENEx.TabName,
            objKeyField.FldName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique = false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                strBuilder.AppendFormat(", obj{0}EN.{1}",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);

            }
            strBuilder.Append(");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return bolIsUniqueness;");

            strBuilder.Append("\r\n" + "}");


            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }

      



        public string Gen_4BL_GetUniquenessConditionString()
        {
            StringBuilder strBuilder = new StringBuilder();
            int intVerCount = 1;
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
         
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// ��ȡ���Ψһ��������(Uniqueness)--{0}({1})",
                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append($"\r\n /// Ψһ������:{objInFor.ConstraintName4GC()}");

                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ��Ψһ�Ķ���</param>",
                       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.Append($"\r\npublic static string GetUniCondStr{strVersion}(cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "//����¼�Ƿ����");

                strBuilder.AppendFormat("\r\n" + "string strResult = cls{0}DA.GetUniCondStr(",
                objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                strBuilder.AppendFormat("obj{0}EN.{1}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
                //bool bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique = false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strBuilder.AppendFormat(", obj{0}EN.{1}",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);

                }
                strBuilder.Append(");");
                strBuilder.Append("\r\n" + "return strResult;");

                strBuilder.Append("\r\n" + "}");

            }
            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����
            strBuilder.AppendFormat("\r\n cls{0}DA.CheckPropertyNew(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ����֯��ѯ����ʱ�Ƿ�Ϸ�,1)����Ƿ������ = ���� and ��;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����
            strBuilder.AppendFormat("\r\n cls{0}DA.CheckProperty4Condition(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_ComboBoxBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            bool bolIsNeedQuote = true;
            clsDataTypeAbbrEN objDataTypeAbbr4ValueField = null;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                        bolIsNeedQuote = objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote;
                        objDataTypeAbbr4ValueField = objField.ObjFieldTabENEx.objDataTypeAbbrEN;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Win��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObj = cls{0}BL.GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    if (bolIsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                        objPrjTabENEx.TabName, strValueFieldName);

                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"ѡ[{2}]...\";",
                    objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    strCodeForCs.AppendFormat("\r\n" + "foreach(cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(objInFor);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                     objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                     objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
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
        public string Gen_4BL_DdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {


                    //				
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Web��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
           

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                        objPrjTabENEx.TabCnName);
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}DA.Get{0}();",
                    strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Web��������-ʹ��Cache");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}Cache(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);
                    //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}DA.Get{0}();",
                    //strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = GetAll{0}ObjLstCache(); ",
                              objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataSource = arr{0}ObjLst;",
                              objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
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
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            //clsSysParaEN_Local.strVersion
            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount);",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ�������ֶ�����ֵ:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ���Ϊnull, ����![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strErrMsgForGetObjById);");

            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache_Once()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_Once({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "return null;");
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.ʹ��˳���ѯ
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache_Seq()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ,ʹ��˳���ѯ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_Seq({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache_Seq({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName);



            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strErrMsgForGetObjById);");

            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.ʹ��˳���ѯ
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache_Seq_Once()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ,ʹ��˳���ѯ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_Seq_Once({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "return null;");


            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetAllRecObjLstCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>�ӻ����л�ȡ�����ж����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetAll{0}ObjLstCache()",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>�ӻ����л�ȡ�����ж����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstCache()",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ����б��ȡ��ض����б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstByKeyLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ����б��ȡ��ض����б�.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ���</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstBy{1}Lst(List<{2}> arr{1}Lst)",
            objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n StringBuilder sbCondition = new StringBuilder();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n string strSqlConditionStr = clsArray.GetSqlInStrByArray(arr{0}Lst, true);", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n string strSqlConditionStr = clsArray.GetSqlInStrByArray(arr{0}Lst);", objKeyField.FldName_FstUcase);
            }
            strBuilder.AppendFormat("\r\n string strCondition = string.Format(\"{0} in ({{0}})\", strSqlConditionStr);", objKeyField.FldName, "{", "}");


            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");



            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecNameByKeyCache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[Get{0}By{1}Cache]����;",
        strTextFieldName, objKeyField.FldName);

            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
             objPrjTabENEx.TabName,
             strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "intFindFailCount++;");
            strBuilder.AppendFormat("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ�������ֶ�����ֵ:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ���Ϊnull, ����![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string GetNameBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
             objPrjTabENEx.TabName,
             strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "intFindFailCount++;");
            strBuilder.AppendFormat("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ�������ֶ�����ֵ:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ���Ϊnull, ����![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");
            
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyFromList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �Ӹ����Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">�����Ķ����б�</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}FromList({2} {3}, List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��XmlReader��һ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByXmlReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XmlReader��һ������-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��XmlReader��һ������");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"reader\">�ṩ������Դ:XmlReader</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�һ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjFromXml(System.Xml.XmlReader reader)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "reader.Read();");
            strBuilder.AppendFormat("\r\n" + "while (!(reader.Name == cls{0}BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(cls{1}EN.con_{0}))",
                      objField.ObjFieldTabENEx.FldName,
                      objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "{");
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "bool":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsBoolean());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "int":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsLong());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "float":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsFloat());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "double":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsDouble());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "DateTime":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsDateTime());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;

                        case "short":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}((short)reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int16":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int32":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsByte());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte[]":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsBytes());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}( reader.ReadElementContentAsString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                    }
                    strBuilder.Append("\r\n" + "}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(cls{1}EN.con_{0}))",
                      objField.ObjFieldTabENEx.FldName,
                      objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "{");
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsString();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "bool":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsBoolean();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "int":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsLong();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "float":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsFloat();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "double":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsDouble();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "DateTime":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsDateTime();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;

                        case "short":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short)reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int16":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int32":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsByte();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte[]":
                            //strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsBytes();",
                            //objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsString();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                    }
                    strBuilder.Append("\r\n" + "}");
                }
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��XML�ļ��л�ȡһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstFromXmlFile()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XML�ļ��л�ȡһ�������б�-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��XML�ļ��л�ȡһ�������б�");
            strBuilder.AppendFormat("\r\n /// ����:{0}",
            objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFileName\">�ṩ��һ��XML�ļ�</param>");
            strBuilder.AppendFormat("\r\n /// <returns>����һ��[cls{0}EN]�����б�</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstFromXmlFile(string strXmlFileName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}Obj = new List<cls{0}EN>();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "XmlReader reader = XmlReader.Create(strXmlFileName);");
            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromXml(reader);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lst{0}Obj.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return lst{0}Obj;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��XML���л�ȡһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstFromXmlStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XML���л�ȡһ�������б�.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��XML���л�ȡһ�������б�");
            strBuilder.AppendFormat("\r\n /// ����:{0}",
            objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}listXml\">�ṩ��һ��XML��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ��[cls{0}EN]�����б�</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstFromXmlStr(string str{0}listXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}Obj = new List<cls{0}EN>();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "UTF8Encoding enc = new UTF8Encoding();");
            strBuilder.AppendFormat("\r\n" + "using (MemoryStream ms = new MemoryStream(enc.GetBytes(str{0}listXml)))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings();");
            strBuilder.AppendFormat("\r\n" + "xmlrs.IgnoreComments = true;");
            strBuilder.AppendFormat("\r\n" + "xmlrs.IgnoreWhitespace = true;");
            strBuilder.AppendFormat("\r\n" + "XmlReader reader = XmlReader.Create(ms, xmlrs);");

            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromXml(reader);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lst{0}Obj.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return lst{0}Obj;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��һ���������л���XML��.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeXML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ���������л���XML��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"writer\">Ŀ��:���л�����XmlWriter</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����Դ:��Ҫ���л��Ķ���</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static void SerializeXML(XmlWriter writer, cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.itemXmlNode);",
            objPrjTabENEx.TabName);


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                string strTemp = GetCode4FieldInSerializeXML(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);
            }

            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���л�һ�������б�XmlWriter.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToXML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�XmlWriter");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">[cls{0}EN]�����б�</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"writer\">�ṩ��һ��XmlWriter����</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�����Ƿ�ɹ�?</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static bool SerializeObjLstToXML(List<cls{0}EN> lst{0}ObjLst, XmlWriter writer)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.listXmlNode);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.itemsXmlNode);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SerializeXML(writer, obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.AppendFormat("\r\n" + "return true;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���л�һ�������б�Xml�ļ�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToXMLFile()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�Xml�ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">��Ҫ���л��Ķ����б�</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFile\">���ɵ�XML�ļ�</param>");
            strBuilder.AppendFormat("\r\n" + "public static void SerializeObjLstToXMLFile(List<cls{0}EN> lst{0}ObjLst, string strXmlFile)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\" \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "SerializeObjLstToXML(lst{0}ObjLst, writer);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���л�һ�������б�Xml�ļ�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�Xml�ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">��Ҫ���л��Ķ����б�</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵ�XML��</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjLstToXMLStr(List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\" \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeObjLstToXML(lst{0}ObjLst, writer);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���л�һ�������б�JSON��.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�JSON��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">��Ҫ���л��Ķ����б�</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵ�JSON��</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjLstToJSONStr(List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "StringBuilder sbJSON = new StringBuilder();");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"{\");");
            strBuilder.AppendFormat("\r\n" + "sbJSON.AppendFormat(\"\\\"RecCount\\\":\\\"{{0}}\\\",\", lst{2}ObjLst.Count);",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "sbJSON.Append(\"\\\"data\\\":[\");");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON_One = SerializeObjToJSON(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "sbJSON.AppendFormat(\"{{0}},\", strJSON_One);",
              "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "sbJSON.Remove(sbJSON.Length - 1, 1);");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"]}\");");
            strBuilder.Append("\r\n" + "return sbJSON.ToString();");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���л�һ������Xml�ļ�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ������Xml�ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���л��Ķ���</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵ�XML��</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStr(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\" \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeXML(writer, obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_func()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ӳ�亯�������ݱ�ӳ��������ֶ�ֵ,ӳ�������ֶ�ֵ");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strInFldName\">�����ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strOutFldName\">����ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strInValue\">�����ֶ�ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>����һ������ֶ�ֵ</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string Func(string strInFldName, string strOutFldName, string strInValue)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "if (strInFldName != con{0}.{1})", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�����ֶ���:[{0}]����ȷ!\", strInFldName);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (con{0}.AttributeName.Contains(strOutFldName) == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����ֶ���:[{0}]����ȷ,��������ֶη�Χ֮��!({1})\",");
            strBuilder.AppendFormat("\r\n" + "strInFldName, string.Join(\", \", con{0}.AttributeName));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const obj{0} = cls{0}BL.GetObjBy{1}Cache(strInValue);", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0} == null) return \"\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}[strOutFldName].ToString();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���л�һ������JSON.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ������JSON");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���л�JSON�Ķ���</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵ�JSON��</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToJSON(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "StringBuilder sbJSON = new StringBuilder();");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"{\");");
            strBuilder.AppendFormat("\r\n" + "foreach (string strField in cls{0}EN.AttributeName)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "sbJSON.AppendFormat(\"\\\"{{0}}\\\":\\\"{{1}}\\\",\", strField, obj{2}EN[strField]);",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "sbJSON.Remove(sbJSON.Length - 1, 1);");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"}\");");
            strBuilder.Append("\r\n" + "return sbJSON.ToString();");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }



        /// <summary>
        /// ���л�һ������Xml�ļ�,���ø����ļ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToXMLStrIso()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ������Xml�ļ�,���ø����ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���л��Ķ���</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>����XML��</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStrByIso(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            //if (objPrjTabENEx.IsForSilverLight == true)
            //{
            //    strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");
            //}
            //else
            //{
                strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");
            //}
            strBuilder.AppendFormat("\r\n" + "using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings xmlws = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "xmlws.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "using (IsolatedStorageFileStream isoStream = isoStore.CreateFile(strXmlIsoFile))");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(isoStream, xmlws))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeXML(writer, obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromIsoFile(strXmlIsoFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// ��Xml�ַ�����һ������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByXmlStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XmlReader��һ������-----------------------------;


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Xml�ַ�����һ������");
            strBuilder.Append("\r\n /// ����:���Է�");
            strBuilder.Append("\r\n /// ����:2010/10/04");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXmlStr\">�ṩ������Դ:��ʾһ�������XML��</param>",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>���ص�һ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjFromXmlStr(string str{0}ObjXmlStr)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "UTF8Encoding enc = new UTF8Encoding();");
            strBuilder.AppendFormat("\r\n" + "using (MemoryStream ms = new MemoryStream(enc.GetBytes(str{0}ObjXmlStr)))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings();");
            strBuilder.Append("\r\n" + "xmlrs.IgnoreComments = true;");
            strBuilder.Append("\r\n" + "xmlrs.IgnoreWhitespace = true;");
            strBuilder.Append("\r\n" + "XmlReader reader = XmlReader.Create(ms, xmlrs);");
            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromXml(reader);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        private string GetCode4FieldInSerializeXML(clsPrjTabFldENEx objField)
        {

            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FldOpTypeId == "0003")
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "string":
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "bool":
                        //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                        // objField.ObjFieldTabENEx.FldName);
                        //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                        // strPrivPropNameWithObjectName4Get);
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString().ToLower(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                       objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "byte[]":
                        //sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                }

                return sbCodeForCs.ToString();
            }
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "string":
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                case "bool":
                    //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                    // objField.ObjFieldTabENEx.FldName);
                    //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                    // strPrivPropNameWithObjectName4Get);
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString().ToLower(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                case "int":
                case "long":
                case "float":
                case "double":
                case "short":
                case "Int16":
                case "Int32":
                case "byte":
                case "byte[]":
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
            }

            return sbCodeForCs.ToString();
        }



        public string Gen_4BL_GetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ�಻��ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCount(strTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCount();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ�಻��ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCountByCond(strTabName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ�಻��ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = cls{0}DA.GetFldValue(strTabName, strFldName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strFldName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = new cls{0}DA().GetFldValue(strFldName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond( string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCountByCond(strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetSpecSQLObj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforOra GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"���ʼ�����ڼ�¼��־��clsSysParaEN.objLog����!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objErrorLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"���ʼ�����ڼ�¼������־��clsSysParaEN.objErrorLog����!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforOra(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == ;
            return strBuilder.ToString();
        }




        public string Gen_4BL_funSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");



            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = new cls{0}DA().SetFldValue(strFldName, strValue, strCondition);",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(cls{0}EN._CurrTabName, strFldName, fltValue, strCondition);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = new cls{0}DA().SetFldValue( strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, strValue, strCondition);",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, intValue, strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, fltValue, strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }


        public string Gen_4BL_GenSQLCode4CreateTab()
        {

            string strDatabaseOwner;

            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //�ֶγ���
            string strFldPrecision;

            strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }


            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ������Ĵ���");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>������Ĵ���</returns>");
            strBuilder.Append("\r\npublic static string GetCode4CreateTable() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n StringBuilder strCreateTabCode = new StringBuilder();");

            strBuilder.AppendFormat("\r\n  strCreateTabCode.Append(\"CREATE table [{1}].[{0}] \"); ",
              objPrjTabENEx.TabName, strDatabaseOwner);
            strBuilder.Append("\r\n strCreateTabCode.Append(\" ( \"); ");//������
            int intCount = 0;

            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
                intCount++;
                ///�����ֶ���
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                strFldPrecision = objField.ObjFieldTabENEx.FldPrecision.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else if (strFieldType == "decimal" || strFieldType == "numeric")
                {
                    strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
                }
                else
                {
                    strFieldLength = "(" + strFieldLength0 + ")";
                }
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///�����Ƿ�ɿ�

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                    if (strFieldType == "bigint identity")
                    {
                        strFieldType = "bigint";
                    }
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                strBuilder.AppendFormat("\r\n // {0} ", strRemark);//����һ���ֶε���Ϣ
                if (intCount == objPrjTabENEx.arrFldSetAll.Count)
                {
                    strBuilder.AppendFormat("\r\n strCreateTabCode.Append(\" {0} \"); ", strFieldCode, strRemark);//����һ���ֶε���Ϣ
                }
                else
                {
                    strBuilder.AppendFormat("\r\n strCreateTabCode.Append(\" {0}, \"); ", strFieldCode, strRemark);//����һ���ֶε���Ϣ
                }
            }
            strBuilder.Remove(strBuilder.Length - 1, 1);
            strBuilder.Append("\r\n strCreateTabCode.Append(\") \"); ");//������
            strBuilder.Append("\r\n  strCreateTabCode.Append(\"ON [PRIMARY] \");");//

            //						Response.Write(strCreateTabCode.ToString());
            strBuilder.Append("\r\n  return strCreateTabCode.ToString();");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();

        }

    }
}
