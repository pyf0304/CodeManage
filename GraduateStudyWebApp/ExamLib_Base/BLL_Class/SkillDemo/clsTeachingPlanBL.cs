
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingPlanBL
 表名:TeachingPlan(01120387)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsTeachingPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingPlanEN GetObj(this K_IdTeachingPlan_TeachingPlan myKey)
{
clsTeachingPlanEN objTeachingPlanEN = clsTeachingPlanBL.TeachingPlanDA.GetObjByIdTeachingPlan(myKey.Value);
return objTeachingPlanEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingPlanEN objTeachingPlanEN)
{
try
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true || clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan) == true)
 {
     objTeachingPlanEN.IdTeachingPlan = clsTeachingPlanBL.GetMaxStrId_S();
 }
bool bolResult = clsTeachingPlanBL.TeachingPlanDA.AddNewRecordBySQL2(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
public static bool AddRecordEx(this clsTeachingPlanEN objTeachingPlanEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objTeachingPlanEN.CheckPropertyNew();
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true || clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan) == true)
 {
     objTeachingPlanEN.IdTeachingPlan = clsTeachingPlanBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objTeachingPlanEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachingPlanEN objTeachingPlanEN)
{
try
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true || clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan) == true)
 {
     objTeachingPlanEN.IdTeachingPlan = clsTeachingPlanBL.GetMaxStrId_S();
 }
string strIdTeachingPlan = clsTeachingPlanBL.TeachingPlanDA.AddNewRecordBySQL2WithReturnKey(objTeachingPlanEN);
     objTeachingPlanEN.IdTeachingPlan = strIdTeachingPlan;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
}
return strIdTeachingPlan;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTeachingPlanEN objTeachingPlanEN)
{
try
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true || clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan) == true)
 {
     objTeachingPlanEN.IdTeachingPlan = clsTeachingPlanBL.GetMaxStrId_S();
 }
