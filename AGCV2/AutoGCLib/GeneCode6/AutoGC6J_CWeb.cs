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
    /// 自动生成界面控制层的代码类(Control of MVC)
    /// </summary>
    public class AutoGC6J_CWeb : clsViewGroupBLEx
    {
        protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        public AutoGC6J_CWeb()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }

        //public AutoGC6J_CWeb(string strViewId)
        //    : base(strViewId)
        //{
        //    // 
        //    // TODO: 在此处添加构造函数逻辑
        //    //

        //}

        protected string mstrBackupFolderName; // '文件目录名
        /// <summary>
        /// 备份的文件目录
        /// </summary>
        public string BackupFolderName
        {
            get { return mstrBackupFolderName; }
            set { mstrBackupFolderName = value; }
        }
        protected string mstrFolderName_Root; // '根文件目录名

        public string FolderName_Root
        {
            get { return mstrFolderName_Root; }
            set { mstrFolderName_Root = value; }
        }
        /// <summary>
        /// 生成通用逻辑层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenActionCode(Encoding myEncoding, ref  string strResult, clsViewInfoENEx objViewInfoENEx)
        {
            //			if (objPrjTabENEx.TabFldNum == 0)
            //			{
            //				strResult = "当前表：" + objINPrjTab.TabName + "的字段数为0，无法生成通用逻辑层!";
            //				return strResult;
            //			}
            //			if (objPrjTabENEx.KeyFldNum == 0)
            //			{
            //				strResult = "当前表：" + objINPrjTab.TabName + "的关键字的个数为0，无法生成通用逻辑层!";
            //				return strResult;
            //			}

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放与WebForm相关的类文件代码;
            string strTemp;          ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("GenListRecCode");	//类中私有变量，也是私有属性
            arrFuncList.Add("GenCombineCondionCode");	//类的构造器1
            arrFuncList.Add("GenAddRecCode");	//类的构造器1
            arrFuncList.Add("GenAddSaveRecCode");	//类的构造器2
            arrFuncList.Add("GenUpdateRecCode");	//类的构造器3
            arrFuncList.Add("GenShowDataForUpdate");	//类的构造器3
            arrFuncList.Add("GenShowDataForDetail");	//类的构造器3

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
                ///类名开始
                ///
           
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName));

                ///包名
                strCodeForCs.AppendFormat("\r\n" + "package {0};",
                    objViewInfoENEx.PrjDomain);
                ///类名开始
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

                //私有属性名-----和属性过程
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

                //生成所有的函数

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

                //把生成写到文件中;
                //检查该文件名的文件夹名，并判断是否存在;
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
                        string strMsg = string.Format("文件：{0}已经存在！", strFindFileFullFile);
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
        /// 生成通用逻辑层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenActionFormCode(Encoding myEncoding, ref  string strResult, clsViewInfoENEx objViewInfoENEx)
        {
            //			if (objPrjTabENEx.TabFldNum == 0)
            //			{
            //				strResult = "当前表：" + objINPrjTab.TabName + "的字段数为0，无法生成通用逻辑层!";
            //				return strResult;
            //			}
            //			if (objPrjTabENEx.KeyFldNum == 0)
            //			{
            //				strResult = "当前表：" + objINPrjTab.TabName + "的关键字的个数为0，无法生成通用逻辑层!";
            //				return strResult;
            //			}

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放与WebForm相关的类文件代码;

            string ClsName = objViewInfoENEx.TableNameForProg_FstUcase + "Form";
            strClassFName = mstrFolderName + ClsName + ".java";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsByPrjId(objViewInfoENEx.PrjId);    //

      
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName));

                ///包名
                strCodeForCs.AppendFormat("\r\n" + "package {0};",
                    objViewInfoENEx.PrjDomain);
                ///类名开始
                //				strCodeForCs.Append("\r\n" +  "//import java.sql.*;");    //
                strCodeForCs.Append("\r\n" + "import java.util.*; ");    //
                strCodeForCs.Append("\r\n" + "import java.util.List;");
                strCodeForCs.Append("\r\n" + "import org.apache.struts.action.ActionForm;");
                //

                strCodeForCs.Append("\r\n" + "");    //
                strCodeForCs.Append("\r\n" + "public class " + ClsName + " extends ActionForm");
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "private static final long serialVersionUID = 1L;");
                strCodeForCs.Append("\r\n" + "private List selectList;");

                strCodeForCs.Append("\r\n" + "public List getSelectList() {");
                strCodeForCs.Append("\r\n" + "return selectList;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "public void setSelectList(List selectList) {");
                strCodeForCs.Append("\r\n" + "objViewInfoENEx.selectList = selectList;");
                strCodeForCs.Append("\r\n" + "}");
                //生成所有的函数

                strCodeForCs.Append(gfunClsPrivateVar(objViewInfoENEx));
                strCodeForCs.Append(gfunClsPrivateVar_Query(objViewInfoENEx));

                strCodeForCs.Append(gfunClsProperty(objViewInfoENEx));

                strCodeForCs.Append(gfunClsProperty_Query(objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "}");

                //把生成写到文件中;
                //检查该文件名的文件夹名，并判断是否存在;
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
                        string strMsg = string.Format("文件：{0}已经存在！", strFindFileFullFile);
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


        ///显示表的记录列表(list{0})
        public string GenListRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();
            try
            {
                strCode.Append("\r\n" + "//显示表的记录列表");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_List);
                strCode.Append("\r\n" + "     HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//操作步骤：");
                strCode.Append("\r\n" + "//第一步：获得form对象；");
                strCode.Append("\r\n" + "//第二步：获得登录人的记录信息");
                strCode.Append("\r\n" + "//第三步：获取当前登录的职工号，并存储在动态FORM中。动态FORM是一个存储各种变量的一个容器。");
                strCode.Append("\r\n" + "//第四步：根据查询条件字段值，动态配置sql语句；");
                strCode.Append("\r\n" + "//第五步：配置excel报表中的属性");
                strCode.Append("\r\n" + "//第六步：根据动态配置的SQL语句，获取查询结果的记录集，用XML方式的字符串表示。");
                strCode.Append("\r\n" + "//第七步：把查询结果的记录集，存在request的result中。");
                strCode.Append("\r\n" + "//第八步：显示查询列表页面(JSP页面)");

                strCode.Append("\r\n" + "//第一步：获得form对象；");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//第二步：获取当前登录的职工号，并存储在动态FORM中。动态FORM是一个存储各种变量的一个容器。");
                strCode.AppendFormat("\r\n" + "//String {0} = UserToken.getUser(request).getUserID();",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n" + "//存贮在动态FORM中");
                strCode.AppendFormat("\r\n" + "//{0}Form.set(\"{1}\", {1});",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.AppendFormat("\r\n //第三步：获得登录人的记录信息");
                strCode.AppendFormat("\r\n //StringBuffer sbSql = new StringBuffer({1}.list{0}Carder(",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.AppendFormat("\r\n // request, {0})); //列表sql，获得登陆人自己记录信息",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);

                strCode.Append("\r\n" + "//第四步：根据查询条件字段值，组合查询条件串；");
                strCode.Append("\r\n" + "ArrayList paramList = new ArrayList();");
                strCode.AppendFormat("\r\n" + "String strOrderby = \" {0} ASC\";",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n" + "//组合查询条件串");
                strCode.AppendFormat("\r\n" + "String strWhereCond = Combine{0}Condion(form, request, paramList,",
                    objViewInfoENEx.TableNameForProg);
                strCode.Append("\r\n" + "strOrderby);");
                strCode.Append("\r\n        Object[] params = new Object[paramList.size()];");
                strCode.Append("\r\n paramList.toArray(params);");

                strCode.Append("\r\n //第五步：根据动态配置的SQL语句，获取查询结果的记录集，用XML方式的字符串表示。");

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
                strCode.Append("\r\n arrError.add(\"在从数据库调数据列表时出现错误!\");");
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
                strCode.Append("\r\n //第六步：配置excel报表中的属性");
                strCode.AppendFormat("\r\n //{0}.setExcelReport(strWhereCond, paramList, request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);

                strCode.Append("\r\n //第七步：把查询结果的记录集，存在request的result中。");
                strCode.AppendFormat("\r\n request.setAttribute(\"result\", arr{1}ObjList);",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCode.Append("\r\n //第八步：显示查询列表页面(JSP页面)");
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

        ///显示表的记录列表(list{0})
        public string GenCombineCondionCode(clsViewInfoENEx objViewInfoENEx)
        {
            string strTemp;
            StringBuilder strCode = new StringBuilder();
            try
            {

                strCode.Append("\r\n" + "// 把所有的查询控件内容组合成一个条件串");

                strCode.AppendFormat("\r\n" + "private String Combine{0}Condion(ActionForm form,",
                    objViewInfoENEx.TableNameForProg);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "ArrayList<String> paramList,");
                strCode.Append("\r\n" + "String strOrderby) {");

                strCode.Append("\r\n" + "//使条件串的初值为\"1=1\"，以便在该串的后面用\"and \"添加其他条件,");
                strCode.Append("\r\n" + "//例如 1=1 && UserName = '张三'");

                strCode.Append("\r\n" + "//操作步骤：");
                strCode.Append("\r\n" + "//第一步：获得form对象；");
                strCode.Append("\r\n" + "//第二步：获得session对象,并对session对象进行初始化");
                strCode.Append("\r\n" + "//第三步：从动态FORM中获取所有查询字段的值。");
                strCode.Append("\r\n" + "//     3.1 如果有查询字段的值,就设置到查询模型对象中，同时存储在Session中；");
                strCode.Append("\r\n" + "//     3.2 否则就从session中去获取查询模型对象，");
                strCode.Append("\r\n" + "//        3.2.1 如果查询模型对象不为NULL，说明曾经存储过查询模型对象的值，");
                strCode.Append("\r\n" + "//                 就从Session的查询模型对象中获取查询字段的值。");
                strCode.Append("\r\n" + "//     说明：通过对(idtemp_query != null的检查就可以知道在");
                strCode.Append("\r\n" + "//          request中是否有查询字段的值。");
                strCode.Append("\r\n" + "//第四步：根据查询条件字段值，动态配置sql语句；");

                strCode.Append("\r\n" + "//第一步：获得form对象；");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
    objViewInfoENEx.TableNameForProg_FstLcase,
     objViewInfoENEx.TableNameForProg_FstUcase);

                strCode.Append("\r\n" + "//第二步：获得session对象,并对session对象进行初始化");
                strCode.Append("\r\n" + "//获得session对象");
                strCode.Append("\r\n" + "HttpSession session = request.getSession();");
                strCode.Append("\r\n" + "//对session进行初始化，即移除 session中的所有变量");
                //strCode.Append("\r\n" +  "if (\"true\".equals(request.getParameter(\"needinit\"))) {");
                //strCode.Append("\r\n" +  "session.removeAttribute(QueryModel.ATT_NAME);");
                //strCode.Append("\r\n" +  "}");

                strCode.AppendFormat("\r\n //第三步：从动态FORM中获取所有查询字段的值。");
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
                strCode.Append("\r\n //定义一个查询模块对象qm");
                strCode.Append("\r\n QueryModel qm;");
                strCode.Append("\r\n //     3.1 如果有查询字段的值,就设置到查询模型对象中，同时存储在Session中；");
                strCode.AppendFormat("\r\n if ({0}temp_query != null) ",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n {");
                strCode.AppendFormat("\r\n //     说明：通过对({0}temp_query != null的检查就可以知道在",
                    objViewInfoENEx. objMainTabKeyFld.FldName_Java);
                strCode.Append("\r\n //          request中是否有查询字段的值。");
                strCode.Append("\r\n qm = new QueryModel(");
                strCode.AppendFormat("\r\n \"{1}.{0}Form\"); //模块名可以写成常量。",
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
                strCode.Append("\r\n //     3.2 否则就从session中去获取查询模型对象，");

                strCode.Append("\r\n qm = (QueryModel) session.getAttribute(QueryModel.ATT_NAME);");
                strCode.Append("\r\n if (qm != null) {");
                strCode.Append("\r\n //        3.2.1 如果查询模型对象不为NULL，说明曾经存储过查询模型对象的值，");
                strCode.Append("\r\n //                 就从Session的查询模型对象中获取查询字段的值。");
                strCode.AppendFormat("\r\n if (! (\"{1}.{0}Form\".equals(qm.getModuleName()))) ",
                    objViewInfoENEx.TableNameForProg,
                    objViewInfoENEx.PrjDomain);
                strCode.Append("\r\n {");
                strCode.Append("\r\n session.removeAttribute(QueryModel.ATT_NAME); //更换模块则清掉原来的session.");
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


                strCode.Append("\r\n //第四步：根据查询条件字段值，动态配置sql语句；");
                strCode.Append("\r\n //根据查询条件动态配置sql语句");

                strCode.Append("\r\n StringBuffer sbWhereCond = new StringBuffer();");
                strCode.Append("\r\n sbWhereCond.append(\" 1=1 \");");
                strCode.Append("\r\n //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。");

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


        ///生成添加记录代码;(Add{0})
        public string GenAddRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//添加记录的函数。主要用于在显示添加记录页面前初始化一些数据，作为页面的初始值");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Add);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//设置所有的下拉框所需要的数据字典，即值-名称的数据集(DataSet).");
                strCode.AppendFormat("\r\n" + "{0}Manager.setAllDict(request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n" + "//获取动态FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
    objViewInfoENEx.TableNameForProg_FstLcase,
     objViewInfoENEx.TableNameForProg_FstUcase);

                strCode.Append("\r\n" + "//通过用户令牌(UserToken)获取当前登录的用户ID");
                strCode.Append("\r\n" + "//String strUserId = UserToken.getUserid(request);");
                strCode.Append("\r\n" + "//获取当前职工号(zgh)的相关信息，存储在数据集(DataSet)中。");
                strCode.Append("\r\n" + "//页面跳转到添加请假的页面");
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
        ///生成显示记录代码;(ShowData)
        public string GenShowData(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 函数功能：把以该关键字的记录内容显示在界面上，");
                strCodeForCs.Append("\r\n" + "///　　　     在这里是把值传到表控件中");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">表记录的关键字，显示该表关键字的内容</param>",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "private void ShowData({0} {1}, ActionForm form,	HttpServletRequest request, HttpServletResponse response)",
            objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);

                strCodeForCs.Append("\r\n" + " throws Exception, SQLException, ClassNotFoundException {");
                strCodeForCs.Append("\r\n" + "//操作步骤：");
                strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在，如果不存在就返回不显示；");
                strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上，在这里显示在表控件中");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "long" || objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//如果关键字为空就返回退出",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//如果关键字为空就返回退出",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在，如果不存在就返回不显示；");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == false)		//检查该关键字的记录是否存在",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String ss = \"关键字为：\" + {0} + \"的不存在!\";",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//response.Write(\"<script>alert('\" + ss + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0} = new cls{0}({1});",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
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
                strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上，在这里显示在表控件中");
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}, form);",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///生成把类对象的属性内容显示到界面上;
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
                ///生成仅有变量;
              
                strCode.Append("\r\n" + "/// <summary>");
                strCode.Append("\r\n" + "/// 函数功能：把类对象的属性内容显示到界面上");
                strCode.Append("\r\n" + "///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值");
                strCode.Append("\r\n" + "///      如果在设置数据库时，就应该一级字段在前，二级字段在后");
                strCode.Append("\r\n" + "/// </summary>");
                strCode.AppendFormat("\r\n" + "/// <param name=\"pobj{0}\">表实体类对象</param>",
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

        ///生成显示记录代码;(ShowData)
        public string GenShowDataForUpdate(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.AppendFormat("\r\n" + " * 功能:针对修改记录显示某条记录的数据,该记录的关键字值为:{0}",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + " * @param {0}:记录的关键字值",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + " * @param form:传递值用的FORM");
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
                strCodeForCs.Append("\r\n" + "//操作步骤：");
                strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在，如果不存在就返回不显示；");
                strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上，在这里显示在表控件中");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "long" || objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//如果关键字为空就返回退出",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//如果关键字为空就返回退出",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在，如果不存在就返回不显示；");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == false)		//检查该关键字的记录是否存在",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String ss = \"关键字为：\" + {0} + \"的不存在!\";",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//response.Write(\"<script>alert('\" + ss + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0} = new cls{0}({1});",
                    objViewInfoENEx.objINPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
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
                strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上，在这里显示在表控件中");
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}ClassForUpdate(obj{0}, form);",
                    objViewInfoENEx.objINPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///生成把类对象的属性内容显示到界面上;
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

        ///生成显示记录代码;(ShowData)
        public string GenShowDataForDetail(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.AppendFormat("\r\n" + " * 功能:针对显示详细信息的显示某条记录的数据,该记录的关键字值为:{0}",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + " * @param {0}:记录的关键字值",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + " * @param form:传递值用的FORM");
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
                strCodeForCs.Append("\r\n" + "//操作步骤：");
                strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在，如果不存在就返回不显示；");
                strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上，在这里显示在表控件中");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                if (objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "long" || objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.CSType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//如果关键字为空就返回退出",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//如果关键字为空就返回退出",
                        objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在，如果不存在就返回不显示；");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}.IsExist({1}) == false)		//检查该关键字的记录是否存在",
                    objViewInfoENEx.objOUTPrjTab.TabName, objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "String ss = \"关键字为：\" + {0} + \"的不存在!\";",
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//response.Write(\"<script>alert('\" + ss + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0} = new cls{0}({1});",
                    objViewInfoENEx.objOUTPrjTab.TabName,
                    objViewInfoENEx. objMainTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
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
                strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上，在这里显示在表控件中");
                strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}ClassForDetail(obj{0}, form);",
                    objViewInfoENEx.objOUTPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "}");
                ///生成把类对象的属性内容显示到界面上;
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
                ///生成仅有变量;
           
                strCode.Append("\r\n" + "/// <summary>");
                strCode.Append("\r\n" + "/// 函数功能：把类对象的属性内容显示到界面上");
                strCode.Append("\r\n" + "///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值");
                strCode.Append("\r\n" + "///      如果在设置数据库时，就应该一级字段在前，二级字段在后");
                strCode.Append("\r\n" + "/// </summary>");
                strCode.AppendFormat("\r\n" + "/// <param name=\"pobj{0}\">表实体类对象</param>",
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
                ///生成仅有变量;
  
                strCode.Append("\r\n" + "/// <summary>");
                strCode.Append("\r\n" + "/// 函数功能：把类对象的属性内容显示到界面上");
                strCode.Append("\r\n" + "///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值");
                strCode.Append("\r\n" + "///      如果在设置数据库时，就应该一级字段在前，二级字段在后");
                strCode.Append("\r\n" + "/// </summary>");
                strCode.AppendFormat("\r\n" + "/// <param name=\"pobj{0}\">表实体类对象</param>",
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


        ///生成添加记录代码;(Add{0})
        public string GenAddSaveRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//添加记录保存函数");
                strCode.AppendFormat("\r\n" + " public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_AddSave);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//获取动态FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
    objViewInfoENEx.TableNameForProg_FstLcase,
     objViewInfoENEx.TableNameForProg_FstUcase);

                strCode.Append("\r\n" + "//获取关键字值");
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

                strCode.Append("\r\n" + "//设置<返回>页面的URL，以便在添加成功的页面上返回到列表页面。");
                strCode.Append("\r\n" + "request.getSession().setAttribute(\"backurl\",");
                strCode.AppendFormat("\r\n" + "\"{2}.do?method={0}\");",
                    objViewInfoENEx.StutsActionMethod_List,
                    objViewInfoENEx.ActionPath,
                    objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + "//页面跳转到添加成功的页面");
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

        ///生成修改记录代码;(Update{0})
        public string GenUpdateRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//修改记录的初始化函数");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Update);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//获取动态FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n try");
                strCode.Append("\r\n {");
                strCode.Append("\r\n" + "//设置所有的下拉框所需要的数据字典，即值-名称的数据集(DataSet).");
                strCode.AppendFormat("\r\n" + "{0}Manager.setAllDict(request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n }");
                strCode.Append("\r\n catch (SQLException objException)");
                strCode.Append("\r\n {");
                //	request.setAttribute("error", objException.getMessage());

                strCode.Append("\r\n ArrayList<String> arrError = new ArrayList<String>();");
                strCode.Append("\r\n arrError.add(\"在获取下拉框数据源时出现错误!\");");
                strCode.Append("\r\n if (objException.getMessage() != null)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n arrError.add(objException.getMessage());");
                strCode.Append("\r\n }");
                strCode.Append("\r\n request.setAttribute(\"error\", arrError);");
                strCode.Append("\r\n return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.Append("\r\n" + "//获取界面中需要修改的关键字值列表。从动态FORM中获取所有选择的行号列表，");
                strCode.Append("\r\n" + "//      行号就是标识该行的关键字值。");
                strCode.Append("\r\n" + "//   只修改列表中的第一行。");
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


                // 把数据集的所有属性都存储在动态FORM，以便传输给VIEW。
                strCode.AppendFormat("\r\n" + "ShowDataForUpdate({2}, form, request, response);",
                    objViewInfoENEx.objINPrjTab.TabName,
                     objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.PrivFuncName);


                strCode.Append("\r\n" + "//页面跳转到修改记录的页面");
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
        ///生成修改保存记录代码;(Update{0}Save)
        public string GenUpdateSaveRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//修改记录保存函数");
                strCode.AppendFormat("\r\n" + " public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_UpdateSave);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//获取动态FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//获取关键字值");
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

                strCode.Append("\r\n" + "//设置<返回>页面的URL，以便在修改成功的页面上返回到列表页面。");
                strCode.Append("\r\n" + "request.getSession().setAttribute(\"backurl\",");
                strCode.AppendFormat("\r\n" + "\"{2}.do?method={0}\");",
                    objViewInfoENEx.StutsActionMethod_List,
                    objViewInfoENEx.ActionPath,
                    objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + "//页面跳转到修改成功的页面");
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

        ///生成删除记录代码;(delete{表名})
        public string GenDeleteRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//删除记录的函数");
                strCode.AppendFormat("\r\n" + " public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Delete);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//获取动态FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//获取需要删除的关键字值列表。从动态FORM中获取所有选择的行号列表，");
                strCode.Append("\r\n" + "//      行号就是标识该行的关键字值。");
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
                strCode.Append("\r\n" + "//删除所选行的所有记录");
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
                strCode.Append("\r\n arrError.add(\"在删除表记录时出现错误!\");");
                strCode.Append("\r\n if (objException.getMessage() != null)");
                strCode.Append("\r\n {");
                strCode.Append("\r\n arrError.add(objException.getMessage());");
                strCode.Append("\r\n }");
                strCode.Append("\r\n request.setAttribute(\"error\", arrError);");
                strCode.Append("\r\n return map.findForward(\"error\");");
                strCode.Append("\r\n }");

                strCode.Append("\r\n" + "//设置<返回>页面的URL，以便在删除成功的页面上返回到列表页面。");
                strCode.Append("\r\n" + "request.getSession().setAttribute(\"backurl\",");
                strCode.AppendFormat("\r\n" + "\"{2}.do?method={0}\");",
                    objViewInfoENEx.StutsActionMethod_List,
                    objViewInfoENEx.ActionPath,
                    objViewInfoENEx.StutsActionObject);
                strCode.Append("\r\n" + "//页面跳转到删除成功的页面");
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

        ///生成记录详细信息代码;(detail{0})
        public string GenDetailRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//显示详细信息的初始化函数");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Detail);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//获取动态FORM");
                strCode.AppendFormat("\r\n" + "{1}Form {0}Form = ({1}Form) form;",
                    objViewInfoENEx.TableNameForProg_FstLcase,
                     objViewInfoENEx.TableNameForProg_FstUcase);
                strCode.Append("\r\n" + "//获取界面中需要修改的关键字值列表。从动态FORM中获取所有选择的行号列表，");
                strCode.Append("\r\n" + "//      行号就是标识该行的关键字值。");
                strCode.Append("\r\n" + "//   只显示列表中的第一行。");
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

                // 把数据集的所有属性都存储在动态FORM，以便传输给VIEW。
                strCode.AppendFormat("\r\n" + "ShowDataForDetail({0}, form, request, response);",
                    objViewInfoENEx.objDetailTabKeyFld.objFieldTabENEx.PrivFuncName);
                strCode.Append("\r\n" + "//页面跳转到显示记录详细信息的页面");
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

        ///生成查询记录初始化函数代码;(query{0})
        public string GenQueryRecCode(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCode = new StringBuilder();

            try
            {
                strCode.Append("\r\n" + "//显示详细信息的初始化函数");
                strCode.AppendFormat("\r\n" + "public ActionForward {0}(ActionMapping map, ActionForm form,",
                    objViewInfoENEx.StutsActionMethod_Query);
                strCode.Append("\r\n" + "HttpServletRequest request,");
                strCode.Append("\r\n" + "HttpServletResponse response) throws");
                strCode.Append("\r\n" + "Exception {");
                strCode.Append("\r\n" + "//设置所有下拉框控件的{值、名称}字典数据列表。");
                strCode.AppendFormat("\r\n" + "{0}Manager.setAllDict(request);",
                    objViewInfoENEx.TableNameForProg_FstLcase);
                strCode.Append("\r\n" + "//页面跳转到查询记录的页面");
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
                        return "///该函数不存在:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数：{0}时出错. \r\n出错信息：{1}.", strFuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }
        /// <summary>
        /// 类的私有变量，用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar(clsViewInfoENEx objViewInfoENEx)
        {
            Hashtable hsTab = new Hashtable();
            StringBuilder strBuilder = new StringBuilder();
            ///定义类中私有属性
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
        /// 类的私有变量，用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar_Query(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类中私有属性
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
            {

                strBuilder.AppendFormat("\r\n protected {0} {1}_query;	//{2}用于查询",
             objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objComm.FstLcase(objQryRegionFldsEx.objPrjTabFldENEx.FldName_Java),
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption);
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string gfunClsProperty(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
            ///
            Hashtable hsTab = new Hashtable();
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrINTabFldSet)
            {

                string strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                objComm.FstUcase(ref strTemp);
                strBuilder.AppendFormat("\r\n //获取{0}({1})的值",
                    objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()",
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};",
                    objComm.FstLcase(objPrjTabFldENEx.FldName_Java));
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //设置{0}({1})的值",
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
                strBuilder.AppendFormat("\r\n //获取{0}({1})的值",
                    objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()",
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};",
                    objComm.FstLcase(objPrjTabFldENEx.FldName_Java));
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //设置{0}({1})的值",
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
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string gfunClsProperty_Query(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
            ///
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet_Query)
            {

                string strTemp = objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName_Java;
                objComm.FstUcase(ref strTemp);
                strBuilder.AppendFormat("\r\n //获取{0}({1})的值",
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.Caption,
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}_query()",
                    objQryRegionFldsEx.objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0}_query;",
                    objComm.FstLcase(objQryRegionFldsEx.objPrjTabFldENEx.FldName_Java));
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //设置{0}({1})的值",
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
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string GenGetSelecedList(clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
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