using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AGC.PureClassEx;

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
    partial class WA_AccessEx4TypeScript : clsGeneCodeBase, IImportClass
    {

        //private new string objViewInfoENEx = "";
        #region ���캯��

        public WA_AccessEx4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();

        }
        public WA_AccessEx4TypeScript(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();

        }
        public WA_AccessEx4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();

        }
        #endregion
        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WAEx_Ts_CopyToExBak()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                //return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ��������չ����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENT:Ŀ�����", ThisTabName4GC);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\npublic static " + this.tabNameHeadEx + "CopyToEx(obj{0}ENS: cls{0}EN  ): cls{0}ENEx ", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.AppendFormat("\r\n const obj{0}ENT: cls{0}ENEx = new cls{0}ENEx();", ThisTabName4GC);


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      ThisTabName4GC, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    ThisTabName4GC, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sfUpdFldSetStr = obj{0}ENS.UpdFldString; //ר�����ڼ�¼ĳ�ֶ������Ƿ��޸�",
                ThisTabName4GC);
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sfFldComparisonOp = obj{0}ENS.sfFldComparisonOp; //ר�����ڼ�¼��������ĳ�ֶεıȽ������",
                ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "return obj{0}ENT; ",
                ThisTabName4GC);

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WAEx_Ts_CopyToEx()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHeadEx + "CopyToEx(obj{0}ENS:cls{0}EN ): cls{0}ENEx", ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "��ͬһ����Ķ���,���Ƶ���һ������.";

            //if (bolIsUseFunc4Detail == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n * @returns Ŀ�����=>cls{0}EN:obj{0}ENT", ThisTabName4GC);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHeadEx + "CopyToEx(obj{0}ENS:cls{0}EN ): cls{0}ENEx", ThisTabName4GC);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName  = " + this.tabNameHeadEx + "CopyToEx.name;");
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT = new cls{0}ENEx();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENT, obj{0}ENS);", ThisTabName4GC);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "ObjectAssign", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyToEx_Static", "Copy��Ex�������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})Copy��������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, " + this.constructorNameEx + ", strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WAEx_Ts_ClassConstructor()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ���캯��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            //            strCodeForCs.Append("\r\n super();");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                     ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                        ThisTabName4GC, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = "cls" + ThisTabName4GC + "ExWApi";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {


                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = null;

                //������-������صĺ���
                arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst;
                int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

                arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_All)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;


                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    objvFunction4GeneCodeEN.CodeText = strTemp;
                }

                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4TypeScript(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}({1})", objPrjTabENEx.TabCnName, ThisTabName4GC);

                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ����,������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + " **/");
                GetImportClassLst(objFuncModule);

                //arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                //strCodeForCs.Append("\r\n" + "//import $ from \"jquery\";");

                if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
                {
                    foreach (var objInFor in arrImportClass)
                    {
                        objInFor.ClsName = objInFor.ClsName;
                        objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                  .Replace("../../TS/", "@/ts/")
                  .Replace("../TS/", "@/ts/")
.Replace("../../PubFun", "@/ts/PubFun")
.Replace("../../PubConfig", "@/ts/PubConfig")
.Replace("../../L0Entity", "@/ts/L0Entity")
.Replace("../../L3ForWApi", "@/ts/L3ForWApi")
.Replace("../PubFun", "@/ts/PubFun")
.Replace("../PubConfig", "@/ts/PubConfig")
.Replace("../L0Entity", "@/ts/L0Entity")
                    .Replace("../L3ForWApi", "@/ts/L3ForWApi");
                    }
                }
                var arrImportClass_RemoveDup = clsPubFun4GC.ImportClass_RemoveDup(arrImportClass);

                StringBuilder sbImport = new StringBuilder();
                foreach (var objInFor in arrImportClass_RemoveDup)
                {
                    sbImport.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath);
                }

                strCodeForCs.AppendLine(sbImport.ToString());

                //foreach (var objInFor in arrImportClass_RemoveDup)
                //{
                //    if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
                //    {
                //        var strFilePath = objInFor.FilePath.Replace(".js", "")
                //            .Replace("../../L0Entity", "@/ts/L0Entity")
                //            .Replace("../../L3ForWApi", "@/ts/L3ForWApi")
                //            .Replace("../../PubFun", "@/ts/PubFun")
                //            .Replace("../../PubConfig", "@/ts/PubConfig");

                //        strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                //          objInFor.ClsName,
                //            strFilePath);
                //    }
                //    else
                //    {
                //        strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                //          objInFor.ClsName,
                //            objInFor.FilePath);
                //    }
                //}

                //strCodeForCs.AppendFormat("\r\n" + "export class  cls{0}ExWApi ",
                //  ThisTabName4GC);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "export const " + this.controllerNameEx + " = \"{0}ExApi\";",
                    ThisTabName4GC);
                strCodeForCs.AppendFormat("\r\n" + "export const " + this.constructorNameEx + " = \"{0}Ex\";",
                   clsString.FstLcaseS(ThisTabName4GC));

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_All)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }
                //�����û��Զ���ĺ���
                string strCode = clsFunction4CodeBLEx.GeneCode4Class(objPrjTabENEx.ClsName, objPrjTabENEx.CodeTypeId, objPrjTabENEx.PrjId);
                strCodeForCs.Append("\r\n" + strCode);

                //strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4WAEx_Ts_GetWebApiUrl()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHeadEx + "GetWebApiUrl(strController: string, strAction: string): string ",
           "");

            Re_objFunction4Code.FuncCHName4Code = "��ȡWebApi�ĵ�ַ.";

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ȡWebApi�ĵ�ַ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ���ص�ǰ�ļ���Web����ĵ�ַ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "export  function " + this.tabNameHeadEx + "GetWebApiUrl(strController: string, strAction: string): string {");
            //strCodeForCs.Append("\r\n" + "const strThisFuncName = \"GetWebApiUrl\";");

            strCodeForCs.Append("\r\n" + "let strServiceUrl:string;");
            strCodeForCs.Append("\r\n" + "let strCurrIPAddressAndPort = \"\";");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort_Local;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(clsSysPara4WebApi.CurrPrx) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = Format(\"{0}/{1}/{2}\", strCurrIPAddressAndPort, strController, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = Format(\"{0}/{1}/{2}/{3}\", strCurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");


            //��ȡĳһ����ֵ�ļ�¼�� == = ;
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
                string strTemp_ImportClass = GeneCode_ImportClass();
                if (string.IsNullOrEmpty(strTemp_ImportClass) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp_ImportClass);
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



        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}WApi", ThisTabName4GC);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_AccessEx4TypeScript);
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
                    Re_objFunction4Code.FuncName4Code = this.Re_objFunction4Code.FuncName4Code;
                    Re_objFunction4Code.FuncCHName4Code = this.Re_objFunction4Code.FuncCHName4Code;

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
        public string Gen_4WAEx_Ts_GetObjExLstByPagerCache()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerCache)}(objPagerPara: stuPagerPara):Promise<Array<cls{ThisTabName4GC}ENEx>> ";
            Re_objFunction4Code.FuncCHName4Code = "���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ";

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjExLstByPagerCache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param objPagerPara:��ҳ�����ṹ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б�");
            strCodeForCs.AppendFormat("\r\n*/");

            var strCache_ParaVarDefLstStr = clsPrjTabBLEx.Cache_ParaVarDefLstStr(objPrjTabENEx, "TypeScript");
            if (string.IsNullOrEmpty(strCache_ParaVarDefLstStr) == false)
            {
                strCache_ParaVarDefLstStr = ", " + strCache_ParaVarDefLstStr;
            }

            strCodeForCs.Append("\r\n" + $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerCache)}(objPagerPara: stuPagerPara {strCache_ParaVarDefLstStr}):Promise<Array<cls{ThisTabName4GC}ENEx>> {{");

            Re_objFunction4Code.FuncName4Code
                = $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerCache)}(objPagerPara: stuPagerPara {strCache_ParaVarDefLstStr}) :Promise<Array<cls{ThisTabName4GC}ENEx>>";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjLstByPagerCache\";");

            var strCache_ParaVarLstStr = clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript");

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWA_F(WA_F.GetObjLst_Cache)}({strCache_ParaVarLstStr});");
            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("GetObjLstCache", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/stuPagerPara.js", "stuPagerPara", enumImportObjType.CustomFunc, this.strBaseUrl);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ExObjLst = arr{0}ObjLst.map({1}CopyToEx);", ThisTabName4GC, this.tabNameHeadEx);

            strCodeForCs.Append("\r\n" + " const objSortInfo = GetSortExpressInfo(objPagerPara);");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "GetSortExpressInfo", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + $" if (IsNullOrEmpty(objSortInfo.SortFld) == false && cls{ThisTabName4GC}EN.AttributeName.indexOf(objSortInfo.SortFld) == -1)");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + " {");

            strCodeForCs.AppendFormat("\r\n" + " for (const objInFor of arr{0}ExObjLst) {{", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + $"await {thisWAEx_F(WA_F.FuncMapByFldName)}(objSortInfo.SortFld, objInFor);");

            //AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC+"Ex", string.Format("FuncMap", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0) return arr{0}ExObjLst;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel: Array < cls{0}ENEx > = arr{0}ExObjLst;", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const objCond = JSON.parse(objPagerPara.whereCond);", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}Cond, objCond);", ThisTabName4GC);
            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENClassInWApi, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "let dicFldComparisonOp: { [index: string]: string } = {};");
            strCodeForCs.Append("\r\n" + "if (objCond.sfFldComparisonOp != \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "dicFldComparisonOp = JSON.parse(objCond.sfFldComparisonOp);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetObjLstByPagerCache->dicFldComparisonOp:\");", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.Append("\r\n" + "const sstrKeys = GetObjKeys(objCond);");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "GetObjKeys", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) != null);", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}Cond.GetFldValue(strKey);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not greater\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length not less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length less\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"length equal\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"in\") {");
            //else if (strComparisonOp == "in")
            //{
            //    const arrValues = strValue.split(',');
            //    console.error(arrValues);
            //    arrUserCodePath_Sel = arrUserCodePath_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
            //}
            strCodeForCs.Append("\r\n" + "const arrValues = strValue.split(',');");
            //strCodeForCs.Append("\r\n" + "console.error(arrValues);");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) == strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) >= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) > strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.filter(x => x.GetFldValue(strKey) <= strValue);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Sel.length == 0) return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);");
            strCodeForCs.Append("\r\n" + "if (intStart <= 0) intStart = 0;");

            strCodeForCs.Append("\r\n" + "const intEnd = intStart + objPagerPara.pageSize;");


            strCodeForCs.Append("\r\n" + "if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {");
            strCodeForCs.Append("\r\n" + "const sstrSplit: string[] = objPagerPara.orderBy.split(\" \");");
            strCodeForCs.Append("\r\n" + "let strSortType = \"asc\";");
            strCodeForCs.Append("\r\n" + "const strSortFld = sstrSplit[0];");
            strCodeForCs.Append("\r\n" + "if (sstrSplit.length > 1) strSortType = sstrSplit[1];");
            strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}Sel = arr{ThisTabName4GC}Sel.sort({thisWAEx_F(WA_F.SortFunByKey)}(strSortFld, strSortType));");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + "//��������ֶ���[OrderBy]Ϊ��,�͵���������");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.sort(objPagerPara.sortFun);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.slice(intStart, intEnd);     ", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����:[{0}]. \\n��������:[{1}]��ȡ��ҳ�����б��ɹ�!(In {2}.{3})\", e, objPagerPara.whereCond, " + this.constructorNameEx + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return new Array<cls{0}ENEx>();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WAEx_Ts_GetObjExLstByPagerAsync()
        {
            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara: stuPagerPara):Promise<Array<cls{ThisTabName4GC}ENEx>>";

            Re_objFunction4Code.FuncCHName4Code = "���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���ݷ�ҳ�����ӻ����л�ȡ��ҳ�����б�,ֻ��ȡһҳ.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param objPagerPara:��ҳ�����ṹ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б�");
            strCodeForCs.AppendFormat("\r\n*/");


            strCodeForCs.Append("\r\n" + $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara: stuPagerPara):Promise<Array<cls{ThisTabName4GC}ENEx>> {{");

            Re_objFunction4Code.FuncName4Code = $"export  async function {thisWAEx_F(WA_F.GetObjExLstByPagerAsync)}(objPagerPara: stuPagerPara) :Promise<Array<cls{ThisTabName4GC}ENEx>>";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetObjExLstByPagerAsync\";", ThisTabName4GC,
            objKeyField.FldName);

            var strCache_ParaVarLstStr = clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript");

            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWA_F(WA_F.GetObjLstByPagerAsync)}(objPagerPara);");

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ExObjLst = arr{0}ObjLst.map({1}CopyToEx);", ThisTabName4GC, this.tabNameHeadEx);

            //strCodeForCs.Append("\r\n" + " const objSortInfo = GetSortExpressInfo(objPagerPara);");
            //AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsCommFunc4Web.js", "GetSortExpressInfo", enumImportObjType.CustomFunc, this.strBaseUrl);

            //strCodeForCs.Append("\r\n" + $" if (IsNullOrEmpty(objSortInfo.SortFld) == false && cls{ThisTabName4GC}EN.AttributeName.indexOf(objSortInfo.SortFld) == -1)");
            //AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, this.strBaseUrl);

            //strCodeForCs.Append("\r\n" + " {");

            //strCodeForCs.AppendFormat("\r\n" + " for (const objInFor of arr{0}ExObjLst) {{", ThisTabName4GC);
            //strCodeForCs.Append("\r\n" + $"await {thisWAEx_F(WA_F.FuncMapByFldName)}(objSortInfo.SortFld, objInFor);");

            ////AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC+"Ex", string.Format("FuncMap", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
            //strCodeForCs.Append("\r\n" + " }");

            //strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0) return arr{0}ExObjLst;", ThisTabName4GC);

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}Sel: Array < cls{0}ENEx > = arr{0}ExObjLst;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {");
            strCodeForCs.Append("\r\n" + "const sstrSplit: string[] = objPagerPara.orderBy.split(\" \");");
            strCodeForCs.Append("\r\n" + "let strSortType = \"asc\";");
            strCodeForCs.Append("\r\n" + "const strSortFld = sstrSplit[0];");
            strCodeForCs.Append("\r\n" + "if (sstrSplit.length > 1) strSortType = sstrSplit[1];");
            strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}Sel = arr{ThisTabName4GC}Sel.sort({thisWAEx_F(WA_F.SortFunByKey)}(strSortFld, strSortType));");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + "//��������ֶ���[OrderBy]Ϊ��,�͵���������");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}Sel = arr{0}Sel.sort(objPagerPara.sortFun);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
                        
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}Sel;", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����:[{0}]. \\n��������:[{1}]��ȡ��ҳ�����б��ɹ�!(In {2}.{3})\", e, objPagerPara.whereCond, " + this.constructorNameEx + ", strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return new Array<cls{0}ENEx>();", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WAEx_Ts_GetObjExLstByFuncMap()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHeadEx + "GetObjExLstByFuncMap(arr{0}ObjLst: Array<cls{0}EN>):Promise<Array<cls{0}ENEx>>  {{",
                  ThisTabName4GC,
          objKeyField.FldName,
          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
            Re_objFunction4Code.FuncCHName4Code = "ͨ������ӳ��Ѷ����б�ת��Ϊ��չ�����б�";


            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ͨ������ӳ��Ѷ����б�ת��Ϊ��չ�����б�.");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param objPagerPara:��ҳ�����ṹ", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n * @returns �����б�");
            strCodeForCs.AppendFormat("\r\n*/");


            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "GetObjExLstByFuncMap(arr{0}ObjLst: Array<cls{0}EN>):Promise<Array<cls{0}ENEx>> {{",
              ThisTabName4GC);

            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHeadEx + "GetObjExLstByFuncMap(arr{0}ObjLst: Array<cls{0}EN>) :Promise<Array<cls{0}ENEx>>{{",
                ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = " + this.tabNameHeadEx + "GetObjExLstByFuncMap.name;", ThisTabName4GC,
            objKeyField.FldName);

            var strCache_ParaVarLstStr = clsPrjTabBLEx.Cache_ParaVarLstStr(objPrjTabENEx, "TypeScript");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array < cls{0}ENEx > = [];", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + " for (const objInFor of arr{0}ObjLst) {{", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + " const objEx = " + this.tabNameHeadEx + "CopyToEx(objInFor);");
            strCodeForCs.AppendFormat("\r\n" + " arr{0}ExObjLst.push(objEx);", ThisTabName4GC);
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.AppendFormat("\r\n" + " for (const objInFor of arr{0}ExObjLst) {{", ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "await {0}ExFuncMap(objInFor);", ThisTabName4GC);
            //AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("FuncMap", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.AppendFormat("\r\n" + " return arr{0}ExObjLst;", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WAEx_Ts_FuncMapBak()
        {
            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            List<clsDGRegionFldsEN> arrDGRegionFld_Sel = clsDGRegionFldsBLEx.GetObjLstByTabIdCache(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            var arrDGRegionFldEx_Sel = arrDGRegionFld_Sel.Select(clsDGRegionFldsBLEx.CopyToEx);
            List<string> arrDataPropertyName = new List<string>();
            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsDGRegionFldsENEx objDGRegionFlds in arrDGRegionFldEx_Sel)
            {
                if (string.IsNullOrEmpty(objDGRegionFlds.OutFldId) == true) continue;
                string strDataPropertyName = objDGRegionFlds.DataPropertyName_FstLcase(this.IsFstLcase);
                if (arrDataPropertyName.Contains(strDataPropertyName) == true) continue;

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFlds.FldId, objDGRegionFlds.PrjId);


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * ��һ����չ��Ĳ������Խ��к���ת��");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", ThisTabName4GC);
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "FuncMap{0}(obj{1}:cls{1}ENEx )", objFieldTab.FldName, ThisTabName4GC);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = " + this.tabNameHeadEx + "FuncMap{0}.name;", objFieldTab.FldName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                arrDataPropertyName.Add(strDataPropertyName);

                strCodeForCs.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(objPrjTabENEx.TabId, objDGRegionFlds.FldId, 1, objPrjTabENEx.PrjId);
                if (objDataNode_Curr == null)
                {

                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabENEx.TabId, objDGRegionFlds.PrjId);

                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);
                    string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{7} ����Ӧ�Ľ�㲻���ڡ� VersionNo=1, CmPrjId={2}({5}),����!(In {6})",
                        objPrjTabENEx.TabId,
                        objDGRegionFlds.FldId, this.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName, clsStackTrace.GetCurrClassFunction(), objDGRegionFlds.DataPropertyName());
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDGRegionFlds.OutDataNodeId, objPrjTabENEx.PrjId);
                string strLastVarName = "";
                string strOutFldId = objDGRegionFlds.OutFldId;
                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabIdCache(objPrjTabENEx.TabId);
                List<clsDnFuncMapEN> arrPath = null;
                try
                {
                    clsDGRegionFldsBLEx.CheckOutFldId(objDGRegionFlds, this.IsFstLcase, this.CmPrjId, objPrjTabENEx.UserId);
                    var strOutDataNodeId = objDGRegionFlds.OutDataNodeId();
                    arrPath = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, strOutDataNodeId, objPrjTabENEx.PrjId);
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabENEx.TabId, objDGRegionFlds.PrjId);
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);
                    string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ,����:{7}�� VersionNo=1, CmPrjId={2}({5}),����!(In {6})",
                        objPrjTabENEx.TabId,
                        objDGRegionFlds.FldId, this.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message, objDGRegionFlds.DataPropertyName());
                    throw new Exception(strMsg);
                }
                List<string> arrConstVar = new List<string>();
                foreach (var objInFor in arrPath)
                {
                    string strIsToString = "";
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}.{1}", ThisTabName4GC, objCacheClassifyField.PropertyName(this.IsFstLcase));
                            }
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                            {
                                var objCacheClassifyField2 = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

                                strCacheClassifyField += string.Format(", obj{0}.{1}", ThisTabName4GC, objCacheClassifyField2.PropertyName(this.IsFstLcase));
                            }

                            if (arrPath.Count == 1)
                            {
                                if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                {
                                    if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName4GC(),
                                        ThisTabName4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                        arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                                    }
                                }
                            }

                            //if (objFieldTab_Start.IsNumberType() == true)
                            //{
                            //    strIsToString = ".toString()";
                            //}
                            if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                            {
                                strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_Start.DataNodeName4GC(),
                                         ThisTabName4GC,
                                         objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});",
                                objDataNode_End.DataNodeName4GC(),
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName4GC(),
                                strCacheClassifyField);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);


                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                            if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            {
                                arrTabId4MapFunc.Add(objPrjTab.TabId);
                            }
                            strLastVarName = objDataNode_End.DataNodeName4GC();
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objPrjTabENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName4GC(),
                                            ThisTabName4GC,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName4GC(), objDataNode_Start.DataNodeName4GC());
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName4GC(),
                                            ThisTabName4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName4GC(),
                                        objDataNode_Start.DataNodeName4GC());
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName4GC(),
                                            ThisTabName4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase),
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName4GC(),
                                        objDataNode_Start.DataNodeName4GC(),
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    //AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                    ThisTabName4GC,
                                    objDGRegionFlds.DataPropertyName_FstLcase(this.IsFstLcase),
                                    strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("FuncMap{0}", objFieldTab.FldName), "����ӳ���:{0} �������ݳ���!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ���������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, " + this.constructorNameEx + ", strThisFuncName);", strErrId);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n}");


            }

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WAEx_Ts_FuncMap()
        {
            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            List<clsPrjTabFldEN> arrPrjTabFld_Sel = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            arrPrjTabFld_Sel = arrPrjTabFld_Sel.Where(x => x.IsForExtendClass == true).ToList();
            List<string> arrDataPropertyName = new List<string>();
            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFld_Sel)
            {
                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == true && objPrjTabFld.FieldTypeId != enumFieldType.DisplayUnit_20) continue;
                string strDataPropertyName = objPrjTabFld.DataPropertyName_FstLcase(this.IsFstLcase);
                if (arrDataPropertyName.Contains(strDataPropertyName) == true) continue;

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);

                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == false)
                {
                    var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFld.DnPathId, objPrjTabENEx.PrjId);
                    if (objDnPath == null) continue;
                    if (objDnPath.PrjId != objPrjTabFld.PrjId)
                    {
                        string strMsg = string.Format("�ڱ�:[{0}]��,��չ�ֶ�:[{1}]�����õ�·������ȷ!", ThisTabName4GC, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }
                    strCodeForCs.Append("\r\n /**");
                    strCodeForCs.Append("\r\n * ��һ����չ��Ĳ������Խ��к���ת��");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", ThisTabName4GC);
                    strCodeForCs.Append("\r\n **/");
                    strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "FuncMap{0}(obj{1}:cls{1}ENEx )", objFieldTab.FldName, ThisTabName4GC);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = " + this.tabNameHeadEx + "FuncMap{0}.name;", objFieldTab.FldName);
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    arrDataPropertyName.Add(strDataPropertyName);
                    if (objFieldTab.IsNumberType())
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}.{1} == 0){{",
                                             ThisTabName4GC,
                                             objFieldTab.PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        if (objFieldTab.ObjDataTypeAbbr1().TypeScriptType != "boolean")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}.{1}) == true){{",
                                                ThisTabName4GC,
                                                objFieldTab.PropertyName(this.IsFstLcase));
                        }
                    }

                    string strLastVarName = "";
                    long strOutDataNodeId = objDnPath.OutDataNodeId;
                    List<clsDnFuncMapEN> arrPath = null;
                    try
                    {
                        arrPath = clsDnFuncMapBLEx.GetObjLstByDnPath(objDnPath, objPrjTabENEx.PrjId);
                    }
                    catch (Exception objException)
                    {
                        var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabENEx.TabId, objPrjTabFld.PrjId);
                        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);
                        string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ,����:{7}�� VersionNo=1, CmPrjId={2}({5}),����!(In {6})",
                            objPrjTabENEx.TabId,
                            objPrjTabFld.FldId, this.CmPrjId,
                            objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                            clsStackTrace.GetCurrClassFunction(), objException.Message, objPrjTabFld.DataPropertyName_FstLcase(this.IsFstLcase));
                        throw new Exception(strMsg);
                    }
                    List<string> arrConstVar = new List<string>();
                    foreach (var objInFor in arrPath)
                    {
                        if (objInFor == null) continue;
                        string strIsToString = "";
                        var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                        var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                        var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                        var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                        switch (objInFor.FuncMapModeId)
                        {
                            case enumFuncMapMode.Table_01:
                                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                string strCacheClassifyField = "";
                                if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                                {
                                    var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

                                    strCacheClassifyField = string.Format(", obj{0}.{1}", ThisTabName4GC, objCacheClassifyField.PropertyName(this.IsFstLcase));
                                }
                                if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                                {
                                    var objCacheClassifyField2 = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

                                    strCacheClassifyField += string.Format(", obj{0}.{1}", ThisTabName4GC, objCacheClassifyField2.PropertyName(this.IsFstLcase));
                                }

                                if (arrPath.Count == 1)
                                {
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName4GC(),
                                            ThisTabName4GC,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase));
                                            arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                                        }
                                    }

                                }

                                if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                {
                                    strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_Start.DataNodeName4GC(),
                                             ThisTabName4GC,
                                             objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                    arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                                }
                                strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});",
                                    objDataNode_End.DataNodeName4GC(),
                                    objPrjTab.TabName,
                                    objFieldTab_Start.FldName,
                                    objFieldTab_End.FldName,
                                    objDataNode_Start.DataNodeName4GC(),
                                    strCacheClassifyField);
                                AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
                                AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);


                                arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                                {
                                    arrTabId4MapFunc.Add(objPrjTab.TabId);
                                }
                                strLastVarName = objDataNode_End.DataNodeName4GC();
                                break;
                            case enumFuncMapMode.Function_02:
                                var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objPrjTabENEx.PrjId);
                                if (objDNFun == null)
                                {
                                    string strMsg = string.Format("DnFunction����Id:[{0}]�Ľ�㲻����!", objInFor.DnFunctionId);
                                    throw new Exception(strMsg);
                                }
                                switch (objDNFun.DnFunctionName)
                                {
                                    case "equal":

                                        if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                        {
                                            if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                            {
                                                //if (objFieldTab_Start.IsNumberType() == true)
                                                //{
                                                //    strIsToString = ".toString()";
                                                //}

                                                strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName4GC(),
                                                ThisTabName4GC,
                                                objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                                arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                            }
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName4GC(), objDataNode_Start.DataNodeName4GC());
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                        strLastVarName = objDataNode_End.DataNodeName4GC();
                                        break;
                                    case "GetDateTime_Sim":
                                        //var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                        if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                         objDataNode_End.DataNodeName4GC(),
                                                ThisTabName4GC,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase));
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                            objDataNode_End.DataNodeName4GC(),
                                            objDataNode_Start.DataNodeName4GC());
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                        strLastVarName = objDataNode_End.DataNodeName4GC();
                                        break;
                                    default:
                                        //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                        if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                         objDataNode_End.DataNodeName4GC(),
                                                ThisTabName4GC,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase),
                                            objDNFun.DnFunctionName);
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                            objDataNode_End.DataNodeName4GC(),
                                            objDataNode_Start.DataNodeName4GC(),
                                            objDNFun.DnFunctionName);
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                        //AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                                        strLastVarName = objDataNode_End.DataNodeName4GC();
                                        break;
                                }
                                break;
                        }

                    }
                    strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                        ThisTabName4GC,
                                        objPrjTabFld.DataPropertyName_FstLcase(this.IsFstLcase),
                                        strLastVarName);
                    if (objFieldTab.ObjDataTypeAbbr1().TypeScriptType != "boolean")
                    {
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("FuncMap{0}", objFieldTab.FldName), "����ӳ���0:{0} �������ݳ���!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ���������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, " + this.constructorNameEx + ", strThisFuncName);", strErrId);
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n}");

                }
                else if (objPrjTabFld.FieldTypeId == enumFieldType.DisplayUnit_20 && string.IsNullOrEmpty(objPrjTabFld.FldDispUnitStyleId) == false)
                {
                    var objFldDispUnitStyle = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleIdCache(objPrjTabFld.FldDispUnitStyleId);
                    if (objFldDispUnitStyle == null)
                    {
                        string strMsg = string.Format("�ڱ�:[{0}]��,��չ�ֶ�(�ֶ���ʾ��Ԫ):[{1}]û��������Ӧ���ֶε�Ԫ��ʾ��ʽ!",
                            ThisTabName4GC, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }
                    var objFieldTab_Out = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);
                    if (objFieldTab_Out == null)
                    {
                        string strMsg = string.Format("�ڱ�:[{0}]��,��չ�ֶ�(�ֶ���ʾ��Ԫ):[{1}]�ڵ�ǰ�����в�����!",
                            ThisTabName4GC, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }
                    if (string.IsNullOrEmpty(objPrjTabFld.InFldId) == true)
                    {
                        string strMsg = string.Format("�ڱ�:[{0}]��,��չ�ֶ�(�ֶ���ʾ��Ԫ):[{1}]û��[�����ֶ�(InFldId)], ����!",
                            ThisTabName4GC, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }
                    var objFieldTab_In = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.InFldId, objPrjTabFld.PrjId);
                    if (objFieldTab_In == null)
                    {
                        string strMsg = string.Format("�ڱ�:[{0}]��,��չ�ֶ�(�ֶ���ʾ��Ԫ):[{1}]�ڵ�ǰ�����в�����!",
                            ThisTabName4GC, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }
                    var objPrjTabFld_In = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objPrjTabFld.TabId, objPrjTabFld.InFldId, objPrjTabFld.PrjId);

                    var objStyle_Content = clscss_StyleBL.GetObjByStyleIdCache(objFldDispUnitStyle.StyleIdContent);
                    var objStyle_Title = clscss_StyleBL.GetObjByStyleIdCache(objFldDispUnitStyle.StyleIdTitle);

                    strCodeForCs.Append("\r\n /**");
                    strCodeForCs.Append("\r\n * ��ʾһ���ֶεĵ�Ԫ��Ϣ");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", ThisTabName4GC);
                    strCodeForCs.Append("\r\n **/");
                    strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "FuncMap{0}(obj{1}:cls{1}ENEx )", objFieldTab.FldName, ThisTabName4GC);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = " + this.tabNameHeadEx + "FuncMap{0}.name;", objFieldTab.FldName);
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    arrDataPropertyName.Add(strDataPropertyName);
                    if (objFieldTab.IsNumberType())
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}.{1} == 0){{",
                                             ThisTabName4GC,
                                             objFieldTab.PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        if (objFieldTab.ObjDataTypeAbbr1().TypeScriptType != "boolean")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}.{1}) == true){{",
                                                ThisTabName4GC,
                                                objFieldTab.PropertyName(this.IsFstLcase));
                        }
                    }
                    if (objPrjTabFld_In != null && objPrjTabFld_In.IsForExtendClass == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}.{1}) == true){{",
                                            ThisTabName4GC,
                                            objFieldTab_In.PropertyName(this.IsFstLcase));
                        strCodeForCs.AppendFormat("\r\n" + "await {0}FuncMap{1}(obj{2});",
                             this.tabNameHeadEx, objFieldTab_In.FldName, ThisTabName4GC);
                        strCodeForCs.Append("\r\n" + "}");

                    }
                    switch (objPrjTabFld.CtlTypeIdDu)
                    {
                        case enumCtlType.span_43:
                            strCodeForCs.AppendFormat("\r\n" + "const spnCurr = GetSpan_Empty(\"{0}\");",
                                                     objFldDispUnitStyle.FldDispUnitStyleContent);
                            strCodeForCs.AppendFormat("\r\n" + "const spnStyle_Title = GetSpan_Empty(\"{0}\");//;",
                                                     objStyle_Title.StyleContent);
                            strCodeForCs.AppendFormat("\r\n" + "spnStyle_Title.innerHTML = \"{0}\";",
                                                     objFieldTab_Out.Caption);
                            strCodeForCs.AppendFormat("\r\n" + "const spnStyle_Content = GetSpan_Empty(\"{0}\");//; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);",
                                                     objStyle_Content.StyleContent);
                            strCodeForCs.AppendFormat("\r\n" + "spnStyle_Content.innerHTML = obj{0}.{1};",
                                                     ThisTabName4GC,
                                                     objFieldTab_In.PropertyName(this.IsFstLcase));

                            strCodeForCs.AppendFormat("\r\n" + "spnCurr.innerHTML = Format(\"{0}\", spnStyle_Title.outerHTML, spnStyle_Content.outerHTML);",
                                                     objFldDispUnitStyle.FldDispUnitFormat);
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = spnCurr.outerHTML;",
                                                     ThisTabName4GC,
                                                     objFieldTab.PropertyName(this.IsFstLcase));
                            break;
                        case enumCtlType.Label_10:
                            strCodeForCs.AppendFormat("\r\n" + "const lblCurr = GetLabel_Empty(\"{0}\");",
                                                     objFldDispUnitStyle.FldDispUnitStyleContent);
                            strCodeForCs.AppendFormat("\r\n" + "const lblStyle_Title = GetLabel_Empty(\"{0}\");//;",
                                                     objStyle_Title.StyleContent);
                            strCodeForCs.AppendFormat("\r\n" + "lblStyle_Title.innerHTML = \"{0}\";",
                                                     objFieldTab_Out.Caption);
                            strCodeForCs.AppendFormat("\r\n" + "const lblStyle_Content = GetLabel_Empty(\"{0}\");//; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);",
                                                     objStyle_Content.StyleContent);
                            strCodeForCs.AppendFormat("\r\n" + "lblStyle_Content.innerHTML = obj{0}.{1};",
                                                     ThisTabName4GC,
                                                     objFieldTab_In.PropertyName(this.IsFstLcase));

                            strCodeForCs.AppendFormat("\r\n" + "lblCurr.innerHTML = Format(\"{0}\", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);",
                                                     objFldDispUnitStyle.FldDispUnitFormat);
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = lblCurr.outerHTML;",
                                                     ThisTabName4GC,
                                                     objFieldTab.PropertyName(this.IsFstLcase));
                            break;
                        default:
                            var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objPrjTabFld.CtlTypeIdDu);
                            var strMsg = string.Format("�ؼ����ͣ�{0}�ں�����û�б�����!({1})", objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                    strCodeForCs.Append("\r\n" + "}");//try
                    //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);
                    if (objFieldTab.ObjDataTypeAbbr1().TypeScriptType != "boolean")
                    {
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("FuncMap{0}", objFieldTab.FldName), "����ӳ���:{0} �������ݳ���!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ���������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, " + this.constructorNameEx + ", strThisFuncName);", strErrId);
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n}");



                }
            }

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WAEx_Ts_FuncMapKey()
        {
            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            List<clsPrjTabFldEN> arrPrjTabFld_Sel = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            arrPrjTabFld_Sel = arrPrjTabFld_Sel.Where(x => x.IsForExtendClass == true).ToList();
            List<string> arrDataPropertyName = new List<string>();
            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFld_Sel)
            {
                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == true) continue;
                string strDataPropertyName = objPrjTabFld.DataPropertyName_FstLcase(this.IsFstLcase);
                if (arrDataPropertyName.Contains(strDataPropertyName) == true) continue;

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);
                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFld.DnPathId, objPrjTabENEx.PrjId);
                if (objDnPath == null) continue;
                if (objDnPath.PrjId != objPrjTabFld.PrjId)
                {
                    string strMsg = string.Format("�ڱ�:[{0}]��,��չ�ֶ�:[{1}]�����õ�·������ȷ!", ThisTabName4GC, objFieldTab.FldName);
                    objPrjTabFld.ErrMsg = strMsg;
                    objPrjTabFld.Update();
                    //throw new Exception(strMsg);
                    continue;
                }
                var objOutDataNode_Path = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.OutDataNodeId, objPrjTabENEx.PrjId);
                var objInDataNode_Path = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, objPrjTabENEx.PrjId);

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * ��һ����չ��Ĳ������Խ��к���ת��");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", ThisTabName4GC);
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "FuncMapKey{0}(obj{1}:cls{1}ENEx ): Promise<Array<{2}>>", objFieldTab.FldName, ThisTabName4GC, objInDataNode_Path.ObjFieldTab().TypeScriptType());
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = " + this.tabNameHeadEx + "FuncMapKey{0}.name;", objFieldTab.FldName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                arrDataPropertyName.Add(strDataPropertyName);
                if (objFieldTab.IsNumberType())
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}.{1} == 0) return [];",
                                         ThisTabName4GC,
                                         objFieldTab.PropertyName(this.IsFstLcase));
                }
                else
                {
                    if (objFieldTab.ObjDataTypeAbbr1().TypeScriptType != "boolean")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}.{1}) == true) return [];",
                                            ThisTabName4GC,
                                            objFieldTab.PropertyName(this.IsFstLcase));
                    }
                }

                string strLastVarName = "";
                string strLastVarType = "One";
                long strOutDataNodeId = objDnPath.OutDataNodeId;

                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabIdCache(objPrjTabENEx.TabId);
                List<clsDnFuncMapEN> arrDnFuncMap = null;
                try
                {
                    //clsPrjTabFldsBLEx.CheckOutDataNodeId(objPrjTabFld, this.CmPrjId, objPrjTabENEx.UserId);
                    //strOutDataNodeId = objDnPath.OutDataNodeId;
                    //var arrPath1 = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, strOutDataNodeId, this.CmPrjId,);

                    arrDnFuncMap = clsDnFuncMapBLEx.GetObjLstByDnPath(objDnPath, objPrjTabENEx.PrjId);
                    if (arrDnFuncMap == null || arrDnFuncMap.Count == 0)
                    {
                        var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabENEx.TabId, objPrjTabFld.PrjId);
                        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);
                        string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ,·������Ϊ0�� VersionNo=1, CmPrjId={2}({5}),����!(In {6})",
                            objPrjTabENEx.TabId,
                            objPrjTabFld.FldId, this.CmPrjId,
                            objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                            clsStackTrace.GetCurrClassFunction(), objPrjTabFld.DataPropertyName_FstLcase(this.IsFstLcase));
                        throw new Exception(strMsg);
                    }
                    arrDnFuncMap.Reverse();
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabENEx.TabId, objPrjTabFld.PrjId);
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);
                    string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ,����:{7}�� VersionNo=1, CmPrjId={2}({5}),����!(In {6})",
                        objPrjTabENEx.TabId,
                        objPrjTabFld.FldId, this.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message, objPrjTabFld.DataPropertyName_FstLcase(this.IsFstLcase));
                    throw new Exception(strMsg);
                }
                List<string> arrConstVar = new List<string>();
                foreach (var objInFor in arrDnFuncMap)
                {
                    if (objInFor == null) continue;
                    string strIsToString = "";
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}.{1}", ThisTabName4GC, objCacheClassifyField.PropertyName(this.IsFstLcase));
                            }
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                            {
                                var objCacheClassifyField2 = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

                                strCacheClassifyField += string.Format(", obj{0}.{1}", ThisTabName4GC, objCacheClassifyField2.PropertyName(this.IsFstLcase));
                            }

                            if (arrDnFuncMap.Count == 1)
                            {
                                if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                {
                                    if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName4GC(),
                                        ThisTabName4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                        arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                                    }
                                }

                            }

                            if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                            {
                                strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_Start.DataNodeName4GC(),
                                         ThisTabName4GC,
                                         objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                            }
                            if (strLastVarType == "List")
                            {
                                strCodeForCs.AppendFormat("\r\n const arr{0} = await {1}_funcKey(cls{1}EN.con_{2}, str{2}Lst {3}, enumComparisonOp.In_04);",
                                    objFieldTab_End.FldName,
                                    objPrjTab.TabName,
                                    objFieldTab_Start.FldName,
                                    strCacheClassifyField);
                                AddImportClass(objPrjTabENEx.TabId, "/PubFun/enumComparisonOp.js", "enumComparisonOp", enumImportObjType.CustomFunc, this.strBaseUrl);

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n const arr{0} = await {1}_funcKey(cls{1}EN.con_{2}, {4} {5}, enumComparisonOp.Like_03);",
                                    objFieldTab_End.FldName,
                                    objPrjTab.TabName,
                                    objFieldTab_Start.FldName,
                                    objFieldTab_End.FldName,
                                    objDataNode_Start.DataNodeName4GC(),
                                    strCacheClassifyField);
                                AddImportClass(objPrjTabENEx.TabId, "/PubFun/enumComparisonOp.js", "enumComparisonOp", enumImportObjType.CustomFunc, this.strBaseUrl);

                            }
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("funcKey", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);


                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                            if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            {
                                arrTabId4MapFunc.Add(objPrjTab.TabId);
                            }
                            strLastVarName = objDataNode_End.DataNodeName4GC();
                            strLastVarType = "List";
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objPrjTabENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":
                                    if (objInDataNode_Path.ObjFieldTab().FldName != objFieldTab_End.FldName)
                                    {
                                        if (strLastVarType == "List")
                                        {
                                            strCodeForCs.AppendFormat("\r\n const str{0}Lst = arr{0};", objFieldTab_Start.FldName);
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        }
                                        else
                                        {
                                            if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                            {
                                                if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                                {
                                                    //if (objFieldTab_Start.IsNumberType() == true)
                                                    //{
                                                    //    strIsToString = ".toString()";
                                                    //}

                                                    strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName4GC(),
                                                    ThisTabName4GC,
                                                    objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                                    arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                                }
                                            }
                                            else
                                            {
                                                strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName4GC(), objDataNode_Start.DataNodeName4GC());
                                                arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                            }
                                        }
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                                case "GetDateTime_Sim":
                                    //var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName4GC(),
                                            ThisTabName4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName4GC(),
                                        objDataNode_Start.DataNodeName4GC());
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const arr{0} = await {3}(obj{1}.{2});",
                                     objFieldTab_End.FldName,
                                            ThisTabName4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase),
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName4GC(),
                                        objDataNode_Start.DataNodeName4GC(),
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    //AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n return arr{0};",
                                    objInDataNode_Path.ObjFieldTab().FldName);
                //if (objFieldTab.ObjDataTypeAbbr1().TypeScriptType != "boolean")
                //{
                //    strCodeForCs.Append("\r\n" + "}");
                //}
                //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", ThisTabName4GC);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("FuncMap{0}", objFieldTab.FldName), "����ӳ���1:{0} �������ݳ���!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ���������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, " + this.constructorNameEx + ", strThisFuncName);", strErrId);
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n}");

            }

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WAEx_Ts_ProxyGetFunction()
        {
            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            List<clsDnFuncMapEN> arrDnFuncMapCache = clsDnFuncMapBL.GetObjLstCache(objPrjTabENEx.PrjId);
            List<string> arrTabId_FuncMap = arrDnFuncMapCache.Where(x => x.FuncMapModeId == enumFuncMapMode.Table_01).Select(x => x.TabId).ToList();
            List<string> arrTabId_FuncMap_One = arrDnFuncMapCache.Where(x => x.AssociationMappingId == enumAssociationMapping.OneToOne_01 && x.FuncMapModeId == enumFuncMapMode.Table_01).Select(x => x.TabId).ToList();
            List<string> arrTabId_FuncMap_Many = arrDnFuncMapCache.Where(x => x.AssociationMappingId == enumAssociationMapping.OneToMany_02 && x.FuncMapModeId == enumFuncMapMode.Table_01).Select(x => x.TabId).ToList();

            List<clsCMProjectPrjTabEN> arrCMProjectPrjTabCache = clsCMProjectPrjTabBL.GetObjLstCache(this.CmPrjId);
            List<string> arrTabId_CmPrjId = arrCMProjectPrjTabCache.Select(x => x.TabId).ToList();

            List<clsPrjTabEN> arrPrjTabCache0 = clsPrjTabBL.GetObjLstCache(objPrjTabENEx.PrjId);
            var arrPrjTabCache = arrPrjTabCache0.Where(x => arrTabId_CmPrjId.Contains(x.TabId)).ToList();
            List<clsFuncModule_AgcEN> arrFuncModule_AgcCache = clsFuncModule_AgcBL.GetObjLstCache(objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n" + "export  function getProxyClass_{0}(funcModuleName: string, option?: any) {{", objPrjTabENEx.PrjId);
            strCodeForCs.Append("\r\n" + "switch (funcModuleName)");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsFuncModule_AgcEN objInFor in arrFuncModule_AgcCache)
            {
                var arrCacheMode = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
                var arrPrjTab_Sel = arrPrjTabCache.Where(x => x.FuncModuleAgcId == objInFor.FuncModuleAgcId
                                && arrTabId_FuncMap.Contains(x.TabId)
                                && arrCacheMode.Contains(x.CacheModeId)).ToList();

                if (arrPrjTab_Sel.Count == 0) continue;
                strCodeForCs.AppendFormat("\r\n" + "case \"Proxy_{0}\":", objInFor.FuncModuleEnName4GC());
                strCodeForCs.AppendFormat("\r\n" + "return getFunction_{0};", objInFor.FuncModuleEnName4GC());

            }

            strCodeForCs.Append("\r\n" + "                        default:");
            strCodeForCs.Append("\r\n" + "console.warn(`δ�ҵ� funcModuleName��${ funcModuleName}                          ��Ӧʵ��`);");
            strCodeForCs.Append("\r\n" + "throw (`δ�ҵ� funcModuleName��${ funcModuleName}                ��Ӧʵ��`);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            foreach (clsFuncModule_AgcEN objFuncModule in arrFuncModule_AgcCache)
            {
                var arrCacheMode = new List<string> { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04 };
                var arrPrjTab_Sel = arrPrjTabCache.Where(x => x.FuncModuleAgcId == objFuncModule.FuncModuleAgcId
                                && arrTabId_FuncMap.Contains(x.TabId)
                                && arrCacheMode.Contains(x.CacheModeId)).ToList();

                if (arrPrjTab_Sel.Count == 0) continue;
                strCodeForCs.AppendFormat("\r\n" + "export  function getFunction_{0}(funcName: string, option?: any) {{", objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "switch (funcName)");
                strCodeForCs.Append("\r\n" + "{");

                foreach (var objInFor in arrPrjTab_Sel)
                {
                    if (arrTabId_FuncMap_One.Contains(objInFor.TabId))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "case \"{0}_func\":", objInFor.TabName);
                        strCodeForCs.AppendFormat("\r\n" + "return {0}_func;", objInFor.TabName);
                    }
                    if (arrTabId_FuncMap_Many.Contains(objInFor.TabId))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "case \"{0}_func4Lst\":", objInFor.TabName);
                        strCodeForCs.AppendFormat("\r\n" + "return {0}_func4Lst;", objInFor.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "                        default:");
                strCodeForCs.Append("\r\n" + "console.warn(`δ�ҵ� funcName��${ funcName}                          ��Ӧʵ��`);");
                strCodeForCs.Append("\r\n" + "throw (`δ�ҵ� funcName��${ funcName}                ��Ӧʵ��`);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WAEx_Ts_FuncMapByFldName()
        {
            StringBuilder strTemp = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.image_08)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(objField.DnPathId) == true && objField.FieldTypeId != enumFieldType.DisplayUnit_20)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.Object_29)
                {
                    continue;
                }

                strTemp.AppendFormat("\r\ncase cls{0}ENEx.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                strTemp.AppendFormat("\r\n" + "return {0}FuncMap{1}(obj{2}Ex);", this.tabNameHeadEx, objField.FldName, ThisTabName4GC);

            }


            Re_objFunction4Code.FuncName4Code = $"export  function {thisWAEx_F(WA_F.FuncMapByFldName)}(strFldName: string, obj{ThisTabName4GC}Ex: cls{ThisTabName4GC}ENEx) ";

            Re_objFunction4Code.FuncCHName4Code = "������չ�ֶ���ȥ������Ӧ��ӳ�亯����";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ������չ�ֶ���ȥ������Ӧ��ӳ�亯��");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strFldName:��չ�ֶ���");
            strCodeForCs.Append("\r\n * @param  obj{0}Ex:��Ҫת���Ķ���");
            strCodeForCs.AppendFormat("\r\n * @returns �����չ�ֶ�����ת��������к���ӳ��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  function {thisWAEx_F(WA_F.FuncMapByFldName)}(strFldName: string, obj{ThisTabName4GC}Ex: cls{ThisTabName4GC}ENEx)");

            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strThisFuncName = {thisWAEx_F(WA_F.FuncMapByFldName)}.name;");
            if (strTemp.Length == 0)
            {
                strCodeForCs.AppendFormat("\r\n" + "console.log(obj{0}Ex);", ThisTabName4GC);
            }
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
            strCodeForCs.Append("\r\n" + "//����Ǳ������ֶ�,����Ҫӳ��");
            strCodeForCs.AppendFormat("\r\n" + "const arrFldName = cls{0}EN.AttributeName;", ThisTabName4GC);
            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("cls{0}EN", ThisTabName4GC), enumImportObjType.ENClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "if (arrFldName.indexOf(strFldName) > -1) return;");
            strCodeForCs.Append("\r\n" + "//�����չ�ֶν���ӳ��");

            strCodeForCs.Append("\r\n" + "switch (strFldName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + strTemp.ToString());

            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.Append("\r\n" + "    strMsg = Format(\"��չ�ֶ�:[{0}]���ֶ�ֵ����ӳ���в�����!(in {1})\", strFldName, strThisFuncName);");
            AddImportClass(objPrjTabENEx.TabId, "/PubFun/clsString.js", "Format", enumImportObjType.CustomFunc, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WAEx_Ts_SortFunByKey()
        {
            Re_objFunction4Code.FuncName4Code = $"export  function {thisWAEx_F(WA_F.SortFunByKey)}(strKey:string, AscOrDesc: string) ";

            Re_objFunction4Code.FuncCHName4Code = "�����������ݹؼ����ֶε�ֵ���бȽ�.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * �����������ݹؼ����ֶε�ֵ���бȽ�");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param a:�Ƚϵĵ�1������");
            strCodeForCs.Append("\r\n * @param  b:�Ƚϵĵ�1������");
            strCodeForCs.AppendFormat("\r\n * @returns ������������ȽϵĽ��",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.Append("\r\n" + $"export  function {thisWAEx_F(WA_F.SortFunByKey)}(strKey:string, AscOrDesc: string)");

            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"SortFunByKey\";");

            strCodeForCs.Append("\r\n" + "if (AscOrDesc == \"Asc\" || AscOrDesc == \"\")");

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "switch (strKey)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.Object_29)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\ncase cls{0}ENEx.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}ENEx, b: cls{0}ENEx) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return a.{0}.localeCompare(b.{0});",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}ENEx, b: cls{0}ENEx) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return a.{0}-b.{0};", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}ENEx) => {{", ThisTabName4GC);

                        strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == true) return 1;", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "else return -1");
                        strCodeForCs.Append("\r\n" + "}");
                        break;
                    case "Object":
                        break;
                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }

            }


            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.Append("\r\n" + $"return {thisWA_F(WA_F.SortFunByKey)}(strKey, AscOrDesc);");
            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("SortFunByKey", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);

            //strCodeForCs.AppendFormat("\r\n" + "       const strMsg = `�ֶ���:[${{strKey}}]�ڱ����:[{0}]�в�����!(in ${{ this.constructor.name}}.${{ strThisFuncName}})`;", ThisTabName4GC);
            //strCodeForCs.Append("\r\n" + "       console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "     break;");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + "  else");
            strCodeForCs.Append("\r\n" + " {");

            strCodeForCs.Append("\r\n" + "switch (strKey)");
            strCodeForCs.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.Object_29)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\ncase cls{0}ENEx.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}ENEx, b: cls{0}ENEx) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return b.{0}.localeCompare(a.{0});",
                            objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "return (a: cls{0}ENEx, b: cls{0}ENEx) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "return b.{0}-a.{0};", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");

                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "return (b: cls{0}ENEx) => {{", ThisTabName4GC);
                        strCodeForCs.AppendFormat("\r\n" + "if (b.{0} == true) return 1;", objField.PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "else return -1");

                        strCodeForCs.Append("\r\n" + "}");
                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }

            }


            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.Append("\r\n" + $"return {thisWA_F(WA_F.SortFunByKey)}(strKey, AscOrDesc);");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("cls{0}EN", ThisTabName4GC),
                FilePath = string.Format("../../L0Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName4GC(),
                   ThisTabName4GC)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("cls{0}ENEx", ThisTabName4GC),
                FilePath = string.Format("../../L0Entity/{0}/cls{1}ENEx.js", objFuncModule.FuncModuleEnName4GC(),
                ThisTabName4GC)
            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("clsSysPara4WebApi", ThisTabName4GC),
                FilePath = string.Format("../../PubConfig/clsSysPara4WebApi.js", objFuncModule.FuncModuleEnName4GC(),
 ThisTabName4GC)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("Format", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/clsString.js", objFuncModule.FuncModuleEnName4GC(),
 ThisTabName4GC)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("IsNullOrEmpty", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/clsString.js", objFuncModule.FuncModuleEnName4GC(),
             ThisTabName4GC)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("stuPagerPara", ThisTabName4GC),
                FilePath = string.Format("../../PubFun/stuPagerPara.js", objFuncModule.FuncModuleEnName4GC(),
ThisTabName4GC)
            });

        }

        public string Gen_4WAEx_Ts_FuncMap4Path()
        {
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHeadEx + "FuncMap4Path(objDnPathPara: any ) ", "");
            Re_objFunction4Code.FuncCHName4Code = "��һ����չ��Ĳ������Խ��к���ת��.";

            List<string> arrTabId4MapFunc = new List<string>();
            List<clsDnPathEN> arrDnPath = null;
            try
            {
                arrDnPath = clsDnPathBLEx.GetObjLstByInDataNodeByTabIdCache(objPrjTabENEx.PrjId, objPrjTabENEx.TabId);
            }
            catch (Exception objException)
            {
                Console.WriteLine(objException);
                return "";
            }

            if (arrDnPath.Count == 0) return "";

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��һ����չ��Ĳ������Խ��к���ת��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", objPrjTabENEx.TabId);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "FuncMap4Path(objDnPathPara: any )", objPrjTabENEx.TabId);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = " + this.tabNameHeadEx + "FuncMap4Path.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (objDnPathPara.inDataNodeName == \"\" && objDnPathPara.outDataNodeName == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsDnPathEN objDnPath in arrDnPath)
            {
                if (objDnPath.OutDataNodeId == 0) continue;
                var objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, objDnPath.PrjId);
                var objOutDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.OutDataNodeId, objDnPath.PrjId);
                var objInFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInDataNode.FldId, objDnPath.PrjId);

                List<clsDnFuncMapEN> arrPath = null;
                try
                {
                    arrPath = clsDnFuncMapBLEx.GetObjLstByDnPath(objDnPath, objPrjTabENEx.PrjId);
                    if (arrPath.Count <= 1) continue;
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabENEx.TabId, objDnPath.PrjId);
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInDataNode.FldId, objDnPath.PrjId);
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(this.CmPrjId);
                    string strMsg = string.Format("ת��������,��TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ,����:{7}�� VersionNo=1, CmPrjId={2}({5}),����!(In {6})",
                        objPrjTabENEx.TabId,
                        objFieldTab.FldId, this.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message);
                    throw new Exception(strMsg);
                }
                bool bolIsNumberType = objInFieldTab.IsNumberType();
                strCodeForCs.AppendFormat("\r\n" + "else if (objDnPathPara.inDataNodeName == \"{0}\" && objDnPathPara.outDataNodeName == \"{1}\")",
                    objInDataNode.DataNodeName4GC(), objOutDataNode.DataNodeName4GC());
                strCodeForCs.Append("\r\n" + "{");
                if (objInDataNode.DataNodeName4GC() == "ViewRegion_RegionId" && objOutDataNode.DataNodeName4GC() == "ApplicationType_ApplicationTypeName")
                {
                    //string ss = "";
                }
                try
                {
                    clsDnPathBLEx.CheckDnPath(objDnPath, objPrjTabENEx.UserId);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("����:{0}��(In {1})",
                    objException.Message,
                      clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n" + "throw(\"{0}\");", strMsg);
                    strCodeForCs.Append("\r\n" + "}");
                    continue;
                }

                string strLastVarName = "";
                long strOutDataNodeId = objDnPath.OutDataNodeId;
                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabIdCache(strTabId_Out4ListRegion);

                List<string> arrConstVar = new List<string>();

                int intIndex = 0;
                foreach (var objInFor in arrPath)
                {
                    //string strIsToString = "";
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);
                    var objFuncMapMode = clsFuncMapModeBL.GetObjByFuncMapModeIdCache(objInFor.FuncMapModeId);
                    var strMapMode = "";
                    clsPrjTabEN objPrjTab = null;
                    if (objFuncMapMode.FuncMapModeId == enumFuncMapMode.Table_01)
                    {
                        objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                        strMapMode = string.Format("{0}({1})", objFuncMapMode.FuncMapModeName, objPrjTab.TabName);
                    }
                    else if (objFuncMapMode.FuncMapModeId == enumFuncMapMode.Function_02)
                    {
                        var objDnFunction = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objInFor.PrjId);
                        strMapMode = string.Format("{0}({1})", objFuncMapMode.FuncMapModeName, objDnFunction.DnFunctionName);
                    }
                    else
                    {
                        strMapMode = objFuncMapMode.FuncMapModeName;
                    }
                    strCodeForCs.AppendFormat("\r\n //Step.{0}  {1}-->{2}({3})",
                            intIndex + 1, objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:

                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", objDnPathPara.{0}", objCacheClassifyField.PropertyName(this.IsFstLcase));
                            }
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                            {
                                var objCacheClassifyField2 = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

                                strCacheClassifyField += string.Format(", objDnPathPara.{0}", objCacheClassifyField2.PropertyName(this.IsFstLcase));
                            }

                            if (arrPath.Count == 1)
                            {
                                if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                {
                                    if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                    {
                                        if (bolIsNumberType)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = Number(objDnPathPara.inValue);//{1}-->{2}({3})",
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = objDnPathPara.inValue;//{1}-->{2}({3})", objDataNode_Start.DataNodeName4GC(),
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                        }
                                        arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                                    }
                                }
                            }

                            if (objFieldTab_Start.IsNumberType() == true)
                            {
                                //strIsToString = ".toString()";
                            }
                            if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                            {
                                if (bolIsNumberType)
                                {
                                    if (intIndex == 0)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = Number(objDnPathPara.inValue);//{1}-->{2}({3})",
                                            objDataNode_Start.DataNodeName4GC(),
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = Number({1});//{2}-->{3}({4})",
                                            objDataNode_Start.DataNodeName4GC(), strLastVarName,
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), "Table");
                                    }
                                }
                                else
                                {
                                    if (intIndex == 0)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = objDnPathPara.inValue;", objDataNode_Start.DataNodeName4GC());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName4GC(), strLastVarName);
                                    }
                                }
                                arrConstVar.Add(objDataNode_Start.DataNodeName4GC());
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});//{6}-->{7}({8})",
                                objDataNode_End.DataNodeName4GC(),
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName4GC(),
                                strCacheClassifyField,
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func"), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                            AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);

                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                            if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            {
                                arrTabId4MapFunc.Add(objPrjTab.TabId);
                            }
                            strLastVarName = objDataNode_End.DataNodeName4GC();
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objPrjTabENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId && intIndex == 0)
                                    {
                                        if (arrConstVar.Contains(objDataNode_Start.DataNodeName4GC()) == false)
                                        {
                                            bool bolIsNumberType_End = objDataNode_End.ObjFieldTab().IsNumberType();
                                            if (bolIsNumberType_End)
                                            {
                                                strCodeForCs.AppendFormat("\r\n const {0} = Number(objDnPathPara.inValue);//{1}-->{2}({3})",
                                                    objDataNode_End.DataNodeName4GC(),
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                            }
                                            else
                                            {
                                                strCodeForCs.AppendFormat("\r\n const {0} = objDnPathPara.inValue;//{1}-->{2}({3})", objDataNode_End.DataNodeName4GC(),
                                                objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                            }
                                            arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                            strLastVarName = objDataNode_End.DataNodeName4GC();
                                        }
                                    }
                                    else
                                    {
                                        bool bolIsNumberType_End = objDataNode_End.ObjFieldTab().IsNumberType();
                                        if (bolIsNumberType_End)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = Number({1});//{2}-->{3}({4})", objDataNode_End.DataNodeName4GC(), objDataNode_Start.DataNodeName4GC(),
                                             objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = {1};//{2}-->{3}({4})", objDataNode_End.DataNodeName4GC(), objDataNode_Start.DataNodeName4GC(),
                                                    objDataNode_Start.DataNodeName4GC(), objDataNode_End.DataNodeName4GC(), strMapMode);
                                        }
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        strLastVarName = objDataNode_End.DataNodeName4GC();
                                    }

                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(objDnPathPara.inValue);",
                                     objDataNode_End.DataNodeName4GC());
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName4GC(),
                                        objDataNode_Start.DataNodeName4GC());
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                    }
                                    AddImportClass(objPrjTab.TabId, objDNFun.ImportPath, objDNFun.DnFunctionName, enumImportObjType.CustomFunc, this.strBaseUrl);

                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == objPrjTabENEx.TabId)
                                    {
                                        if (intIndex == 0)
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = await {3}(objDnPathPara.inValue);",
                                         objDataNode_End.DataNodeName4GC(),
                                                objPrjTabENEx.TabId,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase),
                                            objDNFun.DnFunctionName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                         objDataNode_End.DataNodeName4GC(),
                                                objPrjTab.TabName,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase),
                                            objDNFun.DnFunctionName);
                                        }
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        AddImportClass(objPrjTab.TabId, objDNFun.ImportPath, objDNFun.DnFunctionName, enumImportObjType.CustomFunc, this.strBaseUrl);

                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName4GC(),
                                        objDataNode_Start.DataNodeName4GC(),
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName4GC());
                                        AddImportClass(objPrjTab.TabId, objDNFun.ImportPath, objDNFun.DnFunctionName, enumImportObjType.CustomFunc, this.strBaseUrl);

                                    }
                                    strLastVarName = objDataNode_End.DataNodeName4GC();
                                    break;
                            }
                            break;
                    }
                    intIndex++;
                }
                strCodeForCs.AppendFormat("\r\n return {0};", strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"·��������! inDataNodeName:[{0}], outDataNodeName:[{1}].\", objDnPathPara.inDataNodeName, objDnPathPara.outDataNodeName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "FuncMap4Path2", "��һ����չ��Ĳ������Խ��к���ת������!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})��һ����չ��Ĳ������Խ��к���ת������,{{0}}.(in {{1}}.{{2}})\", e, " + this.constructorNameEx + ", strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string GeneCode_ImportClass()
        {
            StringBuilder sbImport = new StringBuilder();
            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            foreach (var objInFor in arrImportClass)
            {
                sbImport.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                  objInFor.ClsName,
                    objInFor.FilePath);
            }

            if (objPrjTabENEx.ApplicationTypeId == (int)enumApplicationType.VueAppInCore_TS_30)
            {
                sbImport = sbImport.Replace(".js", "");
            }
            return sbImport.ToString();
        }



        public string Gen_4WAEx_Ts_FilterFunByKey()
        {
            StringBuilder strTemp = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetEx)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.DataTypeId == enumDataTypeAbbr.Object_29)
                {
                    continue;
                }
                strTemp.AppendFormat("\r\ncase cls{0}ENEx.con_{1}:",
                    ThisTabName4GC,
                objField.ObjFieldTabENEx.FldName);
                switch (objField.ObjFieldTabENEx.TypeScriptType)
                {
                    case "string":
                        strTemp.AppendFormat("\r\n" + "return (obj: cls{0}ENEx) => {{", ThisTabName4GC);
                        strTemp.AppendFormat("\r\n" + "return obj.{0} === value;",
                            objField.PropertyName(this.IsFstLcase));
                        strTemp.Append("\r\n" + "}");

                        break;
                    case "Date":
                        strTemp.AppendFormat("\r\n" + "return (obj: cls{0}ENEx) => {{", ThisTabName4GC);
                        strTemp.AppendFormat("\r\n" + "return obj.{0} === value;",
                            objField.PropertyName(this.IsFstLcase));
                        strTemp.Append("\r\n" + "}");

                        break;
                    case "number":
                        strTemp.AppendFormat("\r\n" + "return (obj: cls{0}ENEx) => {{", ThisTabName4GC);
                        strTemp.AppendFormat("\r\n" + "return obj.{0} === value;",
    objField.PropertyName(this.IsFstLcase));
                        strTemp.Append("\r\n" + "}");

                        break;
                    case "boolean":
                        strTemp.AppendFormat("\r\n" + "return (obj: cls{0}ENEx) => {{", ThisTabName4GC);

                        strTemp.AppendFormat("\r\n" + "return obj.{0} === value;",
 objField.PropertyName(this.IsFstLcase));
                        strTemp.Append("\r\n" + "}");
                        break;

                    default:
                        var strMsg = string.Format("TypeScript:[{0}]�ں�����û�б�����(in {1})", objField.ObjFieldTabENEx.TypeScriptType, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                        //break;
                }

            }

            if (strTemp.Length == 0) return "";
            Re_objFunction4Code.FuncName4Code = string.Format("export  async function " + this.tabNameHeadEx + "FilterFunByKey(strKey:string, value: any) ", ThisTabName4GC);

            Re_objFunction4Code.FuncCHName4Code = "�����������ݹؼ����ֶε�ֵ���бȽ�.";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/**");
            strCodeForCs.AppendFormat("\r\n * ���˺��������ݹؼ����ֶε�ֵ�����ֵ���бȽ�,�����Ƿ����");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param strKey:�ȽϵĹؼ��ֶ�����");
            strCodeForCs.Append("\r\n * @param value:����ֵ");
            strCodeForCs.AppendFormat("\r\n * @returns ���ض�����ֶ�ֵ�Ƿ���ڸ���ֵ",
            ThisTabName4GC);
            strCodeForCs.AppendFormat("\r\n*/");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHeadEx + "FilterFunByKey(strKey:string, value: any)", ThisTabName4GC);

            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"FilterFunByKey\";");
            //strCodeForCs.Append("\r\n" + "let strMsg =\"\";");
            strCodeForCs.Append("\r\n" + "switch (strKey)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + strTemp.ToString());


            strCodeForCs.Append("\r\n" + "        default:");
            strCodeForCs.AppendFormat("\r\n" + "return {0}_FilterFunByKey(strKey, value);", ThisTabName4GC);
            AddImportClass(objPrjTabENEx.TabId, ThisTabName4GC, string.Format("FilterFunByKey", objKeyField.FldName), enumImportObjType.WApiClassFuncInExWApi, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

    }
}

