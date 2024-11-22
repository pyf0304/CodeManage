using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AgcCommBase;
using System.Reflection;

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
    partial class WA_AppController4JAVABase : clsGeneCodeBase
    {

        #region ���캯��

        public WA_AppController4JAVABase()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_AppController4JAVABase(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
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
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_WA_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

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

                strBuilder.AppendFormat("\r\n" + "package {0}.GC.L5_WA_Controller.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strBuilder.Append("\r\n" + "import android.app.Activity;");
                strBuilder.Append("\r\n" + "import android.util.Log;");
                strBuilder.Append("\r\n" + "import android.widget.TextView;");
                strBuilder.Append("\r\n" + "import android.widget.EditText;");

                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WA.{2}.cls{1}WA4Controller;",
                            objProjectsENEx.JavaPackageName,
                              objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //

                strBuilder.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName,
                                    objPrjTabENEx.TabName); //

                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strBuilder.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWA4ControllerDelegate;"); //
                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsDate;"); //

                strBuilder.Append("\r\n" + "import java.util.List;"); //


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "public class  cls{0}_WA_Controller",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "private TextView tvMsg;");

                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                int intIndex = 1;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Invoke") <= 0) continue;

                    //string strTemp = "";
                    try
                    {
                        strTemp = GC_DeclareCtrlVar4FuncPara(objvFunction4GeneCodeEN, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.AppendFormat("\r\n" + "//Ϊ����[{0}��{1}]�Ĳ�����������ؼ���",
                                intIndex,
                                objvFunction4GeneCodeEN.FuncName4Code);
                            strBuilder.Append(strTemp + "\r\n");
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}��{1}]�޷�����.",
                                 intIndex,
                                 objvFunction4GeneCodeEN.FuncName4Code);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                        intIndex++;
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objvFunction4GeneCodeEN.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Java_icls") > 0) continue;

                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Java_icls") < 0) continue;
                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
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

        public string A_GeneFuncCode_Java_DeclareButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_DeclareButtonGetFirstObj":
                        return Gen_WA_Controller_Java_DeclareButtonGetFirstObj();

                    case "Gen_WA_Controller_Java_DeclareButtonGetObjByKey":
                        return Gen_WA_Controller_Java_DeclareButtonGetObjByKey();

                    case "Gen_WA_Controller_Java_DeclareButtonDelRecord":
                        return Gen_WA_Controller_Java_DeclareButtonDelRecord();
                    case "Gen_WA_Controller_Java_DeclareButtonDelRecordsByJSON":
                        return Gen_WA_Controller_Java_DeclareButtonDelRecordsByJSON();
                        
                    case "Gen_WA_Controller_Java_DeclareButtonAddNewRecord":
                        return Gen_WA_Controller_Java_DeclareButtonAddNewRecord();

                    case "Gen_WA_Controller_Java_DeclareButtonAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_DeclareButtonAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_DeclareButtonGetMaxStrId":
                        return Gen_WA_Controller_Java_DeclareButtonGetMaxStrId();
                    case "Gen_WA_Controller_Java_DeclareButtonGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_DeclareButtonGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_DeclareButtonUpdateRecord":
                        return Gen_WA_Controller_Java_DeclareButtonUpdateRecord();

                    case "Gen_WA_Controller_Java_DeclareButtonIsExistRecord":
                        return Gen_WA_Controller_Java_DeclareButtonIsExistRecord();

                    case "Gen_WA_Controller_Java_DeclareButtonGetRecCountByCond":
                        return Gen_WA_Controller_Java_DeclareButtonGetRecCountByCond();

                    case "Gen_WA_Controller_Java_DeclareButtonGetObjLst":
                        return Gen_WA_Controller_Java_DeclareButtonGetObjLst();

                    case "Gen_WA_Controller_Java_DeclareButtonGetTopObjLst":
                        return Gen_WA_Controller_Java_DeclareButtonGetTopObjLst();

                    case "Gen_WA_Controller_Java_DeclareButtonGetObjLstByPager":
                        return Gen_WA_Controller_Java_DeclareButtonGetObjLstByPager();
                    case "Gen_WA_Controller_Java_DeclareButtontvMsg":
                        return Gen_WA_Controller_Java_DeclareButtontvMsg();
                        
                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����({0})",
                             clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///��1����������:" + strFuncName;
                }
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
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DeclareButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            //string strFunctionName_CN = "����¼�¼";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);
        
            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            //string strFunctionName_CN = "����¼�¼(��ȡ���ؼ���)";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            //string strFunctionName_CN = "��ȡ���ؼ���ֵ,����ǰ׺";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            //string strFunctionName_CN = "�޸ļ�¼";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            //string strFunctionName_CN = "ɾ����¼";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);

            return strBuilder.ToString();
        }
               
        public string Gen_WA_Controller_Java_DeclareButtonDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            //string strFunctionName_CN = "ͨ��JSONɾ��������¼";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);

            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DeclareButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            //string strFunctionName_CN = "����Ƿ���ڼ�¼";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            //string strFunctionName_CN = "����������ȡ��¼��";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }


        public string Gen_WA_Controller_Java_DeclareButtonGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLst";
            //string strFunctionName_CN = "��ȡ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopObjLst";
            //string strFunctionName_CN = "��ȡ������¼�����б�";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            //string strFunctionName_CN = "��ȡ��ҳ��¼�����б�";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjByKey";
            //string strFunctionName_CN = "���ݹؼ��ֻ�ȡ����";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtontvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);
            
            return strBuilder.ToString();
        }
        public string Gen_WA_Controller_Java_DeclareButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "��ȡ���������ĵ�һ����¼����";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", objWebSrvFunctionsENEx.FunctionName);

            return strBuilder.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppController4JAVA);
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
            this.ClsName = string.Format("cls{0}_WA_Controller", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
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
        private string GC_DeclareCtrlVar4FuncPara(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
                 List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";

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

                }
                else
                {
                    string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    arrValueLst.Add(strParaName_New);
                    objWebSrvFuncParaEN._StrTag = strParaName_New;
                    sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                }
            }
            return sbCode.ToString();
        }
        private string GC_DeclareCtrlVar4FuncPara(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
            List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
               clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {

                    }
                    else
                    {
                        string strParaName_New = clsString.GetUniqueStrValue_S(objFuncPara4CodeEN.ParaName, arrValueLst);
                        arrValueLst.Add(strParaName_New);
                        objFuncPara4CodeEN._StrTag = strParaName_New;
                        sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                    }
                }
            }
            return sbCode.ToString();
        }
    }
}
