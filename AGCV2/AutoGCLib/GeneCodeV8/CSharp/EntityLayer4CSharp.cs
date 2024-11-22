using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
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
    class EntityLayer4CSharp : clsGeneCodeBase
    {


        #region ���캯��

        public EntityLayer4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public EntityLayer4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


        /// <summary>
        /// ����Entity�����
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

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                         clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                         objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN";

            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ


                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data; "); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using System.Runtime.Serialization;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Entity",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");



                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// ��{0}�Ĺؼ���({1})�����Ͷ���. �Ա��������Լ���������.", objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public class K_{0}_{1}",
                    objKeyField.FldName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "private {0} _value = {1};", objKeyField.CsType,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId()));
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �ؼ������������ֵ");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public {0} Value {{ get {{ return _value; }}set {{ _value = value;}} }}",
                    objKeyField.CsType);
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �ؼ������͹��캯��");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "public K_{0}_{1}({2} {3})",
                    objKeyField.FldName, objPrjTabENEx.TabName,
                    objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (IsValid({0})) Value = {0};",
                    objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");

                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "Value = 0;");
                }
                else
                {
                    if (objKeyField.CsType == "bool")
                    {
                        strCodeForCs.Append("\r\n" + "Value = false;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "Value = null;");
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "private static bool IsValid({0} {1})",
                    objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.CsType != "bool")
                {
                    if (objKeyField.IsTabNullable == false)
                    {
                        if (objKeyField.IsNumberType() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return false;", objKeyField.PrivFuncName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return false;", objKeyField.PrivFuncName);
                        }
                    }
                    if (objKeyField.IsNumberType() == false)
                    {
                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length != {1}) return false;",
                                objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1}) return false;",
                                objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.IndexOf(' ') >= 0) return false;",
                                objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.IndexOf(')') >= 0) return false;",
                                objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.IndexOf('(') >= 0) return false;",
                                objKeyField.PrivFuncName);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return false;",
                            objKeyField.PrivFuncName);
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ʵ����ʽ����ת��,������:[{0}]��ʽת����:[{1}]");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"value\">ԭ���ͱ�ؼ���</param>");
                strCodeForCs.AppendFormat("\r\n /// <returns>����:[K_{0}_{1}]���͵Ķ���</returns>", objKeyField.FldName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "public static implicit operator K_{0}_{1}({2} value)", objKeyField.FldName, objPrjTabENEx.TabName, objKeyField.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return new K_{0}_{1}(value);", objKeyField.FldName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n /// <summary>");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),ר�����SilverLight��ʵ����", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.Append("\r\n" + "[Serializable]");
                strCodeForCs.Append("\r\n" + "[DataContractAttribute]");
                //}
                if (string.IsNullOrEmpty(objPrjTabENEx.ParentClass) == true)
                {
                    strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName + " : clsEntityBase2");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : {1}",
                          objPrjTabENEx.ClsName,
                         objPrjTabENEx.ParentClass);
                }
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n" + "public static List<string> _RefreshTimeLst = new List<string>();");

                strCodeForCs.Append("\r\n" + "public static string _ConnectString = \"\"; //��ǰ����,��ʹ�õ�����,���Ϊ�վ�ʹ��ϵͳĬ�ϵ�����");
                strCodeForCs.Append("\r\n" + "public new const string _CurrTabName = \"" + objPrjTabENEx.TabName + "\"; //��ǰ����,�������صı���");
                strCodeForCs.Append("\r\n" + "public const string _CurrTabKeyFldName = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //��ǰ���еĹؼ�������,�������صı��йؼ�����");
                strCodeForCs.AppendFormat("\r\n" + "public const string _{0} = \"{1}\"; //{2}",
                                       conPrjTab.WhereFormatBack, objPrjTabENEx.WhereFormatBack, "��̨������ʽ��");

                strCodeForCs.AppendFormat("\r\n" + "public const string _{0} = \"{1}\"; //{2}",
                                  conPrjTab.WhereFormat, objPrjTabENEx.WhereFormat, "ǰ̨������ʽ��");

                //������������صĳ�������
                //if (objPrjTabENEx.I1sNeedGeneIndexer == true)
                //{
                //������������صĴ���
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                    objPrjTabENEx.arrFldSet.Count);
                strTemp = "{";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "{")
                    {
                        strTemp += "\"" + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + "\"";
                    }
                }
                strTemp += "}";
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                strTemp);
                //}


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



                string strConstCode = new TableFldConst4CSharp().GeneCode_This(objPrjTabENEx, this.CmPrjId);
                strCodeForCs.AppendLine(strConstCode);

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
        /// Ϊ�ֶ����������ֶ�ֵ
        /// </summary>
        /// <returns></returns>
        public override string GenSetCondFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();


            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strFldValue\">�ֶ�����ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">�Ƚ������</param>");
            strBuilder.Append("\r\n /// <returns>void</returns>");
            strBuilder.Append("\r\npublic void SetCondFldValue(string strFldName, string strFldValue, string strComparisonOp)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "this[strFldName] = strFldValue;");
            strBuilder.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(strFldName) == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp.Add(strFldName, strComparisonOp);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp[strFldName] = strComparisonOp;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ����Entity�����
        /// </summary>
        /// <returns></returns>
        public override string A_GenEntityLayerCode_Sim(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN_Sim";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);


            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data; "); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                                                                            //strCodeForCs.Append("\r\n" + ""); //
                                                                            //strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                                                                            //strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                                                                            //strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.Runtime.Serialization;");
                strCodeForCs.Append("\r\n" + "using System.Runtime.Serialization.Json;");
                strCodeForCs.Append("\r\n" + "using System.ServiceModel;");
                strCodeForCs.Append("\r\n" + "using System.ServiceModel.Web;");

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Entity",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),ר�����SilverLight��ʵ����", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.Append("\r\n" + "[Serializable]");
                strCodeForCs.Append("\r\n" + "[DataContractAttribute]");
                //}
                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName + " ");
                strCodeForCs.Append("\r\n" + "{");

                //������������صĳ�������

                //������������صĴ���
                //strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                //objPrjTabENEx.arrFldSet.Count);
                //strTemp = "{";
                //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                //{
                //  if (strTemp == "{")
                //  {
                //    strTemp += "\"" + objField.ObjFieldTabENEx.FldName + "\"";
                //  }
                //  else
                //  {
                //    strTemp += ", \"" + objField.ObjFieldTabENEx.FldName + "\"";
                //  }
                //}
                //strTemp += "}";
                //strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                //strTemp);

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


        ///// <summary>
        ///// ����DAL(���ݴ����)����
        ///// </summary>
        ///// <returns></returns>
        //public override string A_GenDALExCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strFuncName = "";
        //    string strResult = "";
        //    clsErrorIdManageBLEx.arrErrIdLstCache = null;
        //    if (objPrjTabENEx.TabFldNum() == 0)
        //    {
        //        strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
        //              objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum() == 0)
        //    {
        //        strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
        //              objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    //���û���������;
        //    //string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; ///��ʱ����;            

        //    IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
        //        clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
        //        objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
        //        .OrderBy(x => x.OrderNum);

        //    objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DAEx";
        //    //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

        //    objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
        //    strRe_ClsName = objPrjTabENEx.ClsName;
        //    clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
        //    strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

        //    strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
        //    objPrjTabENEx.FileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

        //    try
        //    {
        //        //������ʼ

        //        strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
        //        objProject.PrjDomain); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
        //        objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.AppendFormat("\r\n" + "public class  {0} : cls{1}DA", 
        //            objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "{");


        //        strCodeForCs.Append("\r\n" + "//���������Ա���");



        //        //�������еĺ���

        //        foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
        //        {
        //            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
        //            strFuncName = objvFunction4GeneCodeEN.FuncName;
        //            if (strFuncName.Substring(0, 6) == "Print:")
        //            {
        //                strCodeForCs.Append("\r\n" + "");
        //                strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
        //                continue;
        //            }

        //            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
        //            if (string.IsNullOrEmpty(strTemp) == false)
        //            {
        //                strCodeForCs.Append("\r\n" + strTemp);
        //            }

        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");


        //    }
        //    catch (Exception ex)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

        //        clsEntityBase.LogErrorS(ex, strMsg);
        //        throw new Exception(strMsg);



        //    }
        //    return strCodeForCs.ToString();
        //}



        public string A_GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
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
            ArrayList arrFieldCodes = new ArrayList();

            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

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
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }
        public override string Gen_GetSpecSQLObj()
        {
            //return "";
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
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
            ///ɾ����¼ == = ;
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
                Type t = typeof(EntityLayer4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, newobject[] { "1234567890123"    });
                    strCode = (string)mt.Invoke(this, null);
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
            this.ClsName = string.Format("cls{0}EN", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string GenClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToString2(objField, objPrjTabENEx.LangType, false);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }
            }

            return strBuilder.ToString();
        }
    }
}
