using System;
using System.Collections;
using System.Text;
using System.IO;
using com.taishsoft.file;

using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;
using com.taishsoft.commdb;

namespace AGC_CSV7.BusinessLogic.GeneCode2
{
    /// <summary>
    /// �Զ����ɽ�����Ʋ�Ĵ�����(Control of MVC)
    /// </summary>
    public class AutoGC6J_Manager : clsViewGroupBLEx //: clsViewCtlFldSet_V5
    {
        protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        public AutoGC6J_Manager()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

        //public AutoGC6J_Manager(string strViewGroupId)
        //    : base(strViewGroupId)
        //{
        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //

        //}
        /// <summary>
        /// ����ͨ���߼������
        /// </summary>
        /// <returns></returns>
        public string A_GenManagerCode( Encoding myEncoding, ref string strResult)
        {
            //			if (objPrjTabENEx.TabFldNum == 0)
            //			{
            //				strResult = "��ǰ��" + objOUTPrjTab.TabName + "���ֶ���Ϊ0���޷�����ͨ���߼���!";
            //				return strResult;
            //			}
            //			if (objPrjTabENEx.KeyFldNum == 0)
            //			{
            //				strResult = "��ǰ��" + objOUTPrjTab.TabName + "�Ĺؼ��ֵĸ���Ϊ0���޷�����ͨ���߼���!";
            //				return strResult;
            //			}

            ///���û���������;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("GenGetTabRecListCode"); //
            arrFuncList.Add("GenGetTabRecDispListCode");	//����˽�б�����Ҳ��˽������
            arrFuncList.Add("GenAddRecCode");	//��Ĺ�����1
            arrFuncList.Add("GenUpdateRecCode");	//��Ĺ�����3
            //arrFuncList.Add("GenDeleteRecCode"); //
            arrFuncList.Add("GenDeleteMultiRecCode"); // 
            arrFuncList.Add("GenTabDetailRecCode"); //
            //arrFuncList.Add("GenSetExcelReportCode"); //GenSetExcelReportCode
            arrFuncList.Add("GenSetAllDictCode"); //
            //arrFuncList.Add("GenClosePMCode"); //

            string ClsName = objViewInfoENEx.TableNameForProg_FstUcase + "Manager";
            strClassFName = mstrFolderName + ClsName + ".java";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsByPrjId(objViewInfoENEx.PrjId); //


            try
            {
                ///������ʼ
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName));

