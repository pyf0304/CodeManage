
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCase_Resource_RelBL
 表名:MicroteachCase_Resource_Rel(01120369)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:45
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
public static class  clsMicroteachCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCase_Resource_RelEN GetObj(this K_IdMicroteachCaseResourceRel_MicroteachCase_Resource_Rel myKey)
{
clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(myKey.Value);
return objMicroteachCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
if (CheckUniqueness(objMicroteachCase_Resource_RelEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsMicroteachCase_Resource_RelBL.AddNewRecord)", objMicroteachCase_Resource_RelEN.IdMicroteachCase,objMicroteachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.AddNewRecordBySQL2(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
public static bool AddRecordEx(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
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
objMicroteachCase_Resource_RelEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objMicroteachCase_Resource_RelEN.CheckUniqueness() == false)
{
strMsg = string.Format("(微格教学案例流水号(IdMicroteachCase)=[{0}],资源流水号(IdResource)=[{1}])已经存在,不能重复!", objMicroteachCase_Resource_RelEN.IdMicroteachCase, objMicroteachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objMicroteachCase_Resource_RelEN.AddNewRecord();
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
if (CheckUniqueness(objMicroteachCase_Resource_RelEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsMicroteachCase_Resource_RelBL.AddNewRecordWithReturnKey)", objMicroteachCase_Resource_RelEN.IdMicroteachCase,objMicroteachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIdMicroteachCaseResourceRel(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, long lngIdMicroteachCaseResourceRel, string strComparisonOp="")
	{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel; //微格案例资源关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetFuncModuleId(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conMicroteachCase_Resource_Rel.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conMicroteachCase_Resource_Rel.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conMicroteachCase_Resource_Rel.FuncModuleId);
}
objMicroteachCase_Resource_RelEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.FuncModuleId) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.FuncModuleId, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.FuncModuleId] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIdMicroteachCase(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, conMicroteachCase_Resource_Rel.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, conMicroteachCase_Resource_Rel.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, conMicroteachCase_Resource_Rel.IdMicroteachCase);
}
objMicroteachCase_Resource_RelEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IdMicroteachCase) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IdMicroteachCase, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdMicroteachCase] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIdResource(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, conMicroteachCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conMicroteachCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conMicroteachCase_Resource_Rel.IdResource);
}
objMicroteachCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IdResource) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIsMain(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objMicroteachCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IsMain) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIdUsingMode(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strIdUsingMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUsingMode, 4, conMicroteachCase_Resource_Rel.IdUsingMode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUsingMode, 4, conMicroteachCase_Resource_Rel.IdUsingMode);
}
objMicroteachCase_Resource_RelEN.IdUsingMode = strIdUsingMode; //资源使用模式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IdUsingMode) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IdUsingMode, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdUsingMode] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIsVisible(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objMicroteachCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IsVisible) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetIndexNO(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objMicroteachCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.IndexNO) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetBrowseCount(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objMicroteachCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.BrowseCount) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetUpdDate(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMicroteachCase_Resource_Rel.UpdDate);
}
objMicroteachCase_Resource_RelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.UpdDate) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.UpdDate, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.UpdDate] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetUpdUser(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conMicroteachCase_Resource_Rel.UpdUser);
}
objMicroteachCase_Resource_RelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.UpdUser) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.UpdUser, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.UpdUser] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCase_Resource_RelEN SetMemo(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroteachCase_Resource_Rel.Memo);
}
objMicroteachCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(conMicroteachCase_Resource_Rel.Memo) == false)
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp.Add(conMicroteachCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objMicroteachCase_Resource_RelEN.dicFldComparisonOp[conMicroteachCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objMicroteachCase_Resource_RelEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroteachCase_Resource_RelEN.CheckPropertyNew();
clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelCond = new clsMicroteachCase_Resource_RelEN();
string strCondition = objMicroteachCase_Resource_RelCond
.SetIdMicroteachCaseResourceRel(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, "<>")
.SetIdMicroteachCase(objMicroteachCase_Resource_RelEN.IdMicroteachCase, "=")
.SetIdResource(objMicroteachCase_Resource_RelEN.IdResource, "=")
.GetCombineCondition();
objMicroteachCase_Resource_RelEN._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCase_Resource_RelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_MicroteachCase_id_Resource)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroteachCase_Resource_RelEN.Update();
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
 /// <param name = "objMicroteachCase_Resource_Rel">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_Rel)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelCond = new clsMicroteachCase_Resource_RelEN();
string strCondition = objMicroteachCase_Resource_RelCond
.SetIdMicroteachCase(objMicroteachCase_Resource_Rel.IdMicroteachCase, "=")
.SetIdResource(objMicroteachCase_Resource_Rel.IdResource, "=")
.GetCombineCondition();
objMicroteachCase_Resource_Rel._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCase_Resource_RelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel = clsMicroteachCase_Resource_RelBL.GetFirstID_S(strCondition);
objMicroteachCase_Resource_Rel.UpdateWithCondition(strCondition);
}
else
{
objMicroteachCase_Resource_Rel.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
 if (objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.UpdateBySql2(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.UpdateBySql2(objMicroteachCase_Resource_RelEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.UpdateBySqlWithCondition(objMicroteachCase_Resource_RelEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.UpdateBySqlWithConditionTransaction(objMicroteachCase_Resource_RelEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
try
{
int intRecNum = clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.DelRecord(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelENS">源对象</param>
 /// <param name = "objMicroteachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelENS, clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelENT)
{
try
{
objMicroteachCase_Resource_RelENT.IdMicroteachCaseResourceRel = objMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objMicroteachCase_Resource_RelENT.FuncModuleId = objMicroteachCase_Resource_RelENS.FuncModuleId; //功能模块Id
objMicroteachCase_Resource_RelENT.IdMicroteachCase = objMicroteachCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCase_Resource_RelENT.IdResource = objMicroteachCase_Resource_RelENS.IdResource; //资源流水号
objMicroteachCase_Resource_RelENT.IsMain = objMicroteachCase_Resource_RelENS.IsMain; //是否主资源
objMicroteachCase_Resource_RelENT.IdUsingMode = objMicroteachCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objMicroteachCase_Resource_RelENT.IsVisible = objMicroteachCase_Resource_RelENS.IsVisible; //是否显示
objMicroteachCase_Resource_RelENT.IndexNO = objMicroteachCase_Resource_RelENS.IndexNO; //序号
objMicroteachCase_Resource_RelENT.BrowseCount = objMicroteachCase_Resource_RelENS.BrowseCount; //浏览次数
objMicroteachCase_Resource_RelENT.UpdDate = objMicroteachCase_Resource_RelENS.UpdDate; //修改日期
objMicroteachCase_Resource_RelENT.UpdUser = objMicroteachCase_Resource_RelENS.UpdUser; //修改人
objMicroteachCase_Resource_RelENT.Memo = objMicroteachCase_Resource_RelENS.Memo; //备注
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
 /// <param name = "objMicroteachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCase_Resource_RelEN:objMicroteachCase_Resource_RelENT</returns>
 public static clsMicroteachCase_Resource_RelEN CopyTo(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelENS)
{
try
{
 clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelENT = new clsMicroteachCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = objMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel, //微格案例资源关系流水号
FuncModuleId = objMicroteachCase_Resource_RelENS.FuncModuleId, //功能模块Id
IdMicroteachCase = objMicroteachCase_Resource_RelENS.IdMicroteachCase, //微格教学案例流水号
IdResource = objMicroteachCase_Resource_RelENS.IdResource, //资源流水号
IsMain = objMicroteachCase_Resource_RelENS.IsMain, //是否主资源
IdUsingMode = objMicroteachCase_Resource_RelENS.IdUsingMode, //资源使用模式流水号
IsVisible = objMicroteachCase_Resource_RelENS.IsVisible, //是否显示
IndexNO = objMicroteachCase_Resource_RelENS.IndexNO, //序号
BrowseCount = objMicroteachCase_Resource_RelENS.BrowseCount, //浏览次数
UpdDate = objMicroteachCase_Resource_RelENS.UpdDate, //修改日期
UpdUser = objMicroteachCase_Resource_RelENS.UpdUser, //修改人
Memo = objMicroteachCase_Resource_RelENS.Memo, //备注
};
 return objMicroteachCase_Resource_RelENT;
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
public static void CheckPropertyNew(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
 clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.CheckPropertyNew(objMicroteachCase_Resource_RelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
 clsMicroteachCase_Resource_RelBL.MicroteachCase_Resource_RelDA.CheckProperty4Condition(objMicroteachCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel) == true)
{
string strComparisonOpIdMicroteachCaseResourceRel = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelCond.IdMicroteachCaseResourceRel, strComparisonOpIdMicroteachCaseResourceRel);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.FuncModuleId, objMicroteachCase_Resource_RelCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.IdMicroteachCase, objMicroteachCase_Resource_RelCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.IdResource, objMicroteachCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IsMain) == true)
{
if (objMicroteachCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase_Resource_Rel.IsMain);
}
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IdUsingMode) == true)
{
string strComparisonOpIdUsingMode = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IdUsingMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.IdUsingMode, objMicroteachCase_Resource_RelCond.IdUsingMode, strComparisonOpIdUsingMode);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IsVisible) == true)
{
if (objMicroteachCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase_Resource_Rel.IsVisible);
}
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCase_Resource_Rel.IndexNO, objMicroteachCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCase_Resource_Rel.BrowseCount, objMicroteachCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.UpdDate) == true)
{
string strComparisonOpUpdDate = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.UpdDate, objMicroteachCase_Resource_RelCond.UpdDate, strComparisonOpUpdDate);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.UpdUser) == true)
{
string strComparisonOpUpdUser = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.UpdUser, objMicroteachCase_Resource_RelCond.UpdUser, strComparisonOpUpdUser);
}
if (objMicroteachCase_Resource_RelCond.IsUpdated(conMicroteachCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[conMicroteachCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase_Resource_Rel.Memo, objMicroteachCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MicroteachCase_Resource_Rel(微格案例与资源关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_MicroteachCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCase_Resource_RelEN == null) return true;
if (objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCase_Resource_RelEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroteachCase_Resource_RelEN.IdResource);
if (clsMicroteachCase_Resource_RelBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdMicroteachCaseResourceRel !=  {0}", objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCase_Resource_RelEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroteachCase_Resource_RelEN.IdResource);
if (clsMicroteachCase_Resource_RelBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--MicroteachCase_Resource_Rel(微格案例与资源关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_MicroteachCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCase_Resource_RelEN == null) return "";
if (objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCase_Resource_RelEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroteachCase_Resource_RelEN.IdResource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdMicroteachCaseResourceRel !=  {0}", objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCase_Resource_RelEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroteachCase_Resource_RelEN.IdResource);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroteachCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格案例与资源关系(MicroteachCase_Resource_Rel)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCase_Resource_RelBL
{
public static RelatedActions_MicroteachCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroteachCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroteachCase_Resource_RelDA MicroteachCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroteachCase_Resource_RelDA();
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
 public clsMicroteachCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsMicroteachCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_MicroteachCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroteachCase_Resource_RelDA.GetDataTable_MicroteachCase_Resource_Rel(strWhereCond);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroteachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLst(List<long> arrIdMicroteachCaseResourceRelLst)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseResourceRelLst);
 string strWhereCond = string.Format("IdMicroteachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroteachCase_Resource_RelEN> GetObjLstByIdMicroteachCaseResourceRelLstCache(List<long> arrIdMicroteachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsMicroteachCase_Resource_RelEN._CurrTabName);
List<clsMicroteachCase_Resource_RelEN> arrMicroteachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCase_Resource_RelEN> arrMicroteachCase_Resource_RelObjLst_Sel =
arrMicroteachCase_Resource_RelObjLstCache
.Where(x => arrIdMicroteachCaseResourceRelLst.Contains(x.IdMicroteachCaseResourceRel));
return arrMicroteachCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
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
public static List<clsMicroteachCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroteachCase_Resource_RelEN> GetSubObjLstCache(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelCond)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCase_Resource_Rel.AttributeName)
{
if (objMicroteachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objMicroteachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCase_Resource_RelCond[strFldName]));
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
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
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
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
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
List<clsMicroteachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroteachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroteachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
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
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
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
public static List<clsMicroteachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
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
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLst = new List<clsMicroteachCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = new clsMicroteachCase_Resource_RelEN();
try
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objMicroteachCase_Resource_RelEN.FuncModuleId = objRow[conMicroteachCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objRow[conMicroteachCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCase_Resource_RelEN.IdResource = objRow[conMicroteachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objMicroteachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objMicroteachCase_Resource_RelEN.IdUsingMode = objRow[conMicroteachCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objMicroteachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objMicroteachCase_Resource_RelEN.IndexNO = objRow[conMicroteachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objMicroteachCase_Resource_RelEN.BrowseCount = objRow[conMicroteachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCase_Resource_RelEN.UpdDate = objRow[conMicroteachCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objMicroteachCase_Resource_RelEN.UpdUser = objRow[conMicroteachCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objMicroteachCase_Resource_RelEN.Memo = objRow[conMicroteachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conMicroteachCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroteachCase_Resource_Rel(ref clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
bool bolResult = MicroteachCase_Resource_RelDA.GetMicroteachCase_Resource_Rel(ref objMicroteachCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = MicroteachCase_Resource_RelDA.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
return objMicroteachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroteachCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = MicroteachCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objMicroteachCase_Resource_RelEN;
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
public static clsMicroteachCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = MicroteachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objMicroteachCase_Resource_RelEN;
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
public static clsMicroteachCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = MicroteachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objMicroteachCase_Resource_RelEN;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstMicroteachCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelFromList(long lngIdMicroteachCaseResourceRel, List<clsMicroteachCase_Resource_RelEN> lstMicroteachCase_Resource_RelObjLst)
{
foreach (clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN in lstMicroteachCase_Resource_RelObjLst)
{
if (objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel)
{
return objMicroteachCase_Resource_RelEN;
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
 long lngIdMicroteachCaseResourceRel;
 try
 {
 lngIdMicroteachCaseResourceRel = new clsMicroteachCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseResourceRel;
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
 arrList = MicroteachCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = MicroteachCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = MicroteachCase_Resource_RelDA.IsExist(lngIdMicroteachCaseResourceRel);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdMicroteachCaseResourceRel">微格案例资源关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdMicroteachCaseResourceRel, string strOpUser)
{
clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = clsMicroteachCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
objMicroteachCase_Resource_RelEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objMicroteachCase_Resource_RelEN.UpdUser = strOpUser;
return clsMicroteachCase_Resource_RelBL.UpdateBySql2(objMicroteachCase_Resource_RelEN);
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
 bolIsExist = clsMicroteachCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = MicroteachCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
if (objMicroteachCase_Resource_RelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsMicroteachCase_Resource_RelBL.AddNewRecordBySql2)", objMicroteachCase_Resource_RelEN.IdMicroteachCase,objMicroteachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = MicroteachCase_Resource_RelDA.AddNewRecordBySQL2(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
if (objMicroteachCase_Resource_RelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],资源流水号 = [{1}]的数据已经存在!(in clsMicroteachCase_Resource_RelBL.AddNewRecordBySql2WithReturnKey)", objMicroteachCase_Resource_RelEN.IdMicroteachCase,objMicroteachCase_Resource_RelEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = MicroteachCase_Resource_RelDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
try
{
bool bolResult = MicroteachCase_Resource_RelDA.Update(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "objMicroteachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
 if (objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroteachCase_Resource_RelDA.UpdateBySql2(objMicroteachCase_Resource_RelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCase_Resource_RelBL.ReFreshCache();

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdMicroteachCaseResourceRel)
{
try
{
 clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN = clsMicroteachCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);

if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel, objMicroteachCase_Resource_RelEN.UpdUser);
}
if (objMicroteachCase_Resource_RelEN != null)
{
int intRecNum = MicroteachCase_Resource_RelDA.DelRecord(lngIdMicroteachCaseResourceRel);
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
/// <param name="lngIdMicroteachCaseResourceRel">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdMicroteachCaseResourceRel )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCase_Resource_Rel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel,
//lngIdMicroteachCaseResourceRel);
//        clsMicroteachCase_Resource_RelBL.DelMicroteachCase_Resource_RelsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCase_Resource_RelBL.DelRecord(lngIdMicroteachCaseResourceRel, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCase_Resource_RelBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroteachCaseResourceRel, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdMicroteachCaseResourceRel, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdMicroteachCaseResourceRel, "UpdRelaTabDate");
}
bool bolResult = MicroteachCase_Resource_RelDA.DelRecord(lngIdMicroteachCaseResourceRel,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroteachCaseResourceRelLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroteachCase_Resource_Rels(List<string> arrIdMicroteachCaseResourceRelLst)
{
if (arrIdMicroteachCaseResourceRelLst.Count == 0) return 0;
try
{
if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
foreach (var strIdMicroteachCaseResourceRel in arrIdMicroteachCaseResourceRelLst)
{
long lngIdMicroteachCaseResourceRel = long.Parse(strIdMicroteachCaseResourceRel);
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdMicroteachCaseResourceRel, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroteachCase_Resource_RelDA.DelMicroteachCase_Resource_Rel(arrIdMicroteachCaseResourceRelLst);
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
public static int DelMicroteachCase_Resource_RelsByCond(string strWhereCond)
{
try
{
if (clsMicroteachCase_Resource_RelBL.relatedActions != null)
{
List<string> arrIdMicroteachCaseResourceRel = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroteachCaseResourceRel in arrIdMicroteachCaseResourceRel)
{
long lngIdMicroteachCaseResourceRel = long.Parse(strIdMicroteachCaseResourceRel);
clsMicroteachCase_Resource_RelBL.relatedActions.UpdRelaTabDate(lngIdMicroteachCaseResourceRel, "UpdRelaTabDate");
}
}
int intRecNum = MicroteachCase_Resource_RelDA.DelMicroteachCase_Resource_Rel(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroteachCase_Resource_Rel]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdMicroteachCaseResourceRel">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdMicroteachCaseResourceRel)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCase_Resource_RelDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCase_Resource_Rel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCase_Resource_RelBL.DelRecord(lngIdMicroteachCaseResourceRel, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCase_Resource_RelBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroteachCaseResourceRel, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroteachCase_Resource_RelENS">源对象</param>
 /// <param name = "objMicroteachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelENS, clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelENT)
{
try
{
objMicroteachCase_Resource_RelENT.IdMicroteachCaseResourceRel = objMicroteachCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objMicroteachCase_Resource_RelENT.FuncModuleId = objMicroteachCase_Resource_RelENS.FuncModuleId; //功能模块Id
objMicroteachCase_Resource_RelENT.IdMicroteachCase = objMicroteachCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCase_Resource_RelENT.IdResource = objMicroteachCase_Resource_RelENS.IdResource; //资源流水号
objMicroteachCase_Resource_RelENT.IsMain = objMicroteachCase_Resource_RelENS.IsMain; //是否主资源
objMicroteachCase_Resource_RelENT.IdUsingMode = objMicroteachCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objMicroteachCase_Resource_RelENT.IsVisible = objMicroteachCase_Resource_RelENS.IsVisible; //是否显示
objMicroteachCase_Resource_RelENT.IndexNO = objMicroteachCase_Resource_RelENS.IndexNO; //序号
objMicroteachCase_Resource_RelENT.BrowseCount = objMicroteachCase_Resource_RelENS.BrowseCount; //浏览次数
objMicroteachCase_Resource_RelENT.UpdDate = objMicroteachCase_Resource_RelENS.UpdDate; //修改日期
objMicroteachCase_Resource_RelENT.UpdUser = objMicroteachCase_Resource_RelENS.UpdUser; //修改人
objMicroteachCase_Resource_RelENT.Memo = objMicroteachCase_Resource_RelENS.Memo; //备注
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
 /// <param name = "objMicroteachCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
try
{
objMicroteachCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroteachCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel = objMicroteachCase_Resource_RelEN.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.FuncModuleId = objMicroteachCase_Resource_RelEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IdMicroteachCase = objMicroteachCase_Resource_RelEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IdResource = objMicroteachCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IsMain = objMicroteachCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IdUsingMode, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IdUsingMode = objMicroteachCase_Resource_RelEN.IdUsingMode == "[null]" ? null :  objMicroteachCase_Resource_RelEN.IdUsingMode; //资源使用模式流水号
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IsVisible = objMicroteachCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.IndexNO = objMicroteachCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.BrowseCount = objMicroteachCase_Resource_RelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.UpdDate = objMicroteachCase_Resource_RelEN.UpdDate == "[null]" ? null :  objMicroteachCase_Resource_RelEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.UpdUser = objMicroteachCase_Resource_RelEN.UpdUser == "[null]" ? null :  objMicroteachCase_Resource_RelEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conMicroteachCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCase_Resource_RelEN.Memo = objMicroteachCase_Resource_RelEN.Memo == "[null]" ? null :  objMicroteachCase_Resource_RelEN.Memo; //备注
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
 /// <param name = "objMicroteachCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
try
{
if (objMicroteachCase_Resource_RelEN.IdUsingMode == "[null]") objMicroteachCase_Resource_RelEN.IdUsingMode = null; //资源使用模式流水号
if (objMicroteachCase_Resource_RelEN.UpdDate == "[null]") objMicroteachCase_Resource_RelEN.UpdDate = null; //修改日期
if (objMicroteachCase_Resource_RelEN.UpdUser == "[null]") objMicroteachCase_Resource_RelEN.UpdUser = null; //修改人
if (objMicroteachCase_Resource_RelEN.Memo == "[null]") objMicroteachCase_Resource_RelEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
 MicroteachCase_Resource_RelDA.CheckPropertyNew(objMicroteachCase_Resource_RelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
 MicroteachCase_Resource_RelDA.CheckProperty4Condition(objMicroteachCase_Resource_RelEN);
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
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelBL没有刷新缓存机制(clsMicroteachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseResourceRel");
//if (arrMicroteachCase_Resource_RelObjLstCache == null)
//{
//arrMicroteachCase_Resource_RelObjLstCache = MicroteachCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRelCache(long lngIdMicroteachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroteachCase_Resource_RelEN._CurrTabName);
List<clsMicroteachCase_Resource_RelEN> arrMicroteachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCase_Resource_RelEN> arrMicroteachCase_Resource_RelObjLst_Sel =
arrMicroteachCase_Resource_RelObjLstCache
.Where(x=> x.IdMicroteachCaseResourceRel == lngIdMicroteachCaseResourceRel 
);
if (arrMicroteachCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsMicroteachCase_Resource_RelEN obj = clsMicroteachCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRel(lngIdMicroteachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroteachCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetAllMicroteachCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroteachCase_Resource_RelEN> arrMicroteachCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrMicroteachCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCase_Resource_RelEN._CurrTabName);
List<clsMicroteachCase_Resource_RelEN> arrMicroteachCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsMicroteachCase_Resource_RelEN._CurrTabName);
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
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCase_Resource_RelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachCase_Resource_RelBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MicroteachCase_Resource_Rel(微格案例与资源关系)
 /// 唯一性条件:id_MicroteachCase_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelEN)
{
//检测记录是否存在
string strResult = MicroteachCase_Resource_RelDA.GetUniCondStr(objMicroteachCase_Resource_RelEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseResourceRel)
{
if (strInFldName != conMicroteachCase_Resource_Rel.IdMicroteachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroteachCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroteachCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objMicroteachCase_Resource_Rel = clsMicroteachCase_Resource_RelBL.GetObjByIdMicroteachCaseResourceRelCache(lngIdMicroteachCaseResourceRel);
if (objMicroteachCase_Resource_Rel == null) return "";
return objMicroteachCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsMicroteachCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroteachCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroteachCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsMicroteachCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroteachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroteachCase_Resource_RelEN objMicroteachCase_Resource_RelCond)
{
List<clsMicroteachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCase_Resource_Rel.AttributeName)
{
if (objMicroteachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objMicroteachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsMicroteachCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroteachCase_Resource_RelDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCase_Resource_RelDA.SetFldValue(clsMicroteachCase_Resource_RelEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroteachCase_Resource_RelDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCase_Resource_RelDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCase_Resource_RelDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCase_Resource_RelDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroteachCase_Resource_Rel] "); 
 strCreateTabCode.Append(" ( "); 
 // /**微格案例资源关系流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCaseResourceRel bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**微格教学案例流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCase char(8) not Null, "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) not Null, "); 
 // /**是否主资源*/ 
 strCreateTabCode.Append(" IsMain bit Null, "); 
 // /**资源使用模式流水号*/ 
 strCreateTabCode.Append(" IdUsingMode char(4) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" IndexNO int Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格案例与资源关系(MicroteachCase_Resource_Rel)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroteachCase_Resource_Rel : clsCommFun4BL
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
clsMicroteachCase_Resource_RelBL.ReFreshThisCache();
}
}

}