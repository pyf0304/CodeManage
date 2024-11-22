
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJxTeachingPlanBL
 表名:JxTeachingPlan(01120968)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学执行计划管理(TeachingPlan)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsJxTeachingPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsJxTeachingPlanEN GetObj(this K_IdTeachingPlan_JxTeachingPlan myKey)
{
clsJxTeachingPlanEN objJxTeachingPlanEN = clsJxTeachingPlanBL.JxTeachingPlanDA.GetObjByIdTeachingPlan(myKey.Value);
return objJxTeachingPlanEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJxTeachingPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!教学计划名称 = [{0}],教学计划编号 = [{1}]的数据已经存在!(in clsJxTeachingPlanBL.AddNewRecord)", objJxTeachingPlanEN.TeachingPlanDesc,objJxTeachingPlanEN.TeachingPlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true || clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
     objJxTeachingPlanEN.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
 }
bool bolResult = clsJxTeachingPlanBL.JxTeachingPlanDA.AddNewRecordBySQL2(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
public static bool AddRecordEx(this clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objJxTeachingPlanEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objJxTeachingPlanEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学计划名称(TeachingPlanDesc)=[{0}],教学计划编号(TeachingPlanId)=[{1}])已经存在,不能重复!", objJxTeachingPlanEN.TeachingPlanDesc, objJxTeachingPlanEN.TeachingPlanId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true || clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
     objJxTeachingPlanEN.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objJxTeachingPlanEN.AddNewRecord();
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJxTeachingPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!教学计划名称 = [{0}],教学计划编号 = [{1}]的数据已经存在!(in clsJxTeachingPlanBL.AddNewRecordWithMaxId)", objJxTeachingPlanEN.TeachingPlanDesc,objJxTeachingPlanEN.TeachingPlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true || clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
     objJxTeachingPlanEN.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
 }
string strIdTeachingPlan = clsJxTeachingPlanBL.JxTeachingPlanDA.AddNewRecordBySQL2WithReturnKey(objJxTeachingPlanEN);
     objJxTeachingPlanEN.IdTeachingPlan = strIdTeachingPlan;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJxTeachingPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!教学计划名称 = [{0}],教学计划编号 = [{1}]的数据已经存在!(in clsJxTeachingPlanBL.AddNewRecordWithReturnKey)", objJxTeachingPlanEN.TeachingPlanDesc,objJxTeachingPlanEN.TeachingPlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true || clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
     objJxTeachingPlanEN.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
 }
