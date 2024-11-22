using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.sql;
using AGC_CSV7.Entity;
using com.taishsoft.datetime;
using AGC_CSV7.BusinessLogic;

namespace AGC_CSV7.BusinessLogicEx
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    public class AutoGC7Cs_WS : AutoGCPubFuncV7
    {
        //protected //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

       

        /// <summary>
        /// 类文件名
        /// </summary>
        public string ClsFName
        {
            get { return mstrClsFName; }
            set { mstrClsFName = value; }
        }



        #region 构造函数

        public AutoGC7Cs_WS()
        {
            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);

            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public AutoGC7Cs_WS(string strViewId, string strPrjDataBaseId)
            : base(strViewId, strPrjDataBaseId)
        {
            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);

            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion

        /// <summary>
        /// 生成通用逻辑层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCode()
        {
            string strResult;
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                  objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();

            arrFuncList.Add("GetDataSet");
            arrFuncList.Add("GetDataSetV");
            arrFuncList.Add("GetRecordProperty");
            arrFuncList.Add("GetRecordPropertyV");
            arrFuncList.Add("IsExistRecordByCond");
            arrFuncList.Add("IsExist");
            arrFuncList.Add("Gen_GetMaxStrId");
            arrFuncList.Add("AddNewRecordBySql2");
            arrFuncList.Add("Gen_AddNewRecordBySql_XML");
            arrFuncList.Add("UpdateBySql2");
            arrFuncList.Add("Gen_UpdateBySql_XML");
            arrFuncList.Add("DelRecord");
            arrFuncList.Add("DelMultiRecord");
            arrFuncList.Add("DelMultiRecordByCond");
            arrFuncList.Add("ExposeLogicClass");
            arrFuncList.Add("Gen_Ws_SerializeObjToXMLStr");
            arrFuncList.Add("Gen_Ws_SerializeObjListToXMLStr");

            //arrFuncList.Add("ExposeLogicExClass");

            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            strClassFName = mstrFolderName + objPrjTabENEx.ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services.Protocols;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                    objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}_WS",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}Service 的摘要说明",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class {0}Service : System.Web.Services.WebService",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //生成所有的函数
                foreach (string strFuncName in arrFuncList)
                {
                    strTemp = A_GeneFuncCode(strFuncName);
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //把生成写到文件中;
                //检查该文件名的文件夹名,并判断是否存在;
                strFolder = clsString.ParentDir_S(strClassFName);
                if (System.IO.Directory.Exists(strFolder)  ==  false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN.IsBackupForGeneCode  ==  true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                    {
                        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                        throw new Exception(strMsg);
                    }
                }
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString());
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成通用逻辑层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCode4View()
        {
            string strResult;
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();

            arrFuncList.Add("GetDataSet");
            arrFuncList.Add("GetDataSetV");
            arrFuncList.Add("GetRecordProperty");
            arrFuncList.Add("GetRecordPropertyV");
            arrFuncList.Add("IsExistRecordByCond");
            arrFuncList.Add("IsExist");
            arrFuncList.Add("ExposeLogicClass");
            //arrFuncList.Add("ExposeLogicExClass");
            arrFuncList.Add("Gen_Ws_SerializeObjToXMLStr");
            arrFuncList.Add("Gen_Ws_SerializeObjListToXMLStr");

            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            strClassFName = mstrFolderName + objPrjTabENEx.ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services.Protocols;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                    objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}_WS",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}Service 的摘要说明",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class {0}Service : System.Web.Services.WebService",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //生成所有的函数
                foreach (string strFuncName in arrFuncList)
                {
                    strTemp = A_GeneFuncCode(strFuncName);
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //把生成写到文件中;
                //检查该文件名的文件夹名,并判断是否存在;
                strFolder = clsString.ParentDir_S(strClassFName);
                if (System.IO.Directory.Exists(strFolder)  ==  false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN.IsBackupForGeneCode  ==  true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                    {
                        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                        throw new Exception(strMsg);
                    }
                }
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString());
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceTransCode()
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            if (objPrjTabENEx.IsForSilverLight  ==  true)
            {
                arrFuncList.Add("Gen_4Ws_ClassConstructor1");	//类的构造器1

                //arrFuncList.Add("Gen_4Ws_GetRecordProperty4Object");
                //arrFuncList.Add("Gen_4Ws_CondRecObjList");
                arrFuncList.Add("Gen_4Ws_DelRecord_SL");
                //arrFuncList.Add("Gen_4Ws_DelMultiRecord");
                arrFuncList.Add("Gen_4Ws_DelMultiRecordByCond_SL");
                arrFuncList.Add("Gen_4Ws_AddNewRecordBySql_SL");
                arrFuncList.Add("Gen_4Ws_UpdateBySql_SL");
                arrFuncList.Add("Gen_4Ws_IsExistRecord_SL");
                arrFuncList.Add("Gen_4Ws_IsExist_SL");
                arrFuncList.Add("Gen_4Ws_GetMaxStrId_SL");
                arrFuncList.Add("Gen_4Ws_SerializeObjToXMLStr_SL");
                arrFuncList.Add("Gen_4Ws_SerializeObjListToXMLStr_SL");
                
            }
            else
            {
                arrFuncList.Add("Gen_4Ws_ClassConstructor1");	//类的构造器1
                arrFuncList.Add("GenComboBoxBindFunction");		//类索引器
                arrFuncList.Add("GenDdlBindFunction");		//类索引器
                arrFuncList.Add("GenBindListView");		//类索引器

                arrFuncList.Add("Gen_4Ws_GetDataTable4Tab");
                arrFuncList.Add("Gen_4Ws_GetDataTable4TabV");
                arrFuncList.Add("Gen_4Ws_GetDataTable4TabV2");
                arrFuncList.Add("Gen_4Ws_GetRecordProperty4Object");
                arrFuncList.Add("Gen_4Ws_CondRecObjList");
                arrFuncList.Add("Gen_4Ws_DelRecord");
                arrFuncList.Add("Gen_4Ws_DelMultiRecord");
                arrFuncList.Add("Gen_4Ws_DelMultiRecordByCond");
                arrFuncList.Add("Gen_4Ws_AddNewRecordBySql2");
                arrFuncList.Add("Gen_4Ws_UpdateBySql2");
                arrFuncList.Add("Gen_4Ws_IsExistRecord");
                arrFuncList.Add("Gen_4Ws_IsExist");
                arrFuncList.Add("Gen_4Ws_GetMaxStrId");
            }
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "WS";
            objPrjTabENEx.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;


            strClassFName = mstrFolderName + objPrjTabENEx.ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                ///类名开始
                if (objPrjTabENEx.IsForSilverLight  ==  true)
                {
                    strCodeForCs.Append("\r\n" + "using System;"); //
                    strCodeForCs.Append("\r\n" + "using System.Text; "); //
                    strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                    strCodeForCs.Append("\r\n" + "using System.Collections.Generic;"); //

                    strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //                
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "using System;"); //
                    strCodeForCs.Append("\r\n" + "using System.Data; "); //
                    strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                    strCodeForCs.Append("\r\n" + "using System.Text; "); //
                    strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                    strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                    strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //
                }
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}4WS",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                if (objPrjTabENEx.IsForSilverLight  ==  true)
                {
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 获取当前表的最大关键字值");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_GetMaxStrIdHandle(object sender, {0}_GetMaxStrIdCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 是否存在记录");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_IsExistHandle(object sender, {0}_IsExistCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 是否存在条件记录");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_IsExistRecordByCondHandle(object sender, {0}_IsExistRecordByCondCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 添加记录");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_AddNewRecordBySql_XMLHandle(object sender, {0}_AddNewRecordBySql_XMLCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 修改记录");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_UpdateBySql_XMLHandle(object sender, {0}_UpdateBySql_XMLCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 删除一条记录");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_DelRecordHandle(object sender, {0}_DelRecordCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 删除满足条件的记录");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_Del{0}sByCondHandle(object sender, {0}_Del{0}sByCondCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 序列化一个记录到XML串中");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_SerializeObjToXMLStrHandle(object sender, {0}_SerializeObjToXMLStrCompletedEventArgs e);",
                    objPrjTabENEx.TabName);
    strCodeForCs.AppendFormat("\r\n /// <summary>");
    strCodeForCs.AppendFormat("\r\n /// 序列化记录列表到XML串中");
    strCodeForCs.AppendFormat("\r\n /// </summary>");
    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_SerializeObjListToXMLStrHandle(object sender, {0}_SerializeObjListToXMLStrCompletedEventArgs e);",
                    objPrjTabENEx.TabName);


                }
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                if (objPrjTabENEx.IsForSilverLight  ==  true)
                {

        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 获取当前表的最大关键字值");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_GetMaxStrIdHandle Event{0}_GetMaxStrId;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 是否存在记录");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_IsExistHandle Event{0}_IsExist;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 是否存在条件记录");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_IsExistRecordByCondHandle Event{0}_IsExistRecordByCond;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 添加记录");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_AddNewRecordBySql_XMLHandle Event{0}_AddNewRecordBySql_XML;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 修改记录");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_UpdateBySql_XMLHandle Event{0}_UpdateBySql_XML;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 删除一条记录");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_DelRecordHandle Event{0}_DelRecord;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 删除满足条件的记录");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_Del{0}sByCondHandle Event{0}_Del{0}sByCond;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 序列化一个对象记录到XML串中");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_SerializeObjToXMLStrHandle Event{0}_SerializeObjToXMLStr;//声明一个事件",
                    objPrjTabENEx.TabName);
        strCodeForCs.AppendFormat("\r\n /// <summary>");
        strCodeForCs.AppendFormat("\r\n /// 序列化记录列表到XML串中");
        strCodeForCs.AppendFormat("\r\n /// </summary>");
        strCodeForCs.AppendFormat("\r\n" + "public event {0}_SerializeObjListToXMLStrHandle Event{0}_SerializeObjListToXMLStr;//声明一个事件",
                    objPrjTabENEx.TabName);


                }
                //私有属性名-----和属性过程
                strCodeForCs.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient  ==  null)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strCodeForCs.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strCodeForCs.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strCodeForCs.Append("\r\n" + "if (clsSysParaEN.bolIsLocalHost  ==  false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{0}0{1}/{0}1{1}/{2}Service.asmx\", clsSysParaEN.strCurrIPAddressAndPort, clsSysParaEN.strCurrPrx);",
                    "{", "}", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{0}0{1}/{2}Service.asmx\", clsSysParaEN.strCurrIPAddressAndPort_Local);",
                    "{", "}", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strCodeForCs.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                //生成所有的函数

                foreach (string strFuncName in arrFuncList)
                {
                    strTemp = A_GeneFuncCode(strFuncName);
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //把生成写到文件中;
                //检查该文件名的文件夹名,并判断是否存在;
                strFolder = clsString.ParentDir_S(strClassFName);
                if (System.IO.Directory.Exists(strFolder)  ==  false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN.IsBackupForGeneCode  ==  true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                    {
                        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                        throw new Exception(strMsg);

                    }
                }
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString());
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceTransCode4View()
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();

            if (objPrjTabENEx.IsForSilverLight  ==  true)
            {
                arrFuncList.Add("Gen_4Ws_ClassConstructor1");	//类的构造器1

                arrFuncList.Add("Gen_4Ws_IsExistRecord_SL");
                arrFuncList.Add("Gen_4Ws_IsExist_SL");
                arrFuncList.Add("Gen_4Ws_SerializeObjToXMLStr_SL");
                arrFuncList.Add("Gen_4Ws_SerializeObjListToXMLStr_SL");

            }
            else
            {

            arrFuncList.Add("Gen_4Ws_ClassConstructor1");	//类的构造器1
            arrFuncList.Add("GenComboBoxBindFunction");		//类索引器
            arrFuncList.Add("GenDdlBindFunction");		//类索引器
            arrFuncList.Add("GenBindListView");		//类索引器

            arrFuncList.Add("Gen_4Ws_GetDataTable4Tab");
            arrFuncList.Add("Gen_4Ws_GetDataTable4TabV");
            arrFuncList.Add("Gen_4Ws_GetDataTable4TabV2");
            arrFuncList.Add("Gen_4Ws_GetRecordProperty4Object");
            arrFuncList.Add("Gen_4Ws_CondRecObjList");
            arrFuncList.Add("Gen_4Ws_IsExistRecord");
            arrFuncList.Add("Gen_4Ws_IsExist");

            }

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "WS";
            objPrjTabENEx.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;


            strClassFName = mstrFolderName + objPrjTabENEx.ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                ///类名开始
                ///
                if (objPrjTabENEx.IsForSilverLight  ==  true)
                {
                    strCodeForCs.Append("\r\n" + "using System;"); //
                    strCodeForCs.Append("\r\n" + "using System.Text; "); //
                    strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                    strCodeForCs.Append("\r\n" + "using System.Collections.Generic;"); //

                    strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //                
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "using System;"); //
                    strCodeForCs.Append("\r\n" + "using System.Data; "); //
                    strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                    strCodeForCs.Append("\r\n" + "using System.Text; "); //
                    strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                    strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                    strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //
                }

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}4WS",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                if (objPrjTabENEx.IsForSilverLight  ==  true)
                {
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 是否存在记录");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_IsExistHandle(object sender, {0}_IsExistCompletedEventArgs e);",
                                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 是否存在条件记录");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_IsExistRecordByCondHandle(object sender, {0}_IsExistRecordByCondCompletedEventArgs e);",
                                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 序列化一个记录到XML串中");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_SerializeObjToXMLStrHandle(object sender, {0}_SerializeObjToXMLStrCompletedEventArgs e);",
                                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 序列化记录列表到XML串中");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public delegate void {0}_SerializeObjListToXMLStrHandle(object sender, {0}_SerializeObjListToXMLStrCompletedEventArgs e);",
                                    objPrjTabENEx.TabName);


                }
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                if (objPrjTabENEx.IsForSilverLight  ==  true)
                {

                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 是否存在记录");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public event {0}_IsExistHandle Event{0}_IsExist;//声明一个事件",
                                objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 是否存在条件记录");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public event {0}_IsExistRecordByCondHandle Event{0}_IsExistRecordByCond;//声明一个事件",
                                objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 序列化一个对象记录到XML串中");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public event {0}_SerializeObjToXMLStrHandle Event{0}_SerializeObjToXMLStr;//声明一个事件",
                                objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 序列化记录列表到XML串中");
                    strCodeForCs.AppendFormat("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public event {0}_SerializeObjListToXMLStrHandle Event{0}_SerializeObjListToXMLStr;//声明一个事件",
                                objPrjTabENEx.TabName);


                }
                //私有属性名-----和属性过程
                strCodeForCs.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient  ==  null)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strCodeForCs.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strCodeForCs.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strCodeForCs.Append("\r\n" + "if (clsSysParaEN.bolIsLocalHost  ==  false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{0}0{1}/{0}1{1}/{2}Service.asmx\", clsSysParaEN.strCurrIPAddressAndPort, clsSysParaEN.strCurrPrx);",
                    "{", "}", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{0}0{1}/{2}Service.asmx\", clsSysParaEN.strCurrIPAddressAndPort_Local);",
                    "{", "}", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strCodeForCs.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                
                //生成所有的函数

                foreach (string strFuncName in arrFuncList)
                {
                    strTemp = A_GeneFuncCode(strFuncName);
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //把生成写到文件中;
                //检查该文件名的文件夹名,并判断是否存在;
                strFolder = clsString.ParentDir_S(strClassFName);
                if (System.IO.Directory.Exists(strFolder)  ==  false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN.IsBackupForGeneCode  ==  true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                    {
                        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                        throw new Exception(strMsg);
                    }
                }
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString());
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        private string AccessNull(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            return AccessNull("objDT.Rows[0][\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
        }
        private string AccessNull2(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
        }
        private string AccessNull(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToFloat_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "Int16":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.common.clsTranslate.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable  ==  true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable  ==  true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        private string Mark(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            {
                return "\"\'\"";
            }
            else
            {
                return "\"\"";
            }

        }


        //拼装关键字的WHERE串
        private string KeyWhereStr()
        {
            bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName + " = \" + " + Mark(objPrjTabFldENEx) + "+ " + (isNeed_m  ==  true ? "m" : "") + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + "+" + Mark(objPrjTabFldENEx);
                if (i  ==  0)	//是否是第一次
                {
                    WhereStr +=  strTemp;
                }
                else
                {
                    WhereStr +=  " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }

        private string KeyWhereStr(bool isNeed_m)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName + " = \" + " + Mark(objPrjTabFldENEx) + "+ " + (isNeed_m  ==  true ? "m" : "") + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + "+" + Mark(objPrjTabFldENEx);
                ///'strTemp = objPrjTabENEx.arrKeyFldSet[i].ColumnName + " = \"" + Mark(objPrjTabENEx.arrKeyFldSet[i]) + "+ " + "m" + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + Mark(objPrjTabENEx.arrKeyFldSet[i])
                if (i  ==  0)	//是否是第一次
                {
                    WhereStr +=  strTemp;
                }
                else
                {
                    WhereStr +=  " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }



        private string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.PrivPropName + " = " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                strPara +=  "\r\n" + strTemp;
            }
            return strPara;
        }
        //拼装关键字的传值参数串
        private string GetKeyPara()
        {
            string strPara, strTemp;
            int i = 0;
            strPara = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {

                strTemp = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType + " " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                if (i  ==  0)		//是否是第一次
                {
                    strPara +=  strTemp;
                }
                else
                {
                    strPara +=  " , " + strTemp;
                }
                i++;
            }
            return strPara;
        }

        public string A_GeneFuncCode(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {
                    case "ErrNo":
                        return gfunpErrNo();
                    case "Gen_4Ws_ClassConstructor1":
                        return Gen_4Ws_ClassConstructor1();
                    case "ConnectString":
                        return gfunConnectString();
                    case "GenDdlBindFunction":
                        return GenDdlBindFunction();
                    case "GenComboBoxBindFunction":
                        return GenComboBoxBindFunction();
                    case "GenBindListView":
                        return GenBindListView();
                    case "GetDataSet":
                        return Gen_GetDataSet();
                    case "GetDataSetV":
                        return Gen_GetDataSetV();
                    case "GetRecordProperty":
                        return Gen_GetRecordProperty();
                    case "GetRecordPropertyV":
                        return Gen_GetRecordPropertyV();
                    case "IsExistRecordByCond":
                        return Gen_IsExistRecordByCond();
                    case "IsExist":
                        return Gen_IsExist();
                    case "Gen_GetMaxStrId":
                        return Gen_GetMaxStrId();
                    case "AddNewRecordBySql2":
                        return Gen_AddNewRecordBySql2();
                    case "Gen_AddNewRecordBySql_XML":
                        return Gen_AddNewRecordBySql_XML();
                    case "UpdateBySql2":
                        return Gen_UpdateBySql2();
                    case "Gen_UpdateBySql_XML":
                        return Gen_UpdateBySql_XML();
                    case "DelRecord":
                        return Gen_DelRecord();
                    case "DelMultiRecord":
                        return Gen_DelMultiRecord();
                    case "DelMultiRecordByCond":
                        return Gen_DelMultiRecordByCond();
                    case "ExposeLogicClass":
                        return Gen_ExposeLogicClass();
                    case "ExposeLogicExClass":
                        return Gen_ExposeLogicExClass();

                    case "Gen_4Ws_GetDataTable4Tab":
                        return Gen_4Ws_GetDataTable4Tab();
                    case "Gen_4Ws_GetDataTable4TabV":
                        return Gen_4Ws_GetDataTable4TabV();
                    case "Gen_4Ws_GetDataTable4TabV2":
                        return Gen_4Ws_GetDataTable4TabV2();
                    case "Gen_4Ws_GetRecordProperty4Object":
                        return Gen_4Ws_GetRecordProperty4Object();
                    case "Gen_4Ws_CondRecObjList":
                        return Gen_4Ws_CondRecObjList();
                    case "Gen_4Ws_DelRecord":
                        return Gen_4Ws_DelRecord();
                    case "Gen_4Ws_DelRecord_SL":
                        return Gen_4Ws_DelRecord_SL();
                    case "Gen_4Ws_DelMultiRecord":
                        return Gen_4Ws_DelMultiRecord();
                    case "Gen_4Ws_DelMultiRecordByCond":
                        return Gen_4Ws_DelMultiRecordByCond();
                    case "Gen_4Ws_DelMultiRecordByCond_SL":
                        return Gen_4Ws_DelMultiRecordByCond_SL();
                    case "Gen_4Ws_AddNewRecordBySql2":
                        return Gen_4Ws_AddNewRecordBySql2();
                    case "Gen_4Ws_AddNewRecordBySql_SL":
                        return Gen_4Ws_AddNewRecordBySql_SL();
                    case "Gen_4Ws_UpdateBySql2":
                        return Gen_4Ws_UpdateBySql2();
                    case "Gen_4Ws_UpdateBySql_SL":
                        return Gen_4Ws_UpdateBySql_SL();

                    case "Gen_4Ws_IsExistRecord":
                        return Gen_4Ws_IsExistRecord();
                    case "Gen_4Ws_IsExistRecord_SL":
                        return Gen_4Ws_IsExistRecord_SL();
                    case "Gen_4Ws_IsExist":
                        return Gen_4Ws_IsExist();
                    case "Gen_4Ws_IsExist_SL":
                        return Gen_4Ws_IsExist_SL();
                    case "Gen_4Ws_GetMaxStrId":
                        return Gen_4Ws_GetMaxStrId();
                    case "Gen_4Ws_GetMaxStrId_SL":
                        return Gen_4Ws_GetMaxStrId_SL();
                    case "TransNullToStr":
                        return gfunTransNullToStr();
                    case "TransNullToInt":
                        return gfunTransNullToInt();
                    case "TransNullToDate":
                        return gfunTransNullToDate();
                    case "TransNullToFloat":
                        return gfunTransNullToFloat();
                    case "TransNullToDouble":
                        return gfunTransNullToDouble();
                    case "TransNullToBool":
                        return gfunTransNullToBool();
                    case "getStrLen":
                        return gfungetStrLen();
                    case "Dispose":
                        return gfunDispose();
                    case "LogError":
                        return gfunLogError();
                    case "Gen_Ws_SerializeObjToXMLStr":
                        return Gen_Ws_SerializeObjToXMLStr();
                    case "Gen_Ws_SerializeObjListToXMLStr":
                        return Gen_Ws_SerializeObjListToXMLStr();
                    case "Gen_4Ws_SerializeObjToXMLStr_SL":
                        return Gen_4Ws_SerializeObjToXMLStr_SL();
                    case "Gen_4Ws_SerializeObjListToXMLStr_SL":
                        return Gen_4Ws_SerializeObjListToXMLStr_SL();

                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理，请检查!({0})",
                               clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //                           return "///该1函数不存在:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }

        public string gfunConnectString()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串;
            strBuilder.Append("\r\n//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串");
            strBuilder.Append("\r\nprivate static string m_strConnectString;");

            strBuilder.Append("\r\npublic static string ConnectString");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget { return m_strConnectString; }");
            strBuilder.Append("\r\nset { m_strConnectString = value; }");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string gfunpErrNo()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///属性过程;
            ///每个表类都应该有的错误代码类;
            strBuilder.Append("\r\npublic int ErrNo");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  mintErrNo = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunDispErrMsg()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///每个表类都应该有的对外显示的错误信息;
            strBuilder.Append("\r\npublic string DispErrMsg //对外显示的错误信息");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return mstrDispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  mstrDispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}_GetDataSet(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}_GetDataSetV(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_{0}V(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取记录属性
        /// </summary>
        /// <returns></returns>
        public string Gen_GetRecordProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Get{0}(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Get{0}(ref obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecordPropertyV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Get{0}V(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Get{0}(ref obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExistRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExistRecordByCond(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExist({1})",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExist({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {0}_GetMaxStrId()",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrId_S();",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.AddNewRecordBySql2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_AddNewRecordBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql_XML(string str{0}ENObjXml)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.AddNewRecordBySql_XML(str{0}ENObjXml);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySql2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql_XML(string str{0}ENObjXml)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySql_XML(str{0}ENObjXml);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecord({1})",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.DelRecord({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecordBySP({1})",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.DelRecordBySP({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Del{0}s(List<string> arrStdId)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Del{0}s(arrStdId);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}sByCond(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}EN ExposeLogicClass(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{            ");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicExClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}Ex ExposeLogicExClass(cls{0}Ex obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}        ");
            return strBuilder.ToString();
        }



        public string Gen_4Ws_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }





        public string Gen_4Ws_GetDataTable4Tab()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}Ws(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}_GetDataSet(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据出错!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetDataTable4TabV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}VWs(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}_GetDataSetV(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} View 数据出错!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetDataTable4TabV2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}VWs(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}_GetDataSetV(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception (\"获取表View数据出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4Ws_CondRecObjList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static ArrayList Get" + objPrjTabENEx.TabName + "ObjList(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nArrayList arrObjList = new ArrayList(); ");
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_{0}Ws(strCondition);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
   objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}Ws(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_Get{0}(ref obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool DelRecordWs({1} {0})",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_DelRecord({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"删除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecord_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void DelRecordWs({1} {0})",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_DelRecordCompleted +=  new EventHandler<{0}_DelRecordCompletedEventArgs>(obj{0}Service_{0}_DelRecordCompleted);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_DelRecordAsync({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"删除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_DelRecordCompleted(object sender, {0}_DelRecordCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_DelRecord(this, e);",
                    objPrjTabENEx.TabName);
            //            throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}sWs(List<string> arrStdId)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string[] s{0} = (string[])(arrStdId.ToArray(System.Type.GetType(\"System.String\")));",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_Del{0}s(s{1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"删除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCondWs(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = obj{0}Service.{0}_Del{0}sByCond(strWhereCond);",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"删除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelMultiRecordByCond_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void Del{0}sByCondWs(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_Del{0}sByCondCompleted +=  new EventHandler<{0}_Del{0}sByCondCompletedEventArgs>(obj{0}Service_{0}_Del{0}sByCondCompleted);     ",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_Del{0}sByCondAsync(strWhereCond);",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"删除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_Del{0}sByCondCompleted(object sender, {0}_Del{0}sByCondCompletedEventArgs e)",
                        objPrjTabENEx.TabName);
        strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecords = e.Result;");
            strBuilder.AppendFormat("\r\n" + "Event{0}_Del{0}sByCond(this, e);",
                    objPrjTabENEx.TabName);
//            throw new NotImplementedException();
        strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4Ws_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2Ws(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_AddNewRecordBySql2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"添加记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_AddNewRecordBySql_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void AddNewRecordBySql2Ws(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string str{0}ObjXmlStr = cls{0}BL.SerializeObjToXMLStrByIso(obj{0}EN);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_AddNewRecordBySql_XMLCompleted +=  new EventHandler<{0}_AddNewRecordBySql_XMLCompletedEventArgs>(obj{0}Service_{0}_AddNewRecordBySql_XMLCompleted);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_AddNewRecordBySql_XMLAsync(str{0}ObjXmlStr);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
        strBuilder.Append("\r\n" + "}");

        strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_AddNewRecordBySql_XMLCompleted(object sender, {0}_AddNewRecordBySql_XMLCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
        strBuilder.Append("\r\n" + "{");
        strBuilder.AppendFormat("\r\n" + "Event{0}_AddNewRecordBySql_XML(this, e);",
                objPrjTabENEx.TabName);
            //throw new NotImplementedException();
        strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4Ws_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2Ws(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_UpdateBySql2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"添加记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_UpdateBySql_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void UpdateBySql2Ws(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string str{0}ObjXmlStr = cls{0}BL.SerializeObjToXMLStrByIso(obj{0}EN);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_UpdateBySql_XMLCompleted +=  new EventHandler<{0}_UpdateBySql_XMLCompletedEventArgs>(obj{0}Service_{0}_UpdateBySql_XMLCompleted);",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_UpdateBySql_XMLAsync(str{0}ObjXmlStr);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"修改记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");





            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_UpdateBySql_XMLCompleted(object sender, {0}_UpdateBySql_XMLCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_UpdateBySql_XML(this, e);",
                objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "public static bool IsExistRecordWs(string strCondition)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.{0}_IsExistRecordByCond(strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_IsExistRecord_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "public void IsExistRecordWs(string strCondition)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistRecordByCondCompleted +=  new EventHandler<{0}_IsExistRecordByCondCompletedEventArgs>(obj{0}Service_{0}_IsExistRecordByCondCompleted);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistRecordByCondAsync(strCondition);            ",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_IsExistRecordByCondCompleted(object sender, {0}_IsExistRecordByCondCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_IsExistRecordByCond(this, e);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool IsExistWs({0})",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.{0}_IsExist({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4Ws_IsExist_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void IsExistWs({0})",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistCompleted +=  new EventHandler<{0}_IsExistCompletedEventArgs>(obj{0}Service_{0}_IsExistCompleted);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistAsync({1});            ",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_IsExistCompleted(object sender, {0}_IsExistCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_IsExist(this, e);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4Ws_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");

                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrIdWs()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");
                strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                    objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = obj{0}Service.{0}_GetMaxStrId();",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName_FstUcase);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }

        public string Gen_4Ws_GetMaxStrId_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void GetMaxStrIdWs()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_GetMaxStrIdCompleted +=  new EventHandler<{0}_GetMaxStrIdCompletedEventArgs>(obj{0}Service_{0}_GetMaxStrIdCompleted);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_GetMaxStrIdAsync();",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_GetMaxStrIdCompleted(object sender, {0}_GetMaxStrIdCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_GetMaxStrId(this, e);",
                    objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string gfunCheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {

                if (objPrjTabFldENEx.IsTabUnique  ==  true && objPrjTabFldENEx.IsTabPrimary  ==  false)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                    objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.Caption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objPrjTabFldENEx.objFieldTabENEx.PrivFuncName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                    objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " !=  '{0}' and "
                  + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{1}'\", " + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (new cls{0}EN().IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                }
            }
            ///检查类中某属性(非主键)是否唯一 ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\npublic void CheckPropertyNew()");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabNullable  ==  false && objPrjTabFldENEx.objFieldTabENEx.IsIdentity  ==  false)
                {
                    strBuilder.Append("\r\nif (Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + ") ");
                    strBuilder.Append("\r\n|| (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + ") && " + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + " .ToString()  ==  \"\")");
                    if (objPrjTabFldENEx.objFieldTabENEx.CodeTab !=  "")
                    {
                        strBuilder.Append("\r\n|| (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + ") && " + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + " .ToString()  ==  \"0\")");
                    }
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"字段[{0}]不能为空(NULL)!\");",
                    objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n}");
                }
            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName !=  "text" && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string" && objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                {
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + ") && getStrLen(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropName + ") > " + objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim() + ")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"字段[{0}]的长度不能超过{1}!\");",
                    objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            ///检查类中属性是否正确 ==  ==  == = ;
            return strBuilder.ToString();
        }

        public string gfunTransNullToStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///私有函数Begin-------------------------------------;
            strBuilder.Append("\r\nprivate string TransNullToStr(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn \"\";");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn obj.ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunTransNullToInt()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate int TransNullToInt(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn Int32.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunTransNullToDate()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate DateTime TransNullToDate(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(\"#1/1/1900#\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunTransNullToFloat()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate float TransNullToFloat(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0f;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn float.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunTransNullToDouble()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate double TransNullToDouble(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn double.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunTransNullToBool()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate bool TransNullToBool(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn bool.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfungetStrLen()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节---------;
            strBuilder.Append("\r\npublic int getStrLen(string strTemp)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nint len ;");
            strBuilder.Append("\r\nbyte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strBuilder.Append("\r\nlen = sarr.Length;//will output as 3+3*2 = 9");
            strBuilder.Append("\r\nreturn len;");
            strBuilder.Append("\r\n}");
            ///获取字符串长度,其中汉字为2个字节,英文为1个;
            ///私有函数 ==  ==  == ;
            return strBuilder.ToString();
        }
        public string gfunDispose()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///类中析构函数---------------------------------------;
            strBuilder.Append("\r\n public void Dispose()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (mblnDisposed  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Free up the database connection resource by ");
            strBuilder.Append("\r\n //calling its Dispose method");
            strBuilder.Append("\r\n //mobjConnection.Dispose()");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strBuilder.Append("\r\n //prevent the Finalize method from being called.");
            strBuilder.Append("\r\n GC.SuppressFinalize(this);");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Let our class know that Dispose() has been called");
            strBuilder.Append("\r\n mblnDisposed = true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            ///类中析构函数 ==  ==  == ;
            return strBuilder.ToString();
        }
        public string gfunLogError()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节 == ;
            ///错误日志;
            strBuilder.Append("\r\nprotected void LogError" + "(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ mstrModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
    
        /// <summary>
        /// 序列化一个对象到Xml串
        /// </summary>
        /// <returns></returns>
        public string Gen_Ws_SerializeObjToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">需要序列化的对象关键字</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象XML串</returns>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {2}_SerializeObjToXMLStr({0} {1})",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strXmlString = \"\";");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar.objLog.WriteDebugLog(\"XML输出文件:\" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.Get{0}(ref obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strXmlString = cls{0}BL.SerializeObjToXMLStr(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar.objLog.WriteDebugLog(objException.Message);            ");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS(objException, \"{0}Service\"); ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4Ws_SerializeObjToXMLStr_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">需要序列化的对象关键字</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象XML串</returns>",
                objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "public void SerializeObjToXMLStr({0} {1})",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjList = new List<cls{0}EN>();",
                    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjToXMLStrCompleted+= new EventHandler<{0}_SerializeObjToXMLStrCompletedEventArgs>(obj{0}Service_SerializeObjToXMLStrCompleted);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjToXMLStrAsync({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);


            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_SerializeObjToXMLStrCompleted(object sender, {0}_SerializeObjToXMLStrCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_SerializeObjToXMLStr(this, e);",
                    objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// </summary>
        /// <returns></returns>
        public string Gen_Ws_SerializeObjListToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象列表到Xml串");
            strBuilder.Append("\r\n /// 作者:潘以锋");
            strBuilder.Append("\r\n /// 日期:");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要序列化的对象列表的条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象列表XML串</returns>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {0}_SerializeObjListToXMLStr(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strXmlString = \"\";");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}ENObjList = cls{0}BL.Get{0}ObjList(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar.objLog.WriteDebugLog(\"XML输出文件:\" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));");
            strBuilder.AppendFormat("\r\n" + "strXmlString = cls{0}BL.SerializeObjListToXMLStr(lst{0}ENObjList);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar.objLog.WriteDebugLog(objException.Message);");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS(objException, \"{0}Service\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_SerializeObjListToXMLStr_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象列表到Xml串");
            strBuilder.Append("\r\n /// 作者:潘以锋");
            strBuilder.Append("\r\n /// 日期:");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要序列化的对象列表的条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象列表XML串</returns>",
                objPrjTabENEx.TabName);
            
             strBuilder.AppendFormat("\r\n" + "public void SerializeObjListToXMLStr(string strCondition)");
        strBuilder.Append("\r\n" + "{");
        strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjList = new List<cls{0}EN>();",
                objPrjTabENEx.TabName);

        strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
        strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjListToXMLStrCompleted +=  new EventHandler<{0}_SerializeObjListToXMLStrCompletedEventArgs>(obj{0}Service_SerializeObjListToXMLStrCompleted);",
                objPrjTabENEx.TabName);
        strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjListToXMLStrAsync(strCondition);                   ",
                objPrjTabENEx.TabName);
        strBuilder.Append("\r\n" + "}");

        strBuilder.AppendFormat("\r\n" + "void obj{0}Service_SerializeObjListToXMLStrCompleted(object sender, {0}_SerializeObjListToXMLStrCompletedEventArgs e)",
                    objPrjTabENEx.TabName);
        strBuilder.Append("\r\n" + "{");
        strBuilder.AppendFormat("\r\n" + "Event{0}_SerializeObjListToXMLStr(this, e);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strXML = e.Result;");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}ObjList = cls{0}BL.Get{0}ObjListFromXmlStr(strXML);",
                    objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
 
     

    }
}
