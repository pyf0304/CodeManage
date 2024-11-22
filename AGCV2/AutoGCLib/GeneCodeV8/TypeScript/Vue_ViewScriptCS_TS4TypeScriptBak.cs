using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using TzAdvancedLib;

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
    partial class Vue_ViewScriptCS_TS4TypeScriptBak : clsGeneCodeBase
    {
        //private string objPrjTabENEx = "";
        private string strMapFuncCode = "";
        private string strMapFuncCode4ExcelExport = "";
        private List<string> arrTabId4MapFunc = null;// new List<string>();
        private bool bolIsUseFunc = false;
        private bool bolIsUseFunc4ExcelExport = false;
        private string strTabName_Out4ListRegion = "";

        private string strTabId_Out4ListRegion = "";

        private string strTabName_Out4ExportExcel = "";
        private string strTabId_Out4ExportExcel = "";
        private string strFuncName4BindGv = "";
        private List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        private string strVarDef4ViewCacheFld = "";
        private string strVarDef4ViewCacheFld2 = "";

        //private string strVarDef4GivingValue = "";

        int intZIndex;      ///�ؼ��������
        float intCurrLeft;  ///�ؼ�����߿�;
        float intCurrTop;  ///�ؼ��Ķ����;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region ���캯��
        public Vue_ViewScriptCS_TS4TypeScriptBak()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public Vue_ViewScriptCS_TS4TypeScriptBak(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Vue_ViewScriptCS_TS4TypeScriptBak(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();
            if (thisCacheClassifyFld4View != null)
            {
                strVarDef4ViewCacheFld = string.Format("{0}.{1}_Cache", objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            if (thisCacheClassifyFld4View2 != null)
            {
                strVarDef4ViewCacheFld2 = string.Format("{0}.{1}_Cache", objViewInfoENEx.ClsName, thisCacheClassifyFld4View2.FldName);
            }
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

        public string Gen_Vue_Ts_Page_Load()
        {
            if (objViewInfoENEx.IsUseCache4List) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** ��������:ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async Page_Load()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Page_Load.name;");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����Page_Load�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //��������
                //strCodeForCs.Append("\r\n" + "//��������");
                //�����¼�����
                strCodeForCs.Append("\r\n" + "this.SetEventFunc();");

                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();
                var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null
                    && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true
                    && objViewRegion.IsDispInViewInfo(objViewInfoENEx) == true)
                {
                    strCodeForCs.Append("\r\n // Ϊ��ѯ����������");
                    strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4QueryRegion();", objViewInfoENEx.ClsName);
                }


                strCodeForCs.Append("\r\n" + Gen_Vue_Ts_DdlBind4ViewFeatureInPage_Load());


                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                        objViewInfoENEx.FirstSortField, strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
               
                strCodeForCs.Append("\r\n" + "if (this.bolIsInitShow == false)  //");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.objPager.InitShow(this.divName4Pager);");
                strCodeForCs.Append("\r\n" + "this.bolIsInitShow = true;  //");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "//2����ʾ�������ı�������GridView��");

                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ҳ���������ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
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

        public string Gen_Vue_Ts_Page_Load_Cache()
        {
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField_TS).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField_TS).First();
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** ��������:ҳ�浼��,��ҳ�濪ʼ����ʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async Page_Load_Cache()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Page_Load_Cache.name;");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����Page_Load�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //��������
                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();

                var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null
                    && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true
                    && objViewRegion.IsDispInViewInfo(objViewInfoENEx) == true)
                {
                    strCodeForCs.Append("\r\n // Ϊ��ѯ����������");
                    strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4QueryRegion();", objViewInfoENEx.ClsName);
                }
                strCodeForCs.Append("\r\n" + Gen_Vue_Ts_DdlBind4ViewFeatureInPage_Load());

                //�����¼�����
                strCodeForCs.Append("\r\n" + "this.SetEventFunc();");

                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                        objViewInfoENEx.FirstSortField, strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
                
                strCodeForCs.Append("\r\n" + "if (this.bolIsInitShow == false)  //");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.objPager.InitShow(this.divName4Pager);");
                strCodeForCs.Append("\r\n" + "this.bolIsInitShow = true;  //");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "//2����ʾ�������ı�������GridView��");

                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ҳ���������ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
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


        public string Gen_Vue_Ts_DdlBind()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //���ɽ��б���;

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName != "DropDownList") continue;

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

                                strCodeForCs.AppendFormat("\r\n /** ��������:ddl{0}�ĺ�����", objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n" + " **/");
                                strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objEditRegionFldsEx.FldName);
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
                                strCodeForCs.Append("\r\n /**");
                                strCodeForCs.AppendFormat("\r\n * Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                                  strDs_TabName);
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n * @returns ��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable");
                                strCodeForCs.Append("\r\n **/");
                                strCodeForCs.AppendFormat("\r\n" + "public BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                  strDs_TabName, strDS_DataValueField, strDS_DataTextField, objEditRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{1}.name;", strDS_DataValueField);

                                strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} �����ڣ�\", ddl{1});",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                strCodeForCs.Append("\r\n" + "try");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField);

                                //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindDdl_{0}!\");", strDS_DataValueField);

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "catch (e)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�������򲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "});");
                                strCodeForCs.Append("\r\n" + "}");


                                break;
                            case "03": ///�б�������ԴSQL��;
                                strCodeForCs.Append("\r\n /**");
                                strCodeForCs.AppendFormat("\r\n * Ϊ�������ȡ����,��Sql��:[{0}]�л�ȡ",
                                   objEditRegionFldsEx.Ds_SQLStr);
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n * @returns ��ȡ�Զ����Sql�������е����м�¼��¼��DataTable");
                                strCodeForCs.Append("\r\n **/");

                                strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Get{0}.name;", objEditRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                                //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}_GetSpecSQLObj();", objViewInfoENEx.TabName);

                                strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                objEditRegionFldsEx.Ds_SQLStr);
                                strCodeForCs.Append("\r\n" + "return objDT;");
                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.Append("\r\n /** �󶨻���Web��������");
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                                strCodeForCs.Append("\r\n" + " **/");
                                strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objEditRegionFldsEx.FldName);
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
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_BindDdl4QueryRegio1nBak()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Query = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            try
            {
                strCodeForCs.Append("\r\n /** ��������:Ϊ��ѯ����������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4QueryRegion()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;");

                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");

                List<string> arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    //if (objInfor.Ds_TabName == objViewInfoENEx.TabName) continue;


                    if (objInfor.CsType == "bool") continue;
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    arrTabName.Add(objInfor.Ds_TabName);
                    strCodeForCs.AppendFormat("\r\n" + " var obj{0}_Cond:cls{0}EN = new cls{0}EN();//{1}",
                                    objInfor.Ds_TabName,
                                    clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId));
                }


                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    clsFieldTabEN objFieldTab_Cond = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objQryRegionFldsEN.Ds_CondFieldId, objInfor.objQryRegionFldsEN.PrjId);
                    clsFieldTabEN objFieldTab_Sort = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objQryRegionFldsEN.Ds_SortFieldId, objInfor.objQryRegionFldsEN.PrjId);
                    string strVar4Cond = "";
                    string strVar4Sort = "";
                    string strVar4Cond_2 = "";
                    string strVar4Sort_2 = "";
                    if (objFieldTab_Cond != null)
                    {
                        strVar4Cond = objFieldTab_Cond.PrivFuncName();
                        strVar4Cond_2 = ", " + strVar4Cond;
                    }
                    if (objFieldTab_Sort != null)
                    {
                        strVar4Sort = objFieldTab_Sort.PrivFuncName();
                        strVar4Sort_2 = ", " + strVar4Sort;
                    }
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objVarManage.AddVariable(new clsVariable(strVar4Cond)) == true)
                        {
                            string strVarDefStr = "";
                            if (thisCacheClassifyFld4View != null)
                            {
                                if (thisCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                }
                            }
                            if (thisCacheClassifyFld4View2 != null)
                            {
                                if (thisCacheClassifyFld4View2.FldName == objFieldTab_Cond.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                }
                            }


                            strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                            //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }

                        if (objVarManage.AddVariable(new clsVariable(strVar4Sort)) == true)
                        {
                            string strVarDefStr = "";
                            if (thisCacheClassifyFld4View != null)
                            {
                                if (thisCacheClassifyFld4View.FldName == objFieldTab_Sort.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", "");
                                }
                            }
                            if (thisCacheClassifyFld4View2 != null)
                            {
                                if (thisCacheClassifyFld4View2.FldName == objFieldTab_Sort.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", "");
                                }
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                            //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }


                        if (objInfor.objFieldTab_CacheClassify() == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond {6} {7});//{4}",
                                            objInfor.FldName,
                                            objInfor.objFieldTab_ValueField.FldName,
                                            objInfor.CtrlId,
                                            objInfor.Ds_TabName,
                                            clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                            objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                        strVar4Cond_2,
                                        strVar4Sort_2);
                        }
                        else
                        {

                            string strVariableName = string.Format("{0}{2}",
                                            objInfor.objFieldTab_CacheClassify().PrivFuncName(),
                                            objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                                            objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {
                                string strVarDefStr = "";
                                if (thisCacheClassifyFld4View != null)
                                {
                                    if (thisCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                    else
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                }
                                if (thisCacheClassifyFld4View2 != null)
                                {
                                    if (thisCacheClassifyFld4View2.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                    else
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                }
                                strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                                //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);

                                strCodeForCs.AppendFormat("\r\n" + "//var {0}{2} = \"\";//���������ֶ�",
                                    objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }
                            //strCodeForCs.AppendFormat("\r\n" + "var {0}{2} = \"\";",
                            //         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                            //         objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                            //         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            string strConditionFieldName = "";
                            string strConditionFieldName_2 = "";
                            if (objInfor.objFieldTab_ConditionField != null)
                            {
                                strConditionFieldName = string.Format("{0}{1}", objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                                strConditionFieldName_2 = string.Format(", {0}{1}", objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }
                            if (strConditionFieldName.Replace("_q", "") == strVar4Cond)
                            {
                                strVar4Cond_2 = "";
                            }
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond {5} {6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                                objInfor.CtrlId,
                                objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         strConditionFieldName_2,
                                strVar4Cond_2,
                                strVar4Sort_2);
                        }
                    }
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

        public string Gen_Vue_Ts_BindDdl4QueryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Query
                = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** ��������:Ϊ��ѯ����������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4QueryRegion()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    try
                    {
                        Tuple<string, string> tup = this.Gen_Vue_Ts_DefineVar4Ddl(strCodeForCs, objInfor, objVarManage);
                        //
                        string strVar4Cond = tup.Item1;
                        string strVar4Cond_2 = tup.Item2;

                        if (objInfor.CsType == "bool")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                     objInfor.CtrlId);
                        }
                        else
                        {
                            if (objInfor.objFieldTab_CacheClassify() == null)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "await this.SetDdl_{1}({4});//{3}",
                                                objInfor.FldName,
                                                objInfor.FldName,
                                                objInfor.CtrlId,
                                                clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                                strVar4Cond);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "await this.SetDdl_{1}({4});//{3}",
                                     objInfor.FldName,
                                     objInfor.FldName,
                                    objInfor.CtrlId,
                                     clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                    objInfor.objFieldTab_CacheClassify().PrivFuncName());
                            }
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
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

        public Tuple<string, string> Gen_Vue_Ts_DefineVar4Ddl(StringBuilder strCodeForCs, ASPDropDownListEx objInfor, clsVarManage objVarManage)
        {
            clsFieldTabEN objFieldTab_Cond = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objQryRegionFldsEN.Ds_CondFieldId, objInfor.objQryRegionFldsEN.PrjId);

            string strVar4Cond = "";
            string strVar4Cond_2 = "";
            if (objFieldTab_Cond != null && objInfor.objFieldTab_CacheClassify() != null)
            {

                {
                    strVar4Cond = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                    strVar4Cond_2 = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                    if (objVarManage.AddVariable(new clsVariable(objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType)) == true)
                    {

                        //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                        if (thisCacheClassifyFld4View != null && thisCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                        {
                            string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                            strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                        }
                        else
                        {
                            string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                        }
                    }

                }
                if (objFieldTab_Cond.PrivFuncName() != objInfor.objFieldTab_CacheClassify().PrivFuncName())
                {
                    if (objInfor.objTabFeatureFlds.ValueGivingModeId == enumValueGivingMode.GivenValue_02
                      || string.IsNullOrEmpty(objInfor.objTabFeatureFlds.ValueGivingModeId) == true)
                    {
                        strVar4Cond = objFieldTab_Cond.PrivFuncName();
                        strVar4Cond_2 += ", " + objFieldTab_Cond.PrivFuncName();
                        if (objVarManage.AddVariable(new clsVariable(strVar4Cond, objFieldTab_Cond.ObjDataTypeAbbr().TypeScriptType)) == true)
                        {

                            //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                            if (thisCacheClassifyFld4View != null && thisCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                            {
                                string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                                strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                            }
                            else
                            {
                                string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                            }
                        }
                    }
                }
            }
            else if (objFieldTab_Cond != null && objInfor.objFieldTab_CacheClassify() == null)
            {

                if (string.IsNullOrEmpty(objInfor.ValueGivingModeId) == true
                    || objInfor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                {

                    strVar4Cond = objFieldTab_Cond.PrivFuncName();
                    strVar4Cond_2 = strVar4Cond;
                    if (objVarManage.AddVariable(new clsVariable(strVar4Cond, objFieldTab_Cond.ObjDataTypeAbbr().TypeScriptType)) == true)
                    {

                        //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                        if (thisCacheClassifyFld4View != null && thisCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                        {
                            string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                            strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View,
                                thisCacheClassifyFld4View.ObjFieldTabENEx.PrivFuncName(), this.ClsName);
                        }
                        else
                        {
                            string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                        }
                    }
                }
            }
            else if (objFieldTab_Cond == null && objInfor.objFieldTab_CacheClassify() != null)
            {
                strVar4Cond = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                strVar4Cond_2 = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                if (objVarManage.AddVariable(new clsVariable(objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType)) == true)
                {

                    //���ɻ�������ֶεļ����룬����Ƿ񱻸���ȷֵ
                    if (thisCacheClassifyFld4View != null && thisCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                    {
                        string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                        strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                        clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, thisCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                    }
                    else
                    {
                        string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");

                        strCodeForCs.AppendFormat("\r\n" + "{0}  //���������ֶ�", strVarDefStr);
                    }
                }
            }
            else
            {

            }


            //if (objVarManage.AddVariable(new clsVariable(strVar4Cond)) == true)
            //{
            //    string strVarDefStr = "";
            //    if (thisCacheClassifyFld4View != null)
            //    {
            //        if (thisCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
            //        {
            //            strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);
            //        }
            //        else
            //        {
            //            strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
            //        }
            //    }                               
            //}

            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strVar4Cond_2);

            return tup;
        }



        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_SetBindDdl4QryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlTypeAbbr.DropDownList_06, enumCtlTypeAbbr.DropDownList_Bool_18 };
                IEnumerable<clsQryRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet
                    .Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId) && x.InUse == true);
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4Bool_TS());
                    }
                    else
                    {
                        strCodeForCs.Append(objInfor.GC_SetBindDdl_TS4QryRegion());
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



        public string Gen_Vue_Ts_DdlBind4QueryRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName != "DropDownList") continue;

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

                                strCodeForCs.AppendFormat("\r\n /** ��������:ddl{0}�ĺ�����", objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n" + " **/");

                                strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objQryRegionFldsEx.FldName);
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

                                strCodeForCs.Append("\r\n /**");
                                strCodeForCs.AppendFormat("\r\n * Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                                  strDs_TabName);
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n * @returns ��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable");
                                strCodeForCs.Append("\r\n **/");
                                strCodeForCs.AppendFormat("\r\n" + "public BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                  strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", strDS_DataValueField);
                                strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} �����ڣ�\", ddl{1});",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                strCodeForCs.Append("\r\n" + "try");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField);

                                //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                    strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindDdl_{0}!\");", strDS_DataValueField);

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "catch (e)");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨲�ѯ�������򲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "});");
                                strCodeForCs.Append("\r\n" + "}");


                                break;
                            case "03": ///�б�������ԴSQL��;
                                strCodeForCs.Append("\r\n /**");
                                strCodeForCs.AppendFormat("\r\n * Ϊ�������ȡ����,��Sql��:[{0}]�л�ȡ",
                                   objQryRegionFldsEx.Ds_SQLStr);
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n * @returns ��ȡ�Զ����Sql�������е����м�¼��¼��DataTable");
                                strCodeForCs.Append("\r\n **/");

                                strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Get{0}.name;",  objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                                //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}_GetSpecSQLObj();", objViewInfoENEx.TabName);

                                strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                objQryRegionFldsEx.Ds_SQLStr);
                                strCodeForCs.Append("\r\n" + "return objDT;");
                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.Append("\r\n /** �󶨻���Web��������");
                                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                strCodeForCs.Append("\r\n * @param objDDL:��Ҫ�󶨵�ǰ���������");
                                strCodeForCs.Append("\r\n" + " **/");

                                strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objQryRegionFldsEx.FldName);
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
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            string strCacheClassifyFldName4View2 = "";
            if (thisCacheClassifyFld4View != null)
            {
                strCacheClassifyFldName4View = thisCacheClassifyFld4View.FldName;
            }
            if (thisCacheClassifyFld4View2 != null)
            {
                strCacheClassifyFldName4View2 = thisCacheClassifyFld4View2.FldName;
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {


                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlTypeAbbr.DropDownList_06, enumCtlTypeAbbr.DropDownList_Bool_18 };

                //�ӽ��湦���ֶ��л�ȡ�������ֶ�

                IEnumerable<clsvViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrvViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    string strCtrlId = objInfor.CtrlId;
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl4WA_TS(objVarManage, strCacheClassifyFldName4View, strVarDef4ViewCacheFld, objInfor.objFieldTab_CacheClassify()));
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


        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            var objCodeType = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            //���û���������;
            if (objViewInfoENEx.arrQryRegionFldSet == null && objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("����Ҫ���ɴ��롣��ǰ��ѡ��������:{0},����:{1}.�ڸý�����û�в�ѯ������б���������!",
                    strViewName, objCodeType.CodeTypeName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},����:{1}.�ڸý�����û�в�ѯ��������!", strViewName, objCodeType.CodeTypeName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},,����:{1}.�ڸý�����û��DataGrid����,����DataGrid����û���ֶΡ�����!", strViewName, objCodeType.CodeTypeName);
                throw new clsDbObjException(sbMessage.ToString());
            }


            if (objViewInfoENEx.arrDGRegionFldSet.Where(x => x.IsUseFunc == true).Count() > 0)
            {
                this.bolIsUseFunc = true;
            }

            if (objViewInfoENEx.objViewRegion_ExportExcel == null)
            {

            }
            else
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet.Where(x => x.IsUseFunc == true).Count() > 0)
                {
                    this.bolIsUseFunc4ExcelExport = true;
                }
                strTabId_Out4ExportExcel = objViewInfoENEx.objViewRegion_ExportExcel.TabId;
                strTabName_Out4ExportExcel = clsPrjTabBL.GetNameByTabId_Cache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);
            }
            strTabName_Out4ListRegion = clsPrjTabBL.GetNameByTabId_Cache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
            strTabId_Out4ListRegion = objViewInfoENEx.objViewRegion_List.TabId;
            if (bolIsUseFunc)
            {
                strFuncName4BindGv = string.Format("BindGv_{0}4Func", strTabName_Out4ListRegion);
            }
            else
            {
                if (objViewInfoENEx.IsUseCache4List)
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}_Cache", strTabName_Out4ListRegion);
                }
                else
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}", strTabName_Out4ListRegion);
                }
            }
         
            string strFuncName = "";
            string strTemp = ""; ///��ʱ����;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleId_Cache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            //if (objViewInfoENEx.IsUseCache4List)
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_Cache", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_Cache.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_TS.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}

            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", objViewInfoENEx.ClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

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
                arrTabId4MapFunc = new List<string>();
                strFuncName = "FuncMap";
                strMapFuncCode = Gen_Vue_Ts_FuncMap();
                strFuncName = "FuncMap4ExcelExport";
                strMapFuncCode4ExcelExport = Gen_Vue_Ts_FuncMap4ExcelExport();
                //������ʼ
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx));

                strCodeForCs.AppendFormat("\r\n" + "import $ from \"jquery\";");

                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);
                foreach (var objInFor in arrImportClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClassName,
                        objInFor.FilePath);
                }

                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.Append("\r\n" + "* ����һ�����ڵ���Excel�ĺ��������ڵ���js�˵ĵ���Excel��");
                strCodeForCs.Append("\r\n" + " **/");

                strCodeForCs.AppendFormat("\r\n" + "declare function exportSpecialExcel_pyf(arrData:any, strFileName:string): void;", objViewInfoENEx.TabName_In);


                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* ����һ���Ѿ��������ط�������ڵı���strUrl_Session_SetString��");
                //strCodeForCs.Append("\r\n" + "* ���ڶ��崦��Session-����String�����ĵ�ַ");
                //strCodeForCs.Append("\r\n" + " **/");
                //strCodeForCs.Append("\r\n" + "declare let strUrl_Session_SetString: string;");
                //strCodeForCs.Append("\r\n" + "declare let strUrl_Session_GetString: string;");


                strCodeForCs.AppendFormat("\r\n /** {0} ��ժҪ˵��������Q�����ѯ,U�����޸�",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class {0} extends clsOperateList", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "public static objPage_CRUD: {0};", objViewInfoENEx.ClsName);
                List<string> arrVarName = new List<string>();

                if (thisCacheClassifyFld4View != null)
                {
                    var strVarName = string.Format("{0}_Cache", objViewInfoENEx.objCacheClassifyFld4View_TS.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache = \"\";//��������ֶ�",
                        thisCacheClassifyFld4View.FldName);
                    arrVarName.Add(strVarName);
                }
                if (thisCacheClassifyFld4View2 != null)
                {
                    var strVarName = string.Format("{0}_Cache", objViewInfoENEx.objCacheClassifyFld4View2_TS.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache = \"\";//��������ֶ�2",
                        thisCacheClassifyFld4View2.FldName);
                    arrVarName.Add(strVarName);
                }

                List<string> arrFldName4StaticKeyId = new List<string>();
                var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);
                if (objFeatureRegionFlds_Detail != null && objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                    {
                        arrFldName4StaticKeyId.Add(objKeyField.FldName);
                    }
                }
                List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
                var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

                if (objFeatureRegionFlds_Update != null && objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                    {
                        arrFldName4StaticKeyId.Add(objKeyField.FldName);
                    }
                }
                arrFldName4StaticKeyId.ForEach(x =>
                {
                    string strDefaValue = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue;
                    if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";
                var strVarName = string.Format("{0}_Static", x);
                    if (arrVarName.Contains(strVarName) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public static {0}: {1} = {2};//��̬�ؼ���",
                       strVarName,
                       objKeyField.TypeScriptType, strDefaValue);
                        arrVarName.Add(strVarName);
                    }
                });

                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        string strInitValue = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                            if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                            {
                                strInitValue = objVar.InitValue;
                            }
                            else
                            {
                                strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                            }
                        }
                        if (arrVarName.Contains(strVarName) == false && string.IsNullOrEmpty(strVarName) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};//��ѯ����̬�������",

                                    strVarName,
                                    objInFor.ObjFieldTabENEx.TypeScriptType,
                                    strInitValue);
                            arrVarName.Add(strVarName);
                        }
                    }
                }
                if (objViewInfoENEx.arrEditRegionFldSet != null)
                {
                    var arrEditRegionFlds = objViewInfoENEx.arrEditRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                    if (arrEditRegionFlds.Count() > 0)
                    {

                        foreach (var objInFor in arrEditRegionFlds)
                        {
                            string strVarName = "";
                            string strInitValue = "";
                            var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                            if (objVar != null)
                            {
                                strVarName = objVar.VarExpression;
                                if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                                {
                                    strInitValue = objVar.InitValue;
                                }
                                else
                                {
                                    strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                                }
                            }
                            if (arrVarName.Contains(strVarName) == false && string.IsNullOrEmpty(strVarName) == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};//�༭����̬�������",

                                        strVarName,
                                        objInFor.ObjFieldTabENEx.TypeScriptType,
                                        strInitValue);
                                arrVarName.Add(strVarName);
                            }
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "public divName4Query = \"divQuery\";  //��ѯ���Ĳ�Id");

                strCodeForCs.Append("\r\n" + "public divName4Function = \"divFunction\";  //�������Ĳ�Id");
                strCodeForCs.Append("\r\n" + "public divName4Layout = \"divLayout\";  //���沼�ֵĲ�Id");
                strCodeForCs.Append("\r\n" + "constructor() {");
                //strCodeForCs.Append("\r\n" + "super();");
                strCodeForCs.AppendFormat("\r\n" + "{0}.objPage_CRUD = this;", objViewInfoENEx.ClsName);

                strCodeForCs.Append("\r\n" + "}");

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "label",
                    CtrlId = string.Format("lblViewTitle", strTabName_Out4ListRegion),
                    PropertyName = string.Format("ViewTitle", strTabName_Out4ListRegion),
                    Comment = "���ý������-�൱ʹ��ViewState����",
                    DataType = "string",
                    ParentDivName = "this.divName4Layout"
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "label",
                    CtrlId = string.Format("lblViewTitle", strTabName_Out4ListRegion),
                    PropertyName = string.Format("ViewTitle", strTabName_Out4ListRegion),
                    Comment = "���ý������",
                    DataType = "string",
                    ParentDivName = "this.divName4Layout"
                });


                //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                //{
                //    OperateType = "set",
                //    ControlType = "input",
                //    CtrlId = string.Format("h1idSort{0}By", strTabName_Out4ListRegion),
                //    PropertyName = string.Format("h1idSort{0}By", strTabName_Out4ListRegion),
                //    Comment = "���������ֶ�-�൱ʹ��ViewState����",
                //    DataType = "string",
                //    ParentDivName = "this.divName4Layout"
                //});

                //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                //{
                //    OperateType = "get",
                //    ControlType = "input",
                //    CtrlId = string.Format("h1idSort{0}By", strTabName_Out4ListRegion),
                //    PropertyName = string.Format("h1idSort{0}By", strTabName_Out4ListRegion),
                //    Comment = "���������ֶ�",
                //    DataType = "string",
                //    ParentDivName = "this.divName4Layout"
                //});


                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ÿҳ��¼��������չ������޸�");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get pageSize():number {");
                strCodeForCs.Append("\r\n" + "return 5;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "public recCount = 0;");

                strCodeForCs.Append("\r\n" + "");

                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //          objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, 
                //    new VFunction4GeneCodeComparer());                
                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.FuncName4Code);


                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    //if (strFuncName.IndexOf("TS_ScriptCS") > 0)
                    //{
                    //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                    //if (strFuncName4Code.Contains("AddNew") == true
                    //    || strFuncName4Code.Contains("Update") == true
                    //    || strFuncName4Code.Contains("GetObjByKey") == true)
                    //{
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    //string strSource = string.Format("ac{0}_UnitTest", objViewInfoENEx.TabName);
                    //string strTarget = string.Format("ac{0}_UTScript", objViewInfoENEx.TabName);

                    //strTemp = strTemp.Replace(strSource, strTarget);
                    //}
                    //else
                    //{
                    //    strTemp = "";
                    //}
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, "this.divName4Query");
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

        public class PropertyDef4GCComparer : IEqualityComparer<clsPropertyDef4GC>
        {
            public bool Equals(clsPropertyDef4GC t1, clsPropertyDef4GC t2)
            {
                return (t1.OperateType == t2.OperateType && t1.PropertyName == t2.PropertyName);
            }
            public int GetHashCode(clsPropertyDef4GC t)
            {
                return t.ToString().GetHashCode();
            }
        }

        public void Gen_Vue_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            string strIsStatic = "";
            if (x.IsStatic) strIsStatic = "static";
            switch (x.OperateType)
            {
                case "get":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":


                            if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "var str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            }
                            //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "button":

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":

                            if (x.DataType == "boolean")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                            }
                            else if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//������ڣ�ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "CacheClassifyField_TS":
                            strCodeForCs.Append("\r\n" + "//��������ֶ�(CacheClassifyField_TS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//������ڣ�ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//��Ը���ֵ(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//������ڣ�ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return Number(strValue);");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return 0;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return \"\";");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                    }
                    break;
                case "set":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);


                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "Label":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//�������(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//������ڣ�ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            break;
                        case "CacheClassifyField_TS":
                            strCodeForCs.Append("\r\n" + "//��������ֶ�(CacheClassifyField_TS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//������ڣ�ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//��Ը���ֵ(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//������ڣ�ֱ�ӷ���");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                    }
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");

        }

        public string Gen_Vue_Ts_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** ��ʾ{0}�������������ֵ", strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:��ʾ����");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ObjLst:��Ҫ�󶨵Ķ����б�",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}(divContainer: string, arr{0}ObjLst: Array<cls{0}EN>) ",
                strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}.name;", strTabName_Out4ListRegion);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "const o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}�����ڣ�\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "var sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "var sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"���Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortBy: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;

                string strSortBy = "";

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName) == false)
                    {
                        strSortBy = objDGRegionFldsENEx.DataPropertyName_FstLcase();
                    }
                    else
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldId_Cache(objDGRegionFldsENEx.FldId, objDGRegionFldsENEx.PrjId);
                        if (objFieldTab != null)
                        {
                            strSortBy = objFieldTab.PropertyName();
                        }
                    }
                }
                else
                {
                    strSortBy = objDGRegionFldsENEx.SortExpression_FstLcase();
                }

                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.DataPropertyName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}EN.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.FldName);
                }
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", objDGRegionFldsENEx.SortExpression_FstLcase());
                }
                else
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.DataPropertyName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}EN.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.FldName);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
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
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "text: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btn_Click('DelRecordInTab', '${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "text: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnDetailRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnSelectRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "await clsCommFunc4Web.BindTabV4(o, arr{0}ObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                strTabName_Out4ListRegion, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            //strCodeForCs.Append("\r\n" + "this.objPager.ShowPager();");
            strCodeForCs.Append("\r\n" + "this.objPager.ShowPagerV2(this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_BindTab4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc == false) return "";

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** ��ʾ{0}�������������ֵ", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:��ʾ����");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:��Ҫ�󶨵Ķ����б�",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}4Func(divContainer: string, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}4Func.name;", strTabName_Out4ListRegion);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "const o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}�����ڣ�\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "var sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "var sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"���Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortBy: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;
                string strFldName4Bind = objDGRegionFldsENEx.FldName;
                if (objDGRegionFldsENEx.IsUseFunc)
                {
                    strFldName4Bind = objDGRegionFldsENEx.DataPropertyName;
                }
                string strSortBy = objDGRegionFldsENEx.SortExpression;

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName) == false)
                    {
                        strSortBy = objDGRegionFldsENEx.DataPropertyName_FstLcase();
                    }
                    else
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldId_Cache(objDGRegionFldsENEx.FldId, objDGRegionFldsENEx.PrjId);
                        if (objFieldTab != null)
                        {
                            strSortBy = objFieldTab.PropertyName();
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.DataPropertyName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}EN.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.FldName);
                }
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", objDGRegionFldsENEx.SortExpression_FstLcase());
                }
                else
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.DataPropertyName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}EN.con_{1},", strTabName_Out4ListRegion, objDGRegionFldsENEx.FldName);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
           
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //��DG���Ƿ����޸İ�ť
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "text: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btn_Click('DelRecordInTab', '${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "text: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnDetailRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnSelectRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "await clsCommFunc4Web.BindTabV4(o, arr{0}ExObjLst, arrDataColumn, cls{0}EN.con_{1}, this); ",
                strTabName_Out4ListRegion, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + "this.objPager.ShowPagerV2(this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* ��ʾSession ����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async Demo_Session()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Demo_Session.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//����Session");
            strCodeForCs.Append("\r\n" + "var strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSessionAsync(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//��ȡSession");
            strCodeForCs.Append("\r\n" + "var strUserId_Value1 = await this.GetSessionAsync(\"UserId\");");
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//��ȡSession����2��ֱ�Ӷ�ȡҳ���е�hidUserId");
            //          strCodeForCs.Append("\r\n" + "var strUserId_Value2 = $('#hidUserId').val();");
            strCodeForCs.Append("\r\n" + "var strUserId_Value2 = this.hidUserId;");


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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ʾSession���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_SetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* ����Session");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param Key:�ؼ���");
            strCodeForCs.Append("\r\n * @param Value:ֵ");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public SetSessionAsync(Key: string, Value: string): Promise<void> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetSessionAsync.name;",
            objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_SetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "Value: Value");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data:any) {");
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");


            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_GetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* ��ȡSession �ؼ��ֵ�ֵ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param Key:�ؼ���");
            strCodeForCs.Append("\r\n * @returns ֵ");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public GetSessionAsync(Key: string): Promise<string> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetSessionAsync.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_GetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");

            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"������󣡷������粻�ɹ���\");");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_SetKeyReadOnly()
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
                        strCodeForCs.Append("\r\n /**");
                        strCodeForCs.Append("\r\n * ���û��Զ���ؼ��У����ùؼ��ֵ�ֵ���Ƿ�ֻ��");
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n * @param bolReadonly:�Ƿ�ֻ��");
                        strCodeForCs.Append("\r\n **/");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "const strThisFuncName = this.SetKeyReadOnly.name;");
                        //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

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

        public string Gen_Vue_Ts_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //����˽�д���;
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * ����û��Զ���ؼ��У����пؼ���ֵ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strThisFuncName = this.Clear.name;");
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;

                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                            Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "Clear()"),
                            DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = "this.divName4Edit"
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
                                    objEditRegionFldsEx.PropertyName());
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.PropertyName(),
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
                                    objEditRegionFldsEx.PropertyName(), strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objEditRegionFldsEx.PropertyName(), objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objEditRegionFldsEx.PropertyName(), strInitValue);
                                break;
                        }
                    }
                    catch (Exception objException)
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

        public string Gen_Vue_Ts_CopyRecord()
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
                strCodeForCs.Append("\r\n /** ���Ƽ�¼");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async CopyRecord(arr{0}: Array<string>) {{", objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "const strThisFuncName = this.CopyRecord.name;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstBy{1}LstAsync(arr{1});",
                    objViewInfoENEx.TabName_In, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "let intCount = 0;");

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
                    if (objNameField != null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = 'C_' + objInFor.{0};", objNameField.PropertyName());
                    }
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
                {
                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // ��:{0}��������ǰ׺���������ñ���û��һ����ص�ǰ׺�ֶΡ����飡(In {1})",
                                objViewInfoENEx.TabName, clsStackTrace.GetCurrClassFunction());

                        strCodeForCs.AppendFormat("\r\n" + "const strMaxStrId = await {0}_GetMaxStrIdByPrefixAsync(\"\");",
                           objViewInfoENEx.TabName_In);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const strMaxStrId = await {0}_GetMaxStrIdByPrefixAsync(objInFor.{1});",
                            objViewInfoENEx.TabName_In, objPrefixField.PropertyName());
                    }

                    strCodeForCs.Append("\r\n" + "console.log('strMaxStrId=' + strMaxStrId);");
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = strMaxStrId;", objKeyField.PropertyName());
                    if (objNameField != null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = 'C_' + objInFor.{0};", objNameField.PropertyName());
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {0}_AddNewRecordAsync(objInFor);", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "console.log('returnBool=');");
                strCodeForCs.Append("\r\n" + "console.log(returnBool);");
       
                strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                strCodeForCs.Append("\r\n" + "{");
                Gene_ReFreshCache(strCodeForCs);

                //strCodeForCs.Append("\r\n" + "const strInfo = Format(\"��¡��¼�ɹ�!\");");
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"��¡��¼���ɹ�!\");");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"����¡��{0}����¼!\", intCount);");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "console.log('��ɣ�');");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���Ƽ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
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
     
      
        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ��ʾ{0}�������������ֵ");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param divContainer:��ʾ����");
            strCodeForCs.AppendFormat("\r\n * @param obj{0}:��Ҫ��ʾ�Ķ���",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: string, obj{0}: cls{0}EN) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + "const o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{}�����ڣ�\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "o.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n " + "* ���ݹؼ���ѡ����Ӧ�ļ�¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender:�����б�");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = this.SelectRecord.name;");

            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "var strKeyId: string = $('#txtstrKeyId{0}').val();",
            //        objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
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
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���SelectRecord!\", obj{0}EN);", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.Redirect(\"/Index/Main_{0}\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
               
        public string Gen_Vue_Ts_QueryLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public Query{0}Lst(strListDiv:string) ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Query{0}Lst.name;",   objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", strTabName_Out4ListRegion);

            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

           
            strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara);",
                objViewInfoENEx.TabName_Out);
                        
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���Query{0}Lst!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ѯ�����б��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_BindGv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.IsUseCache4List) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}.name;");
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0})\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", strTabName_Out4ListRegion);
            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "let intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {0}_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {{",
objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = Format(\"��������:[{0}]��ȡ�Ķ����б���Ϊ0��\", strWhereCond);");
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ڰ�Gv�����У���������:[{0}]��ȡ�Ķ����б���Ϊ0��\", strWhereCond);");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "var intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);");
            strCodeForCs.Append("\r\n" + "if (intCurrPageIndex == 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "if (intPageCount > 1) intCurrPageIndex = intPageCount;");
            strCodeForCs.Append("\r\n" + "else intCurrPageIndex = 1;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (intCurrPageIndex > intPageCount)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intCurrPageIndex = intPageCount;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,//������ֶ�Ϊ�գ���ʹ�������������", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = < Array<cls{0}EN>>jsonData;",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��GridView���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "var divPager: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divPager\");");
            strCodeForCs.Append("\r\n" + "if (this.recCount <= this.pageSize)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"none\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"block\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = \"����������ȡ�Ķ����б���Ϊ0��\";");
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��\");");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
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
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_BindGv_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc == true) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}_Cache() ",
                strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}_Cache.name;",
       strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj();", strTabName_Out4ListRegion);
            if (thisCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ListRegion,
                        thisCacheClassifyFld4View.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View.FldName);
            }
            if (thisCacheClassifyFld4View2 != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ListRegion,
                        thisCacheClassifyFld4View2.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {0}_GetSimObjFromObj(obj{0}_Cond);", strTabName_Out4ListRegion);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", strTabName_Out4ListRegion);

            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "let intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                    strTabName_Out4ListRegion);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    strTabName_Out4ListRegion, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ListRegion, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                    thisCacheClassifyFld4View2.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.AppendFormat("\r\n" + "lblMsg.innerHTML = Format(\"��������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", obj{0}_Cond.whereCond);", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�ڰ�Gv_Cache�����У���������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", obj{0}_Cond.whereCond);", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);");
            strCodeForCs.Append("\r\n" + "if (intCurrPageIndex == 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "if (intPageCount > 1) intCurrPageIndex = intPageCount;");
            strCodeForCs.Append("\r\n" + "else intCurrPageIndex = 1;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (intCurrPageIndex > intPageCount)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intCurrPageIndex = intPageCount;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,//������ֶ�Ϊ�գ���ʹ�������������", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "sortFun: {0}_SortFun_Defa", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara);", strTabName_Out4ListRegion);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);", strTabName_Out4ListRegion,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ListRegion,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��GridView���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const divPager: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divPager\");");
            strCodeForCs.Append("\r\n" + "if (this.recCount <= this.pageSize)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"none\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"block\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = \"����������ȡ�Ķ����б���Ϊ0��\";");
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                           thisCacheClassifyFld4View2.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }

            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                     thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}_Cache!\");", strTabName_Out4ListRegion);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_SortFunExportExcel()
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * �����������ݱ��������������ֶε�ֵ���бȽ�,����ʹ��ʱ�����ø������չ���ͬ������");
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objViewInfoENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * ����:{0}", objViewInfoENEx.CurrDate);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param a:�Ƚϵĵ�1������");
            strCodeForCs.Append("\r\n * @param b:�Ƚϵĵ�1������");
            strCodeForCs.AppendFormat("\r\n * @returns ������������ȽϵĽ��",
            objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public SortFun_ExportExcel(a:cls{0}EN , b:cls{0}EN): number ", strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SortFun_ExportExcel.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            clsFieldTabEN objField_1 = null;
            clsFieldTabEN objField_2 = null;
            List<clsFieldTabEN> arrFieldTab = clsFieldTabBLEx.GetObjLstByTabId_Cache(strTabId_Out4ExportExcel, objViewInfoENEx.PrjId);

            foreach (var objInFor in arrFieldTab)
            {
                //if (objInFor.ObjFieldTab().DataTypeId == enumDataTypeAbbr.bit_03) continue;
                if (objField_1 == null) objField_1 = objInFor;
                else if (objField_2 == null)
                {
                    objField_2 = objInFor;
                    break;
                }
            }
            if (objField_1 == null || objField_2 == null) return strCodeForCs.ToString();

            string strReturnStr4Field_1 = "";
            string strReturnStr4Field_2 = "";
            if (objField_1.IsNumberType())
            {
                strReturnStr4Field_1 = string.Format("a.{0} - b.{0}", objField_1.PropertyName());
            }
            else if (objField_1.IsBoolType())
            {
                strReturnStr4Field_1 = string.Format("a.{0} ? -1:1", objField_1.PropertyName());
            }
            else
            {
                strReturnStr4Field_1 = string.Format("a.{0}.localeCompare(b.{0})", objField_1.PropertyName());
            }
            if (objField_2.IsNumberType())
            {
                strReturnStr4Field_2 = string.Format("a.{0} - b.{0}", objField_2.PropertyName());
            }
            else if (objField_2.IsBoolType())
            {
                strReturnStr4Field_2 = string.Format("a.{0} ? -1:1", objField_2.PropertyName());
            }
            else
            {
                strReturnStr4Field_2 = string.Format("a.{0}.localeCompare(b.{0})", objField_2.PropertyName());
            }
            strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return {1} ;", objField_1.PropertyName(), strReturnStr4Field_2);
            strCodeForCs.AppendFormat("\r\n" + "else return {0};", strReturnStr4Field_1);

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_ExportExcel4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4ExcelExport == false) return "";
            if (objViewInfoENEx.IsUseCache4List == false)
            {
                return Gen_Vue_Ts_ExportExcel4Func_NoCache(objvFunction4GeneCodeEN);
            }
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}4Func() ",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}4Func.name;",  strTabName_Out4ExportExcel);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj4ExportExcel();", strTabName_Out4ExportExcel);
            if (thisCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ExportExcel,
                        thisCacheClassifyFld4View.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View.FldName);
            }
            if (thisCacheClassifyFld4View2 != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ExportExcel,
                        thisCacheClassifyFld4View2.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View2.FldName);
            }
            //strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {0}_GetSimObjFromObj(obj{0}_Cond);", strTabName_Out4ExportExcel);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", strTabName_Out4ExportExcel);
            //strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", strTabName_Out4ExportExcel);
            //strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ExportExcel);
            strCodeForCs.AppendFormat("\r\n" + " const arr{0}ExObjLst: Array <cls{0}ENEx> = [];", strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                    strTabName_Out4ExportExcel);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    strTabName_Out4ExportExcel, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ExportExcel, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                    thisCacheClassifyFld4View2.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.AppendFormat("\r\n" + "lblMsg.innerHTML = Format(\"��������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", obj{0}_Cond.whereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�ڰ�Gv_Cache�����У���������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", obj{0}_Cond.whereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetSubObjLst_Cache(obj{0}_Cond);", strTabName_Out4ExportExcel);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetSubObjLst_Cache(obj{0}_Cond, {1}.{2}_Cache);", strTabName_Out4ExportExcel,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetSubObjLst_Cache(obj{0}_Cond, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ExportExcel,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
            }

    //        strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst = arr{0}ObjLst.map(this1.CopyToEx);", strTabName_Out4ListRegion,
    //objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "    const objEx = this.CopyToEx(objInFor); ", this.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst.push(objEx); ", strTabName_Out4ListRegion);
             strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ExObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.FuncMap4ExcelExport(objInFor);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����Excelʱ��ȡ���ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                           thisCacheClassifyFld4View2.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }

            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                     thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.PropertyName());
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
            
            }

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFun_ExportExcel);", strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "  this.CombineData(arr{0}ObjLst, arrDataColumn); ");

            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}!\");", strTabName_Out4ExportExcel);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_ExportExcel4Func_NoCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4ExcelExport == false) return "";

            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}4Func() ",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}4Func.name;",       strTabName_Out4ExportExcel);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            //strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", strTabName_Out4ExportExcel);
            //strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "get",
            //    ControlType = "input",
            //    CtrlId = "hidCurrPageIndex",
            //    PropertyName = "CurrPageIndex",
            //    Comment = "��ȡ��ǰҳ���(Used In BindGv_Cache)",
            //    DataType = "number"

            //});

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ExportExcel);
            strCodeForCs.AppendFormat("\r\n" + " const arr{0}ExObjLst: Array <cls{0}ENEx> = [];", strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCondAsync(strWhereCond);",
                strTabName_Out4ExportExcel);

            strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.AppendFormat("\r\n" + "lblMsg.innerHTML = Format(\"��������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", strWhereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�ڰ�Gv_Cache�����У���������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", strWhereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);", strTabName_Out4ExportExcel);

    //        strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst = arr{0}ObjLst.map(this1.CopyToEx);", strTabName_Out4ListRegion,
    //objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "    const objEx = this.CopyToEx(objInFor); ", this.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst.push(objEx); ", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ExObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.FuncMap4ExcelExport(objInFor);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����Excelʱ��ȡ���ݲ��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                           thisCacheClassifyFld4View2.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }

            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                     thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.PropertyName());
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
        
            }

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFun_ExportExcel);", strTabName_Out4ExportExcel);

            strCodeForCs.AppendFormat("\r\n" + "  this.CombineData(arr{0}ObjLst, arrDataColumn); ");

            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}!\");", strTabName_Out4ExportExcel);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_ExportExcel_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            if (bolIsUseFunc4ExcelExport == true) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}_Cache() ",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}_Cache.name;",     strTabName_Out4ExportExcel);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj4ExportExcel();", strTabName_Out4ExportExcel);
            if (thisCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ExportExcel,
                        thisCacheClassifyFld4View.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View.FldName);
            }
            if (thisCacheClassifyFld4View2 != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ExportExcel,
                        thisCacheClassifyFld4View2.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {0}_GetSimObjFromObj(obj{0}_Cond);", strTabName_Out4ExportExcel);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", strTabName_Out4ExportExcel);
            //strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", strTabName_Out4ExportExcel);

            //strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "get",
            //    ControlType = "input",
            //    CtrlId = "hidCurrPageIndex",
            //    PropertyName = "CurrPageIndex",
            //    Comment = "��ȡ��ǰҳ���(Used In BindGv_Cache)",
            //    DataType = "number"

            //});

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                    strTabName_Out4ExportExcel);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    strTabName_Out4ExportExcel, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ExportExcel, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                    thisCacheClassifyFld4View2.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.AppendFormat("\r\n" + "lblMsg.innerHTML = Format(\"��������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", obj{0}_Cond.whereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�ڰ�Gv_Cache�����У���������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", obj{0}_Cond.whereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetSubObjLst_Cache(obj{0}_Cond);", strTabName_Out4ExportExcel);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetSubObjLst_Cache(obj{0}_Cond, {1}.{2}_Cache);", strTabName_Out4ExportExcel,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetSubObjLst_Cache(obj{0}_Cond, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ExportExcel,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��GridView���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                           thisCacheClassifyFld4View2.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }

            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                     thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.PropertyName());
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
         
            }

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFun_ExportExcel);", strTabName_Out4ExportExcel);

            strCodeForCs.AppendFormat("\r\n" + "  this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                strTabName_Out4ExportExcel, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}!\");", strTabName_Out4ExportExcel);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_ExportExcel(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            if (bolIsUseFunc4ExcelExport == true) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}() ",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}.name;",
   strTabName_Out4ExportExcel);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            //strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", strTabName_Out4ListRegion);

            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            //strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCondAsync(strWhereCond);",
                strTabName_Out4ExportExcel);


            strCodeForCs.AppendFormat("\r\n" + "if (this.recCount == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.AppendFormat("\r\n" + "lblMsg.innerHTML = Format(\"��������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", strWhereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = <HTMLDivElement> document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"�ڰ�ExportExcel�����У���������:[{{0}}]��ȡ�Ķ����б���Ϊ0��\", strWhereCond);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��GridView���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��ExportExcel�����У�����������ȡ�ļ�¼��Ϊ0��\");",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.PropertyName());
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText); return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
        
            }

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFun_ExportExcel);", strTabName_Out4ExportExcel);

            strCodeForCs.AppendFormat("\r\n" + "  this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                strTabName_Out4ExportExcel, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}!\");", strTabName_Out4ExportExcel);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        public string Gen_Vue_Ts_BindGv4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc == false) return "";
            if (objViewInfoENEx.IsUseCache4List == false)
            {
                return Gen_Vue_Ts_BindGv4Func_NoCache(objvFunction4GeneCodeEN);
            }
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}4Func() ",
                strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}4Func.name;",
      strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj();", strTabName_Out4ListRegion);
            if (thisCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ListRegion,
                        thisCacheClassifyFld4View.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View.FldName);
            }
            if (thisCacheClassifyFld4View2 != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        strTabName_Out4ListRegion,
                        thisCacheClassifyFld4View2.FldName,
                            objViewInfoENEx.ClsName,
                            thisCacheClassifyFld4View2.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {0}_GetSimObjFromObj(obj{0}_Cond);", strTabName_Out4ListRegion);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", strTabName_Out4ListRegion);

            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "get",
            //    ControlType = "input",
            //    CtrlId = "hidCurrPageIndex",
            //    PropertyName = "CurrPageIndex",
            //    Comment = "��ȡ��ǰҳ���(Used In BindGv_Cache)",
            //    DataType = "number"

            //});

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + " const arr{0}ExObjLst: Array <cls{0}ENEx> = [];", strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                    strTabName_Out4ListRegion);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    strTabName_Out4ListRegion, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ListRegion, objViewInfoENEx.ClsName,
                    thisCacheClassifyFld4View.FldName,
                    thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "const objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "sortFun: (x, y) => {console.log(x,y); return 0;}");
            strCodeForCs.Append("\r\n" + "}");
            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara);", strTabName_Out4ListRegion);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);", strTabName_Out4ListRegion,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache, {1}.{3}_Cache);",
                    strTabName_Out4ListRegion,
                    objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                    thisCacheClassifyFld4View2.FldName);

            }
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst = arr{0}ObjLst.map(this1.CopyToEx);", strTabName_Out4ListRegion,
            //    objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "    const objEx = this.CopyToEx(objInFor); ", this.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst.push(objEx); ", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ExObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.FuncMap(objInFor);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��GridView���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }

            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                     thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}4Func(strListDiv, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}4Func!\");", strTabName_Out4ListRegion);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_BindGv4Func_NoCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}4Func() ",
                strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}4Func.name;",
       strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����ʾ�б�ʱ�������ֶ�(sort{0}By)Ϊ�գ����飡(In BindGv_{0}_Cache)\");", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", strTabName_Out4ListRegion);

            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//��ȡ��ǰҳ");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//��ȡ��ǰҳ");

            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "get",
            //    ControlType = "input",
            //    CtrlId = "hidCurrPageIndex",
            //    PropertyName = "CurrPageIndex",
            //    Comment = "��ȡ��ǰҳ���(Used In BindGv_Cache)",
            //    DataType = "number"

            //});

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + " const arr{0}ExObjLst: Array <cls{0}ENEx> = [];", strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCondAsync(strWhereCond);",
                strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "const objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara);", strTabName_Out4ListRegion);

            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst = arr{0}ObjLst.map(this1.CopyToEx);", strTabName_Out4ListRegion,
            //    objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "    const objEx = this.CopyToEx(objInFor); ", this.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ExObjLst.push(objEx); ", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ExObjLst)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.FuncMap(objInFor);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��GridView���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache, {1}.{3}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }

            if (thisCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else if (thisCacheClassifyFld4View2 == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��BindGv_Cache�����У��������������ȡ�Ķ����б���Ϊ0��(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"����������ȡ�ļ�¼��Ϊ0��(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, thisCacheClassifyFld4View.FldName,
                     thisCacheClassifyFld4View2.FldName);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfo(strListDiv, strMsg);");
            strCodeForCs.Append("\r\n" + "this.objPager.Hide(this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}4Func(strListDiv, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���BindGv_{0}4Func!\");", strTabName_Out4ListRegion);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�󶨶����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        public string Gen_Vue_Ts_CombineData4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc == false) return "";
            if (bolIsUseFunc4ExcelExport == false) return "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �ϲ�����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public CombineData4Func(arr{0}ExObjLst: Array<cls{0}ENEx>, arrDataColumn: Array<clsDataColumn>) ",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = this.CombineData4Func.name;");
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.AppendFormat("\r\n" + "const intRowNum = arr{0}ExObjLst.length;",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "const intColNum = arrDataColumn.length;");
            strCodeForCs.Append("\r\n" + "const arrData: Array < Array < any >> = new Array<Array<any>>();");

            strCodeForCs.Append("\r\n" + "const arrHead: Array < any > = new Array<any>();");
            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrHead.push(arrDataColumn[j].colHeader);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "arrData.push(arrHead);");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intRowNum; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrRow: Array < any > = new Array<any>();");
            strCodeForCs.AppendFormat("\r\n" + "const objEN: cls{0}EN = arr{0}ExObjLst[i];",
                strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + \"\" + j;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "arrData.push(arrRow);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "console.log(\"arrData\", arrData);");
            strCodeForCs.AppendFormat("\r\n" + "const strFileName = Format(\"{0}({{0}})����.xlsx\",", objViewInfoENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n" + " cls{0}EN._CurrTabName);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "exportSpecialExcel_pyf(arrData, strFileName);");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_CombineData(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �ϲ�����");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public CombineData(arr{0}ObjLst: Array<cls{0}EN>, arrDataColumn: Array<clsDataColumn>) ",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CombineData.name;");
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.AppendFormat("\r\n" + "const intRowNum = arr{0}ObjLst.length;",
                strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "const intColNum = arrDataColumn.length;");
            strCodeForCs.Append("\r\n" + "const arrData: Array < Array < any >> = new Array<Array<any>>();");

            strCodeForCs.Append("\r\n" + "const arrHead: Array < any > = new Array<any>();");
            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrHead.push(arrDataColumn[j].colHeader);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "arrData.push(arrHead);");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intRowNum; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrRow: Array < any > = new Array<any>();");
            strCodeForCs.AppendFormat("\r\n" + "const objEN: cls{0}EN = arr{0}ObjLst[i];",
                strTabName_Out4ExportExcel);

            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + \"\" + j;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "arrData.push(arrRow);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "console.log(\"arrData\", arrData);");
            strCodeForCs.AppendFormat("\r\n" + "const strFileName = Format(\"{0}({{0}})����.xlsx\",", objViewInfoENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n" + " cls{0}EN._CurrTabName);", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "exportSpecialExcel_pyf(arrData, strFileName);");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnQuery_Click() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnQuery_Click.name;");
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = 1;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(1);");

            strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnExportExcel_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnExportExcel_Click() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnExportExcel_Click.name;");
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (bolIsUseFunc4ExcelExport == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.ExportExcel_{0}4Func();",
                 strTabName_Out4ExportExcel);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.ExportExcel_{0}_Cache();",
                    strTabName_Out4ExportExcel);
            }
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        
   
        public string Gen_Vue_Ts_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����־ɾ����¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecordBySign_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordBySign_Click.name;");

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
                if (thisCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName);
                }
                else if (thisCacheClassifyFld4View2 == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName,
                        thisCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.{2}_Cache, {1}.{3}_Cache);", objViewInfoENEx.TabName,
                        objViewInfoENEx.ClsName,
                        thisCacheClassifyFld4View.FldName, thisCacheClassifyFld4View2.FldName);
                }
            }
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"����־ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"����־ɾ����¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����־ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnUnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����־�ָ�ɾ����¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnUnDelRecordBySign_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUnDelRecordBySign_Click.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�ָ�ɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_UnDelRecordBySignAsync(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            
            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"����־�ָ���¼�ɹ�,���ָ���{0}����¼!\", returnInt);");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"����־�ָ���¼���ɹ�!\");");
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����־�ָ���¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnDelRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ɾ����¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecord_Click.name;");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(arrKeyIds.length) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "await this.DelMultiRecord(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnDelRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * �����ݱ���ɾ����¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordInTab_Click.name;");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"���뺯����btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord(lngKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord(strKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            }

            strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * �����ݱ���ѡ���¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnSelectRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSelectRecordInTab_Click.name;");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫɾ���ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ѡ���¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * �����ݱ�����ϸ��Ϣ��¼");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecordInTab_Click.name;");
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Detail\";");

            clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "���ò������ͣ�Add||Update||Detail",
                DataType = "string"
            };
            arrPropertyDef4GC.Add(objPropertyDef4GC);

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
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ϸ��Ϣ��¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnDetailRecord_Clic1kBak20210330(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecord_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecord_Click.name;");
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.OpType_d = \"Detail\";");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType_d",
                PropertyName = "OpType_d",
                Comment = "���ò������ͣ�Add||Update||Detail",
                DataType = "string"
            });
            if (objFeatureRegionFlds_Detail == null
                || string.IsNullOrEmpty(objFeatureRegionFlds_Detail.KeyIdGetModeId)
                || objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
            {

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"��Ҫ��ʾ��ϸ��Ϣ��¼�Ĺؼ���Ϊ�գ����飡\";");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strCodeForCs.AppendFormat("\r\n" + "var strKeyId = {0}.{1}_Static;", this.ClsName, objKeyField.PropertyName());
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"����ʾ��ϸ��Ϣʱ�����澲̬�ؼ���Ϊ�գ�(In btnDetailRecord_Click)\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadDetailRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Detail(this.divName4Detail);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // Ϊ�༭����������");
            strCodeForCs.AppendFormat("\r\n" + "//await this.BindDdl4DetailRegion();", objViewInfoENEx.ClsName);

            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadDetailRegion = true;  //", objViewInfoENEx.ClsName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** �����ݱ����޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnUpdateRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecordInTab_Click.name;");
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Update\";");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "���ò������ͣ�Add||Update||Detail",
                DataType = "string"
            });

            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ�޸ĵļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // Ϊ�༭����������");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

       

        public string Gen_Vue_Ts_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async DelMultiRecord(arr{0}: Array<string>) {{",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DelMultiRecord.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
      
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_Del{0}sAsync(arr{1});",
                objViewInfoENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼���ɹ�!\");");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DelMultiRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * ���ݹؼ���ɾ����¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async DelRecord({0}: {1}) {{",
                objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DelRecord.name;");

            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_DelRecordAsync({1});",
                objViewInfoENEx.TabName,
                objKeyField.PrivFuncName);
                        
            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼���ɹ�!\");");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"���DelRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

       

        public string Gen_Vue_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ����¼�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecord_Click.name;");

            strCodeForCs.Append("\r\n" + "this.OpType = \"Add\";");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "���ò������ͣ�Add||Update||Detail",
                DataType = "string"
            });

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // Ϊ�༭����������");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"ȷ�����\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"ȡ�����\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecord();",
                    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"ȷ�����\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"ȡ�����\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����¼�¼��ʼ�����ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

     
        public string Gen_Vue_Ts_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");


            strCodeForCs.Append("\r\n" + "public async GetMaxStrId(strKeyCtrlName) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetMaxStrId.name;");

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
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ�գ����ɹ�������!\");",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}!\", returnString);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
               

        Func<clsvViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_DdlBindFunction4Page_Load()
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

                            strCodeForCs.AppendFormat("\r\n" + "var {0}{2}: {1} = \"\";",
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


        public string Gen_Vue_Ts_DdlBindFunction4Page_Load_Cache()
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
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                 objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                        else
                        {

                            strCodeForCs.AppendFormat("\r\n" + "var {0}{2}: {1} = \"\";",
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


        public string Gen_Vue_Ts_CombineCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;


                strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " public Combine{0}Condition():string ", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {1} ='{{0}}'\", {2}.{3});",
                                objViewInfoENEx.TabName_Out,
                                objInFor.ObjFieldTab().FldName,
                                objViewInfoENEx.ClsName,
                                strVarName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {1} ={{0}}\", {2}.{3});",
                                objViewInfoENEx.TabName_Out,
                                objInFor.ObjFieldTab().FldName,
                                objViewInfoENEx.ClsName,
                                strVarName);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.CacheClassifyField_37) continue;

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            CtrlId = objQryRegionFldsEx.CtrlId,
                            PropertyName = objQryRegionFldsEx.PropertyName,
                            Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                            "CombineCondition()"),

                            DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = "this.divName4Query"
                        });
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            CtrlId = objQryRegionFldsEx.CtrlId,
                            PropertyName = objQryRegionFldsEx.PropertyName,
                            Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                     "CombineCondition()"),

                            DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = "this.divName4Query"
                        });
                        switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                        {

                            case "CheckBox":
                                //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                //            objQryRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                             objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                         strTabName_Out4ListRegion);
                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                         strTabName_Out4ListRegion);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///����ؼ���������;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                                {

                              

                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"selectedIndex\") == 1)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0}); ",
                                          objQryRegionFldsEx.FldName,
                                           strTabName_Out4ListRegion,
                                          "{", "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                           objQryRegionFldsEx.FldName,
                                         strTabName_Out4ListRegion,
                                          "{", "}");
                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {                                  
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                             objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                objQryRegionFldsEx.PropertyName);
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                    {
                                        case "string":

                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ListRegion);
                                            break;
                                        case "int":

                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ListRegion);
                                            break;
                                        default:


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ListRegion);
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///����ؼ��������ı���;
                               
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
                                    && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                {
                                    objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                }
                                if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                {
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                            objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                            objQryRegionFldsEx.PropertyName);
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strTabName_Out4ListRegion);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                 objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.PropertyName,
                                 strTabName_Out4ListRegion);
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", cls{2}EN.con_{0}, this.{1});",
                                       objQryRegionFldsEx.FldName,
                                         objQryRegionFldsEx.PropertyName,
                                         strTabName_Out4ListRegion);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///��Χ��ѯ;
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}), , );",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strTabName_Out4ListRegion);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}), , );",
                                         objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.PropertyName,
                                          strTabName_Out4ListRegion);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
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
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "Button":
                                break;
                        }
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition(in Vue)", "����ϲ�ѯ����(CombineTabNameCondition(in Vue))ʱ����!����ϵ����Ա!", "���ɴ���");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})����ϲ�ѯ����(Combine{0}Condition)ʱ����!����ϵ����Ա!{{0}}\", objException);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
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

        public string Gen_Vue_Ts_CombineConditionObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;


                strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " public Combine{0}ConditionObj():cls{0}EN ", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = new cls{0}EN();", strTabName_Out4ListRegion);

                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}, \"=\");",
                            strTabName_Out4ListRegion,
                            objInFor.ObjFieldTab().FldName,
                            objViewInfoENEx.ClsName,
                            strVarName);
                    }
                }

                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.CacheClassifyField_37) continue;

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            CtrlId = objQryRegionFldsEx.CtrlId,
                            PropertyName = objQryRegionFldsEx.PropertyName,
                            Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "CombineConditionObj()"),
                            DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = "this.divName4Query"
                        });
                        switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                        {

                            case "CheckBox":
                                //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                //            objQryRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                             objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                         strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                    strTabName_Out4ListRegion,
                                    objQryRegionFldsEx.FldName);


                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                         strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, false, \"=\");",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///����ؼ���������;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                                {

                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"selectedIndex\") == 1)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0}); ",
                                          objQryRegionFldsEx.FldName,
                                           strTabName_Out4ListRegion,
                                          "{", "}");
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                        strTabName_Out4ListRegion,
                                        objQryRegionFldsEx.FldName);

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                           objQryRegionFldsEx.FldName,
                                         strTabName_Out4ListRegion,
                                          "{", "}");
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, false, \"=\");",
                                        strTabName_Out4ListRegion,
                                        objQryRegionFldsEx.FldName);

                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {                                    
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                             objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                objQryRegionFldsEx.PropertyName);
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                    {
                                        case "string":


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ListRegion);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                        strTabName_Out4ListRegion,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName);


                                            break;
                                        case "int":


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ListRegion);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    strTabName_Out4ListRegion,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                            break;
                                        default:

                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ListRegion);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                                strTabName_Out4ListRegion,
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName);
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///����ؼ��������ı���;
                                
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
                                    && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                {
                                    objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                }
                                if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                {
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                            objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                            objQryRegionFldsEx.PropertyName);
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strTabName_Out4ListRegion);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                                strTabName_Out4ListRegion,
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                 objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.PropertyName,
                                 strTabName_Out4ListRegion);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    strTabName_Out4ListRegion,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", cls{2}EN.con_{0}, this.{1});",
                                       objQryRegionFldsEx.FldName,
                                         objQryRegionFldsEx.PropertyName,
                                         strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"like\");",
                                    strTabName_Out4ListRegion,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///��Χ��ѯ;
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}), , );",
                                         objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.PropertyName,
                                          strTabName_Out4ListRegion);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
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
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "Button":
                                break;
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "����ϲ�ѯ��������(CombineTabNameConditionObj)ʱ����!����ϵ����Ա!", "���ɴ���");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})����ϲ�ѯ��������(Combine{0}ConditionObj)ʱ����!����ϵ����Ա!{{0}}\", objException);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.whereCond = strWhereCond;", strTabName_Out4ListRegion);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}_Cond;", strTabName_Out4ListRegion);
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


        public string Gen_Vue_Ts_CombineConditionObj4ExportExcel(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;


                strCodeForCs.Append("\r\n /** �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns ������(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " public Combine{0}ConditionObj4ExportExcel():cls{0}EN ", strTabName_Out4ExportExcel);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = new cls{0}EN();", strTabName_Out4ExportExcel);

                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}, \"=\");",
                            strTabName_Out4ExportExcel,
                            objInFor.ObjFieldTab().FldName,
                            objViewInfoENEx.ClsName,
                            strVarName);
                    }
                }

                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.CacheClassifyField_37) continue;

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            CtrlId = objQryRegionFldsEx.CtrlId,
                            PropertyName = objQryRegionFldsEx.PropertyName_FstLcase(),
                            Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "CombineConditionObj4ExportExcel()"),
                            DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = "this.divName4Query"
                        });
                        switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                        {

                            case "CheckBox":
                                //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                //            objQryRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                             objQryRegionFldsEx.PropertyName_FstLcase());
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                         strTabName_Out4ExportExcel);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                    strTabName_Out4ExportExcel,
                                    objQryRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                         strTabName_Out4ExportExcel);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, false, \"=\");",
                                strTabName_Out4ExportExcel,
                                objQryRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///����ؼ���������;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"selectedIndex\") == 1)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0}); ",
                                          objQryRegionFldsEx.FldName,
                                           strTabName_Out4ExportExcel,
                                          "{", "}");
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                        strTabName_Out4ExportExcel,
                                        objQryRegionFldsEx.FldName);

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                           objQryRegionFldsEx.FldName,
                                         strTabName_Out4ExportExcel,
                                          "{", "}");
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, false, \"=\");",
                                        strTabName_Out4ExportExcel,
                                        objQryRegionFldsEx.FldName);

                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                             objQryRegionFldsEx.PropertyName_FstLcase());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                objQryRegionFldsEx.PropertyName_FstLcase());
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                    {
                                        case "string":


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ExportExcel);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                        strTabName_Out4ExportExcel,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName_FstLcase());


                                            break;
                                        case "int":


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ExportExcel);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    strTabName_Out4ExportExcel,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                            break;
                                        default:


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            strTabName_Out4ExportExcel);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    strTabName_Out4ExportExcel,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///����ؼ��������ı���;
                                //strCodeForCs.AppendFormat("\r\n" + "var str{0} = $(\"#{1}\").val();",
                                //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);

                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
                                    && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                {
                                    objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                }
                                if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                                {
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                            objQryRegionFldsEx.PropertyName_FstLcase());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                            objQryRegionFldsEx.PropertyName_FstLcase());
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strTabName_Out4ExportExcel);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    strTabName_Out4ExportExcel,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                 objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.PropertyName,
                                 strTabName_Out4ExportExcel);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    strTabName_Out4ExportExcel,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", cls{2}EN.con_{0}, this.{1});",
                                       objQryRegionFldsEx.FldName,
                                         objQryRegionFldsEx.PropertyName,
                                         strTabName_Out4ExportExcel);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"like\");",
                                    strTabName_Out4ExportExcel,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///��Χ��ѯ;
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strTabName_Out4ExportExcel);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                strTabName_Out4ExportExcel,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ExportExcel);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}), , );",
                                         objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.PropertyName,
                                          strTabName_Out4ExportExcel);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                strTabName_Out4ExportExcel,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
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
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "Button":
                                break;
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj4ExportExcel", "����ϵ���Excel��������(CombineTabNameConditionObj)ʱ����!����ϵ����Ա!", "���ɴ���");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})����ϵ���Excel��������(Combine{0}ConditionObj4ExportExcel)ʱ����!����ϵ����Ա!{{0}}\", objException);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.whereCond = strWhereCond;", strTabName_Out4ExportExcel);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}_Cond;", strTabName_Out4ExportExcel);
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
                            strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = $('#txt{1}{2}').val();",
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
                                    strCodeForCs.AppendFormat("\r\n" + "var {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "var {1}:{0} = $('#txt{1}{2}').val();",
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

        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(),
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "PutDataToClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = "this.divName4Edit"
                });
            }
            if (objEditRegionFldsEx.FieldTypeId() == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsPubSessionStorage.userId;",
                    objViewInfoENEx.TabName,
                    objEditRegionFldsEx.PropertyName());
            }
            else
            {
                switch (objEditRegionFldsEx.CtlTypeId)
                {
                    case enumCtlTypeAbbr.CheckBox_02:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.TextBox_16:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.DropDownList_06:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.CacheClassifyField_37:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         strVarDef4ViewCacheFld);
                        break;
                    case enumCtlTypeAbbr.ViewVariable_38:
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objEditRegionFldsEx.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2}.{3};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objViewInfoENEx.ClsName, strVarName);
                        break;
                    case enumCtlTypeAbbr.GivenValue_35:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         strVarDef4ViewCacheFld);
                        break;

                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
                objViewInfoENEx.TabName,
                objEditRegionFldsEx.PropertyName(),
                objEditRegionFldsEx.CtrlId);
                        break;
                }
            }
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
     
      

        private string GetCode4FieldInShowDetailDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = objDetailRegionFldsEx.CtlTypeName,
                CtrlId = objDetailRegionFldsEx.CtrlId + "_d",
                PropertyName = objDetailRegionFldsEx.PropertyName() + "_d",
                Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "ShowDetailDataFromClass()"),
                DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                ParentDivName = "this.divName4Detail"
            });
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7������checkboxΪѡ��״̬
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8������checkboxΪ��ѡ��״̬
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                         objDetailRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName_Out,
                         objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }



        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(),
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetDataFromClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = "this.divName4Edit"
                });
            }
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
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                         objEditRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName,
                         objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_GetFirstKey()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** ��������:�ӽ����б��л�ȡ��һ���ؼ��ֵ�ֵ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN:��ʵ�������",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n * @returns �б�ĵ�һ���ؼ���ֵ");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public GetFirstKey(): string {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetFirstKey.name;");
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(`��ѡ��һ���ؼ��֣�Ŀǰѡ����:${ arrSelectedKeys.length}���ؼ��֡�`);");
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
        public string Gen_Vue_Ts_SortBy()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** ��������:�ӽ����б��и���ĳһ���ֶ�����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param objAnchorElement:���������ֶε�Anchors",
                    objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async SortBy(objAnchorElement:any) {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SortBy.name;");
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + " console.log(\"objAnchorElement(In SetAllCkechedKeysV2):\", objAnchorElement);");
                strCodeForCs.Append("\r\n" + "//event = window.event || event;");
                strCodeForCs.Append("\r\n" + "const thisEventObj: HTMLInputElement = objAnchorElement;");

                strCodeForCs.Append("\r\n" + "const strFldName: string = thisEventObj.getAttribute(\"FldName\") as string;");
                strCodeForCs.Append("\r\n" + "  if (IsNullOrEmpty(strFldName) == true) return;");
                strCodeForCs.Append("\r\n" + "const strSortByFld: string = strFldName;");

                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(strSortByFld) >= 0)", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(\"Asc\") >= 0)", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = Format(\"{{0}} Desc\", strSortByFld);", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = Format(\"{{0}} Asc\", strSortByFld);", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = Format(\"{{0}} Asc\", strSortByFld);", strTabName_Out4ListRegion, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

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

        public string Gen_Vue_Ts_IndexPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** ��������:������ �б�����ת��ĳһҳ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param intPageIndex:ҳ���",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async IndexPage(intPageIndex:number)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.IndexPage.name;");
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + "if (intPageIndex == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "intPageIndex = this.objPager.pageCount;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "console.log(\"��ת��\" + intPageIndex + \"ҳ\");");

                //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intPageIndex;");
                strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intPageIndex);");
                //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                //{
                //    OperateType = "set",
                //    ControlType = "input",
                //    CtrlId = "hidCurrPageIndex",
                //    PropertyName = "CurrPageIndex",
                //    Comment = "���õ�ǰҳ���",
                //    DataType = "number"

                //});
                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

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

        public string Gen_Vue_Ts_PrevPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** ��������:�������б�����ת��ǰһҳ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async PrevPage()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PrevPage.name;");
                strCodeForCs.Append("\r\n" + "var intCurrPageIndex = $('#hidCurrPageIndex').val();");
                strCodeForCs.Append("\r\n" + "var intPageIndex = Number(intCurrPageIndex) - 1;");
                strCodeForCs.Append("\r\n" + "console.log(\"��ת��\" + intPageIndex + \"ҳ\");");
                strCodeForCs.Append("\r\n" + "this.IndexPage(intPageIndex);");

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

        public string Gen_Vue_Ts_NextPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** ��������:�������б�����ת����һҳ");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async NextPage()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.NextPage.name;");
                strCodeForCs.Append("\r\n" + "var intCurrPageIndex = $('#hidCurrPageIndex').val();");
                strCodeForCs.Append("\r\n" + "var intPageIndex = Number(intCurrPageIndex) + 1;");
                strCodeForCs.Append("\r\n" + "console.log(\"��ת��\" + intPageIndex + \"ҳ\");");
                strCodeForCs.Append("\r\n" + "this.IndexPage(intPageIndex);");

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
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnAddNewRec4Gv\" runat = \"server\" OnClick = \"btnAddNewRec4Gv_Click\" style = \"z-index: 106; \"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"��Ӽ�¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDelete4Gv\" OnClick = \"btnDelete4Gv_Click\" style = \"z-index: 104; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"ɾ����¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"�޸ļ�¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"�޸ļ�¼\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    //clsInpu
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDetail4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDetail4Gv\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"��ϸ��Ϣ\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
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
        public string Gen_Vue_Ts_DefDiv4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                objViewInfoENEx.TabName_In);
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
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                //                strCodeForCs.AppendFormat("\r\n" + "</td>");
                strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //intZIndex += 1;
                //intCurrTop += 25;

            }

            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>1&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>2&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>3&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>4&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>5&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>6&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
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

        public string Gen_Vue_Ts_ShowDataBak20211006()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n /** ��������:���Ըùؼ��ֵļ�¼������ʾ�ڽ�����,");
                    strCodeForCs.Append("\r\n ������   * �������ǰ�ֵ������ؼ���");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param {0}:���¼�Ĺؼ���,��ʾ�ñ�ؼ��ֵ�����",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "  public async Show1Data({0}: {1}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType);
                    strCodeForCs.Append("\r\n" + "        //��������:");
                    strCodeForCs.Append("\r\n" + "        //1�����ؼ����Ƿ�Ϊ�գ�");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.Append("\r\n" + "        //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.Append("\r\n" + "        //4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "        //5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.Append("\r\n" + "        //2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");

                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const returnBool = await {0}_IsExistAsync({1});",
                        objViewInfoENEx.TabName_In, objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"�ؼ���:[{{0}}] �ļ�¼������!\", {0});",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "            else {");
                    //                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"�ؼ���:[${strExam1TypeId}]����ؼ�¼����!\");");
                    //                  strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    //                strCodeForCs.Append("\r\n" + "                //��ʾ��Ϣ��");
                    //              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"�����Ӧ�ؼ��ֵļ�¼���ڲ��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                        objViewInfoENEx.TabName_In, objKeyField.FldName, objKeyField.PrivFuncName);
                    
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
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
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScriptCS_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(Vue_ViewScriptCS_TS4TypeScript);
            //    MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

            //    if (mt == null)
            //    {
            //        string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //    }
            //    else
            //    {
            //        //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
            //        if (mt.GetParameters().Length == 0)
            //        {
            //            strCode = (string)mt.Invoke(this, null);
            //        }
            //        else if (mt.GetParameters().Length == 1)
            //        {
            //            strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
            //        }
            //        //Console.WriteLine(str);
            //    }

            //    return strCode;
            //}
            //catch (Exception objException)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strMsg = "";
            //    if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
            //    {
            //        strMsg = objException.InnerException.Message;
            //    }
            //    else
            //    {
            //        strMsg = objException.Message;
            //    }
            //    sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
            //    throw new Exception(sbMessage.ToString());
            //}
        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //objViewInfoENEx.ClsName = this.ClsName;

            this.ClsName = objViewInfoENEx.ViewName;
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
                        objViewInfoENEx.MainTabId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
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
        public string Gen_Vue_Ts_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ����¼�¼");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public async btnCopyRecord_Click() {");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnCopyRecord_Click.name;");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"��ѡ����Ҫ��¡�ļ�¼��\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "await this.CopyRecord(arrKeyIds);");

            strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���Ƽ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /** �����ֶ�ֵ-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "public async {0}_Click() {{", objInFor.ButtonName);
                    //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}_Click.name;", objInFor.ButtonName);

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
                                strCodeForCs.AppendFormat("\r\n" + "const str{0} = clsCommFunc4Ctrl.getSelectValue(this.divName4Function,\"{1}\");",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "let {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "const {0}: boolean = $(\"#{1}\").prop(\"checked\");",
                  objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                break;
                            default:

                                strCodeForCs.AppendFormat("\r\n" + "const str{0}: string = clsCommFunc4Ctrl.getInputValue(this.divName4Function,\"{1}\");",
                                        objViewFeatureFlds.ObjFieldTabENEx.FldName,
                                        strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");
                        if (objViewFeatureFlds.ObjFieldTabENEx.IsNumberType())
                        {
                            strCodeForCs.AppendFormat("\r\n" + "var {0}:{1} = Number(str{2});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds);", strFuncName);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ü�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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



        public string Gen_Vue_Ts_SetFieldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /** �����ֶ�ֵ-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
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

                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>, {3}: {2})",
                                strFuncName,
                                objKeyField.FldName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "string":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "number":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == 0 )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>)",
                                strFuncName, objKeyField.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                    }
               
                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"û��ѡ���¼�����������ֶ�ֵ!\";");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const  arr{0}ObjLst = await {0}_GetObjLstBy{1}LstAsync(arr{1});",
objViewInfoENEx.TabName_In, objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "let intCount = 0;");

                    strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "{0}_CopyObjTo(objInFor, obj{0}EN);", objViewInfoENEx.TabName_In);


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"���ﲻ��ȷ��ֵΪ�գ�\";",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.PropertyName());
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.PropertyName(),
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
                                  objViewInfoENEx.TabName_In, objFieldTabEN.PropertyName(), objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = TransToBool(\"{2}\");",
                                                        objViewInfoENEx.TabName_In, objFieldTabEN.PropertyName(), objInFor.DefaultValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} =\"{2}\";",
                                    objViewInfoENEx.TabName_In, objFieldTabEN.PropertyName(), objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "let returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sf_UpdFldSetStr = obj{0}EN.updFldString;//������Щ�ֶα��޸�(���ֶ�)", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await {0}_UpdateRecordAsync(obj{0}EN);", objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "console.log('returnBool=');");
                    strCodeForCs.Append("\r\n" + "console.log(returnBool);");
             

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ü�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "const strInfo = Format(\"���ü�¼�ɹ�!\");");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"���ü�¼���ɹ�!\");");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"��������{0}����¼!\", intCount);");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "console.log('��ɣ�');");

                    strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    Gene_ReFreshCache(strCodeForCs);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ü�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
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


        public string Gen_Vue_Ts_btnGoTop_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /** �ö�");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoTop_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGoTop_Click.name;");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {

                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
                                    objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                        "btnGoTop_Click()"),
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
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName,
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
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
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ö���������:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

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

        public string Gen_Vue_Ts_btnUpMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnUpMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpMove_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " var str{0}:string =$('#{1}').val();",
                        //    objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
                                    objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                        "btnUpMove_Click()"),
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ���Ƶļ�¼!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
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
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���Ƽ�¼��������:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
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

        public string Gen_Vue_Ts_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * �ƶ���¼���������ƺ�����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async MoveRecord(strDirect: string)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.MoveRecord.name;");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0}:string =$('#{1}').val();",
                            objInFor.FldName, objInFor.CtrlId);
                    }
                }
                strCodeForCs.Append("\r\n" + "const strKeyId = clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ�ƶ�(${strDirect})�ļ�¼!`);");
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
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�ƶ�({3})��¼��������:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName, strDirect);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

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

        public string Gen_Vue_Ts_btnDownMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnDownMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDownMove_Click.name;");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
                          objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);

                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                        "btnDownMove_Click()"),
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "    if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ���Ƶļ�¼!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
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
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���Ƽ�¼��������:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
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
        private void Gene_ReFreshCache(StringBuilder sbCode)
        {
            if (objViewInfoENEx.IsUseCache4List == false)
            {
                return;
            }
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (thisCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else if (thisCacheClassifyFld4View2 == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, thisCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.{2}_Cache, {1}.{3}_Cache);", objViewInfoENEx.TabName, objViewInfoENEx.ClsName,
                        thisCacheClassifyFld4View.FldName,
                        thisCacheClassifyFld4View2.FldName);
                }
            }
            else
            {
                if (thisCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else if (thisCacheClassifyFld4View2 == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, 
                        thisCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.{2}_Cache, {1}.{3}_Cache);", objViewInfoENEx.TabName,
                        objViewInfoENEx.ClsName,
                        thisCacheClassifyFld4View.FldName,
                        thisCacheClassifyFld4View2.FldName
                        );
                }
            }
        }


        public string Gen_Vue_Ts_PreCheck4Order()
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
                strCodeForCs.AppendFormat("\r\n * �ƶ���¼���ʱ��Ԥ��麯��");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public PreCheck4Order(): boolean");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PreCheck4Order.name;");
                if (arrFieldLst_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsEN objInFor in arrFieldLst_Classify)
                    {

                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);
                            if (objInFor.ObjFieldTab().IsNumberType())
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                             objInFor.ObjFieldTab().PrivFuncName1());
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                objInFor.FldName);
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{0}!\");", objInFor.ObjFieldTab().FldName);
                            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                            strCodeForCs.Append("\r\n" + "//console.trace();");
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");

                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
                                objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "PreCheck4Order()"),
                                DataType = "string"
                            });
                            strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                            objInFor.FldName);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{0}!\");", objInFor.ObjFieldTab().FldName);
                            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                            strCodeForCs.Append("\r\n" + "//console.trace();");
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");

                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                        }

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

        public string Gen_Vue_Ts_btnGoBottum_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * �õ�");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoBottum_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGoBottum_Click.name;",
                        objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnGoBottum_Click()"),
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
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
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
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�õ׳�������:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
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
        public string Gen_Vue_Ts_btnReOrder_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnReOrder_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnReOrder_Click.name;",
                    objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
                                    objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            DataType = "string",
                            IsStatic = true
                        });
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            DataType = "string",
                            IsStatic = true
                        });

                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
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
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�����������:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "await this.{0}();", strFuncName4BindGv);

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

        public string Gen_Vue_Ts_Code4QueryRegion()
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

        public string Gen_Vue_Ts_Code4FeatureRegion()
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
        public string Gen_Vue_Ts_Code4ListRegion()
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

        public string Gen_Vue_Ts_Code4DetailRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.DetailRegion_0006)
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



        public string Gen_Vue_Ts_Code4EditRegion()
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
        public string Gen_Vue_Ts_Code4ExcelExportRegion()
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
      
        public string Gen_Vue_Ts_CopyToEx()
        {
            if (bolIsUseFunc == false && bolIsUseFunc4ExcelExport == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:Դ����", strTabName_Out4ListRegion);
            strCodeForCs.AppendFormat("\r\n * @returns Ŀ�����=>cls{0}EN:obj{0}ENT", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n public CopyToEx(obj{0}ENS:cls{0}EN ): cls{0}ENEx", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CopyToEx.name;");
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT = new cls{0}ENEx();", strTabName_Out4ListRegion);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}_CopyObjTo(obj{0}ENS, obj{0}ENT);",
                    strTabName_Out4ListRegion);

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "CopyToEx", "Copy��Ex:{0} �������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})Copy��������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");


            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_FuncMap4ExcelExport()
        {
            if (string.IsNullOrEmpty(strMapFuncCode4ExcelExport) == false) return strMapFuncCode4ExcelExport;
            if (bolIsUseFunc4ExcelExport == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��һ����չ��Ĳ������Խ��к���ת��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n public async FuncMap4ExcelExport(obj{0}:cls{0}ENEx )", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.FuncMap4ExcelExport.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            List<clsExcelExportRegionFldsENEx> arrExcelExportRegionFld_Sel = objViewInfoENEx.arrExcelExportRegionFldSet.FindAll(x => x.IsUseFunc == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.CmPrjId);
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in arrExcelExportRegionFld_Sel)
            {
                strCodeForCs.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldId_Cache(strTabId_Out4ExportExcel, objExcelExportRegionFldsEx.FldId, 1, objViewInfoENEx.CmPrjId);
                if (objDataNode_Curr == null)
                {
                    string strMsg = string.Format("�����ɵ���Excel��ת������ʱ����TabId={0},�ֶ�FldId=[{1}]==>{4}����ؽ��Ϊ��, VersionNo=1, CmPrjId={2}�����飡(In {3})",
                        strTabId_Out4ExportExcel, objExcelExportRegionFldsEx.FldId, objViewInfoENEx.CmPrjId, clsStackTrace.GetCurrClassFunction(), objExcelExportRegionFldsEx.DataPropertyName);
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objExcelExportRegionFldsEx.OutDataNodeId, objViewInfoENEx.PrjId);
                string strLastVarName = "";
                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabId_Cache(strTabId_Out4ExportExcel);
                List<clsDataNodeFuncMapEN> arrPath = null;
                try
                {
                    arrPath = clsDataNodeFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, objExcelExportRegionFldsEx.OutDataNodeId, objViewInfoENEx.CmPrjId);
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strTabId_Out4ListRegion, objExcelExportRegionFldsEx.PrjId);
                    var objFieldTab = clsFieldTabBL.GetObjByFldId_Cache(objExcelExportRegionFldsEx.FldId, objExcelExportRegionFldsEx.PrjId);
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objViewInfoENEx.CmPrjId);
                    string strMsg = string.Format("ת�������У���TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ������:{7}�� VersionNo=1, CmPrjId={2}({5})�����飡(In {6})",
                        strTabId_Out4ListRegion,
                        objExcelExportRegionFldsEx.FldId, objViewInfoENEx.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message, objExcelExportRegionFldsEx.DataPropertyName);
                    throw new Exception(strMsg);
                }
                foreach (var objInFor in arrPath)
                {
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeId_Cache(objInFor.InDataNodeId, objInFor.CmPrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeId_Cache(objInFor.OutDataNodeId, objInFor.CmPrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldId_Cache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldId_Cache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField_TS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldId_Cache(objPrjTab.CacheClassifyField_TS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}.{1}", strTabName_Out4ExportExcel, objCacheClassifyField.PropertyName());
                            }
                            if (arrPath.Count == 1)
                            {
                                if (objDataNode_Start.TabId == strTabId_Out4ExportExcel)
                                {
                                    strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName,
                                        strTabName_Out4ExportExcel,
                                        objFieldTab_Start.PropertyName());
                                }
                                //else
                                //{
                                //    strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeName);
                                //}
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});",
                                objDataNode_End.DataNodeName,
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);
                            if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            {
                                arrTabId4MapFunc.Add(objPrjTab.TabId);
                            }
                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDNFunctionBL.GetObjByDnFunctionId_Cache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == strTabId_Out4ExportExcel)
                                    {
                                        string strIsToString = "";
                                        if (objFieldTab_Start.IsNumberType() == true)
                                        {
                                            strIsToString = ".toString()";
                                        }
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName,
                                            strTabName_Out4ExportExcel,
                                            objFieldTab_Start.PropertyName(), strIsToString);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out4ExportExcel)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out4ExportExcel,
                                        objFieldTab_Start.PropertyName());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out4ExportExcel)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out4ExportExcel,
                                        objFieldTab_Start.PropertyName(),
                                        objDNFun.DnFunctionName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                    strTabName_Out4ExportExcel,
                                    objExcelExportRegionFldsEx.DataPropertyName_FstLcase(),
                                    strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
            }

            //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4ExportExcel);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "FuncMap4ExcelExport", "����ӳ���:{0} �������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ��4ExcelExport��������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_FuncMap()
        {
            if (string.IsNullOrEmpty(strMapFuncCode) == false) return strMapFuncCode;
            if (bolIsUseFunc == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��һ����չ��Ĳ������Խ��к���ת��");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}S:Դ����", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n public async FuncMap(obj{0}:cls{0}ENEx )", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.FuncMap.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            List<clsDGRegionFldsENEx> arrDGRegionFld_Sel = objViewInfoENEx.arrDGRegionFldSet.FindAll(x => x.IsUseFunc == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.CmPrjId);
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFld_Sel)
            {
                strCodeForCs.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldId_Cache(strTabId_Out4ListRegion, objDGRegionFldsEx.FldId, 1, objViewInfoENEx.CmPrjId);
                if (objDataNode_Curr == null)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strTabId_Out4ListRegion, objDGRegionFldsEx.PrjId);
                    var objFieldTab = clsFieldTabBL.GetObjByFldId_Cache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId);
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objViewInfoENEx.CmPrjId);
                    string strMsg = string.Format("ת�������У���TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{7} ����Ӧ�Ľ�㲻���ڡ� VersionNo=1, CmPrjId={2}({5})�����飡(In {6})",
                        strTabId_Out4ListRegion,
                        objDGRegionFldsEx.FldId, objViewInfoENEx.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName, clsStackTrace.GetCurrClassFunction(), objDGRegionFldsEx.DataPropertyName);
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDGRegionFldsEx.OutDataNodeId, objViewInfoENEx.PrjId);
                string strLastVarName = "";
                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabId_Cache(strTabId_Out4ListRegion);
                List<clsDataNodeFuncMapEN> arrPath = null;
                try
                {
                    arrPath = clsDataNodeFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, objDGRegionFldsEx.OutDataNodeId, objViewInfoENEx.CmPrjId);
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strTabId_Out4ListRegion, objDGRegionFldsEx.PrjId);
                    var objFieldTab = clsFieldTabBL.GetObjByFldId_Cache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId);
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objViewInfoENEx.CmPrjId);
                    string strMsg = string.Format("ת�������У���TabId={0}({3}),�ֶ�FldId=[{1}({4})]==>{8}�ڻ�ȡת��·��ʱ������:{7}�� VersionNo=1, CmPrjId={2}({5})�����飡(In {6})",
                        strTabId_Out4ListRegion,
                        objDGRegionFldsEx.FldId, objViewInfoENEx.CmPrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message, objDGRegionFldsEx.DataPropertyName);
                    throw new Exception(strMsg);
                }
                foreach (var objInFor in arrPath)
                {
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeId_Cache(objInFor.InDataNodeId, objInFor.CmPrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeId_Cache(objInFor.OutDataNodeId, objInFor.CmPrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldId_Cache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldId_Cache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField_TS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldId_Cache(objPrjTab.CacheClassifyField_TS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}.{1}", strTabName_Out4ListRegion, objCacheClassifyField.PropertyName());
                            }
                            if (arrPath.Count == 1)
                            {
                                if (objDataNode_Start.TabId == strTabId_Out4ListRegion)
                                {
                                    strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName,
                                        strTabName_Out4ListRegion,
                                        objFieldTab_Start.PropertyName());
                                }
                                //else
                                //{
                                //    strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeName);
                                //}
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});",
                                objDataNode_End.DataNodeName,
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);
                            if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            {
                                arrTabId4MapFunc.Add(objPrjTab.TabId);
                            }
                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDNFunctionBL.GetObjByDnFunctionId_Cache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == strTabId_Out4ListRegion)
                                    {
                                        string strIsToString = "";
                                        if (objFieldTab_Start.IsNumberType() == true)
                                        {
                                            strIsToString = ".toString()";
                                        }
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName,
                                            strTabName_Out4ListRegion,
                                            objFieldTab_Start.PropertyName(), strIsToString);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out4ListRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out4ListRegion,
                                        objFieldTab_Start.PropertyName());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out4ListRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out4ListRegion,
                                        objFieldTab_Start.PropertyName(),
                                        objDNFun.DnFunctionName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                    strTabName_Out4ListRegion,
                                    objDGRegionFldsEx.DataPropertyName_FstLcase(),
                                    strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
            }

            //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "FuncMap", "����ӳ���:{0} �������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})����ӳ���������ݳ���,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {
            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule.FuncModuleEnName,
                   objViewInfoENEx.TabName)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName)
            });

            if (objViewInfoENEx.TabName != objViewInfoENEx.TabName_Out)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                                   objViewInfoENEx.TabName_Out)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                                 objViewInfoENEx.TabName_Out)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule.FuncModuleEnName,
                                objViewInfoENEx.TabName_Out)
                });
            }
            if (objViewInfoENEx.objViewRegion_ExportExcel != null)
            {

                clsPrjTabEN objPrjTabEN_Excel = clsPrjTabBL.GetObjByTabId_Cache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN_Excel = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN_Excel.FuncModuleAgcId, objPrjTabEN_Excel.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objPrjTabEN_Excel.TabName),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN_Excel.FuncModuleEnName,
                             objPrjTabEN_Excel.TabName)
                });

                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objPrjTabEN_Excel.TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN_Excel.FuncModuleEnName,
                           objPrjTabEN_Excel.TabName)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}BL", objPrjTabEN_Excel.TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN_Excel.FuncModuleEnName,
                       objPrjTabEN_Excel.TabName)
                });
            }


            List<string> arrTabId4Ddl = clsViewInfoBLEx.getRelaTabId4Ddl_Qry(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
            foreach (string strTabId in arrTabId4Ddl)
            {
                if (strTabId == objViewInfoENEx.MainTabId) continue;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                //arrImportClass.Add(new ImportClass
                //{
                //    ClassName = string.Format("cls{0}EN", objPrjTabEN.TabName),
                //    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
                //             objPrjTabEN.TabName)
                //});

                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

            }

            string strRegionId_Feature = clsViewRegionBLEx.GetRegionIdByTypeEx(objViewInfoENEx.ViewId, enumRegionType.FeatureRegion_0008, objViewInfoENEx.PrjId);
            List<string> arrTabId4FeatureDdl = clsFeatureRegionFldsBLEx.getRelaTabId4Ddl(strRegionId_Feature, objViewInfoENEx.PrjId);
            foreach (string strTabId in arrTabId4FeatureDdl)
            {
                if (strTabId == objViewInfoENEx.MainTabId) continue;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

            }
            foreach (string strTabId in arrTabId4MapFunc)
            {
                if (strTabId == objViewInfoENEx.MainTabId) continue;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

            }

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("arrSelectedKeys, clsCommFunc4Web", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsCommFunc4Web", objFuncModule.FuncModuleEnName,
        objViewInfoENEx.TabName)
            });

            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("tzDictionary", objViewInfoENEx.TabName),
            //    ModuleName = "Dictionary_js_1",
            //    FilePath = string.Format("tzdictionary", objFuncModule.FuncModuleEnName,
            //   objViewInfoENEx.TabName)
            //});


            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsPager", objViewInfoENEx.TabName),
            //    FilePath = string.Format("../TS/PubFun/clsPager", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //});
            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsStack1Trace", objViewInfoENEx.TabName),
            //    FilePath = string.Format("../TS/PubFun/clsStackTrace", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //});
            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsOrderByData", objViewInfoENEx.TabName),
            //    FilePath = string.Format("../TS/PubFun/clsOrderByData", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //});
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuPagerPara", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/stuPagerPara", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsDataColumn", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsDataColumn", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });
            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsPubFun", objViewInfoENEx.TabName),
            //    FilePath = string.Format("../TS/PubFun/clsPubFun", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //});

      //      arrImportClass.Add(new ImportClass
      //      {
      //          ClassName = string.Format("TransToBool", objViewInfoENEx.TabName),
      //          FilePath = string.Format("../TS/PubFun/jsString", objFuncModule.FuncModuleEnName,
      //objViewInfoENEx.TabName)
      //      });

            //    arrImportClass.Add(new ImportClass
            //    {
            //        ClassName = string.Format("jsString", objViewInfoENEx.TabName),
            //        FilePath = string.Format("../TS/PubFun/jsString", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //    });

  //          arrImportClass.Add(new ImportClass
  //          {
  //              ClassName = string.Format("clsPubSessionStorage", objViewInfoENEx.TabName),
  //              FilePath = string.Format("../TS/PubFun/clsPubSessionStorage", objFuncModule.FuncModuleEnName,
  //objViewInfoENEx.TabName)
  //          });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("Format, IsNullOrEmpty", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsString", objFuncModule.FuncModuleEnName,
 objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsOperateList", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsOperateList", objFuncModule.FuncModuleEnName,
             objViewInfoENEx.TabName)
            });
            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsCommFunc4Ctrl", objViewInfoENEx.TabName),
            //    FilePath = string.Format("../TS/PubFun/clsCommFunc4Ctrl", objFuncModule.FuncModuleEnName,
            // objViewInfoENEx.TabName)
            //});

            if (bolIsUseFunc == true)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}ENEx", strTabName_Out4ListRegion),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}ENEx", objFuncModule.FuncModuleEnName,
                        strTabName_Out4ListRegion)
                });


                //               arrImportClass.Add(new ImportClass
                //               {
                //                   ClassName = string.Format("clsDateTime", objViewInfoENEx.TabName),
                //                   FilePath = string.Format("../TS/PubFun/clsDateTime", objFuncModule.FuncModuleEnName,
                //objViewInfoENEx.TabName)
                //               });


                List<clsDGRegionFldsENEx> arrDGRegionFld_Sel = objViewInfoENEx.arrDGRegionFldSet.FindAll(x => x.IsUseFunc == true);
                //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.CmPrjId);
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFld_Sel)
                {
                    var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldId_Cache(strTabId_Out4ListRegion, objDGRegionFldsEx.FldId, 1, objViewInfoENEx.CmPrjId);
                    if (objDataNode_Curr == null)
                    {
                        string strMsg = string.Format("TabId={0},FldId=[{1}]==>{3}, VersionNo=1, CmPrjId={2}�Ľ��Ϊ�գ����飡(In {4})",
                            strTabId_Out4ListRegion, objDGRegionFldsEx.FldId, objViewInfoENEx.CmPrjId, objDGRegionFldsEx.DataPropertyName, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                    try
                    {
                        //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabId_Cache(strTabId_Out4ListRegion);
                        var arrPath = clsDataNodeFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, objDGRegionFldsEx.OutDataNodeId, objViewInfoENEx.CmPrjId);
                        foreach (var objInFor in arrPath)
                        {

                            switch (objInFor.FuncMapModeId)
                            {
                                case enumFuncMapMode.Table_01:
                                    var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    var objFuncModule_Temp = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab.FuncModuleAgcId, objPrjTab.PrjId);

                                    arrImportClass.Add(new ImportClass
                                    {
                                        ClassName = string.Format("cls{0}EN", objPrjTab.TabName),
                                        FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_Temp.FuncModuleEnName,
                                        objPrjTab.TabName)
                                    });

                                    arrImportClass.Add(new ImportClass
                                    {
                                        ClassName = string.Format("cls{0}WApi", objPrjTab.TabName),
                                        FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_Temp.FuncModuleEnName,
                                        objPrjTab.TabName)
                                    });

                                    break;
                            }

                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("������ImportClassʱ���ִ���{0}. (in {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                    }
                }

            }


            List<string> arrTabName = new List<string>();
            foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
            {
                if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                if (string.IsNullOrEmpty(objInfor.Ds_TabId) == true) continue;
                if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                arrTabName.Add(objInfor.Ds_TabName);
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(objInfor.Ds_TabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objInfor.Ds_TabName),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
          objInfor.Ds_TabName)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objInfor.Ds_TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                          objInfor.Ds_TabName)
                });
            }
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                  objViewInfoENEx.TabName_Out)
            });


            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            return arrImportClass;
        }

        public string Gen_Vue_Ts_SetEventFunc()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** ��������:�����¼�����");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async SetEventFunc()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetEventFunc.name;");
                strCodeForCs.Append("\r\n" + "// �ڴ˴������û������Գ�ʼ��ҳ��");


                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //����Page_Load�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = clsCommFunc4Ctrl.GetSelectObjInDiv(this.divName4List, '{0}');",
                                    x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ this.{1}(); }});",
                      x.CtrlId, x.ChangeEvent, objViewInfoENEx.ClsName);
                });

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    switch (objCtlTypeAbbr.HtmlCtrlTypeName)
                    {
                        case "HTMLButtonElement":
                            strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} =clsCommFunc4Ctrl.GetButtonObjInDiv(this.divName4List, '{0}');",
                                 x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                            break;
                        case "HTMLInputElement":
                            strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} =clsCommFunc4Ctrl.GetInputObjInDiv(this.divName4List, '{0}');",
                                 x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                            break;
                        default:
                            var strMsg = String.Format("�ؼ�����(HtmlCtrlTypeName):{0}��switch��û�б�����(In {1})", objCtlTypeAbbr.HtmlCtrlTypeName,
                                clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('click', e => {{ this.{1}(); }});",
                      x.CtrlId, x.ClickEvent, objViewInfoENEx.ClsName);
                });
                if (arrQryRegionFlds_ChangeEvent.Count == 0 && arrQryRegionFlds_ClickEvent.Count == 0)
                {
                    strCodeForCs.Append("\r\n" + "console.log('�ڱ������У�û�ж���ؼ�������¼���');");
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ҳ���������ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
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

        public string Gen_Vue_Ts_GeneEventFunc()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /** ��������:ϵͳ���ɵ�Change�¼�����");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;//",
                       x.ChangeEvent);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('������չ��:{0}Ex�и��Ǹú�����');", objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** ��������:ϵͳ���ɵ�Click�¼�����");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;",
                       x.ClickEvent, objViewInfoENEx.ClsName);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('������չ��:{0}Ex�и��Ǹú�����');", objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

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


        public clsPrjTabFldENEx thisCacheClassifyFld4View
        {
            get
            {
                if (objViewInfoENEx.objCacheClassifyFld4View_TS != null) return objViewInfoENEx.objCacheClassifyFld4View_TS;
                if (objViewInfoENEx.objCacheClassifyFld4View != null) return objViewInfoENEx.objCacheClassifyFld4View;
                return null;
            }

        }
        public clsPrjTabFldENEx thisCacheClassifyFld4View2
        {
            get
            {
                if (objViewInfoENEx.objCacheClassifyFld4View2_TS != null) return objViewInfoENEx.objCacheClassifyFld4View2_TS;
                if (objViewInfoENEx.objCacheClassifyFld4View2 != null) return objViewInfoENEx.objCacheClassifyFld4View2;
                return null;
            }
        }

    }
}
