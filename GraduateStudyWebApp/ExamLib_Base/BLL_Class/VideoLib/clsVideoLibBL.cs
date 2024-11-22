
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLibBL
 表名:VideoLib(01120261)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
public static class  clsVideoLibBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoLibEN GetObj(this K_IdVideoLib_VideoLib myKey)
{
clsVideoLibEN objVideoLibEN = clsVideoLibBL.VideoLibDA.GetObjByIdVideoLib(myKey.Value);
return objVideoLibEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsVideoLibBL.IsExist(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objVideoLibEN.IdVideoLib, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsVideoLibBL.VideoLibDA.AddNewRecordBySQL2(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
public static bool AddRecordEx(this clsVideoLibEN objVideoLibEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsVideoLibBL.IsExist(objVideoLibEN.IdVideoLib))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objVideoLibEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objVideoLibEN.AddNewRecord();
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsVideoLibBL.IsExist(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objVideoLibEN.IdVideoLib, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsVideoLibBL.VideoLibDA.AddNewRecordBySQL2WithReturnKey(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetIdVideoLib(this clsVideoLibEN objVideoLibEN, string strIdVideoLib, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLib, 8, conVideoLib.IdVideoLib);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLib, 8, conVideoLib.IdVideoLib);
}
objVideoLibEN.IdVideoLib = strIdVideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IdVideoLib) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IdVideoLib, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IdVideoLib] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibID(this clsVideoLibEN objVideoLibEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibID, conVideoLib.VideoLibID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, conVideoLib.VideoLibID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, conVideoLib.VideoLibID);
}
objVideoLibEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibID) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibID, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibID] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibName(this clsVideoLibEN objVideoLibEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVideoLibName, conVideoLib.VideoLibName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, conVideoLib.VideoLibName);
}
objVideoLibEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibName) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibName, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibName] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibTheme(this clsVideoLibEN objVideoLibEN, string strVideoLibTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTheme, 200, conVideoLib.VideoLibTheme);
}
objVideoLibEN.VideoLibTheme = strVideoLibTheme; //视频库主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibTheme) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibTheme, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibTheme] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetIdVideoLibType(this clsVideoLibEN objVideoLibEN, string strIdVideoLibType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdVideoLibType, conVideoLib.IdVideoLibType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLibType, 4, conVideoLib.IdVideoLibType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLibType, 4, conVideoLib.IdVideoLibType);
}
objVideoLibEN.IdVideoLibType = strIdVideoLibType; //视频库类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IdVideoLibType) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IdVideoLibType, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IdVideoLibType] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibText(this clsVideoLibEN objVideoLibEN, string strVideoLibText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibText, 8000, conVideoLib.VideoLibText);
}
objVideoLibEN.VideoLibText = strVideoLibText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibText) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibText, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibText] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibDate(this clsVideoLibEN objVideoLibEN, string strVideoLibDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDate, 20, conVideoLib.VideoLibDate);
}
objVideoLibEN.VideoLibDate = strVideoLibDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibDate) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibDate, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibDate] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibTime(this clsVideoLibEN objVideoLibEN, string strVideoLibTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTime, 6, conVideoLib.VideoLibTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTime, 6, conVideoLib.VideoLibTime);
}
objVideoLibEN.VideoLibTime = strVideoLibTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibTime) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibTime, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibTime] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibDateIn(this clsVideoLibEN objVideoLibEN, string strVideoLibDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibDateIn, 8, conVideoLib.VideoLibDateIn);
}
objVideoLibEN.VideoLibDateIn = strVideoLibDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibDateIn) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibDateIn, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibDateIn] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoLibTimeIn(this clsVideoLibEN objVideoLibEN, string strVideoLibTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVideoLibTimeIn, 6, conVideoLib.VideoLibTimeIn);
}
objVideoLibEN.VideoLibTimeIn = strVideoLibTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoLibTimeIn) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoLibTimeIn, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoLibTimeIn] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetOwnerId(this clsVideoLibEN objVideoLibEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conVideoLib.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conVideoLib.OwnerId);
}
objVideoLibEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.OwnerId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.OwnerId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.OwnerId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetIdTeachingPlan(this clsVideoLibEN objVideoLibEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conVideoLib.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conVideoLib.IdTeachingPlan);
}
objVideoLibEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IdTeachingPlan) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IdTeachingPlan, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IdTeachingPlan] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetBrowseCount(this clsVideoLibEN objVideoLibEN, int? intBrowseCount, string strComparisonOp="")
	{
objVideoLibEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.BrowseCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.BrowseCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.BrowseCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetIdSenateGaugeVersion(this clsVideoLibEN objVideoLibEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conVideoLib.IdSenateGaugeVersion);
}
objVideoLibEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IdSenateGaugeVersion) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetCaseLevelId(this clsVideoLibEN objVideoLibEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conVideoLib.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conVideoLib.CaseLevelId);
}
objVideoLibEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CaseLevelId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CaseLevelId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CaseLevelId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetIsVisible(this clsVideoLibEN objVideoLibEN, bool bolIsVisible, string strComparisonOp="")
	{
objVideoLibEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IsVisible) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IsVisible, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IsVisible] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetIdXzCollege(this clsVideoLibEN objVideoLibEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conVideoLib.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conVideoLib.IdXzCollege);
}
objVideoLibEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.IdXzCollege) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.IdXzCollege, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.IdXzCollege] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetViewCount(this clsVideoLibEN objVideoLibEN, int? intViewCount, string strComparisonOp="")
	{
objVideoLibEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.ViewCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.ViewCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.ViewCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetDownloadNumber(this clsVideoLibEN objVideoLibEN, int? intDownloadNumber, string strComparisonOp="")
	{
objVideoLibEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.DownloadNumber) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.DownloadNumber, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.DownloadNumber] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetFileIntegration(this clsVideoLibEN objVideoLibEN, int? intFileIntegration, string strComparisonOp="")
	{
objVideoLibEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.FileIntegration) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.FileIntegration, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.FileIntegration] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetLikeCount(this clsVideoLibEN objVideoLibEN, long? lngLikeCount, string strComparisonOp="")
	{
objVideoLibEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.LikeCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.LikeCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.LikeCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetCollectionCount(this clsVideoLibEN objVideoLibEN, long? lngCollectionCount, string strComparisonOp="")
	{
objVideoLibEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CollectionCount) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CollectionCount, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CollectionCount] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetRecommendedDegreeId(this clsVideoLibEN objVideoLibEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conVideoLib.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conVideoLib.RecommendedDegreeId);
}
objVideoLibEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.RecommendedDegreeId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.RecommendedDegreeId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.RecommendedDegreeId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetCourseId(this clsVideoLibEN objVideoLibEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conVideoLib.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conVideoLib.CourseId);
}
objVideoLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CourseId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CourseId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CourseId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoUrl(this clsVideoLibEN objVideoLibEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conVideoLib.VideoUrl);
}
objVideoLibEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoUrl) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoUrl, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoUrl] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetVideoPath(this clsVideoLibEN objVideoLibEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conVideoLib.VideoPath);
}
objVideoLibEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.VideoPath) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.VideoPath, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.VideoPath] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetCoverPicUrl(this clsVideoLibEN objVideoLibEN, string strCoverPicUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, conVideoLib.CoverPicUrl);
}
objVideoLibEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CoverPicUrl) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CoverPicUrl, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CoverPicUrl] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetCoverPicShortUrl(this clsVideoLibEN objVideoLibEN, string strCoverPicShortUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCoverPicShortUrl, 1000, conVideoLib.CoverPicShortUrl);
}
objVideoLibEN.CoverPicShortUrl = strCoverPicShortUrl; //封面短Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.CoverPicShortUrl) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.CoverPicShortUrl, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.CoverPicShortUrl] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetResErrMsg(this clsVideoLibEN objVideoLibEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conVideoLib.ResErrMsg);
}
objVideoLibEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.ResErrMsg) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.ResErrMsg, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.ResErrMsg] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetUpdDate(this clsVideoLibEN objVideoLibEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conVideoLib.UpdDate);
}
objVideoLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.UpdDate) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.UpdDate, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.UpdDate] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetUpdUserId(this clsVideoLibEN objVideoLibEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conVideoLib.UpdUserId);
}
objVideoLibEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.UpdUserId) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.UpdUserId, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.UpdUserId] = strComparisonOp;
}
}
return objVideoLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLibEN SetMemo(this clsVideoLibEN objVideoLibEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conVideoLib.Memo);
}
objVideoLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLibEN.dicFldComparisonOp.ContainsKey(conVideoLib.Memo) == false)
{
objVideoLibEN.dicFldComparisonOp.Add(conVideoLib.Memo, strComparisonOp);
}
else
{
objVideoLibEN.dicFldComparisonOp[conVideoLib.Memo] = strComparisonOp;
}
}
return objVideoLibEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objVideoLibEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsVideoLibEN objVideoLibEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objVideoLibEN.CheckPropertyNew();
clsVideoLibEN objVideoLibCond = new clsVideoLibEN();
string strCondition = objVideoLibCond
.SetIdVideoLib(objVideoLibEN.IdVideoLib, "=")
.GetCombineCondition();
objVideoLibEN._IsCheckProperty = true;
bool bolIsExist = clsVideoLibBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objVideoLibEN.Update();
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsVideoLibBL.VideoLibDA.UpdateBySql2(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVideoLibEN objVideoLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsVideoLibBL.VideoLibDA.UpdateBySql2(objVideoLibEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVideoLibEN objVideoLibEN, string strWhereCond)
{
try
{
bool bolResult = clsVideoLibBL.VideoLibDA.UpdateBySqlWithCondition(objVideoLibEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVideoLibEN objVideoLibEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsVideoLibBL.VideoLibDA.UpdateBySqlWithConditionTransaction(objVideoLibEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsVideoLibEN objVideoLibEN)
{
try
{
int intRecNum = clsVideoLibBL.VideoLibDA.DelRecord(objVideoLibEN.IdVideoLib);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibENS">源对象</param>
 /// <param name = "objVideoLibENT">目标对象</param>
 public static void CopyTo(this clsVideoLibEN objVideoLibENS, clsVideoLibEN objVideoLibENT)
{
try
{
objVideoLibENT.IdVideoLib = objVideoLibENS.IdVideoLib; //视频库流水号
objVideoLibENT.VideoLibID = objVideoLibENS.VideoLibID; //视频库ID
objVideoLibENT.VideoLibName = objVideoLibENS.VideoLibName; //视频名称
objVideoLibENT.VideoLibTheme = objVideoLibENS.VideoLibTheme; //视频库主题词
objVideoLibENT.IdVideoLibType = objVideoLibENS.IdVideoLibType; //视频库类型流水号
objVideoLibENT.VideoLibText = objVideoLibENS.VideoLibText; //案例文本内容
objVideoLibENT.VideoLibDate = objVideoLibENS.VideoLibDate; //视频资源日期
objVideoLibENT.VideoLibTime = objVideoLibENS.VideoLibTime; //视频资源时间
objVideoLibENT.VideoLibDateIn = objVideoLibENS.VideoLibDateIn; //案例入库日期
objVideoLibENT.VideoLibTimeIn = objVideoLibENS.VideoLibTimeIn; //案例入库时间
objVideoLibENT.OwnerId = objVideoLibENS.OwnerId; //拥有者Id
objVideoLibENT.IdTeachingPlan = objVideoLibENS.IdTeachingPlan; //教案流水号
objVideoLibENT.BrowseCount = objVideoLibENS.BrowseCount; //浏览次数
objVideoLibENT.IdSenateGaugeVersion = objVideoLibENS.IdSenateGaugeVersion; //评价量表版本流水号
objVideoLibENT.CaseLevelId = objVideoLibENS.CaseLevelId; //课例等级Id
objVideoLibENT.IsVisible = objVideoLibENS.IsVisible; //是否显示
objVideoLibENT.IdXzCollege = objVideoLibENS.IdXzCollege; //学院流水号
objVideoLibENT.ViewCount = objVideoLibENS.ViewCount; //浏览量
objVideoLibENT.DownloadNumber = objVideoLibENS.DownloadNumber; //下载数目
objVideoLibENT.FileIntegration = objVideoLibENS.FileIntegration; //文件积分
objVideoLibENT.LikeCount = objVideoLibENS.LikeCount; //资源喜欢数量
objVideoLibENT.CollectionCount = objVideoLibENS.CollectionCount; //收藏数量
objVideoLibENT.RecommendedDegreeId = objVideoLibENS.RecommendedDegreeId; //推荐度Id
objVideoLibENT.CourseId = objVideoLibENS.CourseId; //课程Id
objVideoLibENT.VideoUrl = objVideoLibENS.VideoUrl; //视频Url
objVideoLibENT.VideoPath = objVideoLibENS.VideoPath; //视频目录
objVideoLibENT.CoverPicUrl = objVideoLibENS.CoverPicUrl; //封面Url
objVideoLibENT.CoverPicShortUrl = objVideoLibENS.CoverPicShortUrl; //封面短Url
objVideoLibENT.ResErrMsg = objVideoLibENS.ResErrMsg; //资源错误信息
objVideoLibENT.UpdDate = objVideoLibENS.UpdDate; //修改日期
objVideoLibENT.UpdUserId = objVideoLibENS.UpdUserId; //修改用户Id
objVideoLibENT.Memo = objVideoLibENS.Memo; //备注
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
 /// <param name = "objVideoLibENS">源对象</param>
 /// <returns>目标对象=>clsVideoLibEN:objVideoLibENT</returns>
 public static clsVideoLibEN CopyTo(this clsVideoLibEN objVideoLibENS)
{
try
{
 clsVideoLibEN objVideoLibENT = new clsVideoLibEN()
{
IdVideoLib = objVideoLibENS.IdVideoLib, //视频库流水号
VideoLibID = objVideoLibENS.VideoLibID, //视频库ID
VideoLibName = objVideoLibENS.VideoLibName, //视频名称
VideoLibTheme = objVideoLibENS.VideoLibTheme, //视频库主题词
IdVideoLibType = objVideoLibENS.IdVideoLibType, //视频库类型流水号
VideoLibText = objVideoLibENS.VideoLibText, //案例文本内容
VideoLibDate = objVideoLibENS.VideoLibDate, //视频资源日期
VideoLibTime = objVideoLibENS.VideoLibTime, //视频资源时间
VideoLibDateIn = objVideoLibENS.VideoLibDateIn, //案例入库日期
VideoLibTimeIn = objVideoLibENS.VideoLibTimeIn, //案例入库时间
OwnerId = objVideoLibENS.OwnerId, //拥有者Id
IdTeachingPlan = objVideoLibENS.IdTeachingPlan, //教案流水号
BrowseCount = objVideoLibENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objVideoLibENS.IdSenateGaugeVersion, //评价量表版本流水号
CaseLevelId = objVideoLibENS.CaseLevelId, //课例等级Id
IsVisible = objVideoLibENS.IsVisible, //是否显示
IdXzCollege = objVideoLibENS.IdXzCollege, //学院流水号
ViewCount = objVideoLibENS.ViewCount, //浏览量
DownloadNumber = objVideoLibENS.DownloadNumber, //下载数目
FileIntegration = objVideoLibENS.FileIntegration, //文件积分
LikeCount = objVideoLibENS.LikeCount, //资源喜欢数量
CollectionCount = objVideoLibENS.CollectionCount, //收藏数量
RecommendedDegreeId = objVideoLibENS.RecommendedDegreeId, //推荐度Id
CourseId = objVideoLibENS.CourseId, //课程Id
VideoUrl = objVideoLibENS.VideoUrl, //视频Url
VideoPath = objVideoLibENS.VideoPath, //视频目录
CoverPicUrl = objVideoLibENS.CoverPicUrl, //封面Url
CoverPicShortUrl = objVideoLibENS.CoverPicShortUrl, //封面短Url
ResErrMsg = objVideoLibENS.ResErrMsg, //资源错误信息
UpdDate = objVideoLibENS.UpdDate, //修改日期
UpdUserId = objVideoLibENS.UpdUserId, //修改用户Id
Memo = objVideoLibENS.Memo, //备注
};
 return objVideoLibENT;
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
public static void CheckPropertyNew(this clsVideoLibEN objVideoLibEN)
{
 clsVideoLibBL.VideoLibDA.CheckPropertyNew(objVideoLibEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsVideoLibEN objVideoLibEN)
{
 clsVideoLibBL.VideoLibDA.CheckProperty4Condition(objVideoLibEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsVideoLibEN objVideoLibCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objVideoLibCond.IsUpdated(conVideoLib.IdVideoLib) == true)
{
string strComparisonOpIdVideoLib = objVideoLibCond.dicFldComparisonOp[conVideoLib.IdVideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.IdVideoLib, objVideoLibCond.IdVideoLib, strComparisonOpIdVideoLib);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibID) == true)
{
string strComparisonOpVideoLibID = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibID, objVideoLibCond.VideoLibID, strComparisonOpVideoLibID);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibName, objVideoLibCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibTheme) == true)
{
string strComparisonOpVideoLibTheme = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibTheme, objVideoLibCond.VideoLibTheme, strComparisonOpVideoLibTheme);
}
if (objVideoLibCond.IsUpdated(conVideoLib.IdVideoLibType) == true)
{
string strComparisonOpIdVideoLibType = objVideoLibCond.dicFldComparisonOp[conVideoLib.IdVideoLibType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.IdVideoLibType, objVideoLibCond.IdVideoLibType, strComparisonOpIdVideoLibType);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibText) == true)
{
string strComparisonOpVideoLibText = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibText, objVideoLibCond.VideoLibText, strComparisonOpVideoLibText);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibDate) == true)
{
string strComparisonOpVideoLibDate = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibDate, objVideoLibCond.VideoLibDate, strComparisonOpVideoLibDate);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibTime) == true)
{
string strComparisonOpVideoLibTime = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibTime, objVideoLibCond.VideoLibTime, strComparisonOpVideoLibTime);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibDateIn) == true)
{
string strComparisonOpVideoLibDateIn = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibDateIn, objVideoLibCond.VideoLibDateIn, strComparisonOpVideoLibDateIn);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoLibTimeIn) == true)
{
string strComparisonOpVideoLibTimeIn = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoLibTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoLibTimeIn, objVideoLibCond.VideoLibTimeIn, strComparisonOpVideoLibTimeIn);
}
if (objVideoLibCond.IsUpdated(conVideoLib.OwnerId) == true)
{
string strComparisonOpOwnerId = objVideoLibCond.dicFldComparisonOp[conVideoLib.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.OwnerId, objVideoLibCond.OwnerId, strComparisonOpOwnerId);
}
if (objVideoLibCond.IsUpdated(conVideoLib.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objVideoLibCond.dicFldComparisonOp[conVideoLib.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.IdTeachingPlan, objVideoLibCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objVideoLibCond.IsUpdated(conVideoLib.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objVideoLibCond.dicFldComparisonOp[conVideoLib.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.BrowseCount, objVideoLibCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objVideoLibCond.IsUpdated(conVideoLib.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objVideoLibCond.dicFldComparisonOp[conVideoLib.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.IdSenateGaugeVersion, objVideoLibCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objVideoLibCond.IsUpdated(conVideoLib.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objVideoLibCond.dicFldComparisonOp[conVideoLib.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CaseLevelId, objVideoLibCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objVideoLibCond.IsUpdated(conVideoLib.IsVisible) == true)
{
if (objVideoLibCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conVideoLib.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conVideoLib.IsVisible);
}
}
if (objVideoLibCond.IsUpdated(conVideoLib.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objVideoLibCond.dicFldComparisonOp[conVideoLib.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.IdXzCollege, objVideoLibCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objVideoLibCond.IsUpdated(conVideoLib.ViewCount) == true)
{
string strComparisonOpViewCount = objVideoLibCond.dicFldComparisonOp[conVideoLib.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.ViewCount, objVideoLibCond.ViewCount, strComparisonOpViewCount);
}
if (objVideoLibCond.IsUpdated(conVideoLib.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objVideoLibCond.dicFldComparisonOp[conVideoLib.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.DownloadNumber, objVideoLibCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objVideoLibCond.IsUpdated(conVideoLib.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objVideoLibCond.dicFldComparisonOp[conVideoLib.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.FileIntegration, objVideoLibCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objVideoLibCond.IsUpdated(conVideoLib.LikeCount) == true)
{
string strComparisonOpLikeCount = objVideoLibCond.dicFldComparisonOp[conVideoLib.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.LikeCount, objVideoLibCond.LikeCount, strComparisonOpLikeCount);
}
if (objVideoLibCond.IsUpdated(conVideoLib.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objVideoLibCond.dicFldComparisonOp[conVideoLib.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLib.CollectionCount, objVideoLibCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objVideoLibCond.IsUpdated(conVideoLib.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objVideoLibCond.dicFldComparisonOp[conVideoLib.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.RecommendedDegreeId, objVideoLibCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objVideoLibCond.IsUpdated(conVideoLib.CourseId) == true)
{
string strComparisonOpCourseId = objVideoLibCond.dicFldComparisonOp[conVideoLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CourseId, objVideoLibCond.CourseId, strComparisonOpCourseId);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoUrl, objVideoLibCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objVideoLibCond.IsUpdated(conVideoLib.VideoPath) == true)
{
string strComparisonOpVideoPath = objVideoLibCond.dicFldComparisonOp[conVideoLib.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.VideoPath, objVideoLibCond.VideoPath, strComparisonOpVideoPath);
}
if (objVideoLibCond.IsUpdated(conVideoLib.CoverPicUrl) == true)
{
string strComparisonOpCoverPicUrl = objVideoLibCond.dicFldComparisonOp[conVideoLib.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CoverPicUrl, objVideoLibCond.CoverPicUrl, strComparisonOpCoverPicUrl);
}
if (objVideoLibCond.IsUpdated(conVideoLib.CoverPicShortUrl) == true)
{
string strComparisonOpCoverPicShortUrl = objVideoLibCond.dicFldComparisonOp[conVideoLib.CoverPicShortUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.CoverPicShortUrl, objVideoLibCond.CoverPicShortUrl, strComparisonOpCoverPicShortUrl);
}
if (objVideoLibCond.IsUpdated(conVideoLib.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objVideoLibCond.dicFldComparisonOp[conVideoLib.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.ResErrMsg, objVideoLibCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objVideoLibCond.IsUpdated(conVideoLib.UpdDate) == true)
{
string strComparisonOpUpdDate = objVideoLibCond.dicFldComparisonOp[conVideoLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.UpdDate, objVideoLibCond.UpdDate, strComparisonOpUpdDate);
}
if (objVideoLibCond.IsUpdated(conVideoLib.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objVideoLibCond.dicFldComparisonOp[conVideoLib.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.UpdUserId, objVideoLibCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objVideoLibCond.IsUpdated(conVideoLib.Memo) == true)
{
string strComparisonOpMemo = objVideoLibCond.dicFldComparisonOp[conVideoLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLib.Memo, objVideoLibCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_VideoLib
{
public virtual bool UpdRelaTabDate(string strIdVideoLib, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 视频库(VideoLib)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsVideoLibBL
{
public static RelatedActions_VideoLib relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsVideoLibDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsVideoLibDA VideoLibDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsVideoLibDA();
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
 public clsVideoLibBL()
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
if (string.IsNullOrEmpty(clsVideoLibEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsVideoLibEN._ConnectString);
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
public static DataTable GetDataTable_VideoLib(string strWhereCond)
{
DataTable objDT;
try
{
objDT = VideoLibDA.GetDataTable_VideoLib(strWhereCond);
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
objDT = VideoLibDA.GetDataTable(strWhereCond);
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
objDT = VideoLibDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = VideoLibDA.GetDataTable(strWhereCond, strTabName);
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
objDT = VideoLibDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = VideoLibDA.GetDataTable_Top(objTopPara);
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
objDT = VideoLibDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = VideoLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = VideoLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdVideoLibLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsVideoLibEN> GetObjLstByIdVideoLibLst(List<string> arrIdVideoLibLst)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdVideoLibLst, true);
 string strWhereCond = string.Format("IdVideoLib in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoLibLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsVideoLibEN> GetObjLstByIdVideoLibLstCache(List<string> arrIdVideoLibLst)
{
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName);
List<clsVideoLibEN> arrVideoLibObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLibEN> arrVideoLibObjLst_Sel =
arrVideoLibObjLstCache
.Where(x => arrIdVideoLibLst.Contains(x.IdVideoLib));
return arrVideoLibObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLibEN> GetObjLst(string strWhereCond)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
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
public static List<clsVideoLibEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objVideoLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsVideoLibEN> GetSubObjLstCache(clsVideoLibEN objVideoLibCond)
{
List<clsVideoLibEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conVideoLib.AttributeName)
{
if (objVideoLibCond.IsUpdated(strFldName) == false) continue;
if (objVideoLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLibCond[strFldName].ToString());
}
else
{
if (objVideoLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objVideoLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objVideoLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objVideoLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objVideoLibCond[strFldName]));
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
public static List<clsVideoLibEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
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
public static List<clsVideoLibEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
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
List<clsVideoLibEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsVideoLibEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLibEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsVideoLibEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
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
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
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
public static List<clsVideoLibEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsVideoLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsVideoLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
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
public static List<clsVideoLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLibEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsVideoLibEN> arrObjLst = new List<clsVideoLibEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLibEN objVideoLibEN = new clsVideoLibEN();
try
{
objVideoLibEN.IdVideoLib = objRow[conVideoLib.IdVideoLib].ToString().Trim(); //视频库流水号
objVideoLibEN.VideoLibID = objRow[conVideoLib.VideoLibID].ToString().Trim(); //视频库ID
objVideoLibEN.VideoLibName = objRow[conVideoLib.VideoLibName].ToString().Trim(); //视频名称
objVideoLibEN.VideoLibTheme = objRow[conVideoLib.VideoLibTheme] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTheme].ToString().Trim(); //视频库主题词
objVideoLibEN.IdVideoLibType = objRow[conVideoLib.IdVideoLibType].ToString().Trim(); //视频库类型流水号
objVideoLibEN.VideoLibText = objRow[conVideoLib.VideoLibText] == DBNull.Value ? null : objRow[conVideoLib.VideoLibText].ToString().Trim(); //案例文本内容
objVideoLibEN.VideoLibDate = objRow[conVideoLib.VideoLibDate] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDate].ToString().Trim(); //视频资源日期
objVideoLibEN.VideoLibTime = objRow[conVideoLib.VideoLibTime] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTime].ToString().Trim(); //视频资源时间
objVideoLibEN.VideoLibDateIn = objRow[conVideoLib.VideoLibDateIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibDateIn].ToString().Trim(); //案例入库日期
objVideoLibEN.VideoLibTimeIn = objRow[conVideoLib.VideoLibTimeIn] == DBNull.Value ? null : objRow[conVideoLib.VideoLibTimeIn].ToString().Trim(); //案例入库时间
objVideoLibEN.OwnerId = objRow[conVideoLib.OwnerId].ToString().Trim(); //拥有者Id
objVideoLibEN.IdTeachingPlan = objRow[conVideoLib.IdTeachingPlan] == DBNull.Value ? null : objRow[conVideoLib.IdTeachingPlan].ToString().Trim(); //教案流水号
objVideoLibEN.BrowseCount = objRow[conVideoLib.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.BrowseCount].ToString().Trim()); //浏览次数
objVideoLibEN.IdSenateGaugeVersion = objRow[conVideoLib.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conVideoLib.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objVideoLibEN.CaseLevelId = objRow[conVideoLib.CaseLevelId] == DBNull.Value ? null : objRow[conVideoLib.CaseLevelId].ToString().Trim(); //课例等级Id
objVideoLibEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conVideoLib.IsVisible].ToString().Trim()); //是否显示
objVideoLibEN.IdXzCollege = objRow[conVideoLib.IdXzCollege] == DBNull.Value ? null : objRow[conVideoLib.IdXzCollege].ToString().Trim(); //学院流水号
objVideoLibEN.ViewCount = objRow[conVideoLib.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.ViewCount].ToString().Trim()); //浏览量
objVideoLibEN.DownloadNumber = objRow[conVideoLib.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.DownloadNumber].ToString().Trim()); //下载数目
objVideoLibEN.FileIntegration = objRow[conVideoLib.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.FileIntegration].ToString().Trim()); //文件积分
objVideoLibEN.LikeCount = objRow[conVideoLib.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.LikeCount].ToString().Trim()); //资源喜欢数量
objVideoLibEN.CollectionCount = objRow[conVideoLib.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLib.CollectionCount].ToString().Trim()); //收藏数量
objVideoLibEN.RecommendedDegreeId = objRow[conVideoLib.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objVideoLibEN.CourseId = objRow[conVideoLib.CourseId] == DBNull.Value ? null : objRow[conVideoLib.CourseId].ToString().Trim(); //课程Id
objVideoLibEN.VideoUrl = objRow[conVideoLib.VideoUrl] == DBNull.Value ? null : objRow[conVideoLib.VideoUrl].ToString().Trim(); //视频Url
objVideoLibEN.VideoPath = objRow[conVideoLib.VideoPath] == DBNull.Value ? null : objRow[conVideoLib.VideoPath].ToString().Trim(); //视频目录
objVideoLibEN.CoverPicUrl = objRow[conVideoLib.CoverPicUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicUrl].ToString().Trim(); //封面Url
objVideoLibEN.CoverPicShortUrl = objRow[conVideoLib.CoverPicShortUrl] == DBNull.Value ? null : objRow[conVideoLib.CoverPicShortUrl].ToString().Trim(); //封面短Url
objVideoLibEN.ResErrMsg = objRow[conVideoLib.ResErrMsg] == DBNull.Value ? null : objRow[conVideoLib.ResErrMsg].ToString().Trim(); //资源错误信息
objVideoLibEN.UpdDate = objRow[conVideoLib.UpdDate] == DBNull.Value ? null : objRow[conVideoLib.UpdDate].ToString().Trim(); //修改日期
objVideoLibEN.UpdUserId = objRow[conVideoLib.UpdUserId] == DBNull.Value ? null : objRow[conVideoLib.UpdUserId].ToString().Trim(); //修改用户Id
objVideoLibEN.Memo = objRow[conVideoLib.Memo] == DBNull.Value ? null : objRow[conVideoLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLibEN.IdVideoLib, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLibEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objVideoLibEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetVideoLib(ref clsVideoLibEN objVideoLibEN)
{
bool bolResult = VideoLibDA.GetVideoLib(ref objVideoLibEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdVideoLib">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoLibEN GetObjByIdVideoLib(string strIdVideoLib)
{
if (strIdVideoLib.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdVideoLib]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdVideoLib) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdVideoLib]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsVideoLibEN objVideoLibEN = VideoLibDA.GetObjByIdVideoLib(strIdVideoLib);
return objVideoLibEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsVideoLibEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsVideoLibEN objVideoLibEN = VideoLibDA.GetFirstObj(strWhereCond);
 return objVideoLibEN;
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
public static clsVideoLibEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsVideoLibEN objVideoLibEN = VideoLibDA.GetObjByDataRow(objRow);
 return objVideoLibEN;
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
public static clsVideoLibEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsVideoLibEN objVideoLibEN = VideoLibDA.GetObjByDataRow(objRow);
 return objVideoLibEN;
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
 /// <param name = "strIdVideoLib">所给的关键字</param>
 /// <param name = "lstVideoLibObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVideoLibEN GetObjByIdVideoLibFromList(string strIdVideoLib, List<clsVideoLibEN> lstVideoLibObjLst)
{
foreach (clsVideoLibEN objVideoLibEN in lstVideoLibObjLst)
{
if (objVideoLibEN.IdVideoLib == strIdVideoLib)
{
return objVideoLibEN;
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
 string strIdVideoLib;
 try
 {
 strIdVideoLib = new clsVideoLibDA().GetFirstID(strWhereCond);
 return strIdVideoLib;
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
 arrList = VideoLibDA.GetID(strWhereCond);
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
bool bolIsExist = VideoLibDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdVideoLib)
{
if (string.IsNullOrEmpty(strIdVideoLib) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdVideoLib]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = VideoLibDA.IsExist(strIdVideoLib);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdVideoLib">视频库流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdVideoLib, string strOpUser)
{
clsVideoLibEN objVideoLibEN = clsVideoLibBL.GetObjByIdVideoLib(strIdVideoLib);
objVideoLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objVideoLibEN.UpdUserId = strOpUser;
return clsVideoLibBL.UpdateBySql2(objVideoLibEN);
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
 bolIsExist = clsVideoLibDA.IsExistTable();
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
 bolIsExist = VideoLibDA.IsExistTable(strTabName);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsVideoLibBL.IsExist(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objVideoLibEN.IdVideoLib, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = VideoLibDA.AddNewRecordBySQL2(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsVideoLibBL.IsExist(objVideoLibEN.IdVideoLib) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objVideoLibEN.IdVideoLib, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = VideoLibDA.AddNewRecordBySQL2WithReturnKey(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsVideoLibEN objVideoLibEN)
{
try
{
bool bolResult = VideoLibDA.Update(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "objVideoLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsVideoLibEN objVideoLibEN)
{
 if (string.IsNullOrEmpty(objVideoLibEN.IdVideoLib) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = VideoLibDA.UpdateBySql2(objVideoLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLibBL.ReFreshCache();

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
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
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdVideoLib)
{
try
{
 clsVideoLibEN objVideoLibEN = clsVideoLibBL.GetObjByIdVideoLib(strIdVideoLib);

if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(objVideoLibEN.IdVideoLib, objVideoLibEN.UpdUserId);
}
if (objVideoLibEN != null)
{
int intRecNum = VideoLibDA.DelRecord(strIdVideoLib);
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
/// <param name="strIdVideoLib">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdVideoLib )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsVideoLibDA.GetSpecSQLObj();
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
//删除与表:[VideoLib]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conVideoLib.IdVideoLib,
//strIdVideoLib);
//        clsVideoLibBL.DelVideoLibsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsVideoLibBL.DelRecord(strIdVideoLib, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsVideoLibBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdVideoLib, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdVideoLib">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdVideoLib, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsVideoLibBL.relatedActions != null)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(strIdVideoLib, "UpdRelaTabDate");
}
bool bolResult = VideoLibDA.DelRecord(strIdVideoLib,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdVideoLibLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelVideoLibs(List<string> arrIdVideoLibLst)
{
if (arrIdVideoLibLst.Count == 0) return 0;
try
{
if (clsVideoLibBL.relatedActions != null)
{
foreach (var strIdVideoLib in arrIdVideoLibLst)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(strIdVideoLib, "UpdRelaTabDate");
}
}
int intDelRecNum = VideoLibDA.DelVideoLib(arrIdVideoLibLst);
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
public static int DelVideoLibsByCond(string strWhereCond)
{
try
{
if (clsVideoLibBL.relatedActions != null)
{
List<string> arrIdVideoLib = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdVideoLib in arrIdVideoLib)
{
clsVideoLibBL.relatedActions.UpdRelaTabDate(strIdVideoLib, "UpdRelaTabDate");
}
}
int intRecNum = VideoLibDA.DelVideoLib(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[VideoLib]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdVideoLib">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdVideoLib)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsVideoLibDA.GetSpecSQLObj();
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
//删除与表:[VideoLib]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsVideoLibBL.DelRecord(strIdVideoLib, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsVideoLibBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdVideoLib, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objVideoLibENS">源对象</param>
 /// <param name = "objVideoLibENT">目标对象</param>
 public static void CopyTo(clsVideoLibEN objVideoLibENS, clsVideoLibEN objVideoLibENT)
{
try
{
objVideoLibENT.IdVideoLib = objVideoLibENS.IdVideoLib; //视频库流水号
objVideoLibENT.VideoLibID = objVideoLibENS.VideoLibID; //视频库ID
objVideoLibENT.VideoLibName = objVideoLibENS.VideoLibName; //视频名称
objVideoLibENT.VideoLibTheme = objVideoLibENS.VideoLibTheme; //视频库主题词
objVideoLibENT.IdVideoLibType = objVideoLibENS.IdVideoLibType; //视频库类型流水号
objVideoLibENT.VideoLibText = objVideoLibENS.VideoLibText; //案例文本内容
objVideoLibENT.VideoLibDate = objVideoLibENS.VideoLibDate; //视频资源日期
objVideoLibENT.VideoLibTime = objVideoLibENS.VideoLibTime; //视频资源时间
objVideoLibENT.VideoLibDateIn = objVideoLibENS.VideoLibDateIn; //案例入库日期
objVideoLibENT.VideoLibTimeIn = objVideoLibENS.VideoLibTimeIn; //案例入库时间
objVideoLibENT.OwnerId = objVideoLibENS.OwnerId; //拥有者Id
objVideoLibENT.IdTeachingPlan = objVideoLibENS.IdTeachingPlan; //教案流水号
objVideoLibENT.BrowseCount = objVideoLibENS.BrowseCount; //浏览次数
objVideoLibENT.IdSenateGaugeVersion = objVideoLibENS.IdSenateGaugeVersion; //评价量表版本流水号
objVideoLibENT.CaseLevelId = objVideoLibENS.CaseLevelId; //课例等级Id
objVideoLibENT.IsVisible = objVideoLibENS.IsVisible; //是否显示
objVideoLibENT.IdXzCollege = objVideoLibENS.IdXzCollege; //学院流水号
objVideoLibENT.ViewCount = objVideoLibENS.ViewCount; //浏览量
objVideoLibENT.DownloadNumber = objVideoLibENS.DownloadNumber; //下载数目
objVideoLibENT.FileIntegration = objVideoLibENS.FileIntegration; //文件积分
objVideoLibENT.LikeCount = objVideoLibENS.LikeCount; //资源喜欢数量
objVideoLibENT.CollectionCount = objVideoLibENS.CollectionCount; //收藏数量
objVideoLibENT.RecommendedDegreeId = objVideoLibENS.RecommendedDegreeId; //推荐度Id
objVideoLibENT.CourseId = objVideoLibENS.CourseId; //课程Id
objVideoLibENT.VideoUrl = objVideoLibENS.VideoUrl; //视频Url
objVideoLibENT.VideoPath = objVideoLibENS.VideoPath; //视频目录
objVideoLibENT.CoverPicUrl = objVideoLibENS.CoverPicUrl; //封面Url
objVideoLibENT.CoverPicShortUrl = objVideoLibENS.CoverPicShortUrl; //封面短Url
objVideoLibENT.ResErrMsg = objVideoLibENS.ResErrMsg; //资源错误信息
objVideoLibENT.UpdDate = objVideoLibENS.UpdDate; //修改日期
objVideoLibENT.UpdUserId = objVideoLibENS.UpdUserId; //修改用户Id
objVideoLibENT.Memo = objVideoLibENS.Memo; //备注
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
 /// <param name = "objVideoLibEN">源简化对象</param>
 public static void SetUpdFlag(clsVideoLibEN objVideoLibEN)
{
try
{
objVideoLibEN.ClearUpdateState();
   string strsfUpdFldSetStr = objVideoLibEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conVideoLib.IdVideoLib, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.IdVideoLib = objVideoLibEN.IdVideoLib; //视频库流水号
}
if (arrFldSet.Contains(conVideoLib.VideoLibID, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibID = objVideoLibEN.VideoLibID; //视频库ID
}
if (arrFldSet.Contains(conVideoLib.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibName = objVideoLibEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(conVideoLib.VideoLibTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibTheme = objVideoLibEN.VideoLibTheme == "[null]" ? null :  objVideoLibEN.VideoLibTheme; //视频库主题词
}
if (arrFldSet.Contains(conVideoLib.IdVideoLibType, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.IdVideoLibType = objVideoLibEN.IdVideoLibType; //视频库类型流水号
}
if (arrFldSet.Contains(conVideoLib.VideoLibText, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibText = objVideoLibEN.VideoLibText == "[null]" ? null :  objVideoLibEN.VideoLibText; //案例文本内容
}
if (arrFldSet.Contains(conVideoLib.VideoLibDate, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibDate = objVideoLibEN.VideoLibDate == "[null]" ? null :  objVideoLibEN.VideoLibDate; //视频资源日期
}
if (arrFldSet.Contains(conVideoLib.VideoLibTime, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibTime = objVideoLibEN.VideoLibTime == "[null]" ? null :  objVideoLibEN.VideoLibTime; //视频资源时间
}
if (arrFldSet.Contains(conVideoLib.VideoLibDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibDateIn = objVideoLibEN.VideoLibDateIn == "[null]" ? null :  objVideoLibEN.VideoLibDateIn; //案例入库日期
}
if (arrFldSet.Contains(conVideoLib.VideoLibTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoLibTimeIn = objVideoLibEN.VideoLibTimeIn == "[null]" ? null :  objVideoLibEN.VideoLibTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conVideoLib.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.OwnerId = objVideoLibEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conVideoLib.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.IdTeachingPlan = objVideoLibEN.IdTeachingPlan == "[null]" ? null :  objVideoLibEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conVideoLib.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.BrowseCount = objVideoLibEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conVideoLib.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.IdSenateGaugeVersion = objVideoLibEN.IdSenateGaugeVersion == "[null]" ? null :  objVideoLibEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conVideoLib.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.CaseLevelId = objVideoLibEN.CaseLevelId == "[null]" ? null :  objVideoLibEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(conVideoLib.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.IsVisible = objVideoLibEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conVideoLib.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.IdXzCollege = objVideoLibEN.IdXzCollege == "[null]" ? null :  objVideoLibEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conVideoLib.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.ViewCount = objVideoLibEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(conVideoLib.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.DownloadNumber = objVideoLibEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(conVideoLib.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.FileIntegration = objVideoLibEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(conVideoLib.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.LikeCount = objVideoLibEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(conVideoLib.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.CollectionCount = objVideoLibEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conVideoLib.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.RecommendedDegreeId = objVideoLibEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conVideoLib.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.CourseId = objVideoLibEN.CourseId == "[null]" ? null :  objVideoLibEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conVideoLib.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoUrl = objVideoLibEN.VideoUrl == "[null]" ? null :  objVideoLibEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conVideoLib.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.VideoPath = objVideoLibEN.VideoPath == "[null]" ? null :  objVideoLibEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conVideoLib.CoverPicUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.CoverPicUrl = objVideoLibEN.CoverPicUrl == "[null]" ? null :  objVideoLibEN.CoverPicUrl; //封面Url
}
if (arrFldSet.Contains(conVideoLib.CoverPicShortUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.CoverPicShortUrl = objVideoLibEN.CoverPicShortUrl == "[null]" ? null :  objVideoLibEN.CoverPicShortUrl; //封面短Url
}
if (arrFldSet.Contains(conVideoLib.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.ResErrMsg = objVideoLibEN.ResErrMsg == "[null]" ? null :  objVideoLibEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conVideoLib.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.UpdDate = objVideoLibEN.UpdDate == "[null]" ? null :  objVideoLibEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conVideoLib.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.UpdUserId = objVideoLibEN.UpdUserId == "[null]" ? null :  objVideoLibEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conVideoLib.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLibEN.Memo = objVideoLibEN.Memo == "[null]" ? null :  objVideoLibEN.Memo; //备注
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
 /// <param name = "objVideoLibEN">源简化对象</param>
 public static void AccessFldValueNull(clsVideoLibEN objVideoLibEN)
{
try
{
if (objVideoLibEN.VideoLibTheme == "[null]") objVideoLibEN.VideoLibTheme = null; //视频库主题词
if (objVideoLibEN.VideoLibText == "[null]") objVideoLibEN.VideoLibText = null; //案例文本内容
if (objVideoLibEN.VideoLibDate == "[null]") objVideoLibEN.VideoLibDate = null; //视频资源日期
if (objVideoLibEN.VideoLibTime == "[null]") objVideoLibEN.VideoLibTime = null; //视频资源时间
if (objVideoLibEN.VideoLibDateIn == "[null]") objVideoLibEN.VideoLibDateIn = null; //案例入库日期
if (objVideoLibEN.VideoLibTimeIn == "[null]") objVideoLibEN.VideoLibTimeIn = null; //案例入库时间
if (objVideoLibEN.IdTeachingPlan == "[null]") objVideoLibEN.IdTeachingPlan = null; //教案流水号
if (objVideoLibEN.IdSenateGaugeVersion == "[null]") objVideoLibEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objVideoLibEN.CaseLevelId == "[null]") objVideoLibEN.CaseLevelId = null; //课例等级Id
if (objVideoLibEN.IdXzCollege == "[null]") objVideoLibEN.IdXzCollege = null; //学院流水号
if (objVideoLibEN.CourseId == "[null]") objVideoLibEN.CourseId = null; //课程Id
if (objVideoLibEN.VideoUrl == "[null]") objVideoLibEN.VideoUrl = null; //视频Url
if (objVideoLibEN.VideoPath == "[null]") objVideoLibEN.VideoPath = null; //视频目录
if (objVideoLibEN.CoverPicUrl == "[null]") objVideoLibEN.CoverPicUrl = null; //封面Url
if (objVideoLibEN.CoverPicShortUrl == "[null]") objVideoLibEN.CoverPicShortUrl = null; //封面短Url
if (objVideoLibEN.ResErrMsg == "[null]") objVideoLibEN.ResErrMsg = null; //资源错误信息
if (objVideoLibEN.UpdDate == "[null]") objVideoLibEN.UpdDate = null; //修改日期
if (objVideoLibEN.UpdUserId == "[null]") objVideoLibEN.UpdUserId = null; //修改用户Id
if (objVideoLibEN.Memo == "[null]") objVideoLibEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsVideoLibEN objVideoLibEN)
{
 VideoLibDA.CheckPropertyNew(objVideoLibEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsVideoLibEN objVideoLibEN)
{
 VideoLibDA.CheckProperty4Condition(objVideoLibEN);
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
if (clsVideoLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibBL没有刷新缓存机制(clsVideoLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdVideoLib");
//if (arrVideoLibObjLstCache == null)
//{
//arrVideoLibObjLstCache = VideoLibDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdVideoLib">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVideoLibEN GetObjByIdVideoLibCache(string strIdVideoLib)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName);
List<clsVideoLibEN> arrVideoLibObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLibEN> arrVideoLibObjLst_Sel =
arrVideoLibObjLstCache
.Where(x=> x.IdVideoLib == strIdVideoLib 
);
if (arrVideoLibObjLst_Sel.Count() == 0)
{
   clsVideoLibEN obj = clsVideoLibBL.GetObjByIdVideoLib(strIdVideoLib);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrVideoLibObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVideoLibEN> GetAllVideoLibObjLstCache()
{
//获取缓存中的对象列表
List<clsVideoLibEN> arrVideoLibObjLstCache = GetObjLstCache(); 
return arrVideoLibObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVideoLibEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName);
List<clsVideoLibEN> arrVideoLibObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrVideoLibObjLstCache;
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
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName);
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
if (clsVideoLibBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsVideoLibEN._CurrTabName);
CacheHelper.Remove(strKey);
clsVideoLibBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdVideoLib)
{
if (strInFldName != conVideoLib.IdVideoLib)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conVideoLib.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conVideoLib.AttributeName));
throw new Exception(strMsg);
}
var objVideoLib = clsVideoLibBL.GetObjByIdVideoLibCache(strIdVideoLib);
if (objVideoLib == null) return "";
return objVideoLib[strOutFldName].ToString();
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
int intRecCount = clsVideoLibDA.GetRecCount(strTabName);
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
int intRecCount = clsVideoLibDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsVideoLibDA.GetRecCount();
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
int intRecCount = clsVideoLibDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objVideoLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsVideoLibEN objVideoLibCond)
{
List<clsVideoLibEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conVideoLib.AttributeName)
{
if (objVideoLibCond.IsUpdated(strFldName) == false) continue;
if (objVideoLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLibCond[strFldName].ToString());
}
else
{
if (objVideoLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objVideoLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objVideoLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objVideoLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objVideoLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objVideoLibCond[strFldName]));
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
 List<string> arrList = clsVideoLibDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = VideoLibDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = VideoLibDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = VideoLibDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsVideoLibDA.SetFldValue(clsVideoLibEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = VideoLibDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsVideoLibDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsVideoLibDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsVideoLibDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[VideoLib] "); 
 strCreateTabCode.Append(" ( "); 
 // /**视频库流水号*/ 
 strCreateTabCode.Append(" IdVideoLib char(8) primary key, "); 
 // /**视频库ID*/ 
 strCreateTabCode.Append(" VideoLibID char(8) not Null, "); 
 // /**视频名称*/ 
 strCreateTabCode.Append(" VideoLibName varchar(100) not Null, "); 
 // /**视频库主题词*/ 
 strCreateTabCode.Append(" VideoLibTheme varchar(200) Null, "); 
 // /**视频库类型流水号*/ 
 strCreateTabCode.Append(" IdVideoLibType char(4) not Null, "); 
 // /**案例文本内容*/ 
 strCreateTabCode.Append(" VideoLibText varchar(8000) Null, "); 
 // /**视频资源日期*/ 
 strCreateTabCode.Append(" VideoLibDate varchar(20) Null, "); 
 // /**视频资源时间*/ 
 strCreateTabCode.Append(" VideoLibTime char(6) Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" VideoLibDateIn char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" VideoLibTimeIn char(6) Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) not Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**评价量表版本流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeVersion char(4) Null, "); 
 // /**课例等级Id*/ 
 strCreateTabCode.Append(" CaseLevelId char(2) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" ViewCount int Null, "); 
 // /**下载数目*/ 
 strCreateTabCode.Append(" DownloadNumber int Null, "); 
 // /**文件积分*/ 
 strCreateTabCode.Append(" FileIntegration int Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**推荐度Id*/ 
 strCreateTabCode.Append(" RecommendedDegreeId char(2) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**视频Url*/ 
 strCreateTabCode.Append(" VideoUrl varchar(1000) Null, "); 
 // /**视频目录*/ 
 strCreateTabCode.Append(" VideoPath varchar(1000) Null, "); 
 // /**封面Url*/ 
 strCreateTabCode.Append(" CoverPicUrl varchar(1000) Null, "); 
 // /**封面短Url*/ 
 strCreateTabCode.Append(" CoverPicShortUrl varchar(1000) Null, "); 
 // /**资源错误信息*/ 
 strCreateTabCode.Append(" ResErrMsg varchar(30) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 视频库(VideoLib)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4VideoLib : clsCommFun4BL
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
clsVideoLibBL.ReFreshThisCache();
}
}

}