                ///����
                strCodeForCs.AppendFormat("\r\n" + "package {0};",
                objViewInfoENEx.PrjDomain);
                ///������ʼ
                strCodeForCs.Append("\r\n" + "import javax.servlet.http.*;"); //
                strCodeForCs.Append("\r\n" + "import java.sql.SQLException;");
                strCodeForCs.Append("\r\n" + " import java.sql.ResultSet;");
                strCodeForCs.Append("\r\n" + "import java.util.*; "); //
                //				strCodeForCs.Append("\r\n" + "import SpecData.clsSpecSQLforSql; "); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.*;"); //
                strCodeForCs.AppendFormat("\r\n" + "import {0}.commdbtab.*;", objProject.PrjDomain); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commexception.*;"); //
                strCodeForCs.Append("\r\n" + "import javax.servlet.http.*;");


                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n" + "public class " + ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.AppendFormat("\r\n" + "public {0}Manager() ",
                objViewInfoENEx.TableNameForProg_FstUcase);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "}");

                //�������еĺ���

                foreach (string strFuncName in arrFuncList)
                {
                    strTemp = A_GeneFuncCode(strFuncName, objPrjTabENEx);
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");

                //������д���ļ���;
                //�����ļ������ļ����������ж��Ƿ����;
                strFolder = objComm.ParentDir(strClassFName);
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
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

        ///��ȡ���¼�б�(list{0})
        public string GenGetTabRecListCode()
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                strCode.Append("\r\n" + "//��ȡ���¼�б�");
                strCode.AppendFormat("\r\n" + "public ArrayList<cls{1}> get{0}List(String strCondition) throws",
                objViewInfoENEx.TableNameForProg,
                objINPrjTab.TabName);
                strCode.Append("\r\n" + "SQLException, ClassNotFoundException {");
                strCode.Append("\r\n" + "/* boolean a = UserToken.hasPermission(request, \"12\");");
                strCode.Append("\r\n" + " try {");
                strCode.Append("\r\n" + " String strUserId = UserToken.getUser(request).getUserID();");
                strCode.Append("\r\n" + " }");
                strCode.Append("\r\n" + " catch (Exception e) {}");
                strCode.Append("\r\n" + " }*/");
                strCode.AppendFormat("\r\n" + "ArrayList<cls{0}> arrQuoteLst = new cls{0}().Get{0}ObjList(strCondition);",
                objINPrjTab.TabName);
                strCode.Append("\r\n" + "return arrQuoteLst;");
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///��ȡ���¼��ʾ�б�(list{0})
        public string GenGetTabRecDispListCode()
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                strCode.AppendFormat("\r\n" + "//��ȡ������ʾ�ı��¼�б�(����ͼ<{0}>�л�ȡ����)",
                objOUTPrjTab.TabName);
                strCode.AppendFormat("\r\n" + "public ArrayList<cls{1}> get{1}DispList(String strCondition) throws",
                objViewInfoENEx.TableNameForProg,
                objOUTPrjTab.TabName);
                strCode.Append("\r\n" + "SQLException, ClassNotFoundException {");
                strCode.Append("\r\n" + "/* boolean a = UserToken.hasPermission(request, \"12\");");
                strCode.Append("\r\n" + " try {");
                strCode.Append("\r\n" + " String strUserId = UserToken.getUser(request).getUserID();");
                strCode.Append("\r\n" + " }");
                strCode.Append("\r\n" + " catch (Exception e) {}");
                strCode.Append("\r\n" + " }*/");
                strCode.AppendFormat("\r\n" + "ArrayList<cls{0}> arrQuoteLst = new cls{0}().Get{0}ObjList(strCondition);",
                objOUTPrjTab.TabName);
                strCode.Append("\r\n" + "return arrQuoteLst;");
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }
        ///��ʾ��ļ�¼�б�(list{0})

        ///������Ӽ�¼����;(Add{0})
        public string GenAddRecCode()
        {
            StringBuilder strCode = new StringBuilder();
            string strTemp;
            try
            {
                strCode.Append("\r\n" + "//ȷ����Ӽ�¼�ĺ�����");
                strCode.AppendFormat("\r\n" + " public void add{0}({0}Form form) ",
                objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "throws SQLException, Exception {");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet_Add)
                {

                    strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType;
                    objComm.FstUcase(ref strTemp);
                    strCode.AppendFormat("\r\n {0} {4} = form.get{1}();	//{5}",
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objComm.FirstUcase(objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java),
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    strTemp,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                }

                strCode.AppendFormat("\r\n cls{0} obj{0} = new cls{0}();",
                objINPrjTab.TabName);
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet_Add)
                {
                    strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                    objComm.FstUcase(ref strTemp);
                    strCode.AppendFormat("\r\n obj{0}.set{1}({2});		//",
                    objINPrjTab.TabName,
                    strTemp,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objEditRegionFldsEx.FldName_Java,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
                strCode.AppendFormat("\r\n obj{0}.AddNewRecord();",
                objINPrjTab.TabName);
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///ȷ���޸ļ�¼�ĺ���;(Update{0})
        public string GenUpdateRecCode()
        {
            StringBuilder strCode = new StringBuilder();
            string strTemp;
            try
            {
                strCode.Append("\r\n" + "//ȷ���޸ļ�¼�ĺ���");
                strCode.AppendFormat("\r\n" + " public void update{0}({0}Form form) ",
                objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "throws SQLException, Exception {");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet_Update)
                {
                    strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    objComm.FstUcase(ref strTemp);
                    strCode.AppendFormat("\r\n {0} {4} = form.get{1}();		//{5}",
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType,
                    objComm.FirstUcase(objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java),
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    strTemp,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
                strCode.AppendFormat("\r\n" + "{0} {1} = form.get{2}();",
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName,
                objComm.FirstUcase(objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName_Java));
                //clsROLE objROLE = new clsROLE(role_id);

                strCode.AppendFormat("\r\n cls{0} obj{0} = new cls{0}({1});",
                objINPrjTab.TabName,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet_Update)
                {
                    //					if (objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "int")
                    //					{
                    //						strCode.AppendFormat("\r\n int int{0} = Integer.parseInt({0}.toString());",
                    //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    //							objEditRegionFldsEx.FldName_Java);
                    //
                    //						strCode.AppendFormat("\r\n obj{0}.set{1}(int{1});",
                    //							objINPrjTab.TabName,
                    //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    //							objEditRegionFldsEx.FldName_Java);
                    //					}
                    //					else
                    //					{
                    strTemp = objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                    objComm.FstUcase(ref strTemp);
                    strCode.AppendFormat("\r\n obj{0}.set{1}({2});		//{3}",
                    objINPrjTab.TabName,
                    strTemp,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objEditRegionFldsEx.FldName_Java,
                    objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    //					}
                }


                strCode.AppendFormat("\r\n obj{0}.Update();",
                objINPrjTab.TabName);
                //
                //				strCode.Append("\r\n Object[] params = {");
                //				//��ȡ�༭�ֶ��б��еĹؼ��ֶ�
                //				clsEditRegionFldsENEx objEditRegionKeyFldEx = null;
                //				foreach(clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                //				{
                //					if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabPrimary == true)
                //					{
                //						objEditRegionKeyFldEx = objEditRegionFldsEx;
                //					}
                //				}
                //				StringBuilder sbFldList = new StringBuilder();
                //				foreach(clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                //				{
                //					if (objEditRegionFldsEx.objPrjTabFldENEx.IsTabPrimary == false)
                //					{
                //						sbFldList.AppendFormat("{0}, ",
                //							objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                //					}
                //				}
                //				sbFldList.AppendFormat("{0}",
                //					objEditRegionKeyFldEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                //				strCode.Append("\r\n};");
                //				strCode.AppendFormat("\r\n pm.executeUpdate(UPDATE_EMP, params);");

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
        public string GenDeleteRecCode()
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//ɾ��һ���¼�ĺ���");
                strCode.AppendFormat("\r\n" + " public int delete{0}s(List lst{0}s) ",
                objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + " throws SQLException {");
                strCode.AppendFormat("\r\n" + " cls{0} obj{0} = new cls{0}();",
                objINPrjTab.TabName);
                strCode.AppendFormat("\r\n" + "return obj{0}.Del{0}(lst{1}s);",
                objINPrjTab.TabName,
                objViewInfoENEx.TableNameForProg);
                strCode.Append("\r\n" + " }");

                //	 ɾ����¼�ĺ���
                //public int deleteMenu(long intMenu_id) throws SQLException,
                // ClassNotFoundException {
                // return clsMENU.DelRecord(intMenu_id);
                //}
                strCode.Append("\r\n" + "//ɾ��һ����¼�ĺ���");
                strCode.AppendFormat("\r\n" + " public int delete{0}({1} {2}) ",
                objViewInfoENEx.TableNameForProg_FstUcase,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + " throws SQLException {");
                strCode.AppendFormat("\r\n" + "return cls{0}.Del{0}Rercord({1});",
                objINPrjTab.TabName,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + " }");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///����ɾ��������¼����;(delete{����})
        public string GenDeleteMultiRecCode()
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//ɾ��������¼�ĺ���");
                strCode.AppendFormat("\r\n" + " public int delete{0}s(List<string> lstKeys) ",
                objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + " throws SQLException,ClassNotFoundException {");
                strCode.AppendFormat("\r\n" + "return cls{0}.Del{0}(lstKeys);",
                objINPrjTab.TabName,
                objViewInfoENEx.TableNameForProg);
                strCode.Append("\r\n" + " }");
                strCode.Append("\r\n" + "//ɾ��һ����¼�ĺ���");
                strCode.AppendFormat("\r\n" + " public int delete{0}({1} {2}) ",
                objViewInfoENEx.TableNameForProg_FstUcase,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + " throws SQLException, ClassNotFoundException {");
                strCode.AppendFormat("\r\n" + "return cls{0}.DelRecord({1});",
                objINPrjTab.TabName,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + " }");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///���ɼ�¼��ϸ��Ϣ����;(detail{0})
        public string GenTabDetailRecCode()
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//��ȡ��ϸ��Ϣ�����ݼ�(DataSet)����");
                // ��ȡ��ϸ��Ϣ�����ݼ�(DataSet)����

                strCode.AppendFormat("\r\n" + "public ResultSet getv{0}Detail() ",
                objViewInfoENEx.TableNameForProg,
                objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n" + "	throws SQLException, ClassNotFoundException {");
                strCode.Append("\r\n" + "ResultSet rs = null;");
                strCode.Append("\r\n" + "try {");

                strCode.Append("\r\n StringBuffer sbSql = new StringBuffer();");
                strCode.Append("\r\n sbSql.append(\"select \");");
                bool bolIsFirst = true;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in arrDetailFldSet)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCode.AppendFormat("\r\n sbSql.append(\"{0} \");	//{1}",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                    else
                    {
                        strCode.AppendFormat("\r\n sbSql.append(\", {0} \");	//{1}",
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                        objEditRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
                strCode.AppendFormat("\r\n sbSql.append(\" From {0} \");		//{1}",
                objOUTPrjTab.TabName,
                objOUTPrjTab.TabCnName);
                strCode.AppendFormat("\r\n sbSql.append(\" where {0}=? \");		//{1}",
                objViewInfoENEx. objMainTabKeyFld.FldName_Java,
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.Caption);
                strCode.AppendFormat("\r\n rs = cls{0}.GetResultSet(sbSql.toString());",
                objINPrjTab.TabName);

                strCode.Append("\r\n" + "}");
                strCode.Append("\r\n" + "catch (SQLException ex) {");
                strCode.Append("\r\n" + "throw ex;");
                strCode.Append("\r\n" + "}");
                strCode.Append("\r\n" + "finally {");
                strCode.Append("\r\n" + "}");
                strCode.Append("\r\n" + "return rs;");
                strCode.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }


        ///��������EXCEL�������;(setExcelReport)
        public string GenSetExcelReportCode()
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//����EXCEL�������");

                strCode.Append("\r\n" + "public void setExcelReport(String strWhereCond, ArrayList paramList, HttpServletRequest request) {");
                strCode.Append("\r\n" + "StringBuffer sbExportSql = new StringBuffer();");
                strCode.Append("\r\n" + "//excel����sql");

                strCode.Append("\r\n sbExportSql.append(\"select \");");
                strCode.AppendFormat("\r\n sbExportSql.append(\"{0} ECNUROWID\");",
                objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.FldName);
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    strCode.AppendFormat("\r\n sbExportSql.append(\", {0} \");		//{1}",
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                }

                strCode.AppendFormat("\r\n sbExportSql.append(\" From {0} \");		//{1}",
                objOUTPrjTab.TabName,
                objOUTPrjTab.TabCnName);

                strCode.Append("\r\n" + "if (\"\".equals(strWhereCond) == false) {");
                strCode.Append("\r\n" + "sbExportSql.append(strWhereCond);");
                strCode.Append("\r\n" + "}");
                strCode.Append("\r\n" + "Object[] params = new Object[paramList.size()];");
                strCode.Append("\r\n" + "paramList.toArray(params);");
                strCode.Append("\r\n" + "String[] fields = {");
                //"stdId", "stdName", "sex", "academyId", "academyName", "age"};
                bool bolIsFirst = true;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCode.AppendFormat("\r\n \"{0}\"		//{1}",
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                    else
                    {
                        strCode.AppendFormat("\r\n , \"{0}\"		//{1}",
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName,
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
                strCode.Append("\r\n" + "};");

                strCode.Append("\r\n" + "String[] captions = {");
                //"���", "����", "�Ա�", "ѧԺId", "ѧԺN", "����"};
                bolIsFirst = true;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                {
                    if (bolIsFirst == true)
                    {
                        bolIsFirst = false;
                        strCode.AppendFormat("\r\n \"{0}\"",
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                    else
                    {
                        strCode.AppendFormat("\r\n , \"{0}\"",
                        objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
                strCode.Append("\r\n" + "};");
                strCode.Append("\r\n" + "com.neusoft.ecnuidc.util.ExportUtil.setExportProp(request,");
                strCode.Append("\r\n" + "sbExportSql.toString(), params,");
                strCode.Append("\r\n" + "fields, captions);");
                strCode.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///���ɹر�PM(closePM)
        public string GenClosePMCode()
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                strCode.Append("\r\n" + "//�ر�PM");
                strCode.Append("\r\n" + "public void closePM() {");
                strCode.Append("\r\n" + "pm.closePM();");
                strCode.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCode.ToString();
        }

        ///��������������ؼ���{ֵ������}�ֵ������б�;(setAllDict)
        public string GenSetAllDictCode()
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                // // ��������������ؼ���{ֵ������}�ֵ������б�
                //public void setAllDict(HttpServletRequest request) throws Exception {
                // // ΪPART_TYPE(PART_TYPE)�ֶλ�ȡ�ֵ���Ϣ
                // ArrayList<clsPART_TYPE> arrPART_TYPE = new clsPART_TYPE().getPART_TYPEDict();
                // request.setAttribute("arrPART_TYPE", arrPART_TYPE);
                //}
                strCode.Append("\r\n" + "//��������������ؼ���{ֵ������}�ֵ������б�");
                strCode.Append("\r\n" + "public void setAllDict(HttpServletRequest request) throws Exception {");

                foreach (clsvViewGroupFldsEN objvViewGroupFlds in arrvViewGroupFldSet)
                {
                    if (objvViewGroupFlds.CtlTypeId == clsCtlTypeAbbrENEx.DROPDOWNLISTTYPE)
                    {
                        strCode.AppendFormat("\r\n" + "//Ϊ{0}({1})�ֶλ�ȡ�ֵ���Ϣ",
                        objvViewGroupFlds.Caption,
                        objvViewGroupFlds.FldName);

                        strCode.AppendFormat("\r\n" + "ArrayList<cls{1}> arr{0} = new cls{1}().get{1}Dict();",
                        objvViewGroupFlds.FldName,
                        objvViewGroupFlds.DS_TabName);
                        strCode.AppendFormat("\r\n" + "request.setAttribute(\"arr{0}\", arr{0});",
                        objvViewGroupFlds.FldName);
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
        /// <summary>
        /// Struts-config�����ɴ���
        /// </summary>
        /// <returns></returns>

        public string A_GenStrutsConfigCode()
        {
            ///���û���������;
            string strFolder;
            StringBuilder strCode = new StringBuilder(); ///�������WebForm�Ĵ���;
            //			string strTemp ; ///��ʱ����;
            string strClassFName;

            string ClsName = "struts-config-" + objViewInfoENEx.TableNameForProg_FstLcase;
            strClassFName = mstrFolderName + "struts-config-" + objViewInfoENEx.TableNameForProg_FstLcase + ".xml";
            mstrFileName = "struts-config-" + objViewInfoENEx.TableNameForProg_FstLcase + ".xml";

            try
            {
                ///���ɲ����¼�Ľ������;
                /// strCode.Append("///���ɵ�Struts-config����");

                strCode.Append("\r\n" + "<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                strCode.Append("\r\n" + "<!DOCTYPE struts-config PUBLIC \"-//Apache Software Foundation//DTD Struts Configuration 1.1//EN\" \"http://jakarta.apache.org/struts/dtds/struts-config_1_1.dtd\">");
                strCode.Append("\r\n" + "<struts-config>");
                strCode.Append("\r\n" + " <form-beans>");
                strCode.AppendFormat("\r\n" + " <form-bean name=\"{0}.{1}Form\" type=\"{0}.{2}Form\">",
                objViewInfoENEx.PrjDomain,
                objViewInfoENEx.TableNameForProg_FstLcase,
                objViewInfoENEx.TableNameForProg_FstUcase);
                //foreach(clsEditRegionFldsENEx objDetailFld in arrDetailFldSet)
                //{
                // strCode.AppendFormat("\r\n" + " <form-property name=\"{0}\" type=\"java.lang.String\" />",
                // objDetailFld.FldName_Java);
                //}
                //foreach(clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
                //{
                // strCode.AppendFormat("\r\n" + " <form-property name=\"{0}_query\" type=\"java.lang.String\" />",
                // objQryRegionFldsEx.FldName_Java);
                //}
                //strCode.Append("\r\n" + " <form-property name=\"rowid\" type=\"java.lang.String[]\" />");
                strCode.Append("\r\n" + " </form-bean>");
                strCode.Append("\r\n" + " </form-beans>");
                strCode.Append("\r\n" + " <action-mappings>");
                strCode.AppendFormat("\r\n" + " <action name=\"{0}.{1}Form\" parameter=\"method\" path=\"{2}/{1}Action\" scope=\"request\" type=\"{0}.{3}Action\">",
                objViewInfoENEx.PrjDomain,
                objViewInfoENEx.TableNameForProg_FstLcase,
                objViewInfoENEx.ActionPath,
                objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.AppendFormat("\r\n" + " <forward name=\"{0}\" path=\"{1}/{2}_add.jsp\" />",
                objViewInfoENEx.StutsActionMethod_Add,
                objViewInfoENEx.ActionPath,
                objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n" + " <forward name=\"{0}\" path=\"{1}/{2}_list.jsp\" />",
                objViewInfoENEx.StutsActionMethod_List,
                objViewInfoENEx.ActionPath,
                objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n" + " <forward name=\"{0}\" path=\"{1}/{2}_detail.jsp\" />",
                objViewInfoENEx.StutsActionMethod_Detail,
                objViewInfoENEx.ActionPath,
                objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n" + " <forward name=\"{0}\" path=\"{1}/{2}_update.jsp\" />",
                objViewInfoENEx.StutsActionMethod_Update,
                objViewInfoENEx.ActionPath,
                objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n" + " <forward name=\"{0}\" path=\"{1}/{2}_query.jsp\" />",
                objViewInfoENEx.StutsActionMethod_Query,
                objViewInfoENEx.ActionPath,
                objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n" + " <forward name=\"error\" path=\"/myerror.jsp\" />");
                strCode.AppendFormat("\r\n" + " <forward name=\"success\" path=\"{1}.do?method={0}\" />",
                objViewInfoENEx.StutsActionMethod_List,
                objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + " </action>");
                strCode.Append("\r\n" + " </action-mappings>");
                strCode.Append("\r\n" + "</struts-config>");
                strCode.Append("\r\n" + "");


            }
            catch (Exception ex)
            {
               clsGeneralTab2. LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            //������д���ļ���;
            //�����ļ������ļ����������ж��Ƿ����;
            strFolder = objComm.ParentDir(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            clsFile.CreateFileByString(strClassFName, strCode.ToString());
            return strCode.ToString();

        }




        //		public string GenViewCode()
        //		{
        //			switch(objViewInfoENEx.ViewTypeCode)
        //			{
        //				case "0001":	//�������
        //					return GenInsRecControlCode();
        //					//				case "0002":	//�����޸�
        //					//					return GenUpdRecControlCode();
        //				case "0003":	//�����ѯ
        //					return GenQueryRecControlCode();
        //				case "0004":	//�����QUDI
        //					return GenQueryUpdDelInsRecControlCode();
        //				case "0005":	//����Ĳ�ѯ����
        //					return GenQueryInsRecControlCode();
        //				case "0006":	//����Ĳ�ѯ�޸�
        //					return GenQueryUpdRecControlCode();
        //				case "0007":	//����Ĳ�ѯɾ��
        //					return GenQueryUpdDelRecControlCode();
        //					//					break;
        //			}
        //			return "";
        //		}
        public string A_GeneFuncCode(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {


                    case "GenGetTabRecListCode":
                        return GenGetTabRecListCode();
                    case "GenTabDetailRecCode":
                        return GenTabDetailRecCode();
                    case "GenGetTabRecDispListCode":
                        return GenGetTabRecDispListCode();
                    case "GenAddRecCode":
                        return GenAddRecCode();
                    case "GenUpdateRecCode":
                        return GenUpdateRecCode();
                    case "GenDeleteMultiRecCode":
                        return GenDeleteMultiRecCode();
                    case "GenDeleteRecCode":
                        return GenDeleteRecCode();
                    case "GenSetAllDictCode":
                        return GenSetAllDictCode();
                    case "GenClosePMCode":
                        return GenClosePMCode();
                    case "GenSetExcelReportCode":
                        return GenSetExcelReportCode();
                    //				case "LogError":
                    //					return gfunLogError();
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

    }
}