string strKey = clsTeachingPlanBL.TeachingPlanDA.AddNewRecordBySQL2WithReturnKey(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetIdTeachingPlan(this clsTeachingPlanEN objTeachingPlanEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conTeachingPlan.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conTeachingPlan.IdTeachingPlan);
}
objTeachingPlanEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.IdTeachingPlan) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.IdTeachingPlan, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.IdTeachingPlan] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetSubjectName(this clsTeachingPlanEN objTeachingPlanEN, string strSubjectName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, conTeachingPlan.SubjectName);
}
objTeachingPlanEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.SubjectName) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.SubjectName, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.SubjectName] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanAuthor(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, conTeachingPlan.TeachingPlanAuthor);
}
objTeachingPlanEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanAuthor) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanAuthor, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanAuthor] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingObject(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingObject, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, conTeachingPlan.TeachingObject);
}
objTeachingPlanEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingObject) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingObject, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingObject] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingEmphases(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingEmphases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, conTeachingPlan.TeachingEmphases);
}
objTeachingPlanEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingEmphases) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingEmphases, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingEmphases] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingDifficulty(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingDifficulty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, conTeachingPlan.TeachingDifficulty);
}
objTeachingPlanEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingDifficulty) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingDifficulty, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingDifficulty] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingTool(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingTool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, conTeachingPlan.TeachingTool);
}
objTeachingPlanEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingTool) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingTool, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingTool] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingProcess(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, conTeachingPlan.TeachingProcess);
}
objTeachingPlanEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingProcess) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingProcess, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingProcess] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanType(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
}
objTeachingPlanEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanType) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanType, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanType] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetSimplePlanContent(this clsTeachingPlanEN objTeachingPlanEN, string strSimplePlanContent, string strComparisonOp="")
	{
objTeachingPlanEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.SimplePlanContent) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.SimplePlanContent, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.SimplePlanContent] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanInDate(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
}
objTeachingPlanEN.TeachingPlanInDate = strTeachingPlanInDate; //教案入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanInDate) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanInDate, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanInDate] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanInTime(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanInTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
}
objTeachingPlanEN.TeachingPlanInTime = strTeachingPlanInTime; //教案入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanInTime) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanInTime, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanInTime] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetUpdDate(this clsTeachingPlanEN objTeachingPlanEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingPlan.UpdDate);
}
objTeachingPlanEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.UpdDate) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.UpdDate, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.UpdDate] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetUpdUserId(this clsTeachingPlanEN objTeachingPlanEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachingPlan.UpdUserId);
}
objTeachingPlanEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.UpdUserId) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.UpdUserId, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.UpdUserId] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingPlanEN SetMemo(this clsTeachingPlanEN objTeachingPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingPlan.Memo);
}
objTeachingPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.Memo) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.Memo, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.Memo] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingPlanEN objTeachingPlanEN)
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachingPlanBL.TeachingPlanDA.UpdateBySql2(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingPlanEN objTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachingPlanBL.TeachingPlanDA.UpdateBySql2(objTeachingPlanEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingPlanEN objTeachingPlanEN, string strWhereCond)
{
try
{
bool bolResult = clsTeachingPlanBL.TeachingPlanDA.UpdateBySqlWithCondition(objTeachingPlanEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingPlanEN objTeachingPlanEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTeachingPlanBL.TeachingPlanDA.UpdateBySqlWithConditionTransaction(objTeachingPlanEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTeachingPlanEN objTeachingPlanEN)
{
try
{
int intRecNum = clsTeachingPlanBL.TeachingPlanDA.DelRecord(objTeachingPlanEN.IdTeachingPlan);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanENS">源对象</param>
 /// <param name = "objTeachingPlanENT">目标对象</param>
 public static void CopyTo(this clsTeachingPlanEN objTeachingPlanENS, clsTeachingPlanEN objTeachingPlanENT)
{
try
{
objTeachingPlanENT.IdTeachingPlan = objTeachingPlanENS.IdTeachingPlan; //教案流水号
objTeachingPlanENT.SubjectName = objTeachingPlanENS.SubjectName; //课题名称
objTeachingPlanENT.TeachingPlanAuthor = objTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objTeachingPlanENT.TeachingObject = objTeachingPlanENS.TeachingObject; //教学目标
objTeachingPlanENT.TeachingEmphases = objTeachingPlanENS.TeachingEmphases; //教学重点
objTeachingPlanENT.TeachingDifficulty = objTeachingPlanENS.TeachingDifficulty; //教学难点
objTeachingPlanENT.TeachingTool = objTeachingPlanENS.TeachingTool; //教学用具
objTeachingPlanENT.TeachingProcess = objTeachingPlanENS.TeachingProcess; //教学过程
objTeachingPlanENT.TeachingPlanType = objTeachingPlanENS.TeachingPlanType; //教案类型
objTeachingPlanENT.SimplePlanContent = objTeachingPlanENS.SimplePlanContent; //简案内容
objTeachingPlanENT.TeachingPlanInDate = objTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objTeachingPlanENT.TeachingPlanInTime = objTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objTeachingPlanENT.UpdDate = objTeachingPlanENS.UpdDate; //修改日期
objTeachingPlanENT.UpdUserId = objTeachingPlanENS.UpdUserId; //修改用户Id
objTeachingPlanENT.Memo = objTeachingPlanENS.Memo; //备注
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
 /// <param name = "objTeachingPlanENS">源对象</param>
 /// <returns>目标对象=>clsTeachingPlanEN:objTeachingPlanENT</returns>
 public static clsTeachingPlanEN CopyTo(this clsTeachingPlanEN objTeachingPlanENS)
{
try
{
 clsTeachingPlanEN objTeachingPlanENT = new clsTeachingPlanEN()
{
IdTeachingPlan = objTeachingPlanENS.IdTeachingPlan, //教案流水号
SubjectName = objTeachingPlanENS.SubjectName, //课题名称
TeachingPlanAuthor = objTeachingPlanENS.TeachingPlanAuthor, //教案撰写人
TeachingObject = objTeachingPlanENS.TeachingObject, //教学目标
TeachingEmphases = objTeachingPlanENS.TeachingEmphases, //教学重点
TeachingDifficulty = objTeachingPlanENS.TeachingDifficulty, //教学难点
TeachingTool = objTeachingPlanENS.TeachingTool, //教学用具
TeachingProcess = objTeachingPlanENS.TeachingProcess, //教学过程
TeachingPlanType = objTeachingPlanENS.TeachingPlanType, //教案类型
SimplePlanContent = objTeachingPlanENS.SimplePlanContent, //简案内容
TeachingPlanInDate = objTeachingPlanENS.TeachingPlanInDate, //教案入库日期
TeachingPlanInTime = objTeachingPlanENS.TeachingPlanInTime, //教案入库时间
UpdDate = objTeachingPlanENS.UpdDate, //修改日期
UpdUserId = objTeachingPlanENS.UpdUserId, //修改用户Id
Memo = objTeachingPlanENS.Memo, //备注
};
 return objTeachingPlanENT;
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
public static void CheckPropertyNew(this clsTeachingPlanEN objTeachingPlanEN)
{
 clsTeachingPlanBL.TeachingPlanDA.CheckPropertyNew(objTeachingPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTeachingPlanEN objTeachingPlanEN)
{
 clsTeachingPlanBL.TeachingPlanDA.CheckProperty4Condition(objTeachingPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingPlanEN objTeachingPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.IdTeachingPlan, objTeachingPlanCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.SubjectName) == true)
{
string strComparisonOpSubjectName = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.SubjectName, objTeachingPlanCond.SubjectName, strComparisonOpSubjectName);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingPlanAuthor) == true)
{
string strComparisonOpTeachingPlanAuthor = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanAuthor, objTeachingPlanCond.TeachingPlanAuthor, strComparisonOpTeachingPlanAuthor);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingObject) == true)
{
string strComparisonOpTeachingObject = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingObject, objTeachingPlanCond.TeachingObject, strComparisonOpTeachingObject);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingEmphases) == true)
{
string strComparisonOpTeachingEmphases = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingEmphases, objTeachingPlanCond.TeachingEmphases, strComparisonOpTeachingEmphases);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingDifficulty) == true)
{
string strComparisonOpTeachingDifficulty = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingDifficulty, objTeachingPlanCond.TeachingDifficulty, strComparisonOpTeachingDifficulty);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingTool) == true)
{
string strComparisonOpTeachingTool = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingTool, objTeachingPlanCond.TeachingTool, strComparisonOpTeachingTool);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingProcess) == true)
{
string strComparisonOpTeachingProcess = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingProcess, objTeachingPlanCond.TeachingProcess, strComparisonOpTeachingProcess);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingPlanType) == true)
{
string strComparisonOpTeachingPlanType = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanType, objTeachingPlanCond.TeachingPlanType, strComparisonOpTeachingPlanType);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingPlanInDate) == true)
{
string strComparisonOpTeachingPlanInDate = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingPlanInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanInDate, objTeachingPlanCond.TeachingPlanInDate, strComparisonOpTeachingPlanInDate);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.TeachingPlanInTime) == true)
{
string strComparisonOpTeachingPlanInTime = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.TeachingPlanInTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanInTime, objTeachingPlanCond.TeachingPlanInTime, strComparisonOpTeachingPlanInTime);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.UpdDate) == true)
{
string strComparisonOpUpdDate = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.UpdDate, objTeachingPlanCond.UpdDate, strComparisonOpUpdDate);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.UpdUserId, objTeachingPlanCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objTeachingPlanCond.IsUpdated(conTeachingPlan.Memo) == true)
{
string strComparisonOpMemo = objTeachingPlanCond.dicFldComparisonOp[conTeachingPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.Memo, objTeachingPlanCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TeachingPlan
{
public virtual bool UpdRelaTabDate(string strIdTeachingPlan, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教案(TeachingPlan)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTeachingPlanBL
{
public static RelatedActions_TeachingPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTeachingPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTeachingPlanDA TeachingPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTeachingPlanDA();
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
 public clsTeachingPlanBL()
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
if (string.IsNullOrEmpty(clsTeachingPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingPlanEN._ConnectString);
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
public static DataTable GetDataTable_TeachingPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TeachingPlanDA.GetDataTable_TeachingPlan(strWhereCond);
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
objDT = TeachingPlanDA.GetDataTable(strWhereCond);
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
objDT = TeachingPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TeachingPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TeachingPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TeachingPlanDA.GetDataTable_Top(objTopPara);
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
objDT = TeachingPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TeachingPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TeachingPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachingPlanLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLstByIdTeachingPlanLst(List<string> arrIdTeachingPlanLst)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachingPlanLst, true);
 string strWhereCond = string.Format("IdTeachingPlan in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachingPlanLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTeachingPlanEN> GetObjLstByIdTeachingPlanLstCache(List<string> arrIdTeachingPlanLst)
{
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName);
List<clsTeachingPlanEN> arrTeachingPlanObjLstCache = GetObjLstCache();
IEnumerable <clsTeachingPlanEN> arrTeachingPlanObjLst_Sel =
arrTeachingPlanObjLstCache
.Where(x => arrIdTeachingPlanLst.Contains(x.IdTeachingPlan));
return arrTeachingPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLst(string strWhereCond)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
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
public static List<clsTeachingPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTeachingPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTeachingPlanEN> GetSubObjLstCache(clsTeachingPlanEN objTeachingPlanCond)
{
List<clsTeachingPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeachingPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachingPlan.AttributeName)
{
if (objTeachingPlanCond.IsUpdated(strFldName) == false) continue;
if (objTeachingPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingPlanCond[strFldName].ToString());
}
else
{
if (objTeachingPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachingPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachingPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachingPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachingPlanCond[strFldName]));
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
public static List<clsTeachingPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
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
public static List<clsTeachingPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
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
List<clsTeachingPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTeachingPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTeachingPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
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
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
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
public static List<clsTeachingPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTeachingPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
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
public static List<clsTeachingPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTeachingPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTeachingPlan(ref clsTeachingPlanEN objTeachingPlanEN)
{
bool bolResult = TeachingPlanDA.GetTeachingPlan(ref objTeachingPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingPlanEN GetObjByIdTeachingPlan(string strIdTeachingPlan)
{
if (strIdTeachingPlan.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachingPlan]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachingPlan) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachingPlan]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTeachingPlanEN objTeachingPlanEN = TeachingPlanDA.GetObjByIdTeachingPlan(strIdTeachingPlan);
return objTeachingPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTeachingPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTeachingPlanEN objTeachingPlanEN = TeachingPlanDA.GetFirstObj(strWhereCond);
 return objTeachingPlanEN;
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
public static clsTeachingPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTeachingPlanEN objTeachingPlanEN = TeachingPlanDA.GetObjByDataRow(objRow);
 return objTeachingPlanEN;
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
public static clsTeachingPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTeachingPlanEN objTeachingPlanEN = TeachingPlanDA.GetObjByDataRow(objRow);
 return objTeachingPlanEN;
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
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <param name = "lstTeachingPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachingPlanEN GetObjByIdTeachingPlanFromList(string strIdTeachingPlan, List<clsTeachingPlanEN> lstTeachingPlanObjLst)
{
foreach (clsTeachingPlanEN objTeachingPlanEN in lstTeachingPlanObjLst)
{
if (objTeachingPlanEN.IdTeachingPlan == strIdTeachingPlan)
{
return objTeachingPlanEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdTeachingPlan;
 try
 {
 strMaxIdTeachingPlan = clsTeachingPlanDA.GetMaxStrId();
 return strMaxIdTeachingPlan;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdTeachingPlan;
 try
 {
 strIdTeachingPlan = new clsTeachingPlanDA().GetFirstID(strWhereCond);
 return strIdTeachingPlan;
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
 arrList = TeachingPlanDA.GetID(strWhereCond);
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
bool bolIsExist = TeachingPlanDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachingPlan)
{
if (string.IsNullOrEmpty(strIdTeachingPlan) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachingPlan]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TeachingPlanDA.IsExist(strIdTeachingPlan);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdTeachingPlan">教案流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdTeachingPlan, string strOpUser)
{
clsTeachingPlanEN objTeachingPlanEN = clsTeachingPlanBL.GetObjByIdTeachingPlan(strIdTeachingPlan);
objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTeachingPlanEN.UpdUserId = strOpUser;
return clsTeachingPlanBL.UpdateBySql2(objTeachingPlanEN);
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
 bolIsExist = clsTeachingPlanDA.IsExistTable();
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
 bolIsExist = TeachingPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTeachingPlanEN objTeachingPlanEN)
{
try
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true || clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan) == true)
 {
     objTeachingPlanEN.IdTeachingPlan = clsTeachingPlanBL.GetMaxStrId_S();
 }
bool bolResult = TeachingPlanDA.AddNewRecordBySQL2(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTeachingPlanEN objTeachingPlanEN)
{
try
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true || clsTeachingPlanBL.IsExist(objTeachingPlanEN.IdTeachingPlan) == true)
 {
     objTeachingPlanEN.IdTeachingPlan = clsTeachingPlanBL.GetMaxStrId_S();
 }
string strKey = TeachingPlanDA.AddNewRecordBySQL2WithReturnKey(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTeachingPlanEN objTeachingPlanEN)
{
try
{
bool bolResult = TeachingPlanDA.Update(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTeachingPlanEN objTeachingPlanEN)
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.IdTeachingPlan) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TeachingPlanDA.UpdateBySql2(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanBL.ReFreshCache();

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
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
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdTeachingPlan)
{
try
{
 clsTeachingPlanEN objTeachingPlanEN = clsTeachingPlanBL.GetObjByIdTeachingPlan(strIdTeachingPlan);

if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(objTeachingPlanEN.IdTeachingPlan, objTeachingPlanEN.UpdUserId);
}
if (objTeachingPlanEN != null)
{
int intRecNum = TeachingPlanDA.DelRecord(strIdTeachingPlan);
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
/// <param name="strIdTeachingPlan">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdTeachingPlan )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
//删除与表:[TeachingPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTeachingPlan.IdTeachingPlan,
//strIdTeachingPlan);
//        clsTeachingPlanBL.DelTeachingPlansByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachingPlanBL.DelRecord(strIdTeachingPlan, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachingPlanBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeachingPlan, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdTeachingPlan, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTeachingPlanBL.relatedActions != null)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(strIdTeachingPlan, "UpdRelaTabDate");
}
bool bolResult = TeachingPlanDA.DelRecord(strIdTeachingPlan,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdTeachingPlanLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTeachingPlans(List<string> arrIdTeachingPlanLst)
{
if (arrIdTeachingPlanLst.Count == 0) return 0;
try
{
if (clsTeachingPlanBL.relatedActions != null)
{
foreach (var strIdTeachingPlan in arrIdTeachingPlanLst)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(strIdTeachingPlan, "UpdRelaTabDate");
}
}
int intDelRecNum = TeachingPlanDA.DelTeachingPlan(arrIdTeachingPlanLst);
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
public static int DelTeachingPlansByCond(string strWhereCond)
{
try
{
if (clsTeachingPlanBL.relatedActions != null)
{
List<string> arrIdTeachingPlan = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdTeachingPlan in arrIdTeachingPlan)
{
clsTeachingPlanBL.relatedActions.UpdRelaTabDate(strIdTeachingPlan, "UpdRelaTabDate");
}
}
int intRecNum = TeachingPlanDA.DelTeachingPlan(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TeachingPlan]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdTeachingPlan">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdTeachingPlan)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
//删除与表:[TeachingPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachingPlanBL.DelRecord(strIdTeachingPlan, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachingPlanBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeachingPlan, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTeachingPlanENS">源对象</param>
 /// <param name = "objTeachingPlanENT">目标对象</param>
 public static void CopyTo(clsTeachingPlanEN objTeachingPlanENS, clsTeachingPlanEN objTeachingPlanENT)
{
try
{
objTeachingPlanENT.IdTeachingPlan = objTeachingPlanENS.IdTeachingPlan; //教案流水号
objTeachingPlanENT.SubjectName = objTeachingPlanENS.SubjectName; //课题名称
objTeachingPlanENT.TeachingPlanAuthor = objTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objTeachingPlanENT.TeachingObject = objTeachingPlanENS.TeachingObject; //教学目标
objTeachingPlanENT.TeachingEmphases = objTeachingPlanENS.TeachingEmphases; //教学重点
objTeachingPlanENT.TeachingDifficulty = objTeachingPlanENS.TeachingDifficulty; //教学难点
objTeachingPlanENT.TeachingTool = objTeachingPlanENS.TeachingTool; //教学用具
objTeachingPlanENT.TeachingProcess = objTeachingPlanENS.TeachingProcess; //教学过程
objTeachingPlanENT.TeachingPlanType = objTeachingPlanENS.TeachingPlanType; //教案类型
objTeachingPlanENT.SimplePlanContent = objTeachingPlanENS.SimplePlanContent; //简案内容
objTeachingPlanENT.TeachingPlanInDate = objTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objTeachingPlanENT.TeachingPlanInTime = objTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objTeachingPlanENT.UpdDate = objTeachingPlanENS.UpdDate; //修改日期
objTeachingPlanENT.UpdUserId = objTeachingPlanENS.UpdUserId; //修改用户Id
objTeachingPlanENT.Memo = objTeachingPlanENS.Memo; //备注
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
 /// <param name = "objTeachingPlanEN">源简化对象</param>
 public static void SetUpdFlag(clsTeachingPlanEN objTeachingPlanEN)
{
try
{
objTeachingPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTeachingPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTeachingPlan.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.IdTeachingPlan = objTeachingPlanEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conTeachingPlan.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.SubjectName = objTeachingPlanEN.SubjectName == "[null]" ? null :  objTeachingPlanEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(conTeachingPlan.TeachingPlanAuthor, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor == "[null]" ? null :  objTeachingPlanEN.TeachingPlanAuthor; //教案撰写人
}
if (arrFldSet.Contains(conTeachingPlan.TeachingObject, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingObject = objTeachingPlanEN.TeachingObject == "[null]" ? null :  objTeachingPlanEN.TeachingObject; //教学目标
}
if (arrFldSet.Contains(conTeachingPlan.TeachingEmphases, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingEmphases = objTeachingPlanEN.TeachingEmphases == "[null]" ? null :  objTeachingPlanEN.TeachingEmphases; //教学重点
}
if (arrFldSet.Contains(conTeachingPlan.TeachingDifficulty, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingDifficulty = objTeachingPlanEN.TeachingDifficulty == "[null]" ? null :  objTeachingPlanEN.TeachingDifficulty; //教学难点
}
if (arrFldSet.Contains(conTeachingPlan.TeachingTool, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingTool = objTeachingPlanEN.TeachingTool == "[null]" ? null :  objTeachingPlanEN.TeachingTool; //教学用具
}
if (arrFldSet.Contains(conTeachingPlan.TeachingProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingProcess = objTeachingPlanEN.TeachingProcess == "[null]" ? null :  objTeachingPlanEN.TeachingProcess; //教学过程
}
if (arrFldSet.Contains(conTeachingPlan.TeachingPlanType, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingPlanType = objTeachingPlanEN.TeachingPlanType == "[null]" ? null :  objTeachingPlanEN.TeachingPlanType; //教案类型
}
if (arrFldSet.Contains(conTeachingPlan.SimplePlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.SimplePlanContent = objTeachingPlanEN.SimplePlanContent == "[null]" ? null :  objTeachingPlanEN.SimplePlanContent; //简案内容
}
if (arrFldSet.Contains(conTeachingPlan.TeachingPlanInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate == "[null]" ? null :  objTeachingPlanEN.TeachingPlanInDate; //教案入库日期
}
if (arrFldSet.Contains(conTeachingPlan.TeachingPlanInTime, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.TeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime == "[null]" ? null :  objTeachingPlanEN.TeachingPlanInTime; //教案入库时间
}
if (arrFldSet.Contains(conTeachingPlan.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.UpdDate = objTeachingPlanEN.UpdDate == "[null]" ? null :  objTeachingPlanEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTeachingPlan.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.UpdUserId = objTeachingPlanEN.UpdUserId == "[null]" ? null :  objTeachingPlanEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conTeachingPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingPlanEN.Memo = objTeachingPlanEN.Memo == "[null]" ? null :  objTeachingPlanEN.Memo; //备注
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
 /// <param name = "objTeachingPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clsTeachingPlanEN objTeachingPlanEN)
{
try
{
if (objTeachingPlanEN.SubjectName == "[null]") objTeachingPlanEN.SubjectName = null; //课题名称
if (objTeachingPlanEN.TeachingPlanAuthor == "[null]") objTeachingPlanEN.TeachingPlanAuthor = null; //教案撰写人
if (objTeachingPlanEN.TeachingObject == "[null]") objTeachingPlanEN.TeachingObject = null; //教学目标
if (objTeachingPlanEN.TeachingEmphases == "[null]") objTeachingPlanEN.TeachingEmphases = null; //教学重点
if (objTeachingPlanEN.TeachingDifficulty == "[null]") objTeachingPlanEN.TeachingDifficulty = null; //教学难点
if (objTeachingPlanEN.TeachingTool == "[null]") objTeachingPlanEN.TeachingTool = null; //教学用具
if (objTeachingPlanEN.TeachingProcess == "[null]") objTeachingPlanEN.TeachingProcess = null; //教学过程
if (objTeachingPlanEN.TeachingPlanType == "[null]") objTeachingPlanEN.TeachingPlanType = null; //教案类型
if (objTeachingPlanEN.SimplePlanContent == "[null]") objTeachingPlanEN.SimplePlanContent = null; //简案内容
if (objTeachingPlanEN.TeachingPlanInDate == "[null]") objTeachingPlanEN.TeachingPlanInDate = null; //教案入库日期
if (objTeachingPlanEN.TeachingPlanInTime == "[null]") objTeachingPlanEN.TeachingPlanInTime = null; //教案入库时间
if (objTeachingPlanEN.UpdDate == "[null]") objTeachingPlanEN.UpdDate = null; //修改日期
if (objTeachingPlanEN.UpdUserId == "[null]") objTeachingPlanEN.UpdUserId = null; //修改用户Id
if (objTeachingPlanEN.Memo == "[null]") objTeachingPlanEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTeachingPlanEN objTeachingPlanEN)
{
 TeachingPlanDA.CheckPropertyNew(objTeachingPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTeachingPlanEN objTeachingPlanEN)
{
 TeachingPlanDA.CheckProperty4Condition(objTeachingPlanEN);
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
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachingPlan");
//if (arrTeachingPlanObjLstCache == null)
//{
//arrTeachingPlanObjLstCache = TeachingPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachingPlanEN GetObjByIdTeachingPlanCache(string strIdTeachingPlan)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName);
List<clsTeachingPlanEN> arrTeachingPlanObjLstCache = GetObjLstCache();
IEnumerable <clsTeachingPlanEN> arrTeachingPlanObjLst_Sel =
arrTeachingPlanObjLstCache
.Where(x=> x.IdTeachingPlan == strIdTeachingPlan 
);
if (arrTeachingPlanObjLst_Sel.Count() == 0)
{
   clsTeachingPlanEN obj = clsTeachingPlanBL.GetObjByIdTeachingPlan(strIdTeachingPlan);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTeachingPlanObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingPlanEN> GetAllTeachingPlanObjLstCache()
{
//获取缓存中的对象列表
List<clsTeachingPlanEN> arrTeachingPlanObjLstCache = GetObjLstCache(); 
return arrTeachingPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName);
List<clsTeachingPlanEN> arrTeachingPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachingPlanObjLstCache;
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
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName);
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
if (clsTeachingPlanBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTeachingPlanBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdTeachingPlan)
{
if (strInFldName != conTeachingPlan.IdTeachingPlan)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTeachingPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTeachingPlan.AttributeName));
throw new Exception(strMsg);
}
var objTeachingPlan = clsTeachingPlanBL.GetObjByIdTeachingPlanCache(strIdTeachingPlan);
if (objTeachingPlan == null) return "";
return objTeachingPlan[strOutFldName].ToString();
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
int intRecCount = clsTeachingPlanDA.GetRecCount(strTabName);
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
int intRecCount = clsTeachingPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTeachingPlanDA.GetRecCount();
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
int intRecCount = clsTeachingPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTeachingPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTeachingPlanEN objTeachingPlanCond)
{
List<clsTeachingPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeachingPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachingPlan.AttributeName)
{
if (objTeachingPlanCond.IsUpdated(strFldName) == false) continue;
if (objTeachingPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingPlanCond[strFldName].ToString());
}
else
{
if (objTeachingPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachingPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachingPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachingPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachingPlanCond[strFldName]));
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
 List<string> arrList = clsTeachingPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TeachingPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TeachingPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TeachingPlanDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachingPlanDA.SetFldValue(clsTeachingPlanEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TeachingPlanDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachingPlanDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachingPlanDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachingPlanDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TeachingPlan] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) primary key, "); 
 // /**课题名称*/ 
 strCreateTabCode.Append(" SubjectName varchar(200) Null, "); 
 // /**教案撰写人*/ 
 strCreateTabCode.Append(" TeachingPlanAuthor varchar(50) Null, "); 
 // /**教学目标*/ 
 strCreateTabCode.Append(" TeachingObject varchar(5000) Null, "); 
 // /**教学重点*/ 
 strCreateTabCode.Append(" TeachingEmphases varchar(5000) Null, "); 
 // /**教学难点*/ 
 strCreateTabCode.Append(" TeachingDifficulty varchar(5000) Null, "); 
 // /**教学用具*/ 
 strCreateTabCode.Append(" TeachingTool varchar(5000) Null, "); 
 // /**教学过程*/ 
 strCreateTabCode.Append(" TeachingProcess varchar(8000) Null, "); 
 // /**教案类型*/ 
 strCreateTabCode.Append(" TeachingPlanType char(1) Null, "); 
 // /**简案内容*/ 
 strCreateTabCode.Append(" SimplePlanContent text Null, "); 
 // /**教案入库日期*/ 
 strCreateTabCode.Append(" TeachingPlanInDate char(8) Null, "); 
 // /**教案入库时间*/ 
 strCreateTabCode.Append(" TeachingPlanInTime char(6) Null, "); 
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
 /// 教案(TeachingPlan)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TeachingPlan : clsCommFun4BL
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
clsTeachingPlanBL.ReFreshThisCache();
}
}

}