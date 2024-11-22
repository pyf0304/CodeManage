using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
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
    partial class AppController4Swift4Base : clsGeneCodeBase
    {


        #region ���캯��

        public AppController4Swift4Base()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AppController4Swift4Base(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion

        /// <summary>
        /// ����Web Serviceת�������--Swift4
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift4(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUIViewContraller����Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_QUDI.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class  cls{0}_Controller : NSObject",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_icls") > 0) continue;

                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                     strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_icls") < 0) continue;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            
            }
            return strCodeForCs.ToString();
        }
        public string A_GenController_Swift4_Desk_top(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import Cocoa",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUIViewContraller����Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_QUDI.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class  cls{0}_Controller : NSObject",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_Desk_top_icls") > 0) continue;

                    if (strFuncName.IndexOf("Swift4_Desk_top_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Desk_top_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_icls") < 0) continue;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

        public string A_GenController_Swift4_UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_UnitTest.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}_UnitTest : UIViewController",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
                  
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
        public string A_GenController_Swift4_Desk_top_UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UnitTest";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import Cocoa",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class vc{0}_QUDIEx : vc{0}_UnitTest.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}_UnitTest : NSViewController",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: NSTextField!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: NSTextField!");


                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_Desk_top_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Desk_top_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_Desk_top_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }

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
        public string A_GenController_Swift4_UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            ISOButtonEx objISOButton_Temp = null; ///��ʱ����;

          
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "sb" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".storyboard";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".storyboard";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //    //������ʼ
                ISOstoryBoardEx objISOstoryBoardEN = new ISOstoryBoardEx();
                ISOsceneEx objISOsceneEN = new ISOsceneEx();
                objISOsceneEN.Text = string.Format("{0}-��Ԫ����", objPrjTabENEx.TabName);

                objISOstoryBoardEN.arrSubIsoControlLst2.Add(objISOsceneEN);

                ISOviewControllerEx objISOviewControllerEN = new ISOviewControllerEx();
                string strViewControllerID = AgcCommBase.AgcPubFun.getSwiftID();
                objISOviewControllerEN.IsoControlId = strViewControllerID;
                objISOviewControllerEN.customClass = string.Format("vc{0}_UTScript", objPrjTabENEx.TabName);
                objISOviewControllerEN.customModule = objProject.IsoPrjName;//

                objISOsceneEN.arrSubIsoControlLst2.Add(objISOviewControllerEN);

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Top = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Top.type = "top";
              
                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Bottom = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Bottom.type = "bottom";
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Top);
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Bottom);
                ISOviewEx objISOviewEN = new ISOviewEx();
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewEN);
                ISOStackViewEx objISOStackViewEN = new ISOStackViewEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOStackViewEN);
                int intY = 0;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_DefButton") > 0)
                    {
                        objISOButton_Temp = A_GeneFuncCode_Swift4_DefButton(strFuncName, strViewControllerID, ref intY);
                        objISOStackViewEN.arrSubIsoControlLst2.Add(objISOButton_Temp);
                    }
                }
                ISOlabelEx objISOlabelEN = new ISOlabelEx();
                objISOlabelEN.Text = "���";
                objISOlabelEN.x = 10;
                objISOlabelEN.y = 550;
                objISOlabelEN.Width = 50;
                objISOlabelEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOlabelEN);

                ISOtextFieldEx objISOtextFieldEN = new ISOtextFieldEx();
                objISOtextFieldEN.x = 60;
                objISOtextFieldEN.y = 550;
                objISOtextFieldEN.Width = 150;
                objISOtextFieldEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOtextFieldEN);
                ISOnavigationBarEx objISOnavigationBarEN = new ISOnavigationBarEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOnavigationBarEN);

                ISONavigationItemEx objISOnavigationItemEN = new ISONavigationItemEx();
                objISOnavigationItemEN.Text = string.Format("{0}-��Ԫ����", objPrjTabENEx.TabName);

                objISOnavigationBarEN.arrSubIsoControlLst2.Add(objISOnavigationItemEN);

                ISOBarButtonItemEx objISOBarButtonItemEN = new ISOBarButtonItemEx();
                objISOBarButtonItemEN.mKey = "leftBarButtonItem";

                objISOnavigationItemEN.arrSubIsoControlLst2.Add(objISOBarButtonItemEN);
                ISOButtonEx objISOButtonEN = GetISOButton4NavigitionBar_Swift4("����", 
                    objISOviewControllerEN.IsoControlId, "btnReturnMainPage_Click");
              
                objISOBarButtonItemEN.arrSubIsoControlLst2.Add(objISOButtonEN);

                //    strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                ISOOutletEx objISOOutletEN = new ISOOutletEx();
                objISOOutletEN.property = "txtResult";
                objISOOutletEN.destination = objISOtextFieldEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN);

                ISOOutletEx objISOOutletEN2 = new ISOOutletEx();
                objISOOutletEN2.property = "lblResult";
                objISOOutletEN2.destination = objISOlabelEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN2);

                objISOstoryBoardEN.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);



            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

        public string A_GenController_Swift4_Desk_top_UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            ISOButtonEx objISOButton_Temp = null; ///��ʱ����;


            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "sb" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".storyboard";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".storyboard";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //    //������ʼ
                ISOstoryBoardEx objISOstoryBoardEN = new ISOstoryBoardEx();
                ISOsceneEx objISOsceneEN = new ISOsceneEx();
                objISOsceneEN.Text = string.Format("{0}-��Ԫ����", objPrjTabENEx.TabName);

                objISOstoryBoardEN.arrSubIsoControlLst2.Add(objISOsceneEN);

                ISOviewControllerEx objISOviewControllerEN = new ISOviewControllerEx();
                string strViewControllerID = AgcCommBase.AgcPubFun.getSwiftID();
                objISOviewControllerEN.IsoControlId = strViewControllerID;
                objISOviewControllerEN.customClass = string.Format("vc{0}_UTScript", objPrjTabENEx.TabName);
                objISOviewControllerEN.customModule = objProject.IsoPrjName;//

                objISOsceneEN.arrSubIsoControlLst2.Add(objISOviewControllerEN);

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Top = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Top.type = "top";

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Bottom = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Bottom.type = "bottom";
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Top);
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Bottom);
                ISOviewEx objISOviewEN = new ISOviewEx();
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewEN);
                ISOStackViewEx objISOStackViewEN = new ISOStackViewEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOStackViewEN);
                int intY = 0;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_Desk_top_DefButton") > 0)
                    {
                        objISOButton_Temp = A_GeneFuncCode_Swift4_Desk_top_DefButton(strFuncName, strViewControllerID, ref intY);
                        objISOStackViewEN.arrSubIsoControlLst2.Add(objISOButton_Temp);
                    }
                }
                ISOlabelEx objISOlabelEN = new ISOlabelEx();
                objISOlabelEN.Text = "���";
                objISOlabelEN.x = 10;
                objISOlabelEN.y = 550;
                objISOlabelEN.Width = 50;
                objISOlabelEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOlabelEN);

                ISOtextFieldEx objISOtextFieldEN = new ISOtextFieldEx();
                objISOtextFieldEN.x = 60;
                objISOtextFieldEN.y = 550;
                objISOtextFieldEN.Width = 150;
                objISOtextFieldEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOtextFieldEN);
                ISOnavigationBarEx objISOnavigationBarEN = new ISOnavigationBarEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOnavigationBarEN);

                ISONavigationItemEx objISOnavigationItemEN = new ISONavigationItemEx();
                objISOnavigationItemEN.Text = string.Format("{0}-��Ԫ����", objPrjTabENEx.TabName);

                objISOnavigationBarEN.arrSubIsoControlLst2.Add(objISOnavigationItemEN);

                ISOBarButtonItemEx objISOBarButtonItemEN = new ISOBarButtonItemEx();
                objISOBarButtonItemEN.mKey = "leftBarButtonItem";

                objISOnavigationItemEN.arrSubIsoControlLst2.Add(objISOBarButtonItemEN);
                ISOButtonEx objISOButtonEN = GetISOButton4NavigitionBar_Swift4("����",
                    objISOviewControllerEN.IsoControlId, "btnReturnMainPage_Click");
          
                objISOBarButtonItemEN.arrSubIsoControlLst2.Add(objISOButtonEN);

                //    strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                ISOOutletEx objISOOutletEN = new ISOOutletEx();
                objISOOutletEN.property = "txtResult";
                objISOOutletEN.destination = objISOtextFieldEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN);

                ISOOutletEx objISOOutletEN2 = new ISOOutletEx();
                objISOOutletEN2.property = "lblResult";
                objISOOutletEN2.destination = objISOlabelEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN2);

                objISOstoryBoardEN.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

        public string A_GenController_Swift4_SelfDefWs4UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            ISOButtonEx objISOButton_Temp = null; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "sb" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".storyboard";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".storyboard";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //    //������ʼ
                ISOstoryBoardEx objISOstoryBoardEN = new ISOstoryBoardEx();
                ISOsceneEx objISOsceneEN = new ISOsceneEx();
                objISOsceneEN.Text = string.Format("{0}4SD-��Ԫ����", objWebSrvClassENEx.ClsName);
                objISOstoryBoardEN.arrSubIsoControlLst2.Add(objISOsceneEN);

                ISOviewControllerEx objISOviewControllerEN = new ISOviewControllerEx();
                string strViewControllerID = AgcCommBase.AgcPubFun.getSwiftID();
                objISOviewControllerEN.IsoControlId = strViewControllerID;
                objISOviewControllerEN.customClass = string.Format("vc{0}4SD_UTScript", objWebSrvClassENEx.ClsName);
                objISOviewControllerEN.customModule = objProject.IsoPrjName;//

                objISOsceneEN.arrSubIsoControlLst2.Add(objISOviewControllerEN);

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Top = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Top.type = "top";

                ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideEN_Bottom = new ISOviewControllerLayoutGuideEx();
                objISOviewControllerLayoutGuideEN_Bottom.type = "bottom";
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Top);
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewControllerLayoutGuideEN_Bottom);
                ISOviewEx objISOviewEN = new ISOviewEx();
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOviewEN);
                ISOStackViewEx objISOStackViewEN = new ISOStackViewEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOStackViewEN);
                int intY = 0;

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        objISOButton_Temp = Gen_Controller_Swift4_DefButtonByCommonFunction(objWebSrvFunctionsENEx, strViewControllerID, ref intY);
                        objISOStackViewEN.arrSubIsoControlLst2.Add(objISOButton_Temp);
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                ISOlabelEx objISOlabelEN = new ISOlabelEx();
                objISOlabelEN.Text = "���";
                objISOlabelEN.x = 10;
                objISOlabelEN.y = 550;
                objISOlabelEN.Width = 50;
                objISOlabelEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOlabelEN);

                ISOtextFieldEx objISOtextFieldEN = new ISOtextFieldEx();
                objISOtextFieldEN.x = 60;
                objISOtextFieldEN.y = 550;
                objISOtextFieldEN.Width = 150;
                objISOtextFieldEN.Height = 30;

                objISOviewEN.arrSubIsoControlLst2.Add(objISOtextFieldEN);
                ISOnavigationBarEx objISOnavigationBarEN = new ISOnavigationBarEx();
                objISOviewEN.arrSubIsoControlLst2.Add(objISOnavigationBarEN);

                ISONavigationItemEx objISOnavigationItemEN = new ISONavigationItemEx();
                objISOnavigationItemEN.Text = string.Format("{0}4SD-��Ԫ����", objWebSrvClassENEx.ClsName);

                objISOnavigationBarEN.arrSubIsoControlLst2.Add(objISOnavigationItemEN);

                ISOBarButtonItemEx objISOBarButtonItemEN = new ISOBarButtonItemEx();
                objISOBarButtonItemEN.mKey = "leftBarButtonItem";

                objISOnavigationItemEN.arrSubIsoControlLst2.Add(objISOBarButtonItemEN);
                ISOButtonEx objISOButtonEN = GetISOButton4NavigitionBar_Swift4("����",
                    objISOviewControllerEN.IsoControlId, "btnReturnMainPage_Click");
                //ISOButtonEx objISOButtonEN =  new ISOButtonEx();
                //objISOButtonEN.Text = "����";
                //objISOButtonEN.IsoControlName = "ReturnMainPage";
                //objISOButtonEN.x = 16;
                //objISOButtonEN.y = 7;

                //objISOButtonEN.Width = 30;
                //objISOButtonEN.Height = 30;
                objISOBarButtonItemEN.arrSubIsoControlLst2.Add(objISOButtonEN);

                //    strCodeForCs.Append("\r\n" + "<outlet property=\"txtResult\" destination=\"drJ-Oa-kPD\" id=\"wLA-Bq-AcF\"/>");
                ISOOutletEx objISOOutletEN = new ISOOutletEx();
                objISOOutletEN.property = "txtResult";
                objISOOutletEN.destination = objISOtextFieldEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN);

                ISOOutletEx objISOOutletEN2 = new ISOOutletEx();
                objISOOutletEN2.property = "lblResult";
                objISOOutletEN2.destination = objISOlabelEN.IsoControlId;
                objISOviewControllerEN.arrSubIsoControlLst2.Add(objISOOutletEN2);

                objISOstoryBoardEN.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

      
        public string A_GenController_Swift4_Desk_top_UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "vc" + objPrjTabENEx.TabName + "_UTScript";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));



                strCodeForCs.AppendFormat("\r\n" + "import Cocoa",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4��������Ա�:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class vc{0}_UTScriptEx : vc{0}_UTScript.", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}_UTScript : NSViewController",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: NSTextField!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: NSTextField!");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_Desk_top_DeclareButton") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = "";
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Swift4_Desk_top_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        string strSource = string.Format("vc{0}_UnitTest", objPrjTabENEx.TabName);
                        string strTarget = string.Format("vc{0}_UTScript", objPrjTabENEx.TabName);

                        strTemp = strTemp.Replace(strSource, strTarget);
                    }
                    else
                    {
                        strTemp = "";
                    }
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

        /// <summary>
        /// ����Web Serviceת�������--Swift4
        /// </summary>
        /// <returns></returns>
        public string A_GenController_Swift4_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClsName+ "4SD_Controller";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUIViewContraller����Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4�����������:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class vc{0}Ex : vc{0}.", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class  cls{0}4SD_Controller : NSObject",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                //strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                //strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                //strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                //strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                //strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                //strCodeForCs.Append("\r\n" + "}");

                //�������к����ĵ��ú���

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_InvokeByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");

                //�������к������ڲ��ຯ��
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_iclsByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
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

        public string A_GenController_Swift4_SelfDefWs4UnitTest(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName + "4SD_UnitTest";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4�����������:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class tvc{0}Ex : tvc{0}.", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}4SD_UnitTest : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");


                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_btnClickByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
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
        public string A_GenController_Swift4_SelfDefWs4UTScriptCS(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objWebSrvClassENEx.ClsName = "vc" + objWebSrvClassENEx.ClsName + "4SD_UTScript";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));



                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:1�������������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "*      2�����ļ�������ò�Ҫֱ��ʹ��,���⸲�ǣ�");
                strCodeForCs.AppendFormat("\r\n" + "*      3�����������ΪUITableViewContraller�ļ��Ļ��ࣻ");
                strCodeForCs.AppendFormat("\r\n" + "*      4�����������:[{0}]��WebService���������Ľ�������඼�����Դ�Ϊ���ࣻ", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "* ʹ�÷�����1�����Խ�����һ�ļ�����һ������Ϊ�������չ��,�ѵ����¼�(~_Click()����)���Ƶ���չ,������[override]��");
                strCodeForCs.AppendFormat("\r\n" + "*              ���磺class tvc{0}Ex : tvc{0}.", objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "*           2�����Խ�����һ�ļ�����һ����, �Ѹ���Ĵ��븴�Ƶ���һ�����С�");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "class vc{0}4SD_UTScript : UIViewController",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var lblResult: UILabel!");
                strCodeForCs.Append("\r\n" + "@IBOutlet weak var txtResult: UITextField!");
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_DeclareButtonByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "override func viewDidLoad()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.viewDidLoad()");

                strCodeForCs.Append("\r\n" + "// Do any additional setup after loading the view.");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "override func didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.didReceiveMemoryWarning()");
                strCodeForCs.Append("\r\n" + "// Dispose of any resources that can be recreated.");
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_Controller_Swift4_btnClickByCommonFunction(objWebSrvFunctionsENEx);
                        string strSource = string.Format("vc{0}4SD_UnitTest", objWebSrvClassENEx.ClsName);
                        string strTarget = string.Format("vc{0}4SD_UTScript", objWebSrvClassENEx.ClsName);

                        strTemp = strTemp.Replace(strSource, strTarget);

                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
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
        /// ����Web Serviceת�������--Swift2
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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = string.Format("cls{0}WS4Controller", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));
                strCodeForCs.AppendFormat("\r\n" + "import Foundation",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objPrjTabENEx.TabCnName,
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strCodeForCs.Append("\r\n" + "const queue : OperationQueue!");

                strCodeForCs.Append("\r\n" + "const theTimer: Timer!");
                strCodeForCs.Append("\r\n" + "override init()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>, pobj{0}EN : cls{0}EN)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Swift4_btnClick") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Swift4_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode_Swift4_icls(strFuncName);
                    }
                    else if (strFuncName.IndexOf("Swift4_Invoke") > 0)
                    {
                        strTemp =  A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode_Swift4(strFuncName);
                    }
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

        /// <summary>
        /// ����Web Serviceת�������--Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenTableObjWSController_Swift4_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
         
            objWebSrvClassENEx.ClsName = string.Format("{0}WS4Controller", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);
            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";

            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));
                strCodeForCs.AppendFormat("\r\n" + "import UIKit;",
                      objProjectsENEx.JavaPackageName);

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objWebSrvClassENEx.CurrUserName,
                    clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : NSObject",
                       objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const objTableObjWS4ControllerDelegate : clsTableObjWS4ControllerDelegate?;");

                strCodeForCs.Append("\r\n" + "const queue : OperationQueue!");

                strCodeForCs.Append("\r\n" + "const theTimer: Timer!");
                strCodeForCs.Append("\r\n" + "override init()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "super.init();");
                strCodeForCs.Append("\r\n" + "queue = OperationQueue();");
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WS4Controller_Swift4_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                strTemp = A_GeneFuncCode_Swift4("Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService");
                strCodeForCs.Append("\r\n" + strTemp);
               
                strCodeForCs.Append("\r\n" + "}");

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
                //clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string A_GeneFuncCode_Swift4(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {
                    //case "btnGetFirstJSONObj_Click":
                    //    return btnGetFirstJSONObj_Click();

                    case "Gen_Controller_Swift4_btnGetFirstJSONObj_Click":
                    case "Gen_Controller_Swift4_btnGetFirstJSONObj_Click4tvc":
                        return Gen_Controller_Swift4_btnGetFirstJSONObj_Click();

                    case "Gen_Controller_Swift4_btnGetJSONObjByKey_Click":
                    case "Gen_Controller_Swift4_btnGetJSONObjByKey_Click4tvc":
                        return Gen_Controller_Swift4_btnGetJSONObjByKey_Click();


                    case "Gen_4WS4Controller_Swift4_GetFirstJSONObj":
                        return Gen_4WS4Controller_Swift4_GetFirstJSONObj();

                    case "Gen_4WS4Controller_Swift4_GetRecordObjByKey":
                        return Gen_4WS4Controller_Swift4_GetRecordObjByKey();

                    //case "IsFinished4WebService":
                    //    return IsFinished4WebService();
                    //case "IsFinished4WebService":
                    //    return IsFinished4WebService();


                    case "Gen_4WS4Controller_Swift4_IsFinished4WebService":                    
                        return Gen_4WS4Controller_Swift4_IsFinished4WebService();
                    case "Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService":
                        return Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService();

                    //case "Gen_4WS4Controller_1Swift4_SelfDefWs_IsFinished4WebService_Swift4":               
                    //    return Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService_Swift4BaK20170814();

                    //case "btnDelRecord_Click":
                    //    return btnDelRecord_Click();

                    case "Gen_Controller_Swift4_btnDelRecord_Click":
                    case "Gen_Controller_Swift4_btnDelRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnDelRecord_Click();
                    case "Gen_Controller_Swift4_btnReturnMainPage_Click":
                        return Gen_Controller_Swift4_btnReturnMainPage_Click();

                        
                    case "Gen_4WS4Controller_Swift4_DelRecord":                  
                        return Gen_4WS4Controller_Swift4_DelRecord();

                    //case "Gen_4Ws_run_Java":
                    //    return Gen_4Ws_run_Java();

                    //case "btnAddNewRecord_Click":
                    //    return btnAddNewRecord_Click();

                    case "Gen_Controller_Swift4_btnAddNewRecord_Click":
                    case "Gen_Controller_Swift4_btnAddNewRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnAddNewRecord_Click();


                    case "Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click":
                    case "Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click();
                    case "Gen_Controller_Swift4_btnGetMaxStrId_Click":
                    case "Gen_Controller_Swift4_btnGetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_btnGetMaxStrId_Click();
                    case "Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click":
                    case "Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click4tvc":
                        return Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click();

                    case "Gen_4WS4Controller_Swift4_AddNewRecord":
                        return Gen_4WS4Controller_Swift4_AddNewRecord();


                    //case "btnUpdateRecord_Click":
                    //    return btnUpdateRecord_Click();

                    case "Gen_Controller_Swift4_btnUpdateRecord_Click":
                    case "Gen_Controller_Swift4_btnUpdateRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnUpdateRecord_Click();

                    case "Gen_4WS4Controller_Swift4_UpdateRecord":
                        return Gen_4WS4Controller_Swift4_UpdateRecord();

                    case "Gen_Controller_Swift4_btnIsExistRecord_Click":
                    case "Gen_Controller_Swift4_btnIsExistRecord_Click4tvc":
                        return Gen_Controller_Swift4_btnIsExistRecord_Click();

                    case "Gen_Controller_Swift4_btnGetRecCountByCond_Click":
                        return Gen_Controller_Swift4_btnGetRecCountByCond_Click();

                    case "Gen_4WS4Controller_Swift4_IsExistRecord":
                        return Gen_4WS4Controller_Swift4_IsExistRecord();

                    case "Gen_4WS4Controller_Swift4_GetRecCountByCond":
                        return Gen_4WS4Controller_Swift4_GetRecCountByCond();

                    case "Gen_4WS4Controller_Swift4_GetMaxStrId":
                        return Gen_4WS4Controller_Swift4_GetMaxStrId();

                    case "Gen_4WS4Controller_Swift4_GetMaxStrIdByPrefix":
                        return Gen_4WS4Controller_Swift4_GetMaxStrIdByPrefix();

                    //case "btnGetJSONObjLst_Click":
                    //    return btnGetJSONObjLst_Click();

                    case "Gen_Controller_Swift4_btnGetJSONObjLst_Click":
                    case "Gen_Controller_Swift4_btnGetJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_btnGetJSONObjLst_Click();
                    case "Gen_Controller_Swift4_btnGetTopJSONObjLst_Click":
                    case "Gen_Controller_Swift4_btnGetTopJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_btnGetTopJSONObjLst_Click();
                    case "Gen_Controller_Swift4_btnGetJSONObjLstByPager_Click":
                        return Gen_Controller_Swift4_btnGetJSONObjLstByPager_Click();
                    case "Gen_4WS4Controller_Swift4_GetJSONObjLst":
                        return Gen_4WS4Controller_Swift4_GetJSONObjLst();

                    case "Gen_4WS4Controller_Swift4_GetTopJSONObjLst":
                        return Gen_4WS4Controller_Swift4_GetTopJSONObjLst();

                    case "Gen_4WS4Controller_Swift4_GetJSONObjLstByPager":
                        return Gen_4WS4Controller_Swift4_GetJSONObjLstByPager();

                


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

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetRecordObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ��ֵ�ֵ</param>",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetObjBy{1}({2}: {3})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjBy{1}\",",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_4WS4Controller_Swift4_GetFirstJSONObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetFirst{0}(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetFirstJSONObj\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WS4Controller_Swift4_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
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
            strCodeForCs.AppendFormat("\r\n /// <returns>����{0}</returns>",
                    objWebSrvFunctionsENEx.ReturnValueDescription);

            strCodeForCs.AppendFormat("\r\n" + "public func {0}({1})",
                objWebSrvFunctionsENEx.FunctionName, sbParaList.ToString());
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
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
                    //    strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0});",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                    //else
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", {0}.toString());",
                    //        objWebSrvFuncParaEN.ParaName);
                    //}
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                                objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        switch (objDataTypeAbbrEN.SwiftType)
                        {
                            case "Int":
                                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                //strCodeForCs.AppendFormat("\r\n" + "mapParam.put(\"{0}\", Integer.toString({0}));",
                                //    objWebSrvFuncParaEN.ParaName);
                                break;
                            case "Float":
                                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                break;
                            case "Double":
                                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                                        objWebSrvFuncParaEN.ParaName);
                                break;
                            default:
                                strMsg = string.Format("Swift���ͣ�[{0}]û���ں����б�����!({1})",
                                    objDataTypeAbbrEN.SwiftType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                }
            }
            //strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : {0}WS = {0}WS(strMethod: \"{1}\",",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "mapParam: values);");
            //strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
            //    objWebSrvFunctionsENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Controller_Swift4_btnGetJSONObjByKey_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjByKey_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetObjBy{1} : icls{0}GetObjBy{1} = icls{0}GetObjBy{1}(pvcParent: self);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetObjBy{1} : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2}: {2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjByKey,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"���ݹؼ��֡�01�� ��ȡ����\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetFirstJSONObj_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetFirstJSONObj_Click(_ sender: Any) {");

            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetFirstObj : icls{0}GetFirstObj = icls{0}GetFirstObj(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetFirstObj : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirst{0}(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObject: NSObject, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"������������1=1�� ��ȡ��һ����¼����\\(obj{0}EN.{1})!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ú�����[{0}]", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func Invoke_{0}() ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0} : icls{0} = icls{0}(pvcParent: self);",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}.main();",
                objWebSrvFunctionsENEx.FunctionName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0} : NSObject, clsTableObjWS4ControllerDelegate",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            //strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
            //    objWebSrvFunctionsENEx.TabName);

            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : {0}WS4Controller = {0}WS4Controller();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
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
                        strCodeForCs.AppendFormat("\r\n" + " let {1} : {0} = \"{2}\";",
                            objDataTypeAbbrEN.SwiftType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + " let {1} : {0} = {2};",
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

            //  strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                objWebSrvClassENEx.ClsName,
                objWebSrvFunctionsENEx.FunctionName,
                sbParaVarList.ToString());
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ��{0},���ص��¼�����,������Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "func {0}(strResult: String, strClassName: String, strFunctionName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = returnObject as!cls{0}EN;",
            //    objWebSrvFunctionsENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����:[{0}]����ֵΪ��\\(strResult)!\"",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����������ȡ��Ӧ�ļ�¼�����б� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetJSONObjLst(strWhereCond: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLst\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����������ȡ��Ӧ�ļ�¼�����б� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetTopJSONObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">������¼��</strWhereCond>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetTopJSONObjLst(intTopSize: Int, strWhereCond: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "values[\"intTopSize\"] = String(intTopSize);");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetTopJSONObjLst\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����������ȡ��Ӧ�ļ�¼�����б� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetJSONObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</strWhereCond>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func GetJSONObjLstByPager(intPageIndex: Int, intPageSize: Int, strWhereCond: String, strOrderBy: String)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "values[\"intPageIndex\"] = String(intPageIndex);");
            strCodeForCs.AppendFormat("\r\n" + "values[\"intPageSize\"] = String(intPageSize);");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "values[\"strOrderBy\"] = strOrderBy;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetJSONObjLstByPager\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        

        public string Gen_Controller_Swift4_btnGetJSONObjLst_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLst : icls{0}GetJSONObjLst = icls{0}GetJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����ȡ�����б�����\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Controller_Swift4_btnGetTopJSONObjLst_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ������������б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetTopJSONObjLst_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetTopJSONObjLst : icls{0}GetTopJSONObjLst = icls{0}GetTopJSONObjLst(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetTopJSONObjLst : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "let intTopSize : Int = 2;");
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize: intTopSize, strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetTopRecordObjLst,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLst,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst, enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����ȡ�����б�����\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetJSONObjLstByPager_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ������������б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "@IBAction func btnGetJSONObjLstByPager_Click(_ sender: Any) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLstByPager : icls{0}GetJSONObjLstByPager = icls{0}GetJSONObjLstByPager(pvcParent: self);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByPager : NSObject, clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
      
            strCodeForCs.Append("\r\n" + "let intPageIndex : Int = 2;");
            strCodeForCs.Append("\r\n" + "let intPageSize : Int = 2;");
            strCodeForCs.Append("\r\n" + "let strWhereCond : String = \" 1=1 \";");
            strCodeForCs.Append("\r\n" + "let strOrderBy : String = \" 1=1 \";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex: intPageIndex, intPageSize:intPageSize, strWhereCond: strWhereCond, strOrderBy: strOrderBy );",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByPager,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecordObjLstByPager,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnObjectList: NSObject, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager, enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst : Array < cls{0}EN > = returnObjectList as!Array<cls{0}EN>;",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����ȡ�����б�����\\(arr{0}ObjLst.count)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_btnIsExistRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnIsExistRecord_Click(_ sender: Any) {");


            strCodeForCs.Append("\r\n" + "let iobjIsExistRecord : iclsIsExistRecord = iclsIsExistRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjIsExistRecord.main();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsIsExistRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{0} ='12'\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch strClassName {");
            strCodeForCs.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"������������{0}='12'�� ������!\"",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"������������{0}='12'�� ����!\"",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default: ");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_btnGetRecCountByCond_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��Ӧ�����ļ�¼��");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�����ļ�¼��</returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetRecCountByCond_Click(_ sender: Any) {");


            strCodeForCs.Append("\r\n" + "let iobjGetRecCountByCond : iclsGetRecCountByCond = iclsGetRecCountByCond(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjGetRecCountByCond.main();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetRecCountByCond : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{0} ='12'\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond, enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetRecCountByCond,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnInt: Int, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"������������1=1���ļ�¼����[\\(returnInt)]!\"",
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���������ڱ��м���Ƿ����������ļ�¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">�����ڵ�����</param>");
            strCodeForCs.Append("\r\n /// <returns>���ڷ���true,�����ڷ��أ�false</returns>");
            strCodeForCs.Append("\r\n" + "public func IsExistRecord(strWhereCond : String)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"IsExistRecord\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���������ڱ��л�ȡ��¼��");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">��ȡ��¼��������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ؼ�¼��</returns>");
            strCodeForCs.Append("\r\n" + "public func GetRecCountByCond(strWhereCond : String)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetRecCountByCond\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //    strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">�����ڵ�����</param>");
            strCodeForCs.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
            strCodeForCs.Append("\r\n" + "public func GetMaxStrId()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            //    strCodeForCs.Append("\r\n" + "values[\"strWhereCond\"] = strWhereCond;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrId\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strPrefix\">�ؼ���ֵ��ǰ׺</param>");
            strCodeForCs.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
            strCodeForCs.Append("\r\n" + "public func GetMaxStrIdByPrefix(strPrefix : String)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + "values[\"strPrefix\"] = strPrefix;");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"GetMaxStrIdByPrefix\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_IsFinished4WebService()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strCodeForCs.Append("\r\n" + "@objc func IsFinished4WebService()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.IsFinished == true)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "theTimer.invalidate();");
            strCodeForCs.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: cls{0}WS.ResponseData);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "let strResult = cls{0}WS.ResponseData.data;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "switch cls{0}WS.ResponseData.what ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "case 1: //\"GetObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
                   objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ���󲻳ɹ�!����GetObjBy{1}��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
          //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
    objPrjTabENEx.ClsName,
    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "do");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "try obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
    objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch let objError as NSError");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ���󲻳ɹ�!����GetObjBy{1}��������\\(objError.localizedDescription)\";",
          objPrjTabENEx.TabName,
          objKeyField.FldName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
    objPrjTabENEx.ClsName,
    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case 2: //\"GetJSONObjLst\":",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ�����б��ɹ�!����GetJSONObjLst��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case 3: //\"AddNewRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��Ӳ��ɹ�,����AddNewRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
             enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

         
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished)
                );
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 4: //\"UpdateRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"�޸Ĳ��ɹ�!����UpdateRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");

            
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 5: //\"DelRecord\":");

            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
               objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"ɾ�����ɹ�!����DelRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
              objPrjTabENEx.ClsName,
              clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
              enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");
          

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case 6: //\"GetFirst{0}\":",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
          objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��һ����¼���ɹ�!����GetFirst{0}��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "do");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "try obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObject = obj{0}EN;",
                objPrjTabENEx.TabName);       

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObject: obj{0}EN, strClassName: \"{1}\");",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch let objError as NSError");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��һ����¼���ɹ�!����GetFirst{0}��������\\(objError.localizedDescription)\";",
              objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetFirstJSONObj,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 7: //\"IsExistRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
             objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����IsExistRecord��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
            objPrjTabENEx.ClsName,
            clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
            enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let bolResult : Bool = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnBool = bolResult;");
        

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnBool: bolResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case 8: //\"GetMaxStrId\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����GetMaxStrId��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
             enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnString = strResult!;");
         

            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case 9: //\"GetMaxStrIdByPrefix\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
         objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����GetMaxStrIdByPrefix��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
             objPrjTabENEx.ClsName,
             clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
             enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "let strResult : String = clsPubFun.myBool(myObj: strResult as AnyObject);");
            strCodeForCs.Append("\r\n" + "objResponseData.returnString = strResult!;");
         
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnString: strResult!, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case 10: //\"GetTopJSONObjLst\":",
objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
           objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ�������б��ɹ�!����GetTopJSONObjLst��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.AppendFormat("\r\n" + "case 11: //\"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
           objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��ҳ�����б��ɹ�!����GetJSONObjLstByPager��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
objPrjTabENEx.ClsName,
clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst : Array < cls{0}EN > = Array<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLstByJSONStr(strJSON: strResult!);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnObjectList = arr{0}ObjLst as NSObject;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(returnObjectList: arr{0}ObjLst as NSObject, strClassName: \"{1}\");",
                    objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case 12: //\"GetRecCountByCond\":");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WS.ResponseData.errorId >= 2)",
             objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
                    objPrjTabENEx.ClsName,
                    clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                    enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "else if (cls{0}WS.ResponseData.errorId == 1)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����GetRecCountByCond��������\\(cls{0}WS.ResponseData.faultString)\";",
                objPrjTabENEx.TabName);
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
            strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{1}!(objResponseData: objResponseData, strClassName: \"{0}\");",
            objPrjTabENEx.ClsName,
            clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
            enumDict4GC_DictKey2.conFinished));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let intResult : Int = Int(strResult!)!;");
            strCodeForCs.Append("\r\n" + "objResponseData.returnInt = intResult;");
            
            strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{1}!(returnInt: intResult, strClassName: \"{0}\");",
                objPrjTabENEx.ClsName,
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strCodeForCs.Append("\r\n" + "@objc func IsFinished4WebService()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "theTimer.invalidate();");
            strCodeForCs.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvFunctionsENEx.FunctionName, intIndex);

                strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId >= 2)",
                  objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                        objWebSrvClassENEx.ClsName,
                        objWebSrvFunctionsENEx.FunctionName,
                        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                        enumDict4GC_DictKey2.conFinished));
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "else if ({0}WS.ResponseData.errorId == 1)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����[{0}]��������\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strCodeForCs.Append("\r\n" + "objResponseData.faultString = strInfo;");
                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnString = strResult!;",
                        objWebSrvClassENEx.ClsName);


                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult!, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
                                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                                        enumDict4GC_DictKey2.conCorrectFinished));

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                intIndex++;
            }
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
          //  strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_SelfDefWs_IsFinished4WebService_Swift4BaK20170814()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebService�Ƿ���ɺ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ�ĵ���WebService�Ƿ���ɺ������ص�����</returns>");
            strCodeForCs.Append("\r\n" + "func IsFinished4WebService()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.IsFinished == true)",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "theTimer.invalidate();");
            strCodeForCs.AppendFormat("\r\n" + "let objResponseData : clsResponseData = clsResponseData(structResponseData: {0}WS.ResponseData);",
                objWebSrvClassENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "let strResult = {0}WS.ResponseData.data;",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "switch {0}WS.ResponseData.what ",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case {1}: //\"{0}\":",
                objWebSrvClassENEx.ClsName, intIndex);

                strCodeForCs.AppendFormat("\r\n" + "if ({0}WS.ResponseData.errorId > 0)",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"����[{0}]��������\\({1}WS.ResponseData.faultString)\";",
                    objWebSrvFunctionsENEx.FunctionName,
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "//clsPubFun.myAlertIOS7(strInfo: strInfo);");
                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate?.{2}!(objResponseData: objResponseData, strClassName: \"{0}\", strFunctionName: \"{1}\");",
       objWebSrvClassENEx.ClsName,
       objWebSrvFunctionsENEx.FunctionName,
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
       enumDict4GC_DictKey2.conFinished));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "//var obj{0}EN : cls{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN = cls{0}BL.GetObjByJSONStr(strJSON: strResult);",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "//objResponseData.returnObject = obj{0}EN;",
                    objWebSrvClassENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "objResponseData.returnString = strResult;",
                        objWebSrvClassENEx.ClsName);


                strCodeForCs.AppendFormat("\r\n" + "objTableObjWS4ControllerDelegate!.{2}!(strResult: strResult, strClassName: \"{0}\", strFunctionName: \"{1}\");",
                                      objWebSrvClassENEx.ClsName,
                                      objWebSrvFunctionsENEx.FunctionName,
                                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                                        enumDict4GC_DictKey2.conCorrectFinished));

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "break;");
                intIndex++;
            }
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "print(strResult);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
      

        /// <summary>
        /// ͨ�õĵ���WebService���� 
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ͨ�õĵ���WebService����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��Ҫɾ���Ĺؼ��ֵ�ֵ</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n /// <returns>ɾ���Ƿ�ɹ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "func DelRecord({0}: {1}) ",
                objKeyField.PrivFuncName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const values :  Dictionary < String, String > = Dictionary<String, String>();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = {0};",
                    objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "values[\"{0}\"] = String({0});",
                    objKeyField.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"DelRecord\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnDelRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ɾ����¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "@IBAction func btnDelRecord_Click(_ sender: Any) {");

            strCodeForCs.Append("\r\n" + "let iobjDelRecord : iclsDelRecord = iclsDelRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjDelRecord.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsDelRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = \"{2}\";",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "let {0} : {1} = {2};",
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Swift);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1}: {1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��DelRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "let strInfo : String = \"ɾ����¼�ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"ɾ����¼���ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnReturnMainPage_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ص���ҳ");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "@IBAction func btnReturnMainPage_Click(_ sender: AnyObject) {");
            
            strCodeForCs.Append("\r\n" + "let vc = UIStoryboard(name: \"Main\", bundle: nil).instantiateViewController(withIdentifier: \"First\") as UIViewController");
            
            strCodeForCs.Append("\r\n" + "self.present(vc, animated: true, completion: nil);");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_btnAddNewRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnAddNewRecord_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjAddNewRecord : iclsAddNewRecord = iclsAddNewRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjAddNewRecord.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsAddNewRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift4(objField);
                strCodeForCs.Append(strTemp);
                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                         clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"�ؼ���Ϊ��\\(obj{0}EN.{1})���ļ�¼�Ѿ�����,���������!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼�ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼���ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnAddNewRecord4GetMaxStrId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnAddNewRecord4GetMaxStrId_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjAddNewRecord4GetMaxStrId : iclsAddNewRecord4GetMaxStrId = iclsAddNewRecord4GetMaxStrId(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjAddNewRecord4GetMaxStrId.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsAddNewRecord4GetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {

                    string strTemp = SetProperty4DefaultValue_Swift4(objField);
                    strCodeForCs.Append(strTemp);
                    //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                    //       objPrjTabENEx.TabName,
                    //       objField.ObjFieldTabENEx.FldName,
                    //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                    //else
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                    //          objPrjTabENEx.TabName,
                    //          objField.ObjFieldTabENEx.FldName,
                    //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                    //}
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strWhereCond : String = \"{1} = '\\(obj{0}EN.{1})'\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond: strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��IsExistRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"�ؼ���Ϊ��\\(obj{0}EN.{1})���ļ�¼�Ѿ�����,���������!\"",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��AddNewRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼�ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"��Ӽ�¼���ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetMaxStrId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetMaxStrId_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjGetMaxStrId : iclsGetMaxStrId = iclsGetMaxStrId(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjGetMaxStrId.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetMaxStrId : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrId,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnGetMaxStrIdByPrefix_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "@IBAction func btnGetMaxStrIdByPrefix_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjGetMaxStrIdByPrefix : iclsGetMaxStrIdByPrefix = iclsGetMaxStrIdByPrefix(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjGetMaxStrIdByPrefix.main();");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "class iclsGetMaxStrIdByPrefix : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "let strPrefix : String = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix: strPrefix);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��GetMaxStrIdByPrefix,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnString: String, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let strInfo : String = \"��ȡ��{0}�����ؼ���Ϊ��\\(returnString)!\"",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public func AddNewRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"AddNewRecordByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WS4Controller_Swift4_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public func UpdateRecord(obj{0}EN : cls{0}EN)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let values :  Dictionary < String, String > = Dictionary<String, String>();");

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS : cls{0}WS = cls{0}WS(strMethod: \"UpdateRecordByJSON\",",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "mapParam: values,");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "queue.addOperation(obj{0}WS);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "theTimer = Timer.scheduledTimer(timeInterval: 0.1, target: self, selector: #selector(IsFinished4WebService), userInfo: nil, repeats: true);");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Swift4_btnUpdateRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "@IBAction func btnUpdateRecord_Click(_ sender: Any) {");
            strCodeForCs.Append("\r\n" + "let iobjUpdateRecord : iclsUpdateRecord = iclsUpdateRecord(pvcParent: self);");
            strCodeForCs.Append("\r\n" + "iobjUpdateRecord.main();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "class iclsUpdateRecord : NSObject, clsTableObjWS4ControllerDelegate");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const vcParent : UIViewController;");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "init(pvcParent : UIViewController)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "vcParent = pvcParent;");
            strCodeForCs.Append("\r\n" + "super.init();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "func main()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                string strTemp = SetProperty4DefaultValue_Swift4(objField);
                strCodeForCs.Append(strTemp);

                //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                //       objPrjTabENEx.TabName,
                //       objField.ObjFieldTabENEx.FldName,
                //       objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                //          objPrjTabENEx.TabName,
                //          objField.ObjFieldTabENEx.FldName,
                //          objField.ObjFieldTabENEx.DefaultValue4Test_Swift);
                //}
            }
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}WS4Controller : cls{0}WS4Controller = cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = self;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN: obj{0}EN);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(objResponseData : clsResponseData, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//���ܷ����Ƚ����صĴ������磺WebService�ĵ�ַ����ȷ���﷨����ȷ�ȡ�");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: objResponseData.faultString, vcObj: vcParent);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//ͨ��WebServiceִ��UpdateRecord,���ص��¼�����,������ȷ����,����Ҫ����ִ�д���");
            strCodeForCs.AppendFormat("\r\n" + "func {0}(returnBool: Bool, strClassName: String)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"�޸ļ�¼�ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strInfo : String = \"�޸ļ�¼���ɹ�!\"");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "clsPubFun.myAlert(strInfo: strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
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
                Type t = typeof(WS_AccessHigh4Swift4);
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
            this.ClsName = string.Format("cls{0}WS4Controller", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
