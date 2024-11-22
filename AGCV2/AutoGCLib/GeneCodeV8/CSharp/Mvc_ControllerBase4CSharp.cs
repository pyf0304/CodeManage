using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections;
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
    partial class Mvc_ControllerBase4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        #region ���캯��
        public Mvc_ControllerBase4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public Mvc_ControllerBase4CSharp(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_ControllerBase4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            this.objViewInfoENEx = objViewInfoENEx;
            string strFuncName = "";

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
     
            string strTemp;
            objViewInfoENEx.MvcControllerName = string.Format("{0}BaseController", objViewInfoENEx.TabName);

            objViewInfoENEx.WebUserCtlCsFName = string.Format("{0}{1}.cs",
                objViewInfoENEx.FolderName, objViewInfoENEx.MvcControllerName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlCsFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.MvcControllerName;

            strRe_ClsName = objViewInfoENEx.MvcControllerName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlCsFName);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
            //    clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
            //        objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            //int intCount1 = arrvFunction4GeneCodeObjLst.Count();
            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
            //int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
            //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
            //int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();
            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());
            //int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();
            //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);
            //int intCount5 = arrvFunction4GeneCodeObjLst_All.Count();

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
                strCodeForCs.AppendFormat("\r\n" + "public partial class  {0} : Controller",
                    objViewInfoENEx.MvcControllerName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "public int PageSize = 10;");
                strCodeForCs.Append("\r\n" + "public int RecordNum = 0;");
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                ///�����û��Զ���ؼ�������Page_Load����;
                //strTemp = GenPage_LoadCode4Wuc();
                //strCodeForCs.Append(strTemp);

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
                strCodeForCs.AppendFormat("\r\n" + "protected virtual ViewModel4{0} PrepareModel(ViewModel4{0} model, {1} {2} = {3}, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key?"0":"\"\"");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
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
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN, NewModel.editModel4{0});",
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

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(NewModel.qryModel4{0});",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "string strSortOrder = sortOrder.Replace(\"_desc\", \" desc\");");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLstByPager(page, PageSize, strWhereCond, strSortOrder);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.RecordNum = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "IEnumerable <cls{0}EN> arrObjLst2 = arrObjLst;", objMainPrjTab.TabName);
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x=>x.ObjFieldTabENEx != null))
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = String.IsNullOrEmpty(sortOrder) || sortOrder== \"{0}\" ? \"{0}_desc\" : \"{0}\";",
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
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x => x.ObjFieldTabENEx != null))
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

        public string Gen_4MvcCtrl_PrepareListModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�б���׼���б�ģ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"model\">ģ��</param>");
                strCodeForCs.Append("\r\n /// <param name = \"sortOrder\">������Ϣ</param>");
                strCodeForCs.Append("\r\n /// <param name = \"page\">ҳ��</param>");
                strCodeForCs.AppendFormat("\r\n" + "protected virtual ViewModel4{0} PrepareListModel(QryModel4{1} model, string sortOrder = \"\", int page = 1)",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel =  new ViewModel4{0}();",
                    objMainPrjTab.TabName);

                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(model);",
                    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "string strSortOrder = sortOrder.Replace(\"_desc\", \" desc\");");
                strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arrObjLst = cls{0}BL.GetObjLstByPager(page, PageSize, strWhereCond, strSortOrder);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.RecordNum = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objViewInfoENEx.TabName_Out);

                //strCodeForCs.Append("\r\n" + "IEnumerable <cls{0}EN> arrObjLst2 = arrObjLst;", objMainPrjTab.TabName);
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x => x.ObjFieldTabENEx != null))
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCodeForCs.AppendFormat("\r\n" + "ViewBag.{0}SortParm = String.IsNullOrEmpty(sortOrder) || sortOrder== \"{0}\" ? \"{0}_desc\" : \"{0}\";",
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
                foreach (clsDGRegionFldsENEx ObjInFor in objViewInfoENEx.arrDGRegionFldSet.Where(x => x.ObjFieldTabENEx != null))
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


        public string Gen_4MvcCtrl_PrepareEditModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�༭��׼���༭ģ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�޸ĵĹؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "protected virtual EditModel4{0} PrepareEditModel({1} {2} = {3})",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = NewModel = new EditModel4{0}();",
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
           
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN, NewModel);",
                    objMainPrjTab.TabName);
                              
                strCodeForCs.Append("\r\n" + "}");
              
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
        public string Gen_4MvcCtrl_PrepareQueryModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ��ѯ��׼����ѯģ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�޸ĵĹؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "protected virtual QryModel4{0} PrepareQueryModel()",
                    objViewInfoENEx.TabName_Out, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Query();");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} NewModel = null;",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "if (seQryModel4{0} != null)",
    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new QryModel4{0}();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_4MvcCtrl_PrepareFeatureModel()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ������׼����������ģ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�޸ĵĹؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "protected virtual FeatureModel4{0} PrepareFeatureModel()",
                    objViewInfoENEx.TabName_In, objKeyField.CsType, objKeyField.PrivFuncName,
                    IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Feature();");
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} NewModel = null;",
                    objViewInfoENEx.TabName_In);

                strCodeForCs.AppendFormat("\r\n" + "if (seFeatureModel4{0} != null)",
    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = seFeatureModel4{0};",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "NewModel = new FeatureModel4{0}();",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "}");
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Create\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual ViewResult Create()",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                    objMainPrjTab.TabName);
                if (IsNumberType4Key == false)
                {
                    if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "NewModel.editModel4{1}.{0} = cls{1}BL.GetMaxStrId_S();",
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

        public string Gen_4MvcCtrl_CreateAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �½���¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"CreateAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult CreateAjax()",
                    objViewInfoENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = PrepareEditModel();",
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
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}EditAjax\", NewModel);",
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
        public string Gen_4MvcCtrl_UpdateAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UpdateAjax\")]");
                strCodeForCs.Append("\r\n" + "public virtual PartialViewResult UpdateAjax(string[] checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�޸ĵļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }

                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = PrepareEditModel({1});",
                    objMainPrjTab.TabName, objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", objKeyField.PrivFuncName);

                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}EditAjax\", NewModel);",
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


        public string Gen_4MvcCtrl_OnException()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Mvc ������(Controller)���쳣(Exception)������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " protected override void OnException(ExceptionContext filterContext)");
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            if (filterContext.Exception == null) return;");
                strCodeForCs.Append("\r\n" + "            //��ȡ�׳��쳣�Ķ���          ");
                strCodeForCs.Append("\r\n" + "             //д��־    ");
                strCodeForCs.Append("\r\n" + "  	    //Exception ex = filterContext.Exception;             ");
                strCodeForCs.Append("\r\n" + "            //System.IO.File.AppendAllText(filterContext.HttpContext.Server.MapPath(\"/Logs/Log.txt\"), ex.ToString());");
                strCodeForCs.Append("\r\n" + "            //���������Ϊfalse,�ͱ�ʾ����MVC���,��û�д����������Ȼ��������ת���Լ�����Ĵ���ҳ����Ϊtrue�Ļ�,�ͱ�ʾ����MVC���,�쳣���Ѿ������ˡ�����Ҫ����ת������ҳ��,Ҳ�����׳���ҳ�ˣ�          ");
                strCodeForCs.Append("\r\n" + "            filterContext.ExceptionHandled = true;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.Clear();");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.ContentEncoding = Encoding.UTF8;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.HeaderEncoding = Encoding.UTF8;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.StatusCode = 500;");

                strCodeForCs.Append("\r\n" + "    string strMsg = filterContext.Exception.Message;");
                strCodeForCs.Append("\r\n" + "            string strUTF8Code = \"\";");
                strCodeForCs.Append("\r\n" + "            //foreach (byte b in Encoding.UTF8.GetBytes(strMsg))");
                strCodeForCs.Append("\r\n" + "            //{");
                strCodeForCs.Append("\r\n" + "            //    strUTF8Code += '%' + b.ToString(\"X\");");
                strCodeForCs.Append("\r\n" + "            //}");
                strCodeForCs.Append("\r\n" + "            strUTF8Code = HttpUtility.UrlEncode(strMsg, Encoding.UTF8);");
                strCodeForCs.Append("\r\n" + "            filterContext.HttpContext.Response.StatusDescription = strUTF8Code;");
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Update\")]");
                strCodeForCs.Append("\r\n" + "public virtual ViewResult Update(string[] checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�޸ĵļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
         
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null, {1});",
                    objMainPrjTab.TabName, objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", objKeyField.PrivFuncName);

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
        public string Gen_4MvcCtrl_UpdateInTab()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual ViewResult UpdateInTab({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key, objMainPrjTab.TabName);
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
        public string Gen_4MvcCtrl_UpdateInTabAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult UpdateInTabAjax({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", KeyFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", KeyFldName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"û��ѡ���¼,�����޸�!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,�����޸�!\");");

                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

                strCodeForCs.AppendFormat("\r\n" + "EditModel4{0} NewModel = PrepareEditModel({1});",
                    objMainPrjTab.TabName, FldName4Key);

                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seKeyId = {0};", FldName4Key);
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}EditAjax\", NewModel);",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult List(int page = 1)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "seIsAjax = false;");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                if (objSortField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objSortField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objKeyField.FldName);
                }