string strKey = clsJxTeachingPlanBL.JxTeachingPlanDA.AddNewRecordBySQL2WithReturnKey(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetIdTeachingPlan(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conJxTeachingPlan.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conJxTeachingPlan.IdTeachingPlan);
}
objJxTeachingPlanEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.IdTeachingPlan) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.IdTeachingPlan, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.IdTeachingPlan] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetTeachingPlanId(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strTeachingPlanId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingPlanId, conJxTeachingPlan.TeachingPlanId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanId, 12, conJxTeachingPlan.TeachingPlanId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanId, 12, conJxTeachingPlan.TeachingPlanId);
}
objJxTeachingPlanEN.TeachingPlanId = strTeachingPlanId; //教学计划编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.TeachingPlanId) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.TeachingPlanId, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.TeachingPlanId] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetTeachingPlanDesc(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strTeachingPlanDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingPlanDesc, conJxTeachingPlan.TeachingPlanDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanDesc, 100, conJxTeachingPlan.TeachingPlanDesc);
}
objJxTeachingPlanEN.TeachingPlanDesc = strTeachingPlanDesc; //教学计划名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.TeachingPlanDesc) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.TeachingPlanDesc, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.TeachingPlanDesc] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetIdGrade(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strIdGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGrade, conJxTeachingPlan.IdGrade);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGrade, 4, conJxTeachingPlan.IdGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGrade, 4, conJxTeachingPlan.IdGrade);
}
objJxTeachingPlanEN.IdGrade = strIdGrade; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.IdGrade) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.IdGrade, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.IdGrade] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetSchoolTerm(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolTerm, conJxTeachingPlan.SchoolTerm);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conJxTeachingPlan.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conJxTeachingPlan.SchoolTerm);
}
objJxTeachingPlanEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.SchoolTerm) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.SchoolTerm, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.SchoolTerm] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetCourseId(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conJxTeachingPlan.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conJxTeachingPlan.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conJxTeachingPlan.CourseId);
}
objJxTeachingPlanEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.CourseId) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.CourseId, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.CourseId] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetIsClgCheck(this clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsClgCheck, string strComparisonOp="")
	{
objJxTeachingPlanEN.IsClgCheck = bolIsClgCheck; //是否学院审批
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.IsClgCheck) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.IsClgCheck, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.IsClgCheck] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetClgNote(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strClgNote, string strComparisonOp="")
	{
objJxTeachingPlanEN.ClgNote = strClgNote; //学院审批意见
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.ClgNote) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.ClgNote, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.ClgNote] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetClgCheckerId(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strClgCheckerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgCheckerId, 18, conJxTeachingPlan.ClgCheckerId);
}
objJxTeachingPlanEN.ClgCheckerId = strClgCheckerId; //学院审批人id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.ClgCheckerId) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.ClgCheckerId, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.ClgCheckerId] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetClgCheckDate(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strClgCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgCheckDate, 8, conJxTeachingPlan.ClgCheckDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClgCheckDate, 8, conJxTeachingPlan.ClgCheckDate);
}
objJxTeachingPlanEN.ClgCheckDate = strClgCheckDate; //学院审批日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.ClgCheckDate) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.ClgCheckDate, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.ClgCheckDate] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetIsSchCheck(this clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsSchCheck, string strComparisonOp="")
	{
objJxTeachingPlanEN.IsSchCheck = bolIsSchCheck; //是否学校审批
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.IsSchCheck) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.IsSchCheck, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.IsSchCheck] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetSchNote(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strSchNote, string strComparisonOp="")
	{
objJxTeachingPlanEN.SchNote = strSchNote; //学校审批意见
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.SchNote) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.SchNote, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.SchNote] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetSchCheckerId(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strSchCheckerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchCheckerId, 18, conJxTeachingPlan.SchCheckerId);
}
objJxTeachingPlanEN.SchCheckerId = strSchCheckerId; //学校审批人Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.SchCheckerId) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.SchCheckerId, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.SchCheckerId] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetSchCheckDate(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strSchCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchCheckDate, 8, conJxTeachingPlan.SchCheckDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchCheckDate, 8, conJxTeachingPlan.SchCheckDate);
}
objJxTeachingPlanEN.SchCheckDate = strSchCheckDate; //学校审批日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.SchCheckDate) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.SchCheckDate, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.SchCheckDate] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetIdSubmitStatus(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strIdSubmitStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSubmitStatus, conJxTeachingPlan.IdSubmitStatus);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
}
objJxTeachingPlanEN.IdSubmitStatus = strIdSubmitStatus; //送审状态流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.IdSubmitStatus) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.IdSubmitStatus, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.IdSubmitStatus] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJxTeachingPlanEN SetMemo(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conJxTeachingPlan.Memo);
}
objJxTeachingPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJxTeachingPlanEN.dicFldComparisonOp.ContainsKey(conJxTeachingPlan.Memo) == false)
{
objJxTeachingPlanEN.dicFldComparisonOp.Add(conJxTeachingPlan.Memo, strComparisonOp);
}
else
{
objJxTeachingPlanEN.dicFldComparisonOp[conJxTeachingPlan.Memo] = strComparisonOp;
}
}
return objJxTeachingPlanEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objJxTeachingPlanEN.CheckPropertyNew();
clsJxTeachingPlanEN objJxTeachingPlanCond = new clsJxTeachingPlanEN();
string strCondition = objJxTeachingPlanCond
.SetIdTeachingPlan(objJxTeachingPlanEN.IdTeachingPlan, "<>")
.SetTeachingPlanDesc(objJxTeachingPlanEN.TeachingPlanDesc, "=")
.SetTeachingPlanId(objJxTeachingPlanEN.TeachingPlanId, "=")
.GetCombineCondition();
objJxTeachingPlanEN._IsCheckProperty = true;
bool bolIsExist = clsJxTeachingPlanBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(11)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objJxTeachingPlanEN.Update();
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
 /// <param name = "objJxTeachingPlan">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsJxTeachingPlanEN objJxTeachingPlan)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsJxTeachingPlanEN objJxTeachingPlanCond = new clsJxTeachingPlanEN();
