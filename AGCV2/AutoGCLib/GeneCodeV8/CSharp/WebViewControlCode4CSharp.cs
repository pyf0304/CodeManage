using System;
using System.Text;
using System.IO;
using com.taishsoft.file;

using System.Collections;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using AGC.Entity;

using AGC.BusinessLogic;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;

namespace AutoGCLib
{
  
    /// <summary>
    /// �Զ����ɽ�����Ʋ�Ĵ�����(Control of Mvc)
    /// </summary>
    public class WebViewControlCode4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        
        private string strTabName_Out4ListRegion = "";

        //private string thisCacheClassify4View.VarDef4Fld = "";
        List<string> arrFunctionName4Code = null;
        private bool IsHaveEditRegion = true;
        protected bool mbolIsUseCtl = true;
        protected bool bolIsUseWuc4Gv = true;
        #region ���캯��


        public WebViewControlCode4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("vs{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
        }
        public WebViewControlCode4CSharp(string strViewId)
      : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            //this.strDataBaseType = clsPubConst.con_MsSql;
            //InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("vs{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
        }
        
        public WebViewControlCode4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("vs{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
        }
        #endregion

        /// <summary>
        /// ����<��ʾ�б��༭����>
        /// </summary>
        /// <returns></returns>
        private string GenDispListAndEditRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///�������WebForm�Ĵ���;
            //			string strTemp; ///��ʱ����;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ֿ��ƺ���,��ʾ���ڱ༭���û��ؼ�,�����������б���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void DispEdit{0}Region()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ֿ��ƺ���,��ʾ�����б���,���������ڱ༭���û��ؼ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void Disp{0}ListRegion()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

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
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( {2}1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsDateTime.getTodayDateTimeStr(0))//(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, 
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable()         );
                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsCommonSession.UserId)//(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            //if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CacheClassifyField_37)
            //{
            //    sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2})",
            // objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, thisCacheClassify4View.VarDef4Fld);

            //}
            //else
            //{
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2}1.{3})",
                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
            //}
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
                     
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            
            StringBuilder sbCodeForCs = new StringBuilder();

            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0003") //ֻд
            {
                sbCodeForCs.AppendFormat("\r\n" + "{0}1.{1} = pobj{2}BL.Get{3}();",
                  this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            else if (objEditRegionFldsEx.FldOpTypeId() == "0002") //ֻ��
            {
                sbCodeForCs.AppendFormat("\r\n" + "{0}1.{1} = pobj{2}EN.{3};",
                  this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), 
                  objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "{0}1.{1} = pobj{2}EN.{3};",
                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), 
                    objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache":"");
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        //public string GeneCode11(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
        //    {
        //        case enumViewTypeCodeTab.Table_Insert_1:// "0001":	//�������
        //            return GenInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_Update_2:// "0002":	//�����޸�
        //            return GenUpdRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_Query_3:// "0003":	//�����ѯ
        //            return GenQueryRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        //case enumViewTypeCodeTab.Table_QUDI_4:// "0004":	//�����QUDI
        //        //    return GenQueryUpdDelInsRecControlCodeWithWuc4Gv(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QI_5:// "0005":	//����Ĳ�ѯ����
        //            return GenQueryInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QU_6:// "0006":	//����Ĳ�ѯ�޸�
        //            return GenQueryUpdRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QD_7:// "0007":	//����Ĳ�ѯɾ��
        //            return GenQueryDelRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_UI_9:// "0009":	//����Ĳ����޸�
        //            return GenUpdInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QUD_18:// "0018":	//����Ĳ�ѯ�޸�ɾ��
        //            return GenQueryUpdDelRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11:// "0019":	//����Ĳ�ѯɾ��,�����޸ġ����
        //            return GenQueryDel_UpdInsRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        case enumViewTypeCodeTab.Table_List_14:
        //            return GenQueryRecControlCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //        default:
        //            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
        //            string strMsg = string.Format("�������ͣ�[{0}({1})]�ں���:[{2}]��û�б�����,����ϵ����Ա!",
        //                objViewTypeCodeTabEN.ViewTypeName,
        //                objViewInfoENEx.ViewTypeCode,
        //                clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(strMsg);
        //    }
        //    //return "";
        //}
    
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                IsHaveEditRegion = false;
                //StringBuilder sbMessage = new StringBuilder();
                //string strViewName = objViewInfoENEx.ViewName;
                //sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                //sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                //throw new clsDbObjException(sbMessage.ToString());
            }


            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            strTabName_Out4ListRegion = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objViewInfoENEx.WebFormName = string.Format("{0}", this.ClsName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache":"");
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.aspx.cs", objViewInfoENEx.FolderName, this.ClsName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            
            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                //strCodeForCs.Append("\r\n ///���ɲ�ѯ,�޸�,ɾ��,��Ӽ�¼�Ŀ��Ʋ����");

                strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Webform", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} ��ժҪ˵��������Q�����ѯ,U�����޸�", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : System.Web.UI.Page", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = 
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //         clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //         objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId)
                //                       .OrderBy(x => x.OrderNum);

                //int intCount1 = arrvFunction4GeneCodeObjLst.Count();
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
                //int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());

                //int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);

                //int intCount5 = arrvFunction4GeneCodeObjLst_All.Count();
                arrFunctionName4Code = arrvFunction4GeneCodeObjLst.Select(x=>x.FuncName4Code).ToList();
                //arrvFunction4GeneCodeObjLst.Distinct((x,y )=> x.FuncId4GC != y.FuncId4GC);
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
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
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch(Exception objException)
                    {
                        throw objException;
                    }
                }


                strCodeForCs.Append("\r\n" + "");
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

        public string Gen_WebView_CS_Page_Load()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
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
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}= \"\";", thisCacheClassify4View.VarDef4Fld);
                }
                    strCodeForCs.Append("\r\n" + "//1����ʼ��,��ʼ��һЩ����ExcelҪ�õı���");
                strCodeForCs.AppendFormat("\r\n" + "vsViewName = \"{0}\";", objViewInfoENEx.ViewCnName);
                strCodeForCs.AppendFormat("\r\n" + "vsTabName = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                            objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//2���û�Ȩ�޹���:����ǰ�û��ڵ�ǰ�����Ȩ����ز���");
                strCodeForCs.Append("\r\n" + "AccessUserPotence();");

                //����Page_Load�еİ�������Ĵ���
                strCodeForCs.Append("\r\n" + "//3���󶨲�ѯ����������");
                strCodeForCs.Append("\r\n" + "BindDdl4QueryRegion();");

                strCodeForCs.Append("\r\n" + GenDdlBind4ViewFeatureInPage_Load());

                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.Append("\r\n" + "//4�������б����������ֶ�");
                    strCodeForCs.AppendFormat("\r\n" + "{2}1.SetSortBy(string.Format(\"{{0}} Asc\", con{1}.{0}));",
                        objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, 
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache":"");
                }

                strCodeForCs.Append("\r\n" + "//5����ʾ�������ı�������GridView��");
                if (bolIsUseWuc4Gv == true)
                {

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                }
                if (IsHaveEditRegion)
                {

                    //strCodeForCs.Append("\r\n" + "//6�����ñ�ؼ����ֶοؼ���ReadOnly����,");
                    //strCodeForCs.Append("\r\n" + "// ʹֻ֮��,��Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�");

                    //if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);", this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    //}
                    if (arrFunctionName4Code.Contains("DispTabNameListRegion()"))
                    {
                        strCodeForCs.Append("\r\n" + "//6����ʾ�б�����,���ر༭����,");
                        strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "//7�������߼���Ĺ�������,����������ˢ�º���");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}BL.objCommFun4BL = new clsCommFun4BL4{0}();",
                    objViewInfoENEx.TabName);

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
        public string Gen_WebView_CS_btnQuery_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<��ѯ>��ťʱ���������¼�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��GridView�ĵ�ǰҳ��������Ϊ0,����1ҳ��");
                strCodeForCs.Append("\r\n" + "//��������ѯʱ,������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�");
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " {0}1.vsPageIndex = 1;",
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    strCodeForCs.AppendFormat("\r\n" + "//�ѱ��¼��������ʾ��GridView��");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gv{0}.pageIndex = 0;", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�ѱ��¼��������ʾ��GridView��");
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
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

        public string Gen_WebView_CS_BindDropDownLst4EditRegion()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:Ϊ�༭���ؼ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindDdl4EditRegion()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
        
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "if (vsIsBindDdl4Edit == true) return;");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (IsHaveEditRegion)
                {
                    foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                    {
                        if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                        {
                            var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                            var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                            if (arrTabFeatureFlds_Cond.Count == 0)
                            {
                                objInfor.VarIdCond1 = "";
                                objInfor.VarIdCond2 = "";
                                objInfor.FldIdCond1 = "";
                                objInfor.FldIdCond2 = "";
                            }
                            else if (arrTabFeatureFlds_Cond.Count == 1)
                            {
                                objInfor.VarIdCond2 = "";
                                objInfor.FldIdCond2 = "";
                            }
                        }
                        if (objInfor.RegionTypeId == enumRegionType.QueryRegion_0001) continue;
                        if (objInfor.RegionTypeId == enumRegionType.FeatureRegion_0008) continue;

                        //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_SetBindDdl(objVarManage));

                        if (objInfor.objFieldTabCacheClassify() == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetDdl{1}();",
                                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objInfor.FldName);
                        }
                        else
                        {
                            var strVariableName = objInfor.objFieldTabCacheClassify().PrivFuncName();
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {
                                objVarManage.SetVariableProp(strVariableName, "\"\"", "");
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetDdl{1}({2});",
                                   this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objInfor.FldName,
                                   strVariableName);
                        }

                    }

                }
                strCodeForCs.Append("\r\n" + "vsIsBindDdl4Edit = true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindDdl4EditRegion", "�󶨱༭�����������!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})�󶨱༭�����������!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindDropDownLst4QueryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:Ϊ��ѯ���ؼ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindDdl4QueryRegion()", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
       
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.RegionTypeId == enumRegionType.FeatureRegion_0008) continue;

                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl(objVarManage));

                }
               

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindDdl4QueryRegion", "�󶨲�ѯ�����������!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})�󶨲�ѯ�����������!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindGridView4WucInPage()
        {
            if (this.IsUseFunc == true) return "";
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                return "";
            }
            else
            {
            }

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ�;");
                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView����;");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ���");
                strCodeForCs.AppendFormat("\r\n" + "//{0}{2}1.SetGvVisibility(con{1}.UpdDate, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "//{0}{2}1.SetGvVisibility(con{1}.UpdUser, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                      objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView������");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(strWhereCond);",
                  strTabName_Out4ListRegion, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}", "��GridView����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})��GridView����!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindGridView4WucInPageCache()
        {
            if (this.IsUseFunc == true) return "";
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
             
            }
            else
            {
                return "";
            }
            clsQryRegionFldsENEx objQryRegionFldsENExCacheClassifyFld = objViewInfoENEx.arrQryRegionFldSet.Find(x => x.ObjFieldTabENEx.FldId == objViewInfoENEx.objInRelaTab.CacheClassifyField);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}Cache()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ�;");
                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView����;");
                strCodeForCs.Append("\r\n" + "");
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                    //strCodeForCs.AppendFormat("\r\n" + "if (ddl{0}_q.SelectedIndex <= 0)", objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName);
                    //strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid: WebI000143)��ѡ��{0}!\";",
                    //    objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.Caption);
                    //strCodeForCs.AppendFormat("\r\n" + "ddl{0}_q.Focus();", objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName);
                    //strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    //strCodeForCs.Append("\r\n" + "return;");
                    //strCodeForCs.Append("\r\n" + "}");
                    if (objQryRegionFldsENExCacheClassifyFld.FldName == objViewInfoENEx.objCacheClassifyFld4View.FldName)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1};",
                            objQryRegionFldsENExCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = \"\";",
                            objQryRegionFldsENExCacheClassifyFld.FldName);
                    }
                    //strCodeForCs.AppendFormat("\r\n" + " {1}1.vs{0} = str{0};",
                    //    objQryRegionFldsENExCacheClassifyFld.FldName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002));

                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ���");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdDate, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdUser, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = Combine{0}ConditionObj();",
                    objViewInfoENEx.TabName_Out);
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.Set{1}({2}, \"=\");",
                        objViewInfoENEx.TabName_Out,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.PrivFuncName);
                }
                    strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView������");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}Cache(obj{2}Cond);",
                  objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");



                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}Cache", "��GridView����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})��GridView����!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BindGridViewByFunc()
        {
            if (this.IsUseFunc == false) return "";
   
            clsQryRegionFldsENEx objQryRegionFldsENExCacheClassifyFld = objViewInfoENEx.arrQryRegionFldSet.Find(x => x.ObjFieldTabENEx.FldId == objViewInfoENEx.objInRelaTab.CacheClassifyField);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ////*��1�ɰ�GridView�Ĵ���*/");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�Ѳ�ѯ���ݰ���GridView�ϡ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��GridView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void BindGv_{0}ByFunc()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��5��)");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ�;");
                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView����;");
                strCodeForCs.Append("\r\n" + "");
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                    //strCodeForCs.AppendFormat("\r\n" + "if (ddl{0}_q.SelectedIndex <= 0)", objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName);
                    //strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid: WebI000143)��ѡ��{0}!\";",
                    //    objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.Caption);
                    //strCodeForCs.AppendFormat("\r\n" + "ddl{0}_q.Focus();", objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName);
                    //strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    //strCodeForCs.Append("\r\n" + "return;");
                    //strCodeForCs.Append("\r\n" + "}");
                    if (objQryRegionFldsENExCacheClassifyFld.FldName == objViewInfoENEx.objCacheClassifyFld4View.FldName)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1};",
                            objQryRegionFldsENExCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = \"\";",
                            objQryRegionFldsENExCacheClassifyFld.FldName);
                    }
                    //strCodeForCs.AppendFormat("\r\n" + " {1}1.vs{0} = str{0};",
                    //    objQryRegionFldsENExCacheClassifyFld.FldName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002));

                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1������Gv�ؼ���ĳЩ�в��ɼ���");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdDate, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetGvVisibility(con{1}.UpdUser, false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    objViewInfoENEx.TabName_Out, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                strCodeForCs.Append("\r\n" + "//	2����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = Combine{0}ConditionObj();",
                    strTabName_Out4ListRegion);
                if (objQryRegionFldsENExCacheClassifyFld != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.Set{1}({2}, \"=\");",
                        strTabName_Out4ListRegion,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.FldName,
                        objQryRegionFldsENExCacheClassifyFld.ObjFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//	3�����ÿؼ��еİ�GridView������");
                strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}ByFunc(obj{2}Cond);",
                  strTabName_Out4ListRegion, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindGv_{0}Cache", "��GridView����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})��GridView����!\" + objException.Message;", strErrId);

                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WebView_CS_CombineConditionObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected cls{0}EN Combine{0}ConditionObj()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    strTabName_Out4ListRegion);


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.CtlTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case enumCtlType.CheckBox_02:
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumCtlType.DropDownList_06: ///����ؼ���������;
                        case enumCtlType.DropDownList_Bool_18: ///����ؼ���������;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex == 1)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue!= \"\" && this.{1}.SelectedValue!= \"0\")",
                                objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.SelectedValue, \"=\");",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(int.Parse( this.{2}.SelectedValue.ToString()), \"=\");",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.SelectedValue, \"=\");",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case enumCtlType.TextBox_16: ///����ؼ��������ı���;
                        case enumCtlType.TextArea_41: ///����ؼ��������ı���;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.Text.Trim(), \"=\");",
                                    strTabName_Out4ListRegion,
                                   objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());
                                }
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.Text.Trim());",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.CtrlId(),
                             strTabName_Out4ListRegion,
                             "{", "}");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(string.Format(\"{{0}}\", this.{2}.Text.Trim()), \"like\");",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{2}.{0}, this.{1}.Text.Trim());",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId(),
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///��Χ��ѯ;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.Text.Trim(), \"=\");",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.{2}.Text.Trim(), \"=\");",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.CtrlId(),
                                      strTabName_Out4ListRegion,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case enumCtlType.HyperLink_07:
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

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       strTabName_Out4ListRegion);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Combine{0}ConditionObj", "����ϲ�ѯ����(Combine{0}ConditionObj)ʱ����!����ϵ����Ա!", "���ɴ���");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{1})����ϲ�ѯ����(Combine{0}ConditionObj)ʱ����!����ϵ����Ա!\" + objException.Message);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", strTabName_Out4ListRegion);
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

        public string Gen_WebView_CS_CombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected string Combine{0}Condition()", strTabName_Out4ListRegion);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    strTabName_Out4ListRegion);


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.CtlTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case enumCtlType.CheckBox_02:
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                        objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                                strTabName_Out4ListRegion,
                                objQryRegionFldsEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumCtlType.DropDownList_06: ///����ؼ���������;
                        case enumCtlType.DropDownList_Bool_18: ///����ؼ���������;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex == 1)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = true;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex == 2)",
                                objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                             strTabName_Out4ListRegion,
                             objQryRegionFldsEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     strTabName_Out4ListRegion,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue!= \"\" && this.{1}.SelectedValue!= \"0\")",
                                objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    case "int":

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = int.Parse( this.{2}.SelectedValue.ToString());",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                    default:

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.SelectedValue;",
                                             strTabName_Out4ListRegion,
                                            objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.SelectedValue);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.CtrlId(),
                                        strTabName_Out4ListRegion,
                                        "{", "}");
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case enumCtlType.TextBox_16: ///����ؼ��������ı���;
                        case enumCtlType.TextArea_41: ///����ؼ��������ı���;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                                    strTabName_Out4ListRegion,
                                   objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.CtrlId());
                                }
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{2}.{0}, this.{1}.Text.Trim());",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.CtrlId(),
                             strTabName_Out4ListRegion,
                             "{", "}");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{2}.{0}, this.{1}.Text.Trim());",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId(),
                                     strTabName_Out4ListRegion,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///��Χ��ѯ;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.CtrlId(),
                                strTabName_Out4ListRegion,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId());
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(strTabName_Out4ListRegion);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.{2}.Text.Trim();",
                             strTabName_Out4ListRegion,
                            objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{2}.{0}, this.{1}.Text.Trim());",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.CtrlId(),
                                      strTabName_Out4ListRegion,
                                     "{", "}");
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

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckProperty4Condition();",
                       strTabName_Out4ListRegion);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Combine{0}Condition", "����ϲ�ѯ����(Combine{0}Condition)ʱ����!����ϵ����Ա!", "���ɴ���");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{1})����ϲ�ѯ����(Combine{0}Condition)ʱ����!����ϵ����Ա!\" + objException.Message);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
        public string Gen_WebView_CS_vsPageSize()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ר�����ڼ�¼GridView�е�ÿҳ��¼��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public int vsPageSize");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize;");
                strCodeForCs.Append("\r\n" + "strPageSize = (string)ViewState[\"pageSize\"];");
                strCodeForCs.Append("\r\n" + "if (strPageSize == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strPageSize = \"\";");
                strCodeForCs.Append("\r\n" + "return 15;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageSize = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"pageSize\", strPageSize);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_vsIsBindDdl4Edit()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {                        
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ר�����ڼ�¼��ǰ�����Ƿ�󶨱༭����������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public bool vsIsBindDdl4Edit");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strIsBindDdl4Edit;");
                strCodeForCs.Append("\r\n" + "strIsBindDdl4Edit = (string)ViewState[\"IsBindDdl4Edit\"];");
                strCodeForCs.Append("\r\n" + "if (strIsBindDdl4Edit == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return bool.Parse(strIsBindDdl4Edit);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strIsBindDdl4Edit = value.ToString();");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"IsBindDdl4Edit\", strIsBindDdl4Edit);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_btnAddNewRecord_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n ///����¼�¼���¼�����,�����ڸù����е�����������,��Ҫ��������Ӷ��д��롣");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����¼�¼���¼����� ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnAddNewRecord_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                    objViewInfoENEx.TabName);
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
                    objViewInfoENEx.TabName);

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

        public string Gen_WebView_CS_btnAddNewRecordWithMaxId_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n ///����¼�¼���¼�����,�����ڸù����е�����������,��Ҫ��������Ӷ��д��롣");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����¼�¼���¼����� ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnAddNewRecordWithMaxId_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordWithMaxId();",
                    objViewInfoENEx.TabName);
                }
                else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                    strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = ADD\");",
                    objViewInfoENEx.TabName);

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


        public string Gen_WebView_CS_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                //���ɵĲ����¼׼�����̴���for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�����¼��׼������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}Record()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1���󶨱༭����������");
                strCodeForCs.Append("\r\n" + "BindDdl4EditRegion();");

                strCodeForCs.Append("\r\n" + "//2�����ùؼ����ֶο��Ա༭");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                strCodeForCs.Append("\r\n" + "//3���ı���ر༭��ť��״̬");

                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ�����\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ�����\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//4���������ʱ�༭����ؼ��ĳ�ֵ");

                //��ȡ���ֵ
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.{2} = cls{1}BL.GetMaxStrId_S();",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "//{2}1.{1} = cls{0}BL.GetMaxStrId_S();",
                            objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                clsEditRegionFldsENEx objEditField_OrderNum = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.OrderNumField_09);
                clsEditRegionFldsENEx objEditField_Classify = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.ClassificationField_10);