//                string sortOrder = string.Format("{0}_desc", conUserPrjGrant.LastVisitedDate);
                strCodeForCs.AppendFormat("\r\n" + "seSortOrder = sortOrder;");
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Pager(int page = 1)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");                        
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult RedirectToList()",
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

        public string Gen_4MvcCtrl_RedirectToListAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����б�Ajax��������ͼ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult RedirectToListAjax(string[] checkedId = null)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
               
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, sePageIndex);",
                 objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
               
                strCodeForCs.Append("\r\n" + "if (checkedId != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����б�Ajax��������ͼ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult RedirectToListAjax({0} {1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, sePageIndex);",
                objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} > 0)", KeyFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)", KeyFldName);
                }

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({0} == objInFor.{0}) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_ListAjax()
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult ListAjax(int page = 1)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//���ò�ѯ���Ƿ�����");
                strCodeForCs.Append("\r\n" + "ViewBag.IsHideQryRegion = false;");

                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "seIsAjax = false;");
                if (objSortField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objSortField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string sortOrder = string.Format(\"{{0}}\", con{0}.{1});",
                        objViewInfoENEx.TabName_Out, objKeyField.FldName);
                }

                //                string sortOrder = string.Format("{0}_desc", conUserPrjGrant.LastVisitedDate);
                strCodeForCs.AppendFormat("\r\n" + "seSortOrder = sortOrder;");
                strCodeForCs.Append("\r\n" + "//׼����ѯ��ģ��,������ѯ��������İ�����");
                strCodeForCs.AppendFormat("\r\n" + "QryModel4{0} NewModel = PrepareQueryModel();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} FeatureModel = PrepareFeatureModel();",
               objViewInfoENEx.TabName_In);
                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUDAjax\", Tuple.Create( NewModel, FeatureModel));",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Query(ViewModel4{0} model)",
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"QueryAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult QueryAjax(QryModel4{1} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(model, sortOrder);",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model;",
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

        public string Gen_4MvcCtrl_QueryAjax2()
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult QueryAjax2(QryModel4{1} model)",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(model, sortOrder);",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "seQryModel4{0} = model;",
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

        public string Gen_4MvcCtrl_DownLoadFile()
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
                strCodeForCs.Append("\r\n" + "public virtual FileResult DownLoadFile(string FileName)");
                strCodeForCs.Append("\r\n" + "{");
                //	�����ļ�,���Գɹ�

                strCodeForCs.Append("\r\n" + "string filePath = Server.MapPath(FileName);");
                strCodeForCs.Append("\r\n" + "string strFileName = clsString.GetSimpleFName_S(filePath); ");
                strCodeForCs.Append("\r\n" + "byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);");
                strCodeForCs.Append("\r\n" + "return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, strFileName);");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_SortListAjax()
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult SortListAjax(string sortOrder)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "seSortOrder = sortOrder;");                
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder);",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + " NewModel.qryModel4{0} = seQryModel4{0};",
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

        public string Gen_4MvcCtrl_PagerAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����ҳ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"page\">ҳ���</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult PagerAjax(int page=1)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                // strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, page);",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "NewModel.qryModel4{0} = seQryModel4{0};",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Delete({0} {1})",
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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual  ActionResult GetObjBy{1}({0} {1})",
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual JsonResult GetJsonObjBy{1}({0} {1})",
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Deletes\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Deletes(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
             

                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
        public string Gen_4MvcCtrl_DeletesAjax()
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
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DeletesAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DeletesAjax(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

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

        public string Gen_4MvcCtrl_DeleteAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ɾ�������б��е�һ����¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">��ɾ���Ĺؼ���</param>", FldName4Key);
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DeleteAjax({0} {1})",
                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

//                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", KeyFldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", KeyFldName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,����ɾ��!\");");
        
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.DelRecord({1});",
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
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"ɾ��һ����¼����!������Ϣ:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.AppendFormat("\r\n" + "      return RedirectToListAjax({0});", KeyFldName);

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


        public string Gen_4MvcCtrl_DelRecordBySignAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objDelSignField == null)
            {
                string strMsg = string.Format("//��[{0}]��ɾ����־�ֶ�(DeletedDate, IsDeleted)Ϊ��,�������ɡ��ָ���ɾ����¼(UnDelRecordBySign)������;",
                    objViewInfoENEx.TabName);
                throw new Exception(strMsg);
                //strCodeForCs.AppendFormat("\r\n" + "//��[{0}]��ɾ����־�ֶ�Ϊ��,�������ɡ���־��ɾ����¼(DelRecordBySign)������;", 
                //    objViewInfoENEx.TabName);
                //return strCodeForCs.ToString();
            }
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��־��ɾ�������б��ж�ѡ��������¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">��ѡ�Ĺؼ����б�</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DelRecordBySignAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DelRecordBySignAjax(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,����ɾ��!\");");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "string strIds = string.Join(", ", checkedId.Cast<string>().ToArray());
                strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                    FldName4Key);
                //  DAL.BatchDelete(strIds)
                //return View();
