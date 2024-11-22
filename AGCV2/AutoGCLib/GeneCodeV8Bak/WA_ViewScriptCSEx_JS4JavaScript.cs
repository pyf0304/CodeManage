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
using com.taishsoft.util;
using AgcCommBase;
using System.Reflection;
using System.Linq;
using AGC.PureClass;
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
    partial class WA_ViewScriptCSEx_JS4JavaScript : clsGeneCodeBase
    {
        public bool Is4RJ { get; set; }
        private List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        int intZIndex;      ///�ؼ��������
        float intCurrLeft;  ///�ؼ�����߿�;
        float intCurrTop;  ///�ؼ��Ķ����;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region ���캯��
        public WA_ViewScriptCSEx_JS4JavaScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public WA_ViewScriptCSEx_JS4JavaScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WA_ViewScriptCSEx_JS4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        /// <summary>
        /// ��ʼ��ҳ������
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///�ؼ��������
            intCurrLeft = 10;  ///�ؼ�����߿�;
            intCurrTop = 10;
        }

        #endregion

        public string Gen_WApi_Js_Page_Load()
        {
            if (objViewInfoENEx.IsUseCache4List) return "";
    
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* ��������:ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.Page_Load = async function()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����Page_Load�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //��������
                strCodeForCs.Append("\r\n" + "//��������");

                strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    arrTabName.Add(objInfor.Ds_TabName);
                }
                             
                arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    //if (objInfor.Ds_TabName == objViewInfoENEx.TabName) continue;
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    arrTabName.Add(objInfor.Ds_TabName);

                    strCodeForCs.AppendFormat("\r\n" + " const obj{0}_Cond = new cls{0}EN();//{1}",
                        objInfor.Ds_TabName, clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId));
                }

                
                strCodeForCs.Append("\r\n" + Gen_WApi_Js_DdlBindFunction4Page_Load());

                    strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                            objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {{",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
                strCodeForCs.Append("\r\n" + "});");

                strCodeForCs.Append("\r\n" + "//2����ʾ�������ı�������GridView��");

                strCodeForCs.AppendFormat("\r\n" + "const gvResult = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"ҳ���������ɹ�,\" + e+ \".\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

    
        public string Gen_WApi_Js_DdlBind()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName == "DropDownList")
                    {
                        if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                        }
                        else
                        {
                            string strDS_DataValueField;
                            string strDS_DataTextField;
                            string strDs_TabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsEditRegionFldsBLEx.InitDs_PrjTab4Get(objEditRegionFldsEx);
                                strDs_TabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ��������:{2}.",
                                objViewInfoENEx.ViewName, "�༭����", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDs_TabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ����Դ����Ϊ�գ�����!({2}).",
                                objViewInfoENEx.ViewName, "�༭����", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3}.",
                                objViewInfoENEx.ViewName, "�༭����", objException.Message, strDs_TabName);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����.<br/>����Դ����Ϊ:{2}.({3})",
                                    objViewInfoENEx.ViewName, "�༭����", strDs_TabName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataTextField = clsEditRegionFldsBLEx.InitDs_DataTextField(objEditRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3},ֵ�ֶ���Ϊ:{4}.",
                                objViewInfoENEx.ViewName, "�༭����", objException.Message, strDs_TabName, strDS_DataValueField);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����.<br/>����Դ����Ϊ:{2},ֵ�ֶ���Ϊ:{3}.({4})",
                                      objViewInfoENEx.ViewName, "�༭����", strDs_TabName, strDS_DataValueField,
                                      clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            {
                                arrDdlKeyIdLst.Add(strDS_DataValueField);
                            }
                            else
                            {
                                continue;
                            }
                            switch (objEditRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///�б��;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /*��������:ddl{0}�ĺ�����", objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "*/");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                    split = objEditRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//Ϊ�������������ݵ�����,����������б�����ֱ����ӵ�");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"��\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"Ů\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///�б�������Դ��;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindDdl_{1}(ddl{1}, strWhereCond = \"1 =1\") {{",
                                      strDs_TabName, strDS_DataValueField, strDS_DataTextField, objEditRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������\" + ddl{1} + \" �����ڣ�\";",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const responseText = {0}_GetObjLstAsync(strWhereCond).then((jsonData)=>{{",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  jsonData;",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindDdl_{0}!\");", strDS_DataValueField);
                                    strCodeForCs.Append("\r\n" + "resolve(jsonData);");
                                    strCodeForCs.Append("\r\n" + "});");


                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = \"�������򲻳ɹ�,\" + e+ \".\";");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///�б�������ԴSQL��;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,��Sql��:[{0}]�л�ȡ",
                                       objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�Զ����Sql�������е����м�¼��¼��DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.System.Data.DataTable Get{0}(string strCondition)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /* �󶨻���Web��������");
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n  <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                                    strCodeForCs.Append("\r\n" + "*/");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataValueField);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                            }
                        }
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

        public string Gen_WApi_Js_DdlBind4QueryRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName == "DropDownList")
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            string strDS_DataValueField;
                            string strDS_DataTextField;
                            string strDs_TabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsQryRegionFldsBLEx.Ds_PrjTab4Get(objQryRegionFldsEx);
                                strDs_TabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ��������:{2}.",
                                objViewInfoENEx.ViewName, "��ѯ����", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDs_TabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ����Դ����Ϊ�գ�����!({2}).",
                                objViewInfoENEx.ViewName, "��ѯ����", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3}.",
                                objViewInfoENEx.ViewName, "��ѯ����", objException.Message, strDs_TabName);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����.<br/>����Դ����Ϊ:{2}.({3})",
                                    objViewInfoENEx.ViewName, "��ѯ����", strDs_TabName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3},ֵ�ֶ���Ϊ:{4}.",
                                objViewInfoENEx.ViewName, "��ѯ����", objException.Message, strDs_TabName, strDS_DataValueField);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����.<br/>����Դ����Ϊ:{2},ֵ�ֶ���Ϊ:{3}.({4})",
                                      objViewInfoENEx.ViewName, "��ѯ����", strDs_TabName, strDS_DataValueField,
                                      clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            {
                                arrDdlKeyIdLst.Add(strDS_DataValueField);
                            }
                            else
                            {
                                continue;
                            }
                            switch (objQryRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///�б��;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /*��������:ddl{0}�ĺ�����", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "*/");

                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                    split = objQryRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//Ϊ�������������ݵ�����,����������б�����ֱ����ӵ�");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"��\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"Ů\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///�б�������Դ��;

                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindDdl_{1}(ddl{1}, strWhereCond = \"1 =1\") {{",
                                      strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������\" + ddl{1} + \" �����ڣ�\";",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const responseText = {0}_GetObjLstAsync(strWhereCond).then((jsonData)=>{{",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  jsonData;",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindDdl_{0}!\");", strDS_DataValueField);
                                    strCodeForCs.Append("\r\n" + "resolve(jsonData);");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = \"�󶨲�ѯ�������򲻳ɹ�,\" + e+ \".\";");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///�б�������ԴSQL��;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,��Sql��:[{0}]�л�ȡ",
                                       objQryRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�Զ����Sql�������е����м�¼��¼��DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /* �󶨻���Web��������");
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n  <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                                    strCodeForCs.Append("\r\n" + "*/");

                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataValueField);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                            }
                        }
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

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {            
            List<ImportClass> arrImportClass = new List<ImportClass>();
            //     if (objViewInfoENEx.IsUseCache4List)
            //     {
            //         arrImportClass.Add(new ImportClass
            //         {
            //             ClassName = string.Format("WA_{0}_QUDI_Cache", objViewInfoENEx.TabName),
            //             FilePath = string.Format("./WA_{1}_QUDI_Cache.js", 
            //                 objFuncModule.FuncModuleEnName,
            //                 objViewInfoENEx.TabName)
            //         });

            //     }
            //     else
            //     {
            //         arrImportClass.Add(new ImportClass
            //         {
            //             ClassName = string.Format("WA_{0}_QUDI_JS", objViewInfoENEx.TabName),
            //             FilePath = string.Format("./WA_{1}_QUDI_JS.js",
            //             objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //         });
            //     }

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("{0}", this.BaseClsName),
                FilePath = string.Format("./{0}.js", this.BaseClsName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsCommFunc4Web", objViewInfoENEx.TabName),
                FilePath = string.Format("clscommonfunc4web", objFuncModule.FuncModuleEnName,
objViewInfoENEx.TabName)
            });
            return arrImportClass;
        }

        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //���û���������;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�в�ѯ��������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û��DataGrid����,����DataGrid����û���ֶΡ�����!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            //string strResult = "";

            string strFuncName = "";
            string strTemp = ""; ///��ʱ����;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleId_Cache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            this.GetClsName();
            //if (objViewInfoENEx.IsUseCache4List)
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WA_{0}_QUDI_CacheEx", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WA_{0}_QUDI_CacheEx.js",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WA_{0}_QUDI_JSEx", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WA_{0}_QUDI_JSEx.js",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}

            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.js", objViewInfoENEx.ClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;


            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objViewInfoENEx.PrjId); //
            try
            {
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx));


                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);
                                
                strCodeForCs.Append("\r\n" + "const __extends = (this && this.__extends) || (function() {");
                strCodeForCs.Append("\r\n" + "const extendStatics = function(d, b) {");
                strCodeForCs.Append("\r\n" + "extendStatics = Object.setPrototypeOf ||");
                strCodeForCs.Append("\r\n" + "({ __proto__: [] }");
                strCodeForCs.Append("\r\n" + "instanceof Array && function(d, b) { d.__proto__ = b; }) ||");
                strCodeForCs.Append("\r\n" + "function(d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };");
                strCodeForCs.Append("\r\n" + "return extendStatics(d, b);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return function(d, b) {");
                strCodeForCs.Append("\r\n" + "extendStatics(d, b);");
                strCodeForCs.Append("\r\n" + "function __() { this.constructor = d; }");
                strCodeForCs.Append("\r\n" + "d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "})();");
                strCodeForCs.Append("\r\n" + "(function(factory) {");
                strCodeForCs.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const v = factory(require, exports);");
                strCodeForCs.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strCodeForCs.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x => string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strCodeForCs.AppendFormat("\r\n" + "define([\"require\", \"exports\", {0}], factory);", strFilePathStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "})(function(require, exports) {");
                strCodeForCs.Append("\r\n" + "\"use strict\";");
                strCodeForCs.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");
                arrImportClass.ForEach(x => {
                    if (string.IsNullOrEmpty(x.ModuleName) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {2} = require(\"{1}\");", x.ClassName, x.FilePath, x.ModuleName);
                    }
                });


                strCodeForCs.AppendFormat("\r\n /* {0} ��ժҪ˵��������Q�����ѯ,U�����޸�",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");


                strCodeForCs.AppendFormat("\r\n" + "const {0} = /** @class **/ (function(_super) {{", objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "__extends({0}, _super);", objViewInfoENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "function {0}()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return _super !== null && _super.apply(this, arguments) || this;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "Object.defineProperty({0}.prototype, \"PageSize\", {{",
                    objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "get: function() { return 10;},");
                    strCodeForCs.Append("\r\n" + "enumerable: true,");
                    strCodeForCs.Append("\r\n" + "configurable: true");
                    strCodeForCs.Append("\r\n" + "});");
                    
                    
                strCodeForCs.Append("\r\n" + "");
             
                //strCodeForCs.Append("\r\n" + "#endregion ҳ����������");
                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                 
                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                 
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                 
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                Gen_WApi_Js_ControlProperty(strCodeForCs);

                    if (objViewInfoENEx.objCacheClassifyFld4View != null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}.{1}_Cache = \"\";",
                            objViewInfoENEx.ClsName,
                            objViewInfoENEx.objCacheClassifyFld4View.FldName);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "return {0};", objViewInfoENEx.ClsName);
                //if (objViewInfoENEx.IsUseCache4List)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "}}({0}));",
                //    ImportClass.GetOutString(string.Format("WA_{0}_QUDI_Cache", objViewInfoENEx.TabName), this.Is4RJ));
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "}}({0}));",
                //    ImportClass.GetOutString(string.Format("WA_{0}_QUDI_JS", objViewInfoENEx.TabName), this.Is4RJ));

                //}
                strCodeForCs.AppendFormat("\r\n" + "}}({0}));",
                        ImportClass.GetOutString(string.Format("{0}", this.BaseClsName), this.Is4RJ));

                strCodeForCs.AppendFormat("\r\n" + "exports.{0} = {0};", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "});");
                }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        //Object.defineProperty(WApiUsers_QUDI_Cache.prototype, "UserStateId", {
        //    /*
        //    * �û�״̬��
        //   **/
        //    get: function()
        //{
        //    return $("#ddlUserStateId").val();
        //},
        //    /*
        //    * �û�״̬��
        //   **/
        //    set: function(value)
        //{
        //        $("#ddlUserStateId").val(value);
        //},
        //    enumerable: true,
        //    configurable: true
        //});

        public void Gen_WApi_Js_ControlProperty(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "Object.defineProperty(WApiUsers_QUDI_Cache.prototype, \"{0}\", {{", x.PropertyName);

                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.Append("\r\n" + "    get: function()");
                        strCodeForCs.Append("\r\n" + "{");
                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + " },");
                        break;
                    case "set":
                        strCodeForCs.Append("\r\n" + " set: function(value)");
                        strCodeForCs.Append("\r\n" + "{");
                        switch (x.ControlType)
                        {
                            case "checkbox":
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "},");
                        break;

                }
                strCodeForCs.Append("\r\n" + " enumerable: true,");
                strCodeForCs.Append("\r\n" + "configurable: true");
                strCodeForCs.Append("\r\n" + "});");
            });
        }

        public string Gen_WApi_Js_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_List.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /* ��ʾ{0}�������������ֵ", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"divContainer\">��ʾ����</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"arr{0}ObjLst\">��Ҫ�󶨵Ķ����б�</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindTab_{0} = function(divContainer, arr{0}ObjLst) ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"\" + divContainer + \"�����ڣ�\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"���Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //��DG���Ƿ����޸İ�ť
            {
               
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "text: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnUpdateRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");             
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)            
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnDelRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "text: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnDetailRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
                
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnSelectRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindTabV3(o, arr{0}ObjLst, arrDataColumn, cls{0}EN.con_{1}, this); ",
                objViewInfoENEx.TabName_Out, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + "this.objPager.ShowPager();");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "��ʾSession ����");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.Demo_Session = async function()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//����Session");
            strCodeForCs.Append("\r\n" + "const strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSessionAsync(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//��ȡSession");
            strCodeForCs.Append("\r\n" + "const strUserId_Value1 = await this.GetSessionAsync(\"UserId\");");
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//��ȡSession����2��ֱ�Ӷ�ȡҳ���е�hidUserId");
            strCodeForCs.Append("\r\n" + "const strUserId_Value2 = this.hidUserId;");
        

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidUserId",
                PropertyName = "hidUserId",
                Comment = "�û�Id",
                DataType = "string"
            });
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value2:' + strUserId_Value2);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ʾSession���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_SetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "����Session");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">�ؼ���</param>");
            strCodeForCs.Append("\r\n" + "<param name = \"Value\">ֵ</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.SetSessionAsync = function(Key, Value) {");
            strCodeForCs.Append("\r\n" + "localStorage.setItem(Key, Value);");
            strCodeForCs.Append("\r\n" + "console.log('strKey=' + Key + ', strValue=' + Value);");
            strCodeForCs.Append("\r\n" + "}");
           
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_GetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "��ȡSession �ؼ��ֵ�ֵ");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">�ؼ���</param>");
            strCodeForCs.Append("\r\n" + " <return>ֵ</return>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.GetSession = function(Key) {");
            strCodeForCs.Append("\r\n" + "const strValue = localStorage.getItem(Key);");
            strCodeForCs.Append("\r\n" + "console.log('strKey=' + Key + ', strValue=' + strValue);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_SetKeyReadOnly()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.FldName != objKeyField.ObjFieldTabENEx.FldName) continue;
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// ���û��Զ���ؼ��У����ùؼ��ֵ�ֵ���Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">�Ƿ�ֻ��</param>");
                        strCodeForCs.Append("\r\n" + "{0}.prototype.SetKeyReadOnly = function(bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "$('#{0}').prop['ReadOnly'] = bolReadonly;", objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_WApi_Js_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ����û��Զ���ؼ��У����пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "{0}.prototype.Clear = function()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    try
                    {
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objEditRegionFldsEx.CtlTypeName,
                            CtrlId = objEditRegionFldsEx.CtrlId,
                            PropertyName = objEditRegionFldsEx.PropertyName(),
                            Comment = objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                            DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                        });
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objEditRegionFldsEx.FldName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.FldName,
                                    objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///����ؼ���������;
                                strCodeForCs.AppendFormat("\r\n" + "$('#{0} option[0]').attr(\"selected\", true);",
                                objEditRegionFldsEx.CtrlId);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///����ؼ��������ı���;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.FldName, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objEditRegionFldsEx.FldName, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objEditRegionFldsEx.FldName, strInitValue);
                                break;
                        }
                    }
                    catch(Exception objException)
                    {
                        string strMsg = string.Format("�����ֶ�:{0}ʱ����{1}(In {2})", objEditRegionFldsEx.FldName,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
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

        public string Gen_WApi_Js_CopyRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {


                List<clsFeatureRegionFldsENEx> arrFeature_AdditionalCopy = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FieldTypeId == enumFieldType.AdditionalCopyField_15).ToList();
                clsFieldTabEN objFieldTab_Copy = null;
                string strCopyValue = "";
                if (arrFeature_AdditionalCopy.Count() > 0)
                {
                    clsFeatureRegionFldsENEx objFeature_AdditionalCopy = arrFeature_AdditionalCopy[0];
                    strCopyValue = objFeature_AdditionalCopy.DefaultValue;
                    if (string.IsNullOrEmpty(strCopyValue)) strCopyValue = "C_";
                    if (string.IsNullOrEmpty(objFeature_AdditionalCopy.ReleFldId) == false)
                    {
                        objFieldTab_Copy = clsFieldTabBL.GetObjByFldId_Cache(objFeature_AdditionalCopy.ReleFldId, objViewInfoENEx.PrjId);
                    }
                }
                strCodeForCs.Append("\r\n /* ���Ƽ�¼");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.CopyRecord = async function(arr{0}) {{", objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_GetObjLstBy{1}LstAsync(arr{1});",
                    objViewInfoENEx.TabName_In, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "console.log('responseText=');");
                strCodeForCs.Append("\r\n" + "console.log(responseText);");
                strCodeForCs.Append("\r\n" + "const intCount = 0;");
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  responseText;",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "{");
                if (objFieldTab_Copy == null)
                {
                    //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} =\"{1}\" + objInFor.{0};",
                        objFieldTab_Copy.PropertyName(), strCopyValue);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strMaxStrId = await {0}_GetMaxStrIdAsync();",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "console.log('strMaxStrId=' + strMaxStrId);");
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = strMaxStrId;", objKeyField.PropertyName());
                }
                strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await {0}_AddNewRecordAsync(objInFor);", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "console.log('responseText2=');");
                strCodeForCs.Append("\r\n" + "console.log(responseText2);");
                strCodeForCs.Append("\r\n" + "const returnBool = !!responseText2;");
                strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = \"��¡��¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = \"��¡��¼���ɹ�!\";");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const strInfo = \"����¡��\" + intCount + \"����¼!\";");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "console.log('��ɣ�');");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"���Ƽ�¼���ɹ�,\" + e+ \".\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
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
 
        public string Gen_WApi_Js_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ��ʾ{0}�������������ֵ");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n  <param name = \"divContainer\">��ʾ����</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"obj{0}\">��Ҫ��ʾ�Ķ���</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.Show{0}Obj = function(divContainer, obj{0}) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"\" + divContainer + \"�����ڣ�\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const ul = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const li = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = \"\" + strKey + \":\" + strValue + \"\";");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "o.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.UpdateRecord = async function({0}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "//$('#btnOKUpd').text(\"ȷ���޸�\");");
            //strCodeForCs.Append("\r\n" + "//$('#btnCancel').text(\"ȡ���޸�\");");
            //strCodeForCs.Append("\r\n" + "//$('#btnOKUpd').html(\"ȷ���޸�\");");
            //strCodeForCs.Append("\r\n" + "//$('#btnCancel').html(\"ȡ���޸�\");");
            strCodeForCs.Append("\r\n" + "this.btnOKUpd = \"ȷ���޸�\";");
            strCodeForCs.Append("\r\n" + "this.btnCancel = \"ȡ���޸�\";");
                    
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnOKUpd",
                PropertyName = "btnOKUpd",
                Comment = "����ȷ����ť�ı���",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnCancel",
                PropertyName = "btnCancel",
                Comment = "����ȡ����ť�ı���",
                DataType = "string"
            });

            //strCodeForCs.AppendFormat("\r\n" + "//$('#hidKeyId').val({0});", objKeyField.PrivFuncName);
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0}.toString();", objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }
            
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
     
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        //strCodeForCs.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
           
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "this.GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���UpdateRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "���ݹؼ���ѡ����Ӧ�ļ�¼");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.SelectRecord = async function({0}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "$('#btnOKUpd').text(\"ȷ���޸�\");");
            //strCodeForCs.Append("\r\n" + "$('#btnCancel').text(\"ȡ���޸�\");");
            //strCodeForCs.Append("\r\n" + "$('#btnOKUpd').html(\"ȷ���޸�\");");
            //strCodeForCs.Append("\r\n" + "$('#btnCancel').html(\"ȡ���޸�\");");

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                     
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���SelectRecord!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.Redirect(\"/Index/Main_{0}\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_DetailRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "���ݹؼ�����ϸ��Ϣ��¼");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.DetailRecord = async function({0}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "this.btnOKUpd = \"\";");
            strCodeForCs.Append("\r\n" + "this.btnCancel = \"�ر�\";");
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnOKUpd",
                PropertyName = "btnOKUpd",
                Comment = "����ȷ����ť�ı���",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnCancel",
                PropertyName = "btnCancel",
                Comment = "����ȡ����ť�ı���",
                DataType = "string"
            });
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "this.GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DetailRecord!\");", objViewInfoENEx.TabName_Out);
            
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
                       
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.Append("\r\n" + "{0}.prototype.btnGetFirstObj_Click = async function() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetFirstObjAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                        objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"] ��ȡ��һ����¼����\" + obj{0}EN.{1} + \"!\";",
                objViewInfoENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divResult{0}\", obj{1}EN);",
    objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����������ȡ��Ӧ�ĵ�һ����¼�Ķ��󲻳ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_QueryLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.Query{0}Lst = function(strListDiv) ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
                        
            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "��ȡ��ǰҳ���",
                DataType = "number"

            });
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const objPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const responseText = {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst  = jsonData;",
                objViewInfoENEx.TabName_Out);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"]����ȡ�����б�����\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���Query{0}Lst!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "resolve(jsonData);");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ѯ�����б��ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_BindGv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.IsUseCache4List) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindGv_{0} = async function() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "��ȡ��ǰҳ���",
                DataType = "number"

            });

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {0}_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {{",
objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const objPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = jsonData;",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��GridView���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"�ڰ�Gv_Cache�����У�����������ȡ�Ķ����б���Ϊ0��\";");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"]����ȡ�����б�����\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}!\");", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");
        

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg =\"�󶨶����б��ɹ�, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_BindGv_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindGv_{0}_Cache = async function() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj();", objViewInfoENEx.TabName_Out);
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, \"{2}1\", \"=\");",
                        objViewInfoENEx.TabName_Out, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        clsString.combineStrS("9", objViewInfoENEx.objCacheClassifyFld4View.ObjFieldTabENEx.FldLength - 1));
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}_Cond);", objViewInfoENEx.TabName_Out);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "��ȡ��ǰҳ���",
                DataType = "number"

            });

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.recCount =  {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                    objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.recCount =  {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            
            strCodeForCs.Append("\r\n" + "const objPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = {0}_GetObjLstByPager_Cache(objPagerPara);",   objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);", 
                    objViewInfoENEx.TabName_Out,
                    objViewInfoENEx.ClsName, 
                    objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
      
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��GridView���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0})\";",
                    objViewInfoENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_\" + {1}.{2}_Cache + \")\";",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"]����ȡ�����б�����\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}!\");", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg =\"�󶨶����б��ɹ�, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnQuery_Click = async function(strListDiv) ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj();", objViewInfoENEx.TabName_Out);
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, \"{2}1\", \"=\");",
                            objViewInfoENEx.TabName_Out,
                            objViewInfoENEx.objCacheClassifyFld4View.FldName,
                            clsString.combineStrS("9", objViewInfoENEx.objCacheClassifyFld4View.ObjFieldTabENEx.FldLength - 1));
                }
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}_Cond);", objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.recCount =  {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.recCount =  {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                          
                strCodeForCs.Append("\r\n" + "const objPagerPara = {");
                strCodeForCs.Append("\r\n" + "pageIndex: 1,");
                strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = {0}_GetObjLstByPager_Cache(objPagerPara);", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);", objViewInfoENEx.TabName_Out,
                        objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);


            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
                //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {0}_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {{",
        objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "const objPagerPara = {");
                strCodeForCs.Append("\r\n" + "pageIndex: 1,");
                strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {{",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst  = jsonData;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "});");

            }
           
        
            
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ѯ���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnExportExcel_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnExportExcel_Click = async function() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.Append("\r\n" + "const strWhereCond =\" 1=1 \";");
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_GetObjLstAsync(strWhereCond).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst  = jsonData;",
                objViewInfoENEx.TabName_Out);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"]����ȡ�����б�����\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����Excel���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetObjLst_Click = async function() ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"��ѡ��...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLst_Cache = arr{0}ObjLst;",
                strTabName, objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"��ѡ������{0}: \");", objViewInfoENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"û��ʹ�û��棡\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, û��ʹ�û��棡\", 1);",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����������ȡ��Ӧ������������б��ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�Ķ��������б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetTopObjLst_Click = async function() ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetTopObjLstAsync(strWhereCond, intTopSize);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"],������:[\" + intTopSize + \"]����ȡ���������б�����\" + arr{0}ObjLst.length + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����������ȡ��Ӧ�Ķ��������б��ɹ�, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetObjLstByPager_Click = async function() ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstByPagerAsync(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"],ÿҳ��¼��:[\" + intPageSize+ \"],��[\" + intPageIndex+ \"]ҳ,����ȡ��ҳ�����б�����\" + arr{0}ObjLst.length + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����������ȡ��Ӧ�ķ�ҳ�����б��ɹ�, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����������ȡ��Χ����Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetObjLstByRange_Click = async function() ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstByRangeAsync( intMinNum, intMaxNum, strWhereCond, strOrderBy);",
                objViewInfoENEx.TabName);
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"],��С��¼��:[\" + intMinNum + \"],����¼��:[\" + intMaxNum + \"],����ȡ��ҳ�����б�����\" + arr{0}ObjLst.length + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����������ȡ��Χ����Ӧ�Ķ����б��ɹ�, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Js_ScriptCSIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnIsExistRecord_Click = async function() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {0}_IsExistRecordAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"] �ļ�¼������!\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:[\" + strWhereCond + \"]����ؼ�¼����!\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"�����Ӧ�ؼ��ֵļ�¼�Ƿ���ڲ��ɹ�, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Js_ScriptCSGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ��ȡĳһ�����ļ�¼��");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnGetRecCountByCond_Click = async function() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            
            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_GetRecCountByCondAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "const returnInt = Number(responseText);");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��������:\" + strWhereCond + \"�ļ�¼��:\" + returnInt + \"!\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ȡĳһ�����ļ�¼�����ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����־ɾ����¼");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnDelRecordBySign_Click = async function() {");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ����־ɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_DelRecordBySignAsync(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
         
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {                 
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
            strCodeForCs.Append("\r\n" + "const strInfo = \"����־ɾ����¼�ɹ�,��ɾ��\" + returnInt + \"����¼!\";");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"����־ɾ����¼���ɹ�!\";");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"����־ɾ����¼���ɹ�. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n �����ݱ�����ϸ��Ϣ��¼");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {");
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Detail\";");
                    

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��ϸ��Ϣ�ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ϸ��Ϣ��¼���ɹ�. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
              
        public string Gen_WApi_Js_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* �����ݱ����޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {");
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");

         
            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�޸ĵļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ɾ����¼");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnDelRecords_Click = async function() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "string strKeyIdLst = txtstrKeyIdLst{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_DelRecordsAsync(strKeyIdLst);",
                objViewInfoENEx.TabName,
                objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "const returnInt = Number(responseText);");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼�ɹ�,��ɾ��\" + returnInt + \"����¼!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼���ɹ�!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"ɾ����¼���ɹ�. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.DelMultiRecord = async function(arr{0}) {{",
                objKeyField.FldName);

            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_Del{0}sAsync(arr{1});",
                objViewInfoENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);",
                        objViewInfoENEx.TabName_In, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();",
                        objViewInfoENEx.TabName_In);
                }
            }

            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼�ɹ�,��ɾ��\" + returnInt + \"����¼!\";");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼���ɹ�!\";");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DelMultiRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"ɾ����¼���ɹ�. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n ���ݹؼ���ɾ����¼");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.DelRecord = async function({0}) {{",
                objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);

            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_DelRecordAsync({1});",
                objViewInfoENEx.TabName,
                objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);",
                        objViewInfoENEx.TabName_In, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();",
                        objViewInfoENEx.TabName_In);
                }
            }

            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼�ɹ�,��ɾ��\" + returnInt + \"����¼!\";");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼���ɹ�!\";");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DelRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"ɾ����¼���ɹ�. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ��������ɾ��������¼");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnDelMultiRecordByCond_Click = async function() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_Del{0}sByCondAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼�ɹ�,��ɾ��\" + returnInt + \"����¼!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"ɾ����¼���ɹ�!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"ɾ����¼���ɹ�. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
     
        public string Gen_WApi_Js_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");


            strCodeForCs.Append("\r\n" + "{0}.prototype.GetMaxStrId = async function(strKeyCtrlName) {");

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "��ӡ��޸��õĲ�1��",
            //    DataType = "string"
            //});

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdAsync();",
                objViewInfoENEx.TabName);
            
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��ȡ��{0}�����ؼ���Ϊ�գ����ɹ�������!\";",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��ȡ��{0}�����ؼ���Ϊ��\" + returnString + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ȡ��ؼ��ֵ����ֵ���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.Append("\r\n" + "{0}.prototype.btnGetMaxStrIdByPrefix_Click = async function() {");
            //            strCodeForCs.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdByPrefixAsync(strPrefix);",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��ȡ��{0}�����ؼ���Ϊ�գ����ɹ�������!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"��ȡ��{0}�����ؼ���Ϊ��\" + returnString + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��ȡ��ؼ��ֵ����ֵ���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
              
        Func<clsvViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Js_DdlBindFunction4Page_Load()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDs_TabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = {2}_BindDdl_{0}_Cache(\"{1}\", obj{2}_Cond);//{3}",
                                 objInfor.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                        else
                        {
                            
                            strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                                     objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                     objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                     objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = {2}_BindDdl_{0}_Cache(\"{1}\", obj{2}_Cond, {4}{5});//{3}",
                                 objInfor.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(), objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
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


        public string Gen_WApi_Js_DdlBindFunction4Page_Load_Cache()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
         
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                 objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                        else
                        {

                            strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                                     objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                     objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                     objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
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

        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4Code_CacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д�������������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}]���������ͣ�[{1}]û�д�������������Ӧ���롣",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
                                objDataTypeAbbrEN.TypeScriptType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                case enumDataTypeAbbr.int_09:
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
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
        public string Gen_WApi_Js_PutDataToClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /* ��������:�ѽ����ϵ��������ݴ����������");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">���ݴ����Ŀ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.PutDataTo{0}Class = function(pobj{2}EN)",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = objEditRegionFldsEx.CtlTypeName,
                CtrlId = objEditRegionFldsEx.CtrlId,
                PropertyName = objEditRegionFldsEx.PropertyName(),
                Comment = objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
            });
            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
     objViewInfoENEx.TabName,
     objEditRegionFldsEx.FldName,
     objEditRegionFldsEx.CtrlId);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
            objViewInfoENEx.TabName,
            objEditRegionFldsEx.FldName,
            objEditRegionFldsEx.CtrlId);
                    break;
            }
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Js_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:������������������ʾ��������");
                strCodeForCs.Append("\r\n ע��:���������������,������һ��������������ϵ��,����Ϊһ��������ֵ,Ȼ����Ϊ����������ֵ");
                strCodeForCs.Append("\r\n  ������������ݿ�ʱ,��Ӧ��һ���ֶ���ǰ,�����ֶ��ں�");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">��ʵ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.GetDataFrom{0}Class = function(pobj{2}EN )",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

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
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = objEditRegionFldsEx.CtlTypeName,
                CtrlId = objEditRegionFldsEx.CtrlId,
                PropertyName = objEditRegionFldsEx.PropertyName(),
                Comment = objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
            });
            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7������checkboxΪѡ��״̬
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8������checkboxΪ��ѡ��״̬
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Js_GetFirstKey()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:�ӽ����б��л�ȡ��һ���ؼ��ֵ�ֵ");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">��ʵ�������</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n <returns>�б�ĵ�һ���ؼ���ֵ</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.GetFirstKey = function() {");
                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(\"��ѡ��һ���ؼ��֣�Ŀǰѡ����:\" + arrSelectedKeys.length + \"���ؼ��֡�\");");
                strCodeForCs.Append("\r\n" + "return \"\";");

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
        public string Gen_WApi_Js_SortBy()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:�ӽ����б��и���ĳһ���ֶ�����");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"strSortByFld\">������ֶ�</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.SortBy = async function(strSortByFld) {");
                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(strSortByFld) >= 0)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(\"Asc\") >= 0)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = \"\" + strSortByFld + \" Desc\";", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = \"\" + strSortByFld + \" Asc\";", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = \"\" + strSortByFld + \" Asc\";", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
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

        public string Gen_WApi_Js_IndexPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* ��������:������ �б�����ת��ĳһҳ");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"intPageIndex\">ҳ���</param>",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.IndexPage = function(intPageIndex)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (intPageIndex == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "intPageIndex = this.objPager.pageCount;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "console.log(\"��ת��\" + intPageIndex + \"ҳ\");");
                         
                //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intPageIndex;");
                strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intPageIndex);");
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "input",
                    CtrlId = "hidCurrPageIndex",
                    PropertyName = "CurrPageIndex",
                    Comment = "���õ�ǰҳ���",
                    DataType = "number"

                });
                strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{1}{2}();",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
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
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�
            //int iDG_Div_Left;
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û��DataGrid����,����DataGrid����û���ֶΡ�����!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///��ʱ����;
            ///�ж�DataGrid�Ƿ���Ҫ����
            //foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            //{
            //    if (objDGRegionFldsEx.IsNeedSort)
            //    {
            //        objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
            //    }
            //}
            try
            {
                ///���ɲ����¼�Ľ������;
                //objViewInfoENEx.objViewRegion_List.Style_Zindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.Style_Left = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.Style_Top = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;


                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  objViewInfoENEx.TabName, intCurrTop);

                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                //{
                    //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    //strCodeForCs.AppendFormat("\r\n" + "<td>");
                    //��Ӳ�div
                    ASPHtmlTableEx objASPNETHtmlTableENEx = clsASPHtmlTableBLEx.GettabGridFunction();
                    ASPRowEx objASPNETRowENEx = clsASPRowBLEx.GetEmptyTr();
                    objASPNETHtmlTableENEx.arrSubAspControlLst2.Add(objASPNETRowENEx);

                    ASPColEx objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //�б����
                    ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx);
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                    //

                    //strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabGridFunction\" style = \"width: 100%; height: 32px\" class = \"msgtable\" >");
                    //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
                    //  objViewInfoENEx.TabName);
                    //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}�б�</asp:label>",
                    //  objViewInfoENEx.objInRelaTab.TabCnName);
                    //strCodeForCs.Append("\r\n" + "</td>");

                    //iDG_Div_Left = 390;//��һ����ť����Ϊ390
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                      || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnAddNewRec4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        //clsInpu
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDetail4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.arrFeatureId.Contains("0142") == true)
                    {
                        //List<ASPHtmlButtonEx> arrAspNetButton4AdjustOrderNum = new List<ASPHtmlButtonEx>();
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoTop();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpMove();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDownMove();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoBottum();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnReOrder();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //foreach (ASPHtmlButtonEx objInfor in arrAspNetButton4AdjustOrderNum)
                        //{
                        //    clsASPHtmlButtonBLEx.GeneCode(objInfor, strCodeForCs);

                        //}
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnExportExcel4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");

                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnExportExcel4Gv\" OnClick = \"btnExportExcel4Gv_Click\" ",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"����Excel\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.IsNeedSetExportFld == true &&
                          objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnSetExportExcel4User();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");

                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnSetExportExcel4User\" OnClick = \"btnSetExportExcel4User_Click\" ",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"100px\" CssClass = \"btn btn-primary btn-sm\" Text = \"���õ����ֶ�\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }

                    //�����
                    //strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    //strCodeForCs.Append("\r\n" + "</table>");
                    objASPNETHtmlTableENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                //}
                //����GridView�Ĵ���;


                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleId_Cache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            ///����Label�Ĵ���;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCodeForCs.ToString();


        }

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڽ���:{0}��,û�����ñ�������,����!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleId_Cache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)����ģʽId:[{0}]û����Ӧ�Ķ�������!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            ///����Label�Ĵ���;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"����\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
                      strTitle, objTitleStyle.ForeColor);
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    strCodeForCs.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":

                    break;
                case "03":
                    strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                      strTitle);
                    strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    //����в�ѯ����
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                        strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɲ�ѯ������ش���
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //�����������ĵı�ǩ����
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleId_Cache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleId_Cache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleId_Cache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleId_Cache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�в�ѯ��������!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);
            strCodeForCs.AppendFormat("\r\n" + "<table class = \"msgtable\" style = \"width: 80%\"> ",
             objViewInfoENEx.TabName, intDivHeight);

            intCurrTop -= 30;//��Ϊ�����ڲ�(div)��
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///����ר�����ڲ�ѯ�Ľ���ؼ��Ĵ���;
            ///
            bool bolIsTrEnd = true;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "<tr>");
                    bolIsTrEnd = false;
                }

                switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBoxNoPosition(objCheckStyle, objQryRegionFldsEx.CtrlId, objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" +
                          GenCombineCtlNoPosition(objLabelStyle_Text,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                          objQryRegionFldsEx.CtrlId));
                        break;
                }

                intZIndex += 1;
                intCurrTop += 28;
                intFieldNum++;
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "</tr>");
                    bolIsTrEnd = true;
                }
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///���ɲ�ѯ��ť�Ĵ���;
            ///
            if (bolIsTrEnd == true)
            {
                strCodeForCs.Append("\r\n" + "<tr>");
                bolIsTrEnd = false;
            }
            strCodeForCs.Append("\r\n" + "<td>");
            ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnQuery();

            objASPNETHtmlButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs); //;, "btnQuery", "��ѯ", "btnQuery_Click"));
            strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");
            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����CheckBox�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objCheckStyle.Style_Zindex = intZIndex + 1;
                objCheckStyle.Style_Left = (int)intCurrLeft;
                objCheckStyle.Style_Top = (int)intCurrTop;

                ///����CheckBox�Ĵ���;
                ///
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //����<�ؼ���ʽStyle>
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.Style_Zindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //����<�ֺ�>��<����>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //����<��ʾ�ı�> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //����<������־>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

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
        /// ����{��Ͽؼ�},����ߵı�ǩ,���ұߵ����������Ŀؼ�
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            objLabelStyle.Style_Zindex = intZIndex + 1;
            objLabelStyle.Style_Left = (int)intCurrLeft;
            objLabelStyle.Style_Top = (int)intCurrTop;
            ///����Label�Ĵ���;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.Style_Zindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.Style_Zindex = intZIndex + 1;
            objGenCtlStyle.Style_Left = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.Style_Left = (int)intCurrLeft + 5;
            objGenCtlStyle.Style_Top = (int)intCurrTop;
            ///�����ұ߿ؼ��Ĵ���;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.Style_Zindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Button�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objButtonStyle.Style_Zindex = intZIndex + 1;
                objButtonStyle.Style_Left = (int)intCurrLeft;
                objButtonStyle.Style_Top = (int)intCurrTop;

                ///����Button�Ĵ���;
                ///
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //����<�ؼ���ʽStyle>
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.Style_Zindex, objButtonStyle.Style_Left,
                  objButtonStyle.Width, objButtonStyle.Height);

                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //����<�ֺ�>��<����>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //����<��ʾ�ı�> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //���ɵ����¼�
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //����<������־>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex += 1;

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
        /// �������ڱ༭�Ĳ�Div���ò���Ա�����
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_WApi_Js_DefDiv4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">ģ̬��Modal������</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///������֤�ؼ�����;
                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType)
                {
                    case "bool":
                        strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
                          objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    case "int":
                    case "short":
                    case "long":
                    case "DateTime":
                    case "double":
                    case "float":
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
                          objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            objEditRegionFldsEx.CtrlId,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //intZIndex += 1;
                //intCurrTop += 25;

            }

            strCodeForCs.Append("\r\n" + " </table>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">�ر�</button>");
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">�ύ����</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ShowData()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n /* ��������:���Ըùؼ��ֵļ�¼������ʾ�ڽ�����,");
                    strCodeForCs.Append("\r\n ������   �������ǰ�ֵ������ؼ���");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n  <param name = \"{0}\">���¼�Ĺؼ���,��ʾ�ñ�ؼ��ֵ�����</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.ShowData = async function({0}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType);
                    strCodeForCs.Append("\r\n" + "        //��������:");
                    strCodeForCs.Append("\r\n" + "        //1�����ؼ����Ƿ�Ϊ�գ�");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.Append("\r\n" + "        //4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "        //5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "        var obj{0}EN = new cls{0}EN();",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const returnBool = await {0}_IsExistAsync({1});",
                        objViewInfoENEx.TabName_In, objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                var strInfo = \"�ؼ���:[\" + {0} + \"] �ļ�¼������!\";",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "            else {");
               
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = \"�����Ӧ�ؼ��ֵļ�¼���ڲ��ɹ�, \" + e+ \".\";");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                        objViewInfoENEx.TabName_In, objKeyField.FldName, objKeyField.PrivFuncName);
                    
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = \"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,\" + e+ \".\";");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");

                    strCodeForCs.AppendFormat("\r\n" + "        this.GetDataFrom{0}Class(obj{0}EN);",
                        objViewInfoENEx.TabName_In);


                    strCodeForCs.Append("\r\n" + "}");
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScriptCSEx_JS4JavaScript));
    
        }
        public override void GetClsName()
        {
            //if (objViewInfoENEx.IsUseCache4List)
            //{
            //    this.ClsName = string.Format("WA_{0}_QUDI_CacheEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WA_{0}_QUDI_Cache", objViewInfoENEx.TabName);

            //    objViewInfoENEx.ClsName = this.ClsName;

            //}
            //else
            //{
            //    this.ClsName = string.Format("WA_{0}_QUDI_JSEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WA_{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.ClsName = this.ClsName;
            //}

            this.ClsName = string.Format("{0}Ex", objViewInfoENEx.ViewName);
            this.BaseClsName = string.Format("{0}", objViewInfoENEx.ViewName);
            objViewInfoENEx.ClsName = this.ClsName;
            
        }
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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
        public string Gen_WApi_Js_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ����¼�¼");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "{0}.prototype.btnCopyRecord_Click = async function() {");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��¡�ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const responseText = await this.CopyRecord(arrKeyIds);");
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"���Ƽ�¼���ɹ�,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /* �����ֶ�ֵ-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.{0}_Click = async function() {{", objInFor.ButtonName);
                    //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��¡�ļ�¼��\");");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    clsvViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("���ܣ������ֶ�ֵ�ĸ�ֵ��ʽ�Ǹ���ֵ����ȱ����Ӧ�Ľ��湦���ֶΣ���ά���������ɴ���");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("���ܣ������ֶ�ֵ�ĸ�ֵ��ʽ�Ǹ���ֵ����ȱ����Ӧ�Ľ��湦���ֶΣ���ά���������ɴ���");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                strCodeForCs.AppendFormat("\r\n" + "let str{0} = $(\"#{1}\").val();",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "let {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "let {0} = $(\"#{1}\").prop(\"checked\");",
                  objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                           
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "let str{0} = $(\"#{1}\").val();",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");

                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.{0}(arrKeyIds);", strFuncName);
                    }
                    if (objViewInfoENEx.IsUseCache4List)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"���ü�¼���ɹ�,\" + e + \".(In {0}_Click())\";",
                        objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
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



        public string Gen_WApi_Js_SetFieldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);

                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /* �����ֶ�ֵ-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExam1TypeId = GetAllCheckedKeysFromGv();
                    //if (lstExam1TypeId == null) return;


                    clsvViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("���ܣ������ֶ�ֵ�ĸ�ֵ��ʽ�Ǹ���ֵ����ȱ����Ӧ�Ľ��湦���ֶΣ���ά���������ɴ���");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                        strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.{0} = async function(arr{1}, {3})",
                                strFuncName,
                                objKeyField.FldName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        if (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "boolean")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                        objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            strCodeForCs.Append("\r\n" + "}");
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.{0} = async function(arr{1})",
                                strFuncName, objKeyField.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "let strMsg = \"û��ѡ���¼�����������ֶ�ֵ!\";");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_GetObjLstBy{1}LstAsync(arr{1});",
objViewInfoENEx.TabName_In, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "console.log('responseText=');");
                    strCodeForCs.Append("\r\n" + "console.log(responseText);");
                    strCodeForCs.Append("\r\n" + "const intCount = 0;");
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  responseText;",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CopyObjTo(objInFor, obj{0}EN);", objViewInfoENEx.TabName_In);


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"���ﲻ��ȷ��ֵΪ�գ�\";",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.FldName,
                                                      objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                    }
                    else
                    {

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                  objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = TransToBool(\"{2}\");",
                                                        objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} =\"{2}\";",
                                    objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "let returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sf_UpdFldSetStr = obj{0}EN.updFldString;//������Щ�ֶα��޸�(���ֶ�)", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await {0}_UpdateRecordAsync(obj{0}EN);", objViewInfoENEx.TabName_In);
                     
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"�޸ļ�¼����\" + e + \". (In {0}())\";", strFuncName);
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "const strInfo = \"���ü�¼�ɹ�!\";");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = \"���ü�¼���ɹ�!\";");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = \"��������\" + intCount + \"����¼!\";");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "console.log('��ɣ�');");
                    if (objViewInfoENEx.IsUseCache4List == true)
                    {
                        if (objViewInfoENEx.objCacheClassifyFld4View == null)
                        {
                            strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName);
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName,
                                 objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                            strCodeForCs.Append("\r\n" + "}");
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"���ü�¼���ɹ�,\" + e+ \".(In {0}())\";", strFuncName);
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
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


        public string Gen_WApi_Js_btnGoTop_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";
                                
                strCodeForCs.Append("\r\n /* �ö�");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.btnGoTop_Click = async function()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {                       
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�ö��ļ�¼��\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName,
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoTopAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName,
                                          objAdjustOrderNum.VarLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoTopAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"�ö���������:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");

                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");
                //strCodeForCs.Append("\r\n" + "}");


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

        public string Gen_WApi_Js_btnUpMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n ����");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.btnUpMove_Click = async function()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {

                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
          objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ���Ƶļ�¼!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_UpMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_UpMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"���Ƽ�¼��������:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");
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

        public string Gen_WApi_Js_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n �ƶ���¼���������ƺ�����");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.MoveRecord = async function(strDirect)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =$('#{1}').val();",
                            objInFor.FldName, objInFor.CtrlId);
                    }
                }
                strCodeForCs.Append("\r\n" + "const strKeyId = clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�ƶ�(\" + strDirect + \")�ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

               
//                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_AdjustOrderNum(strDirect, {2}, strKeyId);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_AdjustOrderNum(strDirect, strKeyId);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"�ƶ�(\" + strDirect + \")��¼��������:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
       
                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetCheckedItemForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncName);

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

        public string Gen_WApi_Js_btnDownMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n ����");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.btnDownMove_Click = async function()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                    
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
                      objInFor.FldName, objInFor.CtrlId.Substring(3));
                    
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ���Ƶļ�¼!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_DownMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_DownMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"���Ƽ�¼��������:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");

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

        public string Gen_WApi_Js_PreCheck4Order()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds_GoTop = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
                if (objFeatureRegionFlds_GoTop == null) return "";
                //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
                IEnumerable<clsvViewFeatureFldsENEx> arrFieldLst_Classify = objViewInfoENEx.arrvViewFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                
                if (string.IsNullOrEmpty(objFeatureRegionFlds_GoTop.ReleFldId))
                {
                    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]������ֶ�Ϊ�գ��������ɡ�Ԥ�캯��(PreCheck4Order)��;",
                        objViewInfoENEx.TabName);
                    return strCodeForCs.ToString();

                }
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n �ƶ���¼���ʱ��Ԥ��麯��");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.PreCheck4Order = function()");
                strCodeForCs.Append("\r\n" + "{");
                if (arrFieldLst_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in arrFieldLst_Classify)
                    {

                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });

                        strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                            objInFor.FldName);

                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}!\";", objInFor.ObjFieldTab().FldName);
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");
                      
                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
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

        public string Gen_WApi_Js_btnGoBottum_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n �õ�");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.btnGoBottum_Click = async function()");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {                 
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�õ׵ļ�¼��\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                  
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},", 
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoBottomAsync(objOrderByData);",
                         objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoBottomAsync(objOrderByData);",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"�õ׳�������:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");
                //strCodeForCs.Append("\r\n" + "}");

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
        public string Gen_WApi_Js_btnReOrder_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";
                                             
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n ����");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "{0}.prototype.btnReOrder_Click = async function()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");

                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_ReOrderAsync(objOrderByData);",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_ReOrderAsync(objOrderByData);",
                   objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"�����������:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
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

        public string Gen_WApi_Js_Code4QueryRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                            objViewInfoENEx.CodeTypeId,
                            enumRegionType.QueryRegion_0001)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_Code4FeatureRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.FeatureRegion_0008)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_Code4ListRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ListRegion_0002)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_Code4EditRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.EditRegion_0003)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }
        public string Gen_WApi_Js_Code4ExcelExportRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ExcelExportRegion_0007)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }
        public string Gen_WApi_JS_btn_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ��ť����,���ڵ���Js������btn_Click");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.btn_Click = function(strCommandName, strKeyId) {{", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {0}();", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommonFunc4Web_js_1.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"Query\":    //��ѯ��¼");
            strCodeForCs.Append("\r\n" + "objPage.btnQuery_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"AddNewRecordWithMaxId\":    //��Ӽ�¼ʹ�����ؼ���");
            strCodeForCs.Append("\r\n" + "ShowDialog('AddWithMaxId');");
            strCodeForCs.Append("\r\n" + "objPage.btnAddNewRecordWithMaxId_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"AddNewRecord\":            //��Ӽ�¼");
            strCodeForCs.Append("\r\n" + "case \"Create\":            //��Ӽ�¼");
            
            strCodeForCs.Append("\r\n" + "objPage.btnAddNewRecord_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"UpdateRecord\":            //�޸ļ�¼");
            strCodeForCs.Append("\r\n" + "case \"Update\":            //�޸ļ�¼");

            strCodeForCs.Append("\r\n" + "const strKeyId = clsCommonFunc4Web_js_1.clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
            strCodeForCs.Append("\r\n" + "if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�޸ĵļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "objPage.btnUpdateRecord_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"CopyRecord\":            //���Ƽ�¼");
            strCodeForCs.Append("\r\n" + "case \"Clone\":            //���Ƽ�¼");

        
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ���Ƶļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnCopyRecord_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"DelRecord\":            //ɾ����¼");
            strCodeForCs.Append("\r\n" + "case \"Delete\":            //ɾ����¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(arrKeyIds.length) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "objPage.btnDelRecord_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"DelRecordBySign\":            //����־ɾ����¼");
            strCodeForCs.Append("\r\n" + "case \"DeleteBySign\":            //����־ɾ����¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ����־ɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnDelRecordBySign_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"UnDelRecordBySign\":            //����־�ָ�ɾ����¼");
            strCodeForCs.Append("\r\n" + "case \"UnDeleteBySign\":            //����־�ָ�ɾ����¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�ָ�ɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnUnDelRecordBySign_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"GoTop\":            //�ö���¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�ö��ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnGoTop_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"GoBottum\":            //�Ƶ׼�¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�Ƶ׵ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnGoBottum_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"UpMove\":            //���Ƽ�¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ���Ƶļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnUpMove_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"DownMove\":            //���Ƽ�¼");

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ���Ƶļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "objPage.btnDownMove_Click();");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"ReOrder\":            //�����¼");
            strCodeForCs.Append("\r\n" + "objPage.btnReOrder_Click();");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = '����:' + strCommandName + \"�ں���({0}.btn_Click)��û�б�����\";", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"ExportExcel\":            //����Excel");
            strCodeForCs.Append("\r\n" + "alert(\"����Excel���ܻ�û�п�ͨ��\");");
            //strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "}");
            

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }
        
    }
}
