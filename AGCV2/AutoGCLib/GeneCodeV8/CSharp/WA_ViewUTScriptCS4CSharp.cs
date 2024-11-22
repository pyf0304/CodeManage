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
using System.Reflection;
using System.Linq;

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
    partial class WA_ViewUTScriptCS4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        public WA_ViewUTScriptCS4CSharp()
        {


            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_ViewUTScriptCS4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
       
        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
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

            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("WApi{0}_UT", objPrjTabENEx.TabName);;
            string strXmlFileName = string.Format("WApi{0}_UT", objPrjTabENEx.TabName);;
            strXmlFileName = strXmlFileName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".aspx.cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".aspx.cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n ///���ɲ�ѯɾ����¼�Ŀ��Ʋ����");
                strBuilder.Append("\r\n" + GenRefDomainName());    //���ɲο�����

                strBuilder.AppendFormat("\r\n" + "namespace {0}.WApiForm", objProject.PrjDomain);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0} ��ժҪ˵��������Q�����ѯ,U�����޸�", objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "private string strInfo = \"\";");
                //strBuilder.Append("\r\n" + "private string strWhereCond = \"\";");

                strBuilder.Append("\r\n" + "");
                ///���ɽ�����Page_Load����;
                strBuilder.Append("\r\n" + "#region ҳ����������");

                ///���ɽ�����Page_Load����;
                strTemp = GenPage_LoadCode(false);
                strBuilder.Append(strTemp);
                strBuilder.Append("\r\n" + "#endregion ҳ����������");
//�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                  .OrderBy(x=>x.OrderNum);
                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                             
                //Ϊ�����Ĳ�������ؼ����а�
                arrValueLst = new List<string>();
                       

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    if (strFuncName.IndexOf("Cs_btnClick") > 0)
                    {
                        //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                        //if (strFuncName4Code.Contains("AddNew") == true
                        //    || strFuncName4Code.Contains("Update") == true
                        //    || strFuncName4Code.Contains("GetObjByKey") == true)
                        //{
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        //string strSource = string.Format("ac{0}_UnitTest", objPrjTabENEx.TabName);
                        //string strTarget = string.Format("ac{0}_UTScript", objPrjTabENEx.TabName);

                        //strTemp = strTemp.Replace(strSource, strTarget);
                    }
                    else
                    {
                        strTemp = "";
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }
        protected string GenRefDomainName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Configuration;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Text;");
                strCodeForCs.Append("\r\n" + "using System.Web;");
                strCodeForCs.Append("\r\n" + "using System.Web.Security;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.WebControls.WebParts;");
                strCodeForCs.Append("\r\n" + "using System.Web.UI.HtmlControls;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                
                strCodeForCs.Append("\r\n" + "using Newtonsoft.Json;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
                
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);                
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}4WApi;", objProject.PrjDomain);
             
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();

        }

        ///�����޸ļ�¼����;
        public string GenPage_LoadCode(bool bolIsUseWuc4Gv)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void Page_Load(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                strCodeForCs.Append("\r\n" + "if (!IsPostBack)	///����������ǳ��α�����,�����ǵ�����ť�¼�������");
                strCodeForCs.Append("\r\n" + "{");
              
             
                strCodeForCs.Append("\r\n" + "//�����߼���Ĺ�������,����������ˢ�º���");
                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(hidDivName.Value) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "hidDivName.Value = \"divIsExistRecord\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            string FuncName4Code = TransKeyWords4FuncName( objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "protected void btn{0}_Click(object sender, EventArgs e) ",
                FuncName4Code);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName( objvFunction4GeneCodeEN.FuncName4Code));

            //GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strBuilder.AppendFormat("\r\n" + "string strKeyId = txtvarKeyId{0}.Text.Trim();",
                    objvFunction4GeneCodeEN.OrderNum);
     
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);

            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.int_09:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.money_11:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = long.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.JavaType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
                 

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"���ݹؼ���:[{{0}}]��ȡ����{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

    

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjByKey_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            string FuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "protected void btn{0}_Click(object sender, EventArgs e) ",
                FuncName4Code);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strBuilder.AppendFormat("\r\n" + "string strKeyId = txtvarKeyId{0}.Text.Trim();",
                    objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);

            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.int_09:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.money_11:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = long.Parse(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.JavaType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}GetObjBy{1}_WACache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1} = \"01\";",
      objPrjTabENEx.objCacheClassifyFld.CsType,
      objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}GetObjBy{1}_WACache({2}, {3});",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"���ݹؼ���:[{{0}}]��ȡ����(ʹ�û���)��{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�(ʹ�û���),{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "protected void btnGetFirstObj_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));


            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}GetFirstObj(strWhereCond);",
                objPrjTabENEx.TabName);
       
            
            strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
                        objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}] ��ȡ��һ����¼����{{1}}!\", strWhereCond, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Ӧ�ĵ�һ����¼�Ķ��󲻳ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

                   

            return strBuilder.ToString();
        }     

        public string Gen_WApi_Cs_btnClickGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLst_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = {0}GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
   
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.Count);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Ӧ�Ķ����б��ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
       
            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLstByKeyLst_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.CsType != "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<{0}> arr{1} = arrKeyId.Select(x=>{0}.Parse(x)).ToList();", objKeyField.CsType, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}Lst(arr{1});",
                    objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}Lst(arrKeyId);",
                    objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            }
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"���ݹؼ����б�:[{{0}}]����ȡ�����б�����{{1}}!\", string.Join(\",\",arrKeyId), arr{0}ObjLst.Count);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ȡ��Ӧ�Ķ����б��ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjLstByKeyLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�,ʹ�û���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLstByKeyLstCache_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                if (objKeyField.CsType != "string")
                {
                    strBuilder.AppendFormat("\r\n" + "List<{0}> arr{1} = arrKeyId.Select(x=>{0}.Parse(x)).ToList();", objKeyField.CsType, objKeyField.FldName_FstUcase);
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}LstCache(arr{1});",
                     objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}LstCache(arrKeyId);",
            objPrjTabENEx.TabName, objKeyField.FldName);
                } 
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1} = \"01\";",
              objPrjTabENEx.objCacheClassifyFld.CsType,
              objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                if (objKeyField.CsType != "string")
                {
                    strBuilder.AppendFormat("\r\n" + "List<{0}> arr{1} = arrKeyId.Select(x=>{0}.Parse(x)).ToList();", objKeyField.CsType, objKeyField.FldName_FstUcase);
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}LstCache(arr{1}, {2});",
                     objPrjTabENEx.TabName, objKeyField.FldName_FstUcase,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}LstCache(arrKeyId, {2});",
                     objPrjTabENEx.TabName, objKeyField.FldName,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
            }
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"���ݹؼ����б�:[{{0}}]����ȡ�����б���(ʹ�û���)��{{1}}!\", string.Join(\",\",arrKeyId), arr{0}ObjLst.Count());",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ȡ��Ӧ�Ķ����б��ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjLstByKeyLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�,ʹ�û���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLstByKeyLst_WACache_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                if (objKeyField.CsType != "string")
                {
                    strBuilder.AppendFormat("\r\n" + "List<{0}> arr{1} = arrKeyId.Select(x=>{0}.Parse(x)).ToList();", objKeyField.CsType, objKeyField.FldName_FstUcase);
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}Lst_WACache(arr{1});",
                     objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}Lst_WACache(arrKeyId);",
            objPrjTabENEx.TabName, objKeyField.FldName);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1} = \"01\";",
                        objPrjTabENEx.objCacheClassifyFld.CsType,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                if (objKeyField.CsType != "string")
                {
                    strBuilder.AppendFormat("\r\n" + "List<{0}> arr{1} = arrKeyId.Select(x=>{0}.Parse(x)).ToList();", objKeyField.CsType, objKeyField.FldName_FstUcase);
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}Lst_WACache(arr{1}, {2});",
                     objPrjTabENEx.TabName, objKeyField.FldName_FstUcase,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = {0}GetObjLstBy{1}Lst_WACache(arrKeyId, {2});",
                     objPrjTabENEx.TabName, objKeyField.FldName,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
            }
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"���ݹؼ����б�:[{{0}}]����ȡ�����б���(ʹ�û���)��{{1}}!\", string.Join(\",\",arrKeyId), arr{0}ObjLst.Count());",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ȡ��Ӧ�Ķ����б��ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLst_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
          
            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst ={0}GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
       
            strBuilder.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strBuilder.AppendFormat("\r\n" + "objFirstObj.{0} = \"��ѡ��...\";", strTextFld);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strBuilder.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "mspnObject.setPrompt(\"��ѡ������{0}: \");", objPrjTabENEx.TabCnName);

            strBuilder.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strBuilder.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strBuilder.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strBuilder.Append("\r\n" + "SendMessage(\"û��ʹ�û���!\");");
            strBuilder.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, û��ʹ�û���!\", 1);",
                strTabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ���������Ӧ�����б��ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�Ķ��������б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetTopObjLst_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //       strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
            //objvFunction4GeneCodeEN.OrderNum);
            //       strBuilder.AppendFormat("\r\n" + "string strTopSize = txtintTopSize{0}.Text.Trim();",
            //           objvFunction4GeneCodeEN.OrderNum);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "        stuTopPara objTopPara = new stuTopPara()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "whereCond = strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy = strOrderBy,");
            strBuilder.Append("\r\n" + "topSize = intTopSize,");
            strBuilder.Append("\r\n" + "IsCheckSQLAttack = \"false\",");
            strBuilder.Append("\r\n" + "Exclude = \"\"");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst ={0}GetTopObjLst(objTopPara);",
                objPrjTabENEx.TabName);
                     
 
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}],������:[{{1}}]����ȡ���������б�����{{2}}!\", strWhereCond, intTopSize, arr{0}ObjLst.Count);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Ӧ�Ķ��������б��ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
       
            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLstByPager_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.Append("\r\n" + "        stuPagerPara objPagerPara = new stuPagerPara()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "whereCond = strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy = strOrderBy,");
            strBuilder.Append("\r\n" + "pageIndex = intPageIndex,");
            strBuilder.Append("\r\n" + "PageSize = intPageSize");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = {0}GetObjLstByPager(objPagerPara);",
                objPrjTabENEx.TabName);
              

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}],ÿҳ��¼��:[{{1}}],��[{{2}}]ҳ,����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.Count);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Ӧ�ķ�ҳ�����б��ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");
         
            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetObjLstByPagerCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLstByPagerCache_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(strOrderBy) == true) strOrderBy = string.Format(\"{{0}} Asc\", con{0}.{1});", 
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld !=null)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}Cond.Set{1}(\"101\", \"=\");", objPrjTabENEx.TabName, 
                    objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.AppendFormat("\r\n" + "//obj{0}Cond.Set{1}(\"101\", \"=\");", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "//.SetUserStateId(\"01\", \"=\");");
            strBuilder.AppendFormat("\r\n" + "obj{0}Cond.sfUpdFldSetStr = obj{0}Cond.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strFldComparisonOp = JsonConvert.SerializeObject(obj{0}Cond.dicFldComparisonOp);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Cond.sfFldComparisonOp = strFldComparisonOp;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strWhereCond = JsonConvert.SerializeObject(obj{0}Cond);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "        stuPagerPara objPagerPara = new stuPagerPara()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "whereCond = strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy = strOrderBy,");
            strBuilder.Append("\r\n" + "pageIndex = intPageIndex,");
            strBuilder.Append("\r\n" + "PageSize = intPageSize");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = {0}GetObjLstByPagerCache(objPagerPara);",
                objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}],ÿҳ��¼��:[{{1}}],��[{{2}}]ҳ,����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.Count);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Ӧ�ķ�ҳ�����б��ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_WApi_Cs_btnClickGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Χ����Ӧ�Ķ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "protected void btnGetObjLstByRange_Click(object sender, EventArgs e) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            //strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
            //objvFunction4GeneCodeEN.OrderNum);
            //strBuilder.AppendFormat("\r\n" + "string strOrderBy = txtstrOrderBy{0}.Text.Trim();",
            //   objvFunction4GeneCodeEN.OrderNum);

            //strBuilder.AppendFormat("\r\n" + "string strMinNum = txtintMinNum{0}.Text.Trim();",
            //     objvFunction4GeneCodeEN.OrderNum);
            //strBuilder.AppendFormat("\r\n" + "string strMaxNum = txtintMaxNum{0}.Text.Trim();",
            //    objvFunction4GeneCodeEN.OrderNum);


            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.Append("\r\n" + "        stuRangePara objRangePara = new stuRangePara()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "whereCond = strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy = strOrderBy,");
            strBuilder.Append("\r\n" + "minNum = intMinNum,");
            strBuilder.Append("\r\n" + "maxNum = intMaxNum");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = {0}GetObjLstByRange(objRangePara);",
                objPrjTabENEx.TabName);
               
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}],��С��¼��:[{{1}}],����¼��:[{{2}}],����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intMinNum, intMaxNum, arr{0}ObjLst.Count);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Χ����Ӧ�Ķ����б��ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
  
            return strBuilder.ToString();
        }

      
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Cs_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.Append("\r\n" + "protected void btnIsExistRecord_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));


            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool returnBool = {0}_IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
         
strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
     
            strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
                objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}] ������!\", strWhereCond);",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
                objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:[{{0}}] ����!\", strWhereCond);",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�����Ӧ�ؼ��ֵļ�¼�Ƿ���ڲ��ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Cs_btnClickGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡĳһ�����ļ�¼��");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.Append("\r\n" + "protected void btnGetRecCountByCond_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));


            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int returnInt = {0}GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
                     
            strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
                objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:{{0}}�ļ�¼��:{{1}}!\", strWhereCond, returnInt);",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡĳһ�����ļ�¼�����ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetFldValue(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡĳһ�������ֶ�ֵ�б�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strBuilder.Append("\r\n" + "protected void btnGetFldValue_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));


            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<string> arrFldValueLst = {0}GetFldValue(strFldName, strWhereCond);",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "strWhereCond = txtstrWhereCond{0}.Text.Trim();",
                objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "strFldName = txtstrFldName{0}.Text.Trim();",
                            objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��������:{{0}}���ֶ�:[{{1}}]ֵ�б�:{{2}}!\", strWhereCond, strFldName, string.Join(\",\", arrFldValueLst));",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡĳһ�����ļ�¼�����ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_WApi_Cs_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ɾ����¼");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "protected void btnDelRecord_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            strBuilder.AppendFormat("\r\n" + "string strKeyId = txtstrKeyId{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);

            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(strKeyId);",
                            objDataTypeAbbrEN.CsType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.int_09:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(strKeyId);",
                            objDataTypeAbbrEN.CsType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.money_11:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(strKeyId);",
                            objDataTypeAbbrEN.CsType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = long.Parse(strKeyId);",
                            objDataTypeAbbrEN.CsType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.CsType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int returnInt = {0}_DelRecord({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"ɾ����¼�ɹ�, ��ɾ����{0}����¼!\", returnInt);");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"ɾ����¼���ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"ɾ����¼���ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
        
            return strBuilder.ToString();
        }
        public string Gen_WApi_Cs_btnClickDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ɾ����¼");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "protected void btnDelRecords_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            strBuilder.AppendFormat("\r\n" + "string strKeyIdLst = txtstrKeyIdLst{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int returnInt = {0}_DelRecords(strKeyIdLst);",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"ɾ����¼���ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"ɾ����¼���ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
         
            return strBuilder.ToString();
        }


        public string Gen_WApi_Cs_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
          //  strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "protected void btn{0}_Click(object sender, EventArgs e) ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", objWebSrvFunctionsENEx.FunctionName);

            strBuilder.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);

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
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})", 
                                    objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                    objDataTypeAbbrEN.CsType, 
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
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
            
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
            
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
          
            strBuilder.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
           

            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"����ֵΪ��{{0}}!\", returnString);");
            //strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");
         
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //  strBuilder.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "protected void btn{0}_Click(object sender, EventArgs e) ",
                TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code));

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
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
                        strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.CsType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.CsType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strBuilder.AppendFormat("\r\n" + "{0}_{1}({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objvFunction4GeneCodeEN.FuncName4Code);
          
            strBuilder.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");


            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"����ֵΪ��{0}!\", returnString);");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strBuilder.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Cs_btnClickAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "protected void btnAddNewRecord_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
               objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short){2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
            }
       
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}_IsExist({1});",
                objPrjTabENEx.TabName, strKeyFldName_ObjName);

            strBuilder.Append("\r\n" + "if (bolIsExist == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��֣�{{0}}�Ѿ�����!\", obj{0}EN.{1});",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
            strBuilder.Append("\r\n" + "return false;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "bool returnBool = {0}_AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"��Ӽ�¼�ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"��Ӽ�¼���ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");

     
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼���ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "protected void btnAddNewRecord4GetMaxStrId_Click(object sender, EventArgs e) {");

            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "string returnString = {0}GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
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
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                    }
                    else  if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short){2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                    }
                }
            }
            //strBuilder.AppendFormat("\r\n" + "strWhereCond =string.Format(\"{1} = '{{0}}'\", obj{0}EN.{1});",
            //    objPrjTabENEx.TabName,
            //    objKeyField.FldName);
            //strBuilder.AppendFormat("\r\n" + "bool returnBool = {0}_IsExistRecord(strWhereCond);",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "if (returnBool == false)");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool returnBool = {0}_AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
          
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"��Ӽ�¼�ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"��Ӽ�¼���ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");
      
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼���ɹ�, {0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "protected void btnGetMaxStrId_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string returnString = {0}GetMaxStrId();",
                objPrjTabENEx.TabName);
          
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}!\", returnString);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "protected void btnGetMaxStrIdByPrefix_Click(object sender, EventArgs e) {");
            //            strBuilder.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string returnString = {0}GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName);
           
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strInfo = string.Format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}!\", returnString);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
    


            return strBuilder.ToString();
        }

        public string Gen_WApi_Cs_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, EventArgs e) {");
            strBuilder.AppendFormat("\r\n" + "hidDivName.Value = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
           objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short){2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_CSharp);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();//������Щ�ֶα��޸�(���ֶ�)", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool returnBool = {0}_UpdateRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
        
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"�޸ļ�¼�ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strInfo = string.Format(\"�޸ļ�¼���ɹ�!\");");
            strBuilder.AppendFormat("\r\n" + "lblResult{0}.Text = strInfo;", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//��ʾ��Ϣ��");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�޸ļ�¼���ɹ�,{0}.(from {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
 
            return strBuilder.ToString();
        }
     private void GC_GetInputValue4Para(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strBuilder)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
//            StringBuilder strBuilder = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
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
                        strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{1}{2}.Text.Trim();",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{1}{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{1}{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = long.Parse(txt{1}{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{1}{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{1}{2}.Text.Trim();",
                                  objDataTypeAbbrEN.CsType,
                                  objFuncPara4CodeEN.ParaName,
                                  objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    string strTypeName = objFuncPara4CodeEN.GetParaTypeName(enumProgLangType.CSharp_01);
                                    
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{1}{2}.Text.Trim().Split(\",\".ToCharArray()).ToList();",
                                  strTypeName,
                                  objFuncPara4CodeEN.ParaName,
                                  objvFunction4GeneCodeEN.OrderNum);
                                    break;

                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.CsType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }

        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScriptCS4CSharp);
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
            this.ClsName = string.Format("WApi{0}_UT", objPrjTabENEx.TabName);
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
    }
}
