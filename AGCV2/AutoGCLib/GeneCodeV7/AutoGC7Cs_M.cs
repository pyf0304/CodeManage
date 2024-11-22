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
    public class AutoGC7Cs_M : AutoGCPubFuncV7
    {


        #region 构造函数

        public AutoGC7Cs_M()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public AutoGC7Cs_M(string strViewId, string strPrjDataBaseId)
            : base(strViewId, strPrjDataBaseId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion


        ///// <summary>
        ///// 生成Entity层代码
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenEntityLayerCode()
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})", 
        //            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
        //            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///让用户设置属性;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp;  ///临时变量;

        //    ArrayList arrFuncList = new ArrayList();
        //    arrFuncList.Add("ClsPrivateVar");	//类中私有变量,也是私有属性

        //    arrFuncList.Add("ConnectString");	//类的用户自定义连接串
        //    arrFuncList.Add("ClassConstructor1");	//类的构造器1
        //    arrFuncList.Add("ClassConstructor2");	//类的构造器2
        //    //arrFuncList.Add("ClassConstructor3");	//类的构造器3
        //    //			arrFuncList.Add("SetInit");	//			类的初始化的内容
        //    arrFuncList.Add("ClsIndexer");		//类索引器
        //    arrFuncList.Add("ClsProperty");		//类的公开属性
        //    //			arrFuncList.Add("ErrNo");	//
        //    //arrFuncList.Add("Gen_ClearUpdateState");	//  清除修改状态,即清空存储脏字段信息的HashTable列表          
        //    //arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库

        //    ClsName = "cls" + objPrjTabENEx.TabName + "EN";
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    //clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            
        //    try
        //    {
        //        ///类名开始
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        //strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        //                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Entity",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        if (objPrjTabENEx.IsForSilverLight  ==  true)
        //        {
        //            strCodeForCs.AppendFormat("\r\n /// {0}({1}),专门针对SilverLight的实体类", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        }
        //        else
        //        {
        //            strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        }
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        if (objPrjTabENEx.IsForSilverLight  ==  false)
        //        {
        //            strCodeForCs.Append("\r\n" + "[Serializable]");
        //        }
        //        strCodeForCs.Append("\r\n" + "public class " + ClsName + " : clsEntityBase2");
        //        strCodeForCs.Append("\r\n" + "{");

        //        //私有属性名-----和属性过程
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
        //        //与属性名称相关的代码
        //        strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
        //            objPrjTabENEx.arrFldSet.Count);
        //        strTemp = "{";
        //        foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
        //        {
        //            if (strTemp  ==  "{")
        //            {
        //                strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //            else
        //            {
        //                strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //        }
        //        strTemp +=  "}";
        //        strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
        //            strTemp);

        //        strCodeForCs.Append("\r\n" + "//以下是属性变量");



        //        //生成所有的函数

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //把生成写到文件中;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //        ////检查该文件名的文件夹名,并判断是否存在;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}
        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);

        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}


        ///// <summary>
        ///// 生成DAL(数据处理层)代码
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenDALCode()
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
        //            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
        //          objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///让用户设置属性;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp;  ///临时变量;

        //    ArrayList arrFuncList = new ArrayList();
        //    arrFuncList.Add("ConnectString");	//类的用户自定义连接串
        //    arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库
        //    arrFuncList.Add("AddNewRecord");	//	添加新记录
        //    arrFuncList.Add("AddNewRecordBySQL");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddNewRecordBySQL2");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddNewRecordBySQLWithTransaction");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddNewRecordBySQLWithTransaction2");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddnewRecBySP");//		通过存储过程来添加新记录
        //    arrFuncList.Add("AddnewMultiRec");//	添加多条记录
        //    arrFuncList.Add("Update");//			修改记录
        //    arrFuncList.Add("UpdateBySP");//			修改记录
        //    arrFuncList.Add("UpdateBySql");//			修改记录BySql
        //    arrFuncList.Add("UpdateBySql2");//			修改记录BySql
        //    arrFuncList.Add("UpdateBySQLWithTransaction");//			修改记录
        //    arrFuncList.Add("UpdateBySQLWithTransaction2");//			修改记录
        //    //arrFuncList.Add("UpdateMultiRec");	//	同时修改多条记录
        //    //			arrFuncList.Add("funGetRecCount");	//	获取类表的记录数
        //    //			arrFuncList.Add("funGetRecCount_S");//	获取任意表的记录数(静态函数)
        //    //			arrFuncList.Add("funGetRecCountByCond"); //获取类表的条件记录数
        //    //			arrFuncList.Add("funGetRecCountByCond_S"); //获取任意表的条件记录数(静态函数)
        //    //			arrFuncList.Add("funSetFldValue4String"); //设置类表中条件行的某个字段的值
        //    //			arrFuncList.Add("funSetFldValue4Float");	//
        //    //			arrFuncList.Add("funSetFldValue4Int");		//
        //    //			arrFuncList.Add("funSetFldValue4String_S");	//
        //    //			arrFuncList.Add("funSetFldValue4Int_S");	//
        //    //			arrFuncList.Add("funSetFldValue4Float_S");	//
        //    //			arrFuncList.Add("funGetFldValue");			//
        //    //			arrFuncList.Add("funGetFldValue_S");		//
        //    //arrFuncList.Add("DelRecord");				//删除记录
        //    //arrFuncList.Add("CopyObj");	//	复制对象
        //    arrFuncList.Add("CopyObj_S");	//	复制对象
        //    arrFuncList.Add("DelRecordBySP_S");	//删除记录
        //    arrFuncList.Add("DelRecordWithTransaction_S");	//删除记录
        //    arrFuncList.Add("DelMultiRec_S");//
        //    arrFuncList.Add("DelRecord_S"); //
        //    arrFuncList.Add("DelCondRec_S"); //

        //    arrFuncList.Add("Gen_4DAL_GetDataTable4DdlBind"); //            
        //    arrFuncList.Add("GetRecValue");				//获取字段		
        //    arrFuncList.Add("GetRecValueBySP");				//获取字段		
        //    arrFuncList.Add("GetCondRecSet_S"); //
        //    arrFuncList.Add("GetCondRecSetBySP_S"); //
        //    arrFuncList.Add("GetCondRecDataSetBySP_S"); //            
        //    arrFuncList.Add("GetDataSetByCond_S"); //
        //    arrFuncList.Add("GetDataSetByCondBySP_S"); //            
        //    arrFuncList.Add("GetDataSetByCond_V_S"); //
        //    arrFuncList.Add("GetCondRecObjList"); //
        //    arrFuncList.Add("GetCondRecObjListBySP"); //
        //    arrFuncList.Add("GetFirstCondRecObj"); //
        //    arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP
        //    arrFuncList.Add("GetCondRecSetT_S"); //
        //    arrFuncList.Add("GetCondRecSetV_S"); //
        //    //			arrFuncList.Add("GetPrimaryKeyID_S"); //
        //    //			if (1 == 2)
        //    //			{
        //    //				arrFuncList.Add("GetFileFromTabField");
        //    //				arrFuncList.Add("StoreFileToTabField"); //
        //    //				arrFuncList.Add("ShowPic_S"); //
        //    //				arrFuncList.Add("GetFileFromTabField_S"); //
        //    //			}
        //    //			arrFuncList.Add("GetDataTable_S"); //
        //    //arrFuncList.Add("IsExist"); //
        //    arrFuncList.Add("IsExist_S"); //
        //    arrFuncList.Add("IsExistBySP_S"); //
        //    arrFuncList.Add("IsExistCondRec_S"); //
        //    arrFuncList.Add("CheckPropertyNew"); //
        //    //arrFuncList.Add("CheckUniqueness"); //
        //    arrFuncList.Add("CheckUniquenessV2"); //
        //    arrFuncList.Add("GetID"); //
        //    arrFuncList.Add("GetMaxStrID"); //
        //    arrFuncList.Add("GetFirstID"); //
        //    arrFuncList.Add("GetFirstID_S"); //
        //    //			arrFuncList.Add("GetReader"); //
        //    //			arrFuncList.Add("GetTable"); //
        //    //			arrFuncList.Add("GetTableBySQL"); //
        //    arrFuncList.Add("TransNullToStr"); //
        //    arrFuncList.Add("TransNullToInt"); //
        //    arrFuncList.Add("TransNullToShort"); //
        //    arrFuncList.Add("TransNullToLong"); //
        //    arrFuncList.Add("TransNullToDate"); //
        //    arrFuncList.Add("TransNullToFloat"); //
        //    arrFuncList.Add("TransNullToDouble"); //
        //    arrFuncList.Add("TransNullToBool"); //
        //    arrFuncList.Add("getStrLen"); //
        //    //			arrFuncList.Add("Dispose"); //
        //    arrFuncList.Add("LogError"); //
        //    arrFuncList.Add("LogError_S"); //

        //    ClsName = "cls" + objPrjTabENEx.TabName + "DA";
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
        //    try
        //    {
        //        ///类名开始
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
        //        strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
        //            objProject.PrjDomain); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.Append("\r\n" + "public class " + ClsName);
        //        strCodeForCs.Append("\r\n" + "{");

        //        //私有属性名-----和属性过程
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
        //        //与属性名称相关的代码
        //        strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
        //            objPrjTabENEx.arrFldSet.Count);
        //        strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"出错:\"; //there was an error in the method. please see the Application Log for details.\";");
        //        strCodeForCs.AppendFormat("\r\n" + "protected string objViewInfoENEx.ModuleName;");

        //        strTemp = "{";
        //        foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
        //        {
        //            if (strTemp  ==  "{")
        //            {
        //                strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //            else
        //            {
        //                strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //        }
        //        strTemp +=  "}";
        //        strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
        //            strTemp);

        //        strCodeForCs.Append("\r\n" + "//以下是属性变量");



        //        //生成所有的函数

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //把生成写到文件中;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //        ////检查该文件名的文件夹名,并判断是否存在;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}

        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);

        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}


        ///// <summary>
        ///// 生成DAL(数据处理层)代码,针对视图
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenDALCode4View()
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
        //          objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
        //             objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///让用户设置属性;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp;  ///临时变量;

        //    ArrayList arrFuncList = new ArrayList();
        //    arrFuncList.Add("ConnectString");	//类的用户自定义连接串
        //    arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库
        //    arrFuncList.Add("GetRecValue");				//获取字段		
        //    arrFuncList.Add("GetRecValueBySP");				//获取字段		
        //    arrFuncList.Add("GetCondRecSet_S"); //
        //    arrFuncList.Add("GetCondRecSetBySP_S"); //
        //    arrFuncList.Add("GetCondRecDataSetBySP_S"); //            
        //    arrFuncList.Add("GetDataSetByCond_S"); //
        //    arrFuncList.Add("GetDataSetByCondBySP_S"); //            
        //    arrFuncList.Add("GetDataSetByCond_V_S"); //
        //    arrFuncList.Add("GetCondRecObjList"); //
        //    arrFuncList.Add("GetCondRecObjListBySP"); //
        //    arrFuncList.Add("GetFirstCondRecObj"); //
        //    arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP
        //    arrFuncList.Add("GetCondRecSetT_S"); //
        //    arrFuncList.Add("GetCondRecSetV_S"); //
        //    arrFuncList.Add("IsExist_S"); //
        //    arrFuncList.Add("IsExistBySP_S"); //
        //    arrFuncList.Add("IsExistCondRec_S"); //
        //    arrFuncList.Add("GetID"); //
        //    arrFuncList.Add("GetFirstID"); //
        //    arrFuncList.Add("GetFirstID_S"); //
        //    //			arrFuncList.Add("GetReader"); //
        //    //			arrFuncList.Add("GetTable"); //
        //    //			arrFuncList.Add("GetTableBySQL"); //
        //    arrFuncList.Add("TransNullToStr"); //
        //    arrFuncList.Add("TransNullToInt"); //
        //    arrFuncList.Add("TransNullToShort"); //
        //    arrFuncList.Add("TransNullToLong"); //
        //    arrFuncList.Add("TransNullToDate"); //
        //    arrFuncList.Add("TransNullToFloat"); //
        //    arrFuncList.Add("TransNullToDouble"); //
        //    arrFuncList.Add("TransNullToBool"); //
        //    arrFuncList.Add("getStrLen"); //
        //    //			arrFuncList.Add("Dispose"); //
        //    arrFuncList.Add("LogError"); //
        //    arrFuncList.Add("LogError_S"); //

        //    ClsName = "cls" + objPrjTabENEx.TabName + "DA";
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            
        //    try
        //    {
        //        ///类名开始
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
        //        strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
        //            objProject.PrjDomain); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.Append("\r\n" + "public class " + ClsName);
        //        strCodeForCs.Append("\r\n" + "{");

        //        //私有属性名-----和属性过程
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
        //        //与属性名称相关的代码
        //        strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
        //            objPrjTabENEx.arrFldSet.Count);
        //        strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"出错:\"; //there was an error in the method. please see the Application Log for details.\";");
        //        strCodeForCs.AppendFormat("\r\n" + "protected string objViewInfoENEx.ModuleName;");

        //        strTemp = "{";
        //        foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
        //        {
        //            if (strTemp  ==  "{")
        //            {
        //                strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //            else
        //            {
        //                strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //        }
        //        strTemp +=  "}";
        //        strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
        //            strTemp);

        //        strCodeForCs.Append("\r\n" + "//以下是属性变量");



        //        //生成所有的函数

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //把生成写到文件中;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //        ////检查该文件名的文件夹名,并判断是否存在;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}
        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);

        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}


        ///// <summary>
        ///// 生成通用逻辑层代码
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenGeneralLogicCode()
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
        //             objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
        //          objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///让用户设置属性;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp;  ///临时变量;

        //    ArrayList arrFuncList = new ArrayList();
        //    arrFuncList.Add("ClsPrivateVar");	//类中私有变量,也是私有属性

        //    arrFuncList.Add("ConnectString");	//类的用户自定义连接串
        //    arrFuncList.Add("ClassConstructor1");	//类的构造器1
        //    arrFuncList.Add("ClassConstructor2");	//类的构造器2
        //    arrFuncList.Add("ClassConstructor3");	//类的构造器3
        //    //			arrFuncList.Add("SetInit");	//			类的初始化的内容
        //    arrFuncList.Add("ClsIndexer");		//类索引器
        //    arrFuncList.Add("ClsProperty");		//类的公开属性
        //    //			arrFuncList.Add("ErrNo");	//
        //    arrFuncList.Add("Gen_ClearUpdateState");	//  清除修改状态,即清空存储脏字段信息的HashTable列表          
        //    arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库
        //    arrFuncList.Add("Gen_GetSpecSQLObj_Obj");	//获取SQL底层对象,用于处理数据库

        //    arrFuncList.Add("AddNewRecord");	//	添加新记录
        //    arrFuncList.Add("AddNewRecordBySQL");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddNewRecordBySQL2");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddNewRecordBySQLWithTransaction");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddNewRecordBySQLWithTransaction2");//	通过SQL语句来添加新记录
        //    arrFuncList.Add("AddnewRecBySP");//		通过存储过程来添加新记录
        //    arrFuncList.Add("AddnewMultiRec");//	添加多条记录
        //    arrFuncList.Add("Update");//			修改记录
        //    arrFuncList.Add("UpdateBySP");//			修改记录
        //    arrFuncList.Add("UpdateBySql");//			修改记录BySql
        //    arrFuncList.Add("UpdateBySql2");//			修改记录BySql
        //    arrFuncList.Add("UpdateBySQLWithTransaction");//			修改记录
        //    arrFuncList.Add("UpdateBySQLWithTransaction2");//			修改记录
        //    arrFuncList.Add("UpdateMultiRec");	//	同时修改多条记录
        //    //			arrFuncList.Add("funGetRecCount");	//	获取类表的记录数
        //    //			arrFuncList.Add("funGetRecCount_S");//	获取任意表的记录数(静态函数)
        //    //			arrFuncList.Add("funGetRecCountByCond"); //获取类表的条件记录数
        //    //			arrFuncList.Add("funGetRecCountByCond_S"); //获取任意表的条件记录数(静态函数)
        //    //			arrFuncList.Add("funSetFldValue4String"); //设置类表中条件行的某个字段的值
        //    //			arrFuncList.Add("funSetFldValue4Float");	//
        //    //			arrFuncList.Add("funSetFldValue4Int");		//
        //    //			arrFuncList.Add("funSetFldValue4String_S");	//
        //    //			arrFuncList.Add("funSetFldValue4Int_S");	//
        //    //			arrFuncList.Add("funSetFldValue4Float_S");	//
        //    //			arrFuncList.Add("funGetFldValue");			//
        //    //			arrFuncList.Add("funGetFldValue_S");		//
        //    arrFuncList.Add("DelRecord");				//删除记录
        //    arrFuncList.Add("DelRecordBySP");				//删除记录
        //    arrFuncList.Add("DelRecordWithTransaction");				//删除记录
        //    arrFuncList.Add("DelMultiRec_S");			//
        //    arrFuncList.Add("DelRecord_S"); //
        //    arrFuncList.Add("DelCondRec_S"); //
        //    arrFuncList.Add("GetRecValue");				//获取字段		
        //    arrFuncList.Add("GetRecValueBySP");				//获取字段		
        //    arrFuncList.Add("GetCondRecSet_S"); //
        //    arrFuncList.Add("GetCondRecSetBySP_S"); //
        //    arrFuncList.Add("GetCondRecDataSetBySP_S"); //            
        //    arrFuncList.Add("GetDataSetByCond_S"); //
        //    arrFuncList.Add("GetDataSetByCondBySP_S"); //            
        //    arrFuncList.Add("GetDataSetByCond_V_S"); //
        //    arrFuncList.Add("GetCondRecObjList"); //
        //    arrFuncList.Add("GetCondRecObjListBySP"); //
        //    arrFuncList.Add("GetFirstCondRecObj"); //
        //    arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP
        //    arrFuncList.Add("GetCondRecSetT_S"); //
        //    arrFuncList.Add("GetCondRecSetV_S"); //
        //    //			arrFuncList.Add("GetPrimaryKeyID_S"); //
        //    //			if (1 == 2)
        //    //			{
        //    //				arrFuncList.Add("GetFileFromTabField");
        //    //				arrFuncList.Add("StoreFileToTabField"); //
        //    //				arrFuncList.Add("ShowPic_S"); //
        //    //				arrFuncList.Add("GetFileFromTabField_S"); //
        //    //			}
        //    //			arrFuncList.Add("GetDataTable_S"); //
        //    arrFuncList.Add("IsExist"); //
        //    arrFuncList.Add("IsExist_S"); //
        //    arrFuncList.Add("IsExistBySP_S"); //
        //    //			arrFuncList.Add("IsExistCondRec_S"); //
        //    arrFuncList.Add("CheckPropertyNew"); //
        //    arrFuncList.Add("CheckUniqueness"); //
        //    arrFuncList.Add("GetID"); //
        //    arrFuncList.Add("GetFirstID"); //
        //    arrFuncList.Add("GetFirstID_S"); //
        //    //			arrFuncList.Add("GetReader"); //
        //    //			arrFuncList.Add("GetTable"); //
        //    //			arrFuncList.Add("GetTableBySQL"); //
        //    //			arrFuncList.Add("TransNullToStr"); //
        //    //			arrFuncList.Add("TransNullToInt"); //
        //    //			arrFuncList.Add("TransNullToDate"); //
        //    //			arrFuncList.Add("TransNullToFloat"); //
        //    //			arrFuncList.Add("TransNullToDouble"); //
        //    //			arrFuncList.Add("TransNullToBool"); //
        //    //			arrFuncList.Add("getStrLen"); //
        //    //			arrFuncList.Add("Dispose"); //
        //    //			arrFuncList.Add("LogError"); //

        //    ClsName = "cls" + objPrjTabENEx.TabName;
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
        //    try
        //    {
        //        ///类名开始
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.Append("\r\n" + "public class " + ClsName + " : clsGeneralTab");
        //        strCodeForCs.Append("\r\n" + "{");

        //        //私有属性名-----和属性过程
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
        //        //与属性名称相关的代码
        //        strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
        //            objPrjTabENEx.arrFldSet.Count);
        //        strTemp = "{";
        //        foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
        //        {
        //            if (strTemp  ==  "{")
        //            {
        //                strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //            else
        //            {
        //                strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //        }
        //        strTemp +=  "}";
        //        strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
        //            strTemp);

        //        strCodeForCs.Append("\r\n" + "//以下是属性变量");



        //        //生成所有的函数

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //把生成写到文件中;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //        ////检查该文件名的文件夹名,并判断是否存在;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}

        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}

        ///// <summary>
        ///// 生成通用的扩展逻辑层代码
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenGeneralExLogicCode()
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
        //                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
        //          objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///让用户设置属性;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp;  ///临时变量;

        //    ArrayList arrFuncList = new ArrayList();
        //    arrFuncList.Add("ClassConstructorEx1");	//类的构造器1
        //    arrFuncList.Add("ClassConstructorEx2");	//类的构造器2
        //    arrFuncList.Add("ClassConstructorEx3");	//类的构造器3
        //    arrFuncList.Add("GenComboBoxBindFunction");		//类索引器
        //    arrFuncList.Add("GenDdlBindFunction");		//类索引器
        //    arrFuncList.Add("GenBindListView");		//类索引器

        //    ClsName = "cls" + objPrjTabENEx.TabName;
        //    ClsNameEx = ClsName + "Ex";
        //    strClassFName = mstrFolderName + ClsNameEx + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
        //    try
        //    {
        //        ///类名开始
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        ///类名开始
        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.Append("\r\n" + "public class " + ClsNameEx + " : " + ClsName);
        //        strCodeForCs.Append("\r\n" + "{");

        //        //私有属性名-----和属性过程

        //        //生成所有的函数

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //把生成写到文件中;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //        ////检查该文件名的文件夹名,并判断是否存在;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}

        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}

        ///// <summary>
        ///// 生成通用逻辑层代码
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenGeneralLogicCode4View(Encoding myEncoding)
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
        //               objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
        //            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///让用户设置属性;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp;  ///临时变量;

        //    ArrayList arrFuncList = new ArrayList();
        //    arrFuncList.Add("ClsPrivateVar");	//类中私有变量,也是私有属性
        //    arrFuncList.Add("ConnectString");	//类的用户自定义连接串
        //    arrFuncList.Add("ClassConstructor1");	//类的构造器1
        //    arrFuncList.Add("ClassConstructor2");	//类的构造器2
        //    arrFuncList.Add("ClassConstructor3");	//类的构造器3
        //    arrFuncList.Add("ClsIndexer");		//类索引器			
        //    arrFuncList.Add("ClsProperty");		//类的公开属性
        //    arrFuncList.Add("Gen_ClearUpdateState");	//  清除修改状态,即清空存储脏字段信息的HashTable列表          
        //    arrFuncList.Add("Gen_GetSpecSQLObj");	//
        //    arrFuncList.Add("Gen_GetSpecSQLObj_Obj");	//获取SQL底层对象,用于处理数据库
        //    //			arrFuncList.Add("AddNewRecord");	//	添加新记录
        //    //			arrFuncList.Add("AddNewRecordBySQL");//	通过SQL语句来添加新记录
        //    //			arrFuncList.Add("AddnewRecBySP");//		通过存储过程来添加新记录
        //    //			arrFuncList.Add("AddnewMultiRec");//	添加多条记录
        //    //			arrFuncList.Add("Update");//			修改记录
        //    //			arrFuncList.Add("UpdateMultiRec");	//	同时修改多条记录
        //    //			arrFuncList.Add("DelRecord");				//删除记录
        //    //			arrFuncList.Add("DelMultiRec_S");			//
        //    //			arrFuncList.Add("DelRecord_S"); //
        //    //			arrFuncList.Add("DelCondRec_S"); //
        //    arrFuncList.Add("GetRecValue");				//获取字段		
        //    arrFuncList.Add("GetRecValueBySP");				//获取字段		
        //    arrFuncList.Add("GetCondRecSet_S"); //
        //    arrFuncList.Add("GetCondRecSetBySP_S"); //
        //    arrFuncList.Add("GetCondRecDataSetBySP_S"); //        
        //    arrFuncList.Add("GetDataSetByCond_S"); //
        //    arrFuncList.Add("GetDataSetByCondBySP_S"); //            

        //    arrFuncList.Add("GetCondRecObjList"); //
        //    arrFuncList.Add("GetFirstCondRecObj"); //
        //    arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP

        //    //			arrFuncList.Add("GetCondRecSetT_S"); //
        //    //			arrFuncList.Add("GetCondRecSetV_S"); //
        //    arrFuncList.Add("IsExist"); //
        //    arrFuncList.Add("IsExist_S"); //
        //    arrFuncList.Add("IsExistBySP_S"); //
        //    //			arrFuncList.Add("CheckProperty"); //
        //    arrFuncList.Add("GetID"); //
        //    arrFuncList.Add("GetFirstID"); //
        //    arrFuncList.Add("GetFirstID_S"); //

        //    ClsName = "cls" + objPrjTabENEx.TabName;
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
        //    try
        //    {
        //        ///类名开始
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        ///类名开始
        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //

        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.Append("\r\n" + "public class " + ClsName + " : clsGeneralTab");
        //        strCodeForCs.Append("\r\n" + "{");

        //        //私有属性名-----和属性过程
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
        //        strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
        //        //与属性名称相关的代码
        //        strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
        //            objPrjTabENEx.arrFldSet.Count);
        //        strTemp = "{";
        //        foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
        //        {
        //            if (strTemp  ==  "{")
        //            {
        //                strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //            else
        //            {
        //                strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
        //            }
        //        }
        //        strTemp +=  "}";
        //        strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
        //            strTemp);

        //        strCodeForCs.Append("\r\n" + "//以下是属性变量");



        //        //生成所有的函数

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //把生成写到文件中;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //    //    //检查该文件名的文件夹名,并判断是否存在;
        //    //    strFolder = clsString.ParentDir_S(strClassFName);
        //    //    if (System.IO.Directory.Exists(strFolder)  ==  false)
        //    //    {
        //    //        Directory.CreateDirectory(strFolder);
        //    //    }
        //    //    if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //    //    {
        //    //        string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //    //        string strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //    //        while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //    //        {
        //    //            clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //    //            File.Delete(strFindFileFullFile);
        //    //            strFindFileFullFile = clsFile.FindFileFromFolder(mstrBackupFolderName, strSimpleFileName);
        //    //        }
        //    //    }
        //    //    clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}




        private string AccessNull(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte":
                case "byte[]":
                    return AccessNull("objDT.Rows[0][\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"]", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
                default:
                    return AccessNull("objDT.Rows[0][\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
            }
        }
        private string AccessNull2(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte":
                case "byte[]":
                    return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"]", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
                default:
                    return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
            }
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
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToShort(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToDate(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToFloat(" + strContent + ")";
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
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToBool(" + strContent + ")";
                    }
                    else
                    {
                        return "TransNullToBool(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
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

        //拼装关键字的WHERE串
        private string KeyWhereStrWithObject(string strObject)
        {
            //bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName + " = \" + " + Mark(objPrjTabFldENEx) + "+ " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName(strObject) + "+" + Mark(objPrjTabFldENEx);
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


        /// <summary>
        /// 关键字赋值,用于构造函数中关键字赋初值
        /// </summary>
        /// <returns>赋值表达式串</returns>
        private string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.PrivPropName + " = " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ";";
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
                        return GenpErrNo();
                    case "DispErrMsg":
                        return GenDispErrMsg();
                    case "ConnectString":
                        return GenConnectString();
                    case "ClassConstructor1":
                        return GenClassConstructor1();
                    case "ClassConstructor2":
                        return GenClassConstructor2();
                    case "ClassConstructor3":
                        return GenClassConstructor3();
                    case "ClassConstructorEx1":
                        return GenClassConstructorEx1();
                    case "ClassConstructorEx2":
                        return GenClassConstructorEx2();
                    case "ClassConstructorEx3":
                        return GenClassConstructorEx3();
                    case "ClsPrivateVar":
                        return GenClsPrivateVar();
                    case "Gen_ClearUpdateState":
                        return Gen_ClearUpdateState();
                    case "GenDdlBindFunction":
                        return GenDdlBindFunction();
                    case "GenComboBoxBindFunction":
                        return GenComboBoxBindFunction();
                    case "GenBindListView":
                        return GenBindListView();
                    case "ClsProperty":
                        return GenClsProperty();
                    case "ClsIndexer":	//类索引器
                        return GenClsIndexer();
                    case "SetInit":
                        return GenSetInit();
                    case "Gen_GetSpecSQLObj":
                        return Gen_GetSpecSQLObj();
                    case "Gen_GetSpecSQLObj_Obj":
                        return Gen_GetSpecSQLObj_Obj();
                    case "AddNewRecord":
                        return GenAddNewRecord();
                    case "AddNewRecordBySQL":
                        return GenAddNewRecordBySQL();
                    case "AddNewRecordBySQL2":
                        return GenAddNewRecordBySQL2();
                    case "AddNewRecordBySQLWithTransaction":
                        return GenAddNewRecordBySQLWithTransaction();
                    case "AddNewRecordBySQLWithTransaction2":
                        return GenAddNewRecordBySQLWithTransaction2();

                    case "AddnewRecBySP":
                        return GenAddnewRecBySP();
                    case "AddnewMultiRec":
                        return GenAddnewMultiRec();
                    case "Update":
                        return GenUpdate();
                    case "UpdateBySP":
                        return GenUpdateBySP();
                    //case "CopyObj":
                    //    return GenCopyObj();
                    case "CopyObj_S":
                        return GenCopyObj_S();

                    case "UpdateBySql":
                        return GenUpdateBySql();
                    case "UpdateBySql2":
                        return GenUpdateBySql2();
                    case "UpdateBySQLWithTransaction":
                        return GenUpdateBySqlWithTransaction();
                    case "UpdateBySQLWithTransaction2":
                        return GenUpdateBySqlWithTransaction2();
                    case "UpdateMultiRec":
                        return GenUpdateMultiRec();
                    case "funGetRecCount":
                        return GenfunGetRecCount();
                    case "funGetRecCount_S":
                        return GenfunGetRecCount_S();
                    case "funGetRecCountByCond":
                        return GenfunGetRecCountByCond();
                    case "funGetRecCountByCond_S":
                        return GenfunGetRecCountByCond_S();
                    case "funSetFldValue4String":
                        return GenfunSetFldValue4String();
                    case "funSetFldValue4Float":
                        return GenfunSetFldValue4Float();
                    case "funSetFldValue4Int":
                        return GenfunSetFldValue4Int();
                    case "funSetFldValue4String_S":
                        return GenfunSetFldValue4String_S();
                    case "funSetFldValue4Int_S":
                        return GenfunSetFldValue4Int_S();
                    case "funSetFldValue4Float_S":
                        return GenfunSetFldValue4Float_S();
                    case "funGetFldValue":
                        return GenfunGetFldValue();
                    case "funGetFldValue_S":
                        return GenfunGetFldValue_S();
                    case "DelRecord":
                        return GenDelRecord();
                    case "DelRecordBySP":
                        return GenDelRecordBySP();
                    case "DelRecordBySP_S":
                        return GenDelRecordBySP_S();
                    case "DelRecordWithTransaction":
                        return GenDelRecordWithTransaction();
                    case "DelRecordWithTransaction_S":
                        return GenDelRecordWithTransaction_S();

                    case "DelMultiRec_S":
                        return GenDelMultiRec_S();
                    case "DelRecord_S":
                        return GenDelRecord_S();
                    case "DelCondRec_S":
                        return GenDelCondRec_S();

                    case "GetRecValue":
                        return GenGetRecValue();
                    case "GetRecValueBySP":
                        return GenGetRecValueBySP();
                    case "GetCondRecSet_S":
                        return GenGetCondRecSet_S();
                    case "GetCondRecSetBySP_S":
                        return GenGetCondRecSetBySP_S();
                    case "GetDataSetByCond_S":
                        return GenGetDataSetByCond_S();
                    case "GetDataSetByCondBySP_S":
                        return GenGetDataSetByCondBySP_S();
                    case "GetDataSetByCond_V_S":
                        return GenGetDataSetByCond_V_S();

                    case "GetCondRecObjList":
                        return GenGetCondRecObjList();
                    case "GetCondRecObjListBySP":
                        return GenGetCondRecObjListBySP();
                    case "GetFirstCondRecObj":
                        return GenGetFirstCondRecObj();
                    case "GetFirstCondRecObjBySP":
                        return GenGetFirstCondRecObjBySP();
                    case "GetCondRecSetT_S":
                        return GenGetCondRecSetT_S();
                    case "GetCondRecDataSetBySP_S":
                        return GenGetCondRecDataSetBySP_S();
                    case "GetCondRecSetV_S":
                        return GenGetCondRecSetV_S();
                    case "GetPrimaryKeyID_S":
                        return GenGetPrimaryKeyID_S();
                    case "GetFileFromTabField":
                        return GenGetFileFromTabField();
                    case "StoreFileToTabField":
                        return GenStoreFileToTabField();
                    case "ShowPic_S":
                        return GenShowPic_S();
                    case "GetFileFromTabField_S":
                        return GenGetFileFromTabField_S();
                    case "GetDataTable_S":
                        return GenGetDataTable_S();
                    case "IsExist":
                        return GenIsExist();
                    case "IsExist_S":
                        return GenIsExist_S();
                    case "IsExistBySP_S":
                        return GenIsExistBySP();
                    case "IsExistCondRec_S":
                        return GenIsExistCondRec_S();
                    //case "CheckProperty":
                    // return GenCheckProperty();
                    case "CheckPropertyNew":
                        return GenCheckPropertyNew();
                    case "CheckUniqueness":
                        return GenCheckUniqueness();
                    case "CheckUniquenessV2":
                        return GenCheckUniquenessV2();
                    case "GetID":
                        return GenGetID();
                    case "GetMaxStrID":
                        return GenGetMaxStrID();
                    case "GetFirstID":
                        return GenGetFirstID();
                    case "GetFirstID_S":
                        return GenGetFirstID_S();
                    case "GetReader":
                        return GenGetReader();
                    case "GetTable":
                        return GenGetTable();
                    case "GetTableBySQL":
                        return GenGetTableBySQL();
                    case "TransNullToStr":
                        return GenTransNullToStr();
                    case "TransNullToInt":
                        return GenTransNullToInt();
                    case "TransNullToLong":
                        return GenTransNullToLong();
                    case "TransNullToShort":
                        return GenTransNullToShort();
                    case "TransNullToDate":
                        return GenTransNullToDate();
                    case "TransNullToFloat":
                        return GenTransNullToFloat();
                    case "TransNullToDouble":
                        return GenTransNullToDouble();
                    case "TransNullToBool":
                        return GenTransNullToBool();
                    case "getStrLen":
                        return GengetStrLen();
                    case "Dispose":
                        return GenDispose();
                    case "LogError":
                        return GenLogError();
                    case "LogError_S":
                        return GenLogError_S();
                    case "Gen_4DAL_GetDataTable4DdlBind":
                        return Gen_4DAL_GetDataTable4DdlBind();

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
        public string Gen_4DAL_GetDataTable4DdlBind()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId  ==  "02")
                    {
                        strValueFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                    if (objPrjTabFldENEx.FieldTypeId  ==  "03")
                    {
                        strTextFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName !=  "" && strTextFieldName !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                        strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objPrjTabFldENEx.DS_CondStr.Trim()  ==  "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objPrjTabFldENEx.DS_CondStr);
                    //						}
                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

    }
}