if (objEditField_OrderNum != null)
                {
                    if (objEditField_Classify == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCount() + 1;", 
                            objViewInfoENEx.TabName, 
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = \"\";",
                            objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}}='{{1}}'\", con{0}.{1}, {2});",
                             objViewInfoENEx.TabName, objEditField_Classify.FldName, objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        //wucReferFilesB1.OrderNum = clsReferFilesBL.GetRecCountByCond(strCondition) + 1;
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCountByCond(strCondition) + 1;",
                            objViewInfoENEx.TabName,
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();",
                            objViewInfoENEx.TabName);
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

        public string Gen_WebView_CS_AddNewRecordWithMaxId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                //���ɵĲ����¼׼�����̴���for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�����¼��׼������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}RecordWithMaxId()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1���󶨱༭����������");
                strCodeForCs.Append("\r\n" + "BindDdl4EditRegion();");

                strCodeForCs.Append("\r\n" + "//2�����ùؼ����ֶο��Ա༭");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(false);",
                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                strCodeForCs.Append("\r\n" + "//3���ı���ر༭��ť��״̬");

                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ�����\";");
                strCodeForCs.Append("\r\n" + "btnOKUpd.CommandArgument = \"AddWithMaxId\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ�����\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//4���������ʱ�༭����ؼ��ĳ�ֵ");

                //��ȡ���ֵ
                //if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "{0}1.{2} = cls{1}BL.GetMaxStrId_S();",
                //        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);
                //}
                //else
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//{2}1.{1} = cls{0}BL.GetMaxStrId_S();",
                //            objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName,
                //            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                //}
                clsEditRegionFldsENEx objEditField_OrderNum = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.OrderNumField_09);
                clsEditRegionFldsENEx objEditField_Classify = objViewInfoENEx.arrEditRegionFldSet4InUse.Find(x => x.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.ClassificationField_10);
                if (objEditField_OrderNum != null)
                {
                    if (objEditField_Classify == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCount() + 1;",
                            objViewInfoENEx.TabName,
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = \"\";",
                            objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}}='{{1}}'\", con{0}.{1}, {2});",
                             objViewInfoENEx.TabName, objEditField_Classify.FldName, objEditField_Classify.ObjFieldTabENEx.PrivFuncName);
                        //wucReferFilesB1.OrderNum = clsReferFilesBL.GetRecCountByCond(strCondition) + 1;
                        strCodeForCs.AppendFormat("\r\n" + "{2}1.{1} = cls{0}BL.GetRecCountByCond(strCondition) + 1;",
                            objViewInfoENEx.TabName,
                            objEditField_OrderNum.FldName,
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                    }
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();",
                            objViewInfoENEx.TabName);
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


        public string Gen_WebView_CS_AddNewRecordSave()
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

                strCodeForCs.AppendFormat("\r\n" + "protected bool Add{0}RecordSave()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.Append("\r\n" + "//3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
             objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "�ؼ��������������Ͳ���ȷ����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})�ؼ��������������Ͳ���ȷ����!\";", strErrId);
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}EN obj{1}EN;	//�������", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("{0}1.", this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003)), objViewInfoENEx);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN({2});	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                }
                strCodeForCs.Append("\r\n" + "");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "Ϊ����ֵ���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})Ϊ����ֵ���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n //5��ʹ����չ��ӷ���,���߼���ȥ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddRecordEx();", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "��Ӽ�¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})��Ӽ�¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"��Ӽ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"��Ӽ�¼�ɹ�!\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();		//��տؼ�������",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n ///�ָ�<ȷ�����>���<���>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"���\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���༭\";",
                objViewInfoENEx.TabName);

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

        public string Gen_WebView_CS_AddNewRecordWithMaxIdSave()
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

                strCodeForCs.AppendFormat("\r\n" + "protected bool Add{0}RecordWithMaxIdSave()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.Append("\r\n" + "//3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
             objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordWithMaxIdSave", "�ؼ��������������Ͳ���ȷ����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})�ؼ��������������Ͳ���ȷ����!\";", strErrId);
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}EN obj{1}EN;	//�������", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    //string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("{0}1.", this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003)), objViewInfoENEx);
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN({2});	//��ʼ���¶���",
                    //objViewInfoENEx.TabName, objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordWithMaxIdSave", "Ϊ����ֵ���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})Ϊ����ֵ���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n //5��ʹ����չ��ӷ���,���߼���ȥ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddRecordEx();", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordWithMaxIdSave", "��Ӽ�¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})��Ӽ�¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"��Ӽ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"��Ӽ�¼�ɹ�!\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();		//��տؼ�������",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n ///�ָ�<ȷ�����>���<���>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"���\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���༭\";",
                objViewInfoENEx.TabName);

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


        public string Gen_WebView_CS_AddNewRecordSave_Old()
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

                strCodeForCs.AppendFormat("\r\n" + "protected bool Add{0}RecordSave_Old()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.Append("\r\n" + "//3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//5����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
             objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave_Old", "�ؼ��������������Ͳ���ȷ����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})�ؼ��������������Ͳ���ȷ����!\";", strErrId);
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2��������󲢳�ʼ������");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}EN obj{1}EN;	//�������", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("{0}1.", this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003)), objViewInfoENEx);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN({2});	//��ʼ���¶���",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                }
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "//3.1���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    string strKeyFldNameLstStrWithAddStr = KeyFldNameLstStrWithAddStr(string.Format("obj{0}EN.", objViewInfoENEx.TabName), objViewInfoENEx);
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.Append("\r\n" + "");

                        strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,����Ҫ��������Ƿ��Ѿ�����,�����ʱ,�ٻ�ȡ ���ֵ��Ϊ����");
                        strCodeForCs.AppendFormat("\r\n" + "//if (cls{0}BL.IsExist({1}))	//�ж��Ƿ�����ͬ�Ĺؼ���",
                            objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                        strCodeForCs.Append("\r\n" + "//{");
                        strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                            objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "�ؼ����ֶ�������ͬ��ֵ", "���ɴ���");

                        strCodeForCs.AppendFormat("\r\n" + "//strMsg = \"(errid:{0})�ؼ����ֶ�������ͬ��ֵ\";", strErrId);

                        strCodeForCs.Append("\r\n" + "//clsCommonJsFunc.Alert(this, strMsg);");
                        strCodeForCs.Append("\r\n" + "//return false;");
                        strCodeForCs.Append("\r\n" + "//}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}))	//�ж��Ƿ�����ͬ�Ĺؼ���",
                    objViewInfoENEx.TabName, strKeyFldNameLstStrWithAddStr);
                        strCodeForCs.Append("\r\n" + "{");


                        strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                            objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "�ؼ����ֶ�������ͬ��ֵ", "���ɴ���");

                        strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})�ؼ����ֶ�������ͬ��ֵ\";", strErrId);

                        strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//4����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave_Old", "Ϊ����ֵ���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})Ϊ����ֵ���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n //5.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);

                string strDuplicateInfo = "";
                string strDuplicateInfo4ObjValue = "";
                bool bolIsFirst = true;
                int intCount = 0;
                //���Ψһ��------------------------------------------------------
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.IsTabUnique() == true
                    && objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})=[{{{2}}}]",
                                  objEditRegionFldsEx.LabelCaption,
                                objEditRegionFldsEx.FldName, intCount++);

                            strDuplicateInfo4ObjValue += string.Format("obj{0}EN.{1}",
                                                              objViewInfoENEx.TabName,
                                                            objEditRegionFldsEx.FldName);

                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})=[{{{2}}}]",
                              objEditRegionFldsEx.LabelCaption,
                               objEditRegionFldsEx.FldName, intCount++);

                            strDuplicateInfo4ObjValue += string.Format(", obj{0}EN.{1}",
                                                              objViewInfoENEx.TabName,
                                                            objEditRegionFldsEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n ///5.2�����Ψһ��");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"({0})�Ѿ�����,�����ظ�!\", {1});",
                           strDuplicateInfo, strDuplicateInfo4ObjValue);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //���Ψһ�� == == == == == == == == == == == == == == == == == == == == == == == == 


                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,���������ʱ,�Զ���ȡ����ֵ��");
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                        objMainPrjTab.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + " }");
                }
                strCodeForCs.Append("\r\n" + "//6��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave_Old", "��Ӽ�¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})��Ӽ�¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"��Ӽ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"��Ӽ�¼�ɹ�!\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.Append("\r\n" + "//7��������ļ�¼������ʾ��GridView��");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();		//��տؼ�������",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n ///�ָ�<ȷ�����>���<���>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"���\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���༭\";",
                objViewInfoENEx.TabName);

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


        public string Gen_WebView_CS_btnUpdateRecord_Click()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnUpdateRecord_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///�޸ĵ�ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                    clsViewInfoBLEx.KeyFldNameLstStrWithQuote(objViewInfoENEx), objViewInfoENEx.TabName);


                    strCodeForCs.Append("\r\n" + "if (lstKeyValue.Count == 0) ");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdateRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");
                    int intKeyIndex = 0;
                    strCodeForCs.Append("\r\n" + "string[] strKeys = lstKeyValue[0].Split(',');");

                    foreach (clsPrjTabFldENEx objKeyPrjTabFld in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(strKeys[{1}]);",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex, objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        intKeyIndex++;
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdateRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
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

        public string Gen_WebView_CS_btnCopyRecord_Click()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnCopyRecord_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���Ƶ�ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");



                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gv{1},{0});",
                    clsViewInfoBLEx.KeyFldNameLstStrWithQuote(objViewInfoENEx), objViewInfoENEx.TabName);


                    strCodeForCs.Append("\r\n" + "if (lstKeyValue.Count == 0) ");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                       objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnCopyRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");
                    int intKeyIndex = 0;
                    strCodeForCs.Append("\r\n" + "string[] strKeys = lstKeyValue[0].Split(',');");

                    foreach (clsPrjTabFldENEx objKeyPrjTabFld in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex);
                                break;
                            case "int":
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}.Parse(strKeys[{1}]);",
                                objKeyPrjTabFld.KeyVarDefineStr, intKeyIndex, objKeyPrjTabFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                                break;
                        }
                        intKeyIndex++;
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "CopyRecord({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnCopyRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
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

        public string Gen_WebView_CS_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                            enumRegionType.QueryRegion_0001)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string  strFuncName = objvFunction4GeneCodeEN.FuncName;
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

        public string Gen_WebView_CS_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunction4GeneCodeBLEx.GetObjLst4FeatureRegionByViewInfoEx(objViewInfoENEx);

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

        public string Gen_WebView_CS_Code4ExcelExportRegion()
        {
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


        public string Gen_WebView_CS_ShowData()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:���Ըùؼ��ֵļ�¼������ʾ�ڽ�����,");
                    strCodeForCs.Append("\r\n ///������   �������ǰ�ֵ������ؼ���");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">���¼�Ĺؼ���,��ʾ�ñ�ؼ��ֵ�����</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void ShowData({0})",
                    objViewInfoENEx.KeyVarDefineLstStr);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//��������:");
                    strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                    strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objKeyField.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objKeyField.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ����,��������ھͷ��ز���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}) == false)		//���ùؼ��ֵļ�¼�Ƿ����",
                    objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "{");


                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "�ڱ�[{1}]��,�ؼ���Ϊ:[{0}]�ļ�¼������!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{2})�ڱ�[{1}]��,�ؼ���Ϊ:[{0}]�ļ�¼������!\";",
                      objKeyField.PrivFuncName,
                      objViewInfoENEx.TabName, strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN = new cls{1}EN({2});",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.Get{1}(ref obj{0}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "����ʾ����ʱ��ȡ��¼���󲻳ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})����ʾ����ʱ��ȡ��¼���󲻳ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"obj{0}EN\", obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���");
                    strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{1}EN);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
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

        public string Gen_WebView_CS_GetDataFromClass()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                if ((mbolIsUseCtl == false))
                {
                    ///������ȡ���ݴ�������:protected void GetDataFromClass;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:������������������ʾ��������");
                    strCodeForCs.Append("\r\n ///ע��:���������������,������һ��������������ϵ��,����Ϊһ��������ֵ,Ȼ����Ϊ����������ֵ");
                    strCodeForCs.Append("\r\n ///   ������������ݿ�ʱ,��Ӧ��һ���ֶ���ǰ,�����ֶ��ں�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}\">��ʵ�������</param>",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n ///ע��:���������������,������һ��������������ϵ��,����Ϊһ��������ֵ,Ȼ����Ϊ����������ֵ");
                    strCodeForCs.Append("\r\n /// ������������ݿ�ʱ,��Ӧ��һ���ֶ���ǰ,�����ֶ��ں�");
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                              .Where(x => x.IsPrimaryKey_Identity() == false)
                              .Where(x => x.InUse)
                              .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false);

                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrEditRegionFld)
                    {
                       
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ".ToString();");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};,�Ƿ�ɿ�:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + objEditRegionFldsEx.CtrlId + ".Text = pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + ";");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};,�Ƿ�ɿ�:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:������������������ʾ��������");
                    strCodeForCs.Append("\r\n ///ע��:���������������,������һ��������������ϵ��,����Ϊһ��������ֵ,Ȼ����Ϊ����������ֵ");
                    strCodeForCs.Append("\r\n /// ������������ݿ�ʱ,��Ӧ��һ���ֶ���ǰ,�����ֶ��ں�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">��ʵ�������</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls{1}EN pobj{2}EN)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                                 .Where(x => x.IsPrimaryKey_Identity() == false)
                                 .Where(x => x.InUse)
                                 .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false);

                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrEditRegionFld)
                    {                        
                        string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
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

        public string Gen_WebView_CS_Wuc4Gv_GvUpdateClick()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��Gv�б�ؼ���,��GeidView�е����޸�ʱ�������¼���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}{1}1_GvUpdateClick(object sender, clsEventArgs4Update e)",
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);    ////GridView����ɾ���¼�����
                                                                                //strTemp = Gen_GridView_RowDeleting(objViewInfoENEx, false);
                                                                                //strCodeForCs.Append(strTemp);rjTabFldSet[0].ObjFieldTabENEx.PrivFuncName);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Update{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

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

        public string Gen_WebView_CS_Wuc4Gv_GvDeleteClick()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///");
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:��Gv�б�ؼ���,��GeidView�е���ɾ��ʱ�������¼���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "protected void {0}{1}1_GvDeleteClick(object sender, clsEventArgs4Delete e)",
                        this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.Append("\r\n" + "{");


                switch (objViewInfoENEx.arrKeyPrjTabFldSet[0].ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "long {0} = long.Parse(e.KeyId);",
                           objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "int {0} = int.Parse(e.KeyId);",
                                objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "string {0} = e.KeyId;",
                            objViewInfoENEx.MainTabPrimaryField_PrivFuncVar);
                        break;
                }
                strCodeForCs.AppendFormat("\r\n" + "  Delete{1}Record({0});",
                    objViewInfoENEx.MainTabPrimaryField_PrivFuncVar,
                    objViewInfoENEx.TabName);

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

        public string Gen_WebView_CS_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //ɾ����¼���̴���for C#"
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ݸ����ؼ���ɾ����¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����ؼ���</param>", objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.AppendFormat("\r\n" + "protected void Delete{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "ɾ����¼���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                if (bolIsUseWuc4Gv == true)
                {
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                }
                //strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
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


        public string Gen_WebView_CS_btnGoTop_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

          
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ö�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnGoTop_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {               
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                    }
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                     objKeyField.PrivFuncListName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = GetAllCheckedKeysFromGv();",
                                        objKeyField.PrivFuncListName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                strCodeForCs.AppendFormat("\r\n" + "if ({0}  == null)",
                    objKeyField.PrivFuncListName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"��ѡ����Ҫ�ö��ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
   

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() >0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop({1}, {2});",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName,
                                          strClassificationFieldLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop({1});",
                     objViewInfoENEx.TabName,                     
                     objKeyField.PrivFuncListName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ö���������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.SetCheckedItemsForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncListName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
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

        public string Gen_WebView_CS_btnUpMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnUpMove_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MoveRecord(\"UP\");");
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

        public string Gen_WebView_CS_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ƶ���¼,�������ƺ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void MoveRecord(string strDirect)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                            objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                        //strCodeForCs.AppendFormat("\r\n" + "vs{0} = str{1};", objAdjustOrderNum.ClassificationFieldValue, objInFor.FldName);
                    }
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = {2}{3}1.GetFirstCheckedKeyFromGv();",
                                     objKeyField.PrivFuncName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                                        objKeyField.PrivFuncName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = string.Format(\"��ѡ����Ҫ�ƶ�({0})�ļ�¼!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = string.Format(\"��ѡ����Ҫ�ƶ�({0})�ļ�¼!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, {1});",
                     objViewInfoENEx.TabName,
                     strClassificationFieldLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ƶ�({0})��¼��������:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.SetCheckedItemForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

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

        public string Gen_WebView_CS_btnDownMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnDownMove_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MoveRecord(\"DOWN\");");
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

        public string Gen_WebView_CS_PreCheck4Order()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds_GoTop = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
                if (objFeatureRegionFlds_GoTop == null) return "";
                //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
                IEnumerable<clsViewFeatureFldsENEx> arrFieldLst_Classify = objViewInfoENEx.arrViewFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                //foreach (clsPrjTabFldENEx objField in arrFldSet)
                //{
                //    if (objField.FieldTypeId == enumFieldType.ClassificationField_10)
                //    {
                //        clsFieldTabEN objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objField.FldId, objField.PrjId);
                //        objAdjustOrderNum.ClassificationFieldValue = objFieldTabEN.FldName;
                //    }
                //    if (objField.FieldTypeId == enumFieldType.OrderNumField_09)
                //    {
                //        clsFieldTabEN objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objField.FldId, objField.PrjId);

                //        objAdjustOrderNum.OrderNumFieldName = objFieldTabEN.FldName;
                //    }
                //}
                if (string.IsNullOrEmpty(objFeatureRegionFlds_GoTop.ReleFldId))
                {
                    strCodeForCs.AppendFormat("\r\n" + "//��[{0}]������ֶ�Ϊ��,�������ɡ�Ԥ�캯��(PreCheck4Order)��;",
                        objViewInfoENEx.TabName);
                    return strCodeForCs.ToString();

                }
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�õ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private bool PreCheck4Order()");
                strCodeForCs.Append("\r\n" + "{");
                if (arrFieldLst_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in arrFieldLst_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex <= 0)",
                                    objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}.Text) == true)",
                                    objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}.Text) == true)",
                                    objInFor.CtrlId);
                                break;
                        }

                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"������{0}!\";", objInFor.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.Focus();",
                            objInFor.CtrlId);
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

        public string Gen_WebView_CS_btnGoBottum_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�õ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnGoBottum_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                            objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                        //strCodeForCs.AppendFormat("\r\n" + "vs{0} = str{1};", objAdjustOrderNum.ClassificationFieldValue, objInFor.FldName);
                    }
                }
                if (bolIsUseWuc4Gv == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                     objKeyField.PrivFuncListName,
                                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                     this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<{1}> {0} = GetAllCheckedKeysFromGv();",
                                        objKeyField.PrivFuncListName,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }

                strCodeForCs.AppendFormat("\r\n" + "if ({0}  == null)",
                    objKeyField.PrivFuncListName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"��ѡ����Ҫ�õ׵ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
           
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom({1}, {2});",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName,
                         strClassificationFieldLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom({1});",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�õ׳�������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.SetCheckedItemsForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncListName, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
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
        public string Gen_WebView_CS_btnReOrder_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected void btnReOrder_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        switch (objInFor.CtlTypeId)
                        {
                            case enumCtlType.DropDownList_06:
                            case enumCtlType.DropDownList_Bool_18:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                            objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextBox_16:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                            case enumCtlType.TextArea_41:
                                strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.Text;",
                          objInFor.FldName, objInFor.CtrlId);
                                break;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "vs{0}_OrderNum = str{0};", objInFor.FldName);
                        //strCodeForCs.AppendFormat("\r\n" + "vs{0} = str{1};", objAdjustOrderNum.ClassificationFieldValue, objInFor.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
               
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0}_OrderNum,", x));
                    strClassificationFieldLst = strClassificationFieldLst.Replace("_OrderNum_OrderNum", "_OrderNum");
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                   strClassificationFieldLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName                   );
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�����������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "{0}{2}1.BindGv_{1}(strWhereCond);",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002),
                    strTabName_Out4ListRegion, PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

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
        /// ����EXCEL�ļ�,���е������ֶ���ȫ��DataGridһ�¡�
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_btnExportExcel_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �¼�����:�Ѳ�ѯ�����ı��¼,������Excel.");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n" + "/// <param name = \"e\"></param>");
                //        strCodeForCs.Append("\r\n" + "//����ר�����ڵ���Excel����ش���");
                strCodeForCs.Append("\r\n" + "protected void btnExportExcel_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//����Excel����");
                strCodeForCs.Append("\r\n" + "ExportExcel();");
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

        public string Gen_WebView_CS_btnSetExportExcel4User_Click()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == false)
            {
                return "";
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///���õ�ǰ�û���Excel�����ֶ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");


                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnSetExportExcel4User_Click(object sender, EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\"ViewName = '{" + "0" + "}'\", vsViewName);//��ǰ����");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And TabName = '{" + "0" + "}'\", vsTabName);//��ǰ������ʹ�õı�");
                    strCodeForCs.Append("\r\n" + "sbCondition.AppendFormat(\" And UserId = '{" + "0" + "}'\", clsCommonSession.UserId);//��ǰ�û�");
                    strCodeForCs.Append("\r\n" + "//����������ȡExcel����Id");
                    strCodeForCs.Append("\r\n" + "string strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());");
                    strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                      objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetMaxStrId_S", "��ϵͳ��û�н���Ϊ{0},���� = {1},�����û� = {2}�ĵ���Excel�û�����,���ȵ���һ��Excel,�ٲ��п������Ա��ϵ!", "���ɴ���");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "sbMsg.AppendFormat(\"(errid:{0})��ϵͳ��û�н���Ϊ[{{0}}]\", vsViewName);", strErrId, "{", "}");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\",���� = '{" + "0" + "}'\", vsTabName);");
                    strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"�����û� = '{" + "0" + "}'�ĵ���Excel�û�����,���ȵ���һ��Excel,�ٲ��п������Ա��ϵ!\", clsCommonSession.UserId);");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, sbMsg.ToString());");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//��������Excel�ֶν����������");
                    strCodeForCs.Append("\r\n" + "StringBuilder sbScript = new StringBuilder();");

                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"<script language = 'javascript'>\");");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"window.open('\");");
                    strCodeForCs.Append("\r\n" + "sbScript.AppendFormat(\"../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users = {" + "0" + "}\", strid_ExportExcel4Users);");
                    strCodeForCs.Append("\r\n" + "sbScript.Append(\"','_blank', 'left = 50px,top = 50px,status = no,width = 920px,height = 650px,scrollbars = yes'); </script>\");");
                    strCodeForCs.Append("\r\n" + "Page.ClientScript.RegisterStartupScript(this.GetType(), \"����Excel�ֶ�����\", sbScript.ToString());");
                    strCodeForCs.Append("\r\n" + "// Response.Write(sbScript.ToString());");
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

        public string Gen_WebView_CS_ExportExcel()
        {
            if (objViewInfoENEx.IsNeedSetExportFld == true)
            {
                return GenExportExcel4SetExportFld();
            }
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            string strTabName_Out = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);
            string strTabName_Out_Query = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Query.TabId, objViewInfoENEx.PrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //����ר�����ڵ���Excel ����ش���
                strCodeForCs.Append("\r\n /// <summary>");
                
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                        strTabName_Out_Query);
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}��Ϣ����.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                List<string> arrColHead = new List<string>();
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    string strColHead = objExcelExportRegionFldsEx.ColCaption;
                    if (arrColHead.Contains(strColHead) == false)
                    {
                        arrColHead.Add(strColHead);
                    }
                    else
                    {
                        string strMsg = string.Format("����Excelʱ,��ͷ�ظ�!�ظ���ͷ:[{0}({2})].(In {1})",
                            strColHead, clsStackTrace.GetCurrClassFunction(),
                            objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName);
                        throw new Exception(strMsg);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    strTabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
            
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    strTabName_Out);
            
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���ݳ���,����ϵ����Ա!����:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "  try");
                strCodeForCs.Append("\r\n" + "  {");
                strCodeForCs.Append("\r\n" + "//�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007,���Ի�����һ����䡣");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + " catch (Exception objException)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);");

                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException2)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"����Excel����,����ϵ����Ա!����:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException2.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
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
        /// ����<��ʾ�б��༭����>
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_DispListRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///�������WebForm�Ĵ���;
            //			string strTemp; ///��ʱ����;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ֿ��ƺ���,��ʾ�����б���,���������ڱ༭���û��ؼ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void Disp{0}ListRegion()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ����<��ʾ�б��༭����>
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_DispEditRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder(); ///�������WebForm�Ĵ���;
            //			string strTemp; ///��ʱ����;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ֿ��ƺ���,��ʾ���ڱ༭���û��ؼ�,�����������б���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private void DispEdit{0}Region()",
              objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "divList.Visible = false;",
            objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "tabEdit{0}Region.Visible = true;",
            objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_ErrMessageSession()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:������Ϣ��Session����,��Session���ݸ���ʾ����ҳ��,��ʾ��Ӧ�Ĵ������ݡ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seErrMessage");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage;");
                strCodeForCs.Append("\r\n" + "strErrMessage = (string)Session[\"ErrMessage\"];");
                strCodeForCs.Append("\r\n" + "if (strErrMessage == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strErrMessage = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strErrMessage;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strErrMessage = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"ErrMessage\", strErrMessage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_BackLinkStrSession()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:�������Ӵ���Session����,��Session���ڸ��߳���ҳ��,��һ��ҳ������Ҫ���ص�ҳ�档");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string seBackErrPageLinkStr");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = (string)Session[\"BackErrPageLinkStr\"];");
                strCodeForCs.Append("\r\n" + "if (strBackErrPageLinkStr == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strBackErrPageLinkStr = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strBackErrPageLinkStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strBackErrPageLinkStr = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"BackErrPageLinkStr\", strBackErrPageLinkStr);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WebView_CS_DefProperty_vsViewName()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����Ľ��湦������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefProperty_vsTabName()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");

               
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����ĵ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefProperty_vsCacheClassifyField()
        {
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                return "";
            }
            var strVar4ViewCacheFld = string.Format("{0}Cache", objViewInfoENEx.objCacheClassifyFld4View.FldName);
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����ĵ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected string vs{0}", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string s{0};", strVar4ViewCacheFld);
                strCodeForCs.AppendFormat("\r\n" + "s{0} = (string)ViewState[\"{0}\"];", strVar4ViewCacheFld);
                strCodeForCs.AppendFormat("\r\n" + "if (s{0} == null)", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "s{0} = \"\";", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return s{0};", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string s{0} = value;", strVar4ViewCacheFld);
                strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"{0}\", s{0});", strVar4ViewCacheFld);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefProperty_qsUserId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString����:ͨ��QueryString���ݹ�����UserId����������������,��ҿ��Բο����������");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                                              
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_CS_DefProperty_vsPotenceLevel()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ViewState����:���ڼ�¼��ǰ�û��ڵ�ǰ�����Ȩ�޵ȼ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //��ȡ��ǰ�û���Ȩ�޵ȼ����
                strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = (string)ViewState[\"PotenceLevel\"];");
                strCodeForCs.Append("\r\n" + "if (sPotenceLevel == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = \"9\";");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PotenceLevel\", sPotenceLevel);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
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
        // ����Ȩ���йصı����������
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_PotenceRelaVar()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//�����йصı����������");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����Ľ��湦������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsViewName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName;");
                strCodeForCs.Append("\r\n" + "sViewName = (string)ViewState[\"ViewName\"];");
                strCodeForCs.Append("\r\n" + "if (sViewName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sViewName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sViewName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sViewName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"ViewName\", sViewName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ViewState����:��ǰ�����ĵ���������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected string vsTabName");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName;");
                strCodeForCs.Append("\r\n" + "sTabName = (string)ViewState[\"TabName\"];");
                strCodeForCs.Append("\r\n" + "if (sTabName == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sTabName = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sTabName;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sTabName = value;");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"TabName\", sTabName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// QueryString����:ͨ��QueryString���ݹ�����UserId����������������,��ҿ��Բο����������");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.Append("\r\n /// ����:");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private string qsUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = Request.QueryString[ \"UserId\"] ?? \"\".ToString();");
                strCodeForCs.Append("\r\n" + "if ((strUserId != null) && (strUserId != \"\"))");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_DefConst_ViewId4Potence()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {                
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��Ȩ����صĽ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "protected const string ViewId4Potence = \"00260203\";		//������");
                //				strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel; //Ȩ�޵ȼ����");
                strCodeForCs.Append("\r\n");
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
        // ����Ȩ���й�Ȩ�޵ȼ��Ĵ���
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_PotenceLevelProperty()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ViewState����:���ڼ�¼��ǰ�û��ڵ�ǰ�����Ȩ�޵ȼ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //��ȡ��ǰ�û���Ȩ�޵ȼ����
                strCodeForCs.Append("\r\n" + "protected string vsPotenceLevel");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = (string)ViewState[\"PotenceLevel\"];");
                strCodeForCs.Append("\r\n" + "if (sPotenceLevel == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);");
                strCodeForCs.Append("\r\n" + "sPotenceLevel = \"9\";");
                strCodeForCs.Append("\r\n" + "ViewState.Add(\"PotenceLevel\", sPotenceLevel);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return sPotenceLevel;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WebView_CS_AccessUserPotence()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �û�Ȩ�޹���:����ǰ�û��ڵ�ǰ�����Ȩ����ز���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");

                //��ȡ��ǰ�û���Ȩ�޵ȼ����
                strCodeForCs.Append("\r\n" + "protected bool AccessUserPotence()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//����Ȩ���й��ж�Ȩ�޵Ĵ���");
                //��ȡ��ǰ�û���Ȩ�޵ȼ����
                strCodeForCs.Append("\r\n" + "//���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô����,�ȼ���ŷ�ʽ:1Ϊ���2���,��������");
                strCodeForCs.Append("\r\n" + "switch (vsPotenceLevel)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"0\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"1\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"2\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"3\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"4\":");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"9\":");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
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
        /// ���ɵ�¼�û����û���Session
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_DefProperty_seUserId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n" + "//���ɵ�¼�û����û���Session");
                //���ɵ�¼�û����û���Session
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Session����:��¼���û�ID,���ڼ���û�Ȩ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "protected string seUserId");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId;");
                strCodeForCs.Append("\r\n" + "strUserId = (string)Session[\"UserId\"];");
                strCodeForCs.Append("\r\n" + "if (strUserId == null) ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strUserId = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strUserId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strUserId = value;");
                strCodeForCs.Append("\r\n" + "Session.Add(\"UserId\", strUserId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n ///protected clsUsersEN objUser");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///get");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser;");
                strCodeForCs.Append("\r\n ///pobjUser = (clsUsersEN)Session[\"objUser\"];");
                strCodeForCs.Append("\r\n ///if (pobjUser == null) ");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///pobjUser = null;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///return pobjUser;");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///set");
                strCodeForCs.Append("\r\n ///{");
                strCodeForCs.Append("\r\n ///clsUsersEN pobjUser = value;");
                strCodeForCs.Append("\r\n ///Session.Add(\"objUser\", pobjUser);");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n ///}");
                strCodeForCs.Append("\r\n");
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
        /// ���ɸ������SESSION������Ժ���
        /// </summary>
        /// <returns></returns>
        public string Gen_WebView_CS_ParentObjSeesionProp()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {                    
                    if (objQryRegionFldsEx.IsTabForeignKey() == true)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                        objQryRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "protected string {0}",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "get");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = (string)Session[\"{0}\"];",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null) ",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "str{0} = \"\";",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.AppendFormat("\r\n" + "return str{0};",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "set");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = value;",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "Session.Add(\"{0}\", str{0});",
                        objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "}");

                    }
                }
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
        
        public string Gen_WebView_CS_btnSetFieldValue_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                 

                    K_FldId_FieldTab objKey = new K_FldId_FieldTab(objInFor.ReleFldId);
                    clsFieldTabEN objFieldTabEN = objKey.GetObj();

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///�����ֶ�ֵ");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");


                    strCodeForCs.AppendFormat("\r\n" + "protected void {0}_Click(object sender, System.EventArgs e)", objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
                && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count > 0)
                        {
                            objViewFeatureFlds = arrViewFeatureFlds[0];
                            ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds, new clsGetTabFieldObj());
                            string strCtrlId = objASPDropDownListENEx.CtrlId;
                            if (strCtrlId.IndexOf("_SetFldValue") == -1)
                            {
                                strCtrlId = strCtrlId + "_SetFldValue";
                                objASPDropDownListENEx.CtrlId = strCtrlId;
                            }

                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex <= 0)",
                                        objASPDropDownListENEx.CtrlId);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"������{0}({1})!\";", 
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, lblMsg_List.Text);");
                            strCodeForCs.AppendFormat("\r\n" + "{0}.Focus();",
                                objASPDropDownListENEx.CtrlId);
                            strCodeForCs.Append("\r\n" + "return;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.AppendFormat("\r\n" + "string str{0} = {1}.SelectedValue;",
                                   objViewFeatureFlds.ObjFieldTabENEx.FldName,
                                   objASPDropDownListENEx.CtrlId);
                        }
                    }
                
                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "K_{0}_{1} objKey = new K_{0}_{1}({2});",
                        objKeyField.FldName, objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = objKey.GetObj();",
                                            objViewInfoENEx.TabName);
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(\"���ﲻ��ȷ,ֵΪ��!\");",
                                                      objViewInfoENEx.TabName, objFieldTabEN.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(str{2});",
                                                      objViewInfoENEx.TabName, objFieldTabEN.FldName,
                                                      objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                    }
                    else
                    {
                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}({2});",
                                                    objViewInfoENEx.TabName, objFieldTabEN.FldName, objInFor.DefaultValue);

                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(bool.Parse(\"{2}\"));",
                                                        objViewInfoENEx.TabName, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}(\"{2}\");",
                                                        objViewInfoENEx.TabName, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.Update();",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, string.Format("{0}_Click", objInFor.ButtonName), string.Format("{0}���ɹ�!", objInFor.Text), "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0}){1}���ɹ�!\" + objException.Message;", strErrId, objInFor.Text);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
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


        /// <summary>
        /// �������ֻ��һ���ؼ��ֵ�ɾ���¼�
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_WebView_CS_btnDelRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///ɾ����ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "ɾ����¼���ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}{2}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
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

        public string Gen_WebView_CS_btnDelRecord_Click()
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnDelRecord_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///ɾ����ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ɾ����¼ʱ����!����{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
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

        public string Gen_WebView_CS_btnDelRecordBySign_Click()
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnDelRecordBySign_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///��־��ɾ�������б��ж�ѡ��������¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecordBySign_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecordBySign({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ڸ��ݱ�־ɾ����¼ʱ����!����{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
           
                    strCodeForCs.Append("\r\n" + "}");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
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

        public string Gen_WebView_CS_btnUnDelRecordBySign_Click()
        {
            if (objViewInfoENEx.arrKeyPrjTabFldSet.Count == 1)
            {
                return GenbtnUnDelRecordBySign_Click4OneKeyword();
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///��־��ɾ�������б��ж�ѡ��������¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");


                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");

                    strCodeForCs.AppendFormat("\r\n" + "List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gv{0}, \"chkCheckRec\", {1});",
                    objViewInfoENEx.TabName, strKeys);

                    strCodeForCs.AppendFormat("\r\n" + "if (lstKeyValues.Count == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                     objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecordBySign_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg_List.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "foreach (string strKeyValue in lstKeyValues)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string[] strKeys = strKeyValue.Split(',');");
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldEN in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = strKeys[{1}];",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                            case "long":
                                strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(strKeys[{1}]);",
                                objPrjTabFldEN.KeyVarDefineStr, intKeyIndex++);
                                break;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UnDelRecordBySign({1});", objViewInfoENEx.TabName, objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ڻָ����ݱ�־ɾ����¼ʱ����!����{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);

                    if (this.IsUseFunc)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                              strTabName_Out4ListRegion);

                    }
                    else if (PrjTabEx_ListRegion.IsUseCache_TS()== true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                            strTabName_Out4ListRegion);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                            strTabName_Out4ListRegion);
                    }
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


        public string Gen_WebView_CS_PutDataToClass()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intIndex = 0;
            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ///1���ɴӽ���㵽�߼�������ݴ��亯������");
                if ((mbolIsUseCtl == false))
                {
                    ///������ȡ���ݴ�������:protected void PutDataToClass;
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                         .Where(x => x.IsPrimaryKey_Identity() == false)
                         .Where(x => x.InUse);

                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                       if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsDateTime.getTodayDateTimeStr(0);\\(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                            continue;
                        }
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsCommonSession.UserId;\\(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                            continue;
                        }
                        switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                        {
                            case "int":
                                strCodeForCs.AppendFormat("\r\n" + "if (txt{0}.Text.Trim() == \"\")", objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = 0;\\(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                                objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = int.Parse(" + objEditRegionFldsEx.CtrlId + ".Text);");

                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};,�Ƿ�ɿ�:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + "pobj" + objViewInfoENEx.TabName + "EN." + objEditRegionFldsEx.FldName + " = " + objEditRegionFldsEx.CtrlId + ".Text;");
                                strCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                                strCodeForCs.AppendFormat("" + "(˵��:{3};�ֶ�����:{0};�ֶγ���:{1};,�Ƿ�ɿ�:{2})",
                                objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                                objEditRegionFldsEx.ObjFieldTabENEx.IsNull,
                                objEditRegionFldsEx.ObjFieldTabENEx.MemoInTab);
                                break;
                        }

                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:�ѽ����ϵ��������ݴ����������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">���ݴ����Ŀ�������</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls{1}EN pobj{2}EN)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                 
                    IEnumerable<clsEditRegionFldsENEx> arrEditRegionFld = objViewInfoENEx.arrEditRegionFldSet4InUse
                       .Where(x => x.IsPrimaryKey_Identity() == false)
                       .Where(x => x.InUse);
                    intIndex = 0;
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrEditRegionFld)
                    {
                        intIndex++;
                   
                        string strTemp = "";
                        if (intIndex == 1)
                        {
                            strTemp = GetCode4FieldInPutDataToClass_First(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        else if (intIndex == arrEditRegionFld.Count())
                        {
                            strTemp = GetCode4FieldInPutDataToClass_Last(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        else
                        {
                            strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        }
                        strCodeForCs.AppendFormat("{0}", strTemp);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
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

        //����GridView��ɾ�����¼�����
        public string Gen_WebView_CS_btnCancelEdit_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.AppendFormat("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// �¼�����:ȡ���༭״̬,�˻ص��б�״̬");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"sender\"></param>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name = \"e\"></param>");

                strCodeForCs.AppendFormat("\r\n" + "protected void btnCancel{0}Edit_Click(object sender, EventArgs e)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //if (objViewInfoENEx.ViewTypeCode != (int)enumViewTypeCodeTab.Table_Insert_1)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();",
                //    objViewInfoENEx.TabName);
                //}
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

        public string Gen_WebView_CS_btnOkUpd_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:�¼�����,������<ȷ���޸�>ʱ�������¼�����,");
                strCodeForCs.Append("\r\n /// ���幦��Ϊ�ѽ�������ͬ�����ݿ���,�ѽ������ݱ��浽���ݿ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "protected void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "Button btnTemp;");
                strCodeForCs.Append("\r\n" + "btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"���\":");
                    if (objViewInfoENEx.arrFeatureId.Contains(enumPrjFeature.AddNewRecordWithMaxId_0183))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordWithMaxId();",
                     objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
                        objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"ȷ�����\":");
                    strCodeForCs.Append("\r\n" + "//����һ������Ĳ���Ĵ���,�����߼���̫��,");
                    strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                    strCodeForCs.Append("\r\n" + "if (btnOKUpd.CommandArgument == \"AddWithMaxId\")");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objViewInfoENEx.arrFeatureId.Exists(x => x == enumPrjFeature.AddNewRecordWithMaxId_0183) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordWithMaxIdSave();",
                       objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//Add{0}RecordWithMaxIdSave();",
                       objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objViewInfoENEx.arrFeatureId.Exists(x => x == enumPrjFeature.AddNewRecordWithMaxId_0183) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                    objViewInfoENEx.TabName);
                    }
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"ȷ���޸�\":");
                    strCodeForCs.Append("\r\n" + "//����һ��������޸ĵĴ���,�����߼���̫��,");
                    strCodeForCs.Append("\r\n" + "//�Ͱ��߼���ϲ������Ʋ�,");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;");
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

        //�����޸ļ�¼׼�����̴���
        public string Gen_WebView_CS_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //�����޸ļ�¼׼�����̴��� for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�޸ļ�¼��׼������,�Ѹ����ؼ��ֵļ�¼�ֶ�ֵ��ʾ���û��ؼ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void Update{1}Record({0})",
                objViewInfoENEx.KeyVarDefineLstStr,
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "//��������:(�ܹ�2��)");
                strCodeForCs.Append("\r\n" + "//1���󶨱༭����������");
                strCodeForCs.Append("\r\n" + "//2����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                strCodeForCs.Append("\r\n" + "//3�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "//1���󶨱༭����������");
                strCodeForCs.Append("\r\n" + "BindDdl4EditRegion();");

                strCodeForCs.Append("\r\n" + "//2����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n" + "//3�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                            this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���޸�\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {
                    strCodeForCs.AppendFormat("\r\n" + "DispEdit{0}Region();", objViewInfoENEx.TabName);
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


        public string Gen_WebView_CS_CopyRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                List<clsFeatureRegionFldsENEx> arrFeature_AdditionalCopy = objViewInfoENEx.arrFeatureRegionFlds.Where(x=>x.FieldTypeId == enumFieldType.AdditionalCopyField_15).ToList();

                //�����޸ļ�¼׼�����̴��� for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���Ƽ�¼,�Ѹ����ؼ��ֵļ�¼���ݸ���һ���¼�¼,�������ֶ�ֵ��ǰ�����\"Copy_\"");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void CopyRecord({0})",
                objViewInfoENEx.KeyVarDefineLstStr);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "K_{1}_{0} myKey = new K_{1}_{0}({2});", objViewInfoENEx.TabName_In, objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = myKey.GetObj();", objViewInfoENEx.TabName_In, objKeyField.FldName);
                if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02)
                {
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();", objViewInfoENEx.TabName_In, objKeyField.FldName);
                    }
                    else
                    {
                        if (objKeyField.CsType == "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();", objViewInfoENEx.TabName_In, objKeyField.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 999;", objViewInfoENEx.TabName_In, objKeyField.FldName);
                        }
                    }
                }
                if (arrFeature_AdditionalCopy.Count()>0)
                {
                    clsFeatureRegionFldsENEx objFeature_AdditionalCopy = arrFeature_AdditionalCopy[0];
                    string strCopyValue = objFeature_AdditionalCopy.DefaultValue;
                    if (string.IsNullOrEmpty(strCopyValue)) strCopyValue = "Copy_";
                    clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objFeature_AdditionalCopy.ReleFldId, objViewInfoENEx.PrjId);
                    if (objFieldTab == null)
                    {
                        var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                        arrPrjTabFld = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.NameField_03).ToList();
                        if (arrPrjTabFld.Count == 0)
                        {
                            string strMsg = string.Format("��ǰ��:[{0}]û�������ֶ�!", objViewInfoENEx.TabName);
                            throw new Exception(strMsg);
                        }
                        objFieldTab = clsFieldTabBL.GetObjByFldIdCache(arrPrjTabFld[0].FldId, objViewInfoENEx.PrjId);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"{2}\" + obj{0}EN.{1});", 
                        objViewInfoENEx.TabName_In, objFieldTab.FldName, strCopyValue);
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();", objViewInfoENEx.TabName_In, objKeyField.FldName);


                if (this.IsUseFunc)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                          strTabName_Out4ListRegion);

                }
                else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                        strTabName_Out4ListRegion);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                        strTabName_Out4ListRegion);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ڿ�¡��¼ʱ����!����{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
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


        //�����޸Ĵ���׼�����̴���
        public string Gen_WebView_CS_UpdateRecordSave()
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
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵ�ʵ�����</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected bool Update{0}RecordSave(cls{0}EN obj{0}EN)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.Append("\r\n" + "//2����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//4��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "//5�����޸ĺ��������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");

                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "�ؼ��������������Ͳ���ȷ����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})�ؼ��������������Ͳ���ȷ����!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"�ؼ��������������Ͳ���ȷ����!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//2����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "Ϊ����ֵ���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})Ϊ����ֵ���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");

       
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//3��ʹ����չ�޸ķ���,����չ�߼���ȥ�޸�");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.UpdateRecordEx();", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"�޸ļ�¼���ɹ�!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false; ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"�޸ļ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"�޸ļ�¼�ɹ�!\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {

                    strCodeForCs.Append("\r\n" + "//5�����޸ĺ��������ʾ��GridView��");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();//��տؼ��е�����",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "//�ָ�<ȷ���޸�>���<���>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"���\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���༭\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//��ת���б��иոյļ�¼��,ʹ��ê�㹦�ܡ�");

                strCodeForCs.AppendFormat("\r\n" + "this.ClientScript.RegisterStartupScript(this.GetType(), \"Go-Anchor\", string.Format(\"this.location.href = '#A_{0}{{0}}'\", obj{0}EN.{3}.ToString().Trim()), true);",
                            objViewInfoENEx.TabName, "{", "}", objKeyField.ObjFieldTabENEx.FldName);


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

        //�����޸Ĵ���׼�����̴���
        public string Gen_WebView_CS_UpdateRecordSave_Old()
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
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵ�ʵ�����</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected bool Update{0}RecordSave_Old(cls{0}EN obj{0}EN)",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.Append("\r\n" + "//2����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.Append("\r\n" + "//3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                strCodeForCs.Append("\r\n" + "//4��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.Append("\r\n" + "//5�����޸ĺ��������ʾ��GridView��");
                strCodeForCs.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//���ڴ����ڼ����������ʱ���ֵ�ı���");

                strCodeForCs.Append("\r\n" + "//1�����ؼ����������������Ƿ���ȷ");
                strCodeForCs.AppendFormat("\r\n" + "if (!{0}1.IsValid(ref strResult))",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave_Old", "�ؼ��������������Ͳ���ȷ����!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})�ؼ��������������Ͳ���ȷ����!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"�ؼ��������������Ͳ���ȷ����!\";");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//2����ֵ�ӽ���㴫���߼��������ʵ���");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//�ѽ����ֵ����", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave_Old", "Ϊ����ֵ���ɹ�!", "���ɴ���");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})Ϊ����ֵ���ɹ�!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false;");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                //���Ψһ��------------------------------------------------------

                string strDuplicateInfo = "";
                bool bolIsFirst = true;
                //���Ψһ��------------------------------------------------------
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.IsTabUnique() == true
                    && objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId != enumFieldType.KeyField_02)
                    {
                        if (bolIsFirst == true)
                        {
                            strDuplicateInfo += string.Format("{0}({1})",
                                  objEditRegionFldsEx.LabelCaption,
                                objEditRegionFldsEx.FldName);
                            bolIsFirst = false;
                        }
                        else
                        {
                            strDuplicateInfo += string.Format(",{0}({1})",
                              objEditRegionFldsEx.LabelCaption,
                               objEditRegionFldsEx.FldName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(strDuplicateInfo) == false)
                {
                    strCodeForCs.Append("\r\n" + "//3.2�����Ψһ��");
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Check{0}Uniqueness() == false)",
                          objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"({0})�����ظ�!\";",
                           strDuplicateInfo);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "return false;");
                    strCodeForCs.Append("\r\n" + "}");

                }
                //���Ψһ�� == == == == == == == == == == == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "//4��������ʵ�������ݴ��������ݿ���");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"�޸ļ�¼���ɹ�!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return false; ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"�޸ļ�¼�ɹ�!\";");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg_Edit.Text = \"�޸ļ�¼�ɹ�!\";");
                //����в�ѯ����
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                {

                    strCodeForCs.Append("\r\n" + "//5�����޸ĺ��������ʾ��GridView��");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "Disp{0}ListRegion();", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}1.Clear();//��տؼ��е�����",
                        this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                strCodeForCs.Append("\r\n" + "//�ָ�<ȷ���޸�>���<���>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"���\";");
                strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"ȡ���༭\";",
                objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//��ת���б��иոյļ�¼��,ʹ��ê�㹦�ܡ�");

                strCodeForCs.AppendFormat("\r\n" + "this.ClientScript.RegisterStartupScript(this.GetType(), \"Go-Anchor\", string.Format(\"this.location.href = '#A_{0}{{0}}'\", obj{0}EN.{3}.ToString().Trim()), true);",
                            objViewInfoENEx.TabName, "{", "}", objKeyField.ObjFieldTabENEx.FldName);


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

        private string GetCode4FieldInPutDataToClass_First(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(clsDateTime.getTodayDateTimeStr(0))//(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(clsCommonSession.UserId)//(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }

            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            //if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CacheClassifyField_37)
            //{
            //    sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2})",
            // objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, thisCacheClassify4View.VarDef4Fld);

            //}
            //else
            //{
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}1.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
            //}
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInPutDataToClass_Last(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsDateTime.getTodayDateTimeStr(0));//(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(clsCommonSession.UserId);//(�ֶ�����:{2},�ֶγ���:{3},�Ƿ�ɿ�:{3})",
                    objViewInfoENEx.TabName, objEditRegionFldsEx.FldName,
                    objEditRegionFldsEx.ObjFieldTabENEx.CsType(),
                    objEditRegionFldsEx.ObjFieldTabENEx.FldLength,
                    objEditRegionFldsEx.IsTabNullable());
                return sbCodeForCs.ToString();
            }
            
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}( {2}1.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            //if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CacheClassifyField_37)
            //{
            //    sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2});",
            // objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, thisCacheClassify4View.VarDef4Fld);

            //}
            //else
            //{
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}({2}1.{3});",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
            //}
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WebViewControlCode4CSharp);
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

        public override void GetClsName()
        {
            objViewInfoENEx.WebFormName = objViewInfoENEx.ViewName;

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }

        protected string GenRefDomainName()
        {
            string strFuncName = "";
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
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using CommFunc4WebForm;");

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0};", objProject.PrjDomain);

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
        // ����Ȩ���й��ж�Ȩ�޵Ĵ���
        /// </summary>
        /// <returns></returns>
        public string GenPotenceRelaCode()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;
                strCodeForCs.AppendFormat("\r\n" + "vsViewName = \"{0}\";", objViewInfoENEx.ViewCnName);
                strCodeForCs.AppendFormat("\r\n" + "vsTabName = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                            objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "//����Ȩ���й��ж�Ȩ�޵Ĵ���");
                ////��ȡ��ǰ�û���Ȩ�޵ȼ����
                //strCodeForCs.Append("\r\n" + "//���ݵȼ�Ȩ�ޱ����ȷ���û�����ʹ��ʲô����,�ȼ���ŷ�ʽ:1Ϊ���2���,��������");
                //strCodeForCs.Append("\r\n" + "switch (vsPotenceLevel)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "case \"0\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"1\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"2\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"3\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"4\":");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "case \"9\":");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "default:");
                //strCodeForCs.Append("\r\n" + "Response.Redirect(\"../error.aspx\");");
                //strCodeForCs.Append("\r\n" + "break;");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string GenDdlBindFunction4Page_Load()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (IsHaveEditRegion)
                {
                    strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetDdl{1}();",
                                this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003), objEditRegionFldsEx.FldName);
                        }
                    }
                }

                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsQryRegionFldsENEx> arrQRF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrQRF4DropDownLst
                    .Select(GetDdlObj).Distinct(new ASPDropDownListEx4GCComparer());

                //�ӽ��湦���ֶ��л�ȡ�������ֶ�

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).ToList();
                arrASPDropDownListObj = arrASPDropDownListObj.Union(arrASPDropDownListObj4WFF).Distinct(new ASPDropDownListComparer());

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl(objVarManage));
                    
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

        public string GenDdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("CSharp");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
               

                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                
                //�ӽ��湦���ֶ��л�ȡ�������ֶ�

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();
                
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    string strCtrlId = objInfor.CtrlId;
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }
                    //strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl(objVarManage));

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


        //public string this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002)
        //{
        //    string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
        //    return strClsName;
        //}
        public string GenbtnUpdateRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///�޸ĵ�ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return;",
                                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                        case "int":
                        case "long":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return;",
                          objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                    }

                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "Update{0}Record({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                    }

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUpdateRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUpdateRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");
                    if (IsHaveEditRegion)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                        objKeyField.PrivFuncName);
                        //					strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0});",
                        //						objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "//2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�");
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                        if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}1.SetKeyReadOnly(true);",
                                    this.GetClsNameByRegionTypeId(enumRegionType.EditRegion_0003));
                        }
                        strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"ȷ���޸�\";	");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {
                        //strStd1Id = "";
                        strCodeForCs.Append("\r\n" + "clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;");
                        strCodeForCs.AppendFormat("\r\n" + "Response.Redirect(\"wfm{0}_UI.aspx?OperateType = UPDATE&{1} = \" + {2});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName,
                        objKeyField.PrivFuncName);
                        //Update{TabName}Record(strStd1Id);
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

        public string GenbtnCopyRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n ///�޸ĵ�ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                    objKeyField.KeyVarDefineStr,
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return;",
                                objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                        case "int":
                        case "long":
                            if (bolIsUseWuc4Gv == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = {2}1.GetFirstCheckedKeyFromGv();",
                                 objKeyField.KeyVarDefineStr,
                                 objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                 this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0} = GetFirstCheckedKeyFromGv();",
                                objKeyField.KeyVarDefineStr,
                                objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return;",
                          objViewInfoENEx.KeyPrivFuncFldNameLstStr);
                            break;
                    }

                        strCodeForCs.AppendFormat("\r\n" + "CopyRecord({1});",
                        objViewInfoENEx.TabName,
                       objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnCopyRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnCopyRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                    strCodeForCs.Append("\r\n" + "//1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�");

                    strCodeForCs.AppendFormat("\r\n" + "CopyRecord({0});",
                    objKeyField.PrivFuncName);
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

        /// <summary>
        /// �������ֻ��һ���ؼ��ֵ�ɾ���¼�
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string GenbtnDelRecord_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///ɾ����ǰ��ѡ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1});",
                        objViewInfoENEx.TabName,
                        objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "ɾ����¼���ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
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


        /// <summary>
        /// �������ֻ��һ���ؼ��ֵ�ɾ���¼�
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string GenbtnDelRecordBySign_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///��־��ɾ�������б��ж�ѡ��������¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                    //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    //    objKeyField.PrivFuncName,
                    //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    //strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecordBySign(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.FldName_FstUcase);

                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecordBySign_Click", "��־��ɾ����¼���ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})��־��ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}{2}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
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


        public string GenbtnUnDelRecordBySign_Click4OneKeyword()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ָ���־��ɾ�������б��ж�ѡ��������¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnUnDelRecordBySign_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");

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
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = {2}{3}1.GetAllCheckedKeysFromGv();",
                                         objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                         this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<{1}> lst{0} = GetAllCheckedKeysFromGv();",
                                            objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (lst{0} == null) return;",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);

                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "foreach ({0} {1} in lst{2})",
                    //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    //    objKeyField.PrivFuncName,
                    //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    //strCodeForCs.Append("\r\n" + "{");


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UnDelRecordBySign(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.FldName_FstUcase);

                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnUnDelRecordBySign_Click", "�ָ���־��ɾ����¼���ɹ�!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})�ָ���־��ɾ����¼���ɹ�!\" + objException.Message;", strErrId);
                    strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                    strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    if (bolIsUseWuc4Gv == true)
                    {
                        if (this.IsUseFunc)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}ByFunc();",
                                  strTabName_Out4ListRegion);

                        }
                        else if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}Cache();",
                                strTabName_Out4ListRegion);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();",
                                strTabName_Out4ListRegion);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", strTabName_Out4ListRegion);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "protected void btnDelRecord_Click(object sender, System.EventArgs e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string str{0} = (string) rd.Value;",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == null || str{0}.Trim().Length == 0) ",
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnDelRecord_Click", "û��ѡ���¼,��ѡ��һ����Ч�ı��¼!", "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";", strErrId);

                    //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"û��ѡ���¼,��ѡ��һ����Ч�ı��¼!\";");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            //							strCodeForCs.AppendFormat("\r\n" + "{0} = e.Item.Cells[{1}].Text;", 
                            //								objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.PrivFuncName, intItemNum);
                            break;
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = int.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1};",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "{0} = long.Parse(str{1});",
                            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldName);
                            break;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}.DelRecord({1});",
                    objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    if (bolIsUseWuc4Gv == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " string strWhereCond = Combine{0}Condition();",
               objViewInfoENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + " {1}{2}1.BindGv_{0}(strWhereCond);",
                            objViewInfoENEx.TabName, this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), PrjTabEx_ListRegion.IsUseCache_TS() ? "Cache" : "");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindGv_{0}();", objViewInfoENEx.TabName);
                    }
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
        /// <summary>
        /// ����EXCEL�ļ�,���е������ֶ���ȫ��DataGridһ�¡�ר����Ե����ֶ�
        /// </summary>
        /// <returns></returns>
        public string GenExportExcel4SetExportFld()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    //					StringBuilder sbMessage = new StringBuilder();
                    //					string strViewName = objViewInfoENEx.ViewName;
                    //					sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!" , strViewName);
                    //					throw new clsDbObjException(sbMessage.ToString());
                    return "";
                }

                //����ר�����ڵ���Excel ����ش���
                strCodeForCs.Append("\r\n /// <summary>");
                if (
                    clsPrjTabBL.GetObjByTabIdCache(
                    clsViewRegionBL.GetObjByRegionIdCache(objViewInfoENEx.objViewRegion_ExportExcel.RegionId, objViewInfoENEx.PrjId).TabId, objViewInfoENEx.PrjId).SqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[v{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT;");
                //				strCodeForCs.Append("\r\n" + "int intColNum = objDT.Columns.Count;");
                strCodeForCs.Append("\r\n" + "List<string> arrCnName = new List<string>();");
                strCodeForCs.Append("\r\n" + "List<string> arrColName = new List<string>();");


                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}��Ϣ����.xls\";",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                //				strCodeForCs.Append("\r\n" + "for (int i = 0; i<intColNum; i++)");
                //				strCodeForCs.Append("\r\n" + "{");
                //				strCodeForCs.Append("\r\n" + "strCnName[i] = objDT.Columns[i].ColumnName;");
                //				strCodeForCs.Append("\r\n" + "strColName[i] = strCnName[i];");
                //				strCodeForCs.Append("\r\n" + "}");
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(con{2}.{0}); arrCnName.Add(\"{1}\");",
                    objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                    objExcelExportRegionFldsEx.ColCaption,
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ViewName = vsViewName;//��ǰ����");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.TabName = vsTabName;//����Excel���õı������ͼ");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.ExportFileName = strFileName;//����Excel���ļ���");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UserId = clsCommonSession.UserId;//��ǰ�û�Id");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//��ǰ����");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;//��ǰ���������ɴ���ϵͳ�����õĹ���Id,Ϊ�˷����ֶ�����������");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrCnName = arrCnName;//�����ֶ���,Ҳ��Excel�ļ��еı�����");
                strCodeForCs.Append("\r\n" + "objExportExcelSetENEx.arrColName = arrColName;//���ݱ������");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx);");
                strCodeForCs.Append("\r\n" + "strFileName = objExportExcelSetENEx.ExportFileName;//����Excel���ļ���");
                strCodeForCs.Append("\r\n" + "arrCnName = objExportExcelSetENEx.arrCnName;//�����ֶ���,Ҳ��Excel�ļ��еı�����");
                strCodeForCs.Append("\r\n" + "arrColName = objExportExcelSetENEx.arrColName;//���ݱ������");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ڵ�����¼ʱ����!����{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "}");




                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���");
                strCodeForCs.Append("\r\n" + "if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "//�û�Odbc�ķ�ʽ������Excel,��Web����������Ҫ��װExcel,Ŀǰ��Excel2003,���ϣ��2007,���Ի�����һ����䡣");
                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);");

                strCodeForCs.Append("\r\n" + "//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ڵ�����¼ʱ����!����{0}.(In {1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "clsCommonJsFunc.Alert(this, strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsCommForWebForm.DownLoadFile(strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ����:�����ļ����ӷ����������ļ����ͻ��������");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>");
                //strCodeForCs.Append("\r\n /// <returns></returns>");
                //strCodeForCs.Append("\r\n" + "protected bool DownLoadFile(string strDownLoadFileName)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); ");
                //strCodeForCs.Append("\r\n" + "Response.Clear(); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Disposition\", \"attachment; filename = \" + HttpUtility.UrlEncode(file.Name)); ");
                //strCodeForCs.Append("\r\n" + "Response.AddHeader(\"Content-Length\", file.Length.ToString()); ");
                //strCodeForCs.Append("\r\n" + "Response.ContentType = \"application/octet-stream\"; ");
                //strCodeForCs.Append("\r\n" + "Response.WriteFile(file.FullName); ");
                //strCodeForCs.Append("\r\n" + "Response.End();");
                //strCodeForCs.Append("\r\n" + "return true;");
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

        public string Gen_WebView_CS_DefProperty_vsClassificationFieldName()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";
                if (objAdjustOrderNum.ClassificationFieldValueLst == null) return "";

                foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                {
                    string strInFor_OrderNum = string.Format("{0}_OrderNum", strInFor);
                    strInFor_OrderNum = strInFor_OrderNum.Replace("_OrderNum_OrderNum", "_OrderNum");
                    ///���ɽ��б���;
                    //strCodeForCs.Append("\r\n" + "//�����йصı����������");

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ViewState����:��ǰ��¼����ķ�������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "protected string vs{0}", strInFor_OrderNum);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "get");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string sClassificationField;");
                    strCodeForCs.AppendFormat("\r\n" + "sClassificationField = (string)ViewState[\"{0}\"];", strInFor_OrderNum);
                    strCodeForCs.Append("\r\n" + "if (sClassificationField == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "sClassificationField = \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return sClassificationField;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "set");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string sClassificationField = value;");
                    strCodeForCs.AppendFormat("\r\n" + "ViewState.Add(\"{0}\", sClassificationField);", strInFor_OrderNum);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
       
    }
}