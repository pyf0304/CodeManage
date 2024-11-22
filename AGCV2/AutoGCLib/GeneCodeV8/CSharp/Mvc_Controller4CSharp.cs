using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
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
    partial class Mvc_Controller4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";


        #region ���캯��
        public Mvc_Controller4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public Mvc_Controller4CSharp(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_Controller4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            //intZIndex = 100;        ///�ؼ��������
            //intCurrLeft = 10;  ///�ؼ�����߿�;
            //intCurrTop = 10;
        }
        #endregion

   
  

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                //}

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
                strCodeForCs.Append("\r\n" + "using System.Web.Mvc;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
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
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.Models.PubFun;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.Models;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}Mvc.BusinessLogic;", objProject.PrjDomain);
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
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
            this.objViewInfoENEx = objViewInfoENEx;


            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            //string strFolder;
            string strTemp;
            objViewInfoENEx.MvcControllerName = string.Format("{0}Controller", objViewInfoENEx.TabName);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs",
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcControllerName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcControllerName;

            strRe_ClsName = objViewInfoENEx.MvcControllerName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
        clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
             objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);


            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//���������صĿؼ����Ʋ����");

                strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����



                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}Mvc.Controllers", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		{0} ��ժҪ˵����", objViewInfoENEx.MvcControllerName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : {1}BaseController",
                    objViewInfoENEx.MvcControllerName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "public int PageSize = 10;");
                //strCodeForCs.Append("\r\n" + "public int RecordNum = 0;");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
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
     


        public string Gen_4MvcCtrl_PrepareModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊҳ��׼��ģ��,��������ѯ����Ϣ��������Ϣ����ҳ��Ϣ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"model\">ģ��</param>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�޸ĵĹؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n /// <param name = \"sortOrder\">������Ϣ</param>");
                strCodeForCs.Append("\r\n /// <param name = \"page\">ҳ��</param>");
                strCodeForCs.AppendFormat("\r\n" + "private ViewModel4{0} PrepareModel(ViewModel4{0} model, {1} {2} = {3}, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key?"0":"\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = null;",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "//�ؼ��ֲ�Ϊ��,˵�����޸�");
                if (IsNumberType4Key == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)",
                        objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} >0)",
                        objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "{");

             

                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                    objMainPrjTab.TabName, FldName4Key, objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN, NewModel);",
                    objMainPrjTab.TabName);

                strCodeForCs.AppendFormat("\r\n" + "if (seQryModel4{0} != null)",
                    objViewInfoENEx.TabName_Out   );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (model == null)"); 
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//modelΪ��,��Viewû�л�ȡģ��,�������״ε��ø�View, ����û�д�Viewû�л�ȡģ��");

                strCodeForCs.AppendFormat("\r\n" + "NewModel = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "if (seQryModel4{0} != null)",
    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");            
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//model��Ϊ��,��View��ȡ��ģ�͡�");
                strCodeForCs.Append("\r\n" + "//1������ģ���л�ȡ�Ĳ�ѯ��Ϣ��ȡ����,��ѯ��ؼ�¼�����б�");
                strCodeForCs.Append("\r\n" + "//2���Ѳ�ѯ�������ݴ��ص�View�С�");
                strCodeForCs.Append("\r\n" + "//3���ѱ༭�������ݴ��ص�View�С�");

                strCodeForCs.AppendFormat("\r\n" + "NewModel = model;",
                    objMainPrjTab.TabName);
              
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = model.qryModel4{0};",
                //    objViewInfoENEx.TabName_Out);
            
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "if (NewModel.qryModel4{0} != null)",
                objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = Combine{0}Condition(NewModel.qryModel4{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "string strSortOrder = sortOrder.Replace(\"_desc\", \" desc\");");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLstByPager(page, PageSize, strWhereCond, strSortOrder);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.RecordNum = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "IEnumerable <cls{0}EN> arrObjLst2 = arrObjLst;", objMainPrjTab.TabName);
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = String.IsNullOrEmpty(sortOrder) || sortOrder== \"{0}\" ? \"{0}_desc\" : \"\";",
                            ObjInFor.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = sortOrder == \"{0}\" ? \"{0}_desc\" : \"{0}\";",
                            ObjInFor.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "            switch (sortOrder)");
                strCodeForCs.Append("\r\n" + "{");
                bolIsFirst = true;
                string strFirstFieldName = "";
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strFirstFieldName = ObjInFor.ObjFieldTabENEx.FldName;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":",
                        ObjInFor.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.OrderBy(s => s.{0});",
                        ObjInFor.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.AppendFormat("\r\n" + "case \"{0}_desc\":",
                        ObjInFor.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.OrderByDescending(s => s.{0});",
                        ObjInFor.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "break;");

                }

                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arrObjLst = arrObjLst.OrderBy(s => s.{0});",
                    strFirstFieldName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "NewModel.{0}Lst = arrObjLst;",
                    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + ".Skip((page - 1) * PageSize)");
                //strCodeForCs.Append("\r\n" + ".Take(PageSize);");
                strCodeForCs.Append("\r\n" + "NewModel.PagingInfo = new PagingInfo");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "CurrentPage = page,");
                strCodeForCs.Append("\r\n" + "ItemsPerPage = PageSize,");
                strCodeForCs.Append("\r\n" + "TotalItems = this.RecordNum");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return NewModel;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Create()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �½���¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public ViewResult Create()",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                    objMainPrjTab.TabName);
                if (IsNumberType4Key == false)
                {
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                            objKeyField.FldName, objMainPrjTab.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                            objKeyField.FldName, objMainPrjTab.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Update()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public ViewResult Update({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,  FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null, {1});",
                    objMainPrjTab.TabName, FldName4Key);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", FldName4Key);

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_List()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ר�����ڷ�ҳ�е���ʾ�б��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"page\"></param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult List(int page = 1)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
           
                strCodeForCs.Append("\r\n" + "seIsAjax = false;");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
         
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
         
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_Pager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ר�����ڷ�ҳ�е���ʾ�б��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"page\"></param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult {0}_Pager(int page = 1)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                        
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_RedirectToList()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����Ƿ���Ajax,�ֱ��ض�����Ӧ����View");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult RedirectToList()",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (seIsAjax == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return RedirectToAction(\"ListAjax\");");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "return RedirectToAction(\"List\");");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        
        public string Gen_4MvcCtrl_Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ѯ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"model\">��View��ȡ��ģ������</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}_Query(ViewModel4{0} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
      
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model.qryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_QueryAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ѯ��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"model\">��View��ȡ��ģ������</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public PartialViewResult QueryAjax(ViewModel4{0} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model.qryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }     

        public string Gen_4MvcCtrl_Delete()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ɾ�������б��е�ѡ��һ����¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">��ѡ�Ĺؼ����б�</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult Delete({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                              
                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.DelRecord({1});",
                            objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "                if (intRecCount == 1)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "                    TempData[\"message\"] = string.Format(\"[{{0}}] �Ѿ���ɾ��!\", {0});",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                else");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "                    TempData[\"message\"] = string.Format(\"[{{0}}] �����Ѿ���ɾ��!\", {0});",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "                string strMsg = string.Format(\"ɾ����¼����!�ؼ���:[{{0}}].������Ϣ:{{1}}.\", {0}, objException.Message);",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToList();");


                //strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                //    objViewInfoENEx.TabName_Out);

                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
            

        public string Gen_4MvcCtrl_GetObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"{0}\">�ؼ���</param>");
                strCodeForCs.Append("\r\n" + "/// <returns>Json����</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult GetObjBy{1}({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({1});",
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "   if (seIsAjax == true)");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUDAjax\", (object)obj{0}EN);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", (object)obj{0}EN);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_GetJsonObjByKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡJson����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"{0}\">�ؼ���</param>");
                strCodeForCs.Append("\r\n" + "/// <returns>Json����</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public JsonResult GetJsonObjBy{1}({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({1});",
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.AppendFormat("\r\n" + "return Json(obj{0}EN, JsonRequestBehavior.AllowGet);",
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_Deletes()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ɾ�������б��ж�ѡ�Ķ�����¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">��ѡ�Ĺؼ����б�</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ActionResult Deletes(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
             

                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "            return RedirectToList();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "string strIds = string.Join(", ", checkedId.Cast<string>().ToArray());
                strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                    FldName4Key);
                //  DAL.BatchDelete(strIds)
                //return View();
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.Del{0}s(arr{1});",
                    objMainPrjTab.TabName,
                    FldName4Key);
             
                strCodeForCs.Append("\r\n" + "                if (intRecCount > 0)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"��[{0}]����¼ �Ѿ���ɾ��!\", intRecCount);");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                else");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"��[0]����¼��ɾ��!\");");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"ɾ��������¼����!������Ϣ:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToList();");



                //strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                //    objViewInfoENEx.TabName_Out);

                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_SortList()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ר�������б��ֶ��������ʾ�б��¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"model\">��View��������Model</param>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"sortOrder\">��View��������������Ϣ</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public ViewResult {1}_SortList(ViewModel4{0} model, string sortOrder)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "seSortOrder = sortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_Save()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public ActionResult Save(ViewModel4{0} model, string Operate)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                
                strCodeForCs.Append("\r\n" + "if (ModelState.IsValid)");
                strCodeForCs.Append("\r\n" + "{");             
             
                strCodeForCs.Append("\r\n" + "if (Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model);",
                    objMainPrjTab.TabName);
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,����Ҫ��������Ƿ��Ѿ�����,�����ʱ,�ٻ�ȡ ���ֵ��Ϊ����");
                    strCodeForCs.AppendFormat("\r\n" + "//if (cls{0}BL.IsExist({1}) == true)",
                    objMainPrjTab.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + "//{");

                    strCodeForCs.AppendFormat("\r\n" + "//string strMsg = string.Format(\"�ؼ���:[�û�Id:{0}]�Ѿ�����,�����ظ������ͬ�ؼ��ּ�¼!\",  model.{0});",
                            FldName4Key);
                    strCodeForCs.Append("\r\n" + "//TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "//ModelState.AddModelError(\"\", strMsg);");
                    strCodeForCs.AppendFormat("\r\n" + "//ViewModel4{0} NewModel = PrepareModel(model, {1});",
                        objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                    //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                    strCodeForCs.Append("\r\n" + "//ViewBag.Operate = \"Add\";");
                    strCodeForCs.AppendFormat("\r\n" + "//return View(\"{0}CRUD\", NewModel);",
                        objMainPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "//}");
                    strCodeForCs.Append("\r\n" + "");
                }
                else if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}) == true)",
                    objMainPrjTab.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ؼ���:[�û�Id:{0}]�Ѿ�����,�����ظ������ͬ�ؼ��ּ�¼!\",  model.{0});",
                            FldName4Key);
                    strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                        objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                    //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                    strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                    strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                        objMainPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();",
                 objMainPrjTab.TabName);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,���������ʱ,�Զ���ȡ����ֵ��");
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                        objMainPrjTab.TabName, objKeyField.PropertyName(this.IsFstLcase), strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.PropertyName(this.IsFstLcase));
                    strCodeForCs.Append("\r\n" + " }");
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "TempData[\"message\"] = string.Format(\"{{0}} has been saved\", obj{0}EN.{1});",
                    objMainPrjTab.TabName, FldName4Key, "{", "}");
             
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
             
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�༭��¼�д�!����{0}\", objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "return RedirectToList();");

                strCodeForCs.Append("\r\n" + "//return View();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model);",
                    objMainPrjTab.TabName);
                if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                     objMainPrjTab.TabName, FldName4Key);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                                        objMainPrjTab.TabName, FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = seKeyId;", 
                    objMainPrjTab.TabName, FldName4Key);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();",
                 objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "TempData[\"message\"] = string.Format(\"{{0}} has been saved.\", obj{0}EN.{1}); ",
                    objMainPrjTab.TabName, FldName4Key, "{", "}");
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�༭��¼�д�!����{0}\", objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Update\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                //objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //objMainPrjTab.TabName);
                //strCodeForCs.Append("\r\n" + "//return View();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�༭��¼�д�!����{0}\", objException.Message);");
                //strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                //strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return View();");
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"�༭��¼�д�!\";");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                strCodeForCs.Append("\r\n" + "string action = GetCurrentAction();");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "ViewBag.EditError = \"true\";");
                //strCodeForCs.Append("\r\n" + "ViewBag.PreOperate = Operate;");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = Operate;");
                strCodeForCs.Append("\r\n" + "return RedirectToList();");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                //return RedirectToAction("List");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_4MvcCtrl_seKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڱ����޸ļ�¼�Ĺؼ���(KeyId)");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public {0} seKeyId",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} strKeyId = {1};", 
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    IsNumberType4Key ? "0" : "\"\"");
            
                strCodeForCs.Append("\r\n" + "if (System.Web.HttpContext.Current.Session[\"KeyId\"] == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strKeyId = {0};", IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strKeyId = ({0})System.Web.HttpContext.Current.Session[\"KeyId\"];",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "return strKeyId;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} strKeyId = value;",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"KeyId\", strKeyId);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_seIsAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڱ��浱ǰ�Ƿ���Ajax������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "    public bool seIsAjax");
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            get");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                bool bolIsAjax = false;");
                strCodeForCs.Append("\r\n" + "                if (System.Web.HttpContext.Current.Session[\"IsAjax\"] == null)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    return false;");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                bolIsAjax = (bool)System.Web.HttpContext.Current.Session[\"IsAjax\"];");
                strCodeForCs.Append("\r\n" + "                return bolIsAjax;");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            set");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                bool bolIsAjax = value;");
                strCodeForCs.Append("\r\n" + "                System.Web.HttpContext.Current.Session.Add(\"IsAjax\", bolIsAjax);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        }");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_seTabInfo4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTabName =  objViewInfoENEx.TabName_Out;
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڲ�ѯ��Ϣ��Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public QryModel4{0} seQryModel4{0}",
                    strTabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} objQryModel4{0};",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "objQryModel4{0} = (QryModel4{0})System.Web.HttpContext.Current.Session[\"QryModel4{0}\"];",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "return objQryModel4{0};",
                    strTabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} objQryModel4{0} = value;",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"QryModel4{0}\", objQryModel4{0});",
                    strTabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
       

        public string Gen_4MvcCtrl_PrepareDdlViewData()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ׼��������İ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "private void PrepareDdlViewData()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //string strTemp = Gen_Mvc_GetDdlBindDS();
                //strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                

            //    strCodeForCs.Append("\r\n" + "ViewData[\"CollegeList\"] = clsDepartmentInfoBL.GetObjLst4SelectListItem(\"1=1\");");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_GetCurrentAction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ȡ��ǰҳ���Action����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public string GetCurrentAction()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n" + "string action = Request.RequestContext.RouteData.Values[\"action\"].ToString();");
                strCodeForCs.Append("\r\n" + "if (!string.IsNullOrWhiteSpace(action))");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "action = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return action;");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_GetCurrentController()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ȡ��ǰҳ���Controller����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public string GetCurrentController()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "string controller = Request.RequestContext.RouteData.Values[\"controller\"].ToString();");
                strCodeForCs.Append("\r\n" + "if (!string.IsNullOrWhiteSpace(controller))");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "controller = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return controller;");
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
        /// ��ȡ������󶨵�����Դ
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_Mvc_GetDdlBindDSBak20230309()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                if (arrTabName.Contains("TrueAndFalse") == false)
                                {
                                    arrTabName.Add("TrueAndFalse");
                                    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                                }
                            }
                            else
                            {
                                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objEditRegionFldsEx.DsTabId);
                                if (objPrjTabEN_CodeTab == null)
                                {
                                    string strMsg = string.Format("�ڽ���༭��,{0}�����������Դ��û������,����!({1})",
                                        objEditRegionFldsEx.FldName,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }
                                if (arrTabName.Contains(objPrjTabEN_CodeTab.TabName) == false)
                                {
                                    arrTabName.Add(objPrjTabEN_CodeTab.TabName);
                                    strCodeForCs.AppendFormat("\r\n" + "ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                                        objPrjTabEN_CodeTab.TabName);
                                }
                            }
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            if (arrTabName.Contains("TrueAndFalse") == false)
                            {
                                arrTabName.Add("TrueAndFalse");
                                strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դֵ�ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ�ı��ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            if (arrTabName.Contains(objPrjTabEN_CodeTab.TabName) == false)
                            {
                                arrTabName.Add(objPrjTabEN_CodeTab.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                                      objPrjTabEN_CodeTab.TabName);
                            }
                        }
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


        public string Gen_4MvcCtrl_DdlEvent()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                if (arrTabName.Contains("TrueAndFalse") == false)
                                {

                                    using (JsFunction objJsFunc = new JsFunction())
                                    {
                                        objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);
                                        arrTabName.Add("TrueAndFalse");
                                        objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                        objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                           objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                        //objJsFunc.sbText.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                                        objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                        objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                        objJsFunc.sbText.Append("\r\n" + "//����Ҫ�˺���ʱ,��ȥ���������д����ע��,������Ӧ���޸�");

                                        objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                            objEditRegionFldsEx.FldName);
                                        objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");

                                        objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                        objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                        objJsFunc.sbText.Append("\r\n" + "{");
                                        objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                        objJsFunc.sbText.Append("\r\n" + "};");
                                        objJsFunc.sbText.Append("\r\n" + "return res;");
                                        objJsFunc.sbText.Append("\r\n" + "}");
                                    }
                                }
                            }
                            else
                            {
                                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objEditRegionFldsEx.DsTabId);
                                if (objPrjTabEN_CodeTab == null)
                                {
                                    string strMsg = string.Format("�ڽ���༭��,{0}�����������Դ��û������,����!({1})",
                                        objEditRegionFldsEx.FldName,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }
                               
                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                       objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                    objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                    objJsFunc.sbText.Append("\r\n" + "//����Ҫ�˺���ʱ,��ȥ���������д����ע��,������Ӧ���޸�");

                                    objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                        objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");
                                    
                                    objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                    objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                    objJsFunc.sbText.Append("\r\n" + "};");
                                    objJsFunc.sbText.Append("\r\n" + "return res;");
                                    objJsFunc.sbText.Append("\r\n" + "}");
                                    arrJsFunction.Add(objJsFunc);
                                }

                            }
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            if (arrTabName.Contains("TrueAndFalse") == false)
                            {
                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    arrTabName.Add("TrueAndFalse");
                                    objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                    objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                       objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    //objJsFunc.sbText.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                                    objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                    objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                    objJsFunc.sbText.Append("\r\n" + "//����Ҫ�˺���ʱ,��ȥ���������д����ע��,������Ӧ���޸�");

                                    objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                        objQryRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");
                                    objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                    objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                    objJsFunc.sbText.Append("\r\n" + "};");
                                    objJsFunc.sbText.Append("\r\n" + "return res;");
                                    objJsFunc.sbText.Append("\r\n" + "}");
                                    arrJsFunction.Add(objJsFunc);
                                }

                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դֵ�ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ�ı��ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            using (JsFunction objJsFunc = new JsFunction())
                            {
                                objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.Append("\r\n" + "[HttpGet]");
                                objJsFunc.sbText.AppendFormat("\r\n" + "public JsonResult {0}Selected(string {1})",
                                   objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.Append("\r\n" + "const res = new JsonResult();");
                                objJsFunc.sbText.Append("\r\n" + "List<SelectListItem> sltSubType = null;");
                                objJsFunc.sbText.Append("\r\n" + "//����Ҫ�˺���ʱ,��ȥ���������д����ע��,������Ӧ���޸�");

                                objJsFunc.sbText.AppendFormat("\r\n" + "//string strCondition = string.Format(\"{{0}}='{{1}}'\", conSubType.{0}, {0});",
                                    objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "//sltSubType = clsSubTypeBL4Mvc.GetObjLst4SelectListItem(strCondition);");                                
                                objJsFunc.sbText.Append("\r\n" + "res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;");
                                objJsFunc.sbText.Append("\r\n" + "res.Data = new");
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.Append("\r\n" + "SubTypeLst = sltSubType");
                                objJsFunc.sbText.Append("\r\n" + "};");
                                objJsFunc.sbText.Append("\r\n" + "return res;");
                                objJsFunc.sbText.Append("\r\n" + "}");
                                arrJsFunction.Add(objJsFunc);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            arrJsFunction.Sort((x, y) => { return x.funcName.CompareTo(y.funcName); });
            foreach (JsFunction objJsFunction in arrJsFunction)
            {
                strCodeForCs.Append("\r\n" + objJsFunction.funcText);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_CombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "protected string Combine{0}Condition(QryModel4{0} obj{0}EN)", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    string strFldName = objQryRegionFldsEx.FldName;
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == true)",
                                        objViewInfoENEx.TabName_Out, objQryRegionFldsEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                          
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out);
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///����ؼ���������;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"true\")",
                                        objViewInfoENEx.TabName_Out,
                                           strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN.{1} == \"false\")",
                                        objViewInfoENEx.TabName_Out,
                                         strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                        
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":

                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false && obj{0}EN.{1} != \"0\")",
                                    objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                                  objViewInfoENEx.TabName_Out,
                                                objQryRegionFldsEx.FldName);
                                        break;
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1}>0)",
                                    objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{0}.{1}, obj{0}EN.{1});",
                                                objViewInfoENEx.TabName_Out,
                                                objQryRegionFldsEx.FldName);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false && obj{0}EN.{1} != \"0\")",
                                    objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                                  objViewInfoENEx.TabName_Out,
                                                objQryRegionFldsEx.FldName);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "TextBox": ///����ؼ��������ı���;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///��Ȳ�ѯ;
                            {
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "string":
                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                      objViewInfoENEx.TabName_Out,
                                        strFldName);
                                        break;
                                    case "int":
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1}>0)",
                                  objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                  objViewInfoENEx.TabName_Out,
                                    strFldName);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                           objViewInfoENEx.TabName_Out,
                                            objQryRegionFldsEx.FldName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = {{1}}\", con{0}.{1},  obj{0}EN.{1});",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName);
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///ģ����ѯ;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                     objViewInfoENEx.TabName_Out,
                                        strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} like '%{{1}}%'\", con{0}.{1}, obj{0}EN.{1});",
                                     objViewInfoENEx.TabName_Out,
                                     objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///��Χ��ѯ;
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                      objViewInfoENEx.TabName_Out,
                                       strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                                                        objViewInfoENEx.TabName_Out,
                                        objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)",
                                                  objViewInfoENEx.TabName_Out,
                                                    strFldName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\"And {{0}} = '{{1}}'\", con{0}.{1}, obj{0}EN.{1});",
                                      objViewInfoENEx.TabName_Out,
                                      objQryRegionFldsEx.FldName);
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
               
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.MvcControllerName, "Combine{0}Condition", "(AspMvc)����ϲ�ѯ����(Combine{0}Condition)ʱ����!����ϵ����Ա!", "���ɴ���");
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
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_PutDataToClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///���ɽ��б���;
                //strCodeForCs.Append("\r\n ///1���ɴӽ���㵽�߼�������ݴ��亯������");
              
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:�ѽ����ϵ��������ݴ����������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">���ݴ����Ŀ�������</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void PutDataTo{0}Class(cls{0}EN pobj{0}EN, ViewModel4{0} model)",
                    objViewInfoENEx.TabName );
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        string strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);
                    }
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
        public string Gen_4MvcCtrl_GetDataFromClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

              
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// ��������:������������������ʾ��������");
                    strCodeForCs.Append("\r\n ///ע��:���������������,������һ��������������ϵ��,����Ϊһ��������ֵ,Ȼ����Ϊ����������ֵ");
                    strCodeForCs.Append("\r\n /// ������������ݿ�ʱ,��Ӧ��һ���ֶ���ǰ,�����ֶ��ں�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">��ʵ�������</param>",
                    objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "protected void GetDataFrom{0}Class(cls{0}EN pobj{0}EN, ViewModel4{0} model)",
                            objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        string strTemp = Get_4MvcCtrl_Code4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);

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

        private string Get_4MvcCtrl_Code4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(model.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = model.{3};",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string Get_4MvcCtrl_Code4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0003") //ֻд
            {
                sbCodeForCs.AppendFormat("\r\n" + "model.{1} = pobj{2}BL.Get{3}();",
                  objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            else if (objEditRegionFldsEx.FldOpTypeId() == "0002") //ֻ��
            {
                sbCodeForCs.AppendFormat("\r\n" + "model.{1} = pobj{2}EN.{3};",
                  objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "model.{1} = pobj{2}EN.{3};",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        //public string Gen_4MvcCtrl_GetObjLst4SelectListItem()
        //{
        //    if (objProjectsENEx.IsSupportMvc == false) return "//������Ŀ��֧��Mvc,���Բ�������GetObjLst4SelectListItem()����";
        //    StringBuilder strCodeForCs = new StringBuilder();
        //    string strTextFieldName = "";
        //    string strValueFieldName = "";
        //    try
        //    {
        //        ///���ɽ��б���;
        //        //��0��:�ѿؼ���������ComboBoxת����ComboBox
        //        foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
        //        {
        //            if (objField.FieldTypeId == "02")
        //            {
        //                strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
        //            }
        //            if (objField.FieldTypeId == "03")
        //            {
        //                strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
        //            }
        //        }
        //        if (strValueFieldName != "" && strTextFieldName != "")
        //        {
        //            strCodeForCs.Append("\r\n /// <summary>");
        //            strCodeForCs.Append("\r\n /// ��ȡ�û���������Ķ����б�");
        //            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //            strCodeForCs.Append("\r\n /// </summary>");
        //            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</param>");
        //            strCodeForCs.AppendFormat("\r\n" + "public static List<SelectListItem> GetObjLst4SelectListItem(string strWhereCond)",
        //            strValueFieldName);
        //            strCodeForCs.Append("\r\n" + "{");
        //            strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");


        //            //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = new cls{1}DA().Get{0}();",
        //            //strValueFieldName, objPrjTabENEx.TabName);
        //            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(strWhereCond); ",
        //                      objPrjTabENEx.TabName);
        //            strCodeForCs.AppendFormat("\r\n" + "List<SelectListItem> {0}List = new List<SelectListItem>();",
        //                objPrjTabENEx.TabName);
        //            strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = \"ѡ[{5}]...\", Value = \"0\" {4});",
        //            objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}", objPrjTabENEx.TabCnName);

        //            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
        //            strCodeForCs.Append("\r\n" + "{");
        //            strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = objInFor.{1}, Value = objInFor.{2} {4});",
        //                objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}");
        //            strCodeForCs.Append("\r\n" + "}");

        //            strCodeForCs.AppendFormat("\r\n" + "return {0}List;", objPrjTabENEx.TabName);

        //            strCodeForCs.Append("\r\n" + "}");
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        clsEntityBase.LogErrorS(ex, "");
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_Controller4CSharp);
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
            this.ClsName = string.Format("{0}Controller", objViewInfoENEx.TabName);
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
