using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    partial class AutoGC6_Controller : AutoGCPubFuncV6
    {

        /// <summary>
        /// ����Web Serviceת�������--Swift3
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift3(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_QUDI";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strBuilder.AppendFormat("\r\n" + "*      3�����������ΪUIViewContraller����Ļ��ࣻ");
                strBuilder.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strBuilder.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_QUDI.", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class  cls{0}_QUDI : NSObject",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift3_icls") > 0) continue;

                    if (strFuncName.IndexOf("Swift3_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_btnClick(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_Invoke(strFuncName);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift3(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift3_icls") < 0) continue;
                    if (strFuncName.IndexOf("Swift3_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_btnClick(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_Invoke(strFuncName);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift3(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
           
            }
            return strBuilder.ToString();
        }
        public string A_GenController_Swift3_UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, "this.CmPrjId"));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strBuilder.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strBuilder.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strBuilder.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_UnitTest.", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class vc{0}_UnitTest : UIViewController",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strBuilder.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strBuilder.Append("\r\n" + "override func viewDidLoad()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.viewDidLoad()");

                strBuilder.Append("\r\n" + "// Do any additional setup after loading the view.");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strBuilder.Append("\r\n" + "}");

                //�������еĺ���


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift3_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_btnClick(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_Invoke(strFuncName);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift3(strFuncName);
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

        public string A_GenController_Swift3_UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, "this.CmPrjId"));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strBuilder.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strBuilder.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strBuilder.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_UnitTest.", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class vc{0}_UTScript : UIViewController",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strBuilder.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strBuilder.Append("\r\n" + "override func viewDidLoad()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.viewDidLoad()");

                strBuilder.Append("\r\n" + "// Do any additional setup after loading the view.");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strBuilder.Append("\r\n" + "}");

                //�������еĺ���


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift3_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_btnClick(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_Invoke(strFuncName);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift3(strFuncName);
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


        /// <summary>
        /// ����Web Serviceת�������--Swift3
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift3_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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


            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClsName+ "4SD_Controller";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare); 
            
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strBuilder.AppendFormat("\r\n" + "*      3�����������ΪUIViewContraller����Ļ��ࣻ");
                strBuilder.AppendFormat("\r\n" + "*      4�����������:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strBuilder.AppendFormat("\r\n" + "*              ���磺class vc{0}Ex : vc{0}.", objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class  cls{0}4SD_Controller : NSObject",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                //strBuilder.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                //strBuilder.Append("\r\n" + "override func viewDidLoad()");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "super.viewDidLoad()");

                //strBuilder.Append("\r\n" + "// Do any additional setup after loading the view.");
                //strBuilder.Append("\r\n" + "}");

                //strBuilder.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strBuilder.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strBuilder.Append("\r\n" + "}");

                //�������к����ĵ��ú���

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift3_InvokeByCommonFunction(objWebSrvFunctionsENEx);
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

                strBuilder.Append("\r\n" + "}");

                //�������к������ڲ��ຯ��
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift3_iclsByCommonFunction(objWebSrvFunctionsENEx);
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
             

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public string A_GenController_Swift3_SelfDefWs4UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName + "4SD_UnitTest";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strBuilder.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strBuilder.AppendFormat("\r\n" + "*      4�����������:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strBuilder.AppendFormat("\r\n" + "*              ���磺class tvc{0}Ex : tvc{0}.", objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class vc{0}4SD_UnitTest : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strBuilder.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strBuilder.Append("\r\n" + "override func viewDidLoad()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.viewDidLoad()");

                strBuilder.Append("\r\n" + "// Do any additional setup after loading the view.");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strBuilder.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift3_btnClickByCommonFunction(objWebSrvFunctionsENEx);
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

                strBuilder.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }
        public string A_GenController_Swift3_SelfDefWs4UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName + "_SelfDef4UTScript";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strBuilder.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strBuilder.AppendFormat("\r\n" + "*      4�����������:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strBuilder.AppendFormat("\r\n" + "*              ���磺class tvc{0}Ex : tvc{0}.", objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "class vc{0}_SelfDef4UTScript : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strBuilder.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strBuilder.Append("\r\n" + "override func viewDidLoad()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.viewDidLoad()");

                strBuilder.Append("\r\n" + "// Do any additional setup after loading the view.");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strBuilder.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strBuilder.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift3_btnClickByCommonFunction(objWebSrvFunctionsENEx);
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

                strBuilder.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����Web Serviceת�������--Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Swift3(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId("this.CmPrjId"),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = string.Format("cls{0}WS4Controller", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, "this.CmPrjId"));
                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objPrjTabENEx.TabCnName,
                    objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strBuilder.Append("\r\n" + "const queue : OperationQueue!");

                strBuilder.Append("\r\n" + "const theTimer: Timer!");
                strBuilder.Append("\r\n" + "override init()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "queue = OperationQueue();");

                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>, pobj{0}EN : cls{0}EN)",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "queue = OperationQueue();");
                strBuilder.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift3_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_btnClick(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift3_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift3_Invoke(strFuncName);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift3(strFuncName);
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

        /// <summary>
        /// ����Web Serviceת�������--Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Swift3_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
            //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objWebSrvClassENEx.FunctionTemplateId,
            //  objWebSrvClassENEx.LangType, objWebSrvClassENEx.ProgLevelTypeId, objWebSrvClassENEx.SqlDsTypeId);


            objWebSrvClassENEx.ClsName = string.Format("{0}WS4Controller", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);

            string strIsShare = objPrjTabENEx.IsShare == true ? "_Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}{2}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName, strIsShare);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));
                strBuilder.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);

                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + " **/");
                strBuilder.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strBuilder.Append("\r\n" + "const queue : OperationQueue!");

                strBuilder.Append("\r\n" + "const theTimer: Timer!");
                strBuilder.Append("\r\n" + "override init()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "queue = OperationQueue();");

                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "queue = OperationQueue();");
                strBuilder.Append("\r\n" + "}");

                //�������еĺ���
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_Swift3_ByCommonFunction(objWebSrvFunctionsENEx);
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
                strTemp = A_GeneFuncCode_Swift3("Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService");
                strBuilder.Append("\r\n" + strTemp);
              
                strBuilder.Append("\r\n" + "}");

                ////������д���ļ���;
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



        public string A_GeneFuncCode_Swift3(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {
                    case "btnGetFirstJSONObj_Click":
                        return btnGetFirstJSONObj_Click();

                    case "Gen_Controller_Swift3_btnGetFirstJSONObj_Click":
                    case "Gen_Controller_Swift3_btnGetFirstJSONObj_Click4tvc":
                        return Gen_Controller_Swift3_btnGetFirstJSONObj_Click();

                    case "Gen_Controller_Swift3_btnGetJSONObjByKey_Click":
                    case "Gen_Controller_Swift3_btnGetJSONObjByKey_Click4tvc":
                        return Gen_Controller_Swift3_btnGetJSONObjByKey_Click();


                    case "Gen_4WS4Controller_Swift3_GetFirstJSONObj":
                        return Gen_4WS4Controller_Swift3_GetFirstJSONObj();

                    case "Gen_4WS4Controller_Swift3_GetRecordObjByKey":
                        return Gen_4WS4Controller_Swift3_GetRecordObjByKey();

                    case "IsFinished4WebService":
                        return IsFinished4WebService();
                    //case "IsFinished4WebService":
                    //    return IsFinished4WebService();


                    case "Gen_4WS4Controller_Swift3_IsFinished4WebService":                    
                        return Gen_4WS4Controller_Swift3_IsFinished4WebService();
                    case "Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService":
                        return Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService();

                    case "Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService_Swift3":               
                        return Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService_Swift3BaK20170814();

                    case "btnDelRecord_Click":
                        return btnDelRecord_Click();

                    case "Gen_Controller_Swift3_btnDelRecord_Click":
                    case "Gen_Controller_Swift3_btnDelRecord_Click4tvc":
                        return Gen_Controller_Swift3_btnDelRecord_Click();

                    case "Gen_4WS4Controller_Swift3_DelRecord":                  
                        return Gen_4WS4Controller_Swift3_DelRecord();

                    //case "Gen_4Ws_run_Java":
                    //    return Gen_4Ws_run_Java();

                    case "btnAddNewRecord_Click":
                        return btnAddNewRecord_Click();

                    case "Gen_Controller_Swift3_btnAddNewRecord_Click":
                    case "Gen_Controller_Swift3_btnAddNewRecord_Click4tvc":
                        return Gen_Controller_Swift3_btnAddNewRecord_Click();


                    case "Gen_Controller_Swift3_btnAddNewRecord4GetMaxStrId_Click":
                    case "Gen_Controller_Swift3_btnAddNewRecord4GetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift3_btnAddNewRecord4GetMaxStrId_Click();
                    case "Gen_Controller_Swift3_btnGetMaxStrId_Click":
                    case "Gen_Controller_Swift3_btnGetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift3_btnGetMaxStrId_Click();
                    case "Gen_Controller_Swift3_btnGetMaxStrIdByPrefix_Click":
                    case "Gen_Controller_Swift3_btnGetMaxStrIdByPrefix_Click4tvc":
                        return Gen_Controller_Swift3_btnGetMaxStrIdByPrefix_Click();

                    case "Gen_4WS4Controller_Swift3_AddNewRecord":
                        return Gen_4WS4Controller_Swift3_AddNewRecord();


                    case "btnUpdateRecord_Click":
                        return btnUpdateRecord_Click();

                    case "Gen_Controller_Swift3_btnUpdateRecord_Click":
                    case "Gen_Controller_Swift3_btnUpdateRecord_Click4tvc":
                        return Gen_Controller_Swift3_btnUpdateRecord_Click();

                    case "Gen_4WS4Controller_Swift3_UpdateRecord":
                        return Gen_4WS4Controller_Swift3_UpdateRecord();

                    case "Gen_Controller_Swift3_btnIsExistRecord_Click":
                    case "Gen_Controller_Swift3_btnIsExistRecord_Click4tvc":
                        return Gen_Controller_Swift3_btnIsExistRecord_Click();

                    case "Gen_4WS4Controller_Swift3_IsExistRecord":
                        return Gen_4WS4Controller_Swift3_IsExistRecord();

                    case "Gen_4WS4Controller_Swift3_GetRecCountByCond":
                        return Gen_4WS4Controller_Swift3_GetRecCountByCond();

                    case "Gen_4WS4Controller_Swift3_GetMaxStrId":
                        return Gen_4WS4Controller_Swift3_GetMaxStrId();

                    case "Gen_4WS4Controller_Swift3_GetMaxStrIdByPrefix":
                        return Gen_4WS4Controller_Swift3_GetMaxStrIdByPrefix();

                    case "btnGetJSONObjLst_Click":
                        return btnGetJSONObjLst_Click();

                    case "Gen_Controller_Swift3_btnGetJSONObjLst_Click":
                    case "Gen_Controller_Swift3_btnGetJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift3_btnGetJSONObjLst_Click();
                    case "Gen_Controller_Swift3_btnGetTopJSONObjLst_Click":
                    case "Gen_Controller_Swift3_btnGetTopJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift3_btnGetTopJSONObjLst_Click();

                    case "Gen_4WS4Controller_Swift3_GetJSONObjLst":
                        return Gen_4WS4Controller_Swift3_GetJSONObjLst();

                    case "Gen_4WS4Controller_Swift3_GetTopJSONObjLst":
                        return Gen_4WS4Controller_Swift3_GetTopJSONObjLst();

                    case "Gen_4WS4Controller_Swift3_GetJSONObjLstByPager":
                        return Gen_4WS4Controller_Swift3_GetJSONObjLstByPager();

                    case "GenDdlBindFunction":
                        return GenDdlBindFunction();


                    case "GenComboBoxBindFunction":
                        return GenComboBoxBindFunction();
                    case "GenBindListView":
                        return GenBindListView();
                    case "GetStrLen":
                        return GengetStrLen();


                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����!({0})",
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

        public string gfunConnectString()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�;
            strBuilder.Append("\r\n//�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�");
            strBuilder.Append("\r\nprivate static string m_strConnectString;");

            strBuilder.Append("\r\npublic static string ConnectString");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget { return m_strConnectString; }");
            strBuilder.Append("\r\nset { m_strConnectString = value; }");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string gfunpErrNo()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���Թ���;
            ///ÿ�����඼Ӧ���еĴ��������;
            strBuilder.Append("\r\npublic int ErrNo");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n mintErrNo = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunDispErrMsg()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///ÿ�����඼Ӧ���еĶ�����ʾ�Ĵ�����Ϣ;
            strBuilder.Append("\r\npublic string DispErrMsg //������ʾ�Ĵ�����Ϣ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return objPrjTabENEx.DispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPrjTabENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetTopDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetDataSetByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetByRange(string strWhereCond, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��ǰ����ͼ�����ݼ�,��DataSet��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetVByRange(string strWhereCond, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetVByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public List<cls{0}EN> {0}GetObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string gfunCheckUniqueness()
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
                    
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " != '{0}' and "
                  + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (new cls{0}BL.IsExistRecord(sbCondition.ToString()) == true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\npublic void CheckPropertyNew()");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    strBuilder.Append("\r\nif (Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") ");
                    strBuilder.Append("\r\n|| (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && " + objField.ObjFieldTabENEx.PrivPropName + " .ToString() == \"\")");
                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strBuilder.Append("\r\n|| (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && " + objField.ObjFieldTabENEx.PrivPropName + " .ToString() == \"0\")");
                    }
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]����Ϊ��(NULL)!\");",
                    objField.ColCaption);
                    strBuilder.Append("\r\n}");
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && GetStrLen(" + objField.ObjFieldTabENEx.PrivPropName + ") > " + objField.ObjFieldTabENEx.FldLength.ToString().Trim() + ")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\npublic {0} {1}GetFirstID_S(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}BL.GetFirstID_S(strWhereCond);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡFirst�ؼ��ֳ���!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ��ؼ�¼����,����ж������,��ȡ���еĵ�һ��,����������������
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ķ���</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\npublic cls{0}EN {0}GetFirstObj_S(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡFirst��¼�������!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetRecordObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ��ֵ�ֵ</param>",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetObjBy{1}({2}: {3})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }

            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjBy{1}\",",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4WS4Controller_Swift3_GetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetFirst{0}(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetFirstJSONObj\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_4WS4Controller_Swift3_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");

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
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.JavaType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{1}: {0},",
                            objSelfDefDataTypeEN_Para.SwiftType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{1}: {0},",
                            objDataTypeAbbrEN.SwiftType,
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

            strBuilder.AppendFormat("\r\n" + "public func {0}({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
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
                    strMsg = string.Format("Swift���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                        objWebSrvFuncParaEN.ParaName,
                          objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);

                    //if (objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0}.toString());",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                                objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.SwiftType)
                        {
                            case "Int":
                                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                //strBuilder.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Integer.toString({0}));",
                                //    objWebSrvFuncParaEN.ParaName);
                                break;
                            default:
                                strMsg = string.Format("Swift���ͣ�[{0}]û���ں����б�����!({1})",
                                    objDataTypeAbbrEN.SwiftType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                }
            }
            //strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : {0}WS = {0}WS(strMethod: \"{1}\",",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "mapParam: values);");
            //strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift3_btnGetJSONObjByKey_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjByKey_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetObjBy{1} : icls{0}GetObjBy{1} = icls{0}GetObjBy{1}(pvcParent: self);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjBy{1} : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2}: {2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"���ݹؼ��֡�01�� ��ȡ����\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_btnGetFirstJSONObj_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnGetFirstJSONObj_Click(_ sender: Any) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetFirstObj : icls{0}GetFirstObj = icls{0}GetFirstObj(pvcParent: self);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetFirstObj : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"������������1=1�� ��ȡ��һ����¼����\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ú�����[{0}]", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "@IBAction func Invoke_{0}() ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0} : icls{0} = icls{0}(pvcParent: self);",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}.main();",
                objWebSrvFunctionsENEx.FunctionName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0} : NSObject, clsTableObjWS4ControllerDelegate",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            //strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
            //    objWebSrvFunctionsENEx.TabName);

            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : {0}WS4Controller = {0}WS4Controller();",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objWebSrvClassENEx.ClsName);
            string strMsg = "";
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
                    strMsg = string.Format("Swift���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + " let {1} : {0} = \"{2}\";",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + " let {1} : {0} = {2};",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.SwiftType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0}: {0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            //  strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName,
                sbParaVarList.ToString());
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//ͨ��WebServiceִ��{0},���ص��¼�����,������Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "func {0}(strResult: String, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
            //    objWebSrvFunctionsENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����:[{0}]����ֵΪ��\\(strResult)!\"",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����������ȡ��Ӧ�ļ�¼�����б� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetJSONObjLst(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLst\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����������ȡ��Ӧ�ļ�¼�����б� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</strWhereCond>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetTopJSONObjLst(intTopSize: Int, strWhereCond: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "values[\"intTopSize\"] = String(intTopSize);");
            strBuilder.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetTopJSONObjLst\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����������ȡ��Ӧ�ļ�¼�����б� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public func GetJSONObjLstByPager(intPageIndex: Int, intPageSize: Int, strWhereCond: String, strOrderBy: String)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "values[\"intPageIndex\"] = String(intPageIndex);");
            strBuilder.AppendFormat("\r\n" + "values[\"intPageSize\"] = String(intPageSize);");
            strBuilder.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "values[\"strOrderBy\"] = strOrderBy;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLstByPager\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        

        public string Gen_Controller_Swift3_btnGetJSONObjLst_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLst : icls{0}GetJSONObjLst = icls{0}GetJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����ȡ�����б�����\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift3_btnGetTopJSONObjLst_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ������������б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "@IBAction func btnGetTopJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetTopJSONObjLst : icls{0}GetTopJSONObjLst = icls{0}GetTopJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetTopJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let intTopSize : Int = 2;");
            strBuilder.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize: intTopSize, strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetTopRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����ȡ�����б�����\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift3_btnIsExistRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnIsExistRecord_Click(_ sender: Any) {");


            strBuilder.Append("\r\n" + "let iobjIsExistRecord : iclsIsExistRecord = iclsIsExistRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjIsExistRecord.main();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsIsExistRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strWhereCond : String = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord, enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch strClassName {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"������������{0}='12'�� ������!\"",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"������������{0}='12'�� ����!\"",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default: ");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���������ڱ��м���Ƿ����������ļ�¼");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�����ڵ�����</param>");
            strBuilder.Append("\r\n /// <returns>���ڷ���true,�����ڷ��أ�false</returns>");
            strBuilder.Append("\r\n" + "public func IsExistRecord(strWhereCond : String)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"IsExistRecord\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���������ڱ��л�ȡ��¼��");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��ȡ��¼��������</param>");
            strBuilder.Append("\r\n /// <returns>���ؼ�¼��</returns>");
            strBuilder.Append("\r\n" + "public func GetRecCountByCond(strWhereCond : String)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetRecCountByCond\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //    strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�����ڵ�����</param>");
            strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
            strBuilder.Append("\r\n" + "public func GetMaxStrId()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            //    strBuilder.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrId\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strPrefix\">�ؼ���ֵ��ǰ׺</param>");
            strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
            strBuilder.Append("\r\n" + "public func GetMaxStrIdByPrefix(strPrefix : String)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + "values[\"strPrefix\"] = strPrefix;");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrIdByPrefix\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_IsFinished4WebService()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strBuilder.Append("\r\n" + "func IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.IsFinished == true)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "theTimer.invalidate();");
            strBuilder.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: cls{0}WS.ResponseData);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "let strResult = cls{0}WS.ResponseData.data;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "switch cls{0}WS.ResponseData.what ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case 1: //\"GetObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ���󲻳ɹ�!����GetObjBy{1}��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
          //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
    objPrjTabENEx.ClsName,
    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "try obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch let objError as NSError");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ���󲻳ɹ�!����GetObjBy{1}��������\\(objError.localizedDescription)\";",
          objPrjTabENEx.TabName,
          objKeyField.FldName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
    objPrjTabENEx.ClsName,
    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 2: //\"GetJSONObjLst\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ�����б��ɹ�!����GetJSONObjLst��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 22: //\"GetTopJSONObjLst\":",
    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
           objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ�������б��ɹ�!����GetTopJSONObjLst��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case 23: //\"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
           objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��ҳ�����б��ɹ�!����GetJSONObjLstByPager��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 3: //\"AddNewRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��Ӳ��ɹ�,����AddNewRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
             enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");

         
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished)
                );
            strBuilder.Append("\r\n" + "return;");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 4: //\"UpdateRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"�޸Ĳ��ɹ�!����UpdateRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "return;");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 5: //\"DelRecord\":");

            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
               objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"ɾ�����ɹ�!����DelRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
              objPrjTabENEx.ClsName,
              clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
              enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");
          

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case 6: //\"GetFirst{0}\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��һ����¼���ɹ�!����GetFirst{0}��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "try obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);       

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch let objError as NSError");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��һ����¼���ɹ�!����GetFirst{0}��������\\(objError.localizedDescription)\";",
              objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case 7: //\"IsExistRecord\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
             objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����IsExistRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
            objPrjTabENEx.ClsName,
            clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
            enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnBool = bolResult;");
        

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 8: //\"GetMaxStrId\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����GetMaxStrId��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
             enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnString = strResult!;");
         

            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case 9: //\"GetMaxStrIdByPrefix\":");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                    enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����GetMaxStrIdByPrefix��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
             enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strBuilder.Append("\r\n" + "objResponseData.returnString = strResult!;");
         
            strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "print(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strBuilder.Append("\r\n" + "func IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "theTimer.invalidate();");
            strBuilder.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvClassENEx.ClsName, intIndex);

                strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId >= 2)",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                        objWebSrvClassENEx.ClsName,
                        objWebSrvFunctionsENEx.FunctionName,
                        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                        enumDict4GC_DictKey2.conFinished));
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "else if ({0}WS.ResponseData.errorId == 1)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����[{0}]��������\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                //  strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strBuilder.Append("\r\n" + "objResponseData.faultString = strInfo;");
                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "objResponseData.returnString = strResult!;",
                        objWebSrvClassENEx.ClsName);


                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult!, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
                                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                                        enumDict4GC_DictKey2.conCorrectFinished));

                strBuilder.Append("\r\n" + "return;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
          //  strBuilder.Append("\r\n" + "print(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_SelfDefWs_IsFinished4WebService_Swift3BaK20170814()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strBuilder.Append("\r\n" + "func IsFinished4WebService()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "theTimer.invalidate();");
            strBuilder.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvClassENEx.ClsName, intIndex);

                strBuilder.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId > 0)",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"����[{0}]��������\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "objResponseData.returnString = strResult;",
                        objWebSrvClassENEx.ClsName);


                strBuilder.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
                                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                                        enumDict4GC_DictKey2.conCorrectFinished));

                strBuilder.Append("\r\n" + "return;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "print(strResult);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
       

        /// <summary>
        /// ͨ�õĵ���WebService���� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ�õĵ���WebService����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��Ҫɾ���Ĺؼ��ֵ�ֵ</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n /// <returns>ɾ���Ƿ�ɹ���</returns>");
            strBuilder.AppendFormat("\r\n" + "func DelRecord({0}: {1}) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"DelRecord\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_btnDelRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ɾ����¼");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "@IBAction func btnDelRecord_Click(_ sender: Any) {");

            strBuilder.Append("\r\n" + "let iobjDelRecord : iclsDelRecord = iclsDelRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjDelRecord.main();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "class iclsDelRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1}: {1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "let strInfo : String = \"ɾ����¼�ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"ɾ����¼���ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }


        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift3_btnAddNewRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnAddNewRecord_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjAddNewRecord : iclsAddNewRecord = iclsAddNewRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjAddNewRecord.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsAddNewRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift3(objField);
                strBuilder.Append(strTemp);
                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                         clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"�ؼ���Ϊ��\\(obj{0}EN.{1})���ļ�¼�Ѿ�����,���������!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼�ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼���ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_btnAddNewRecord4GetMaxStrId_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnAddNewRecord4GetMaxStrId_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjAddNewRecord4GetMaxStrId : iclsAddNewRecord4GetMaxStrId = iclsAddNewRecord4GetMaxStrId(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjAddNewRecord4GetMaxStrId.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsAddNewRecord4GetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {

                    string strTemp = SetProperty4DefaultValue_Swift3(objField);
                    strBuilder.Append(strTemp);
                    //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                    //       objPrjTabENEx.TabName,
                    //       objField.ObjFieldTabENEx.FldName,
                    //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                    //else
                    //{
                    //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                    //          objPrjTabENEx.TabName,
                    //          objField.ObjFieldTabENEx.FldName,
                    //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                }
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"�ؼ���Ϊ��\\(obj{0}EN.{1})���ļ�¼�Ѿ�����,���������!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼�ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼���ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_btnGetMaxStrId_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnGetMaxStrId_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjGetMaxStrId : iclsGetMaxStrId = iclsGetMaxStrId(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjGetMaxStrId.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsGetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_btnGetMaxStrIdByPrefix_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "@IBAction func btnGetMaxStrIdByPrefix_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjGetMaxStrIdByPrefix : iclsGetMaxStrIdByPrefix = iclsGetMaxStrIdByPrefix(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjGetMaxStrIdByPrefix.main();");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "class iclsGetMaxStrIdByPrefix : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "let strPrefix : String = \"2\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix: strPrefix);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_AddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public func AddNewRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"AddNewRecordByJSON\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift3_UpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public func UpdateRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");

            strBuilder.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"UpdateRecordByJSON\",",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "mapParam: values,");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift3_btnUpdateRecord_Click()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "@IBAction func btnUpdateRecord_Click(_ sender: Any) {");
            strBuilder.Append("\r\n" + "let iobjUpdateRecord : iclsUpdateRecord = iclsUpdateRecord(pvcParent: self);");
            strBuilder.Append("\r\n" + "iobjUpdateRecord.main();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "class iclsUpdateRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const vcParent : UIViewController;");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "init(pvcParent : UIViewController)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "super.init();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "func main()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift3(objField);
                strBuilder.Append(strTemp);

                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strBuilder.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strBuilder.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"�޸ļ�¼�ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strInfo : String = \"�޸ļ�¼���ɹ�!\"");
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    }
}
