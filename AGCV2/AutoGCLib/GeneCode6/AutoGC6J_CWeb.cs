using System;
using System.Collections;
using System.Text;
using System.IO;
using com.taishsoft.file;

using com.taishsoft.common;
using AGC_CSV7.Entity;
using com.taishsoft.commdb;


namespace AGC_CSV7.BusinessLogic.GeneCode2
{
    /// <summary>
    /// �Զ����ɽ�����Ʋ�Ĵ�����(Control of MVC)
    /// </summary>
    public class AutoGC6J_CWeb : clsViewGroupBLEx
    {
        protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        public AutoGC6J_CWeb()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

        //public AutoGC6J_CWeb(string strViewId)
        //    : base(strViewId)
        //{
        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //

        //}

        protected string mstrBackupFolderName; // '�ļ�Ŀ¼��
        /// <summary>
        /// ���ݵ��ļ�Ŀ¼
        /// </summary>
        public string BackupFolderName
        {
            get { return mstrBackupFolderName; }
            set { mstrBackupFolderName = value; }
        }
        protected string mstrFolderName_Root; // '���ļ�Ŀ¼��

        public string FolderName_Root
        {
            get { return mstrFolderName_Root; }
            set { mstrFolderName_Root = value; }
        }
        /// <summary>
        /// ����ͨ���߼������
        /// </summary>
        /// <returns></returns>
        public string A_GenActionCode(Encoding myEncoding, ref  string strResult, clsViewInfoENEx objViewInfoENEx)
        {
            //			if (objPrjTabENEx.TabFldNum == 0)
            //			{
            //				strResult = "��ǰ��" + objINPrjTab.TabName + "���ֶ���Ϊ0���޷�����ͨ���߼���!";
            //				return strResult;
            //			}
            //			if (objPrjTabENEx.KeyFldNum == 0)
            //			{
            //				strResult = "��ǰ��" + objINPrjTab.TabName + "�Ĺؼ��ֵĸ���Ϊ0���޷�����ͨ���߼���!";
            //				return strResult;
            //			}

            ///���û���������;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder();    ///���������WebForm��ص����ļ�����;
            string strTemp;          ///��ʱ����;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("GenListRecCode");	//����˽�б�����Ҳ��˽������
            arrFuncList.Add("GenCombineCondionCode");	//��Ĺ�����1
            arrFuncList.Add("GenAddRecCode");	//��Ĺ�����1
            arrFuncList.Add("GenAddSaveRecCode");	//��Ĺ�����2
            arrFuncList.Add("GenUpdateRecCode");	//��Ĺ�����3
            arrFuncList.Add("GenShowDataForUpdate");	//��Ĺ�����3
            arrFuncList.Add("GenShowDataForDetail");	//��Ĺ�����3

            arrFuncList.Add("GenUpdateSaveRecCode");    //
            arrFuncList.Add("GenDeleteRecCode");    //
            arrFuncList.Add("GenDetailRecCode");    //
            arrFuncList.Add("GenQueryRecCode");    //
            arrFuncList.Add("GenGetSelecedList");    //

            arrFuncList.Add("");    //

            string ClsName = objViewInfoENEx.TableNameForProg_FstUcase + "Action";
            strClassFName = mstrFolderName + ClsName + ".java";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsByPrjId(objViewInfoENEx.PrjId);    //
     
            try
            {
                ///������ʼ
                ///
           
                ///������ʼ
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName));

                ///����
                strCodeForCs.AppendFormat("\r\n" + "package {0};",
                    objViewInfoENEx.PrjDomain);
                ///������ʼ
                //				strCodeForCs.Append("\r\n" +  "//import java.sql.*;");    //
                strCodeForCs.Append("\r\n" + "import java.sql.SQLException;");
                strCodeForCs.Append("\r\n" + "import com.mdf.quote.commdbtab.*;");

                strCodeForCs.Append("\r\n" + "import java.util.*; ");    //
                //				strCodeForCs.Append("\r\n" +  "import SpecData.clsSpecSQLforSql; ");    //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.*;");    //
                strCodeForCs.Append("\r\n" + "import javax.servlet.http.*;");
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.QueryModel;");
                strCodeForCs.Append("\r\n" + "import org.apache.struts.action.*;");
                strCodeForCs.Append("\r\n" + "import org.apache.struts.actions.DispatchAction;");
                //                strCodeForCs.Append("\r\n" + "import org.apache.struts.actions.LookupDispatchAction;");
                //

                strCodeForCs.Append("\r\n" + "");    //


                strCodeForCs.Append("\r\n" + "public class " + ClsName + " extends DispatchAction");
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                //strCodeForCs.Append("\r\n" + "protected Map<String,String> getKeyMethodMap() {");
                //strCodeForCs.Append("\r\n" + "Map<String,String> map = new HashMap<String,String>();");
                //strCodeForCs.Append("\r\n" + "map.put(\"button.add\", \"funAdd\");");
                //strCodeForCs.Append("\r\n" + "map.put(\"button.delete\", \"funDelete\");");
                //strCodeForCs.Append("\r\n" + "map.put(\"button.update\", \"funUpdate\");");
                //strCodeForCs.Append("\r\n" + "return map;");
                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "private {0}Manager {1}Manager;",
                    objViewInfoENEx.TableNameForProg_FstUcase,
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCodeForCs.AppendFormat("\r\n" + "public {0}Action() ",
                    objViewInfoENEx.TableNameForProg_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}Manager = new {0}Manager();",
                    objViewInfoENEx.TableNameForProg_FstUcase,
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

