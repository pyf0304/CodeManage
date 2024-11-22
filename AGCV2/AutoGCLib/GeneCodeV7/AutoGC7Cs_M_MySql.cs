using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
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
    public class AutoGC7Cs_M_MySql : AutoGCPubFuncV7
    {
        //protected //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        protected string strClsNameEx;

        #region 构造函数

        public AutoGC7Cs_M_MySql()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public AutoGC7Cs_M_MySql(string strViewId, string strPrjDataBaseId)
            : base(strViewId, strPrjDataBaseId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion

        /// <summary>
        /// 生成Entity层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenEntityLayerCodeNew()
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

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("ClsPrivateVar");	//类中私有变量,也是私有属性

            arrFuncList.Add("ConnectString");	//类的用户自定义连接串
            arrFuncList.Add("ClassConstructor1");	//类的构造器1
            arrFuncList.Add("ClassConstructor2");	//类的构造器2
            //arrFuncList.Add("ClassConstructor3");	//类的构造器3
            //			arrFuncList.Add("SetInit");	//			类的初始化的内容
            arrFuncList.Add("ClsIndexer");		//类索引器
            arrFuncList.Add("ClsProperty");		//类的公开属性
            //			arrFuncList.Add("ErrNo");	//
            //arrFuncList.Add("Gen_ClearUpdateState");	//  清除修改状态,即清空存储脏字段信息的HashTable列表          
            //arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库

            ClsName = "cls" + objPrjTabENEx.TabName;
            strClassFName = mstrFolderName + ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                //                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbforMySql;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Entity",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + ClsName + " : clsEntityBase2");
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                    objPrjTabENEx.arrFldSet.Count);
                strTemp = "{";
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp  ==  "{")
                    {
                        strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp +=  "}";
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                    strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");



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
                        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

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
        /// 生成DAL(数据处理层)代码
        /// </summary>
        /// <returns></returns>
        public string A_GenDALCodeNew()
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

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("ConnectString");	//类的用户自定义连接串
            arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库
            arrFuncList.Add("AddNewRecord");	//	添加新记录
            arrFuncList.Add("AddNewRecordBySQL");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddNewRecordBySQL2");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddNewRecordBySQLWithTransaction");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddNewRecordBySQLWithTransaction2");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddnewRecBySP");//		通过存储过程来添加新记录
            arrFuncList.Add("AddnewMultiRec");//	添加多条记录
            arrFuncList.Add("Update");//			修改记录
            arrFuncList.Add("UpdateBySP");//			修改记录
            arrFuncList.Add("UpdateBySql");//			修改记录BySql
            arrFuncList.Add("UpdateBySql2");//			修改记录BySql
            arrFuncList.Add("UpdateBySQLWithTransaction");//			修改记录
            arrFuncList.Add("UpdateBySQLWithTransaction2");//			修改记录
            //arrFuncList.Add("UpdateMultiRec");	//	同时修改多条记录
            //			arrFuncList.Add("funGetRecCount");	//	获取类表的记录数
            //			arrFuncList.Add("funGetRecCount_S");//	获取任意表的记录数(静态函数)
            //			arrFuncList.Add("funGetRecCountByCond"); //获取类表的条件记录数
            //			arrFuncList.Add("funGetRecCountByCond_S"); //获取任意表的条件记录数(静态函数)
            //			arrFuncList.Add("funSetFldValue4String"); //设置类表中条件行的某个字段的值
            //			arrFuncList.Add("funSetFldValue4Float");	//
            //			arrFuncList.Add("funSetFldValue4Int");		//
            //			arrFuncList.Add("funSetFldValue4String_S");	//
            //			arrFuncList.Add("funSetFldValue4Int_S");	//
            //			arrFuncList.Add("funSetFldValue4Float_S");	//
            //			arrFuncList.Add("funGetFldValue");			//
            //			arrFuncList.Add("funGetFldValue_S");		//
            //arrFuncList.Add("DelRecord");				//删除记录
            arrFuncList.Add("DelRecordBySP_S");				//删除记录
            arrFuncList.Add("DelRecordWithTransaction_S");				//删除记录
            arrFuncList.Add("DelMultiRec_S");			//
            arrFuncList.Add("DelRecord_S"); //
            arrFuncList.Add("DelCondRec_S"); //
            arrFuncList.Add("GetRecValue");				//获取字段		
            arrFuncList.Add("GetRecValueBySP");				//获取字段		
            arrFuncList.Add("GetCondRecSet_S"); //
            arrFuncList.Add("GetCondRecSetBySP_S"); //
            arrFuncList.Add("GetCondRecDataSetBySP_S"); //            
            arrFuncList.Add("GetDataSetByCond_S"); //
            arrFuncList.Add("GetDataSetByCondBySP_S"); //            
            arrFuncList.Add("GetDataSetByCond_V_S"); //
            arrFuncList.Add("GetCondRecObjList"); //
            arrFuncList.Add("GetCondRecObjListBySP"); //
            arrFuncList.Add("GetFirstCondRecObj"); //
            arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP
            arrFuncList.Add("GetCondRecSetT_S"); //
            arrFuncList.Add("GetCondRecSetV_S"); //
            //			arrFuncList.Add("GetPrimaryKeyID_S"); //
            //			if (1 == 2)
            //			{
            //				arrFuncList.Add("GetFileFromTabField");
            //				arrFuncList.Add("StoreFileToTabField"); //
            //				arrFuncList.Add("ShowPic_S"); //
            //				arrFuncList.Add("GetFileFromTabField_S"); //
            //			}
            //			arrFuncList.Add("GetDataTable_S"); //
            //arrFuncList.Add("IsExist"); //
            arrFuncList.Add("IsExist_S"); //
            arrFuncList.Add("IsExistBySP_S"); //
            arrFuncList.Add("IsExistCondRec_S"); //
            arrFuncList.Add("CheckPropertyNew"); //
            //            arrFuncList.Add("CheckUniqueness"); //
            arrFuncList.Add("CheckUniquenessV2"); //
            arrFuncList.Add("GetID"); //
            arrFuncList.Add("GetFirstID"); //
            arrFuncList.Add("GetFirstID_S"); //
            //			arrFuncList.Add("GetReader"); //
            //			arrFuncList.Add("GetTable"); //
            //			arrFuncList.Add("GetTableBySQL"); //
            arrFuncList.Add("TransNullToStr"); //
            arrFuncList.Add("TransNullToInt"); //
            arrFuncList.Add("TransNullToShort"); //
            arrFuncList.Add("TransNullToLong"); //
            arrFuncList.Add("TransNullToDate"); //
            arrFuncList.Add("TransNullToFloat"); //
            arrFuncList.Add("TransNullToDouble"); //
            arrFuncList.Add("TransNullToBool"); //
            arrFuncList.Add("getStrLen"); //
            //			arrFuncList.Add("Dispose"); //
            arrFuncList.Add("LogError"); //
            arrFuncList.Add("LogError_S"); //

            ClsName = "cls" + objPrjTabENEx.TabName + "DA";
            strClassFName = mstrFolderName + ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using MySql.Data.MySqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.CommdbforMySql;"); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                    objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                    objPrjTabENEx.arrFldSet.Count);
                strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"出错:\"; //there was an error in the method. please see the Application Log for details.\";");
                strCodeForCs.AppendFormat("\r\n" + "protected string mstrModuleName;");

                strTemp = "{";
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp  ==  "{")
                    {
                        strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp +=  "}";
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                    strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");



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
                        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

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
        public string A_GenGeneralLogicCodeNew()
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

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("ClsPrivateVar");	//类中私有变量,也是私有属性

            arrFuncList.Add("ConnectString");	//类的用户自定义连接串
            arrFuncList.Add("ClassConstructor1");	//类的构造器1
            arrFuncList.Add("ClassConstructor2");	//类的构造器2
            arrFuncList.Add("ClassConstructor3");	//类的构造器3
            //			arrFuncList.Add("SetInit");	//			类的初始化的内容
            arrFuncList.Add("ClsIndexer");		//类索引器
            arrFuncList.Add("ClsProperty");		//类的公开属性
            //			arrFuncList.Add("ErrNo");	//
            arrFuncList.Add("Gen_ClearUpdateState");	//  清除修改状态,即清空存储脏字段信息的HashTable列表          
            arrFuncList.Add("Gen_GetSpecSQLObj");	//获取SQL底层对象,用于处理数据库
            arrFuncList.Add("AddNewRecord");	//	添加新记录
            arrFuncList.Add("AddNewRecordBySQL");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddNewRecordBySQL2");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddNewRecordBySQLWithTransaction");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddNewRecordBySQLWithTransaction2");//	通过SQL语句来添加新记录
            arrFuncList.Add("AddnewRecBySP");//		通过存储过程来添加新记录
            arrFuncList.Add("AddnewMultiRec");//	添加多条记录
            arrFuncList.Add("Update");//			修改记录
            arrFuncList.Add("UpdateBySP");//			修改记录
            arrFuncList.Add("UpdateBySql");//			修改记录BySql
            arrFuncList.Add("UpdateBySql2");//			修改记录BySql
            arrFuncList.Add("UpdateBySQLWithTransaction");//			修改记录
            arrFuncList.Add("UpdateBySQLWithTransaction2");//			修改记录
            arrFuncList.Add("UpdateMultiRec");	//	同时修改多条记录
            //			arrFuncList.Add("funGetRecCount");	//	获取类表的记录数
            //			arrFuncList.Add("funGetRecCount_S");//	获取任意表的记录数(静态函数)
            //			arrFuncList.Add("funGetRecCountByCond"); //获取类表的条件记录数
            //			arrFuncList.Add("funGetRecCountByCond_S"); //获取任意表的条件记录数(静态函数)
            //			arrFuncList.Add("funSetFldValue4String"); //设置类表中条件行的某个字段的值
            //			arrFuncList.Add("funSetFldValue4Float");	//
            //			arrFuncList.Add("funSetFldValue4Int");		//
            //			arrFuncList.Add("funSetFldValue4String_S");	//
            //			arrFuncList.Add("funSetFldValue4Int_S");	//
            //			arrFuncList.Add("funSetFldValue4Float_S");	//
            //			arrFuncList.Add("funGetFldValue");			//
            //			arrFuncList.Add("funGetFldValue_S");		//
            arrFuncList.Add("DelRecord");				//删除记录
            arrFuncList.Add("DelRecordBySP");				//删除记录
            arrFuncList.Add("DelRecordWithTransaction");				//删除记录
            arrFuncList.Add("DelMultiRec_S");			//
            arrFuncList.Add("DelRecord_S"); //
            arrFuncList.Add("DelCondRec_S"); //
            arrFuncList.Add("GetRecValue");				//获取字段		
            arrFuncList.Add("GetRecValueBySP");				//获取字段		
            arrFuncList.Add("GetCondRecSet_S"); //
            arrFuncList.Add("GetCondRecSetBySP_S"); //
            arrFuncList.Add("GetCondRecDataSetBySP_S"); //            
            arrFuncList.Add("GetDataSetByCond_S"); //
            arrFuncList.Add("GetDataSetByCondBySP_S"); //            
            arrFuncList.Add("GetDataSetByCond_V_S"); //
            arrFuncList.Add("GetCondRecObjList"); //
            arrFuncList.Add("GetCondRecObjListBySP"); //
            arrFuncList.Add("GetFirstCondRecObj"); //
            arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP
            arrFuncList.Add("GetCondRecSetT_S"); //
            arrFuncList.Add("GetCondRecSetV_S"); //
            //			arrFuncList.Add("GetPrimaryKeyID_S"); //
            //			if (1 == 2)
            //			{
            //				arrFuncList.Add("GetFileFromTabField");
            //				arrFuncList.Add("StoreFileToTabField"); //
            //				arrFuncList.Add("ShowPic_S"); //
            //				arrFuncList.Add("GetFileFromTabField_S"); //
            //			}
            //			arrFuncList.Add("GetDataTable_S"); //
            arrFuncList.Add("IsExist"); //
            arrFuncList.Add("IsExist_S"); //
            arrFuncList.Add("IsExistBySP_S"); //
            //			arrFuncList.Add("IsExistCondRec_S"); //
            arrFuncList.Add("CheckPropertyNew"); //
            arrFuncList.Add("CheckUniqueness"); //
            arrFuncList.Add("GetID"); //
            arrFuncList.Add("GetFirstID"); //
            arrFuncList.Add("GetFirstID_S"); //
            //			arrFuncList.Add("GetReader"); //
            //			arrFuncList.Add("GetTable"); //
            //			arrFuncList.Add("GetTableBySQL"); //
            //			arrFuncList.Add("TransNullToStr"); //
            //			arrFuncList.Add("TransNullToInt"); //
            //			arrFuncList.Add("TransNullToDate"); //
            //			arrFuncList.Add("TransNullToFloat"); //
            //			arrFuncList.Add("TransNullToDouble"); //
            //			arrFuncList.Add("TransNullToBool"); //
            //			arrFuncList.Add("getStrLen"); //
            //			arrFuncList.Add("Dispose"); //
            //			arrFuncList.Add("LogError"); //

            ClsName = "cls" + objPrjTabENEx.TabName;
            strClassFName = mstrFolderName + ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbforMySql;"); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + ClsName + " : clsGeneralTab");
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                    objPrjTabENEx.arrFldSet.Count);
                strTemp = "{";
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp  ==  "{")
                    {
                        strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp +=  "}";
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                    strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");



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
                        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

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
        /// 生成通用的扩展逻辑层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenGeneralExLogicCodeNew()
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

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("ClassConstructorEx1");	//类的构造器1
            arrFuncList.Add("ClassConstructorEx2");	//类的构造器2
            arrFuncList.Add("ClassConstructorEx3");	//类的构造器3
            arrFuncList.Add("GenComboBoxBindFunction");		//类索引器
            arrFuncList.Add("GenDdlBindFunction");		//类索引器
            arrFuncList.Add("GenBindListView");		//类索引器

            ClsName = "cls" + objPrjTabENEx.TabName;
            strClsNameEx = ClsName + "Ex";
            strClassFName = mstrFolderName + strClsNameEx + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                ///类名开始
                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbforMySql;"); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + strClsNameEx + " : " + ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程

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
                        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

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
        public string A_GenGeneralLogicCode4ViewNew()
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

            ///让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp;  ///临时变量;

            ArrayList arrFuncList = new ArrayList();
            arrFuncList.Add("ClsPrivateVar");	//类中私有变量,也是私有属性
            arrFuncList.Add("ConnectString");	//类的用户自定义连接串
            arrFuncList.Add("ClassConstructor1");	//类的构造器1
            arrFuncList.Add("ClassConstructor2");	//类的构造器2
            arrFuncList.Add("ClassConstructor3");	//类的构造器3
            arrFuncList.Add("ClsIndexer");		//类索引器			
            arrFuncList.Add("ClsProperty");		//类的公开属性
            arrFuncList.Add("Gen_ClearUpdateState");	//  清除修改状态,即清空存储脏字段信息的HashTable列表          
            arrFuncList.Add("Gen_GetSpecSQLObj");	//
            //			arrFuncList.Add("AddNewRecord");	//	添加新记录
            //			arrFuncList.Add("AddNewRecordBySQL");//	通过SQL语句来添加新记录
            //			arrFuncList.Add("AddnewRecBySP");//		通过存储过程来添加新记录
            //			arrFuncList.Add("AddnewMultiRec");//	添加多条记录
            //			arrFuncList.Add("Update");//			修改记录
            //			arrFuncList.Add("UpdateMultiRec");	//	同时修改多条记录
            //			arrFuncList.Add("DelRecord");				//删除记录
            //			arrFuncList.Add("DelMultiRec_S");			//
            //			arrFuncList.Add("DelRecord_S"); //
            //			arrFuncList.Add("DelCondRec_S"); //
            arrFuncList.Add("GetRecValue");				//获取字段		
            arrFuncList.Add("GetRecValueBySP");				//获取字段		
            arrFuncList.Add("GetCondRecSet_S"); //
            arrFuncList.Add("GetCondRecSetBySP_S"); //
            arrFuncList.Add("GetCondRecDataSetBySP_S"); //        
            arrFuncList.Add("GetDataSetByCond_S"); //
            arrFuncList.Add("GetDataSetByCondBySP_S"); //            

            arrFuncList.Add("GetCondRecObjList"); //
            arrFuncList.Add("GetFirstCondRecObj"); //
            arrFuncList.Add("GetFirstCondRecObjBySP"); //GetFirstCondRecObjBySP

            //			arrFuncList.Add("GetCondRecSetT_S"); //
            //			arrFuncList.Add("GetCondRecSetV_S"); //
            arrFuncList.Add("IsExist"); //
            arrFuncList.Add("IsExist_S"); //
            arrFuncList.Add("IsExistBySP_S"); //
            //			arrFuncList.Add("CheckProperty"); //
            arrFuncList.Add("GetID"); //
            arrFuncList.Add("GetFirstID"); //
            arrFuncList.Add("GetFirstID_S"); //

            ClsName = "cls" + objPrjTabENEx.TabName;
            strClassFName = mstrFolderName + ClsName + ".cs";
            mstrFileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
            try
            {
                ///类名开始
                ///
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                ///类名开始
                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbforMySql;"); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}",
                    objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + ClsName + " : clsGeneralTab");
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                    objPrjTabENEx.arrFldSet.Count);
                strTemp = "{";
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp  ==  "{")
                    {
                        strTemp +=  "\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp +=  ", \"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp +=  "}";
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                    strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");



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
                        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

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

        public string GenSQLCode( clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;	//数据库拥有者
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//字段长度

            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +objPrjTabFldENEx.DefPrivateProperty());

                ///计算字段名
                strFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString();
                if (strFieldLength0  ==  string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType)  ==  false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objPrjTabFldENEx.objFieldTabENEx.Caption;
                if (strRemark0  ==  string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

                ///计算是否可空

                if (objPrjTabFldENEx.IsTabNullable  ==  true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键

                if (objPrjTabFldENEx.IsTabPrimary && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objPrjTabFldENEx.IsTabPrimary)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey  ==  "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner;
            if (strDatabaseOwner  ==  "")
            {
                strDatabaseOwner = "dbo";
            }
            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public string GenStoreProcedure_Add(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");


            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);

            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Add ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,

                                            objPrjTabFldENEx.objFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                            objPrjTabFldENEx.objFieldTabENEx.FldLength);

                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();


            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if ((objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY) && (objPrjTabFldENEx.IsTabPrimary  ==  true))
                {
                    continue;
                }
                arrFieldListForInsert.Add(objPrjTabFldENEx.objFieldTabENEx.FldName);
                arrValueListForInsert.Add("@" + objPrjTabFldENEx.objFieldTabENEx.FldName);
            }

            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);

            strCodeForCs.AppendFormat("\r\n" + "insert into {0} ",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "({0}) values ({1}) ;", strFieldListCode, strValuesListCode);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Add()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Add";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                    objPrjTabFldENEx.objFieldTabENEx.FldLength);
            }
            //<Parameter name = "@Name" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@Sex" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@ClgId" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@MajorId" size = "4" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@UserType" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Update()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Update";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                    objPrjTabFldENEx.objFieldTabENEx.FldLength);
            }

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Delete()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Delete";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Select()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Select";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_SelectOne()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectOne";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_IsExist()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_IsExist";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "<Parameter name = \"@IsExist\" size = \"1\" datatype = \"Char\" direction = \"spParamOutput\" isNullable = \"False\" />");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectTop1ByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectTop1ByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenStoreProcedure_Update(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Update ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
                {

                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                            objPrjTabFldENEx.objFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                            objPrjTabFldENEx.objFieldTabENEx.FldLength);
                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "update {0} set ",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "{0} = @{0},", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }

            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedure_Delete(clsPrjTabENEx objPrjTabENEx,  string strPrjDataBaseId)
        {


            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Delete ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "delete from {0} ",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedure_Select(clsPrjTabENEx objPrjTabENEx  ,  string strPrjDataBaseId)
        {



            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Select ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            //if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            //}
            //else
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            //}

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select {1} from {0} ",
                objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strCodeForCs.AppendFormat("\r\n" + "-- Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenStoreProcedure_SelectOne(clsPrjTabENEx objPrjTabENEx,     string strPrjDataBaseId)
        {



            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectOne ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select {1} from {0} ",
                objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedure_IsExist(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "-- Run Example:");
            strCodeForCs.Append("\r\n" + "-- declare @Exist char(1)");
            strCodeForCs.Append("\r\n" + "-- exec Student_IsExist '1005', @Exist out");
            strCodeForCs.Append("\r\n" + "-- select @Exist;");

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_IsExist ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            strCodeForCs.Append("\r\n" + "@IsExist char(1) out");
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.AppendFormat("\r\n" + "if (Exists(select * from {1} Where {0} = @{0}))",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '1';");
            strCodeForCs.Append("\r\n" + "return 1;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '0'");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedure_SelectByCond(clsPrjTabENEx objPrjTabENEx,    string strPrjDataBaseId)
        {



            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectByCond ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret        int,    -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select {1} from {0} ';",
                objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public override string GenStoreProcedure_SelectTop1ByCond(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {


            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectTop1ByCond ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret        int,    -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select Top 1 * from {0} ';",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforMySql objSQL = null;
            //objSQL = new clsSpecSQLforMySql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenSQLCode4CreateTab(clsPrjTabENEx objPrjTabENEx,  string strPrjDataBaseId)
        {



            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//字段长度

            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +objPrjTabFldENEx.DefPrivateProperty());

                ///计算字段名
                strFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString();
                if (strFieldLength0  ==  string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType)  ==  false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objPrjTabFldENEx.objFieldTabENEx.Caption;
                if (strRemark0  ==  string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

                ///计算是否可空

                if (objPrjTabFldENEx.IsTabNullable  ==  true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键
                if (objPrjTabFldENEx.IsTabPrimary && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey  ==  "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner;
            if (strDatabaseOwner  ==  "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

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
        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + objPrjTabFldENEx.objFieldTabENEx.DefPrivateProperty());
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string GenClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///定义类属性
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.ToString();
                strBuilder.Append("\r\n" + strTemp);
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// 类索引器
        /// </summary>
        /// <returns></returns>
        public string GenClsIndexer()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic static int AttributeCount");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn mintAttributeCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //类索引器,字符串参数
            strBuilder.Append("\r\npublic object this[string strAttributeName]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]")
                    {
                    }
                    else  if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    }
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]")
                    {
                    }
                    else  if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    }

                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            //类索引器,整型(INT)序号参数

            strBuilder.Append("\r\npublic object this[int intIndex]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]")
                    {
                    }
                    else            if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    }
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]")
                    {
                    }
                    else if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    }
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string GenConnectString()
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

        public string GenpErrNo()
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
        public string GenDispErrMsg()
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
        public string GenClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n public " + ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + ClsName + "(" + GetKeyPara() + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + GetKeyAssign() + ";");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2})",
                ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strBuilder.Append("\r\nSetInit();");
            strBuilder.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string GenClassConstructorEx1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n public " + strClsNameEx + "()" + ": base()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructorEx2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + strClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructorEx3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2}) : base({3},bolIsGet{2})",
                strClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string GenSetInit()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 设置类的有些属性初始值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\nprivate void SetInit()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nmstrModuleName = this.GetType().ToString();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "DateTime")
                {
                    strBuilder.Append("\r\n" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " = System.DateTime.Parse(\"01/01/1900\");	");
                }
            }
            strBuilder.Append("\r\n}");
            ///类构造器 ==  ==  == = ;
            return strBuilder.ToString();
        }
        public string GenAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>添加是否成功?</returns>");

            strBuilder.AppendFormat("\r\n public bool AddNewRecord(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA ; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlCommandBuilder objCB ; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            /// Dim objSQL As new IKData.SQLServer();
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where 1 = 2\";", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.PrimaryTypeId  ==  "02" && objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                }
                else
                {
                    if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                    {
                        strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                        strBuilder.Append("\r\n }");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
            }
            strBuilder.Append("\r\nobjDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Add(objRow);");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}" + "\r\n");
            ///添加新记录 == = ;
            return strBuilder.ToString();
        }
        public string gfunAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///公共过程--------------------------------------;
            ///添加新记录----------------;
            ///
            strBuilder.Append("\r\n  public int AddNewRecord()");
            strBuilder.Append("\r\n       throws SQLException, ClassNotFoundException {");
            strBuilder.Append("\r\n  String strSQL;");
            strBuilder.Append("\r\n  clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n  strSQL = \"insert into " + objPrjTabENEx.TabName + "\";");
            strBuilder.Append("\r\n  strSQL +=  \" (");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.Append(objPrjTabFldENEx.objFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objPrjTabFldENEx.objFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            int intFldNum = objPrjTabENEx.arrFldSet.Count;
            for (int i = 0; i < intFldNum; i++)
            {
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.Append("\r\n strSQL +=  \" values (?");
                }
                else
                {
                    strBuilder.Append(",   ?");
                }
            }
            strBuilder.Append(")\";");
            strBuilder.Append("\r\n  PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n  //        PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n  objPS.clearParameters();");

            int intFieldNo = 1;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.Append("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", this." + clsString.FstLcaseS(objPrjTabFldENEx.objFieldTabENEx.FldName) + ");");
                intFieldNo +=  1;
            }
            strBuilder.Append("\r\n  int iResult = objPS.executeUpdate();");
            strBuilder.Append("\r\n  objPS.close();");
            strBuilder.Append("\r\n  return iResult;");
            strBuilder.Append("\r\n  }");
            ///添加新记录 == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n  MySqlConnection myConnection = null;");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", mstrStdid, mstrFileName);");
            string strFieldLst = "";
            string strParaLst = "";
            //            StringBuilder strValueLst = new StringBuilder();
            List<string> lstField = new List<string>();//字段列表
            List<string> lstPara = new List<string>();//？参数
            List<string> lstParaStatement = new List<string>();//参数语句
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                lstField.Add(objPrjTabFldENEx.objFieldTabENEx.FldName);
                lstPara.Add("?" + objPrjTabFldENEx.objFieldTabENEx.FldName);
                StringBuilder sbTemp = new StringBuilder();
                sbTemp.AppendFormat("\r\n //定义参数,并设置参数值.字段:{0}({1})",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                sbTemp.AppendFormat("\r\n myCommand.Parameters.Add(new MySqlParameter(\"?{0}\", MySqlDbType.{1}, {2}));",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.MySqlType, objPrjTabFldENEx.objFieldTabENEx.FldLength);
                sbTemp.AppendFormat("\r\n myCommand.Parameters[\"?{0}\"].Value = obj{1}.{0};",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);

                lstParaStatement.Add(sbTemp.ToString());
                intIndex = intIndex + 1;
            }
            strFieldLst = clsArray.GetSqlInStrByArray(lstField, false);
            strParaLst = clsArray.GetSqlInStrByArray(lstPara, false);

            strBuilder.AppendFormat("\r\n strSQL.Append(\"insert into {0}\");",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"({0}) \");",
                strFieldLst);

            strBuilder.Append("\r\nstrSQL.Append(\"values \");");

            strBuilder.AppendFormat("\r\nstrSQL.Append(\" ({0})\");",
                strParaLst);

            strBuilder.Append("\r\n int intFlag = 0;//标志");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            //myConnection.ConnectionString = objSQL.ConnectionString
            strBuilder.Append("\r\n MySqlCommand myCommand = new MySqlCommand(strSQL.ToString(), myConnection);");
            foreach (string strPara in lstParaStatement)
            {
                strBuilder.Append(strPara);
            }

            strBuilder.Append("\r\n intFlag = myCommand.ExecuteNonQuery();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            //ErrorInformation.
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\n  return false;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (myConnection !=  null)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection.Close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intFlag > 0)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return false;");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n ");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQL2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n if ({0} !=  null)",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.Append("\r\n }");
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                    case "byte[]":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                        {
                            if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)  ==  false)
                            {
                                strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                    objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                            }
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        }
                        break;
                }

            }

            strBuilder.Append("\r\n //组织插入记录SQL串");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({0}0{1}) values ({0}1{1}) \", strFieldListCode, strValuesListCode);",
                "{", "}");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQLWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}, MySqlConnection objSqlConnect, MySqlTransaction objMySqlTransaction) ",
                     objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", mstrStdid, mstrFileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    strFieldLst.AppendFormat("{0}", objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strValueLsd.AppendFormat("{0}", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        strParaIndex = "'{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex = "{" + intIndex.ToString() + "}";
                    }
                    bolIsFirst = false;
                }
                else
                {
                    strFieldLst.AppendFormat(", {0}", objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strValueLsd.AppendFormat(", {0}", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        strParaIndex +=  ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex +=  ", {" + intIndex.ToString() + "}";
                    }

                }
                intIndex = intIndex + 1;
            }

            strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQLWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///添加新记录,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}, MySqlConnection objSqlConnect, MySqlTransaction objMySqlTransaction) ",
                     objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n StringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //需要插入表的字段列表");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //需要插入表的值列表");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n if ({0} !=  null)",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        strBuilder.Append("\r\n }");
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                    case "byte[]":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        break;

                    default:
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                        }
                        break;
                }

            }

            strBuilder.Append("\r\n //组织插入记录SQL串");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({0}0{1}) values ({0}1{1}) \", strFieldListCode, strValuesListCode);",
                "{", "}");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///添加新记录,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddnewRecBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public bool Addnew{0}BySP(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.PrimaryTypeId  ==  "02" && objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                }
                else
                {
                    strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ");");
                }
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Add\",values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }

        public override string GenUpdateBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过存储过程(StoreProcedure)来修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strTemp = string.Format("public bool Update{0}BySP(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Update\",values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }

        public string GenDelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public bool DelRecordBySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objKeyField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objKeyField.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }


        public string GenDelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public static bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//通过存储过程来");
            strBuilder.Append("\r\n//直接使用");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }
        public string GenAddnewMultiRec()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///添加多条新记录---------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把多条记录同时插入到表中!");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"oDT\"></param>");
            strBuilder.Append("\r\n /// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strTemp = string.Format("public bool Addnew{0}s(System.Data.DataTable oDT, ref string strResult) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where " + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " = '111'\";", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n//检查关键字的唯一性");
            ///如果该表的关键不是顺序递增型;
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.IsIdentity  ==  false)
            {
                if (objPrjTabENEx.arrKeyFldSet.Count  ==  0)
                {
                    strBuilder.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");

                    ///  MsgBox("你的表中没有关键字");
                }
                else
                {
                    strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
                    strBuilder.Append("\r\n{");
                    string strTT;
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
                    {
                        strTT = string.Format("oRow[\"{0}\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.FldName);
                        strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable) + ";",
                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                        strBuilder.Append("\r\n" + strTemp);
                    }
                    strBuilder.Append("\r\nif (IsExist(" + objPrjTabENEx.KeyPrivFuncFldNameLstStr + "))");
                    strBuilder.Append("\r\n{");
                    ArrayList arrKeyVarLst = new ArrayList();
                    ArrayList arrKeyValueLst = new ArrayList();
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
                    {
                        string strKeyVar = string.Format("{0} = {1}{2}{3}", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
                        arrKeyVarLst.Add(strKeyVar);
                        arrKeyValueLst.Add(objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                        intKeyIndex++;
                    }
                    string strKeyVarLst = clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);
                    string strKeyVarValueLst = string.Format("string.Format(\"{0}\", {1})", strKeyVarLst, strKeyValueLst);
                    clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    strBuilder.Append("\r\nstrResult = \"关键字变量值为:\" + " + strKeyVarValueLst + " + \"的记录已存在,不能重复插入!\" ;");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n//把多条记录插入到表中");
            strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.PrimaryTypeId  ==  "02" && objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                }
                else
                {
                    strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = oRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim(); //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
            }
            strBuilder.Append("\r\nobjDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Add(objRow);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch(Exception objException) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\nobjSQL.MySqlConnect.Close();");
            strBuilder.Append("\r\nobjSQL = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///添加多条新记录 ==  ==  == = ;
            return strBuilder.ToString();
        }
        public string GenUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.AppendFormat("\r\npublic bool Update(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\n MySql.Data.MySqlClient.MySqlCommandBuilder objCB ;");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {2} from {0} where {1};",
                objPrjTabENEx.TabName, KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName), objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nif (objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(\"没有相应的ID号:" + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName) + ");");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows[0];");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if ((objPrjTabFldENEx.objFieldTabENEx.IsIdentity  ==  false) && (objPrjTabFldENEx.IsTabPrimary  ==  false))
                {
                    strBuilder.AppendFormat("\r\n if (obj{1}.IsUpdated(cls{1}EN.con_{0}))",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenUpdateBySql()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n  MySqlConnection myConnection = null;");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", mstrStdid, mstrFileName);");
            string strFieldParaLst = "";
            //            StringBuilder strValueLst = new StringBuilder();
            List<string> lstFieldPara = new List<string>();//字段列表
            List<string> lstPara = new List<string>();//？参数
            List<string> lstParaStatement = new List<string>();//参数语句
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objPrjTabFldENEx.IsTabPrimary  ==  false)
                {
                    lstFieldPara.Add(objPrjTabFldENEx.objFieldTabENEx.FldName + " = ?" + objPrjTabFldENEx.objFieldTabENEx.FldName);
                }
                StringBuilder sbTemp = new StringBuilder();
                sbTemp.AppendFormat("\r\n //定义参数,并设置参数值.字段:{0}({1})",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                sbTemp.AppendFormat("\r\n myCommand.Parameters.Add(new MySqlParameter(\"?{0}\", MySqlDbType.{1}, {2}));",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.MySqlType, objPrjTabFldENEx.objFieldTabENEx.FldLength);
                sbTemp.AppendFormat("\r\n myCommand.Parameters[\"?{0}\"].Value = obj{1}.{0};",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);

                lstParaStatement.Add(sbTemp.ToString());
                intIndex = intIndex + 1;
            }
            strFieldParaLst = clsArray.GetSqlInStrByArray(lstFieldPara, false);

            strBuilder.AppendFormat("\r\n strSQL.Append(\"update {0} set \");",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"{0} \");",
                strFieldParaLst);


            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\"Where {0} = ?{0}\"); ",
             objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n int intFlag = 0;//标志");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            //myConnection.ConnectionString = objSQL.ConnectionString
            strBuilder.Append("\r\n MySqlCommand myCommand = new MySqlCommand(strSQL.ToString(), myConnection);");
            foreach (string strPara in lstParaStatement)
            {
                strBuilder.Append(strPara);
            }

            strBuilder.Append("\r\n intFlag = myCommand.ExecuteNonQuery();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            //ErrorInformation.
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\n  return false;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (myConnection !=  null)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n myConnection.Close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intFlag > 0)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return false;");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n ");

            //修改记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenUpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");

            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if ((objPrjTabFldENEx.objFieldTabENEx.IsIdentity  ==  false) && (objPrjTabFldENEx.IsTabPrimary  ==  false))
                {
                    //if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                    //{
                    // strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                    // strBuilder.Append("\r\n {");
                    // strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                    // strBuilder.Append("\r\n }");
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n if (obj{1}.IsUpdated(cls{1}EN.con_{0}))",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");

                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                        {
                            case "bool":
                                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " == true?\"1\":\"0\"); //{2}",
                                     "{", "}",
                                     objPrjTabFldENEx.objFieldTabENEx.Caption);
                                break;
                            case "byte":
                            case "byte[]":
                                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                                     "{", "}",
                                     objPrjTabFldENEx.objFieldTabENEx.Caption);
                                break;
                            default:
                                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)  ==  false)
                                {
                                    strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                        objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                                }
                                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                                     "{", "}",
                                     objPrjTabFldENEx.objFieldTabENEx.Caption);
                                break;
                        }
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1},\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                        "{", "}",
                        objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                    strBuilder.Append("\r\n }");

                }
                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = '{1}0{2}'\",{3}); ",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                 "{", "}",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            }
            else
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = {1}0{2}\", {3}); ",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                 "{", "}",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenUpdateBySqlWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,支持事务处理,该方式是非优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、支持事务处理.");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// ///      2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}, MySqlConnection objSqlConnect, MySqlTransaction objMySqlTransaction) ",
                     objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if ((objPrjTabFldENEx.objFieldTabENEx.IsIdentity  ==  false) && (objPrjTabFldENEx.IsTabPrimary  ==  false))
                {
                    //if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                    //{
                    // strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                    // strBuilder.Append("\r\n {");
                    // strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                    // strBuilder.Append("\r\n }");
                    //}
                    //else
                    //{
                    if (bolIsFirst  ==  true)
                    {
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                        {
                            //    sbSQL.AppendFormat("LoginTime = 'mstrLoginTime' //登陆时间

                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                                   "{", "}",
                                   objPrjTabFldENEx.objFieldTabENEx.Caption);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1}\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                               "{", "}",
                               objPrjTabFldENEx.objFieldTabENEx.Caption);
                        }
                        bolIsFirst = false;
                    }
                    else
                    {
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                        {
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                                "{", "}",
                                objPrjTabFldENEx.objFieldTabENEx.Caption);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1}\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                            "{", "}",
                            objPrjTabFldENEx.objFieldTabENEx.Caption);
                        }
                    }
                    //}
                }
            }
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"Where {0} = '{1}0{2}'\",{3}); ",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                 "{", "}",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            }
            else
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"Where {0} = {1}0{2}\", {3}); ",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                 "{", "}",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }

        public override string GenUpdateBySqlWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///修改记录------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,支持事务处理,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// ///      2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// ///      3、支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}, MySqlConnection objSqlConnect, MySqlTransaction objMySqlTransaction) ",
                     objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {

                if ((objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY) && (objPrjTabFldENEx.IsTabPrimary  ==  true))
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\n if (obj{1}.IsUpdated(cls{1}EN.con_{0}))",
                        objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");


                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                {
                    switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                    {
                        case "bool":
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " == true?\"1\":\"0\"); //{2}",
                                 "{", "}",
                                 objPrjTabFldENEx.objFieldTabENEx.Caption);
                            break;
                        case "byte":
                        case "byte[]":
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" "
                              + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\","
                              + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ");  //{2}",
                                 "{", "}",
                                 objPrjTabFldENEx.objFieldTabENEx.Caption);
                            break;
                        default:
                            if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)  ==  false)
                            {
                                strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //转换值串中的单撇\"'\",使之成为双撇\"''\"",
                                    objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                            }
                            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                                 "{", "}",
                                 objPrjTabFldENEx.objFieldTabENEx.Caption);
                            break;
                    }
                }
                else
                {
                    strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1},\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + "); //{2}",
                    "{", "}",
                    objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
                strBuilder.Append("\r\n }");


            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = '{1}0{2}'\",{3}); ",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                 "{", "}",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            }
            else
            {
                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0} = {1}0{2}\", {3}); ",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                 "{", "}",
                 objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///修改记录 == = ;
            return strBuilder.ToString();
        }


        public override string GenUpdateMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///按条件修改多条记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:修改多条记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nMySql.Data.MySqlClient.MySqlCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {1} from {0} where \" + strCondition;",
                objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDA = new MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, objSQL.MySqlConnect);");
            strBuilder.Append("\r\nobjCB = new MySql.Data.MySqlClient.MySqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[\"{0}\"].Rows.Count  ==  0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nintRecCount = objDS.Tables[\"{0}\"].Rows.Count;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nforeach(System.Data.DataRow objRow in objDS.Tables[\"{0}\"].Rows)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if ((objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY) && (objPrjTabFldENEx.IsTabPrimary  ==  true))
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1}; //{2}",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName), objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///按条件修改多条记录 == = ;
            return strBuilder.ToString();
        }
        public string GenfunGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取表中的记录数---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic int funGetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(CurrTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int funGetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中满足条件的记录数");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic int funGetRecCountByCond(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(CurrTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int funGetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(strTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///设置/获取表中的符合条件的某字段的值------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int funSetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int funSetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int funSetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int funSetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int funSetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic ArrayList funGetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nArrayList arrList = objSQL.funGetFldDataOfTable(\"{0}\", strFldName, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中的符合条件的某字段的值,以列表返回");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>获取的字段值列表</returns>");
            strBuilder.Append("\r\npublic static ArrayList funGetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nArrayList arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///设置/获取表中的符合条件的某字段的值 == = ;
            return strBuilder.ToString();
        }
        public string GenDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\npublic bool DelRecord() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }

        public string Gen_GetSpecSQLObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\n public static clsSpecSQLforMySql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforMySql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforMySql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforMySql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }

        public string GenDelRecordWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.Append("\r\npublic bool DelRecord(MySqlConnection objSqlConnect, MySqlTransaction objMySqlTransaction) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnect, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }
        public string GenDelRecordWithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除记录------------------;
            strBuilder.AppendFormat("\r\npublic static bool DelRecord({0}, MySqlConnection objSqlConnect, MySqlTransaction objMySqlTransaction) ",
             objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnect, objMySqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
            return strBuilder.ToString();
        }

        public string GenDelMultiRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一些记录------------------;
            strBuilder.Append("\r\n//同时删除多条记录");
            strTemp = string.Format("public static bool Del{0}(List<string> lstKey)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nstring strKeyList;");
            strBuilder.Append("\r\nif (lstKey.Count  == 0) return true;");
            strBuilder.Append("\r\nstrKeyList = \"\";");
            strBuilder.Append("\r\nfor (int i = 0; i<lstKey.Count; i++)");
            strBuilder.Append("\r\n{");
            ///				if ( (i == 0) strKeyList +=  "'" + lstKey[i].ToString() + "'";
            ///				else strKeyList +=  ", " + "'" + lstKey[i].ToString() + "'";
            if (objPrjTabENEx.arrKeyFldSet.Count  ==  0)
            {
                strBuilder.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");
            }
            else
            {
                strBuilder.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\nelse strKeyList +=  \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\n}");
            }
            strBuilder.Append("\r\nstrSQL = \"\";");
            //				if ( objFKSet.GetDelFKTab !=  \")
            //											 {
            //												 strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //					foreach(clsForeignKey objForeignKey in arrForeignKeySet)
            //					{	 
            //						strBuilder.Append("\r\nstrSQL = strSQL + \"Delete " + objFK.FKTABLE_NAME + " where " + objPrjTabENEx.objKeyField0.ColumnName + " in (\" + strKeyList + \")"";");
            //					}
            //			}
            strBuilder.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            if (objPrjTabENEx.arrKeyFldSet.Count  ==  0)
            {
                strBuilder.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " in (\" + strKeyList + \")\";");
                strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL);");
            }
            strBuilder.Append("\r\n}");
            ///删除一些记录 == = ;
            return strBuilder.ToString();
        }
        public string GenDelRecord_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除一条记录-----------------;
            ///
            ///获取表关键字变量的定义列表串
            ///

            strBuilder.Append("\r\n" + string.Format("public static bool DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//删除单条记录");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strBuilder.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\n return objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            ///删除一条记录 == = ;
            return strBuilder.ToString();
        }
        public string GenDelCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///删除多条记录,删除带条件的记录------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除多条记录,带条件的删除");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>返回删除的记录0。</returns>");
            strBuilder.AppendFormat("\r\npublic static int Del{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;	//表示删除0条记录,实际上是不能该表的所有记录");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nint intRecoCount = objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\nreturn intRecoCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除多条记录,删除带条件的记录 == = ;
            return strBuilder.ToString();
        }
        public string GenGetRecValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\npublic bool Get{0}(ref cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where " + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName) + ";", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " = " + AccessNull(objPrjTabFldENEx) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///获取某一关键值的记录 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetRecValueBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一关键值的记录-----------------------------;
            strBuilder.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(" + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ");");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectOne\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " = " + AccessNull(objPrjTabFldENEx) + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///获取某一关键值的记录 ==  == = ;
            return strBuilder.ToString();
        }


        public string GenGetCondRecSet_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetCondRecSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "ByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }
        public string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet Get" + objPrjTabENEx.TabName + "DataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }
        public string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "ByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }
        public string GenGetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n strSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "V(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }


        public string GenGetCondRecObjList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic ArrayList Get" + objPrjTabENEx.TabName + "ObjList(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nArrayList arrObjList = new ArrayList(); ");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0} = new cls{0}();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0});",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0})", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = {2}; //{3}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}S, cls{0}EN obj{0}T)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1}; //{3}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetCondRecObjListBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\npublic ArrayList Get" + objPrjTabENEx.TabName + "ObjListBySP(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nArrayList arrObjList = new ArrayList(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0} = new cls{0}();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0});",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetFirstCondRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0} = new cls{0}();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
   objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);

            }
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.AppendFormat("\r\nreturn obj{0};", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}BySP(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectTop1ByCond\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0} = new cls{0}();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
   objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);

            }
            strBuilder.AppendFormat("\r\n" + "obj{0}.ClearUpdateState();//清除修改状态,即清除脏字段信息",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.AppendFormat("\r\nreturn obj{0};", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            ///获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetCondRecSetT_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件的DataTable,其中的代码转换成相应的名称------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称");
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
                strBuilder.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
                strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}T(string strCondition)",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

                strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
                strBuilder.Append("\r\n //获取连接对象");
                strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select {0}.* \");", objPrjTabENEx.TabName);
                bool bolIsFirst;
                StringBuilder sbTabName = new StringBuilder();
                StringBuilder sbWhereStr = new StringBuilder();
                StringBuilder sbFldStr = new StringBuilder();
                StringBuilder sbLeftJoinStr = new StringBuilder();
                bool bolIsSelfLink = false;
                bolIsFirst = true;
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.IsNeedTransCode  ==  true)
                    {
                        if (objPrjTabENEx.TabName  ==  objPrjTabFldENEx.objFieldTabENEx.CodeTab)
                        {
                            bolIsSelfLink = true;
                        }
                        else
                        {
                            bolIsSelfLink = false;
                        }
                        if (bolIsFirst)
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" from {0}, {1}\");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.CodeTab);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                                objPrjTabFldENEx.objFieldTabENEx.CodeTab);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                        }
                        if (bolIsSelfLink  ==  true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}Self.{1} {2}{3} \");",
                                objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}.{1} {2}{3} \");",
                                objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                        }
                    }
                }

                strBuilder.Append(sbFldStr.ToString());
                strBuilder.AppendFormat("\r\nstrSQL.Append(\" from {0} \");",
                    objPrjTabENEx.TabName);
                strBuilder.Append(sbLeftJoinStr.ToString());
                ///  strBuilder.Append(sbTabName.ToString());
                ///  strBuilder.Append(sbWhereStr.ToString());
                strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
                strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
                strBuilder.Append("\r\nreturn objDT;");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 从视图(SQL View)中获取信息生成 == >DataTable
        /// </summary>
        /// <returns></returns>
        public string GenGetCondRecSetV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件的相关表视图(View)------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的相关表视图(View)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}V(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
            return strBuilder.ToString();
        }


        public string GenGetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一条件的关键字列表-----------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的关键字列表");
            strBuilder.Append("\r\n ///		 如果表关键字是多个,则多个关键字之间用\"//\"隔开");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>关键字列表</returns>");
            strBuilder.Append("\r\npublic static ArrayList GetPrimaryKeyID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondition;",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				LogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				objDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue = \"\";");
            strBuilder.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (iCol  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\narrList.Add(strKeyValue);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取某一条件的关键字列表 ==  ==  ==  ;
            return strBuilder.ToString();
        }
        public string GenGetFileFromTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///上传文件以及下载文件相关代码------------------------------------ ;
            if (mbolIsHaveImageField  ==  true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 功能:从数据库表字段中获取内容,并且存放在文件中。");
                strBuilder.Append("\r\n ///		说明:表记录条件为当前对象所对应的记录。");
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">获取内容后,所存了的文件名。</param>");
                strBuilder.Append("\r\n /// <returns>如果成功获取就返回TRUE,否则为FALSE</returns>");
                strBuilder.Append("\r\npublic bool GetFileFromTabField(string strDownLoadFileName)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nSpecData.clsSpecSQLforMySql objSQL = new SpecData.clsSpecSQLforMySql();");
                strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
                strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
                ///  strBuilder.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", mstrStdid);");
                strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
                strBuilder.AppendFormat("{0}", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                strBuilder.Append(" = '{0}'\", ");
                strBuilder.AppendFormat("{0});", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
                strBuilder.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.ToString());");
                strBuilder.Append("\r\nreturn true;");
                strBuilder.Append("\r\n}");
            }
            return strBuilder.ToString();
        }

        public string GenStoreFileToTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:存储文件。把文件存储到数据库表字段中。");
            strBuilder.Append("\r\n ///		说明:表记录条件为当前对象所对应的记录。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strUpLoadFileName\">所要存储的文件名</param>");
            strBuilder.Append("\r\n /// <returns>如果成功就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\npublic bool StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
            strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName));
            strBuilder.Append("\r\nSpecData.clsSpecSQLforMySql objSQL = new SpecData.clsSpecSQLforMySql();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenShowPic_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:显示图片。显示与关键字相关记录的图片");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"imgPic\">需要显示图片的image控件</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strWebFileDir\">用于WEB显示的文件路径,即URL</param>");
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0} = new cls{0}({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}.Get{0}();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}.FileName;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}.GetFileFromTabField(strDownLoadFileName);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetFileFromTabField_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:从数据库表字段中下载文件内容。该函数是静态(static)函数。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">返回下载的文件名</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strBuilder.Append("\r\npublic static bool GetFileFromTabField(ref string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0} = new cls{0}({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}.Get{0}();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}.FileName;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}.GetFileFromTabField(strDownLoadFileName);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///上传文件以及下载文件相关代码 ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取某一SQL串的DataTable---------------------------;

            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTable(string strSql)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///获取某一SQL串的DataTable ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("\r\npublic bool IsExist()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象 ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExistBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.AppendFormat("\r\npublic static bool IsExistBySP({0})",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.Append("\r\n" + "string strIsExist = \"\";");
            strBuilder.Append("\r\n" + "values.Add(strIsExist);");
            strBuilder.AppendFormat("\r\n" + "ArrayList arrReturn = objSQL.ExecSpWithOutPut(\"{0}_IsExist\", values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (arrReturn[0].ToString()  ==  \"1\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象 ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExist_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象(共享过程函数)-----------------------;
            ///objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {

                if (i  ==  0)	//是否是第一次
                {
                    strTemp = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType + " " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp +=  ", " + objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType + " " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回是否存在?</returns>");

            strBuilder.Append("\r\npublic static bool IsExist(" + strTemp + ")");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false) + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///在数据库中是否存在当前对象(共享过程函数) ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExistCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:判断是否存在某一条件的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\npublic static bool IsExistCondRec(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", strCondition))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
   
        public string GenCheckUniqueness()
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
                    strBuilder.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
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
        public string GenCheckUniquenessV2()
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
                    if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " !=  '{0}' and "
                      + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{1}'\", " + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
                    }
                    else
                    {
                        strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " !=  {0} and "
                          + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{1}'\", " + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");

                    }
                    strBuilder.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                                objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                                objPrjTabFldENEx.objFieldTabENEx.PrivFuncName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({3} {4})",
                                objPrjTabFldENEx.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                                objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                                objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}'\", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
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

        public string GenCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabNullable  ==  false && objPrjTabFldENEx.FieldTypeId !=  "02")
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]" || objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                        continue;
                    }
                    strBuilder.Append("\r\nif (Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ") ");
                    strBuilder.Append("\r\n|| (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ") && " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " .ToString()  ==  \"\")");
                    if (objPrjTabFldENEx.objFieldTabENEx.CodeTab !=  "")
                    {
                        strBuilder.Append("\r\n|| (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ") && " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + " .ToString()  ==  \"0\")");
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
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ") && getStrLen(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName) + ") > " + objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim() + ")");
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

        public string GenGetID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的所有记录的关键字值列表");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的关键字值列表</returns>");

            strBuilder.Append("\r\npublic ArrayList GetID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            //			strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"+ " + KeyWhereStr(true) + "))");
            //			strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue = \"\";");
            strBuilder.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (iCol  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\narrList.Add(strKeyValue);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string GenGetFirstID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strBuilder.AppendFormat("\r\npublic {0} GetFirstID(string strCondition) ", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            ;
            strBuilder.Append("\r\nreturn " + AccessNull("null", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, true) + ";");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");
            strBuilder.Append("\r\nobjDT = null;");
            switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "int":
                    strBuilder.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strBuilder.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strBuilder.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strBuilder.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strBuilder.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strBuilder.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strBuilder.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string GenGetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strCondition) ", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nLogErrorS(objException, \"cls{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
            {
                strBuilder.Append("\r\nreturn " + AccessNull("null", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, true) + ";");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn new cls{0}DA()." + AccessNull("null", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, true) + ";",
                    objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");
            strBuilder.Append("\r\nobjDT = null;");
            switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "int":
                    strBuilder.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strBuilder.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strBuilder.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strBuilder.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strBuilder.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strBuilder.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strBuilder.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        public string GenGetReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select {1} from {0} where \" + strCondition;", objPrjTabENEx.TabName, objPrjTabENEx.FieldNameLstStr));
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDR = objSQL.GetSqlDataReader(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///  strBuilder.Append("\r\nobjDR = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDR;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenGetTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTable(根据条件获取数据表);
            strBuilder.Append("\r\npublic DataTable GetTable(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from " + objPrjTabENEx.TabName + " where \" + strCondition;", objPrjTabENEx.FieldNameLstStr);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///  strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenGetTableBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTableBySQL(根据SQL语句获取数据表)----------------------------------;
            strBuilder.Append("\r\npublic DataTable GetTableBySQL(string strSQL) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforMySql objSQL = null;");
            strBuilder.Append("\r\n //获取连接对象");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///GetTableBySQL(根据SQL语句获取数据表) ==  ==  == ;
            ///公共过程END ==  ==  == ;
            return strBuilder.ToString();
        }
     

        public override string GenComboBoxBindFunction()
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
                    strCodeForCs.Append("\r\n" + "clsSpecSQLforMySql mySql = new clsSpecSQLforMySql();");
                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                        strValueFieldName);
                  

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0};",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"请选择...\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
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
        public string GenDdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///生成仅有变量;
                strCodeForCs.Append("\r\n ///绑定下拉框的函数代码");
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
                    //					strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()", 
                    //						strValueFieldName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    //					strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    //					strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //						strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //					//									if (objViewCtlField.DS_CondStr.Trim()  ==  "")
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DS_TabName);
                    //					//									}
                    //					//									else
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DS_TabName, objViewCtlField.DS_CondStr);
                    //					//									}
                    //					strCodeForCs.Append("\r\n" + "clsSpecSQLforMySql mySql = new clsSpecSQLforMySql();");
                    //					strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //					strCodeForCs.Append("\r\n" + "return objDT;");
                    //					strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                    strCodeForCs.Append("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"请选择...\",\"0\");");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                        strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};", 
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};", 
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
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
        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string GenBindListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///生成绑定ListView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在ListView中。");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjList;",
                    objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjList = new cls{0}().Get{0}ObjList(strWhereCond);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//清除原来所有Item",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//清除原来所有列头信息",
                    objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId !=  "04" && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType !=  "byte[]")	//不是管理字段
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                            objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}.{1};",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}.{1}.ToString();",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabENEx.objKeyField0.FldID  ==  objPrjTabFldENEx.FldID)
                    {
                        continue;
                    }
                    if (objPrjTabFldENEx.FieldTypeId !=  "04"
                        && objPrjTabFldENEx.IsTabForeignKey  ==  false
                        && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType !=  "byte[]")
                    {
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1});",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1}.ToString());",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjList.Count;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
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