//                strCodeForCs.Append("\r\n" + "int intRecCount = 0;");
                //strCodeForCs.AppendFormat("\r\n" + "     foreach(string strKey in arr{0})", FldName4Key);
                //strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.DelRecordBySign(arr{1});",
                    objMainPrjTab.TabName,
                    FldName4Key);
                //strCodeForCs.Append("\r\n" + "intRecCount += intDelCount;");
                //strCodeForCs.Append("\r\n" + "                }");

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
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"��־��ɾ��һ����¼����!������Ϣ:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

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


        public string Gen_4MvcCtrl_UnDelRecordBySignAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objDelSignField == null)
            {
string strMsg = string.Format("//��[{0}]��ɾ����־�ֶ�(DeletedDate, IsDeleted)Ϊ��,�������ɡ��ָ���ɾ����¼(UnDelRecordBySign)������;",
                    objViewInfoENEx.TabName);
                throw new Exception(strMsg);
                //strCodeForCs.AppendFormat("\r\n" + "//��[{0}]��ɾ����־�ֶ�Ϊ��,�������ɡ��ָ���ɾ����¼(UnDelRecordBySign)������;",
                //    objViewInfoENEx.TabName);
                //return strCodeForCs.ToString();
            }
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �ָ�ɾ�������б��ж�ѡ��������¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"checkedId\">��ѡ�Ĺؼ����б�</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UnDelRecordBySignAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult UnDelRecordBySignAjax(string[] checkedId)",
                    FldName4Key);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");


                strCodeForCs.Append("\r\n" + " try");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,���ָܻ�ɾ��!\");");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "string strIds = string.Join(", ", checkedId.Cast<string>().ToArray());
                strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                    FldName4Key);
                //  DAL.BatchDelete(strIds)
                
         //       strCodeForCs.Append("\r\n" + "int intRecCount = 0;");
                //strCodeForCs.AppendFormat("\r\n" + "     foreach(string strKey in arr{0})", FldName4Key);
                //strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.UnDelRecordBySign(arr{1});",
                    objMainPrjTab.TabName,
                    FldName4Key);
                //strCodeForCs.Append("\r\n" + "intRecCount += intDelCount;");
                //strCodeForCs.Append("\r\n" + "                }");

                strCodeForCs.Append("\r\n" + "                if (intRecCount > 0)");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"��[{0}]����¼ �Ѿ����ָ�ɾ��!\", intRecCount);");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                else");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"��[0]����¼���ָ�ɾ��!\");");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                string strMsg = string.Format(\"�ָ�ɾ��һ����¼����!������Ϣ:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");
                             
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
                strCodeForCs.AppendFormat("\r\n" + "public virtual ViewResult SortList(ViewModel4{0} model, string sortOrder)",
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

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult Save(ViewModel4{0} model, string Operate)",
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
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model.editModel4{0});",
                    objMainPrjTab.TabName);
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,����Ҫ��������Ƿ��Ѿ�����,�����ʱ,�ٻ�ȡ ���ֵ��Ϊ����");
                    strCodeForCs.AppendFormat("\r\n" + "//if (cls{0}BL.IsExist({1}) == true)",
                    objMainPrjTab.TabName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + "//{");

                    strCodeForCs.AppendFormat("\r\n" + "//string strMsg = string.Format(\"�ؼ���:[�û�Id:{0}]�Ѿ�����,�����ظ������ͬ�ؼ��ּ�¼!\",  model.editModel4{1}.{0});",
                            FldName4Key, objViewInfoENEx.TabName);
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

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"�ؼ���:[�û�Id:{0}]�Ѿ�����,�����ظ������ͬ�ؼ��ּ�¼!\",  model.editModel4{1}.{0});",
                            FldName4Key, objViewInfoENEx.TabName);
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
                        objMainPrjTab.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                    strCodeForCs.Append("\r\n" + " {");
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
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
                strCodeForCs.Append("\r\n" + "//return RedirectToList();");

                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{0}EN, model.editModel4{0});",
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
                strCodeForCs.Append("\r\n" + "//return RedirectToList();");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_4MvcCtrl_SaveAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult SaveAjax(EditModel4{0} model, string Operate)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
               
                strCodeForCs.Append("\r\n" + "if (ModelState.IsValid == false)");                
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"�༭��¼�д�!\";");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                strCodeForCs.Append("\r\n" + "string action = GetCurrentAction();");
                //strCodeForCs.AppendFormat("\r\n" + "NewModel.{0} = cls{1}BL.GetMaxStrId_S();",
                //    FldName4Key, objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "ViewBag.EditError = \"true\";");
                //strCodeForCs.Append("\r\n" + "ViewBag.PreOperate = Operate;");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = Operate;");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(null);",
                //    objMainPrjTab.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModel);",
                //    objMainPrjTab.TabName);
                //return RedirectToAction("List");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "if (Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return AddSaveAjax(model);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return UpdateSaveAjax(model);");
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

        public string Gen_4MvcCtrl_UpdateSaveAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult UpdateSaveAjax(EditModel4{0} model)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");
                
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
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"\";");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"[{0}]�༭��¼�д�!����{1}\", clsStackTrace.GetCurrFunction(), objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Update\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Update\";");
                strCodeForCs.Append("\r\n" + "string strJS = string.Format(\"ShowErrMsg('{0}'); \", strMsg);");
                strCodeForCs.Append("\r\n" + "return JavaScript(strJS);");
                strCodeForCs.Append("\r\n" + "//throw new Exception(strMsg);");
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


        public string Gen_4MvcCtrl_AddSaveAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �޸ļ�¼");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " [HttpPost]");

                strCodeForCs.AppendFormat("\r\n" + "public virtual ActionResult AddSaveAjax(EditModel4{0} model)",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "PrepareDdlData4Edit();");

         
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

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"[{{0}}]�ؼ���:[�û�Id:{0}]�Ѿ�����,�����ظ������ͬ�ؼ��ּ�¼!\", clsStackTrace.GetCurrFunction(), model.{0});",
                            FldName4Key);
                    strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                    //strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1});",
                    //    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                    //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                    strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
                    //strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", model);",
                    //    objMainPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "string strJS = string.Format(\"ShowErrMsg('{0}'); \", strMsg);");
                    strCodeForCs.Append("\r\n" + "return JavaScript(strJS);");
                    strCodeForCs.Append("\r\n" + "}");
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();",
                objMainPrjTab.TabName);

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

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "TempData[\"message\"] = string.Format(\"{{0}} has been saved\", obj{0}EN.{1});",
                    objMainPrjTab.TabName, FldName4Key, "{", "}");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"\";");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"[{0}]�༭��¼�д�!����{1}\", clsStackTrace.GetCurrFunction(), objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", strMsg);");
                //strCodeForCs.Append("\r\n" + "return RedirectToAction(\"Create\", NewModel);");
                strCodeForCs.Append("\r\n" + "ViewBag.Operate = \"Add\";");
  
                strCodeForCs.Append("\r\n" + "string strJS = string.Format(\"ShowErrMsg('{0}'); \", strMsg);");
                strCodeForCs.Append("\r\n" + "return JavaScript(strJS);");
  
                strCodeForCs.Append("\r\n" + "//return View();");
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
        

        public string Gen_4MvcCtrl_seSortOrder()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڱ���������Ϣ��Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public string seSortOrder",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "strSortOrder = (string)System.Web.HttpContext.Current.Session[\"SortOrder4{0}\"];", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (strSortOrder == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strSortOrder = \"\";");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strSortOrder;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strSortOrder = value;");
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"SortOrder4{0}\", strSortOrder);", objViewInfoENEx.TabName);

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

        public string Gen_4MvcCtrl_sePageIndex()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڱ���������Ϣ��Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public int sePageIndex",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex;");
                strCodeForCs.AppendFormat("\r\n" + "strPageIndex = (string)System.Web.HttpContext.Current.Session[\"PageIndex4{0}\"];", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (strPageIndex == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return int.Parse(strPageIndex);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strPageIndex = value.ToString();");
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"PageIndex4{0}\", strPageIndex);", objViewInfoENEx.TabName);

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

        public string Gen_4MvcCtrl_seTabInfo4Feature()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTabName = objViewInfoENEx.TabName_In;
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ڲ�ѯ��Ϣ��Session");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public FeatureModel4{0} seFeatureModel4{0}",
                    strTabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} objFeatureModel4{0};",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "objFeatureModel4{0} = (FeatureModel4{0})System.Web.HttpContext.Current.Session[\"FeatureModel4{0}\"];",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "return objFeatureModel4{0};",
                    strTabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "FeatureModel4{0} objFeatureModel4{0} = value;",
                    strTabName);
                strCodeForCs.AppendFormat("\r\n" + "System.Web.HttpContext.Current.Session.Add(\"FeatureModel4{0}\", objFeatureModel4{0});",
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

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlViewData()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //string strTemp = Gen_4MvcCtrl_GetDdlBindDS();
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
        public string Gen_4MvcCtrl_PrepareDdlData4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ��ѯ��׼��������İ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlData4Query()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strTemp = Gen_4MvcCtrl_GetDdlBindDS4Query();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);


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

        public string Gen_4MvcCtrl_PrepareDdlData4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ������׼��������İ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlData4Feature()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strTemp = Gen_4MvcCtrl_GetDdlBindDS4Feature();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);


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
        public string Gen_4MvcCtrl_PrepareDdlData4Edit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// Ϊ�༭��׼��������İ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected virtual void PrepareDdlData4Edit()",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "{");
                string strTemp = Gen_4MvcCtrl_GetDdlBindDS4Edit();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);


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
        public string Gen_4MvcCtrl_GetDdlBindDSBak20230309()
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
                                strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            //if (objPrjTabEN_CodeTab == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
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

        public string Gen_4MvcCtrl_GetDdlBindDS4Edit()
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
                                    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
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
                                             
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4MvcCtrl_GetDdlBindDS4QueryBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            if (arrTabName.Contains("TrueAndFalse") == false)
                            {
                                arrTabName.Add("TrueAndFalse");
                                strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            //if (objPrjTabEN_CodeTab == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
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
      
        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_4MvcCtrl_GetDdlBindDS4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {

                IEnumerable<ASPDropDownListEx> arrASPDropDownListENEx = objViewInfoENEx.arrQryRegionFldSet
                    .Where(x=>x.objCtlType.CtlTypeName.Contains("DropDownList"))
                    .Select(GetDdlObj).Distinct(new DsTabNameComparer());

                foreach (ASPDropDownListEx objASPDropDownListENEx in arrASPDropDownListENEx)
                {
                    strCodeForCs.Append("\r\n" + objASPDropDownListENEx.GC_BindDdl4Mvc());
                    
                }
                //        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                //    {
                //        if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                //            {
                //                if (arrTabName.Contains("TrueAndFalse") == false)
                //                {
                //                    arrTabName.Add("TrueAndFalse");
                //                    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun_Mvc.GetSliLst4TrueAndFalse();");
                //                }
                //            }
                //            else
                //            {
                //                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                //                clsFieldTabEN objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                //                clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                //                if (objPrjTabEN_CodeTab == null)
                //                {
                //                    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                //                        objQryRegionFldsEx.FldName,
                //                        clsStackTrace.GetCurrClassFunction());
                //                    throw new Exception(strMsg);
                //                }
                //                if (objFieldTab_ValueField == null)
                //                {
                //                    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դֵ�ֶ�û������,����!({1})",
                //                        objQryRegionFldsEx.FldName,
                //                        clsStackTrace.GetCurrClassFunction());
                //                    throw new Exception(strMsg);
                //                }
                //                if (objFieldTabEN_TextField == null)
                //                {
                //                    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ�ı��ֶ�û������,����!({1})",
                //                        objQryRegionFldsEx.FldName,
                //                        clsStackTrace.GetCurrClassFunction());
                //                    throw new Exception(strMsg);
                //                }
                //                if (arrTabName.Contains(objPrjTabEN_CodeTab.TabName) == false)
                //                {
                //                    arrTabName.Add(objPrjTabEN_CodeTab.TabName);
                //                    strCodeForCs.AppendFormat("\r\n" + "ViewData[\"{0}List\"] = cls{0}BL4Mvc.GetObjLst4SelectListItem(\"1=1\");",
                //                          objPrjTabEN_CodeTab.TabName);
                //                }
                //            }
                //        }
                //    }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());



        public string Gen_4MvcCtrl_GetDdlBindDS4Feature()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                IEnumerable<ASPDropDownListEx> arrASPDropDownListENEx = objViewInfoENEx.arrViewFeatureFlds
                    .Where(x => x.ObjCtlType.CtlTypeName.Contains("DropDownList"))
                  .Select(GetDdlObj2).Distinct(new DsTabNameComparer());

                foreach (ASPDropDownListEx objASPDropDownListENEx in arrASPDropDownListENEx)
                {
                    strCodeForCs.Append("\r\n" + objASPDropDownListENEx.GC_BindDdl4Mvc());

                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
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
                strCodeForCs.AppendFormat("\r\n" + "protected  virtual string Combine{0}Condition(QryModel4{0} obj{0}EN)", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN == null)",
             objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");

                strCodeForCs.Append("\r\n" + "}");

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
                    strCodeForCs.AppendFormat("\r\n" + "protected  virtual void PutDataTo{0}Class(cls{0}EN pobj{0}EN, EditModel4{0} model)",
                    objViewInfoENEx.TabName );
                    strCodeForCs.Append("\r\n" + "{");
                int intIndex = 0;
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                    intIndex++;
                    string strTemp = "";
                    if (intIndex == 1)
                    {
                        strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass_First(objEditRegionFldsEx, objViewInfoENEx);
                    }
                    else if (intIndex == objViewInfoENEx.arrEditRegionFldSet4InUse.Count)
                    {
                        strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass_Last(objEditRegionFldsEx, objViewInfoENEx);
                    }
                    else
                    {
                        strTemp = Get_4MvcCtrl_Code4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                    }
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
                    strCodeForCs.AppendFormat("\r\n" + "protected  virtual void GetDataFrom{0}Class(cls{0}EN pobj{0}EN, EditModel4{0} model)",
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
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3})",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        private string Get_4MvcCtrl_Code4FieldInPutDataToClass_First(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(model.{3})",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(model.{3})",
            objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string Get_4MvcCtrl_Code4FieldInPutDataToClass_Last(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FldOpTypeId() == "0002")
            {
                sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3});",
              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n" + ".Set{1}(model.{3});",
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_ControllerBase4CSharp);
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
            this.ClsName = string.Format("{0}BaseController", objViewInfoENEx.TabName);
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
        public string Gen_4MvcCtrl_GoTop()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
  
 
            try
            {

                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ö�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoTop\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult GoTop(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return View();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count>0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                                strInFor);
                    }
                }
              
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"��ѡ����Ҫ�ö��ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "return View();");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{1});",
                      objViewInfoENEx.TabName,
                      objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{2}, {1});",
                         objViewInfoENEx.TabName,
                         objAdjustOrderNum.VarLst,
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ö���������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                                
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");


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

        public string Gen_4MvcCtrl_GoTopAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
         
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ö�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoTopAjax\")]");
                if (objAdjustOrderNum.VarDefLst.Count() == 0)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult GoTopAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult GoTopAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count>0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                              strInFor);
                    }
                }
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"��ѡ����Ҫ�ö��ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{1});",
                      objViewInfoENEx.TabName,
                      objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoTop(lst{2}, {1});",
                         objViewInfoENEx.TabName,
                         objAdjustOrderNum.VarLst,
                         objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ö���������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

    //            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
    //objViewInfoENEx.TabName_Out);
    //            strCodeForCs.Append("\r\n" + "{");
    //            strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
    //                objKeyField.FldName, objKeyField.PrivFuncName);
    //            strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_UpMove()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
    
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UpMove\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult UpMove(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "return MoveRecord(\"UP\", {0}, page);",
                                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_UpMoveAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
      
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"UpMoveAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult UpMoveAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult UpMoveAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"UP\", {0}, page);",
                                        objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"UP\", {0}, {1}, page);",
                             objKeyField.PrivFuncName, objAdjustOrderNum.VarLst);
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


        public string Gen_4MvcCtrl_MoveRecord()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ƶ���¼,�������ƺ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + " public ActionResult MoveRecord(string strDirect, {0} {1}, int page)",
                    objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return  View();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                    strInFor);
                    }
                }
                    //strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                    //                    objKeyField.PrivFuncName,
                    //                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
               
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ�({0})�ļ�¼!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "return View();");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ�({0})�ļ�¼!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "return View();");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                  objViewInfoENEx.TabName,
                  objKeyField.PrivFuncName);
                }
                else
                {
                    string strClassificationFieldLst = "";
                    objAdjustOrderNum.ClassificationFieldValueLst.ForEach(
                        x => strClassificationFieldLst += string.Format("vs{0},", x));                    
                    strClassificationFieldLst = strClassificationFieldLst.TrimEnd(",".ToCharArray());
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, str{1});",
                     objViewInfoENEx.TabName,
                     strClassificationFieldLst,
                     objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ƶ�({0})��¼��������:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (objInFor.{0} == {1}) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_4MvcCtrl_MoveRecordAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ƶ���¼,�������ƺ�����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " public PartialViewResult MoveRecordAjax(string strDirect, {0} {1}, int page)",
                        objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " public PartialViewResult MoveRecordAjax(string strDirect, {0} {1}, {2}, int page)",
                        objKeyField.CsType, objKeyField.PrivFuncName, string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                            strInFor);
                    }
                }
                //strCodeForCs.AppendFormat("\r\n" + "{1} {0} = GetFirstCheckedKeyFromGv();",
                //                    objKeyField.PrivFuncName,
                //                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ�({0})�ļ�¼!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ�({0})�ļ�¼!\", strDirect);");
                    strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                    strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");
                    strCodeForCs.Append("\r\n" + "}");
                }
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {1});",
                  objViewInfoENEx.TabName,
                  objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(strDirect, {2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�ƶ�({0})��¼��������:{1}.({2})\", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                            
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareListModel(seQryModel4{1}, sortOrder, page);",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (objInFor.{0} == {1}) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "return PartialView(\"{0}LstAjax\", NewModel);", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_DownMove()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
     
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DownMove\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult DownMove(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "return MoveRecord(\"DOWN\", {0}, page);",
                    objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_DownMoveAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
 
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"DownMoveAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult DownMoveAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult DownMoveAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"DOWN\", {0}, page);",
                    objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "return MoveRecordAjax(\"DOWN\", {0}, {1}, page);",
                    objKeyField.PrivFuncName, objAdjustOrderNum.VarLst);
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


        public string Gen_4MvcCtrl_PreCheck4Order()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
      
            clsFieldTabEN objFieldTabEN_Classification = null;
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�õ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private bool PreCheck4Order()");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        if (clsDataTypeAbbrBLEx.IsNumberType(clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN_Classification.DataTypeId)) == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} <= 0)",
                                    strInFor);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                                strInFor);
                        }
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"����������ֶ�{0}!\";", strInFor);
                        strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
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
        /// ������������ֶ�������
        /// </summary>
        /// <returns></returns>
        public string Gen_4MvcCtrl_ClassificationFieldValue()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
   
            clsDataTypeAbbrEN objDataTypeAbbrEN = null;
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                if (objAdjustOrderNum.ClassificationFieldValueLst.Count == 0)
                {           
                    return strCodeForCs.ToString();
                }
                foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///�õ�");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public virtual {0} {1}", objDataTypeAbbrEN.CsType, strInFor);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "get;set;");
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

        public string Gen_4MvcCtrl_GoBottumAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
         
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�õ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoBottumAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult GoBottumAjax(string[] checkedId, int page = 1)");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult GoBottumAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                            strInFor);
                    }
                }
                
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"��ѡ����Ҫ�õ׵ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�õ׳�������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                //    objViewInfoENEx.TabName_Out);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                //    objKeyField.FldName, objKeyField.PrivFuncName);
                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_GoBottum()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
     
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�õ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"GoBottum\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult GoBottum(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ�ƶ��ļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return View();");
                if (objAdjustOrderNum.ClassificationFieldValueLst.Count > 0)
                {
                    foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                            strInFor);
                    }
                }
                if (objKeyField.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(checkedId);",
                                        objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                    strCodeForCs.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x => {0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"��ѡ����Ҫ�õ׵ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "return View();");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{1});",
                        objViewInfoENEx.TabName,
                        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.GoBottom(lst{2}, {1});",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�õ׳�������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");

                strCodeForCs.Append("\r\n" + "string sortOrder = seSortOrder;");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} model = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                strCodeForCs.AppendFormat("\r\n" + "model.qryModel4{0} = seQryModel4{0};",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModel = PrepareModel(model, {1}, sortOrder, page);",
                    objMainPrjTab.TabName, IsNumberType4Key ? "0" : "\"\"");

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in NewModel.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");                
                strCodeForCs.AppendFormat("\r\n" + "if (checkedId.Contains(objInFor.{0}.ToString()) == true) objInFor._Checked = \"checked\";",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "}");

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
        public string Gen_4MvcCtrl_ReOrder()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"ReOrder\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult ReOrder(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return View();");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName);
                }
                else
                {
                    
                        foreach (string strInFor in objAdjustOrderNum.ClassificationFieldValueLst)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                                strInFor);
                        }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�����������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_4MvcCtrl_ReOrderAjax()
        {
            if (this.objOrderNumField == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
           
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"ReOrderAjax\")]");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.Append("\r\n" + "public virtual PartialViewResult ReOrderAjax(string[] checkedId, int page = 1)" );
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult ReOrderAjax(string[] checkedId, {0}, int page = 1)",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (PreCheck4Order() == false) return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (string.IsNullOrEmpty(objAdjustOrderNum.VarLst) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder();",
                   objViewInfoENEx.TabName);
                }
                else
                {

                    //strCodeForCs.AppendFormat("\r\n" + "string str{0} = {0}.ToString();",
                    //    objAdjustOrderNum.ClassificationFieldValue);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReOrder({1});",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�����������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);"); ;
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_AddErrors()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n ///��Ӵ�����Ϣ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public void AddErrors(string error)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "ModelState.AddModelError(\"\", error);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Command4List()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n ///�б����������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public virtual ActionResult Command4List(string button, string[] checkedId)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//switch(button)");
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.Append("\r\n" + "//    case \"Create\":");
            strCodeForCs.Append("\r\n" + "//    Create();");
            strCodeForCs.Append("\r\n" + "//    break;");
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.Append("\r\n" + "return RedirectToList();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_Command4Query()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n ///�б����������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public virtual ActionResult Command4Query(string button, string[] checkedId)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//switch(button)");
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.Append("\r\n" + "//    case \"Query\":");
            strCodeForCs.Append("\r\n" + "//    QueryAjax();");
            strCodeForCs.Append("\r\n" + "//    break;");
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.Append("\r\n" + "return RedirectToList();");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_Clone()
        {
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
              
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ö�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"Clone\")]");
                strCodeForCs.Append("\r\n" + "public ActionResult Clone(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ���Ƶļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "PrepareDdlViewData();");
                strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} modelErr = new ViewModel4{0}();",
                    objMainPrjTab.TabName);
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, 0);",
                 objMainPrjTab.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "ViewModel4{0} NewModelErr = PrepareModel(modelErr, \"\");",
                    objMainPrjTab.TabName);
                }

                strCodeForCs.AppendFormat("\r\n" + "return View(\"{0}CRUD\", NewModelErr);",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"��ѡ����Ҫ�ö��ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "foreach (string strKey in checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                        objViewInfoENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                if (objNameField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"C_\" + obj{0}EN.{1};",
                                        objViewInfoENEx.TabName, objNameField.FldName);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,���������ʱ,�Զ���ȡ����ֵ��");
       
                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ��ͷ���������,���������ʱ,�Զ���ȡ����ֵ��");

                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"���Ƽ�¼��������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_4MvcCtrl_CloneAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //���ɽ��б���;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///�ö�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"CloneAjax\")]");
                strCodeForCs.Append("\r\n" + "public virtual PartialViewResult CloneAjax(string[] checkedId, int page = 1)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "sePageIndex = page;");
                strCodeForCs.Append("\r\n" + "if (checkedId == null || checkedId.Length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ѡ����Ҫ���Ƶļ�¼!\");");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + "List<string> lst{0} = new List<string>(checkedId);",
                                    objKeyField.ObjFieldTabENEx.FldName_FstUcase,
                                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);

                strCodeForCs.AppendFormat("\r\n" + "if (lst{0}  == null)",
                    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = \"��ѡ����Ҫ�ö��ļ�¼!\";");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "foreach (string strKey in checkedId)");
                strCodeForCs.Append("\r\n" + "{");
                if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(checkedId[0]);",
                  objKeyField.CsType, objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = checkedId[0];",
       objKeyField.CsType, objKeyField.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                        objViewInfoENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                if (objNameField != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"C_\" + obj{0}EN.{1};",
                                            objViewInfoENEx.TabName, objNameField.FldName);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ�����������,���������ʱ,�Զ���ȡ����ֵ��");

                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "//��Ϊ���ַ��ͷ���������,���������ʱ,�Զ���ȡ����ֵ��");

                    strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                        objMainPrjTab.TabName, objKeyField.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();",
                    objMainPrjTab.TabName);

                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"���Ƽ�¼��������:{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "AddErrors(strMsg);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "            return RedirectToListAjax();");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_ExportErr()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// ������ʾ��������", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "private string ExportErr(string strErrMsg)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strDownLoadStr = string.Format(\" <span>���ش���:{0}</span></a>\", strErrMsg);");
            strCodeForCs.Append("\r\n" + "return strDownLoadStr;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_ExportExcel()
        {

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
                
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public virtual string ExportExcel(QryModel4{0} model)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(model);",
                        objViewInfoENEx.TabName_Out);
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
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsPubFun_Mvc.InitExcelFile(strFolderName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return ExportErr(string.Format(objException.Message));");
                strCodeForCs.Append("\r\n" + "}");
                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���ݳ���,����ϵ����Ա!����:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

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
                
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "string strFilePath = string.Format(\"~/{0}/{1}\", \"TempFiles\", strFileName);");
                strCodeForCs.AppendFormat("\r\n" + "string strDownLoadStr = string.Format(\"<a href=\\\"/{0}/{{0}}?FileName={{1}}\\\">����</a>\", \"DownLoadFile\", strFilePath); ",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "return strDownLoadStr;");
                strCodeForCs.Append("\r\n" + "}");
               
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4MvcCtrl_ExportExcelAjax()
        {

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
                
                    strCodeForCs.AppendFormat("\r\n /// ����Excel�����ݲ�ѯ����ϵĲ�ѯ����,��[{0}]���л�ȡ��¼��,���յ�����Excel", objViewInfoENEx.TabName);
                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[HttpPost]");
                strCodeForCs.Append("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"ExportExcelAjax\")]");
                strCodeForCs.AppendFormat("\r\n" + "public virtual FileResult ExportExcelAjax(ViewModel4{0} model)",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = Combine{0}Condition(model.qryModel4{0});",
                        objViewInfoENEx.TabName_Out);
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
                    objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "strFolderName = clsSysParaEN.TempFileFolder;");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = strFolderName + strFileName;");
                strCodeForCs.Append("\r\n" + "//��ʼ����Ҫ������Excel�ļ�,�����Ʊ�׼Excel�ļ���Ϊĸ��,���Ʋ��ɹ������ܵ���");
             
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "clsPubFun_Mvc.InitExcelFile(strFolderName, strDownLoadFileName);"); 
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ʼ��Excel�����ļ�ʱ����!������Ϣ:{0}.\", objException.Message);");
                strCodeForCs.Append("\r\n" + "TempData[\"message\"] = strMsg;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                //strCodeForCs.Append("\r\n" + "return ExportErr(string.Format(objException.Message));");
                strCodeForCs.Append("\r\n" + "}");
                //				strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTable(objDT, strColName, strCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                
                    strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                    objViewInfoENEx.TabName_Out);
                
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���ݳ���,����ϵ����Ա!����:{0}.({1})\",");
                strCodeForCs.Append("\r\n" + "objException.Message, clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

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
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "const path = Server.MapPath(\"~/TempFiles/\" + strFileName);");
                strCodeForCs.Append("\r\n" + "return File(path, \"application/ms-excel\", strFileName);");

                //strCodeForCs.Append("\r\n" + "string strFilePath = string.Format(\"~/{0}/{1}\", \"TempFiles\", strFileName);");

                //strCodeForCs.AppendFormat("\r\n" + "string strDownLoadStr = string.Format(\"<a href=\\\"/{0}/{{0}}?FileName={{1}}\\\">����</a>\", \"DownLoadFile\", strFilePath); ",
                //    objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "return strDownLoadStr;");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4MvcCtrl_SetFieldValueAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());

                    string strFuncName = string.Format("{0}Ajax", objInFor.ButtonName.Substring(3));
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n ///�����ֶ�ֵ");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n" + "[HttpPost]");
                    strCodeForCs.AppendFormat("\r\n" + "[MultipleButton(Name = \"action\", Argument = \"{0}\")]", strFuncName);
                 
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

            
                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("���ܣ������ֶ�ֵ�ĸ�ֵ��ʽ�Ǹ���ֵ,��ȱ����Ӧ�Ľ��湦���ֶ�,��ά���������ɴ���");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        
                            strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult {0}(string[] checkedId, {1} {2})",
                            strFuncName, objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}))",
                                        objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"������{0}({1})!\";",
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");

                        strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                        strCodeForCs.Append("\r\n" + "}");
      
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public virtual PartialViewResult {0}(string[] checkedId)",
                                strFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                    }

                    strCodeForCs.Append("\r\n" + "if (checkedId == null)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"û��ѡ���¼,���������ֶ�ֵ!\");");
                    strCodeForCs.Append("\r\n" + "            TempData[\"message\"] = string.Format(\"û��ѡ���¼,���������ֶ�ֵ!\");");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "List<string> arr{0} = new List<string>(checkedId);",
                        FldName4Key);
                    strCodeForCs.Append("\r\n" + "int intRecCount = 0;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (string {0} in arr{1})",                        
                        objKeyField.PrivFuncName,
                        FldName4Key);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "K_{0}_{1} objKey = {2};",
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
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}.Set{1}({2});",
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
                    strCodeForCs.Append("\r\n" + "      intRecCount += 1;");
                    strCodeForCs.Append("\r\n" + "              }");
                    strCodeForCs.Append("\r\n" + "                if (intRecCount > 0)");
                    strCodeForCs.Append("\r\n" + "                {");
                    strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"��[{0}]����¼ �Ѿ��������ֶ�ֵ!\", intRecCount);");
                    strCodeForCs.Append("\r\n" + "                }");
                    strCodeForCs.Append("\r\n" + "                else");
                    strCodeForCs.Append("\r\n" + "                {");
                    strCodeForCs.Append("\r\n" + "                    TempData[\"message\"] = string.Format(\"��[0]����¼�������ֶ�ֵ!\");");
                    strCodeForCs.Append("\r\n" + "                }");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, string.Format("{0}_Click", objInFor.ButtonName), string.Format("{0}���ɹ�!", objInFor.Text), "���ɴ���");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{0})�����ֶ�ֵ({1})���ɹ�!\" + objException.Message;", strErrId, objInFor.Text);
                    strCodeForCs.Append("\r\n" + "                TempData[\"message\"] = strMsg;");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "            return RedirectToListAjax(checkedId);");

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

    }
}