string strCondition = objJxTeachingPlanCond
.SetTeachingPlanDesc(objJxTeachingPlan.TeachingPlanDesc, "=")
.SetTeachingPlanId(objJxTeachingPlan.TeachingPlanId, "=")
.GetCombineCondition();
objJxTeachingPlan._IsCheckProperty = true;
bool bolIsExist = clsJxTeachingPlanBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objJxTeachingPlan.IdTeachingPlan = clsJxTeachingPlanBL.GetFirstID_S(strCondition);
objJxTeachingPlan.UpdateWithCondition(strCondition);
}
else
{
objJxTeachingPlan.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
objJxTeachingPlan.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsJxTeachingPlanBL.JxTeachingPlanDA.UpdateBySql2(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsJxTeachingPlanEN objJxTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsJxTeachingPlanBL.JxTeachingPlanDA.UpdateBySql2(objJxTeachingPlanEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strWhereCond)
{
try
{
bool bolResult = clsJxTeachingPlanBL.JxTeachingPlanDA.UpdateBySqlWithCondition(objJxTeachingPlanEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsJxTeachingPlanEN objJxTeachingPlanEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsJxTeachingPlanBL.JxTeachingPlanDA.UpdateBySqlWithConditionTransaction(objJxTeachingPlanEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
public static int Delete(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
try
{
int intRecNum = clsJxTeachingPlanBL.JxTeachingPlanDA.DelRecord(objJxTeachingPlanEN.IdTeachingPlan);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanENS">源对象</param>
 /// <param name = "objJxTeachingPlanENT">目标对象</param>
 public static void CopyTo(this clsJxTeachingPlanEN objJxTeachingPlanENS, clsJxTeachingPlanEN objJxTeachingPlanENT)
{
try
{
objJxTeachingPlanENT.IdTeachingPlan = objJxTeachingPlanENS.IdTeachingPlan; //教案流水号
objJxTeachingPlanENT.TeachingPlanId = objJxTeachingPlanENS.TeachingPlanId; //教学计划编号
objJxTeachingPlanENT.TeachingPlanDesc = objJxTeachingPlanENS.TeachingPlanDesc; //教学计划名称
objJxTeachingPlanENT.IdGrade = objJxTeachingPlanENS.IdGrade; //年级流水号
objJxTeachingPlanENT.SchoolTerm = objJxTeachingPlanENS.SchoolTerm; //学期
objJxTeachingPlanENT.CourseId = objJxTeachingPlanENS.CourseId; //课程Id
objJxTeachingPlanENT.IsClgCheck = objJxTeachingPlanENS.IsClgCheck; //是否学院审批
objJxTeachingPlanENT.ClgNote = objJxTeachingPlanENS.ClgNote; //学院审批意见
objJxTeachingPlanENT.ClgCheckerId = objJxTeachingPlanENS.ClgCheckerId; //学院审批人id
objJxTeachingPlanENT.ClgCheckDate = objJxTeachingPlanENS.ClgCheckDate; //学院审批日期
objJxTeachingPlanENT.IsSchCheck = objJxTeachingPlanENS.IsSchCheck; //是否学校审批
objJxTeachingPlanENT.SchNote = objJxTeachingPlanENS.SchNote; //学校审批意见
objJxTeachingPlanENT.SchCheckerId = objJxTeachingPlanENS.SchCheckerId; //学校审批人Id
objJxTeachingPlanENT.SchCheckDate = objJxTeachingPlanENS.SchCheckDate; //学校审批日期
objJxTeachingPlanENT.IdSubmitStatus = objJxTeachingPlanENS.IdSubmitStatus; //送审状态流水号
objJxTeachingPlanENT.Memo = objJxTeachingPlanENS.Memo; //备注
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
 /// <param name = "objJxTeachingPlanENS">源对象</param>
 /// <returns>目标对象=>clsJxTeachingPlanEN:objJxTeachingPlanENT</returns>
 public static clsJxTeachingPlanEN CopyTo(this clsJxTeachingPlanEN objJxTeachingPlanENS)
{
try
{
 clsJxTeachingPlanEN objJxTeachingPlanENT = new clsJxTeachingPlanEN()
{
IdTeachingPlan = objJxTeachingPlanENS.IdTeachingPlan, //教案流水号
TeachingPlanId = objJxTeachingPlanENS.TeachingPlanId, //教学计划编号
TeachingPlanDesc = objJxTeachingPlanENS.TeachingPlanDesc, //教学计划名称
IdGrade = objJxTeachingPlanENS.IdGrade, //年级流水号
SchoolTerm = objJxTeachingPlanENS.SchoolTerm, //学期
CourseId = objJxTeachingPlanENS.CourseId, //课程Id
IsClgCheck = objJxTeachingPlanENS.IsClgCheck, //是否学院审批
ClgNote = objJxTeachingPlanENS.ClgNote, //学院审批意见
ClgCheckerId = objJxTeachingPlanENS.ClgCheckerId, //学院审批人id
ClgCheckDate = objJxTeachingPlanENS.ClgCheckDate, //学院审批日期
IsSchCheck = objJxTeachingPlanENS.IsSchCheck, //是否学校审批
SchNote = objJxTeachingPlanENS.SchNote, //学校审批意见
SchCheckerId = objJxTeachingPlanENS.SchCheckerId, //学校审批人Id
SchCheckDate = objJxTeachingPlanENS.SchCheckDate, //学校审批日期
IdSubmitStatus = objJxTeachingPlanENS.IdSubmitStatus, //送审状态流水号
Memo = objJxTeachingPlanENS.Memo, //备注
};
 return objJxTeachingPlanENT;
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
public static void CheckPropertyNew(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 clsJxTeachingPlanBL.JxTeachingPlanDA.CheckPropertyNew(objJxTeachingPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 clsJxTeachingPlanBL.JxTeachingPlanDA.CheckProperty4Condition(objJxTeachingPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsJxTeachingPlanEN objJxTeachingPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.IdTeachingPlan, objJxTeachingPlanCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.TeachingPlanId) == true)
{
string strComparisonOpTeachingPlanId = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.TeachingPlanId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.TeachingPlanId, objJxTeachingPlanCond.TeachingPlanId, strComparisonOpTeachingPlanId);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.TeachingPlanDesc) == true)
{
string strComparisonOpTeachingPlanDesc = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.TeachingPlanDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.TeachingPlanDesc, objJxTeachingPlanCond.TeachingPlanDesc, strComparisonOpTeachingPlanDesc);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.IdGrade) == true)
{
string strComparisonOpIdGrade = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.IdGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.IdGrade, objJxTeachingPlanCond.IdGrade, strComparisonOpIdGrade);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.SchoolTerm, objJxTeachingPlanCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.CourseId) == true)
{
string strComparisonOpCourseId = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.CourseId, objJxTeachingPlanCond.CourseId, strComparisonOpCourseId);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.IsClgCheck) == true)
{
if (objJxTeachingPlanCond.IsClgCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", conJxTeachingPlan.IsClgCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conJxTeachingPlan.IsClgCheck);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.ClgCheckerId) == true)
{
string strComparisonOpClgCheckerId = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.ClgCheckerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.ClgCheckerId, objJxTeachingPlanCond.ClgCheckerId, strComparisonOpClgCheckerId);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.ClgCheckDate) == true)
{
string strComparisonOpClgCheckDate = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.ClgCheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.ClgCheckDate, objJxTeachingPlanCond.ClgCheckDate, strComparisonOpClgCheckDate);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.IsSchCheck) == true)
{
if (objJxTeachingPlanCond.IsSchCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", conJxTeachingPlan.IsSchCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conJxTeachingPlan.IsSchCheck);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.SchCheckerId) == true)
{
string strComparisonOpSchCheckerId = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.SchCheckerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.SchCheckerId, objJxTeachingPlanCond.SchCheckerId, strComparisonOpSchCheckerId);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.SchCheckDate) == true)
{
string strComparisonOpSchCheckDate = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.SchCheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.SchCheckDate, objJxTeachingPlanCond.SchCheckDate, strComparisonOpSchCheckDate);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.IdSubmitStatus) == true)
{
string strComparisonOpIdSubmitStatus = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.IdSubmitStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.IdSubmitStatus, objJxTeachingPlanCond.IdSubmitStatus, strComparisonOpIdSubmitStatus);
}
if (objJxTeachingPlanCond.IsUpdated(conJxTeachingPlan.Memo) == true)
{
string strComparisonOpMemo = objJxTeachingPlanCond.dicFldComparisonOp[conJxTeachingPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJxTeachingPlan.Memo, objJxTeachingPlanCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--JxTeachingPlan(教学计划), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TeachingPlanDesc_TeachingPlanId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objJxTeachingPlanEN == null) return true;
if (objJxTeachingPlanEN.IdTeachingPlan == null || objJxTeachingPlanEN.IdTeachingPlan == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingPlanDesc = '{0}'", objJxTeachingPlanEN.TeachingPlanDesc);
 sbCondition.AppendFormat(" and TeachingPlanId = '{0}'", objJxTeachingPlanEN.TeachingPlanId);
if (clsJxTeachingPlanBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdTeachingPlan !=  '{0}'", objJxTeachingPlanEN.IdTeachingPlan);
 sbCondition.AppendFormat(" and TeachingPlanDesc = '{0}'", objJxTeachingPlanEN.TeachingPlanDesc);
 sbCondition.AppendFormat(" and TeachingPlanId = '{0}'", objJxTeachingPlanEN.TeachingPlanId);
if (clsJxTeachingPlanBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--JxTeachingPlan(教学计划), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TeachingPlanDesc_TeachingPlanId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objJxTeachingPlanEN == null) return "";
if (objJxTeachingPlanEN.IdTeachingPlan == null || objJxTeachingPlanEN.IdTeachingPlan == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingPlanDesc = '{0}'", objJxTeachingPlanEN.TeachingPlanDesc);
 sbCondition.AppendFormat(" and TeachingPlanId = '{0}'", objJxTeachingPlanEN.TeachingPlanId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdTeachingPlan !=  '{0}'", objJxTeachingPlanEN.IdTeachingPlan);
 sbCondition.AppendFormat(" and TeachingPlanDesc = '{0}'", objJxTeachingPlanEN.TeachingPlanDesc);
 sbCondition.AppendFormat(" and TeachingPlanId = '{0}'", objJxTeachingPlanEN.TeachingPlanId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_JxTeachingPlan
{
public virtual bool UpdRelaTabDate(string strIdTeachingPlan, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教学计划(JxTeachingPlan)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsJxTeachingPlanBL
{
public static RelatedActions_JxTeachingPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsJxTeachingPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsJxTeachingPlanDA JxTeachingPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsJxTeachingPlanDA();
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
 public clsJxTeachingPlanBL()
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
if (string.IsNullOrEmpty(clsJxTeachingPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsJxTeachingPlanEN._ConnectString);
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
public static DataTable GetDataTable_JxTeachingPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = JxTeachingPlanDA.GetDataTable_JxTeachingPlan(strWhereCond);
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
objDT = JxTeachingPlanDA.GetDataTable(strWhereCond);
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
objDT = JxTeachingPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = JxTeachingPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = JxTeachingPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = JxTeachingPlanDA.GetDataTable_Top(objTopPara);
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
objDT = JxTeachingPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = JxTeachingPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = JxTeachingPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsJxTeachingPlanEN> GetObjLstByIdTeachingPlanLst(List<string> arrIdTeachingPlanLst)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
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
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachingPlanLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsJxTeachingPlanEN> GetObjLstByIdTeachingPlanLstCache(List<string> arrIdTeachingPlanLst)
{
string strKey = string.Format("{0}", clsJxTeachingPlanEN._CurrTabName);
List<clsJxTeachingPlanEN> arrJxTeachingPlanObjLstCache = GetObjLstCache();
IEnumerable <clsJxTeachingPlanEN> arrJxTeachingPlanObjLst_Sel =
arrJxTeachingPlanObjLstCache
.Where(x => arrIdTeachingPlanLst.Contains(x.IdTeachingPlan));
return arrJxTeachingPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsJxTeachingPlanEN> GetObjLst(string strWhereCond)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
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
public static List<clsJxTeachingPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objJxTeachingPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsJxTeachingPlanEN> GetSubObjLstCache(clsJxTeachingPlanEN objJxTeachingPlanCond)
{
List<clsJxTeachingPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsJxTeachingPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conJxTeachingPlan.AttributeName)
{
if (objJxTeachingPlanCond.IsUpdated(strFldName) == false) continue;
if (objJxTeachingPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJxTeachingPlanCond[strFldName].ToString());
}
else
{
if (objJxTeachingPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objJxTeachingPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJxTeachingPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objJxTeachingPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objJxTeachingPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objJxTeachingPlanCond[strFldName]));
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
public static List<clsJxTeachingPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
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
public static List<clsJxTeachingPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
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
List<clsJxTeachingPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsJxTeachingPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsJxTeachingPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsJxTeachingPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
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
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
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
public static List<clsJxTeachingPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsJxTeachingPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsJxTeachingPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
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
public static List<clsJxTeachingPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsJxTeachingPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJxTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJxTeachingPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetJxTeachingPlan(ref clsJxTeachingPlanEN objJxTeachingPlanEN)
{
bool bolResult = JxTeachingPlanDA.GetJxTeachingPlan(ref objJxTeachingPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsJxTeachingPlanEN GetObjByIdTeachingPlan(string strIdTeachingPlan)
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
clsJxTeachingPlanEN objJxTeachingPlanEN = JxTeachingPlanDA.GetObjByIdTeachingPlan(strIdTeachingPlan);
return objJxTeachingPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsJxTeachingPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsJxTeachingPlanEN objJxTeachingPlanEN = JxTeachingPlanDA.GetFirstObj(strWhereCond);
 return objJxTeachingPlanEN;
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
public static clsJxTeachingPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsJxTeachingPlanEN objJxTeachingPlanEN = JxTeachingPlanDA.GetObjByDataRow(objRow);
 return objJxTeachingPlanEN;
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
public static clsJxTeachingPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsJxTeachingPlanEN objJxTeachingPlanEN = JxTeachingPlanDA.GetObjByDataRow(objRow);
 return objJxTeachingPlanEN;
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
 /// <param name = "lstJxTeachingPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsJxTeachingPlanEN GetObjByIdTeachingPlanFromList(string strIdTeachingPlan, List<clsJxTeachingPlanEN> lstJxTeachingPlanObjLst)
{
foreach (clsJxTeachingPlanEN objJxTeachingPlanEN in lstJxTeachingPlanObjLst)
{
if (objJxTeachingPlanEN.IdTeachingPlan == strIdTeachingPlan)
{
return objJxTeachingPlanEN;
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
 strMaxIdTeachingPlan = clsJxTeachingPlanDA.GetMaxStrId();
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
 strIdTeachingPlan = new clsJxTeachingPlanDA().GetFirstID(strWhereCond);
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
 arrList = JxTeachingPlanDA.GetID(strWhereCond);
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
bool bolIsExist = JxTeachingPlanDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = JxTeachingPlanDA.IsExist(strIdTeachingPlan);
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
 bolIsExist = clsJxTeachingPlanDA.IsExistTable();
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
 bolIsExist = JxTeachingPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objJxTeachingPlanEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学计划名称 = [{0}],教学计划编号 = [{1}]的数据已经存在!(in clsJxTeachingPlanBL.AddNewRecordBySql2)", objJxTeachingPlanEN.TeachingPlanDesc,objJxTeachingPlanEN.TeachingPlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true || clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
     objJxTeachingPlanEN.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
 }
bool bolResult = JxTeachingPlanDA.AddNewRecordBySQL2(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsJxTeachingPlanEN objJxTeachingPlanEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objJxTeachingPlanEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学计划名称 = [{0}],教学计划编号 = [{1}]的数据已经存在!(in clsJxTeachingPlanBL.AddNewRecordBySql2WithReturnKey)", objJxTeachingPlanEN.TeachingPlanDesc,objJxTeachingPlanEN.TeachingPlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true || clsJxTeachingPlanBL.IsExist(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
     objJxTeachingPlanEN.IdTeachingPlan = clsJxTeachingPlanBL.GetMaxStrId_S();
 }
string strKey = JxTeachingPlanDA.AddNewRecordBySQL2WithReturnKey(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
try
{
bool bolResult = JxTeachingPlanDA.Update(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 if (string.IsNullOrEmpty(objJxTeachingPlanEN.IdTeachingPlan) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = JxTeachingPlanDA.UpdateBySql2(objJxTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJxTeachingPlanBL.ReFreshCache();

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
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
 clsJxTeachingPlanEN objJxTeachingPlanEN = clsJxTeachingPlanBL.GetObjByIdTeachingPlan(strIdTeachingPlan);

if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(objJxTeachingPlanEN.IdTeachingPlan, "SetUpdDate");
}
if (objJxTeachingPlanEN != null)
{
int intRecNum = JxTeachingPlanDA.DelRecord(strIdTeachingPlan);
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
objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
//删除与表:[JxTeachingPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conJxTeachingPlan.IdTeachingPlan,
//strIdTeachingPlan);
//        clsJxTeachingPlanBL.DelJxTeachingPlansByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsJxTeachingPlanBL.DelRecord(strIdTeachingPlan, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsJxTeachingPlanBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsJxTeachingPlanBL.relatedActions != null)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(strIdTeachingPlan, "UpdRelaTabDate");
}
bool bolResult = JxTeachingPlanDA.DelRecord(strIdTeachingPlan,objSqlConnection,objSqlTransaction);
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
public static int DelJxTeachingPlans(List<string> arrIdTeachingPlanLst)
{
if (arrIdTeachingPlanLst.Count == 0) return 0;
try
{
if (clsJxTeachingPlanBL.relatedActions != null)
{
foreach (var strIdTeachingPlan in arrIdTeachingPlanLst)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(strIdTeachingPlan, "UpdRelaTabDate");
}
}
int intDelRecNum = JxTeachingPlanDA.DelJxTeachingPlan(arrIdTeachingPlanLst);
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
public static int DelJxTeachingPlansByCond(string strWhereCond)
{
try
{
if (clsJxTeachingPlanBL.relatedActions != null)
{
List<string> arrIdTeachingPlan = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdTeachingPlan in arrIdTeachingPlan)
{
clsJxTeachingPlanBL.relatedActions.UpdRelaTabDate(strIdTeachingPlan, "UpdRelaTabDate");
}
}
int intRecNum = JxTeachingPlanDA.DelJxTeachingPlan(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[JxTeachingPlan]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdTeachingPlan">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdTeachingPlan)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
//删除与表:[JxTeachingPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsJxTeachingPlanBL.DelRecord(strIdTeachingPlan, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsJxTeachingPlanBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objJxTeachingPlanENS">源对象</param>
 /// <param name = "objJxTeachingPlanENT">目标对象</param>
 public static void CopyTo(clsJxTeachingPlanEN objJxTeachingPlanENS, clsJxTeachingPlanEN objJxTeachingPlanENT)
{
try
{
objJxTeachingPlanENT.IdTeachingPlan = objJxTeachingPlanENS.IdTeachingPlan; //教案流水号
objJxTeachingPlanENT.TeachingPlanId = objJxTeachingPlanENS.TeachingPlanId; //教学计划编号
objJxTeachingPlanENT.TeachingPlanDesc = objJxTeachingPlanENS.TeachingPlanDesc; //教学计划名称
objJxTeachingPlanENT.IdGrade = objJxTeachingPlanENS.IdGrade; //年级流水号
objJxTeachingPlanENT.SchoolTerm = objJxTeachingPlanENS.SchoolTerm; //学期
objJxTeachingPlanENT.CourseId = objJxTeachingPlanENS.CourseId; //课程Id
objJxTeachingPlanENT.IsClgCheck = objJxTeachingPlanENS.IsClgCheck; //是否学院审批
objJxTeachingPlanENT.ClgNote = objJxTeachingPlanENS.ClgNote; //学院审批意见
objJxTeachingPlanENT.ClgCheckerId = objJxTeachingPlanENS.ClgCheckerId; //学院审批人id
objJxTeachingPlanENT.ClgCheckDate = objJxTeachingPlanENS.ClgCheckDate; //学院审批日期
objJxTeachingPlanENT.IsSchCheck = objJxTeachingPlanENS.IsSchCheck; //是否学校审批
objJxTeachingPlanENT.SchNote = objJxTeachingPlanENS.SchNote; //学校审批意见
objJxTeachingPlanENT.SchCheckerId = objJxTeachingPlanENS.SchCheckerId; //学校审批人Id
objJxTeachingPlanENT.SchCheckDate = objJxTeachingPlanENS.SchCheckDate; //学校审批日期
objJxTeachingPlanENT.IdSubmitStatus = objJxTeachingPlanENS.IdSubmitStatus; //送审状态流水号
objJxTeachingPlanENT.Memo = objJxTeachingPlanENS.Memo; //备注
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
 /// <param name = "objJxTeachingPlanEN">源简化对象</param>
 public static void SetUpdFlag(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
try
{
objJxTeachingPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objJxTeachingPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conJxTeachingPlan.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.IdTeachingPlan = objJxTeachingPlanEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conJxTeachingPlan.TeachingPlanId, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.TeachingPlanId = objJxTeachingPlanEN.TeachingPlanId; //教学计划编号
}
if (arrFldSet.Contains(conJxTeachingPlan.TeachingPlanDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.TeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc; //教学计划名称
}
if (arrFldSet.Contains(conJxTeachingPlan.IdGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.IdGrade = objJxTeachingPlanEN.IdGrade; //年级流水号
}
if (arrFldSet.Contains(conJxTeachingPlan.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.SchoolTerm = objJxTeachingPlanEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conJxTeachingPlan.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.CourseId = objJxTeachingPlanEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conJxTeachingPlan.IsClgCheck, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.IsClgCheck = objJxTeachingPlanEN.IsClgCheck; //是否学院审批
}
if (arrFldSet.Contains(conJxTeachingPlan.ClgNote, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.ClgNote = objJxTeachingPlanEN.ClgNote == "[null]" ? null :  objJxTeachingPlanEN.ClgNote; //学院审批意见
}
if (arrFldSet.Contains(conJxTeachingPlan.ClgCheckerId, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.ClgCheckerId = objJxTeachingPlanEN.ClgCheckerId == "[null]" ? null :  objJxTeachingPlanEN.ClgCheckerId; //学院审批人id
}
if (arrFldSet.Contains(conJxTeachingPlan.ClgCheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.ClgCheckDate = objJxTeachingPlanEN.ClgCheckDate == "[null]" ? null :  objJxTeachingPlanEN.ClgCheckDate; //学院审批日期
}
if (arrFldSet.Contains(conJxTeachingPlan.IsSchCheck, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.IsSchCheck = objJxTeachingPlanEN.IsSchCheck; //是否学校审批
}
if (arrFldSet.Contains(conJxTeachingPlan.SchNote, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.SchNote = objJxTeachingPlanEN.SchNote == "[null]" ? null :  objJxTeachingPlanEN.SchNote; //学校审批意见
}
if (arrFldSet.Contains(conJxTeachingPlan.SchCheckerId, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.SchCheckerId = objJxTeachingPlanEN.SchCheckerId == "[null]" ? null :  objJxTeachingPlanEN.SchCheckerId; //学校审批人Id
}
if (arrFldSet.Contains(conJxTeachingPlan.SchCheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.SchCheckDate = objJxTeachingPlanEN.SchCheckDate == "[null]" ? null :  objJxTeachingPlanEN.SchCheckDate; //学校审批日期
}
if (arrFldSet.Contains(conJxTeachingPlan.IdSubmitStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.IdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus; //送审状态流水号
}
if (arrFldSet.Contains(conJxTeachingPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objJxTeachingPlanEN.Memo = objJxTeachingPlanEN.Memo == "[null]" ? null :  objJxTeachingPlanEN.Memo; //备注
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
 /// <param name = "objJxTeachingPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
try
{
if (objJxTeachingPlanEN.ClgNote == "[null]") objJxTeachingPlanEN.ClgNote = null; //学院审批意见
if (objJxTeachingPlanEN.ClgCheckerId == "[null]") objJxTeachingPlanEN.ClgCheckerId = null; //学院审批人id
if (objJxTeachingPlanEN.ClgCheckDate == "[null]") objJxTeachingPlanEN.ClgCheckDate = null; //学院审批日期
if (objJxTeachingPlanEN.SchNote == "[null]") objJxTeachingPlanEN.SchNote = null; //学校审批意见
if (objJxTeachingPlanEN.SchCheckerId == "[null]") objJxTeachingPlanEN.SchCheckerId = null; //学校审批人Id
if (objJxTeachingPlanEN.SchCheckDate == "[null]") objJxTeachingPlanEN.SchCheckDate = null; //学校审批日期
if (objJxTeachingPlanEN.Memo == "[null]") objJxTeachingPlanEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 JxTeachingPlanDA.CheckPropertyNew(objJxTeachingPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 JxTeachingPlanDA.CheckProperty4Condition(objJxTeachingPlanEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdTeachingPlanCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[教学计划]...","0");
List<clsJxTeachingPlanEN> arrJxTeachingPlanObjLst = GetAllJxTeachingPlanObjLstCache(); 
objDDL.DataValueField = conJxTeachingPlan.IdTeachingPlan;
objDDL.DataTextField = conJxTeachingPlan.TeachingPlanDesc;
objDDL.DataSource = arrJxTeachingPlanObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsJxTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsJxTeachingPlanBL没有刷新缓存机制(clsJxTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachingPlan");
//if (arrJxTeachingPlanObjLstCache == null)
//{
//arrJxTeachingPlanObjLstCache = JxTeachingPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsJxTeachingPlanEN GetObjByIdTeachingPlanCache(string strIdTeachingPlan)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsJxTeachingPlanEN._CurrTabName);
List<clsJxTeachingPlanEN> arrJxTeachingPlanObjLstCache = GetObjLstCache();
IEnumerable <clsJxTeachingPlanEN> arrJxTeachingPlanObjLst_Sel =
arrJxTeachingPlanObjLstCache
.Where(x=> x.IdTeachingPlan == strIdTeachingPlan 
);
if (arrJxTeachingPlanObjLst_Sel.Count() == 0)
{
   clsJxTeachingPlanEN obj = clsJxTeachingPlanBL.GetObjByIdTeachingPlan(strIdTeachingPlan);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrJxTeachingPlanObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingPlanDescByIdTeachingPlanCache(string strIdTeachingPlan)
{
if (string.IsNullOrEmpty(strIdTeachingPlan) == true) return "";
//获取缓存中的对象列表
clsJxTeachingPlanEN objJxTeachingPlan = GetObjByIdTeachingPlanCache(strIdTeachingPlan);
if (objJxTeachingPlan == null) return "";
return objJxTeachingPlan.TeachingPlanDesc;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdTeachingPlanCache(string strIdTeachingPlan)
{
if (string.IsNullOrEmpty(strIdTeachingPlan) == true) return "";
//获取缓存中的对象列表
clsJxTeachingPlanEN objJxTeachingPlan = GetObjByIdTeachingPlanCache(strIdTeachingPlan);
if (objJxTeachingPlan == null) return "";
return objJxTeachingPlan.TeachingPlanDesc;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsJxTeachingPlanEN> GetAllJxTeachingPlanObjLstCache()
{
//获取缓存中的对象列表
List<clsJxTeachingPlanEN> arrJxTeachingPlanObjLstCache = GetObjLstCache(); 
return arrJxTeachingPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsJxTeachingPlanEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsJxTeachingPlanEN._CurrTabName);
List<clsJxTeachingPlanEN> arrJxTeachingPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrJxTeachingPlanObjLstCache;
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
string strKey = string.Format("{0}", clsJxTeachingPlanEN._CurrTabName);
CacheHelper.Remove(strKey);
clsJxTeachingPlanEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsJxTeachingPlanEN._RefreshTimeLst.Count == 0) return "";
return clsJxTeachingPlanEN._RefreshTimeLst[clsJxTeachingPlanEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsJxTeachingPlanBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsJxTeachingPlanEN._CurrTabName);
CacheHelper.Remove(strKey);
clsJxTeachingPlanEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsJxTeachingPlanBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--JxTeachingPlan(教学计划)
 /// 唯一性条件:TeachingPlanDesc_TeachingPlanId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//检测记录是否存在
string strResult = JxTeachingPlanDA.GetUniCondStr(objJxTeachingPlanEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdTeachingPlan)
{
if (strInFldName != conJxTeachingPlan.IdTeachingPlan)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conJxTeachingPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conJxTeachingPlan.AttributeName));
throw new Exception(strMsg);
}
var objJxTeachingPlan = clsJxTeachingPlanBL.GetObjByIdTeachingPlanCache(strIdTeachingPlan);
if (objJxTeachingPlan == null) return "";
return objJxTeachingPlan[strOutFldName].ToString();
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
int intRecCount = clsJxTeachingPlanDA.GetRecCount(strTabName);
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
int intRecCount = clsJxTeachingPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsJxTeachingPlanDA.GetRecCount();
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
int intRecCount = clsJxTeachingPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objJxTeachingPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsJxTeachingPlanEN objJxTeachingPlanCond)
{
List<clsJxTeachingPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsJxTeachingPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conJxTeachingPlan.AttributeName)
{
if (objJxTeachingPlanCond.IsUpdated(strFldName) == false) continue;
if (objJxTeachingPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJxTeachingPlanCond[strFldName].ToString());
}
else
{
if (objJxTeachingPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objJxTeachingPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJxTeachingPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objJxTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objJxTeachingPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objJxTeachingPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objJxTeachingPlanCond[strFldName]));
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
 List<string> arrList = clsJxTeachingPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = JxTeachingPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = JxTeachingPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = JxTeachingPlanDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsJxTeachingPlanDA.SetFldValue(clsJxTeachingPlanEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = JxTeachingPlanDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsJxTeachingPlanDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsJxTeachingPlanDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsJxTeachingPlanDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[JxTeachingPlan] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) primary key, "); 
 // /**教学计划编号*/ 
 strCreateTabCode.Append(" TeachingPlanId char(12) not Null, "); 
 // /**教学计划名称*/ 
 strCreateTabCode.Append(" TeachingPlanDesc varchar(100) not Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGrade char(4) not Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**是否学院审批*/ 
 strCreateTabCode.Append(" IsClgCheck bit Null, "); 
 // /**学院审批意见*/ 
 strCreateTabCode.Append(" ClgNote text Null, "); 
 // /**学院审批人id*/ 
 strCreateTabCode.Append(" ClgCheckerId varchar(18) Null, "); 
 // /**学院审批日期*/ 
 strCreateTabCode.Append(" ClgCheckDate char(8) Null, "); 
 // /**是否学校审批*/ 
 strCreateTabCode.Append(" IsSchCheck bit Null, "); 
 // /**学校审批意见*/ 
 strCreateTabCode.Append(" SchNote text Null, "); 
 // /**学校审批人Id*/ 
 strCreateTabCode.Append(" SchCheckerId varchar(18) Null, "); 
 // /**学校审批日期*/ 
 strCreateTabCode.Append(" SchCheckDate char(8) Null, "); 
 // /**送审状态流水号*/ 
 strCreateTabCode.Append(" IdSubmitStatus char(2) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeName varchar(50) Null, "); 
 // /**学期名*/ 
 strCreateTabCode.Append(" SchoolTermName char(1) Null, "); 
 // /**送审状态流描述*/ 
 strCreateTabCode.Append(" SubmitStatusDesc varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 教学计划(JxTeachingPlan)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4JxTeachingPlan : clsCommFun4BL
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
clsJxTeachingPlanBL.ReFreshThisCache();
}
}

}