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
    partial class CommFun4BL4CSharp : clsGeneCodeBase
    {
     
        #region ���캯��

        public CommFun4BL4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public CommFun4BL4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
        /// ����ҵ���߼�����룭��C#.NET
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
            if (arrvFunction4GeneCodeObjLst.Count() == 0) 
                    {
                string strMsg = string.Format("����:{4}({5}), ��������:{0}, ��������:{1}, Sql���ͣ�{2}({3})==>û�п������ɵĺ���4GC!",
                    objPrjTabENEx.LangType, clsCodeTypeBL.GetNameByCodeTypeIdCache(objPrjTabENEx.CodeTypeId),
                    clsSQLDSTypeBL.GetNameBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId), objPrjTabENEx.SqlDsTypeId,
                    objPrjTabENEx.TabName, objPrjTabENEx.TabId);
                return strMsg;
            }
            objPrjTabENEx.ClsName = string.Format("clsCommFun4BL4{0}", objPrjTabENEx.TabName);
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
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient; "); //
                strCodeForCs.Append("\r\n" + "using System.Linq;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogicEx",
                objProjectsENEx.PrjDomain);

                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommFun4BL", objPrjTabENEx.ClsName);
                }
                else if (objPrjTabENEx.objCacheClassifyFld2 == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommFun4BLV2", objPrjTabENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommFun4BLV3", objPrjTabENEx.ClsName);
                }
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                //�������еĺ���
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

        public string GeneCode_This(clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {
            //string strCodeTypeId = "";
            var arrCodeTypeCache = clsCodeTypeBL.GetObjLstCache();
            string strCodeTypeENName = "CommFun4BL";
            string strProgLangTypeId = enumProgLangType.CSharp_01;
            clsCodeTypeEN objCodeType_CommFun4BL = arrCodeTypeCache.Find(x => x.ProgLangTypeId == strProgLangTypeId
            && x.CodeTypeENName == strCodeTypeENName);
            this.objPrjTabENEx = objPrjTabENEx;

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

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                         clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(strCmPrjId),
                         objPrjTabENEx.LangType, objCodeType_CommFun4BL.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);
            if (arrvFunction4GeneCodeObjLst.Count() == 0)
            {
                string strMsg = string.Format("����:{4}({5}), ��������:{0}, ��������:{1}, Sql���ͣ�{2}({3})==>û�п������ɵĺ���4GC!",
                    objPrjTabENEx.LangType, clsCodeTypeBL.GetNameByCodeTypeIdCache(objCodeType_CommFun4BL.CodeTypeId),
                    clsSQLDSTypeBL.GetNameBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId), objPrjTabENEx.SqlDsTypeId,
                    objPrjTabENEx.TabName, objPrjTabENEx.TabId);
                return strMsg;
            }
            objPrjTabENEx.ClsName = string.Format("clsCommFun4BL4{0}", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";

            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
               
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommFun4BL", objPrjTabENEx.ClsName);
                }
                else if (objPrjTabENEx.objCacheClassifyFld2 == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommFun4BLV2", objPrjTabENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommFun4BLV3", objPrjTabENEx.ClsName);
                }
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                //�������еĺ���
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


        ///// <summary>
        ///// ����ָ���ĺ���
        ///// </summary>
        ///// <returns>�������ɵ�ָ����������</returns>
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

      


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(CommFun4BL4CSharp);
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
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
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
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public override void ReFreshCache()");
            }
            else if (objPrjTabENEx.objCacheClassifyFld2 == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public override void ReFreshCache({0} {1})",
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }  
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public override void ReFreshCache({0} {1},{2} {3})",
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }
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
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache();",
                    objPrjTabENEx.TabName);
            }
            else if (objPrjTabENEx.objCacheClassifyFld2 == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache({1});",
                    objPrjTabENEx.TabName,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
                else
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache({1}, {2});",
                    objPrjTabENEx.TabName,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }

            //string strTabId = cboPrjTab.SelectedValue.ToString();
            //arrPrjTabObjLst = clsPrjTabBLEx.GetPrjTabObjLstByPrjIdCacheEx(strPrjId);
            //int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            if (objPrjTabENEx.IsRefresh4RelaView == true)
            {
                List<string> arrTabId = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                foreach (string strRelaTabId in arrTabId)
                {
                    if (clsCMProjectPrjTabBLEx.IsExistRecord(this.CmPrjId, strRelaTabId) == false) continue;

                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                    if (objPrjTab.TabStateId != "01") continue;
                    //string strMsg = string.Format("{0}({1}) ",
                    //    objPrjTab.TabName, objPrjTab.TabId);
                    //listBox1.Items.Add(strMsg);
                    if (objPrjTab.IsUseCache == false) continue;
                    if (string.IsNullOrEmpty( objPrjTab.CacheClassifyField) == true || objPrjTabENEx.objCacheClassifyFld == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache();",
                            objPrjTab.TabName);
                    }
                    else if (string.IsNullOrEmpty( objPrjTab.CacheClassifyField2) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache({1});",
                            objPrjTab.TabName,
                            objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache({1}, {2});",
                            objPrjTab.TabName,
                            objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                            objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
                    }

                }
            }
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
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

        public override void GetClsName()
        {
            this.ClsName = string.Format("clsCommFun4BL4{0}", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }


    }
}
