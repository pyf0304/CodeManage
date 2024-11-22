using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using com.taishsoft.sql;

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
    partial class NodeBusinessLogicEx4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        #region ���캯��

        public NodeBusinessLogicEx4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public NodeBusinessLogicEx4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
        public string A_GenWebServiceCodeNew(Encoding myEncoding)
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
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


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
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}Service ��ժҪ˵��",
                objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}Service : System.Web.Services.WebService",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //�������еĺ���

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
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Java(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Java(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_JavaScript(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_JavaScript(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift4(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift4(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift3(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift3(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_SilverLight(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

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
                
        /// <summary>
        /// ����ҵ���߼���չ����룭��C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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

            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                         clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                         objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BLEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ
                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Globalization;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");

                strCodeForCs.Append("\r\n" + "using System.Xml;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;");

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient; "); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProjectsENEx.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);

 
                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogicEx",
                objProjectsENEx.PrjDomain);

                strCodeForCs.Append("\r\n" + "{");


                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Static = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12);
                if (arrvFunction4GeneCodeObjLst_Static.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static class  {0}_Static", objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Static)
                    {
                        //clsvFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
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
                            if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                            {
                                strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                                    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                            }
                            else
                            {
                                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");

                }
                
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : cls{1}BL", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotStatic = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotStatic)
                {
                    //clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
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
                        objPrjTabENEx.FuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                                objException.Message,
                                clsStackTrace.GetCurrClassFunction());
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(NodeBusinessLogicEx4CSharp);
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
                throw objException;
            }
        }

        public string Gen_4BL_DefineObjCommFun4BL()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ר�����߼������ڴ�����ȹ��������Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public static clsCommFun4BL objCommFun4BL = null;");
            //strCodeForCs.Append("\r\n" + "public static event OnAddNewRecord onAddNewRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnUpdateRecord onUpdateRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnDeleteRecord onDelRecord;");

            return strCodeForCs.ToString();
        }

        public string Gen_4BL_DefineUniqueInstance4DAL()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ����ģʽ:�������ݷ��ʲ�ĵ���ģʽ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DA uniqueInstance = null;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ����ģʽ:�������ݷ��ʲ�ĵ���ģʽ,ʹ���ݷ��ʲ�ķ��ʲ���Ҫ��γ�ʼ����");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DA {0}DA", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "    get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (uniqueInstance == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "uniqueInstance = new cls{0}DA();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return uniqueInstance;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Neo4JBLEx_DelNodeEx()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ��չɾ����¼,��ͬʱɾ�������ļ�¼,��Ҫ����ԭ���Ե�������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static bool DelNodeEx({0} {1})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static bool DelNodeEx({0} {1}, {2} {3})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName,
                objPrjTabENEx.objCacheClassifyFld.CsType, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n" + "//��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n" + "objSQL = cls{0}DA.GetSpecSQLObj();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//ɾ��TeacherInfo�������뵱ǰ�����йصļ�¼");
            strCodeForCs.Append("\r\n" + "SqlConnection objConnection = null;");
            strCodeForCs.Append("\r\n" + "SqlTransaction objSqlTransaction = null;");
            strCodeForCs.Append("\r\n" + "  try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//��ȡ���Ӷ���");
            strCodeForCs.Append("\r\n" + "objConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            strCodeForCs.Append("\r\n" + "//��ȡ�����Ӷ����е�����");
            strCodeForCs.Append("\r\n" + "objSqlTransaction = objConnection.BeginTransaction();");
            strCodeForCs.Append("\r\n" + "//");
            strCodeForCs.AppendFormat("\r\n" + "//ɾ�����:[{0}]��صı�Ĵ���,��Ҫʱȥ��ע��,��д��صĴ���",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//string strCondition = string.Format(\"{0} = '{1}'\",");
            strCodeForCs.AppendFormat("\r\n" + "//con{0}.{1},", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "//{0});", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "//        cls{0}BL.Del{0}sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelNode({1}, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelNode({1}, {2}, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "                objSqlTransaction.Commit();");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ErrorInformationBL.AddInformation(\"cls{0}BLEx\", \"DelNodeEx\", objException.Message, clsSysParaEN.strUserId);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��չɾ����¼����:{0}!KeyId = {1}.({2})\",");
            strCodeForCs.Append("\r\n" + "objException.Message,");
            strCodeForCs.AppendFormat("\r\n" + "{0}, clsStackTrace.GetCurrClassFunction());",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "if (objSqlTransaction != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objSqlTransaction.Rollback();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

            //return false;
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "finally");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objConnection.Close();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_DelRecord4MultiTab()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ��չɾ����¼,��ͬʱɾ�������ļ�¼,��Ҫ����ԭ���Ե�������");
            strCodeForCs.AppendFormat("\r\n" + "/// �����������ʾ����,ʹ��ʱ�븴�Ƶ���չ��:[{0}]�и���Ϊ:[{1}]ʹ��",
                objPrjTabENEx.TabName,
                "DelRecord4MultiTabEx");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool DelRecord4MultiTab({0} {1})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n" + "//��ȡ���Ӷ���");
            strCodeForCs.AppendFormat("\r\n" + "objSQL = cls{0}DA.GetSpecSQLObj();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//ɾ��TeacherInfo�������뵱ǰ�����йصļ�¼");
            strCodeForCs.Append("\r\n" + "SqlConnection objConnection = null;");
            strCodeForCs.Append("\r\n" + "SqlTransaction objSqlTransaction = null;");
            strCodeForCs.Append("\r\n" + "  try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//��ȡ���Ӷ���");
            strCodeForCs.Append("\r\n" + "objConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            strCodeForCs.Append("\r\n" + "//��ȡ�����Ӷ����е�����");
            strCodeForCs.Append("\r\n" + "objSqlTransaction = objConnection.BeginTransaction();");
            strCodeForCs.Append("\r\n" + "//");
            strCodeForCs.AppendFormat("\r\n" + "//ɾ�����:[{0}]��صı�Ĵ���,��Ҫʱȥ��ע��,��д��صĴ���",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//string strCondition = string.Format(\"{0} = '{1}'\",");
            strCodeForCs.Append("\r\n" + "//constStudent.id_College,");
            strCodeForCs.Append("\r\n" + "//strid_College);");
            strCodeForCs.Append("\r\n" + "//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n" + "//");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1}, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "                objSqlTransaction.Commit();");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ErrorInformationBL.AddInformation(\"cls{0}BL\", \"DelRecord4MultiTab\", objException.Message, clsSysParaEN.strUserId);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"ɾ������¼����:{0}!KeyId = {1}.({2})\",");
            strCodeForCs.Append("\r\n" + "objException.Message,");
            strCodeForCs.AppendFormat("\r\n" + "{0}, clsStackTrace.GetCurrClassFunction());",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "if (objSqlTransaction != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objSqlTransaction.Rollback();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

            //return false;
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "finally");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objConnection.Close();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Neo4JBLEx_DefineUniqueInstance4DALEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ����ģʽ:�������ݷ�����չ��ĵ���ģʽ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DAEx uniqueInstanceEx = null;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ����ģʽ:�������ݷ�����չ��ĵ���ģʽ,ʹ���ݷ�����չ��ķ��ʲ���Ҫ��γ�ʼ����");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DAEx {0}DAEx", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "    get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (uniqueInstanceEx == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "uniqueInstanceEx = new cls{0}DAEx();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return uniqueInstanceEx;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_DefineObjLst4Cache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "   private static string strMsg = \"\";");
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_ReFreshCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "  if (clsSysParaEN.spIsUseQueue4Task == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.arrFunctionLst4Queue == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "clsDynamicFunction objDynamicFunction = new clsDynamicFunction();");
            strCodeForCs.AppendFormat("\r\n" + "objDynamicFunction.NameSpace = \"{0}.BusinessLogic\";", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "objDynamicFunction.ClsName = \"cls{0}BL\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objDynamicFunction.AssemblyType = typeof({0}.BusinessLogic.cls{1}BL);", objProjectsENEx.PrjDomain, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "objDynamicFunction.FunctionName = clsStackTrace.GetCurrFunction();");
            strCodeForCs.Append("\r\n" + "if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"ˢ1�»���ɹ�!({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.objCommFun4BL.ReFreshCache();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4BL_ReFreshThisCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�±����еĻ���.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg;");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
          objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"ˢ1�»���ɹ�!({{2}}->{{1}}->{{0}})\",");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = string.Format(\"ˢ�»����Ѿ��رա�(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4CFBL_ReFreshCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public override void ReFreshCache()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg;");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = string.Format(\"ˢ�»����Ѿ��رա�(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache();",
                    objPrjTabENEx.TabName);
            //string strTabId = cboPrjTab.SelectedValue.ToString();
            //arrPrjTabObjLst = clsPrjTabBLEx.GetPrjTabObjLstByPrjIdCacheEx(strPrjId);
            //int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            foreach (string strRelaTabId in arrTabId)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                if (objPrjTab.TabStateId != "01") continue;
                //string strMsg = string.Format("{0}({1}) ",
                //    objPrjTab.TabName, objPrjTab.TabId);
                //listBox1.Items.Add(strMsg);
                if (objPrjTab.IsUseCache == false) continue;
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache();",
                        objPrjTab.TabName);
            }

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_DefineConst4Xml()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����XML����ǩ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �б��XML����ǩ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");


            return strCodeForCs.ToString();
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_{0}(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_{0}(string strWhereCond)", "��ȡ�����ݳ���_{0}!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                    strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond)", "��ȡ�����ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(strWhereCond, lstExclude)", "��ȡ�����ݳ���!(�ų��ļ���ַ����б�)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(�ų��ļ���ַ����б�)(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)", "��ȡ�����ݳ���!(�Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(�Ƿ���SQL����), {{1}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})��ȡ�����ݳ���!(�Ƿ���SQL����)({1}: GetDataTable)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����ݳ���!(�Ƿ���SQL����)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, string strTabName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, strTabName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond, string strTabName)", "��ȡ�����ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, strTabName, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(strWhereCond, strTabName, lstExclude)", "��ȡ�����ݳ���!(�ų��ļ���ַ����б�)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(�ų��ļ���ַ����б�)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, strTabName, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)", "��ȡ�����ݳ���!(�Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(�Ƿ���SQL����),{{1}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})��ȡ�����ݳ���!(�Ƿ���SQL����)({1}: GetDataTable)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����ݳ���!(�Ƿ���SQL����)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }


        public string Gen_4BL_GetTopDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_Top", "��ȡ�����ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_Top", "��ȡ�����ݳ���!(�ų��ļ���ַ����б�)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(�ų��ļ���ַ����б�)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_Top", "��ȡ�����ݳ���!(�Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(�Ƿ���SQL����),{{1}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByPager", "��ȡ��ҳ�����ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ��ҳ�����ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByPager", "��ȡ��ҳ�����ݳ���!(�ų��ļ���ַ����б�)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ��ҳ�����ݳ���!(�ų��ļ���ַ����б�)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByPager", "��ȡ��ҳ�����ݳ���!(�Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ��ҳ�����ݳ���!(�Ƿ���SQL����),{{1}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "��ȡ�����Χ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����Χ���ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})��ȡ�����Χ���ݳ���!(strWhereCond = {{0}})({1}:GetDataTableByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����Χ���ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4BL_GetDataTableByRange_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "��ȡ�����Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})��ȡ�����Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)(strWhereCond = {{0}})({1}:GetDataTableByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����Χ���ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }


        public string Gen_4BL_GetDataTableByRange_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "��ȡ�����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})��ȡ�����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)(strWhereCond = {{0}})({1}:GetDataTableByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet(string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSet", "��ȡ�����ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})��ȡ�����ݳ���!(strWhereCond = {{0}})({1}:GetDataSet)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSet_Top", "��ȡ�����ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����ݳ���!(strWhereCond = {{1}}),{{2}}({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})��ȡ�����ݳ���!(strWhereCond = {{0}})({1}:GetDataSet)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetByRange", "��ȡ�����Χ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�����Χ���ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})��ȡ�����Χ���ݳ���!(strWhereCond = {{0}})({1}:GetDataSetByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetV(string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetV", "��ȡ����ͼ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ���ݳ���!(strWhereCond = {{1}}),{{2}}({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"04:(errid:{22})��ȡ����ͼ���ݳ���!(strWhereCond = {{0}})({1}:GetDataSetV)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ����ͼ���ݳ���!\\r\\n({1}:GetDataSetV)\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strWhereCond, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetVByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetVByRange", "��ȡ����ͼ����Χ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ����Χ���ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})��ȡ����ͼ����Χ���ݳ���!(strWhereCond = {{0}})({1}:GetDataSetVByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ����ͼ����Χ���ݳ���!\\r\\n({1}:GetDataSetVByRange)\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "��ȡ����ͼ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ���ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��ǰ����ͼ�����ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݱ�,��DataTable��ʾ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}V(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_{0}V(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_{0}V", "��ȡ����ͼ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ���ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTableV_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ����ͼ,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableV(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "��ȡ����ͼ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableVByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "��ȡ����ͼ����Χ���ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ����Χ���ݳ���!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})��ȡ����ͼ����Χ���ݳ���!(strWhereCond = {{0}})({1}:GetDataTableVByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ����ͼ����Χ���ݳ���!\\r\\n({1}:GetDataTableVByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableVByRange(strWhereCond, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "��ȡ����ͼ����Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ����Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})��ȡ����ͼ����Χ���ݳ���!(ͬʱ�����ų�һЩ�ؼ��ֲ����)(strWhereCond = {{0}})({1}:GetDataTableVByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableVByRange(strWhereCond, bolIsCheckSQLAttack, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "��ȡ����ͼ����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ����ͼ����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})��ȡ����ͼ����Χ���ݳ���!(ͬʱ����Ƿ���SQL����)(strWhereCond = {{0}})({1}:GetDataTableVByRange)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ�����ݳ���!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
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
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetV(strWhereCond);",
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


        public string Gen_4BL_GetRecObjLstFromDataTable()
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

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            //strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond, lstExclude);",
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


        public string Gen_4BL_GetObjLstByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByTabName(string strWhereCond, string strTabName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond, strTabName);",
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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond, strTabName, lstExclude);",
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

        public string Gen_4BL_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡJSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static string GetJSONObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = GetObjLst(strWhereCond);",
                    objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");

            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡJSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);",
                        objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");

            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_Top(intTopSize, strWhereCond);",
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
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);",
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
        public string Gen_4BL_GetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ҳ��ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <returns>���ط�ҳ�����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
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
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);",
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

        public string Gen_4BL_GeneEnumConstList()
        {
            string strKeyFieldName = "";
            string strNamedFieldName = "";
            string strEnglishNameFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strKeyFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strNamedFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "05")
                {
                    strEnglishNameFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (string.IsNullOrEmpty(strKeyFieldName) == true) return "";
            if (string.IsNullOrEmpty(strNamedFieldName) == true) return "";
            if (string.IsNullOrEmpty(strEnglishNameFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����!������{0},������Ϣ��{1}��({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݱ���������enum�б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\npublic class enum{0}",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strBuilder.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GeneEnumConstList4Field()
        {

            string strStrConstFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FieldTypeId == "07")
                {
                    strStrConstFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }

            if (string.IsNullOrEmpty(strStrConstFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����!������{0},������Ϣ��{1}��({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// ���ݱ��ֶ���������enum�б�-�ֶ�����[{0}]", objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.AppendFormat("\r\npublic class enum{0}_{1}",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", strFieldValue);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string con{0} = \"{0}\";",
                        strFieldValue);
                }

                strBuilder.Append("\r\n}");
            }
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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">��ѯ�������ų��ı�־�б�</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);",
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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> {0}List(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
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

        public string Gen_Neo4JBLEx_GetObjExLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��չ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">������������������</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>������չ�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}ENEx> GetObjExLst(cls{0}EN obj{0}Cond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arrObjLst = cls{0}BL.GetObjLst(obj{0}Cond).ToList();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "List <cls{0}ENEx> arrObjExLst = new List<cls{0}ENEx>();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}ENEx obj{0}ENEx = new cls{0}ENEx();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.CopyTo(objInFor, obj{0}ENEx);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arrObjExLst.Add(obj{0}ENEx);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "return arrObjExLst;");
            strBuilder.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public string Gen_Neo4JBLEx_Static_CopyToEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>Ŀ�����=>cls{0}EN:obj{0}ENT</returns>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static cls{0}ENEx CopyToEx(this cls{0}EN obj{0}ENS)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}ENEx obj{0}ENT = new cls{0}ENEx();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyToEx_Static", "��̬Copy��:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_Neo4JBLEx_CopyToEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>Ŀ�����=>cls{0}EN:obj{0}ENT</returns>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static cls{0}ENEx CopyToEx(cls{0}EN obj{0}ENS)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}ENEx obj{0}ENT = new cls{0}ENEx();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyToEx_Static", "Copy��Ex:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBLEx_Static_CopyTo()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>Ŀ�����=>cls{0}EN:obj{0}ENT</returns>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static cls{0}EN CopyTo(this cls{0}ENEx obj{0}ENS)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}ENT = new cls{0}EN();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo__Static", "��̬Copy��:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecProperty4Object()
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

            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKey()
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
            string strErrId = "";
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}",
                        string.Format("�ڱ���,�ؼ���[Key]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "���ɴ���");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�ڱ���,�ؼ���[{3}]����Ϊ��!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:Get{1}By{3})\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName, strErrId,
                //         objKeyField.FldName);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}DA.GetObjBy{1}({2});",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBLEx_GetObjExByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,����չ�������ʽ��ʾ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>����չ����</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}ENEx GetObjExBy{2}({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.AppendFormat("\r\n" + "cls{0}ENEx obj{0}ENEx = new cls{0}ENEx();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.CopyTo(obj{0}EN, obj{0}ENEx);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}ENEx;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>�����</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{2}({1}, string strTabName)",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            string strErrId = "";
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}ByTabName",
                        string.Format("�ڱ���,�ؼ���[Key]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "���ɴ���");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�ڱ���,�ؼ���[{3}]����Ϊ��!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:Get{1}By{3})\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName, strErrId,
                //         objKeyField.FldName);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}DA.GetObjBy{1}({2}, strTabName);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy��:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObjToSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyObjToSimObj(cls{0}EN obj{0}ENS, cls{0}EN_Sim obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjToSimObj(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyObjToSimObj", "Copy��:{0} ���󵽼򵥶������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyObjToSimObj)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyObjToSimObj)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyObjFromSimObj4Upd(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjFromSimObj4Upd(obj{0}ENS, obj{0}ENT);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyObjFromSimObj4Upd", "Copy��:{0} �򻯶��󵽶�������(����޸�)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy���������(����޸�)����,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} ��������(����޸�)����!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_SetUpdFlag_S()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����޸ı�־,�������ֶ��޸ı�־�ַ�����ȡ��һ���ֶ��Ѿ����޸�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void SetUpdFlag(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}EN.sfUpdFldSetStr;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(obj{0}EN.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }
            
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "SetUpdFlag", "���ñ���޸ı�־����!��:{0}.", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})���ñ���޸ı�־����,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} ��������(����޸�)����!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyObjFromSimObj(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjFromSimObj(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyObjFromSimObj", "Copy��:{0} �򻯶��󵽶������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetSimObjLstFromObjLst_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѷ����б�ת���ɼ򻯶����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">�����б�</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�򻯶����б�</returns>");
            strBuilder.AppendFormat("\r\n public static List<cls{0}EN_Sim> GetSimObjLstFromObjLst(List<cls{0}EN> arr{0}ObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = new List<cls{0}EN_Sim>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjToSimObj(obj{0}EN, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n arr{0}SimObjLst.Add(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return arr{0}SimObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetSimObjFromObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѷ���ת���ɼ򻯶���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�򻯶���</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN_Sim GetSimObjFromObj(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjToSimObj(obj{0}EN, obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN_Sim;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѽ򻯶���ת���ɶ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�򻯶���</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN GetObjFromSimObj(cls{0}EN_Sim obj{0}EN_Sim)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjFromSimObj(obj{0}EN_Sim, obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѽ򻯶���ת���ɶ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�򻯶���</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN GetObjFromSimObj4Upd(cls{0}EN_Sim obj{0}EN_Sim)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjFromSimObj4Upd(obj{0}EN_Sim, obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetSimObjFromObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѽ򻯶���ת���ɶ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�򻯶���</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN_Sim GetSimObjFromObj4Upd(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strsfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "CopyObjToSimObj(obj{0}EN, obj{0}EN_Sim);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN_Sim.sfUpdFldSetStr = strsfUpdFldSetStr;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN_Sim;",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n }");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelRecord({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = {0}DA.DelRecord({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            //strBuilder.Append("\r\n" + "  //����ɾ����¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onDelRecord?.Invoke({0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ���ɾ����¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "���ݹؼ���ɾ����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})���ݹؼ���ɾ����¼����,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})���ݹؼ���ɾ����¼����!({1}:DelRecord)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"���ݹؼ���ɾ����¼����!({1}: DelRecord)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.DelRecord({1},objSqlConnection,objSqlTransaction);",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "���ݹؼ���ɾ����¼����!(ʹ������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})���ݹؼ���ɾ����¼����!(ʹ������),{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})���ݹؼ���ɾ����¼����!(ʹ������)({1}:DelRecord)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"���ݹؼ���ɾ����¼����!(ʹ������)({1}: DelRecord)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.DelRecordBySP({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            //strBuilder.Append("\r\n" + "  //����ɾ����¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "    onDelRecord?.Invoke({0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ���ɾ����¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySP", "ͨ���洢����ɾ����¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})ͨ���洢����ɾ����¼����,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"10:(errid:{22})ͨ���洢����ɾ����¼����!({1}:DelRecordBySP)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ���ֵ�б�</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}s(List<string> arr{1}Lst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intDelRecNum = {0}DA.Del{0}(arr{1}Lst);",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return intDelRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}s", "ɾ����ؼ��ּ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})ɾ����ؼ��ּ�¼����,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"09:(errid:{22})ɾ����ؼ��ּ�¼����!({1}:Del{0}s)\\r\\n\" + objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ����ؼ��ּ�¼����!({1}: Del{0}s)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼����</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = {0}DA.Del{0}(strWhereCond);",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCond", "ɾ�����������¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})ɾ�����������¼����!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                     strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"08:(errid:{22})ɾ�����������¼����!(strWhereCond = {{0}})({1}:Del{0}sByCond)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ�����������¼����!({1}: Del{0}sByCond)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ�ɾ���ɹ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}sByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.Del{0}WithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCondWithTransaction_S", "ɾ�����������¼����!(ͬʱ��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})ɾ�����������¼����!(ͬʱ��������)(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"08:(errid:{22})ɾ�����������¼����!(ͬʱ��������)(strWhereCond = {{0}})({1}:Del{0}sByCondWithTransaction_S)\\r\\n ������Ϣ:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"ɾ�����������¼����!(ͬʱ��������)({1}: Del{0}WithTransaction_S)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            clsTabFunctionPropEN objTabFunctionProp = objPrjTabENEx.arrTabFunctionProp.Find(x=>x.FuncId4GC == objPrjTabENEx.FuncId4GC);
            if (objTabFunctionProp == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            }
            else
            {
                clsMethodModifierEN objMethodModifier = clsMethodModifierBL.GetObjByMethodModifierIdCache(objTabFunctionProp.MethodModifierId);
                strBuilder.AppendFormat("\r\n" + "{1} static bool AddNewRecordBySql2(cls{0}EN obj{0}EN)",
                        objPrjTabENEx.TabName, objMethodModifier.MethodModifierName);
            }
            strBuilder.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��!(from {0})\\r\\n\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //��������¼�¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ�����Ӽ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "��Ӽ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��Ӽ�¼����, {{1}}.(from {{0}})\",", strErrId );
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})��Ӽ�¼����!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��.(from {{0}})\", ");
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.AddNewRecordBySQL2(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "��Ӽ�¼����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��Ӽ�¼����!(��������), {{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})��Ӽ�¼����!(��������)({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!(��������)({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2WithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02 
                && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ,ͬʱ�����²����¼�Ĺؼ��ֵ�ֵ(���Identity�ؼ���)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3�������²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻��²����¼�Ĺؼ��ֵ�ֵ,����ͱ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��!(from {{0}})\", ");
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.AppendFormat("\r\n" + "string strKey = {0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "������ֵ����Ӽ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})������ֵ����Ӽ�¼����, {{2}}.(from {{0}})\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_AddNewRecordBySql2WithReturnKeyAndTransaction_S()
        {

            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
              && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ,ͬʱ�����²����¼�Ĺؼ��ֵ�ֵ,�ú������Խ���������(���Identity�ؼ���)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3�������²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");

            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻��²����¼�Ĺؼ��ֵ�ֵ,����ͱ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��!(from {{0}})\", ");
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = {0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "������ֵ����Ӽ�¼����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})������ֵ����Ӽ�¼����!(��������), {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">����ʵ������XML��</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql_XML", "��Ӽ�¼����!(ʹ��XML)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��Ӽ�¼����!(ʹ��XML), {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.Update(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update", "�޸ļ�¼����!", "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼����, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + " {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            strBuilder.Append("\r\n" + " }");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //�����޸ļ�¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ����޸ļ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼����,{{1}}!(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql2ByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN, string strTabName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //�����޸ļ�¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ����޸ļ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼����, {{2}}.(from {{0}})\\r\\n\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + " {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!(��������)(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "�޸ļ�¼����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼����,{{1}}.(��������)(from {{0}})\\r\\n\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySqlWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithCondition", "���������޸ļ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})���������޸ļ�¼����, {{1}}.(from {{0}})\\r\\n\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySqlWithConditionTransaction(obj{0}EN, strWhereCond, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithConditionTransaction", "���������޸ļ�¼����!(��������)", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})���������޸ļ�¼����!(��������),{{1}}.(from {{0}})\\r\\n\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�ṩXML��������ʵ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">��Ҫ�޸ĵĶ���,��XML����ʾ</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.Append("\r\n" + "ReFreshCache();");

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql_XML", "�޸ļ�¼(UpdateBySql_XML)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�޸ļ�¼(UpdateBySql_XML)����,{{1}}.!(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistRecord(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}DA.IsExistCondRec(strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = new cls{1}DA().GetFirstID(strWhereCond);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetFirstID_S", "��ȡFirst�ؼ��ֳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡFirst�ؼ��ֳ���, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������������Ĺؼ����б�ֵ</returns>");

            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID_S(string strWhereCond) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n List<string> arrList;");
            //strBuilder.AppendFormat("\r\n {0} {1};",
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arrList = {0}DA.GetID(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return arrList;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetPrimaryKeyID_S", "��ȡ�ؼ����б����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ�ؼ����б����, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");

            strBuilder.Append("\r\npublic static string GetMaxStrId() ");
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
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrId", "��ȡ���ؼ���ֵ(GetMaxStrId)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ���ؼ���ֵ����, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetMaxStrIDByPrefix_S()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06) return "";

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");

            strBuilder.Append("\r\npublic static string GetMaxStrIdByPrefix_S(string strPrefix) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strPrefix) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = string.Format(\"ǰ׺����Ϊ��.(from {0})\",");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n string strMax{1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strMax{0} = new cls{1}DA().GetMaxStrIdByPrefix(strPrefix);",
            objKeyField.FldName_FstUcase, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return strMax{0};", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrIdByPrefix_S", "����ǰ׺��ȡ���ؼ���ֵ(GetMaxStrId)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})����ǰ׺��ȡ���ؼ���ֵ����, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})����Ƿ���ڵ�ǰ��(IsExistTable)����, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����Ƿ���ڵ�ǰ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">������</param>");
            strBuilder.Append("\r\n /// <returns>���ھͷ���True,���򷵻�False</returns>");

            strBuilder.Append("\r\npublic static bool IsExistTable(string strTabName) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n bool bolIsExist;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n bolIsExist = {0}DA.IsExistTable(strTabName);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistTable", "����Ƿ����ָ����(IsExistTable)����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})����Ƿ����ָ����(IsExistTable)����, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ķ���</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetFirstObj_S(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = {0}DA.GetFirstObj(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetFirstObj_S", "��ȡ��ǰ�����������ĵ�һ����¼���ݳ���", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})��ȡ��ǰ�����������ĵ�һ����¼���ݳ���!(strWhereCond = {{1}}),{{2}}.(from {{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">������DataRow</param>");
            strBuilder.Append("\r\n /// <returns>������ص�ʵ�����</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRow objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = {0}DA.GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "����DataRow��¼��ȡ�������!", "���ɴ���");


            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})����DataRow��¼��ȡ�������, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��DataRowViewת�������ʵ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">������DataRowView</param>");
            strBuilder.Append("\r\n /// <returns>������ص�ʵ�����</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRowView objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = {0}DA.GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "����DataRowView��¼��ȡ�������!", "���ɴ���");


            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})ͨ��DataRowView��¼�������, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExist",
                    string.Format("�ڱ���,�ؼ���[Key]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "���ɴ���");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�ڱ���,�ؼ���[{1}]����Ϊ��!!(from {{0}})\",", strErrId, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{22})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:IsExist)\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName,
                //         strErrId);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}DA.IsExist({1});",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
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
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistByTabName",
                    string.Format("�ڱ���,�ؼ���[Key]����Ϊ��!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "���ɴ���");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})�ڱ���,�ؼ���[{1}]����Ϊ��.(from {{0}})\",", strErrId, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{22})�ڱ�[{1}]��,�ؼ���[{0}]����Ϊ��!(cls{1}BL:IsExist)\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName,
                //         strErrId);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}DA.IsExist({1}, strTabName);",
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
                    strBuilder.Append("\r\n" + "//����¼�Ƿ����");
                    strBuilder.AppendFormat("\r\n" + "bool bolIsUniqueness = {0}DA.Check{1}Uniqueness({3}, {5});",
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
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                            objKeyField.PropertyName(this.IsFstLcase));
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
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{1}Uniqueness(",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "else");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{1}Uniqueness(",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    objKeyField.PropertyName(this.IsFstLcase));
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

            strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{0}Uniqueness(",
            objPrjTabENEx.TabName);
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

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
            strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{0}Uniqueness(",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("obj{0}EN.{1}",
            objPrjTabENEx.TabName,
            objKeyField.FldName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;
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
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
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

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ��Ψһ�Ķ���</param>",
                       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.Append($"\r\npublic static string GetUniCondStr{strVersion}(cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "//����¼�Ƿ����");

                strBuilder.AppendFormat("\r\n" + "string strResult = {0}DA.GetUniCondStr(",
                objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                strBuilder.AppendFormat("obj{0}EN.{1}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
                //bool bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����
            strBuilder.AppendFormat("\r\n {0}DA.CheckPropertyNew(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPrjTabENEx"></param>
        /// <returns></returns>
        public string Gen_4BL_CombineConditionByCondObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �������������е��ֶ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetCombineCondition(clsCond_{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");




                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {

                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objPrjTabFldEx.objCtlType.CtlTypeName
                    {
                        case enumDataTypeAbbr.bit_03:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                                 objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                        objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            break;

                        case enumDataTypeAbbr.char_04:
                        case enumDataTypeAbbr.varchar_25:
                        case enumDataTypeAbbr.nvarchar_15:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.datetime_05:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.decimal_06:
                        case enumDataTypeAbbr.float_07:
                        case enumDataTypeAbbr.int_09:
                        case enumDataTypeAbbr.bigint_01:

                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} {{1}}\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "//��������{0}({1})�ں���:[{2}]��û�д���!",
                                  objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                  clsStackTrace.GetCurrClassFunction());
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_CheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ����֯��ѯ����ʱ�Ƿ�Ϸ�,1)����Ƿ������ = ���� and ��;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����
            strBuilder.AppendFormat("\r\n {0}DA.CheckProperty4Condition(obj{0}EN);",
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
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
                        objPrjTabENEx.TabName, strValueFieldName, "{", "}");
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

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
                     objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
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
                if (string.IsNullOrEmpty(strValueFieldName) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]�Ĺؼ��ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                    return strCodeForCs.ToString();

                }
                if (string.IsNullOrEmpty(strTextFieldName) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                    return strCodeForCs.ToString();
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

                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
    objPrjTabENEx.TabName, strValueFieldName, "{", "}");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}BL.GetDataTable(strCondition);",
                        strValueFieldName, objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};", objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
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

        public string Gen_4BL_DdlBindFunctionCache()
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

                    //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = new cls{1}DA().Get{0}();",
                    //strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = GetAll{0}ObjLstCache(); ",
                              objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};", objPrjTabENEx.TabName, strTextFieldName);
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

        public string Gen_4BL_GetObjLst4SelectListItem()
        {
            if (objProjectsENEx.IsSupportMvc == false) return "//������Ŀ��֧��Mvc,���Բ�������GetObjLst4SelectListItem()����";
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��ȡ�û���������Ķ����б�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static List<SelectListItem> GetObjLst4SelectListItem(string strWhereCond)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");


                    //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = new cls{1}DA().Get{0}();",
                    //strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(strWhereCond); ",
                              objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<SelectListItem> {0}List = new List<SelectListItem>();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = \"ѡ[{5}]...\", Value = \"0\" {4});",
                    objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}", objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = objInFor.{1}, Value = objInFor.{2} {4});",
                        objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.AppendFormat("\r\n" + "return {0}List;", objPrjTabENEx.TabName);

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

        public string Gen_4BL_SortFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsSortFld == false) continue;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// �����б�������,����:{0}�ֶ�", objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"parr{0}ObjLst\">��Ҫ����Ķ����б�</param>", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "public static void Sort{0}ObjLstBy{1}(List<cls{0}EN> parr{0}ObjLst, SortOrder mySortOrder)",
                                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.AppendFormat("\r\n" + "parr{0}ObjLst.Sort((cls{0}EN obj{0}EN1, cls{0}EN obj{0}EN2) =>",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN1.{1}.CompareTo(obj{0}EN2.{1})<0)",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN1.{1} < obj{0}EN2.{1})",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (mySortOrder == SortOrder.Ascending)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return -1;//��ֵС����ֵ,����-1,Ϊ����,�������1,���ǽ���  ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return 1;//��ֵС����ֵ,����-1,Ϊ����,�������1,���ǽ���  ");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN1.{1} == obj{0}EN2.{1})//��ֵ������ֵ,����0  ",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return 0;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (mySortOrder == SortOrder.Ascending)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return 1;//��ֵ������ֵ,����1,Ϊ����,�������-1,���ǽ���  ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return -1;//��ֵ������ֵ,����1,Ϊ����,�������-1,���ǽ���  ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "});");
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
        public string Gen_4BL_GetSubSet4ObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "06") continue;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// ���ݷ����ֶλ�ȡ�����ж����б���Ӽ�,����:{0}�ֶ�", objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"parr{0}ObjLst\">��Ҫ����Ķ����б�</param>", objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "public static List <cls{0}EN> GetSubSet4{0}ObjLstBy{1}Cache({2} {3})",
                                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                                objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "   if (string.IsNullOrEmpty({0}) == true) return null;",
                            objField.ObjFieldTabENEx.PrivFuncName);
                    }
                    // strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.Append("\r\n" + "//��ʼ���б���");
                    strCodeForCs.Append("\r\n" + "InitListCache(); ");

                    strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in cls{0}BL.arr{0}ObjLstCache", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.AppendFormat("\r\n" + "                    return arr{0}ObjLst_Sel;", objPrjTabENEx.TabName);
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
        /// ��ʼ���б���.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_InitListCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            StringBuilder strBuilder = new StringBuilder();
            //��ʼ���б���.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ʼ���б���.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n" + "public static void InitListCache()");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            {
                strBuilder.Append("\r\n" + "//��黺��ˢ�»���");
                strBuilder.Append("\r\n" + "string strMsg;");
                strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"��cls{2}BLû��ˢ�»������(cls{2}BL.objCommFun4BL == null), ����ϵ����Ա!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                    "{", "}", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            {
                List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                bool bolIsDef_strMsg = false;
                foreach (string strRelaTabId in arrTabId)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                    if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                    if (objPrjTab.TabName == "Sex")
                    {
                        string strMsg = string.Format("objPrjTab.TabName={0},objPrjTab.TabStateId='{1}'",
                            objPrjTab.TabName, objPrjTab.TabStateId);
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                    }
                    if (objPrjTab.TabStateId != "01") continue;

                    if (bolIsDef_strMsg == false)
                    {
                        strBuilder.Append("\r\n" + "//��黺��ˢ�»���");
                        strBuilder.Append("\r\n" + "string strMsg;");
                        bolIsDef_strMsg = true;
                    }
                    strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTab.TabName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"��cls{2}BLû��ˢ�»������(cls{2}BL.objCommFun4BL == null), ����ϵ����Ա!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        "{", "}", objPrjTab.TabName);
                    strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.AppendFormat("\r\n" + "//string strWhereCond = string.Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "//if (arr{0}ObjLstCache == null)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//{");
            strBuilder.AppendFormat("\r\n" + "//arr{0}ObjLstCache = {0}DA.GetObjLst(strWhereCond);",
                  objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "}");

            //��ʼ���б���.======================= = ;
            return strBuilder.ToString();
        }

       
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.ʹ��˳���ѯ
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyCache_TryOnce()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.(����һ��)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_TryOnce({2} {3})",
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

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in cls{0}BL.arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count >= 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0];",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache_TryOnce({2});",
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
        public string Gen_4BL_GetObjByKeyCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            StringBuilder strBuilder = new StringBuilder();
            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.û�оͷ���null.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            //strBuilder.Append("\r\n" + "//��ʼ���б���");
            //  strBuilder.Append("\r\n" + "InitListCache(); ");
            strBuilder.Append("\r\n" + "//��ȡ�����еĶ����б�");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = CacheHelper.GetCache(con{0}._CurrTabName_S, GetObjLstCache);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count == 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0];", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetAllRecObjLstCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n string strWhereCond = string.Format(\"{0} in ({{0}})\", strSqlConditionStr);", objKeyField.FldName, "{", "}");


            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
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
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyFromList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �Ӹ����Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(con{1}.{0}))",
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
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(con{1}.{0}))",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.Append("\r\n" + "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���л��Ķ���</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>����XML��</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStrByIso(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "bool":
                        //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                        // objField.ObjFieldTabENEx.FldName);
                        //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                        // strPrivPropNameWithObjectName4Get);
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString().ToLower(CultureInfo.InvariantCulture));",
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
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                      objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "byte[]":
                        //sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                }

                return sbCodeForCs.ToString();
            }
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "string":
                    sbCodeForCs.AppendFormat("\r\n" + "if (obj{1}EN.{0} != null)",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n{");
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n}");
                    break;
                case "bool":
                    //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                    // objField.ObjFieldTabENEx.FldName);
                    //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                    // strPrivPropNameWithObjectName4Get);
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString().ToLower(CultureInfo.InvariantCulture));",
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
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                case "byte[]":
                    //sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + "if (obj{1}EN.{0} != null)",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n{");
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n}");
                    break;
            }

            return sbCodeForCs.ToString();
        }



        public string Gen_4BL_GetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ�಻��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond(string strTabName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCountByCond(strTabName, strWhereCond);", objPrjTabENEx.TabName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = cls{0}DA.GetFldValue(strTabName, strFldName, strWhereCond);", objPrjTabENEx.TabName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValue(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetFldValueNoDistinct()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ����ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValueNoDistinct(strFldName, strWhereCond);", objPrjTabENEx.TabName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond( string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCountByCond(strWhereCond);", objPrjTabENEx.TabName);
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

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"���ʼ�����ڼ�¼��־��clsSysParaEN.objLog����!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objErrorLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"���ʼ�����ڼ�¼������־��clsSysParaEN.objErrorLog����!\");");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");



            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = {0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = {0}DA.SetFldValue(strFldName, strValue, strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(cls{0}EN._CurrTabName, strFldName, fltValue, strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = {0}DA.SetFldValue( strFldName, intValue, strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    strRemark = "/**" + strRemark0 + "*/";

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
        public string Gen_4BL_SynchToServerByCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            bool bolIsNeedSynchCode = false;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == enumFieldType.SynField_08)
                    {
                        bolIsNeedSynchCode = true;
                        break;
                    }
                }
                if (bolIsNeedSynchCode == false) return "";

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ͬ�����������ļ�¼,��Client��Server");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strCondition\">ͬ��������</param>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strOpUserId\">����ͬ�����û�</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public static int SynchToServerByCondition(string strCondition, string strOpUserId)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strOpUserId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "throw new Exception(\"ͬ���������ʱ,ͬ���˲���Ϊ��!\");");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "int intCount = 0;");

                strCodeForCs.Append("\r\n" + "string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionStringClient\";");

                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ENObjLst = cls{0}BL.GetObjLst(strCondition);",
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN4Web in arr{0}ENObjLst)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//���������¼����Դ����Server,�Ͳ���Ҫͬ����");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN4Web.SynSource == \"Server\") continue;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.IsSynchToServer = true;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.SynchToServerDate = strCurrDate14;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.SynchToServerUser = strOpUserId;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.SynSource = \"Client\";",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}_Target = cls{0}BL.GetObjBy{1}(obj{0}EN4Web.{1});",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Target != null)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "int intResult = (obj{0}_Target.UpdDate.CompareTo(obj{0}EN4Web.UpdDate));",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intResult < 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Web);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AddNewRecordBySql2(obj{0}EN4Web);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionStringClient\";");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Web);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"��ͬ����Server��ʱ,�ֶα�{0}({1})ʱ����({3}).[�ϼ��״�:{2}]\", ");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN._CurrTabName, obj{0}EN4Web.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "throw new Exception(sbMsg.ToString());");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");
                strCodeForCs.Append("\r\n" + "return intCount;");
                strCodeForCs.Append("\r\n" + "}");

            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_SynchToClientByCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            bool bolIsNeedSynchCode = false;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == enumFieldType.SynField_08)
                    {
                        bolIsNeedSynchCode = true;
                        break;
                    }
                }
                if (bolIsNeedSynchCode == false) return "";

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ͬ�����������ļ�¼,��Server��Client");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strCondition\">ͬ��������</param>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strOpUserId\">����ͬ�����û�</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public static int SynchToClientByCondition(string strCondition, string strOpUserId)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strOpUserId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "throw new Exception(\"�ϴ���Client��ʱ,ͬ���˲���Ϊ��!\");");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "int intCount = 0;");
                strCodeForCs.Append("\r\n" + "string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");

                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ENObjLst = cls{0}BL.GetObjLst(strCondition);",
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN4Main in arr{0}ENObjLst)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//���������¼����Դ����Client,�Ͳ���Ҫͬ����");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN4Main.SynSource == \"Client\") continue;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main.IsSynchToClient = true;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main.SynchToClientDate = strCurrDate14;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main.SynchToClientUser = strOpUserId;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionStringClient\";");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN4Main2 = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CopyTo(obj{0}EN4Main, obj{0}EN4Main2);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main2.SynSource = \"Server\";",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}_Target = cls{0}BL.GetObjBy{1}(obj{0}EN4Main.{1});",
                    objPrjTabENEx.TabName, objKeyField.FldName);

                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Target != null)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//���Ŀ��صĶ�������С����Դ��������ھ͸���");
                strCodeForCs.AppendFormat("\r\n" + "int intResult = obj{0}_Target.UpdDate.CompareTo(obj{0}EN4Main.UpdDate);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intResult < 0)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Main2);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AddNewRecordBySql2(obj{0}EN4Main2);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Main);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"��ͬ����Client��,�ֶα�{0}({1})ʱ����({3}).[�ϼ��״�:{2}]\", ");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN._CurrTabName, obj{0}EN4Main.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "throw new Exception(sbMsg.ToString());");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");
                strCodeForCs.Append("\r\n" + "return intCount;");
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
        /// �ö���������Ҫͬʱ���ڣ������ֶκ�����ֶ�,�����Զ����ɸú���
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GoTop()
        {

            StringBuilder strCodeForCs = new StringBuilder();
   
            try
            {
                ///���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// �������Ĺؼ����б�����Ӧ�Ķ����ö���");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">�����Ĺؼ����б�</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.Append("\r\n" + "public static bool GoTop(List<string> arrKeyId)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} - 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
  
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ö�����!����:{{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// �������Ĺؼ����б�����Ӧ�Ķ����ö������ݷ����ֶΣ�{0}��������",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">�����Ĺؼ����б�</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoTopBy{0}(List<string> arrKeyId, string str{0})",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} - 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
              
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\" {{0}} = '{{1}}' order by {{2}} \",  ",
                        objPrjTabENEx.TabName, "{", "}");
                    
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1}, str{1},", objPrjTabENEx.TabName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1});", objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ö�����,{{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //return strCodeForCs.ToString();
        }

        /// <summary>
        /// �õ׺�������Ҫͬʱ���ڣ������ֶκ�����ֶ�,�����Զ����ɸú���
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GoBottom()
        {

            StringBuilder strCodeForCs = new StringBuilder();
   
            try
            {
                ///���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// �������Ĺؼ����б�����Ӧ�Ķ����õס�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">�����Ĺؼ����б�</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.Append("\r\n" + "public static bool GoBottom(List<string> arrKeyId)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} + 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
          
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ö�����, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// �������Ĺؼ����б�����Ӧ�Ķ����ö������ݷ����ֶΣ�{0}��������",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">�����Ĺؼ����б�</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoBottomBy{0}(List<string> arrKeyId, string str{0})",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} + 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\" {{0}} = '{{1}}' order by {{2}} \",  ",
                        objPrjTabENEx.TabName, "{", "}");

                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1}, str{1},", objPrjTabENEx.TabName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1});", objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ö�����, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����������Ҫͬʱ���ڣ������ֶκ�����ֶ�,�����Զ����ɸú���
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_ReOrder()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.Append("\r\n" + "public static bool ReOrder()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�������, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// �������򡣸��ݷ����ֶΣ�{0}��������",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"str{0}\">�����Ĺؼ����б�</param>",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool ReOrderBy{0}(string str{0})",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\" {{0}} = '{{1}}' order by {{2}} \",  ",
                        objPrjTabENEx.TabName, "{", "}");

                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1}, str{1},", objPrjTabENEx.TabName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1});", objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ö�����, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����������Ҫͬʱ���ڣ������ֶκ�����ֶ�,�����Զ����ɸú���
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_AdjustOrderNum()
        {

            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {
                ///���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]�������ֶ�Ϊ��,�������ɰ���������غ����ļ�;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ���������ؼ��ּ�¼����š�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"strDirect\">������\"Up\",\"Down\"��ʾ</param>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">�����Ĺؼ���</param>",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "/// <returns>�Ƿ�ɼ�</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool AdjustOrderNum(string strDirect, {0} {1})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//�������裺");
                    strCodeForCs.AppendFormat("\r\n" + "//1�������������Ĺؼ���[{0}],��ȡ��Ӧ�����[{1}]��",
                        objKeyField.FldName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "//2�������ǰ����Ƿ���ĩ����ţ�");
                    strCodeForCs.Append("\r\n" + "//3�������ĩ�����,���˳���");
                    strCodeForCs.Append("\r\n" + "//   3.1������������ƶ�,�жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,");
                    strCodeForCs.Append("\r\n" + "//	   ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,");
                    strCodeForCs.Append("\r\n" + "//   3.2������������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,");
                    strCodeForCs.Append("\r\n" + "//	   �����ǵ�һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��");
                    strCodeForCs.AppendFormat("\r\n" + "//4����ȡ��(��)һ����ż�¼�Ĺؼ���{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//5���ѵ�ǰ�ؼ���{0}����Ӧ��¼����ż�(��)1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6������(��)һ����Źؼ���{0}����Ӧ�ļ�¼��ż�(��)1",
                        objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "string strMsg;");
                    strCodeForCs.Append("\r\n" + "int intOrderNum;    //��ǰ��¼�����");
                    strCodeForCs.Append("\r\n" + "int intPrevOrderNum, intNextOrderNum;   //����������¼�����");

                    string strPrevKeyFldName = string.Format("{0}Prev{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    string strNextKeyFldName = string.Format("{0}Next{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //��һ����ŵĹؼ���{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //��һ����ŵĹؼ���{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strNextKeyFldName,
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "int intTabRecNum;       //��ǰ�����ֶεļ�¼��");
                  
                    strCodeForCs.Append("\r\n" + "StringBuilder strCondition = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "//1�������������Ĺؼ���[{0}],��ȡ��Ӧ�����[{1}]��",
                        objKeyField.FldName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = cls{0}BL.GetObjBy{1}({2});", 
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intOrderNum = obj{0}.{1};//��ǰ���", 
                        objPrjTabENEx.TabName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum = intOrderNum - 1;//ǰһ����¼�����");
                    strCodeForCs.Append("\r\n" + "intNextOrderNum = intOrderNum + 1;//��һ����¼�����");

                    strCodeForCs.Append("\r\n" + "//3�������ǰ����Ƿ���ĩ�����,");
                    strCodeForCs.Append("\r\n" + "//		3.1 �����ĩ�����,���˳�,");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intTabRecNum = cls{0}BL.GetRecCountByCond(cls{0}EN._CurrTabName, \"1 = 1\");    //��ȡ��ǰ��ļ�¼��", 
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "switch (strDirect)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "case \"UP\":");
                    strCodeForCs.Append("\r\n" + "case \"Up\":");
                    strCodeForCs.Append("\r\n" + "case \"up\":");
                    strCodeForCs.Append("\r\n" + "//3�������ĩ�����,���˳���");
                    strCodeForCs.Append("\r\n" + "//  3.2������������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,");
                    strCodeForCs.Append("\r\n" + "//	     �����ǵ�һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum <= 1)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"�Ѿ��ǵ�һ����¼,����������.(from {{0}})\", clsStackTrace.GetCurrClassFunction());", 
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//		3.2 �������,������������ƶ�,���жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,");
                    strCodeForCs.Append("\r\n" + "//		    ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,");
                    strCodeForCs.Append("\r\n" + "//		    ����������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,");
                    strCodeForCs.Append("\r\n" + "//		    �������ʼһ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��");

                    strCodeForCs.AppendFormat("\r\n" + "strCondition.AppendFormat(\" {{0}} = {{1}}\", con{0}.{3}, intOrderNum - 1);", 
                        objPrjTabENEx.TabName, "{", "}",
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "//4����ȡ��һ������ֶεĹؼ���{0}",
                         objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(strCondition.ToString());", 
                        objPrjTabENEx.TabName,
                        strPrevKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrevKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strPrevKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"��ȡ��һ����¼�Ĺؼ��ֳ���.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5���ѵ�ǰ�ؼ���{0}����Ӧ��¼����ż�1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6������(��)һ����Źؼ���{0}����Ӧ�ļ�¼��ż�1",
                        objKeyField.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strPrevKeyFldName);

                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "case \"DOWN\":");
                    strCodeForCs.Append("\r\n" + "case \"Down\":");
                    strCodeForCs.Append("\r\n" + "case \"down\":");
                    strCodeForCs.Append("\r\n" + "//3�������ĩ�����,���˳���");
                    strCodeForCs.Append("\r\n" + "//   3.1������������ƶ�,�жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,");
                    strCodeForCs.Append("\r\n" + "//	   ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum >= intTabRecNum)    //�����ǰ��Ŵ��ڱ��¼��");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"�Ѿ������һ����¼,����������.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "                            throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "//4����ȡ��һ������ֶεĹؼ���{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "strCondition.AppendFormat(\" {{0}} = {{1}}\", con{0}.{3}, intOrderNum + 1);",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(strCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strNextKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strNextKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strNextKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"��ȡ��һ����¼�Ĺؼ��ֳ���.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5���ѵ�ǰ�ؼ���{0}����Ӧ��¼����ż�1",
                       objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6������(��)һ����Źؼ���{0}����Ӧ�ļ�¼��ż�1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intNextOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strNextKeyFldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"�����������!strDirect=[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "strDirect,");
                    strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"������¼�������!����:[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "objException.Message,");
                    strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// ���������ؼ��ּ�¼����š����ݷ����ֶΣ�{0}��������",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"strDirect\">������\"Up\",\"Down\"��ʾ</param>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">�����Ĺؼ���</param>",
                         objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"str{0}\">�����ֶ�</param>",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "/// <returns>�Ƿ�ɹ�?</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool AdjustOrderNum(string strDirect, {0} {1}, string str{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//�������裺");
                    strCodeForCs.AppendFormat("\r\n" + "//1�������������Ĺؼ���[{0}],��ȡ��Ӧ�����[{1}]��",
                        objKeyField.FldName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "//2�������ǰ����Ƿ���ĩ����ţ�");
                    strCodeForCs.Append("\r\n" + "//3�������ĩ�����,���˳���");
                    strCodeForCs.Append("\r\n" + "//   3.1������������ƶ�,�жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,");
                    strCodeForCs.Append("\r\n" + "//	   ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,");
                    strCodeForCs.Append("\r\n" + "//   3.2������������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,");
                    strCodeForCs.Append("\r\n" + "//	   �����ǵ�һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��");
                    strCodeForCs.AppendFormat("\r\n" + "//4����ȡ��(��)һ����ż�¼�Ĺؼ���{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//5���ѵ�ǰ�ؼ���{0}����Ӧ��¼����ż�(��)1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6������(��)һ����Źؼ���{0}����Ӧ�ļ�¼��ż�(��)1",
                        objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "string strMsg;");
                    strCodeForCs.Append("\r\n" + "int intOrderNum;    //��ǰ��¼�����");
                    strCodeForCs.Append("\r\n" + "int intPrevOrderNum, intNextOrderNum;   //����������¼�����");

                    string strPrevKeyFldName = string.Format("{0}Prev{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    string strNextKeyFldName = string.Format("{0}Next{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //��һ����ŵĹؼ���{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //��һ����ŵĹؼ���{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strNextKeyFldName,
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "int intTabRecNum;       //��ǰ�����ֶεļ�¼��");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "//1�������������Ĺؼ���[{0}],��ȡ��Ӧ�����[{1}]��",
                        objKeyField.FldName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = cls{0}BL.GetObjBy{1}({2});",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intOrderNum = obj{0}.{1};//��ǰ���",
                        objPrjTabENEx.TabName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum = intOrderNum - 1;//ǰһ����¼�����");
                    strCodeForCs.Append("\r\n" + "intNextOrderNum = intOrderNum + 1;//��һ����¼�����");

                    strCodeForCs.Append("\r\n" + "//3�������ǰ����Ƿ���ĩ�����,");
                    strCodeForCs.Append("\r\n" + "//		3.1 �����ĩ�����,���˳�,");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}}='{{1}}'\", con{0}.{3}, str{3});",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "intTabRecNum = cls{0}BL.GetRecCountByCond(cls{0}EN._CurrTabName, strCondition);    //��ȡ��ǰ��ļ�¼��",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "switch (strDirect)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "case \"UP\":");
                    strCodeForCs.Append("\r\n" + "case \"Up\":");
                    strCodeForCs.Append("\r\n" + "case \"up\":");
                    strCodeForCs.Append("\r\n" + "//3�������ĩ�����,���˳���");
                    strCodeForCs.Append("\r\n" + "//  3.2������������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,");
                    strCodeForCs.Append("\r\n" + "//	     �����ǵ�һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum <= 1)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"�Ѿ��ǵ�һ����¼,����������.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//		3.2 �������,������������ƶ�,���жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,");
                    strCodeForCs.Append("\r\n" + "//		    ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,");
                    strCodeForCs.Append("\r\n" + "//		    ����������ƶ�,���жϵ�ǰ����Ƿ񡰴��ڡ�1,");
                    strCodeForCs.Append("\r\n" + "//		    �������ʼһ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1��");

                    strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" {{0}} = {{1}} And {{2}}='{{3}}'\", con{0}.{3}, intOrderNum - 1, con{0}.{4}, str{4});",
                        objPrjTabENEx.TabName, "{", "}",
                        objAdjustOrderNum.OrderNumFieldName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "//4����ȡ��һ������ֶεĹؼ���{0}",
                         objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(sbCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strPrevKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrevKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strPrevKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"��ȡ��һ����¼�Ĺؼ��ֳ���.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5���ѵ�ǰ�ؼ���{0}����Ӧ��¼����ż�1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6������(��)һ����Źؼ���{0}����Ӧ�ļ�¼��ż�1",
                        objKeyField.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n  \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intPrevOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strPrevKeyFldName);

                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "case \"DOWN\":");
                    strCodeForCs.Append("\r\n" + "case \"Down\":");
                    strCodeForCs.Append("\r\n" + "case \"down\":");
                    strCodeForCs.Append("\r\n" + "//3�������ĩ�����,���˳���");
                    strCodeForCs.Append("\r\n" + "//   3.1������������ƶ�,�жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ���,");
                    strCodeForCs.Append("\r\n" + "//	   ���������һ����¼,��׼���ѵ�ǰ�ֶ������ż�1,����һ�ֶε���ż�1,");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum >= intTabRecNum)    //�����ǰ��Ŵ��ڱ��¼��");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"�Ѿ������һ����¼,����������.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "                            throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "//4����ȡ��һ������ֶεĹؼ���{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" {{0}} = {{1}}  And {{2}}='{{3}}'\", con{0}.{3}, intOrderNum + 1, con{0}.{4}, str{4});",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(sbCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strNextKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strNextKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strNextKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"��ȡ��һ����¼�Ĺؼ��ֳ���.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5���ѵ�ǰ�ؼ���{0}����Ӧ��¼����ż�1",
                       objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6������(��)һ����Źؼ���{0}����Ӧ�ļ�¼��ż�1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intNextOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strNextKeyFldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"�����������!strDirect=[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n \t \t" + "strDirect,");
                    strCodeForCs.Append("\r\n \t \t" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"������¼�������!����:[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n \t \t" + "objException.Message,");
                    strCodeForCs.Append("\r\n \t \t" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //return strCodeForCs.ToString();
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}BLEx", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

        public string Gen_Neo4JBLEx_Static_AddNodeEx()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //�����¼���̹��̴���for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����¼���̵����ݱ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>�����¼�Ƿ�ɹ���</returns>");

                strCodeForCs.AppendFormat("\r\n" + "public static bool AddNodeEx(this cls{0}EN obj{0}EN)",
                       objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                strCodeForCs.Append("\r\n" + "//2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//3����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//4��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
        
                string strErrId = "";


                strCodeForCs.Append("\r\n" + "//1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("obj{0}EN.", objPrjTabENEx.TabName), objPrjTabENEx);
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.Append("\r\n" + "");

                        strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,����Ҫ��������Ƿ��Ѿ�����,�����ʱ,�ٻ�ȡ ���ֵ��Ϊ����");
                        strCodeForCs.AppendFormat("\r\n" + "//if (cls{0}BL.IsExist({1}))	//�ж��Ƿ�����ͬ�Ĺؼ���",
                            objPrjTabENEx.TabName, strKeyFldNameLstStrWithAddStr);
                        strCodeForCs.Append("\r\n" + "//{");
                        strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNodeEx", "�ؼ����ֶ�������ͬ��ֵ", "���ɴ���");

                        strCodeForCs.AppendFormat("\r\n" + "//strMsg = \"(errid:{0})�ؼ����ֶ�������ͬ��ֵ\";", strErrId);

                        strCodeForCs.Append("\r\n" + "//throw new Exception(strMsg);");
                        strCodeForCs.Append("\r\n" + "//}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}))	//�ж��Ƿ�����ͬ�Ĺؼ���",
                    objPrjTabENEx.TabName, strKeyFldNameLstStrWithAddStr);
                        strCodeForCs.Append("\r\n" + "{");


                        strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNodeEx", "�ؼ����ֶ�������ͬ��ֵ", "���ɴ���");

                        strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})�ؼ����ֶ�������ͬ��ֵ\";", strErrId);

                        strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n //2����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objPrjTabENEx.TabName);

                string strDuplicateInfo = "";
                string strDuplicateInfo4ObjValue = "";
                bool bolIsFirst = true;
                int intCount = 0;
                //���Ψһ��------------------------------------------------------
                foreach (clsPrjTabFldENEx objPrjTabFldEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldEx.IsTabUnique == true
                    && objPrjTabFldEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})=[{{{2}}}]",
                                  objPrjTabFldEx.ObjFieldTabENEx.Caption,
                                objPrjTabFldEx.FldName, intCount++);

                            strDuplicateInfo4ObjValue += string.Format("obj{0}EN.{1}",
                                                              objPrjTabENEx.TabName,
                                                            objPrjTabFldEx.FldName);

                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})=[{{{2}}}]",
                              objPrjTabFldEx.ObjFieldTabENEx.Caption,
                               objPrjTabFldEx.FldName, intCount++);

                            strDuplicateInfo4ObjValue += string.Format(", obj{0}EN.{1}",
                                                              objPrjTabENEx.TabName,
                                                            objPrjTabFldEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n ///5.2�����Ψһ��");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"({0})�Ѿ�����,�����ظ�!\", {1});",
                           strDuplicateInfo, strDuplicateInfo4ObjValue);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //���Ψһ�� == == == == == == == == == == == == == == == == == == == == == == == == 


                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,���������ʱ,�Զ���ȡ����ֵ��");
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                        objPrjTabENEx.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + " }");
                }
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewNode();", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Add{0}RecordSave", "��Ӽ�¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})��Ӽ�¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "return true;");

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
        public string Gen_Neo4JBLEx_Static_UpdateNodeEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //�޸Ĵ���׼�����̴��� for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼���̵����ݱ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵ�ʵ�����</param>", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateNodeEx(this cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//3��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                
                //string strErrId = "";
                               
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objPrjTabENEx.TabName);
                //���Ψһ��------------------------------------------------------

                string strDuplicateInfo = "";
                bool bolIsFirst = true;
                //���Ψһ��------------------------------------------------------
                foreach (clsPrjTabFldENEx objPrjTabFldEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldEx.IsTabUnique == true
                    && objPrjTabFldEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})",
                                  objPrjTabFldEx.ObjFieldTabENEx.Caption,
                                objPrjTabFldEx.FldName);
                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})",
                              objPrjTabFldEx.ObjFieldTabENEx.Caption,
                               objPrjTabFldEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n" + "//2�����Ψһ��");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"({0})�����ظ�!\";",
                           strDuplicateInfo);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
                //���Ψһ�� == == == == == == == == == == == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "//4��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.UpdateNode();", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"�޸ļ�¼���ɹ�!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "return true; ");

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

        public string Gen_Neo4JBLEx_Static_EditNodeEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //�޸Ĵ���׼�����̴��� for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �༭��¼���̵����ݱ��С����������ؼ�¼���޸�,�����ھ����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}\">��Ҫ�޸ĵ�ʵ�����</param>", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static bool EditNodeEx(this cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//3��������ʵ�������ݴ��������ݿ���");
                //strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");

                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = null;
                foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
                {
                    if (objInFor.InUse == false) continue;
                    if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                    arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId).ToList();

                }
                
                if (arrObjLst_Flds != null && arrObjLst_Flds.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = new cls{0}EN();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = obj{0}Cond",
                        objPrjTabENEx.TabName);
                    foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                    {

                        strCodeForCs.AppendFormat("\r\n" + ".Set{1}(obj{0}.{1}, \"=\")",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTab().FldName);
                    }
                    strCodeForCs.Append("\r\n" + ".GetCombineCondition();");
                }
                else
                {
                    switch(objPrjTabENEx.objKeyField0.PrimaryTypeId)
                    {
                        case enumPrimaryType.Identity_02:
                        case enumPrimaryType.StringAutoAddPrimaryKey_03:

                            string strErrMsg = string.Format("�������󣺹ؼ�������Ϊ:[Identity or �ַ����Զ���������]�ı�,һ��Ҫ����Ψһ������;", ThisTabName4GC,
                                                          clsStackTrace.GetCurrClassFunction());

                            clsPrjTabBLEx.CheckTabFlds(objPrjTabENEx.TabId, CmPrjId, objPrjTabENEx.UserId);
                            throw new Exception(strErrMsg);

                        case enumPrimaryType.PrimaryKey_01:
                            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = new cls{0}EN();",
                       objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "string strCondition = obj{0}Cond",
                                objPrjTabENEx.TabName);
                            
                                strCodeForCs.AppendFormat("\r\n" + ".Set{1}(obj{0}.{1}, \"=\")",
                                    objPrjTabENEx.TabName,
                                    objKeyField.FldName);
                            
                            strCodeForCs.Append("\r\n" + ".GetCombineCondition();");
                            break;
                    }
                   
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}._IsCheckProperty = true;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistNode(strCondition);",
                    objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "if (bolIsExist)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = cls{0}BL.GetFirstID_S(strCondition);",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.FldName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.UpdateWithCondition(strCondition);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                    if (objPrjTabENEx.objKeyField0.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = cls{0}BL.GetMaxStrId();",
                            objPrjTabENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);

                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.AddNewNode();", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "return true; ");

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

    }
}