                foreach (string strFuncName in arrFuncList)
                {
                    strTemp = A_GeneFuncCode(strFuncName, objViewInfoENEx);
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                //strCodeForCs.Append("\r\n/**");
                //strCodeForCs.Append("\r\n* getMethodPermsMap");
                //strCodeForCs.Append("\r\n*");
                //strCodeForCs.Append("\r\n * @return ActionMethodPermsMap");
                //strCodeForCs.Append("\r\n*/");
                //strCodeForCs.Append("\r\nprotected ActionMethodPermsMap getMethodPermsMap() {");
                //strCodeForCs.Append("\r\nreturn null;");
                //strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n" + "}");

                //������д���ļ���;
                //�����ļ������ļ����������ж��Ƿ����;
                strFolder = objComm.ParentDir(strClassFName);
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN.IsBackupForGeneCode == true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                    {
                        string strMsg = string.Format("�ļ���{0}�Ѿ����ڣ�", strFindFileFullFile);
                        throw new Exception(strMsg);
                    }
                }
                //UTF8Encoding utf8 = new UTF8Encoding(false);
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString(), myEncoding); 
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ͨ���߼������
        /// </summary>
        /// <returns></returns>
        public string A_GenActionFormCode(Encoding myEncoding, ref  string strResult, clsViewInfoENEx objViewInfoENEx)
        {
            //			if (objPrjTabENEx.TabFldNum == 0)
            //			{
            //				strResult = "��ǰ��" + objINPrjTab.TabName + "���ֶ���Ϊ0���޷�����ͨ���߼���!";
            //				return strResult;
            //			}
            //			if (objPrjTabENEx.KeyFldNum == 0)
            //			{
            //				strResult = "��ǰ��" + objINPrjTab.TabName + "�Ĺؼ��ֵĸ���Ϊ0���޷�����ͨ���߼���!";
            //				return strResult;
            //			}

            ///���û���������;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder();    ///���������WebForm��ص����ļ�����;

            string ClsName = objViewInfoENEx.TableNameForProg_FstUcase + "Form";
            strClassFName = mstrFolderName + ClsName + ".java";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsByPrjId(objViewInfoENEx.PrjId);    //

      
            try
            {
                ///������ʼ
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName));

                ///����
                strCodeForCs.AppendFormat("\r\n" + "package {0};",
                    objViewInfoENEx.PrjDomain);
                ///������ʼ
                //				strCodeForCs.Append("\r\n" +  "//import java.sql.*;");    //
                strCodeForCs.Append("\r\n" + "import java.util.*; ");    //
                strCodeForCs.Append("\r\n" + "import java.util.List;");
                strCodeForCs.Append("\r\n" + "import org.apache.struts.action.ActionForm;");
                //

                strCodeForCs.Append("\r\n" + "");    //
                strCodeForCs.Append("\r\n" + "public class " + ClsName + " extends ActionForm");
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n" + "private static final long serialVersionUID = 1L;");
                strCodeForCs.Append("\r\n" + "private List selectList;");

                strCodeForCs.Append("\r\n" + "public List getSelectList() {");
                strCodeForCs.Append("\r\n" + "return selectList;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "public void setSelectList(List selectList) {");
                strCodeForCs.Append("\r\n" + "objViewInfoENEx.selectList = selectList;");
                strCodeForCs.Append("\r\n" + "}");
                //�������еĺ���

                strCodeForCs.Append(gfunClsPrivateVar(objViewInfoENEx));
                strCodeForCs.Append(gfunClsPrivateVar_Query(objViewInfoENEx));

                strCodeForCs.Append(gfunClsProperty(objViewInfoENEx));

                strCodeForCs.Append(gfunClsProperty_Query(objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "}");

                //������д���ļ���;
                //�����ļ������ļ����������ж��Ƿ����;
                strFolder = objComm.ParentDir(strClassFName);
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN.IsBackupForGeneCode == true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                    {
                        string strMsg = string.Format("�ļ���{0}�Ѿ����ڣ�", strFindFileFullFile);
                        throw new Exception(strMsg);

                    }
                }
                //UTF8Encoding utf8 = new UTF8Encoding(false);
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString(), myEncoding); 
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        ///��ʾ��ļ�¼�б�(list{0})
        public string GenListRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                strCode.Append("\r\n" + "//��ʾ��ļ�¼�б�");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_List);
                strCode.Append("\r\n" + "     HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//�������裺");
                strCode.Append("\r\n" + "//��һ�������form����");
                strCode.Append("\r\n" + "//�ڶ�������õ�¼�˵ļ�¼��Ϣ");
                strCode.Append("\r\n" + "//����������ȡ��ǰ��¼��ְ���ţ����洢�ڶ�̬FORM�С���̬FORM��һ���洢���ֱ�����һ��������");
                strCode.Append("\r\n" + "//���Ĳ������ݲ�ѯ�����ֶ�ֵ����̬����sql��䣻");
                strCode.Append("\r\n" + "//���岽������excel�����е�����");
                strCode.Append("\r\n" + "//�����������ݶ�̬���õ�SQL��䣬��ȡ��ѯ����ļ�¼������XML��ʽ���ַ�����ʾ��");
                strCode.Append("\r\n" + "//���߲����Ѳ�ѯ����ļ�¼��������request��result�С�");
                strCode.Append("\r\n" + "//�ڰ˲�����ʾ��ѯ�б�ҳ��(JSPҳ��)");

