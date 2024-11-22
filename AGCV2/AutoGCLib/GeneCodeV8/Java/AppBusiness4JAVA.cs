using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
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
    partial class AppBusiness4JAVA : clsGeneCodeBase
    {

        #region ���캯��

        public AppBusiness4JAVA()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AppBusiness4JAVA(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_ABL";
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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L51_AppBusiness.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import android.app.Activity;");
                strCodeForCs.Append("\r\n" + "import android.widget.TextView;");
                strCodeForCs.Append("\r\n" + "import android.widget.EditText;");
                strCodeForCs.Append("\r\n" + "import android.view.View;");
                strCodeForCs.Append("\r\n" + "import android.util.Log;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WS.{2}.cls{1}WS4Controller;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L5_Controller.{2}.cls{1}_Controller;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.Task;");
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.TaskQueue;");
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsExecTask;");
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsParentObjDelegate;");
                strCodeForCs.AppendFormat("\r\n" + "import com.taishsoft.util.clsDate;");
                strCodeForCs.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName,
                                    objPrjTabENEx.TabName); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWS4ControllerDelegate;"); //
                strCodeForCs.Append("\r\n" + "import java.util.ArrayList;"); //

                strCodeForCs.Append("\r\n" + "import java.util.List;"); //

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  cls{0}_ABL extends Activity",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "private String mstrCurrFuncName = \"\";");
                strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arrAll{0}ObjLstCache = null;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//�û�����ʽ����WebService�ķ�������ִ������Ķ���");
                strCodeForCs.Append("\r\n" + "private clsParentObjDelegate mobjParentObjDelegate_Task = null;");
                strCodeForCs.Append("\r\n" + "private iclsExecTaskEx iobjExecTaskEx = null;");
                strCodeForCs.Append("\r\n" + "//�������");
                strCodeForCs.Append("\r\n" + "private TaskQueue mobjTaskQueue = null;");
                strCodeForCs.Append("\r\n" + "private int mintTotalRecCount;");
                strCodeForCs.Append("\r\n" + "private int mintPageIndex;");
                strCodeForCs.Append("\r\n" + "//ÿ�η���WebService��ȡ�ļ�¼���������¼��̫�����׳���");
                strCodeForCs.Append("\r\n" + "private int mintPageSize = 3;");
                strCodeForCs.Append("\r\n" + "//��ҳ��");
                strCodeForCs.Append("\r\n" + "private int mintTotalPages = 0;");
                strCodeForCs.Append("\r\n" + "//��С������¼���");
                strCodeForCs.Append("\r\n" + "private int mintMinNum = 0;");
                strCodeForCs.Append("\r\n" + "private int mintMaxNum = 0;");
                strCodeForCs.Append("\r\n" + "//�ܵ�����¼���");
                strCodeForCs.Append("\r\n" + "private int mintTotalMaxNum = 0;");
                
                strCodeForCs.Append("\r\n" + "//���ڻص��ĸ�����,֪ͨ���������������");
                strCodeForCs.Append("\r\n" + "private clsParentObjDelegate mobjParentObjDelegate = null;");
                strCodeForCs.Append("\r\n" + " //Ϊ����[GetRecCountByCond]�Ĳ������������");
                strCodeForCs.Append("\r\n" + "private String mstrWhereCond;");

                strCodeForCs.Append("\r\n" + "private String mstrOrderBy;");
                strCodeForCs.Append("\r\n" + "private TextView tvMsg;");

                strCodeForCs.AppendFormat("\r\n" + "public cls{0}_ABL(clsParentObjDelegate objParentObjDelegate)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "mobjParentObjDelegate = objParentObjDelegate;");
                strCodeForCs.Append("\r\n" + "iobjExecTaskEx = new iclsExecTaskEx();");
                strCodeForCs.Append("\r\n" + "mobjTaskQueue = new TaskQueue(iobjExecTaskEx);");
                strCodeForCs.Append("\r\n" + "mobjParentObjDelegate_Task = mobjTaskQueue.getParentObjDelegate();");

                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                int intIndex = 1;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("btnClick") <= 0) continue;

                    //string strTemp = "";
                    try
                    {
                        strTemp = GC_DeclareCtrlVar4FuncPara(objvFunction4GeneCodeEN, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "//Ϊ����[{0}��{1}]�Ĳ�����������ؼ���",
                                intIndex,
                                objvFunction4GeneCodeEN.FuncName4Code);
                            strCodeForCs.Append(strTemp + "\r\n");
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}��{1}]�޷�����.",
                                 intIndex,
                                 objvFunction4GeneCodeEN.FuncName4Code);
                            strCodeForCs.Append("\r\n" + strTemp);
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
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";

                    strTemp = A_GeneFuncCode_Java_AppBusiness(objvFunction4GeneCodeEN);


                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

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

        public string A_GeneFuncCode_Java_AppBusiness(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
             string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {

                switch (strFuncName)
                {

                    case "Gen_AppBusiness_Java_GetRecCountByCond":
                        return Gen_AppBusiness_Java_GetRecCountByCond();

                    case "Gen_AppBusiness_Java_Class4ExecTaskEx":
                        return Gen_AppBusiness_Java_Class4ExecTaskEx();

                    case "Gen_AppBusiness_Java_InsertObjLstToAllObjLst":
                        return Gen_AppBusiness_Java_InsertObjLstToAllObjLst();

                    case "Gen_AppBusiness_Java_GetJSONObjLstByRange":
                        return Gen_AppBusiness_Java_GetJSONObjLstByRange();
                    case "Gen_AppBusiness_Java_IsExistKeyId":
                        return Gen_AppBusiness_Java_IsExistKeyId();
                    case "Gen_AppBusiness_Java_GetJSONObjLst":
                        return Gen_AppBusiness_Java_GetJSONObjLst();
                    case "Gen_AppBusiness_Java_GetJSONObjLstByPager":
                        return Gen_AppBusiness_Java_GetJSONObjLstByPager();
                    case "Gen_AppBusiness_Java_AddTask":
                        return Gen_AppBusiness_Java_AddTask();
                        
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
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_AppBusiness_Java_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "public void GetRecCountByCond() {");


            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetRecCountByCondEx iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCondEx(null);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetRecCountByCondEx extends  cls{0}_Controller.icls{0}GetRecCountByCond",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetRecCountByCondEx(Object pvcParent)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = mstrWhereCond;");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = mstrWhereCond;");

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s]�ļ�¼��:[%s]!\", strWhereCond, returnInt);",
                objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((ac{0}_UnitTest)vcParent, strInfo);",
            //    objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + " Log.d(\"cls{0}_ABL\", strInfo);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "  mintTotalRecCount = returnInt;//�ܼ�¼��,���ڻ�ȡ��ҳ�����б�");

            strCodeForCs.Append("\r\n" + "  mintTotalPages = mintTotalRecCount / mintPageSize;//��ҳ��,���ڻ�ȡ��ҳ�����б�");
            strCodeForCs.Append("\r\n" + "  if (mintTotalRecCount > mintTotalPages * mintPageSize)");
            strCodeForCs.Append("\r\n" + " {");
            strCodeForCs.Append("\r\n" + "     mintTotalPages++;");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + "mintMinNum = 1;");
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintPageSize;");
            strCodeForCs.Append("\r\n" + "mintTotalMaxNum = mintTotalRecCount;");

            strCodeForCs.Append("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"GetRecCountByCond\", 1);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_AppBusiness_Java_Class4ExecTaskEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼�������չ��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "class iclsExecTaskEx extends clsExecTask");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.Append("\r\n" + "public void ExecTask(Task myTask)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "switch (myTask.getTaskName())");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"GetRecCountByCond\":");
            strCodeForCs.Append("\r\n" + "GetRecCountByCond();");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"GetJSONObjLstByRange\":");
            strCodeForCs.Append("\r\n" + "GetJSONObjLstByRange();");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "String strMsg = String.format(\"������������[%s]û�б�����\", myTask.getTaskName());");
            strCodeForCs.Append("\r\n" + "System.out.println(strMsg); //����쳣��Ϣ");
            //  throw new Exception("AAA");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_AppBusiness_Java_InsertObjLstToAllObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �Ѷ����б���ӵ��ܶ����б���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"arr{0}ObjLst\">��Ҫ���ӵĶ���</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void InsertObjLstToAllObjLst(List<cls{0}EN> arr{0}ObjLst)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}_ABL.arrAll{0}ObjLstCache == null)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}_ABL.arrAll{0}ObjLstCache = new ArrayList<>();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "for (cls{0}EN obj{0}EN : arr{0}ObjLst)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (IsExistKeyId(obj{0}EN.get{1}()) == false)",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}_ABL.arrAll{0}ObjLstCache.add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_AppBusiness_Java_IsExistKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �Ѷ����б���ӵ��ܶ����б���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strKeyId\">�����Ĺؼ���</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public boolean IsExistKeyId({0} {1})", 
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "for (cls{0}EN obj{0}EN : cls{0}_ABL.arrAll{0}ObjLstCache)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            switch(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType)
            {
                case "long":
                case "Long":
                case "int":
                case "Integer":
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.get{1}() == {2}) return true;",
                          objPrjTabENEx.TabName,
                         objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    break;
                default:
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.get{1}().equals({2}) == true) return true;",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    break;
            }
   
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_AppBusiness_Java_GetJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����������</param>");
            strCodeForCs.Append("\r\n /// <returns>ͨ������:[Finished_GetJSONObjLst]���ض����б�</returns>");

            strCodeForCs.Append("\r\n" + "public void GetJSONObjLst(String strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mstrCurrFuncName = \"GetJSONObjLst\";");
            strCodeForCs.Append("\r\n" + "mstrWhereCond = strWhereCond;");
            strCodeForCs.Append("\r\n" + "//1����ȡ��¼��");

            strCodeForCs.Append("\r\n" + "//2��ÿ��3����¼,ѭ����ȡ���м�¼");
            strCodeForCs.Append("\r\n" + "mintPageIndex = 1;");
            strCodeForCs.Append("\r\n" + "mintMinNum = 1;");
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintPageSize;");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetRecCountByCond\");");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetJSONObjLstByRange\");");

            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������,���߸�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void Finished_GetJSONObjLst()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strMsg = String.format(\"����GetJSONObjLst���!���ƣ�%d��¼!\",");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}_ABL.arrAll{0}ObjLstCache.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Log.d(\"cls{0}_ABL\", strMsg);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"Finished_GetJSONObjLst\", cls{0}_ABL.arrAll{0}ObjLstCache.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_AppBusiness_Java_GetJSONObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����������</param>");
            strCodeForCs.Append("\r\n /// <returns>ͨ������:[Finished_GetJSONObjLst]���ض����б�</returns>");

            strCodeForCs.Append("\r\n" + "public void GetJSONObjLstByPager(Integer intPageIndex, Integer intPageSize, String strWhereCond, String strOrderBy)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mstrCurrFuncName = \"GetJSONObjLstByPager\";");
            strCodeForCs.Append("\r\n" + "mstrWhereCond = strWhereCond;");
            strCodeForCs.Append("\r\n" + "mstrOrderBy = strOrderBy;");
            strCodeForCs.Append("\r\n" + "//1����ȡ��¼��");

            strCodeForCs.Append("\r\n" + "//2��ÿ��3����¼,ѭ����ȡ���м�¼");
            strCodeForCs.Append("\r\n" + "mintPageIndex = intPageIndex;");
            strCodeForCs.Append("\r\n" + "if (intPageIndex>1) {");
            strCodeForCs.Append("\r\n" + "mintMinNum = (intPageIndex - 1) * intPageSize + 1; //intPageSize �ͻ�Ҫ���ҳ��С ");
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintPageSize + mintMinNum - 1; // mintPageSizeΪ����WebServiceʱ��ҳ��С");
            strCodeForCs.Append("\r\n" + "mintTotalMaxNum = intPageIndex * intPageSize;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mintMinNum = 1;");
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintPageSize;// mintPageSizeΪ����WebServiceʱ��ҳ��С");
            strCodeForCs.Append("\r\n" + "mintTotalMaxNum = intPageIndex * intPageSize;//intPageSize �ͻ�Ҫ���ҳ��С");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (mintMaxNum>mintTotalMaxNum) {");       
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintTotalMaxNum; // mintPageSizeΪ����WebServiceʱ��ҳ��С");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}_ABL.arrAll{0}ObjLstCache = null; ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//AddTask(\"GetRecCountByCond\");");
            strCodeForCs.Append("\r\n" + "AddTask(\"GetJSONObjLstByRange\");");

            strCodeForCs.Append("\r\n" + "mobjTaskQueue.ExecTask();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������,���߸�����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public void Finished_GetJSONObjLstByPager()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "String strMsg = String.format(\"����GetJSONObjLst���!���ƣ�%d��¼!\",");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}_ABL.arrAll{0}ObjLstCache.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Log.d(\"cls{0}_ABL\", strMsg);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"Finished_GetJSONObjLstByPager\", cls{0}_ABL.arrAll{0}ObjLstCache.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_AppBusiness_Java_GetJSONObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Χ����Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void GetJSONObjLstByRange() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByRangeEx iobj{0}GetJSONObjLstByRange = new icls{0}GetJSONObjLstByRangeEx(null);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByRange.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByRangeEx extends  cls{0}_Controller.icls{0}GetJSONObjLstByRange",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstByRangeEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //int intMinNum = Long.valueOf(txtintMaxNum.getText().toString());
            //int intMinNum = Long.valueOf(txtintMinNum.getText().toString());

            //strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "String strOrderBy =\"\";");
            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond =  mstrWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "String strOrderBy = mstrOrderBy;");

            strCodeForCs.AppendFormat("\r\n" + "int intMinNum = mintMinNum;");
            strCodeForCs.AppendFormat("\r\n" + "int intMaxNum = mintMaxNum;");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByRange,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "String strWhereCond =  mstrWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "String strOrderBy = mstrOrderBy;");

            strCodeForCs.AppendFormat("\r\n" + "int intMinNum = mintMinNum;");
            strCodeForCs.AppendFormat("\r\n" + "int intMaxNum = mintMaxNum;");

            strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"��������:[%s],��С��¼��:[%d],����¼��:[%d],����ȡ��ҳ�����б�����%s!\", strWhereCond, intMinNum, intMaxNum, arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            
            strCodeForCs.AppendFormat("\r\n" + "Log.d(\"cls{0}_ABL\", strInfo);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "InsertObjLstToAllObjLst(arr{0}ObjLst);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (intMaxNum < mintTotalMaxNum)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mintMinNum = mintMaxNum + 1;");
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintMaxNum + mintPageSize;");
            strCodeForCs.Append("\r\n" + "if (mintMaxNum>mintTotalMaxNum) {");
            strCodeForCs.Append("\r\n" + "mintMaxNum = mintTotalMaxNum; // mintPageSizeΪ����WebServiceʱ��ҳ��С");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "GetJSONObjLstByRange();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (mstrCurrFuncName.equals(\"GetJSONObjLst\"))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Finished_GetJSONObjLst();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (mstrCurrFuncName.equals(\"GetJSONObjLstByPager\"))");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Finished_GetJSONObjLstByPager();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "Finished_GetJSONObjLst();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "mobjParentObjDelegate_Task.NotifyFinished(\"GetJSONObjLstByRange\", 1);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_AppBusiness_Java_AddTask()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ������������������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strTaskName\">��������</param>");
            //strCodeForCs.Append("\r\n /// <param name = \"objSpinner\">���������</param>");
            //strCodeForCs.Append("\r\n /// <param name = \"objDdlBind\">������󶨶���</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + " private void AddTask(String strTaskName)");
            strCodeForCs.Append("\r\n" + " {");
            strCodeForCs.Append("\r\n" + " Task objTask = new Task();");
            strCodeForCs.Append("\r\n" + " objTask.setTaskName(strTaskName);");
            //strCodeForCs.Append("\r\n" + " objTask.setSpinner(objSpinner);");
            //strCodeForCs.Append("\r\n" + " objTask.setActivity(this);");
            //strCodeForCs.Append("\r\n" + " objTask.setDdlBind(objDdlBind);");
            strCodeForCs.Append("\r\n" + " objTask.setState(Task.State.NEW);");
            strCodeForCs.Append("\r\n" + " mobjTaskQueue.addTask(objTask);");
            strCodeForCs.Append("\r\n" + " }");
            return strCodeForCs.ToString();
        }


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppBusiness4JAVA);
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
            this.ClsName = string.Format("cls{0}_ABL", objPrjTabENEx.TabName);
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
