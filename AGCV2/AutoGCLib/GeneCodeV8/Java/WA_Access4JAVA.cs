using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
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
    partial class WA_Access4JAVA : clsGeneCodeBase
    {
        #region ���캯��

        public WA_Access4JAVA()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_Access4JAVA(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_Access4JAVA(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion
        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
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
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".java";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".java";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.AppendFormat("\r\n" + "package {0}.GC.L3_ForWA.{1};",
                  objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                strBuilder.AppendFormat("\r\n" + "import {0}.PubFun.clsPubVar;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC());

                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                    objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC());
                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L2_Business.{2}.cls{1}BL;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC());
                //strBuilder.Append("\r\n" + "import com.taishsoft.commdb.clsResponseData;");
                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsResponseData;");
                strBuilder.Append("\r\n" + "import com.taishsoft.util.HttpWebapi;");


                strBuilder.Append("\r\n" + "import android.os.Bundle;");
                strBuilder.Append("\r\n" + "import android.os.Handler;");
                strBuilder.Append("\r\n" + "import android.os.Looper;");
                strBuilder.Append("\r\n" + "import android.os.Message;");
                strBuilder.Append("\r\n" + "import android.widget.TextView;");
                strBuilder.Append("\r\n" + "import android.widget.Toast;");

                strBuilder.Append("\r\n" + "import org.json.JSONObject;");
                strBuilder.Append("\r\n" + "import org.ksoap2.SoapEnvelope;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapObject;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapPrimitive;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapSerializationEnvelope;");
                strBuilder.Append("\r\n" + "import org.ksoap2.transport.HttpTransportSE;");
                strBuilder.Append("\r\n" + "import org.xmlpull.v1.XmlPullParserException;");

                strBuilder.Append("\r\n" + "import java.io.IOException;");
                strBuilder.Append("\r\n" + "import java.util.HashMap;");

                strBuilder.Append("\r\n" + "import java.util.Iterator;");
                strBuilder.Append("\r\n" + "import java.util.List;");
                strBuilder.Append("\r\n" + "import java.util.Map;");


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "public class  {0} implements Runnable",
                  objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "public static clsResponseData objResponseData = null;");

                strBuilder.Append("\r\n" + "private Handler mHandler = null;");
                strBuilder.Append("\r\n" + "private Map<String, String> Param = null;");
                strBuilder.Append("\r\n" + "private String NameSpace = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "private String MethodName = \"\";");
                strBuilder.Append("\r\n" + "private String WEB_API_URL = \"\";");
                strBuilder.Append("\r\n" + "private String soapAction = \"\";");

                strBuilder.AppendFormat("\r\n" + "private cls{0}EN obj{0}EN = null;",
                      objPrjTabENEx.TabName);
                //˽��������-----�����Թ���
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                       objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //˽��������-----�����Թ���

                strBuilder.AppendFormat("\r\n" + "public cls{0}WA(Handler mmHandler, String strMethod, Map<String, String> mapParam, cls{0}EN pobj{0}EN)",
                  objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData = new clsResponseData();",
                        objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "this.mHandler = mmHandler;");
                strBuilder.Append("\r\n" + "this.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "this.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (this.Param == null)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new HashMap<String, String>();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                      objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "WEB_API_URL = String.format(\"%s/%s/{0}Api\", clsPubVar.getCurrIPAndPort_{2}(), clsPubVar.getCurrWebApi_{2}());",
                  objPrjTabENEx.TabName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC(),
                  objProjectsENEx.PrjDomain);
                strBuilder.Append("\r\n" + "}");
                //�������еĺ���


                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                strBuilder.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
         
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenWebApiTransCode_Java_SelfDefWA(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName + "WS4SD";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.AppendFormat("\r\n" + "package {0}.GC.L3_ForWA.{1};",
                  objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                //strBuilder.AppendFormat("\r\n" + "import {0}.L0Entity.cls{1}EN;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.ClsName);
                //strBuilder.AppendFormat("\r\n" + "import {0}.Logic.cls{1}BL;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsResponseData;");
                strBuilder.AppendFormat("\r\n" + "import {0}.PubFun.clsPubVar;",
                    objProjectsENEx.JavaPackageName);

                strBuilder.Append("\r\n" + "import android.os.Bundle;");
                strBuilder.Append("\r\n" + "import android.os.Handler;");
                strBuilder.Append("\r\n" + "import android.os.Looper;");
                strBuilder.Append("\r\n" + "import android.os.Message;");
                strBuilder.Append("\r\n" + "import android.widget.TextView;");
                strBuilder.Append("\r\n" + "import android.widget.Toast;");

                strBuilder.Append("\r\n" + "import org.json.JSONObject;");
                strBuilder.Append("\r\n" + "import org.ksoap2.SoapEnvelope;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapObject;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapPrimitive;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapSerializationEnvelope;");
                strBuilder.Append("\r\n" + "import org.ksoap2.transport.HttpTransportSE;");
                strBuilder.Append("\r\n" + "import org.xmlpull.v1.XmlPullParserException;");

                strBuilder.Append("\r\n" + "import java.io.IOException;");
                strBuilder.Append("\r\n" + "import java.util.HashMap;");

                strBuilder.Append("\r\n" + "import java.util.Iterator;");
                strBuilder.Append("\r\n" + "import java.util.List;");
                strBuilder.Append("\r\n" + "import java.util.Map;");

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.PageName, objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "public class  {0} implements Runnable",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "public static clsResponseData objResponseData = null;");

                strBuilder.Append("\r\n" + "private Handler mHandler = null;");
                strBuilder.Append("\r\n" + "private Map<String, String> Param = null;");
                strBuilder.Append("\r\n" + "private String NameSpace = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "private String MethodName = \"\";");
                strBuilder.Append("\r\n" + "private String WEB_API_URL = \"\";");
                strBuilder.Append("\r\n" + "private String soapAction = \"\";");

                //strBuilder.AppendFormat("\r\n" + "private cls{0}EN obj{0}EN = null;",
                //      objWebSrvClassENEx.ClsName);
                //˽��������-----�����Թ���
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                //strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //˽��������-----�����Թ���

                strBuilder.AppendFormat("\r\n" + "public {0}WS4SD(Handler mmHandler, String strMethod, Map<String, String> mapParam)",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData = new clsResponseData();",
                        objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "this.mHandler = mmHandler;");
                strBuilder.Append("\r\n" + "this.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "this.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (this.Param == null)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new HashMap<String, String>();");
                strBuilder.Append("\r\n" + "}");

                //strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                //      objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "WEB_API_URL = String.format(\"%s/%s/{1}/{0}.asmx\", clsPubVar.getCurrIPAndPort_{2}(), clsPubVar.getCurrPrx_{2}());",
                  objWebSrvClassENEx.ClsName,
                  objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC(),
                  objProjectsENEx.PrjDomain);
                strBuilder.Append("\r\n" + "}");
                //�������еĺ���


                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WA_Java_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_run_Java_SelfDefWA");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strBuilder.Append("\r\n" + strTemp);
                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_CallWebApi_Java_SelfDefWA");

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strBuilder.Append("\r\n" + strTemp);

                strBuilder.Append("\r\n" + "}");

                //������д���ļ���;
                ////�����ļ������ļ�����,���ж��Ƿ����;
                //strFolder = clsString.ParentDir_S(strClassFName);
                //if (System.IO.Directory.Exists(strFolder) == false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objWebSrvClassENEx.FolderName_Root, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                //    {
                //        string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                //        throw new Exception(strMsg);

                //    }
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.CreateFileByString(strClassFName, strBuilder.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public string A_GeneFuncCode_Java(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Srv4CSharp);
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


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"GetFirstObj\", values, null);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetFirstObj(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetFirstObj\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            clsDataTypeAbbrEN objFuncReturnTypeEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFunctionsENEx.ReturnTypeId);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = null;
            if (objFuncReturnTypeEN == null)
            {
                objSelfDefDataTypeEN = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFunctionsENEx.ReturnType);
                if (objSelfDefDataTypeEN == null)
                {
                    strMsg = string.Format("�����ķ������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objWebSrvFunctionsENEx.ReturnTypeId, objWebSrvFunctionsENEx.ReturnType);
                    throw new Exception(strMsg);
                }
            }

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.CsType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }

            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }
            strBuilder.AppendFormat("\r\n /// <returns>����{0}</returns>",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            if (objSelfDefDataTypeEN != null)
            {
                strBuilder.AppendFormat("\r\n" + "private String {1}WA(Map<String, String> mapParam) throws Exception",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "private String {1}WA(Map<String, String> mapParam) throws Exception",
                       objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                           sbParaList.ToString());
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}\";",
              objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����:[{0}]ʱ����,������Ϣ:%s\", objException.getMessage());",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"GetObjBy{1}\", values, null);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetObjBy{1}(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetObjBy{1}\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }




        /// <summary>
        /// ����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_AddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi����Ӽ�¼,���ݴ���ʹ��JSON��");
            strBuilder.AppendFormat("\r\n /// mapParam����:��", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"AddNewRecord\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String AddNewRecord(Map<String, String> mapParam, cls{0}EN obj{0}EN) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"AddNewRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strJSON = cls{0}BL.GetJSONStrByObj(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "mapParam.put(\"str{0}JSONObj\", strJSON);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ����WebApi���޸ļ�¼,���ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_UpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi���޸ļ�¼,���ݴ���ʹ��JSON��");
            strBuilder.AppendFormat("\r\n /// mapParam����:��", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"UpdateRecord\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String UpdateRecord(Map<String, String> mapParam, cls{0}EN obj{0}EN) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"UpdateRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strJSON = cls{0}BL.GetJSONStrByObj(obj{0}EN);",
             objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "mapParam.put(\"str{0}JSONObj\", strJSON);",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ����WebApi��ɾ����¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi��ɾ����¼");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String DelRecord(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"DelRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// ����WebApi��ɾ����¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_DelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi��ɾ����¼");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String DelRecordsByJSON(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"DelRecordsByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����WebApi������Ƿ���ڼ�¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi������Ƿ���ڼ�¼");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String IsExistRecord(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"IsExistRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����WebApi������Ƿ���ڼ�¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡĳһ�����ļ�¼��");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡĳһ�����ļ�¼��</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetRecCountByCond(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetRecCountByCond\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����WebApi������Ƿ���ڼ�¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi������Ƿ���ڼ�¼");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetMaxStrId(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetMaxStrId\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����WebApi������Ƿ���ڼ�¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebApi������Ƿ���ڼ�¼");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetMaxStrIdByPrefix(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetMaxStrIdByPrefix\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"GetObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetObjLst(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"GetTopObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetTopObjLst(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetTopObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"GetTopObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetObjLstByPager(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetObjLstByPager\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WA(mHandler, \"GetObjLstByRange\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WA);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetObjLstByRange(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetObjLstByRange\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "String strUrl = String.format(\"%s/%s\", WEB_API_URL, MethodName);");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.Append("\r\n" + "return HttpWebapi.DoGet(strUrl, mapParam);");
            //            strBuilder.AppendFormat("\r\n" + "return CallWebApi(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"�ڵ���WebApi����ʱ����,������Ϣ:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ͨ�õĵ���WebApi����
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_CallWebApi()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ�õĵ���WebApi����");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String CallWebApi(String MethodName, Map<String, String> mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "soapAction = NameSpace + MethodName;");

            strBuilder.AppendFormat("\r\n" + "String result = \"\";");
            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "//step1 ָ��WebApi�������ռ�͵��õķ�����");
            strBuilder.AppendFormat("\r\n" + "SoapObject request = new SoapObject(NameSpace, MethodName);");

            strBuilder.AppendFormat("\r\n" + "//step2 ���õ��÷����Ĳ���ֵ,����Ĳ���������ú�WebApiһ��");
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"str{0}Id\", \"01\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"b\", 4);");
            strBuilder.AppendFormat("\r\n" + "if (mapParam != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Iterator iter = mapParam.entrySet().iterator();");
            strBuilder.AppendFormat("\r\n" + "while (iter.hasNext())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Map.Entry entry = (Map.Entry)iter.next();");
            strBuilder.AppendFormat("\r\n" + "request.addProperty((String)entry.getKey(),");
            strBuilder.AppendFormat("\r\n" + "(String)entry.getValue());");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//step3 ���ɵ���WebApi������SOAP������Ϣ,��ָ��SOAP�İ汾");
            strBuilder.AppendFormat("\r\n" + "SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(");
            strBuilder.AppendFormat("\r\n" + "SoapEnvelope.VER11);");
            strBuilder.AppendFormat("\r\n" + "//�����Ƿ���õ���dotNet�µ�WebApi");
            strBuilder.AppendFormat("\r\n" + "envelope.dotNet = true;");
            strBuilder.AppendFormat("\r\n" + "//����,�ȼ���envelope.bodyOut = request;");
            strBuilder.AppendFormat("\r\n" + "envelope.setOutputSoapObject(request);");

            strBuilder.AppendFormat("\r\n" + "//step4 ����HttpTransportSE����");
            strBuilder.AppendFormat("\r\n" + "HttpTransportSE ht = new HttpTransportSE(WEB_API_URL);");

            strBuilder.AppendFormat("\r\n" + "//step5 ����WebApi");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //��һ��������������soapAction,��Ҫ��soapAction + MethodName
            strBuilder.AppendFormat("\r\n" + "ht.call(soapAction, envelope);");
            //            } catch (HttpResponseException e) {
            //                e.printStackTrace();
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (IOException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.errorId = 4;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.faultString = String.format(\"����Զ��WebApi������ַ��[%s]. ������Ϣ��[%s].\", WEB_API_URL, e.getMessage());",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "result = cls{0}WA.objResponseData.faultString;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (XmlPullParserException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.errorId = 3;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.faultString = String.format(\"����Զ��WebApi������ַ��[%s]. ������Ϣ��[%s].\", WEB_API_URL, e.getMessage());",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "result = cls{0}WA.objResponseData.faultString;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "//step6 ʹ��getResponse�������WebApi�����ķ��ؽ��");
            strBuilder.AppendFormat("\r\n" + "if (envelope.getResponse() != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SoapPrimitive response = (SoapPrimitive)envelope.getResponse();");
            strBuilder.AppendFormat("\r\n" + "String strResult = response.toString();");
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.IsFinished = true;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.errorId = 0;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.data = strResult;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "return strResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.IsFinished = true;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.errorId = 1;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.faultString = \"��WebApiû���յ�����!\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "result = \"��WebApiû���յ�����!\";");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.IsFinished = true;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.errorId = 2;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WA.objResponseData.faultString = \"��WebApi��ȡ���ݳ����쳣,�п��ܻ�ȡ���ݲ�����!\";", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "result = e.getMessage();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ͨ�õĵ���WebApi����
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_CallWebApi_SelfDefWA()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ�õĵ���WebApi����,���ר�ŵ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "private String CallWebApi(String MethodName, Map<String, String> mapParam) ");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "soapAction = NameSpace + MethodName;");

            strBuilder.AppendFormat("\r\n" + "String result = \"\";");
            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "//step1 ָ��WebApi�������ռ�͵��õķ�����");
            strBuilder.AppendFormat("\r\n" + "SoapObject request = new SoapObject(NameSpace, MethodName);");

            strBuilder.AppendFormat("\r\n" + "//step2 ���õ��÷����Ĳ���ֵ,����Ĳ���������ú�WebApiһ��");
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"strKeyId\", \"01\");");
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"b\", 4);");
            strBuilder.AppendFormat("\r\n" + "if (mapParam != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Iterator iter = mapParam.entrySet().iterator();");
            strBuilder.AppendFormat("\r\n" + "while (iter.hasNext())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Map.Entry entry = (Map.Entry)iter.next();");
            strBuilder.AppendFormat("\r\n" + "request.addProperty((String)entry.getKey(),");
            strBuilder.AppendFormat("\r\n" + "(String)entry.getValue());");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//step3 ���ɵ���WebApi������SOAP������Ϣ,��ָ��SOAP�İ汾");
            strBuilder.AppendFormat("\r\n" + "SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(");
            strBuilder.AppendFormat("\r\n" + "SoapEnvelope.VER11);");
            strBuilder.AppendFormat("\r\n" + "//�����Ƿ���õ���dotNet�µ�WebApi");
            strBuilder.AppendFormat("\r\n" + "envelope.dotNet = true;");
            strBuilder.AppendFormat("\r\n" + "//����,�ȼ���envelope.bodyOut = request;");
            strBuilder.AppendFormat("\r\n" + "envelope.setOutputSoapObject(request);");

            strBuilder.AppendFormat("\r\n" + "//step4 ����HttpTransportSE����");
            strBuilder.AppendFormat("\r\n" + "HttpTransportSE ht = new HttpTransportSE(WEB_API_URL);");

            strBuilder.AppendFormat("\r\n" + "//step5 ����WebApi");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //��һ��������������soapAction,��Ҫ��soapAction + MethodName
            strBuilder.AppendFormat("\r\n" + "ht.call(soapAction, envelope);");
            //            } catch (HttpResponseException e) {
            //                e.printStackTrace();
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (IOException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.errorId = 4;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.faultString = String.format(\"����Զ��WebApi������ַ��[%s]. ������Ϣ��[%s].\", WEB_API_URL, e.getMessage());",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "result = {0}WS4SD.objResponseData.faultString;",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (XmlPullParserException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.errorId = 3;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.faultString = String.format(\"����Զ��WebApi������ַ��[%s]. ������Ϣ��[%s].\", WEB_API_URL, e.getMessage());",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "result = {0}WS4SD.objResponseData.faultString;",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "//step6 ʹ��getResponse�������WebApi�����ķ��ؽ��");
            strBuilder.AppendFormat("\r\n" + "if (envelope.getResponse() != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SoapPrimitive response = (SoapPrimitive)envelope.getResponse();");
            strBuilder.AppendFormat("\r\n" + "String strResult = response.toString();");
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.IsFinished = true;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.errorId = 0;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.data = strResult;", objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "return strResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.IsFinished = true;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.errorId = 1;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.data = \"��WebApiû���յ�����!\";", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "result = \"��WebApiû���յ�����!\";");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "result = e.getMessage();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }



        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Java_run()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �̳�Runnable�����ʵ�ֵġ�run������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void run()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "Looper.prepare();");
            strBuilder.Append("\r\n" + "String strResult = \"\";");
            strBuilder.Append("\r\n" + "int intResult;");
            strBuilder.Append("\r\n" + "boolean bolResult;");

            strBuilder.Append("\r\n" + "Message msg = new Message();");
            strBuilder.Append("\r\n" + "Bundle data = new Bundle();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "switch (MethodName)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case \"GetObjBy{1}\":",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetObjBy{1}(Param);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.Append("\r\n" + "msg.what = 1;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetObjLst\":",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetObjLst(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 2;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.Append("\r\n" + "case \"AddNewRecord\":");
                strBuilder.AppendFormat("\r\n" + "strResult = AddNewRecord(Param, obj{0}EN);",
                      objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "msg.what = 3;");
                strBuilder.Append("\r\n" + "bolResult = Boolean.valueOf(strResult).booleanValue();");
                strBuilder.Append("\r\n" + "data.putBoolean(\"bolResult\", bolResult);");

                strBuilder.Append("\r\n" + "break;");
                strBuilder.Append("\r\n" + "case \"UpdateRecord\":");
                strBuilder.AppendFormat("\r\n" + "strResult = UpdateRecord(Param, obj{0}EN);",
                      objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "msg.what = 4;");
                strBuilder.Append("\r\n" + "bolResult = Boolean.valueOf(strResult).booleanValue();");
                strBuilder.Append("\r\n" + "data.putBoolean(\"bolResult\", bolResult);");

                strBuilder.Append("\r\n" + "break;");
                strBuilder.Append("\r\n" + "case \"DelRecord\":");
                strBuilder.Append("\r\n" + "strResult = DelRecord(Param);");
                strBuilder.Append("\r\n" + "msg.what = 5;");
                strBuilder.Append("\r\n" + "intResult = Integer.parseInt(strResult);");
                strBuilder.Append("\r\n" + "data.putInt(\"intResult\", intResult);");

                strBuilder.Append("\r\n" + "break;");
                strBuilder.AppendFormat("\r\n" + "case \"DelRecordsByJSON\":",
                    objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "strResult = DelRecordsByJSON(Param);",
                        objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "msg.what = 13;");
                strBuilder.Append("\r\n" + "intResult = Integer.parseInt(strResult);");
                strBuilder.Append("\r\n" + "data.putInt(\"intResult\", intResult);");

                strBuilder.Append("\r\n" + "break;");
            }
            strBuilder.AppendFormat("\r\n" + "case \"GetFirstObj\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetFirstObj(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 6;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"IsExistRecord\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = IsExistRecord(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 7;");
            strBuilder.Append("\r\n" + "bolResult = Boolean.valueOf(strResult).booleanValue();");
            strBuilder.Append("\r\n" + "data.putBoolean(\"bolResult\", bolResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrId\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetMaxStrId(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 8;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrIdByPrefix\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetMaxStrIdByPrefix(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 9;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetTopObjLst\":",
     objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetTopObjLst(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 10;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetObjLstByPager\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetObjLstByPager(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 11;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetRecCountByCond\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetRecCountByCond(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 12;");
            strBuilder.Append("\r\n" + "intResult = Integer.parseInt(strResult);");
            strBuilder.Append("\r\n" + "data.putInt(\"intResult\", intResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetObjLstByRange\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetObjLstByRange(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 14;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//      throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//��������Դ�������");
            strBuilder.Append("\r\n" + "data.putInt(\"COUNT\", 100);//COUNT�Ǳ�ǩ,handleMessage��ʹ��");

            strBuilder.Append("\r\n" + "msg.setData(data);");
            strBuilder.Append("\r\n" + "if (mHandler != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "mHandler.sendMessage(msg); // ��Handler������Ϣ,����UI");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "Looper.loop();");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_run_Java_SelfDefWA()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �̳�Runnable�����ʵ�ֵġ�run������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void run()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "Looper.prepare();");
            strBuilder.Append("\r\n" + "String strResult = \"\";");
            strBuilder.Append("\r\n" + "boolean bolResult;");

            strBuilder.Append("\r\n" + "Message msg = new Message();");
            strBuilder.Append("\r\n" + "Bundle data = new Bundle();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "switch (MethodName)");
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case \"{0}\":",
              objWebSrvFunctionsENEx.FunctionName);
                strBuilder.AppendFormat("\r\n" + "strResult = {0}WA(Param);",
                      objWebSrvFunctionsENEx.FunctionName);
                strBuilder.AppendFormat("\r\n" + "msg.what = {0};", intIndex);
                strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//      throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//��������Դ�������");
            strBuilder.Append("\r\n" + "data.putInt(\"COUNT\", 100);//COUNT�Ǳ�ǩ,handleMessage��ʹ��");

            strBuilder.Append("\r\n" + "msg.setData(data);");
            strBuilder.Append("\r\n" + "if (mHandler != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "mHandler.sendMessage(msg); // ��Handler������Ϣ,����UI");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "Looper.loop();");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
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
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Access4JAVA);
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
            this.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);


        }
    }
}