                strCode.Append("\r\n" + "//��һ�������form����");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//�ڶ�������ȡ��ǰ��¼��ְ���ţ����洢�ڶ�̬FORM�С���̬FORM��һ���洢���ֱ�����һ��������");
                strCode.AppendFormat("\r\n" + "//String {0} = UserToken.getUser(request).getUserID();",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n" + "//�����ڶ�̬FORM��");
                strCode.AppendFormat("\r\n" + "//{0}Form.set(\"{1}\", {1});",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.AppendFormat("\r\n //����������õ�¼�˵ļ�¼��Ϣ");
                strCode.AppendFormat("\r\n //StringBuffer sbSql = new StringBuffer({1}.list{0}Carder(",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n // request, {0})); //�б�sql����õ�½���Լ���¼��Ϣ",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);

                strCode.Append("\r\n" + "//���Ĳ������ݲ�ѯ�����ֶ�ֵ����ϲ�ѯ��������");
                strCode.Append("\r\n" + "ArrayList paramList = new ArrayList();");
                strCode.AppendFormat("\r\n" + "String strOrderby = \" {0} ASC\";",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n" + "//��ϲ�ѯ������");
                strCode.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condion(form, request, paramList,",
                    objViewInfoENEx.TableNameForProg);
                strCode.Append("\r\n" + "strOrderby);");
                strCode.Append("\r\n        Object[] params = new Object[paramList.size()];");
                strCode.Append("\r\n paramList.toArray(params);");

                strCode.Append("\r\n //���岽�����ݶ�̬���õ�SQL��䣬��ȡ��ѯ����ļ�¼������XML��ʽ���ַ�����ʾ��");

                strCode.AppendFormat("\r\n List arr{0}ObjList = null;",
                         objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.Append("\r\n try");
                strCode.Append("\r\n {");
                strCode.AppendFormat("\r\n arr{2}ObjList = {1}Manager.get{2}DispList(strWhereCond);",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.Append("\r\n }");
                strCode.Append("\r\n catch (SQLException objException)");
                strCode.Append("\r\n {");
                //	request.setAttribute("error", objException.getMessage());

                strCode.Append("\r\n ArrayList<String> arrError = new ArrayList<String>();");
                strCode.Append("\r\n arrError.add(\"�ڴ����ݿ�������б�ʱ���ִ���!\");");
                strCode.Append("\r\n if (objException.getMessage() != null)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n arrError.add(objException.getMessage());");
                strCode.Append("\r\n }");
                strCode.Append("\r\n request.setAttribute(\"error\", arrError);");
                strCode.Append("\r\n return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.AppendFormat("\r\n" + "{0}.setSelectList(arr{1}ObjList);",
                   objViewInfoENEx.StutsActionFormObject_Sim,
                   objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.Append("\r\n //������������excel�����е�����");
                strCode.AppendFormat("\r\n //{0}.setExcelReport(strWhereCond, paramList, request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);

                strCode.Append("\r\n //���߲����Ѳ�ѯ����ļ�¼��������request��result�С�");
                strCode.AppendFormat("\r\n request.setAttribute(\"result\", arr{1}ObjList);",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.Append("\r\n //�ڰ˲�����ʾ��ѯ�б�ҳ��(JSPҳ��)");
                strCode.AppendFormat("\r\n return map.findForward(\"{0}\");",
                    objViewInfoENEx.StutsActionMethod_List);
                strCode.Append("\r\n }");
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///��ʾ��ļ�¼�б�(list{0})
        public string GenCombineCondionCode(clsViewInfoENEx objViewInfoENEx)
        {
            string strTemp;
            StringBuilder strCode = new StringBuilder();
            try
            {

                strCode.Append("\r\n" + "// �����еĲ�ѯ�ؼ�������ϳ�һ��������");

                strCode.AppendFormat("\r\n" + "private String Combine{0}Condion(ActionForm form,",
                    objViewInfoENEx.TableNameForProg);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "ArrayList<String> paramList,");
                strCode.Append("\r\n" + "String strOrderby) {");

                strCode.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1=1\"���Ա��ڸô��ĺ�����\"and \"�����������,");
                strCode.Append("\r\n" + "//���� 1=1 && UserName = '����'");

                strCode.Append("\r\n" + "//�������裺");
                strCode.Append("\r\n" + "//��һ�������form����");
                strCode.Append("\r\n" + "//�ڶ��������session����,����session������г�ʼ��");
                strCode.Append("\r\n" + "//���������Ӷ�̬FORM�л�ȡ���в�ѯ�ֶε�ֵ��");
                strCode.Append("\r\n" + "//     3.1 ����в�ѯ�ֶε�ֵ,�����õ���ѯģ�Ͷ����У�ͬʱ�洢��Session�У�");
                strCode.Append("\r\n" + "//     3.2 ����ʹ�session��ȥ��ȡ��ѯģ�Ͷ���");
                strCode.Append("\r\n" + "//        3.2.1 �����ѯģ�Ͷ���ΪNULL��˵�������洢����ѯģ�Ͷ����ֵ��");
                strCode.Append("\r\n" + "//                 �ʹ�Session�Ĳ�ѯģ�Ͷ����л�ȡ��ѯ�ֶε�ֵ��");
                strCode.Append("\r\n" + "//     ˵����ͨ����(idtemp_query != null�ļ��Ϳ���֪����");
                strCode.Append("\r\n" + "//          request���Ƿ��в�ѯ�ֶε�ֵ��");
                strCode.Append("\r\n" + "//���Ĳ������ݲ�ѯ�����ֶ�ֵ����̬����sql��䣻");

                strCode.Append("\r\n" + "//��һ�������form����");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
    objViewInfoENEx.TableNameForProg_FstLcase,
     objViewInfoENEx.TableNameForProg_FstUcase);

                strCode.Append("\r\n" + "//�ڶ��������session����,����session������г�ʼ��");
                strCode.Append("\r\n" + "//���session����");
                strCode.Append("\r\n" + "HttpSession session = request.getSession();");
                strCode.Append("\r\n" + "//��session���г�ʼ�������Ƴ� session�е����б���");
                //strCode.Append("\r\n" +  "if (\"true\".equals(request.getParameter(\"needinit\"))) {");
                //strCode.Append("\r\n" +  "session.removeAttribute(QueryModel.ATT_NAME);");
                //strCode.Append("\r\n" +  "}");

                strCode.AppendFormat("\r\n //���������Ӷ�̬FORM�л�ȡ���в�ѯ�ֶε�ֵ��");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    strTemp = objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType;
                    objComm.FstUcase(ref strTemp);
                    strCode.AppendFormat("\r\n {0} {1}_query = {2}Form.get{3}_query();",
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType,
                        objQryRegionFldsEx.FldName_Java,
                        objViewInfoENEx.TableNameForProg_FstLcase,
                   objComm.FirstUcase(objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java),
                        strTemp);
                }
                strTemp = objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType;
                objComm.FstUcase(ref strTemp);
                strCode.AppendFormat("\r\n {0} {1}temp_query = ({0}) request.getAttribute(\"{1}_query\");",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType,
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java,
                    objViewInfoENEx.TableNameForProg,
                    strTemp);
                strCode.Append("\r\n //����һ����ѯģ�����qm");
                strCode.Append("\r\n QueryModel qm;");
                strCode.Append("\r\n //     3.1 ����в�ѯ�ֶε�ֵ,�����õ���ѯģ�Ͷ����У�ͬʱ�洢��Session�У�");
                strCode.AppendFormat("\r\n if ({0}temp_query != null) ",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n {");
                strCode.AppendFormat("\r\n //     ˵����ͨ����({0}temp_query != null�ļ��Ϳ���֪����",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n //          request���Ƿ��в�ѯ�ֶε�ֵ��");
                strCode.Append("\r\n qm = new QueryModel(");
                strCode.AppendFormat("\r\n \"{1}.{0}Form\"); //ģ��������д�ɳ�����",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.PrjDomain);
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    strCode.AppendFormat("\r\n qm.setProperty(\"{0}_query\", {0}_query);",
                        objQryRegionFldsEx.FldName_Java);
                }
                strCode.Append("\r\n session.setAttribute(QueryModel.ATT_NAME, qm);");
                strCode.Append("\r\n }");
                strCode.Append("\r\n else {");
                strCode.Append("\r\n //     3.2 ����ʹ�session��ȥ��ȡ��ѯģ�Ͷ���");

                strCode.Append("\r\n qm = (QueryModel) session.getAttribute(QueryModel.ATT_NAME);");
                strCode.Append("\r\n if (qm != null) {");
                strCode.Append("\r\n //        3.2.1 �����ѯģ�Ͷ���ΪNULL��˵�������洢����ѯģ�Ͷ����ֵ��");
                strCode.Append("\r\n //                 �ʹ�Session�Ĳ�ѯģ�Ͷ����л�ȡ��ѯ�ֶε�ֵ��");
                strCode.AppendFormat("\r\n if (! (\"{1}.{0}Form\".equals(qm.getModuleName()))) ",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.PrjDomain);
                strCode.Append("\r\n {");
                strCode.Append("\r\n session.removeAttribute(QueryModel.ATT_NAME); //����ģ�������ԭ����session.");
                strCode.Append("\r\n }");
                strCode.Append("\r\n else {");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    strCode.AppendFormat("\r\n {0}_query = ({1}) qm.getProperty(\"{0}_query\");",
                        objQryRegionFldsEx.FldName_Java,
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType);
                }
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");
                strCode.Append("\r\n }");


                strCode.Append("\r\n //���Ĳ������ݲ�ѯ�����ֶ�ֵ����̬����sql��䣻");
                strCode.Append("\r\n //���ݲ�ѯ������̬����sql���");

                strCode.Append("\r\n StringBuffer sbWhereCond = new StringBuffer();");
                strCode.Append("\r\n sbWhereCond.append(\" 1=1 \");");
                strCode.Append("\r\n //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�");

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "boolean")
                    {
                        strCode.AppendFormat("\r\n //if ({0}_query != null &&  ! (\"\".equals({0}_query))) ",
                           objQryRegionFldsEx.FldName_Java);
                        strCode.Append("\r\n //{");
                        strCode.AppendFormat("\r\n //paramList.add(\"%\" + {0}_query + \"%\");",
                            objQryRegionFldsEx.FldName_Java);
                        strCode.AppendFormat("\r\n //sbWhereCond.append(\" AND {0} = '\" + {0}_query + \"\'\" );",
                            objQryRegionFldsEx.FldName_Java);
                        strCode.AppendFormat("\r\n //System.out.println({0}_query);",
                            objQryRegionFldsEx.FldName_Java);
                        strCode.Append("\r\n //}");
                        continue;
                    }
                    else if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "int")
                    {
                        strCode.AppendFormat("\r\n if ({0}_query != null && {0}_query != 0 &&  ! (\"\".equals({0}_query))) ",
                            objQryRegionFldsEx.FldName_Java);
                    }
                    else if (objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "double")
                    {
                        strCode.AppendFormat("\r\n if ({0}_query != null && {0}_query != 0.0 &&  ! (\"\".equals({0}_query))) ",
                            objQryRegionFldsEx.FldName_Java);
                    }
                    else
                    {
                        strCode.AppendFormat("\r\n if ({0}_query != null &&  ! (\"\".equals({0}_query))) ",
                            objQryRegionFldsEx.FldName_Java);
                    }
                    strCode.Append("\r\n {");
                    strCode.AppendFormat("\r\n paramList.add(\"%\" + {0}_query + \"%\");",
                        objQryRegionFldsEx.FldName_Java);
                    strCode.AppendFormat("\r\n sbWhereCond.append(\" AND {0} = '\" + {0}_query + \"\'\" );",
                        objQryRegionFldsEx.FldName_Java);
                    strCode.AppendFormat("\r\n System.out.println({0}_query);",
                        objQryRegionFldsEx.FldName_Java);
                    strCode.Append("\r\n }");
                }
                strCode.Append("\r\n if (\"\".equals(strOrderby) == false) ");
                strCode.Append("\r\n {");
                strCode.Append("\r\n sbWhereCond.append(\" ORDER BY \" + strOrderby);");
                strCode.Append("\r\n }");
                strCode.Append("\r\n return sbWhereCond.toString();");
                strCode.Append("\r\n }");
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }


        ///������Ӽ�¼����;(Add{0})
        public string GenAddRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//��Ӽ�¼�ĺ�������Ҫ��������ʾ��Ӽ�¼ҳ��ǰ��ʼ��һЩ���ݣ���Ϊҳ��ĳ�ʼֵ");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Add);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//�������е�����������Ҫ�������ֵ䣬��ֵ-���Ƶ����ݼ�(DataSet).");
                strCode.AppendFormat("\r\n" + "{0}Manager.setAllDict(request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n" + "//��ȡ��̬FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
    objViewInfoENEx.TableNameForProg_FstLcase,
     objViewInfoENEx.TableNameForProg_FstUcase);

                strCode.Append("\r\n" + "//ͨ���û�����(UserToken)��ȡ��ǰ��¼���û�ID");
                strCode.Append("\r\n" + "//String strUserId = UserToken.getUserid(request);");
                strCode.Append("\r\n" + "//��ȡ��ǰְ����(zgh)�������Ϣ���洢�����ݼ�(DataSet)�С�");
                strCode.Append("\r\n" + "//ҳ����ת�������ٵ�ҳ��");
                strCode.AppendFormat("\r\n" + "return map.findForward(\"{0}\");",
                    objViewInfoENEx.StutsActionMethod_Add);
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }
        ///������ʾ��¼����;(ShowData)
        public string GenShowData(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�");
                strCodeForCs.Append("\r\n" + "///������     �������ǰ�ֵ������ؼ���");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "private void ShowData({0} {1}, ActionForm form,	HttpServletRequest request, HttpServletResponse response)",
            objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                strCodeForCs.Append("\r\n" + " throws Exception, SQLException, ClassNotFoundException {");
                strCodeForCs.Append("\r\n" + "//�������裺");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��");
                strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "long" || objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == false)		//���ùؼ��ֵļ�¼�Ƿ����",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String ss = \"�ؼ���Ϊ��\" + {0} + \"�Ĳ�����!\";",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//response.Write(\"<script>alert('\" + ss + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0} = new cls{0}({1});",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Get{0}();",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "//BackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "//response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "request.getSession().setAttribute(\"obj{0}\", obj{0});",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���");
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}, form);",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///���ɰ�����������������ʾ��������;
                string strTemp = GenGetDataFromClass(objViewInfoENEx);
                strCodeForCs.Append(strTemp);
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GenGetDataFromClass(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                ///���ɽ��б���;
              
                strCode.Append("\r\n" + "/// <summary>");
                strCode.Append("\r\n" + "/// �������ܣ�������������������ʾ��������");
                strCode.Append("\r\n" + "///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ");
                strCode.Append("\r\n" + "///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�");
                strCode.Append("\r\n" + "/// </summary>");
                strCode.AppendFormat("\r\n" + "/// <param name=\"pobj{0}\">��ʵ�������</param>",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCode.AppendFormat("\r\n" + "private void GetDataFrom{0}Class(cls{0} pobj{0}, ActionForm form)",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCode.Append("\r\n" + "throws Exception{");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
objViewInfoENEx.TableNameForProg_FstLcase,
objViewInfoENEx.TableNameForProg_FstUcase);

                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrINTabFldSet)
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.IsIdentity == false)
                    {
                        strCode.AppendFormat("\r\n" + "{0}Form.set{1}(pobj{2}.get{1}());",
                            objViewInfoENEx.TableNameForProg_FstLcase,
                           objComm.FirstUcase(objPrjTabFldENEx.objFieldTabENEx.FldName_Java),
                           objViewInfoENEx.objINPrjTab.TabName);
                    }
                }
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///������ʾ��¼����;(ShowData)
        public string GenShowDataForUpdate(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.AppendFormat("\r\n" + " * ����:����޸ļ�¼��ʾĳ����¼������,�ü�¼�Ĺؼ���ֵΪ:{0}",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + " * @param {0}:��¼�Ĺؼ���ֵ",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + " * @param form:����ֵ�õ�FORM");
                strCodeForCs.Append("\r\n" + " * @param request");
                strCodeForCs.Append("\r\n" + " * @param response");
                strCodeForCs.Append("\r\n" + " * @throws Exception");
                strCodeForCs.Append("\r\n" + " * @throws SQLException");
                strCodeForCs.Append("\r\n" + " * @throws ClassNotFoundException");
                strCodeForCs.Append("\r\n" + " */");
                strCodeForCs.AppendFormat("\r\n" + "private void ShowDataForUpdate({0} {1}, ActionForm form,	HttpServletRequest request, HttpServletResponse response)",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                strCodeForCs.Append("\r\n" + " throws Exception, SQLException, ClassNotFoundException {");
                strCodeForCs.Append("\r\n" + "//�������裺");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��");
                strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "long" || objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == false)		//���ùؼ��ֵļ�¼�Ƿ����",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String ss = \"�ؼ���Ϊ��\" + {0} + \"�Ĳ�����!\";",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//response.Write(\"<script>alert('\" + ss + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0} = new cls{0}({1});",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Get{0}();",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "//BackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "//response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "request.getSession().setAttribute(\"obj{0}\", obj{0});",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���");
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}ClassForUpdate(obj{0}, form);",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///���ɰ�����������������ʾ��������;
                string strTemp = GenGetDataFromClassForUpdate();
                strCodeForCs.Append(strTemp);
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        ///������ʾ��¼����;(ShowData)
        public string GenShowDataForDetail(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.AppendFormat("\r\n" + " * ����:�����ʾ��ϸ��Ϣ����ʾĳ����¼������,�ü�¼�Ĺؼ���ֵΪ:{0}",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + " * @param {0}:��¼�Ĺؼ���ֵ",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + " * @param form:����ֵ�õ�FORM");
                strCodeForCs.Append("\r\n" + " * @param request");
                strCodeForCs.Append("\r\n" + " * @param response");
                strCodeForCs.Append("\r\n" + " * @throws Exception");
                strCodeForCs.Append("\r\n" + " * @throws SQLException");
                strCodeForCs.Append("\r\n" + " * @throws ClassNotFoundException");
                strCodeForCs.Append("\r\n" + " */");
                strCodeForCs.AppendFormat("\r\n" + "private void ShowDataForDetail({0} {1}, ActionForm form,	HttpServletRequest request, HttpServletResponse response)",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                strCodeForCs.Append("\r\n" + " throws Exception, SQLException, ClassNotFoundException {");
                strCodeForCs.Append("\r\n" + "//�������裺");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��");
                strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1�����ؼ����Ƿ�Ϊ�գ�");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "long" || objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//����ؼ���Ϊ�վͷ����˳�",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == false)		//���ùؼ��ֵļ�¼�Ƿ����",
                    objViewInfoENEx.objOUTPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String ss = \"�ؼ���Ϊ��\" + {0} + \"�Ĳ�����!\";",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//response.Write(\"<script>alert('\" + ss + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������");
                strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0} = new cls{0}({1});",
                    objViewInfoENEx.objOUTPrjTab.TabName,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//4����ȡ�������������ԣ�");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.Get{0}();",
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ErrMessage = objException.Message;");
                strCodeForCs.Append("\r\n" + "//BackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "//response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "request.getSession().setAttribute(\"obj{0}\", obj{0});",
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "//5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���");
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}ClassForDetail(obj{0}, form);",
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///���ɰ�����������������ʾ��������;
                string strTemp = GenGetDataFromClassForDetail();
                strCodeForCs.Append(strTemp);
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenGetDataFromClassForUpdate(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                ///���ɽ��б���;
           
                strCode.Append("\r\n" + "/// <summary>");
                strCode.Append("\r\n" + "/// �������ܣ�������������������ʾ��������");
                strCode.Append("\r\n" + "///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ");
                strCode.Append("\r\n" + "///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�");
                strCode.Append("\r\n" + "/// </summary>");
                strCode.AppendFormat("\r\n" + "/// <param name=\"pobj{0}\">��ʵ�������</param>",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCode.AppendFormat("\r\n" + "private void GetDataFrom{0}ClassForUpdate(cls{0} pobj{0}, ActionForm form)",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCode.Append("\r\n" + "throws Exception{");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
objViewInfoENEx.TableNameForProg_FstLcase,
objViewInfoENEx.TableNameForProg_FstUcase);

                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrINTabFldSet)
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.IsIdentity == false)
                    {
                        strCode.AppendFormat("\r\n" + "{0}Form.set{1}(pobj{2}.get{1}());",
                            objViewInfoENEx.TableNameForProg_FstLcase,
                           objComm.FirstUcase(objPrjTabFldENEx.objFieldTabENEx.FldName_Java),
                           objViewInfoENEx.objINPrjTab.TabName);
                    }
                }
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        public string GenGetDataFromClassForDetail(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                ///���ɽ��б���;
  
                strCode.Append("\r\n" + "/// <summary>");
                strCode.Append("\r\n" + "/// �������ܣ�������������������ʾ��������");
                strCode.Append("\r\n" + "///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ");
                strCode.Append("\r\n" + "///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�");
                strCode.Append("\r\n" + "/// </summary>");
                strCode.AppendFormat("\r\n" + "/// <param name=\"pobj{0}\">��ʵ�������</param>",
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.AppendFormat("\r\n" + "private void GetDataFrom{0}ClassForDetail(cls{0} pobj{0}, ActionForm form)",
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.Append("\r\n" + "throws Exception{");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
objViewInfoENEx.TableNameForProg_FstLcase,
objViewInfoENEx.TableNameForProg_FstUcase);

                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrOUTTabFldSet)
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.IsIdentity == false)
                    {
                        strCode.AppendFormat("\r\n" + "{0}Form.set{1}(pobj{2}.get{1}());",
                            objViewInfoENEx.TableNameForProg_FstLcase,
                           objComm.FirstUcase(objPrjTabFldENEx.objFieldTabENEx.FldName_Java),
                           objViewInfoENEx.objOUTPrjTab.TabName);
                    }
                }
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }


        ///������Ӽ�¼����;(Add{0})
        public string GenAddSaveRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//��Ӽ�¼���溯��");
                strCode.AppendFormat("\r\n" + " public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_AddSave);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//��ȡ��̬FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
    objViewInfoENEx.TableNameForProg_FstLcase,
     objViewInfoENEx.TableNameForProg_FstUcase);

                strCode.Append("\r\n" + "//��ȡ�ؼ���ֵ");
                strCode.AppendFormat("\r\n" + "{2} {0}={1}Form.get{0}();",
                   objComm.FirstUcase(objViewInfoENEx. objMainTabKeyFld.FldName_Java), objViewInfoENEx.TableNameForProg_FstLcase,
                   objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                strCode.Append("\r\n try");
                strCode.Append("\r\n {");
                strCode.AppendFormat("\r\n" + "{1}Manager.add{2}({1}Form);",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n }");
                strCode.Append("\r\n catch(Exception ex)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n     request.setAttribute(\"error\", ex.getMessage());");
                strCode.Append("\r\n" + "return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.Append("\r\n" + "//����<����>ҳ���URL���Ա�����ӳɹ���ҳ���Ϸ��ص��б�ҳ�档");
                strCode.Append("\r\n" + "request.getSession().setAttribute(\"backurl\",");
                strCode.AppendFormat("\r\n" + "\"{2}.do?method={0}\");",
                    objViewInfoENEx.StutsActionMethod_List,
                    objViewInfoENEx.ActionPath,
                    objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + "//ҳ����ת����ӳɹ���ҳ��");
                strCode.Append("\r\n" + "return map.findForward(\"success\");");
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///�����޸ļ�¼����;(Update{0})
        public string GenUpdateRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//�޸ļ�¼�ĳ�ʼ������");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Update);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//��ȡ��̬FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n try");
                strCode.Append("\r\n {");
                strCode.Append("\r\n" + "//�������е�����������Ҫ�������ֵ䣬��ֵ-���Ƶ����ݼ�(DataSet).");
                strCode.AppendFormat("\r\n" + "{0}Manager.setAllDict(request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n }");
                strCode.Append("\r\n catch (SQLException objException)");
                strCode.Append("\r\n {");
                //	request.setAttribute("error", objException.getMessage());

                strCode.Append("\r\n ArrayList<String> arrError = new ArrayList<String>();");
                strCode.Append("\r\n arrError.add(\"�ڻ�ȡ����������Դʱ���ִ���!\");");
                strCode.Append("\r\n if (objException.getMessage() != null)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n arrError.add(objException.getMessage());");
                strCode.Append("\r\n }");
                strCode.Append("\r\n request.setAttribute(\"error\", arrError);");
                strCode.Append("\r\n return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.Append("\r\n" + "//��ȡ��������Ҫ�޸ĵĹؼ���ֵ�б��Ӷ�̬FORM�л�ȡ����ѡ����к��б�");
                strCode.Append("\r\n" + "//      �кž��Ǳ�ʶ���еĹؼ���ֵ��");
                strCode.Append("\r\n" + "//   ֻ�޸��б��еĵ�һ�С�");
                //strCode.AppendFormat("\r\n" + "{1} {2} = {0}Form.getArray(\"rowid\")[0] ;",
                //    objViewInfoENEx.TableNameForProg_FstLcase,
                //    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                //    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.PrivFuncName);

                strCode.AppendFormat("\r\n" + "// ArrayList lstRowId = objViewInfoENEx.getSelecedList(request, {0});",
                    objViewInfoENEx.StutsActionFormObject_Sim);
                strCode.AppendFormat("\r\n" + "//{0} {1} = 0;",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + "//if (lstRowId.size() > 0)");
                strCode.Append("\r\n" + "//{");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "int")
                {
                    strCode.AppendFormat("\r\n" + "//{0} = Integer.valueOf(lstRowId.get(0).toString());",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "long")
                {
                    strCode.AppendFormat("\r\n" + "//{0} = Long.valueOf(lstRowId.get(0).toString());",
                     objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCode.AppendFormat("\r\n" + "//{0} = lstRowId.get(0).toString();",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCode.Append("\r\n" + "//}");
                strCode.Append("\r\n" + "//else");
                strCode.Append("\r\n" + "//{");
                strCode.Append("\r\n" + "//return map.findForward(\"error\");");
                strCode.Append("\r\n" + "//}");
                strCode.AppendFormat("\r\n" + "//{0} {1} = {3}.get{2}();",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName,
                    objComm.FirstUcase(objViewInfoENEx. objMainTabKeyFld.FldName_Java),
                    objViewInfoENEx.StutsActionFormObject_Sim);

                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "int")
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(request.getParameter(\"id\"));",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                }
                else if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "long")
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(request.getParameter(\"id\"));",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = request.getParameter(\"id\");",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }


                // �����ݼ����������Զ��洢�ڶ�̬FORM���Ա㴫���VIEW��
                strCode.AppendFormat("\r\n" + "ShowDataForUpdate({2}, form, request, response);",
                    objViewInfoENEx.objINPrjTab.TabName,
                     objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.PrivFuncName);


                strCode.Append("\r\n" + "//ҳ����ת���޸ļ�¼��ҳ��");
                strCode.AppendFormat("\r\n" + "return map.findForward(\"{0}\");",
                    objViewInfoENEx.StutsActionMethod_Update);
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }
        ///�����޸ı����¼����;(Update{0}Save)
        public string GenUpdateSaveRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//�޸ļ�¼���溯��");
                strCode.AppendFormat("\r\n" + " public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//��ȡ��̬FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//��ȡ�ؼ���ֵ");
                strCode.AppendFormat("\r\n" + "{3} {0}={2}Form.get{0}();",
                   objComm.FirstUcase(objViewInfoENEx. objMainTabKeyFld.FldName_Java),
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType);

                strCode.Append("\r\n try");
                strCode.Append("\r\n {");
                strCode.AppendFormat("\r\n" + "{1}Manager.update{2}({1}Form);",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n }");
                strCode.Append("\r\n catch(Exception ex)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n     request.setAttribute(\"error\", ex.getMessage());");
                strCode.Append("\r\n" + "return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.Append("\r\n" + "//����<����>ҳ���URL���Ա����޸ĳɹ���ҳ���Ϸ��ص��б�ҳ�档");
                strCode.Append("\r\n" + "request.getSession().setAttribute(\"backurl\",");
                strCode.AppendFormat("\r\n" + "\"{2}.do?method={0}\");",
                    objViewInfoENEx.StutsActionMethod_List,
                    objViewInfoENEx.ActionPath,
                    objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + "//ҳ����ת���޸ĳɹ���ҳ��");
                strCode.Append("\r\n" + "return map.findForward(\"success\");");
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///����ɾ����¼����;(delete{����})
        public string GenDeleteRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//ɾ����¼�ĺ���");
                strCode.AppendFormat("\r\n" + " public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Delete);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//��ȡ��̬FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//��ȡ��Ҫɾ���Ĺؼ���ֵ�б��Ӷ�̬FORM�л�ȡ����ѡ����к��б�");
                strCode.Append("\r\n" + "//      �кž��Ǳ�ʶ���еĹؼ���ֵ��");
                strCode.AppendFormat("\r\n" + "//ArrayList lstRowId = objViewInfoENEx.getSelecedList(request, {0});",
                    objViewInfoENEx.StutsActionFormObject_Sim);

                //int intROLE_ID = Integer.valueOf(request.getParameter("id"));
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "int")
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(request.getParameter(\"id\"));",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                }
                else if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "long")
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(request.getParameter(\"id\"));",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = request.getParameter(\"id\");",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCode.Append("\r\n try");
                strCode.Append("\r\n {");
                strCode.Append("\r\n" + "//ɾ����ѡ�е����м�¼");
                strCode.AppendFormat("\r\n" + "//{0}Manager.delete{1}s(lstRowId);",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx.TableNameForProg);
                strCode.AppendFormat("\r\n" + "{0}.delete{1}({2});",
                    objViewInfoENEx.StutsManagerObject_Sim,
                    objViewInfoENEx.TableNameForProg_FstUcase,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n }");
                strCode.Append("\r\n catch (SQLException objException)");
                strCode.Append("\r\n {");
                //	request.setAttribute("error", objException.getMessage());

                strCode.Append("\r\n ArrayList<String> arrError = new ArrayList<String>();");
                strCode.Append("\r\n arrError.add(\"��ɾ�����¼ʱ���ִ���!\");");
                strCode.Append("\r\n if (objException.getMessage() != null)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n arrError.add(objException.getMessage());");
                strCode.Append("\r\n }");
                strCode.Append("\r\n request.setAttribute(\"error\", arrError);");
                strCode.Append("\r\n return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.Append("\r\n" + "//����<����>ҳ���URL���Ա���ɾ���ɹ���ҳ���Ϸ��ص��б�ҳ�档");
                strCode.Append("\r\n" + "request.getSession().setAttribute(\"backurl\",");
                strCode.AppendFormat("\r\n" + "\"{2}.do?method={0}\");",
                    objViewInfoENEx.StutsActionMethod_List,
                    objViewInfoENEx.ActionPath,
                    objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + "//ҳ����ת��ɾ���ɹ���ҳ��");
                strCode.Append("\r\n" + "return map.findForward(\"success\");");
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///���ɼ�¼��ϸ��Ϣ����;(detail{0})
        public string GenDetailRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//��ʾ��ϸ��Ϣ�ĳ�ʼ������");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Detail);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//��ȡ��̬FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//��ȡ��������Ҫ�޸ĵĹؼ���ֵ�б��Ӷ�̬FORM�л�ȡ����ѡ����к��б�");
                strCode.Append("\r\n" + "//      �кž��Ǳ�ʶ���еĹؼ���ֵ��");
                strCode.Append("\r\n" + "//   ֻ��ʾ�б��еĵ�һ�С�");
                //strCode.AppendFormat("\r\n" + "{1} {2} = {0}Form.getArray(\"rowid\")[0] ;",
                //                    objViewInfoENEx.TableNameForProg_FstLcase,
                //                    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                //                    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.PrivFuncName);

                strCode.AppendFormat("\r\n" + "// ArrayList lstRowId = objViewInfoENEx.getSelecedList(request, {0});",
                    objViewInfoENEx.StutsActionFormObject_Sim);
                strCode.AppendFormat("\r\n" + "//{0} {1} = 0;",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + "//if (lstRowId.size() > 0)");
                strCode.Append("\r\n" + "//{");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "int")
                {
                    strCode.AppendFormat("\r\n" + "//{0} = Integer.valueOf(lstRowId.get(0).toString());",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "long")
                {
                    strCode.AppendFormat("\r\n" + "//{0} = Long.valueOf(lstRowId.get(0).toString());",
                     objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCode.AppendFormat("\r\n" + "//{0} = lstRowId.get(0).toString();",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCode.Append("\r\n" + "//}");
                strCode.Append("\r\n" + "//else");
                strCode.Append("\r\n" + "//{");
                strCode.Append("\r\n" + "//return map.findForward(\"error\");");
                strCode.Append("\r\n" + "//}");
                strCode.AppendFormat("\r\n" + "//{0} {1} = {3}.get{2}();",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName,
                    objComm.FirstUcase(objViewInfoENEx. objMainTabKeyFld.FldName_Java),
                    objViewInfoENEx.StutsActionFormObject_Sim);

                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "int")
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(request.getParameter(\"id\"));",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                }
                else if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "long")
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(request.getParameter(\"id\"));",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCode.AppendFormat("\r\n" + "{0} {1} = request.getParameter(\"id\");",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }

                // �����ݼ����������Զ��洢�ڶ�̬FORM���Ա㴫���VIEW��
                strCode.AppendFormat("\r\n" + "ShowDataForDetail({0}, form, request, response);",
                    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + "//ҳ����ת����ʾ��¼��ϸ��Ϣ��ҳ��");
                strCode.AppendFormat("\r\n" + "return map.findForward(\"{0}\");",
                    objViewInfoENEx.StutsActionMethod_Detail);
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///���ɲ�ѯ��¼��ʼ����������;(query{0})
        public string GenQueryRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//��ʾ��ϸ��Ϣ�ĳ�ʼ������");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Query);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//��������������ؼ���{ֵ������}�ֵ������б�");
                strCode.AppendFormat("\r\n" + "{0}Manager.setAllDict(request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n" + "//ҳ����ת����ѯ��¼��ҳ��");
                strCode.AppendFormat("\r\n" + "return map.findForward(\"{0}\");",
                    objViewInfoENEx.StutsActionMethod_Query);
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        public string A_GeneFuncCode(string strFuncName, clsViewInfoENEx objViewInfoENEx)
        {
            try
            {
                switch (strFuncName)
                {
                    case "GenListRecCode":
                        return GenListRecCode();
                    case "GenAddRecCode":
                        return GenAddRecCode();
                    case "GenAddSaveRecCode":
                        return GenAddSaveRecCode();
                    case "GenUpdateRecCode":
                        return GenUpdateRecCode();
                    case "GenShowData":
                        return GenShowData();
                    case "GenShowDataForDetail":
                        return GenShowDataForDetail();
                    case "GenShowDataForUpdate":
                        return GenShowDataForUpdate();
                    case "GenGetDataFromCls":
                        return GenGetDataFromClass(objViewInfoENEx);
                    case "GenUpdateSaveRecCode":
                        return GenUpdateSaveRecCode();
                    case "GenDeleteRecCode":
                        return GenDeleteRecCode();
                    case "GenDetailRecCode":
                        return GenDetailRecCode();
                    case "GenQueryRecCode":
                        return GenQueryRecCode();
                    case "GenCombineCondionCode":
                        return GenCombineCondionCode();
                    case "GenGetSelecedList":
                        return GenGetSelecedList();

                    default:
                        return "///�ú���������:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�����ɺ�����{0}ʱ����. \r\n������Ϣ��{1}.", strFuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }
        /// <summary>
        /// ���˽�б��������������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar(clsViewInfoENEx objViewInfoENEx)
        {
            Hashtable hsTab = new Hashtable();
            StringBuilder strBuilder = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in arrINTabFldSet)
            {

                strBuilder.AppendFormat("\r\n protected {0} {1};	//{2}",
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objComm.FstLcase(objPrjTabFldENEx.FldName_Java),
                    objPrjTabFldENEx.objFieldTabENEx.Caption);
                hsTab.Add(objPrjTabFldENEx.FldName_Java, "TRUE");
            }
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in arrOUTTabFldSet)
            {
                if (hsTab.Contains(objPrjTabFldENEx.FldName_Java) == true)
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\n protected {0} {1};	//{2}",
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objComm.FstLcase(objPrjTabFldENEx.FldName_Java),
                    objPrjTabFldENEx.objFieldTabENEx.Caption);
                hsTab.Add(objPrjTabFldENEx.FldName_Java, "TRUE");
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���˽�б��������������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar_Query(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������˽������
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
            {

                strBuilder.AppendFormat("\r\n protected {0} {1}_query;	//{2}���ڲ�ѯ",
             objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objComm.FstLcase(objQryRegionFldsEx.objPrjTabFldENEx.FldName_Java),
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string gfunClsProperty(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����������
            ///
            Hashtable hsTab = new Hashtable();
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrINTabFldSet)
            {

                string strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                objComm.FstUcase(ref strTemp);
                strBuilder.AppendFormat("\r\n //��ȡ{0}({1})��ֵ",
                    objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()",
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};",
                    objComm.FstLcase(objPrjTabFldENEx.FldName_Java));
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //����{0}({1})��ֵ",
                    objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public void set{0}({1} value)",
                    strTemp, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = value;", objPrjTabFldENEx.FldName_Java);
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
                hsTab.Add(objPrjTabFldENEx.FldName_Java, "TRUE");
            }
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in arrOUTTabFldSet)
            {
                if (hsTab.Contains(objPrjTabFldENEx.FldName_Java) == true)
                {
                    continue;
                }
                string strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                objComm.FstUcase(ref strTemp);
                strBuilder.AppendFormat("\r\n //��ȡ{0}({1})��ֵ",
                    objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()",
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};",
                    objComm.FstLcase(objPrjTabFldENEx.FldName_Java));
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //����{0}({1})��ֵ",
                    objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public void set{0}({1} value)",
                    strTemp, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = value;", objPrjTabFldENEx.FldName_Java);
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string gfunClsProperty_Query(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����������
            ///
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
            {

                string strTemp = objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                objComm.FstUcase(ref strTemp);
                strBuilder.AppendFormat("\r\n //��ȡ{0}({1})��ֵ",
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}_query()",
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0}_query;",
                    objComm.FstLcase(objQryRegionFldsEx.objPrjTabFldENEx.FldName_Java));
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //����{0}({1})��ֵ",
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public void set{0}_query({1} value)",
                    strTemp,
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n objViewInfoENEx.{0}_query = value;",
                    objQryRegionFldsEx.objPrjTabFldENEx.FldName_Java);
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string GenGetSelecedList(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����������
            ///
            strBuilder.AppendFormat("\r\n public ArrayList getSelecedList(HttpServletRequest request,");
            strBuilder.AppendFormat("\r\n {0} {1})",
                objViewInfoENEx.StutsActionFormClass_Sim,
                objViewInfoENEx.StutsActionFormObject_Sim);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n List list = {0}.getSelectList();",
                objViewInfoENEx.StutsActionFormObject_Sim);
            strBuilder.Append("\r\n ArrayList<String> lstKeys = new ArrayList<String>();");
            strBuilder.Append("\r\n for (int i = 0; i < list.size(); i++)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strId = request.getParameter(\"chk[\" + i + \"]\");");
            strBuilder.Append("\r\n if (strId == null)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n continue;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n lstKeys.add(strId);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return lstKeys;");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
    }
}