
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroTeachCaseRelaInfoBL
 表名:MicroTeachCaseRelaInfo(01120318)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsMicroTeachCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroTeachCaseRelaInfoEN GetObj(this K_IdMicroTeachCaseRelaInfo_MicroTeachCaseRelaInfo myKey)
{
clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(myKey.Value);
return objMicroTeachCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
if (CheckUniqueness(objMicroTeachCaseRelaInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],微格案例相关信息类型流水号 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsMicroTeachCaseRelaInfoBL.AddNewRecord)", objMicroTeachCaseRelaInfoEN.IdMicroteachCase,objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType,objMicroTeachCaseRelaInfoEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.AddNewRecordBySQL2(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
public static bool AddRecordEx(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objMicroTeachCaseRelaInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objMicroTeachCaseRelaInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(微格教学案例流水号(IdMicroteachCase)=[{0}],微格案例相关信息类型流水号(IdMicroTeachCaseRelaInfoType)=[{1}],资源流水号(IdResource)=[{2}])已经存在,不能重复!", objMicroTeachCaseRelaInfoEN.IdMicroteachCase, objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, objMicroTeachCaseRelaInfoEN.IdResource);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objMicroTeachCaseRelaInfoEN.AddNewRecord();
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
if (CheckUniqueness(objMicroTeachCaseRelaInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],微格案例相关信息类型流水号 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsMicroTeachCaseRelaInfoBL.AddNewRecordWithReturnKey)", objMicroTeachCaseRelaInfoEN.IdMicroteachCase,objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType,objMicroTeachCaseRelaInfoEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.AddNewRecordBySQL2WithReturnKey(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetIdMicroTeachCaseRelaInfo(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, long lngIdMicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetFuncModuleId(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conMicroTeachCaseRelaInfo.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
}
objMicroTeachCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.FuncModuleId) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetIdMicroteachCase(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, conMicroTeachCaseRelaInfo.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
}
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.IdMicroteachCase) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.IdMicroteachCase, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdMicroteachCase] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetIdResource(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, conMicroTeachCaseRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
}
objMicroTeachCaseRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.IdResource) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.IdResource, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdResource] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetIdMicroTeachCaseRelaInfoType(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strIdMicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroTeachCaseRelaInfoType, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetIsVisible(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objMicroTeachCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.IsVisible) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetBrowseCount(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
	{
objMicroTeachCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.BrowseCount) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetFlag(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFlag, 50, conMicroTeachCaseRelaInfo.Flag);
}
objMicroTeachCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.Flag) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetUpdDate(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMicroTeachCaseRelaInfo.UpdDate);
}
objMicroTeachCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.UpdDate) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetUpdUser(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conMicroTeachCaseRelaInfo.UpdUser);
}
objMicroTeachCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.UpdUser) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroTeachCaseRelaInfoEN SetMemo(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroTeachCaseRelaInfo.Memo);
}
objMicroTeachCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conMicroTeachCaseRelaInfo.Memo) == false)
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conMicroTeachCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objMicroTeachCaseRelaInfoEN.dicFldComparisonOp[conMicroTeachCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objMicroTeachCaseRelaInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroTeachCaseRelaInfoEN.CheckPropertyNew();
clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoCond = new clsMicroTeachCaseRelaInfoEN();
string strCondition = objMicroTeachCaseRelaInfoCond
.SetIdMicroTeachCaseRelaInfo(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, "<>")
.SetIdMicroteachCase(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, "=")
.SetIdMicroTeachCaseRelaInfoType(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, "=")
.SetIdResource(objMicroTeachCaseRelaInfoEN.IdResource, "=")
.GetCombineCondition();
objMicroTeachCaseRelaInfoEN._IsCheckProperty = true;
bool bolIsExist = clsMicroTeachCaseRelaInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_MicroteachCase_id_MicroTeachCaseRelaInfoType_id_Resource)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroTeachCaseRelaInfoEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoCond = new clsMicroTeachCaseRelaInfoEN();
string strCondition = objMicroTeachCaseRelaInfoCond
.SetIdMicroteachCase(objMicroTeachCaseRelaInfo.IdMicroteachCase, "=")
.SetIdMicroTeachCaseRelaInfoType(objMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, "=")
.SetIdResource(objMicroTeachCaseRelaInfo.IdResource, "=")
.GetCombineCondition();
objMicroTeachCaseRelaInfo._IsCheckProperty = true;
bool bolIsExist = clsMicroTeachCaseRelaInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo = clsMicroTeachCaseRelaInfoBL.GetFirstID_S(strCondition);
objMicroTeachCaseRelaInfo.UpdateWithCondition(strCondition);
}
else
{
objMicroTeachCaseRelaInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.UpdateBySql2(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.UpdateBySql2(objMicroTeachCaseRelaInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.UpdateBySqlWithCondition(objMicroTeachCaseRelaInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.UpdateBySqlWithConditionTransaction(objMicroTeachCaseRelaInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
try
{
int intRecNum = clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.DelRecord(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objMicroTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENS, clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENT)
{
try
{
objMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objMicroTeachCaseRelaInfoENT.FuncModuleId = objMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objMicroTeachCaseRelaInfoENT.IdMicroteachCase = objMicroTeachCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objMicroTeachCaseRelaInfoENT.IdResource = objMicroTeachCaseRelaInfoENS.IdResource; //资源流水号
objMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoENT.IsVisible = objMicroTeachCaseRelaInfoENS.IsVisible; //是否显示
objMicroTeachCaseRelaInfoENT.BrowseCount = objMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objMicroTeachCaseRelaInfoENT.Flag = objMicroTeachCaseRelaInfoENS.Flag; //标志
objMicroTeachCaseRelaInfoENT.UpdDate = objMicroTeachCaseRelaInfoENS.UpdDate; //修改日期
objMicroTeachCaseRelaInfoENT.UpdUser = objMicroTeachCaseRelaInfoENS.UpdUser; //修改人
objMicroTeachCaseRelaInfoENT.Memo = objMicroTeachCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objMicroTeachCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsMicroTeachCaseRelaInfoEN:objMicroTeachCaseRelaInfoENT</returns>
 public static clsMicroTeachCaseRelaInfoEN CopyTo(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENS)
{
try
{
 clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENT = new clsMicroTeachCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo, //案例相关信息流水号
FuncModuleId = objMicroTeachCaseRelaInfoENS.FuncModuleId, //功能模块Id
IdMicroteachCase = objMicroTeachCaseRelaInfoENS.IdMicroteachCase, //微格教学案例流水号
IdResource = objMicroTeachCaseRelaInfoENS.IdResource, //资源流水号
IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType, //微格案例相关信息类型流水号
IsVisible = objMicroTeachCaseRelaInfoENS.IsVisible, //是否显示
BrowseCount = objMicroTeachCaseRelaInfoENS.BrowseCount, //浏览次数
Flag = objMicroTeachCaseRelaInfoENS.Flag, //标志
UpdDate = objMicroTeachCaseRelaInfoENS.UpdDate, //修改日期
UpdUser = objMicroTeachCaseRelaInfoENS.UpdUser, //修改人
Memo = objMicroTeachCaseRelaInfoENS.Memo, //备注
};
 return objMicroTeachCaseRelaInfoENT;
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
public static void CheckPropertyNew(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 clsMicroTeachCaseRelaInfoBL.MicroTeachCaseRelaInfoDA.CheckProperty4Condition(objMicroTeachCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfo = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoCond.IdMicroTeachCaseRelaInfo, strComparisonOpIdMicroTeachCaseRelaInfo);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.FuncModuleId, objMicroTeachCaseRelaInfoCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.IdMicroteachCase, objMicroTeachCaseRelaInfoCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.IdResource, objMicroTeachCaseRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, objMicroTeachCaseRelaInfoCond.IdMicroTeachCaseRelaInfoType, strComparisonOpIdMicroTeachCaseRelaInfoType);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.IsVisible) == true)
{
if (objMicroTeachCaseRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroTeachCaseRelaInfo.IsVisible);
}
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroTeachCaseRelaInfo.BrowseCount, objMicroTeachCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.Flag) == true)
{
string strComparisonOpFlag = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.Flag, objMicroTeachCaseRelaInfoCond.Flag, strComparisonOpFlag);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.UpdDate, objMicroTeachCaseRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.UpdUser, objMicroTeachCaseRelaInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objMicroTeachCaseRelaInfoCond.IsUpdated(conMicroTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[conMicroTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroTeachCaseRelaInfo.Memo, objMicroTeachCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MicroTeachCaseRelaInfo(微格案例相关信息), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_MicroteachCase_id_MicroTeachCaseRelaInfoType_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMicroTeachCaseRelaInfoEN == null) return true;
if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdMicroTeachCaseRelaInfoType = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroTeachCaseRelaInfoEN.IdResource);
if (clsMicroTeachCaseRelaInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdMicroTeachCaseRelaInfo !=  {0}", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdMicroTeachCaseRelaInfoType = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroTeachCaseRelaInfoEN.IdResource);
if (clsMicroTeachCaseRelaInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--MicroTeachCaseRelaInfo(微格案例相关信息), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_MicroteachCase_id_MicroTeachCaseRelaInfoType_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroTeachCaseRelaInfoEN == null) return "";
if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdMicroTeachCaseRelaInfoType = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroTeachCaseRelaInfoEN.IdResource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdMicroTeachCaseRelaInfo !=  {0}", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdMicroTeachCaseRelaInfoType = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroTeachCaseRelaInfoEN.IdResource);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroTeachCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdMicroTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格案例相关信息(MicroTeachCaseRelaInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroTeachCaseRelaInfoBL
{
public static RelatedActions_MicroTeachCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroTeachCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroTeachCaseRelaInfoDA MicroTeachCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroTeachCaseRelaInfoDA();
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
 public clsMicroTeachCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsMicroTeachCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroTeachCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_MicroTeachCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroTeachCaseRelaInfoDA.GetDataTable_MicroTeachCaseRelaInfo(strWhereCond);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLst(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroTeachCaseRelaInfoLst);
 string strWhereCond = string.Format("IdMicroTeachCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroTeachCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLstCache(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoEN._CurrTabName);
List<clsMicroTeachCaseRelaInfoEN> arrMicroTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoEN> arrMicroTeachCaseRelaInfoObjLst_Sel =
arrMicroTeachCaseRelaInfoObjLstCache
.Where(x => arrIdMicroTeachCaseRelaInfoLst.Contains(x.IdMicroTeachCaseRelaInfo));
return arrMicroTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
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
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroTeachCaseRelaInfoEN> GetSubObjLstCache(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoCond)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroTeachCaseRelaInfo.AttributeName)
{
if (objMicroTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objMicroTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objMicroTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoCond[strFldName]));
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
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
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
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
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
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
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
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
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
public static List<clsMicroTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
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
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroTeachCaseRelaInfo(ref clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
bool bolResult = MicroTeachCaseRelaInfoDA.GetMicroTeachCaseRelaInfo(ref objMicroTeachCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = MicroTeachCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
return objMicroTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroTeachCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = MicroTeachCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objMicroTeachCaseRelaInfoEN;
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
public static clsMicroTeachCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = MicroTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objMicroTeachCaseRelaInfoEN;
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
public static clsMicroTeachCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = MicroTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objMicroTeachCaseRelaInfoEN;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstMicroTeachCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoFromList(long lngIdMicroTeachCaseRelaInfo, List<clsMicroTeachCaseRelaInfoEN> lstMicroTeachCaseRelaInfoObjLst)
{
foreach (clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN in lstMicroTeachCaseRelaInfoObjLst)
{
if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo)
{
return objMicroTeachCaseRelaInfoEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdMicroTeachCaseRelaInfo;
 try
 {
 lngIdMicroTeachCaseRelaInfo = new clsMicroTeachCaseRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdMicroTeachCaseRelaInfo;
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
 arrList = MicroTeachCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = MicroTeachCaseRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = MicroTeachCaseRelaInfoDA.IsExist(lngIdMicroTeachCaseRelaInfo);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdMicroTeachCaseRelaInfo">案例相关信息流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdMicroTeachCaseRelaInfo, string strOpUser)
{
clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = clsMicroTeachCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objMicroTeachCaseRelaInfoEN.UpdUser = strOpUser;
return clsMicroTeachCaseRelaInfoBL.UpdateBySql2(objMicroTeachCaseRelaInfoEN);
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
 bolIsExist = clsMicroTeachCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = MicroTeachCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
if (objMicroTeachCaseRelaInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],微格案例相关信息类型流水号 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsMicroTeachCaseRelaInfoBL.AddNewRecordBySql2)", objMicroTeachCaseRelaInfoEN.IdMicroteachCase,objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType,objMicroTeachCaseRelaInfoEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = MicroTeachCaseRelaInfoDA.AddNewRecordBySQL2(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
if (objMicroTeachCaseRelaInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],微格案例相关信息类型流水号 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsMicroTeachCaseRelaInfoBL.AddNewRecordBySql2WithReturnKey)", objMicroTeachCaseRelaInfoEN.IdMicroteachCase,objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType,objMicroTeachCaseRelaInfoEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = MicroTeachCaseRelaInfoDA.AddNewRecordBySQL2WithReturnKey(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
try
{
bool bolResult = MicroTeachCaseRelaInfoDA.Update(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroTeachCaseRelaInfoDA.UpdateBySql2(objMicroTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroTeachCaseRelaInfoBL.ReFreshCache();

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdMicroTeachCaseRelaInfo)
{
try
{
 clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = clsMicroTeachCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);

if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objMicroTeachCaseRelaInfoEN.UpdUser);
}
if (objMicroTeachCaseRelaInfoEN != null)
{
int intRecNum = MicroTeachCaseRelaInfoDA.DelRecord(lngIdMicroTeachCaseRelaInfo);
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
/// <param name="lngIdMicroTeachCaseRelaInfo">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdMicroTeachCaseRelaInfo )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
//删除与表:[MicroTeachCaseRelaInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo,
//lngIdMicroTeachCaseRelaInfo);
//        clsMicroTeachCaseRelaInfoBL.DelMicroTeachCaseRelaInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroTeachCaseRelaInfoBL.DelRecord(lngIdMicroTeachCaseRelaInfo, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroTeachCaseRelaInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroTeachCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdMicroTeachCaseRelaInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(lngIdMicroTeachCaseRelaInfo, "UpdRelaTabDate");
}
bool bolResult = MicroTeachCaseRelaInfoDA.DelRecord(lngIdMicroTeachCaseRelaInfo,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroTeachCaseRelaInfos(List<string> arrIdMicroTeachCaseRelaInfoLst)
{
if (arrIdMicroTeachCaseRelaInfoLst.Count == 0) return 0;
try
{
if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
foreach (var strIdMicroTeachCaseRelaInfo in arrIdMicroTeachCaseRelaInfoLst)
{
long lngIdMicroTeachCaseRelaInfo = long.Parse(strIdMicroTeachCaseRelaInfo);
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(lngIdMicroTeachCaseRelaInfo, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroTeachCaseRelaInfoDA.DelMicroTeachCaseRelaInfo(arrIdMicroTeachCaseRelaInfoLst);
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
public static int DelMicroTeachCaseRelaInfosByCond(string strWhereCond)
{
try
{
if (clsMicroTeachCaseRelaInfoBL.relatedActions != null)
{
List<string> arrIdMicroTeachCaseRelaInfo = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroTeachCaseRelaInfo in arrIdMicroTeachCaseRelaInfo)
{
long lngIdMicroTeachCaseRelaInfo = long.Parse(strIdMicroTeachCaseRelaInfo);
clsMicroTeachCaseRelaInfoBL.relatedActions.UpdRelaTabDate(lngIdMicroTeachCaseRelaInfo, "UpdRelaTabDate");
}
}
int intRecNum = MicroTeachCaseRelaInfoDA.DelMicroTeachCaseRelaInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroTeachCaseRelaInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdMicroTeachCaseRelaInfo">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdMicroTeachCaseRelaInfo)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
//删除与表:[MicroTeachCaseRelaInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroTeachCaseRelaInfoBL.DelRecord(lngIdMicroTeachCaseRelaInfo, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroTeachCaseRelaInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroTeachCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objMicroTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENS, clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENT)
{
try
{
objMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objMicroTeachCaseRelaInfoENT.FuncModuleId = objMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objMicroTeachCaseRelaInfoENT.IdMicroteachCase = objMicroTeachCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objMicroTeachCaseRelaInfoENT.IdResource = objMicroTeachCaseRelaInfoENS.IdResource; //资源流水号
objMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoENT.IsVisible = objMicroTeachCaseRelaInfoENS.IsVisible; //是否显示
objMicroTeachCaseRelaInfoENT.BrowseCount = objMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objMicroTeachCaseRelaInfoENT.Flag = objMicroTeachCaseRelaInfoENS.Flag; //标志
objMicroTeachCaseRelaInfoENT.UpdDate = objMicroTeachCaseRelaInfoENS.UpdDate; //修改日期
objMicroTeachCaseRelaInfoENT.UpdUser = objMicroTeachCaseRelaInfoENS.UpdUser; //修改人
objMicroTeachCaseRelaInfoENT.Memo = objMicroTeachCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
try
{
objMicroTeachCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroTeachCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.FuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.IdResource = objMicroTeachCaseRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.IsVisible = objMicroTeachCaseRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.BrowseCount = objMicroTeachCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.Flag, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.Flag = objMicroTeachCaseRelaInfoEN.Flag == "[null]" ? null :  objMicroTeachCaseRelaInfoEN.Flag; //标志
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.UpdDate = objMicroTeachCaseRelaInfoEN.UpdDate == "[null]" ? null :  objMicroTeachCaseRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.UpdUser = objMicroTeachCaseRelaInfoEN.UpdUser == "[null]" ? null :  objMicroTeachCaseRelaInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conMicroTeachCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroTeachCaseRelaInfoEN.Memo = objMicroTeachCaseRelaInfoEN.Memo == "[null]" ? null :  objMicroTeachCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
try
{
if (objMicroTeachCaseRelaInfoEN.Flag == "[null]") objMicroTeachCaseRelaInfoEN.Flag = null; //标志
if (objMicroTeachCaseRelaInfoEN.UpdDate == "[null]") objMicroTeachCaseRelaInfoEN.UpdDate = null; //修改日期
if (objMicroTeachCaseRelaInfoEN.UpdUser == "[null]") objMicroTeachCaseRelaInfoEN.UpdUser = null; //修改人
if (objMicroTeachCaseRelaInfoEN.Memo == "[null]") objMicroTeachCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 MicroTeachCaseRelaInfoDA.CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 MicroTeachCaseRelaInfoDA.CheckProperty4Condition(objMicroTeachCaseRelaInfoEN);
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
if (clsMicroTeachCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoBL没有刷新缓存机制(clsMicroTeachCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroTeachCaseRelaInfo");
//if (arrMicroTeachCaseRelaInfoObjLstCache == null)
//{
//arrMicroTeachCaseRelaInfoObjLstCache = MicroTeachCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoCache(long lngIdMicroTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoEN._CurrTabName);
List<clsMicroTeachCaseRelaInfoEN> arrMicroTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoEN> arrMicroTeachCaseRelaInfoObjLst_Sel =
arrMicroTeachCaseRelaInfoObjLstCache
.Where(x=> x.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo 
);
if (arrMicroTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsMicroTeachCaseRelaInfoEN obj = clsMicroTeachCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetAllMicroTeachCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroTeachCaseRelaInfoEN> arrMicroTeachCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrMicroTeachCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroTeachCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoEN._CurrTabName);
List<clsMicroTeachCaseRelaInfoEN> arrMicroTeachCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroTeachCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoEN._CurrTabName);
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
if (clsMicroTeachCaseRelaInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroTeachCaseRelaInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroTeachCaseRelaInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MicroTeachCaseRelaInfo(微格案例相关信息)
 /// 唯一性条件:id_MicroteachCase_id_MicroTeachCaseRelaInfoType_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//检测记录是否存在
string strResult = MicroTeachCaseRelaInfoDA.GetUniCondStr(objMicroTeachCaseRelaInfoEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroTeachCaseRelaInfo)
{
if (strInFldName != conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroTeachCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroTeachCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objMicroTeachCaseRelaInfo = clsMicroTeachCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfoCache(lngIdMicroTeachCaseRelaInfo);
if (objMicroTeachCaseRelaInfo == null) return "";
return objMicroTeachCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroTeachCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoCond)
{
List<clsMicroTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroTeachCaseRelaInfo.AttributeName)
{
if (objMicroTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objMicroTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objMicroTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroTeachCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsMicroTeachCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroTeachCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroTeachCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroTeachCaseRelaInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.SetFldValue(clsMicroTeachCaseRelaInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroTeachCaseRelaInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroTeachCaseRelaInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroTeachCaseRelaInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例相关信息流水号*/ 
 strCreateTabCode.Append(" IdMicroTeachCaseRelaInfo bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**微格教学案例流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCase char(8) not Null, "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) not Null, "); 
 // /**微格案例相关信息类型流水号*/ 
 strCreateTabCode.Append(" IdMicroTeachCaseRelaInfoType char(4) not Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**标志*/ 
 strCreateTabCode.Append(" Flag varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**资源名称*/ 
 strCreateTabCode.Append(" ResourceName varchar(100) Null, "); 
 // /**微格案例相关信息类型名称*/ 
 strCreateTabCode.Append(" MicroTeachCaseRelaInfoTypeName varchar(50) Null, "); 
 // /**微格教学案例名称*/ 
 strCreateTabCode.Append(" MicroteachCaseName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格案例相关信息(MicroTeachCaseRelaInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroTeachCaseRelaInfo : clsCommFun4BL
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
clsMicroTeachCaseRelaInfoBL.ReFreshThisCache();
}
}

}