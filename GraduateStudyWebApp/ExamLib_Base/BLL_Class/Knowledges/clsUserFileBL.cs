
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserFileBL
 表名:UserFile(01120085)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsUserFileBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFileName">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserFileEN GetObj(this K_FileName_UserFile myKey)
{
clsUserFileEN objUserFileEN = clsUserFileBL.UserFileDA.GetObjByFileName(myKey.Value);
return objUserFileEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserFileEN objUserFileEN)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserFileBL.IsExist(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserFileEN.FileName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsUserFileBL.UserFileDA.AddNewRecordBySQL2(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsUserFileEN objUserFileEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsUserFileBL.IsExist(objUserFileEN.FileName))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objUserFileEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objUserFileEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserFileEN objUserFileEN)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserFileBL.IsExist(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserFileEN.FileName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsUserFileBL.UserFileDA.AddNewRecordBySQL2WithReturnKey(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetFileName(this clsUserFileEN objUserFileEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, conUserFile.FileName);
}
objUserFileEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.FileName) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.FileName, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.FileName] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetOrderNum(this clsUserFileEN objUserFileEN, int? intOrderNum, string strComparisonOp="")
	{
objUserFileEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.OrderNum) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.OrderNum, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.OrderNum] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetFileSize(this clsUserFileEN objUserFileEN, double dblFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblFileSize, conUserFile.FileSize);
objUserFileEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.FileSize) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.FileSize, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.FileSize] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetExtension(this clsUserFileEN objUserFileEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 10, conUserFile.Extension);
}
objUserFileEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.Extension) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.Extension, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.Extension] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetResourceTypeName(this clsUserFileEN objUserFileEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, conUserFile.ResourceTypeName);
}
objUserFileEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.ResourceTypeName) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.ResourceTypeName, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.ResourceTypeName] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetFileSizeUnit(this clsUserFileEN objUserFileEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, conUserFile.FileSizeUnit);
}
objUserFileEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.FileSizeUnit) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.FileSizeUnit, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.FileSizeUnit] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetResourcePicPath(this clsUserFileEN objUserFileEN, string strResourcePicPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourcePicPath, 500, conUserFile.ResourcePicPath);
}
objUserFileEN.ResourcePicPath = strResourcePicPath; //图片位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.ResourcePicPath) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.ResourcePicPath, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.ResourcePicPath] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetUploadDateTime(this clsUserFileEN objUserFileEN, string strUploadDateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDateTime, 200, conUserFile.UploadDateTime);
}
objUserFileEN.UploadDateTime = strUploadDateTime; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.UploadDateTime) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.UploadDateTime, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.UploadDateTime] = strComparisonOp;
}
}
return objUserFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserFileEN SetFileNamePath(this clsUserFileEN objUserFileEN, string strFileNamePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNamePath, 1000, conUserFile.FileNamePath);
}
objUserFileEN.FileNamePath = strFileNamePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserFileEN.dicFldComparisonOp.ContainsKey(conUserFile.FileNamePath) == false)
{
objUserFileEN.dicFldComparisonOp.Add(conUserFile.FileNamePath, strComparisonOp);
}
else
{
objUserFileEN.dicFldComparisonOp[conUserFile.FileNamePath] = strComparisonOp;
}
}
return objUserFileEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserFileEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserFileEN objUserFileEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserFileEN.CheckPropertyNew();
clsUserFileEN objUserFileCond = new clsUserFileEN();
string strCondition = objUserFileCond
.SetFileName(objUserFileEN.FileName, "=")
.GetCombineCondition();
objUserFileEN._IsCheckProperty = true;
bool bolIsExist = clsUserFileBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserFileEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserFileEN objUserFileEN)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserFileBL.UserFileDA.UpdateBySql2(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserFileEN objUserFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserFileBL.UserFileDA.UpdateBySql2(objUserFileEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUserFileEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserFileEN objUserFileEN, string strWhereCond)
{
try
{
bool bolResult = clsUserFileBL.UserFileDA.UpdateBySqlWithCondition(objUserFileEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objUserFileEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserFileEN objUserFileEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserFileBL.UserFileDA.UpdateBySqlWithConditionTransaction(objUserFileEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strFileName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUserFileEN objUserFileEN)
{
try
{
int intRecNum = clsUserFileBL.UserFileDA.DelRecord(objUserFileEN.FileName);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objUserFileENS">源对象</param>
 /// <param name = "objUserFileENT">目标对象</param>
 public static void CopyTo(this clsUserFileEN objUserFileENS, clsUserFileEN objUserFileENT)
{
try
{
objUserFileENT.FileName = objUserFileENS.FileName; //文件名称
objUserFileENT.OrderNum = objUserFileENS.OrderNum; //序号
objUserFileENT.FileSize = objUserFileENS.FileSize; //文件大小
objUserFileENT.Extension = objUserFileENS.Extension; //扩展名
objUserFileENT.ResourceTypeName = objUserFileENS.ResourceTypeName; //资源类型名称
objUserFileENT.FileSizeUnit = objUserFileENS.FileSizeUnit; //文件大小单位
objUserFileENT.ResourcePicPath = objUserFileENS.ResourcePicPath; //图片位置
objUserFileENT.UploadDateTime = objUserFileENS.UploadDateTime; //上传时间
objUserFileENT.FileNamePath = objUserFileENS.FileNamePath; //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objUserFileENS">源对象</param>
 /// <returns>目标对象=>clsUserFileEN:objUserFileENT</returns>
 public static clsUserFileEN CopyTo(this clsUserFileEN objUserFileENS)
{
try
{
 clsUserFileEN objUserFileENT = new clsUserFileEN()
{
FileName = objUserFileENS.FileName, //文件名称
OrderNum = objUserFileENS.OrderNum, //序号
FileSize = objUserFileENS.FileSize, //文件大小
Extension = objUserFileENS.Extension, //扩展名
ResourceTypeName = objUserFileENS.ResourceTypeName, //资源类型名称
FileSizeUnit = objUserFileENS.FileSizeUnit, //文件大小单位
ResourcePicPath = objUserFileENS.ResourcePicPath, //图片位置
UploadDateTime = objUserFileENS.UploadDateTime, //上传时间
FileNamePath = objUserFileENS.FileNamePath, //文件路径
};
 return objUserFileENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsUserFileEN objUserFileEN)
{
 clsUserFileBL.UserFileDA.CheckPropertyNew(objUserFileEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserFileEN objUserFileEN)
{
 clsUserFileBL.UserFileDA.CheckProperty4Condition(objUserFileEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserFileEN objUserFileCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserFileCond.IsUpdated(conUserFile.FileName) == true)
{
string strComparisonOpFileName = objUserFileCond.dicFldComparisonOp[conUserFile.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.FileName, objUserFileCond.FileName, strComparisonOpFileName);
}
if (objUserFileCond.IsUpdated(conUserFile.OrderNum) == true)
{
string strComparisonOpOrderNum = objUserFileCond.dicFldComparisonOp[conUserFile.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conUserFile.OrderNum, objUserFileCond.OrderNum, strComparisonOpOrderNum);
}
if (objUserFileCond.IsUpdated(conUserFile.FileSize) == true)
{
string strComparisonOpFileSize = objUserFileCond.dicFldComparisonOp[conUserFile.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", conUserFile.FileSize, objUserFileCond.FileSize, strComparisonOpFileSize);
}
if (objUserFileCond.IsUpdated(conUserFile.Extension) == true)
{
string strComparisonOpExtension = objUserFileCond.dicFldComparisonOp[conUserFile.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.Extension, objUserFileCond.Extension, strComparisonOpExtension);
}
if (objUserFileCond.IsUpdated(conUserFile.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objUserFileCond.dicFldComparisonOp[conUserFile.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.ResourceTypeName, objUserFileCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objUserFileCond.IsUpdated(conUserFile.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objUserFileCond.dicFldComparisonOp[conUserFile.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.FileSizeUnit, objUserFileCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objUserFileCond.IsUpdated(conUserFile.ResourcePicPath) == true)
{
string strComparisonOpResourcePicPath = objUserFileCond.dicFldComparisonOp[conUserFile.ResourcePicPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.ResourcePicPath, objUserFileCond.ResourcePicPath, strComparisonOpResourcePicPath);
}
if (objUserFileCond.IsUpdated(conUserFile.UploadDateTime) == true)
{
string strComparisonOpUploadDateTime = objUserFileCond.dicFldComparisonOp[conUserFile.UploadDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.UploadDateTime, objUserFileCond.UploadDateTime, strComparisonOpUploadDateTime);
}
if (objUserFileCond.IsUpdated(conUserFile.FileNamePath) == true)
{
string strComparisonOpFileNamePath = objUserFileCond.dicFldComparisonOp[conUserFile.FileNamePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserFile.FileNamePath, objUserFileCond.FileNamePath, strComparisonOpFileNamePath);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserFile
{
public virtual bool UpdRelaTabDate(string strFileName, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程资源管理(UserFile)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserFileBL
{
public static RelatedActions_UserFile relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserFileDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserFileDA UserFileDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserFileDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsUserFileBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsUserFileEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserFileEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_UserFile(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable_UserFile(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = UserFileDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrFileNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUserFileEN> GetObjLstByFileNameLst(List<string> arrFileNameLst)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFileNameLst, true);
 string strWhereCond = string.Format("FileName in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFileNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserFileEN> GetObjLstByFileNameLstCache(List<string> arrFileNameLst)
{
string strKey = string.Format("{0}", clsUserFileEN._CurrTabName);
List<clsUserFileEN> arrUserFileObjLstCache = GetObjLstCache();
IEnumerable <clsUserFileEN> arrUserFileObjLst_Sel =
arrUserFileObjLstCache
.Where(x => arrFileNameLst.Contains(x.FileName));
return arrUserFileObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetObjLst(string strWhereCond)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserFileCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserFileEN> GetSubObjLstCache(clsUserFileEN objUserFileCond)
{
List<clsUserFileEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserFileEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserFile.AttributeName)
{
if (objUserFileCond.IsUpdated(strFldName) == false) continue;
if (objUserFileCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserFileCond[strFldName].ToString());
}
else
{
if (objUserFileCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserFileCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserFileCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserFileCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserFileCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserFileCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsUserFileEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserFileEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserFileEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserFileEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserFileEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserFileEN> arrObjLst = new List<clsUserFileEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserFileEN objUserFileEN = new clsUserFileEN();
try
{
objUserFileEN.FileName = objRow[conUserFile.FileName].ToString().Trim(); //文件名称
objUserFileEN.OrderNum = objRow[conUserFile.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserFile.OrderNum].ToString().Trim()); //序号
objUserFileEN.FileSize = Double.Parse(objRow[conUserFile.FileSize].ToString().Trim()); //文件大小
objUserFileEN.Extension = objRow[conUserFile.Extension] == DBNull.Value ? null : objRow[conUserFile.Extension].ToString().Trim(); //扩展名
objUserFileEN.ResourceTypeName = objRow[conUserFile.ResourceTypeName] == DBNull.Value ? null : objRow[conUserFile.ResourceTypeName].ToString().Trim(); //资源类型名称
objUserFileEN.FileSizeUnit = objRow[conUserFile.FileSizeUnit] == DBNull.Value ? null : objRow[conUserFile.FileSizeUnit].ToString().Trim(); //文件大小单位
objUserFileEN.ResourcePicPath = objRow[conUserFile.ResourcePicPath] == DBNull.Value ? null : objRow[conUserFile.ResourcePicPath].ToString().Trim(); //图片位置
objUserFileEN.UploadDateTime = objRow[conUserFile.UploadDateTime] == DBNull.Value ? null : objRow[conUserFile.UploadDateTime].ToString().Trim(); //上传时间
objUserFileEN.FileNamePath = objRow[conUserFile.FileNamePath] == DBNull.Value ? null : objRow[conUserFile.FileNamePath].ToString().Trim(); //文件路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserFileEN.FileName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserFileEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserFileEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserFile(ref clsUserFileEN objUserFileEN)
{
bool bolResult = UserFileDA.GetUserFile(ref objUserFileEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFileName">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserFileEN GetObjByFileName(string strFileName)
{
if (strFileName.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFileName]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFileName) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFileName]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsUserFileEN objUserFileEN = UserFileDA.GetObjByFileName(strFileName);
return objUserFileEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserFileEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserFileEN objUserFileEN = UserFileDA.GetFirstObj(strWhereCond);
 return objUserFileEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsUserFileEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserFileEN objUserFileEN = UserFileDA.GetObjByDataRow(objRow);
 return objUserFileEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsUserFileEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserFileEN objUserFileEN = UserFileDA.GetObjByDataRow(objRow);
 return objUserFileEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strFileName">所给的关键字</param>
 /// <param name = "lstUserFileObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserFileEN GetObjByFileNameFromList(string strFileName, List<clsUserFileEN> lstUserFileObjLst)
{
foreach (clsUserFileEN objUserFileEN in lstUserFileObjLst)
{
if (objUserFileEN.FileName == strFileName)
{
return objUserFileEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strFileName;
 try
 {
 strFileName = new clsUserFileDA().GetFirstID(strWhereCond);
 return strFileName;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = UserFileDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = UserFileDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFileName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFileName)
{
if (string.IsNullOrEmpty(strFileName) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFileName]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = UserFileDA.IsExist(strFileName);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsUserFileDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = UserFileDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserFileEN objUserFileEN)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserFileBL.IsExist(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserFileEN.FileName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = UserFileDA.AddNewRecordBySQL2(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserFileEN objUserFileEN)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserFileBL.IsExist(objUserFileEN.FileName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserFileEN.FileName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = UserFileDA.AddNewRecordBySQL2WithReturnKey(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserFileEN objUserFileEN)
{
try
{
bool bolResult = UserFileDA.Update(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objUserFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserFileEN objUserFileEN)
{
 if (string.IsNullOrEmpty(objUserFileEN.FileName) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserFileDA.UpdateBySql2(objUserFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshCache();

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strFileName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFileName)
{
try
{
 clsUserFileEN objUserFileEN = clsUserFileBL.GetObjByFileName(strFileName);

if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(objUserFileEN.FileName, "SetUpdDate");
}
if (objUserFileEN != null)
{
int intRecNum = UserFileDA.DelRecord(strFileName);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strFileName">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFileName )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserFileDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[UserFile]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserFile.FileName,
//strFileName);
//        clsUserFileBL.DelUserFilesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserFileBL.DelRecord(strFileName, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserFileBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFileName, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strFileName">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFileName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserFileBL.relatedActions != null)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(strFileName, "UpdRelaTabDate");
}
bool bolResult = UserFileDA.DelRecord(strFileName,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrFileNameLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUserFiles(List<string> arrFileNameLst)
{
if (arrFileNameLst.Count == 0) return 0;
try
{
if (clsUserFileBL.relatedActions != null)
{
foreach (var strFileName in arrFileNameLst)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(strFileName, "UpdRelaTabDate");
}
}
int intDelRecNum = UserFileDA.DelUserFile(arrFileNameLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelUserFilesByCond(string strWhereCond)
{
try
{
if (clsUserFileBL.relatedActions != null)
{
List<string> arrFileName = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFileName in arrFileName)
{
clsUserFileBL.relatedActions.UpdRelaTabDate(strFileName, "UpdRelaTabDate");
}
}
int intRecNum = UserFileDA.DelUserFile(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserFile]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFileName">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFileName)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserFileDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[UserFile]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserFileBL.DelRecord(strFileName, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserFileBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFileName, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objUserFileENS">源对象</param>
 /// <param name = "objUserFileENT">目标对象</param>
 public static void CopyTo(clsUserFileEN objUserFileENS, clsUserFileEN objUserFileENT)
{
try
{
objUserFileENT.FileName = objUserFileENS.FileName; //文件名称
objUserFileENT.OrderNum = objUserFileENS.OrderNum; //序号
objUserFileENT.FileSize = objUserFileENS.FileSize; //文件大小
objUserFileENT.Extension = objUserFileENS.Extension; //扩展名
objUserFileENT.ResourceTypeName = objUserFileENS.ResourceTypeName; //资源类型名称
objUserFileENT.FileSizeUnit = objUserFileENS.FileSizeUnit; //文件大小单位
objUserFileENT.ResourcePicPath = objUserFileENS.ResourcePicPath; //图片位置
objUserFileENT.UploadDateTime = objUserFileENS.UploadDateTime; //上传时间
objUserFileENT.FileNamePath = objUserFileENS.FileNamePath; //文件路径
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objUserFileEN">源简化对象</param>
 public static void SetUpdFlag(clsUserFileEN objUserFileEN)
{
try
{
objUserFileEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserFileEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserFile.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.FileName = objUserFileEN.FileName; //文件名称
}
if (arrFldSet.Contains(conUserFile.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.OrderNum = objUserFileEN.OrderNum; //序号
}
if (arrFldSet.Contains(conUserFile.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.FileSize = objUserFileEN.FileSize; //文件大小
}
if (arrFldSet.Contains(conUserFile.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.Extension = objUserFileEN.Extension == "[null]" ? null :  objUserFileEN.Extension; //扩展名
}
if (arrFldSet.Contains(conUserFile.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.ResourceTypeName = objUserFileEN.ResourceTypeName == "[null]" ? null :  objUserFileEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(conUserFile.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.FileSizeUnit = objUserFileEN.FileSizeUnit == "[null]" ? null :  objUserFileEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(conUserFile.ResourcePicPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.ResourcePicPath = objUserFileEN.ResourcePicPath == "[null]" ? null :  objUserFileEN.ResourcePicPath; //图片位置
}
if (arrFldSet.Contains(conUserFile.UploadDateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.UploadDateTime = objUserFileEN.UploadDateTime == "[null]" ? null :  objUserFileEN.UploadDateTime; //上传时间
}
if (arrFldSet.Contains(conUserFile.FileNamePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserFileEN.FileNamePath = objUserFileEN.FileNamePath == "[null]" ? null :  objUserFileEN.FileNamePath; //文件路径
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objUserFileEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserFileEN objUserFileEN)
{
try
{
if (objUserFileEN.Extension == "[null]") objUserFileEN.Extension = null; //扩展名
if (objUserFileEN.ResourceTypeName == "[null]") objUserFileEN.ResourceTypeName = null; //资源类型名称
if (objUserFileEN.FileSizeUnit == "[null]") objUserFileEN.FileSizeUnit = null; //文件大小单位
if (objUserFileEN.ResourcePicPath == "[null]") objUserFileEN.ResourcePicPath = null; //图片位置
if (objUserFileEN.UploadDateTime == "[null]") objUserFileEN.UploadDateTime = null; //上传时间
if (objUserFileEN.FileNamePath == "[null]") objUserFileEN.FileNamePath = null; //文件路径
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserFileEN objUserFileEN)
{
 UserFileDA.CheckPropertyNew(objUserFileEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserFileEN objUserFileEN)
{
 UserFileDA.CheckProperty4Condition(objUserFileEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsUserFileBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserFileBL没有刷新缓存机制(clsUserFileBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FileName");
//if (arrUserFileObjLstCache == null)
//{
//arrUserFileObjLstCache = UserFileDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFileName">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserFileEN GetObjByFileNameCache(string strFileName)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUserFileEN._CurrTabName);
List<clsUserFileEN> arrUserFileObjLstCache = GetObjLstCache();
IEnumerable <clsUserFileEN> arrUserFileObjLst_Sel =
arrUserFileObjLstCache
.Where(x=> x.FileName == strFileName 
);
if (arrUserFileObjLst_Sel.Count() == 0)
{
   clsUserFileEN obj = clsUserFileBL.GetObjByFileName(strFileName);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUserFileObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserFileEN> GetAllUserFileObjLstCache()
{
//获取缓存中的对象列表
List<clsUserFileEN> arrUserFileObjLstCache = GetObjLstCache(); 
return arrUserFileObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserFileEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUserFileEN._CurrTabName);
List<clsUserFileEN> arrUserFileObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUserFileObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsUserFileEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsUserFileBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserFileEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserFileBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFileName)
{
if (strInFldName != conUserFile.FileName)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserFile.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserFile.AttributeName));
throw new Exception(strMsg);
}
var objUserFile = clsUserFileBL.GetObjByFileNameCache(strFileName);
if (objUserFile == null) return "";
return objUserFile[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsUserFileDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsUserFileDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserFileDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsUserFileDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserFileCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserFileEN objUserFileCond)
{
List<clsUserFileEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserFileEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserFile.AttributeName)
{
if (objUserFileCond.IsUpdated(strFldName) == false) continue;
if (objUserFileCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserFileCond[strFldName].ToString());
}
else
{
if (objUserFileCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserFileCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserFileCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserFileCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserFileCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserFileCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsUserFileDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = UserFileDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = UserFileDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = UserFileDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsUserFileDA.SetFldValue(clsUserFileEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = UserFileDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsUserFileDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsUserFileDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsUserFileDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[UserFile] "); 
 strCreateTabCode.Append(" ( "); 
 // /**文件名称*/ 
 strCreateTabCode.Append(" FileName varchar(500) primary key, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**文件大小*/ 
 strCreateTabCode.Append(" FileSize decimal(22,0) not Null, "); 
 // /**扩展名*/ 
 strCreateTabCode.Append(" Extension varchar(10) Null, "); 
 // /**资源类型名称*/ 
 strCreateTabCode.Append(" ResourceTypeName varchar(50) Null, "); 
 // /**文件大小单位*/ 
 strCreateTabCode.Append(" FileSizeUnit varchar(10) Null, "); 
 // /**图片位置*/ 
 strCreateTabCode.Append(" ResourcePicPath varchar(500) Null, "); 
 // /**上传时间*/ 
 strCreateTabCode.Append(" UploadDateTime varchar(200) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FileNamePath varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课程资源管理(UserFile)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserFile : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserFileBL.ReFreshThisCache();
}
}

}