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
using AGC.PureClass;
using AGC.PureClassEx;
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
    partial class WA_ViewUTScript_TS4Html : clsGeneCodeBase
    {

        public WA_ViewUTScript_TS4Html()
        {


            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_ViewUTScript_TS4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_CS_DefButton(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                string strCondition = string.Format("{0}='{1}'", convFunction4GeneCode.FuncId4GC, strFuncId4GC);
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.GetFirstObj_S(strCondition);

                //strFuncName = objFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //    strTemp = A_GeneFuncCode_Ts_btnClick(strFuncName);
                //}
                strTemp = A_GeneFuncCode_CS_DefButton(objvFunction4GeneCodeEN);
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

        public string A_GeneFuncCode_CS_DefButton(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            try
            {
                switch (objvFunction4GeneCodeEN.FuncName)
                {

                    case "Gen_WApi_CS_DefButtonGetFirstObj":
                        return Gen_WApi_CS_DefButtonGetFirstObj(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonGetObjByKey":
                        return Gen_WApi_CS_DefButtonGetObjByKey(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonDelRecord":
                        return Gen_WApi_CS_DefButtonDelRecord(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonDelRecords":
                        return Gen_WApi_CS_DefButtonDelRecords(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonAddNewRecord":
                        return Gen_WApi_CS_DefButtonAddNewRecord(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_WApi_CS_DefButtonAddNewRecord4GetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_WApi_CS_DefButtonGetMaxStrId":
                        return Gen_WApi_CS_DefButtonGetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_WApi_CS_DefButtonGetMaxStrIdByPrefix":
                        return Gen_WApi_CS_DefButtonGetMaxStrIdByPrefix(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonUpdateRecord":
                        return Gen_WApi_CS_DefButtonUpdateRecord(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonIsExistRecord":
                        return Gen_WApi_CS_DefButtonIsExistRecord(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonGetRecCountByCond":
                        return Gen_WApi_CS_DefButtonGetRecCountByCond(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonGetObjLst":
                        return Gen_WApi_CS_DefButtonGetObjLst(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonGetTopObjLst":
                        return Gen_WApi_CS_DefButtonGetTopObjLst(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonGetObjLstByPager":
                        return Gen_WApi_CS_DefButtonGetObjLstByPager(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefButtonGetObjLstByRange":
                        return Gen_WApi_CS_DefButtonGetObjLstByRange(objvFunction4GeneCodeEN);

                    case "Gen_WApi_CS_DefLabelMsg":
                        return Gen_WApi_CS_DefLabelMsg(objvFunction4GeneCodeEN);
                                               
                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����({0})",
                             clsStackTrace.GetCurrClassFunction(), objvFunction4GeneCodeEN.FuncName);
                        throw new Exception(strMsg);
                        //            return "///��1����������:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }


        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenWApi_CS_UTScript(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
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
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format( "WApi{0}_UT", objPrjTabENEx.TabName);
            //objPrjTabENEx.ClsName = objPrjTabENEx.ClsName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".aspx";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".aspx.cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                            .OrderBy(x => x.OrderNum); 

            try
            {
                //���ɲ����¼�Ľ������;
                //      strCodeForCs.Append("///���ɲ�ѯ���޸ġ�ɾ������Ӽ�¼�Ľ������(���ÿؼ�)");
                strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.aspx.cs\" Inherits = \"{1}.WApiForm.{0}\" %>",
                  objPrjTabENEx.ClsName, objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                strCodeForCs.Append("\r\n" + "<html xmlns = \"http://www.w3.org/1999/xhtml\">");
                strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
                strCodeForCs.Append("\r\n" + "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = utf-8\" />");
                strCodeForCs.AppendFormat("\r\n" + "<title>{0}��WApi��Ԫ����</title>", objPrjTabENEx.TabCnName);
                //strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/taishweb2.css\"/>",
                //  objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                    objProjectsENEx.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "<script type = \"text/javascript\" src = \"../../JS/tzPubFun.js\"></script>");
                strCodeForCs.AppendFormat("\r\n" + "<script src = \"../TypeScript/tzPubFun.js\" ></script>");
                 strCodeForCs.Append("\r\n" + "     <script>    ");
                strCodeForCs.Append("\r\n" + "         function ExpandDiv(divName) {");
                strCodeForCs.Append("\r\n" + "            OnlyShowDiv(divName, \"function\", \"content\");");
                strCodeForCs.Append("\r\n" + "        }");

                strCodeForCs.Append("\r\n" + "window.onload = function() {");
                strCodeForCs.Append("\r\n" + "const hidDivName = document.getElementById(\"hidDivName\");");
                strCodeForCs.Append("\r\n" + "const divName = hidDivName.value;");
                strCodeForCs.Append("\r\n" + "ExpandDiv(divName);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "    </script>");

                strCodeForCs.Append("\r\n" + "</head>");


                strCodeForCs.Append("\r\n" + "<body>");
                strCodeForCs.Append("\r\n" + "<form id = \"form1\" runat = \"server\">");

                ASPHiddenFieldEx objASPNETHiddenFieldENEx = new ASPHiddenFieldEx();
                objASPNETHiddenFieldENEx.CtrlId = "hidDivName";
                objASPNETHiddenFieldENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                   //�����������ĵı�ǩ����
                clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                //��������1�ű���ı�ǩ����
                clsLabelStyleEN objLabelStyle_T1 = clsLabelStyleBL.GetObjByLabelStyleIdCache("0003");
                clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
                clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
                clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
                //0003:QUDIģʽ


                strCodeForCs.Append("\r\n" + "<div id = \"tabLayout\" class = \"tab_layout\" ");
                strCodeForCs.Append("\r\n" + "runat = \"server\">");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";

                    strTemp = A_GeneFuncCode_CS_DefButton(objvFunction4GeneCodeEN);
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
              

                strCodeForCs.Append("\r\n" + "</div>");

                strCodeForCs.Append("\r\n" + "</form>");
                strCodeForCs.Append("\r\n" + "</body>");
                strCodeForCs.Append("\r\n" + "</html>");

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
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_CS_DefButtonAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "AddNewRecord";

            string strFunctionName_CN = string.Format("{0}������¼�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "AddNewRecord4GetMaxStrId";

            string strFunctionName_CN = string.Format("{0}������¼�¼(��ȡ���ؼ���)", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetMaxStrId";

            string strFunctionName_CN = string.Format("{0}����ȡ���ؼ���ֵ", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetMaxStrIdByPrefix";

            string strFunctionName_CN = string.Format("{0}����ȡ���ؼ���ֵ,����ǰ׺", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "UpdateRecord";

            string strFunctionName_CN = string.Format("{0}���޸ļ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);
            
         

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_CS_DefButtonDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //Gen_WApi_CS_DefButtonDelRecordsByJSON
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelRecords";

            string strFunctionName_CN = string.Format("{0}��ɾ��������¼ͨ���ؼ��ִ�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}��ɾ����¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);
            //ASPLabelEx objASPNETLabelENEx = GetOrderNumLabel(intOrderNum);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_CS_DefButtonIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}������Ƿ���ڼ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetRecCountByCond";

            string strFunctionName_CN = string.Format("{0}������������ȡ��¼��", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_CS_DefButtonGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}����ȡ��¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetTopObjLst";

            string strFunctionName_CN = string.Format("{0}����ȡ������¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetObjLstByPagerCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�,ʹ�û���", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetSubObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�,ʹ�û���", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_CS_DefButtonGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByRange";

            string strFunctionName_CN = string.Format("{0}����ȡ��Χ�ڼ�¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_CS_DefButtonGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ��ֻ�ȡ����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_CS_DefButtonGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetFirstObj";

            string strFunctionName_CN = string.Format("{0}����ȡ���������ĵ�һ����¼����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public ASPLabelEx GetOrderNumLabel(int intOrderNum)
        {


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblOrderNum{0}", intOrderNum);
            objASPNETLabelENEx.Text = string.Format("��{0}��������", intOrderNum);
            objASPNETLabelENEx.Width = 80;
            objASPNETLabelENEx.Height = 24;

            return objASPNETLabelENEx;
        }
        public ASPDivEx GetParaInputCtrlGroup(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("divParaGroup{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            GC_GetInputValueCtrl4Para(objFunction4GeneCodeEN.FuncId4Code, objvFunction4GeneCodeEN.OrderNum, objASPNETDivENEx);


            return objASPNETDivENEx;


        }

        public string Gen_WApi_CS_DefLabelMsg(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblMsg");
            objASPNETLabelENEx.Text = "��ʾ���";
            objASPNETLabelENEx.Width = 200;
            objASPNETLabelENEx.Height = 24;
            objASPNETLabelENEx.mTextSize = "12sp";
            objASPNETLabelENEx.minHeight = "35dp";

            //objASPNETLabelENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETLabelENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objASPNETLabelENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
      
        public string Gen_WApi_CS_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objASPNETButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objASPNETButtonENEx.Width = 200;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";

            //ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);

            //�����ʾ����Ŀؼ�
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //���ˮƽ��
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string GetLinearLayout4FunctionByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objASPNETButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objASPNETButtonENEx.Width = 200;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";

            //ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);

            //�����ʾ����Ŀؼ�
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //���ˮƽ��
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);



            return strCodeForCs.ToString();
        }
        private void GC_GetInputValueCtrl4Para(string strFuncId4Code, int intOrderNum, ASPDivEx objASPNETDivENEx)
        {
            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst == null) return;
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
                ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
                objASPNETDivENEx_Para.CtrlId = string.Format("divPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                //objASPNETLabelENEx.Is4PureHtml = true;
                objASPNETLabelENEx.CtrlId = string.Format("lblPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETLabelENEx.Text = objFuncPara4CodeEN.ParaName;
                objASPNETLabelENEx.Width = 200;
                objASPNETLabelENEx.Height = 24;

                objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                if (objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    //objASPNETTextBoxENEx.Is4PureHtml = true;
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("Where") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1=1", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("1=1", intOrderNum);

                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("OrderBy") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("{0} Asc", objKeyField.FldName);
                        objASPNETTextBoxENEx.Value = string.Format("{0} Asc", objKeyField.FldName);

                    }

                    objASPNETTextBoxENEx.Width = 400;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
                }
                else
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    //objASPNETTextBoxENEx.Is4PureHtml = true;
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("pageSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("5", intOrderNum);

                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("pageIndex") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("1", intOrderNum);

                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("topSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("3", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("3", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Min") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("2", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("2", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Max") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                        objASPNETTextBoxENEx.Value = string.Format("5", intOrderNum);

                    }

                    objASPNETTextBoxENEx.Width = 400;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

                }
            }

        }

        public ASPDivEx GetFunctionGroupDiv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;


            //string strFunctionName_CN = string.Format("{0}������Ƿ���ڼ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", strFunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left; margin-bottom:5px;");
            objASPNETDivENEx.Class = "function";
            
            //���ˮƽ��
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            ASPDivEx objASPNETDivENEx_Title = GetDiv4FuncTitle(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Title);

            return objASPNETDivENEx;
        }

        private ASPDivEx GetFunctionResultDiv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;

            string strFunctionName_CN = string.Format("{0}��{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
            objASPNETDivENEx_Para.CtrlId = string.Format("divResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            objASPNETButtonENEx.Text = strFunctionName_CN;
            objASPNETButtonENEx.Width = 300;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";
         

            ASPLabelEx objASPNETLabelENEx2 = new ASPLabelEx();
            objASPNETLabelENEx2.CtrlId = string.Format("lblResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETLabelENEx2.Text = "���";
            objASPNETLabelENEx2.CssClass = "Content";
            objASPNETLabelENEx2.Width = 600;
            objASPNETLabelENEx2.Height = 24;

            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx2);
            return objASPNETDivENEx_Para;
            
        }
        /// <summary>
        /// ���������ı���Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncTitle(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}��{1}", 
                objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            //< div class="title" style="width:100%">
            //      <div style = "float:left; width:80%; " >
            //                 < asp:Label ID = "lblIsExistRecord4Title" Width="600px" Height="24px" Text="���" runat="server" />

            //      </div>
            //      <div style = "float:right; width:20%; " >
            //          < input id="btnIsExistRecord4Expand" type="button" value="չ��" onclick="ExpandDiv('divGen_WApi_CS_DefButtonIsExistRecord')" />
            //      </div>
            //  </div>
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "title";
            objASPNETDivENEx.Style = "width:100%; height:25px;";

            {
                ASPDivEx objASPNETDivENEx_Left = new ASPDivEx();

                objASPNETDivENEx_Left.Style = "float:left; width:80%;";

                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                objASPNETLabelENEx.CtrlId = string.Format("lblTitle{0}", objvFunction4GeneCodeEN.OrderNum);
                objASPNETLabelENEx.Text = string.Format("���ԣ�{0}", strFunctionName_CN);
                objASPNETLabelENEx.CssClass = "h6";
                objASPNETLabelENEx.Width = 600;
                objASPNETLabelENEx.Height = 20;

                objASPNETDivENEx_Left.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Left);

            }
            {
                ASPDivEx objASPNETDivENEx_Right = new ASPDivEx();

                objASPNETDivENEx_Right.Style = "float:right; width:20%;";

                ASPHtmlButtonEx objASPNETHtmlButtonENEx = new ASPHtmlButtonEx();
                objASPNETHtmlButtonENEx.CtrlId = string.Format("btnExpand{0}", strFunctionName);
                objASPNETHtmlButtonENEx.Value = string.Format("չ��");
                objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}');", strFunctionName);
                objASPNETHtmlButtonENEx.Width = 300;
                objASPNETHtmlButtonENEx.Height = 24;

                objASPNETDivENEx_Right.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Right);
            }
            
            return objASPNETDivENEx;
        }

        /// <summary>
        /// ��������������Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        private ASPDivEx GetDiv4FuncContent(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = objFunction4CodeEN.FuncName4Code;

            string strFunctionName_CN = string.Format("{0}��{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "content";
            objASPNETDivENEx.Style = "width: 100%";

            {
                ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
            }
            //{
            //    ASPDivEx objASPNETDivENEx_Button = new ASPDivEx();
            //    objASPNETDivENEx_Button.Class = "button";
            //    objASPNETDivENEx_Button.Style = "width: 100%";

            //    ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            //    objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            //    objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            //    objASPNETButtonENEx.Text = strFunctionName_CN;
            //    objASPNETButtonENEx.Width = 200;
            //    objASPNETButtonENEx.Height = 24;
            //    objASPNETButtonENEx.mTextSize = "12sp";
            //    objASPNETButtonENEx.minHeight = "35dp";
            //    objASPNETDivENEx_Button.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            //    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Button);
            //}
            //�����ʾ����Ŀؼ�
            ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            return objASPNETDivENEx;

            //objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScript_TS4Html);
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
            this.ClsName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);
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
