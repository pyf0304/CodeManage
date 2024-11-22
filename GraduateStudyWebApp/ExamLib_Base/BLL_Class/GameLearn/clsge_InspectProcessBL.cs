
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_InspectProcessBL
 表名:ge_InspectProcess(01120910)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsge_InspectProcessBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strInspectId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_InspectProcessEN GetObj(this K_InspectId_ge_InspectProcess myKey)
{
clsge_InspectProcessEN objge_InspectProcessEN = clsge_InspectProcessBL.ge_InspectProcessDA.GetObjByInspectId(myKey.Value);
return objge_InspectProcessEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_InspectProcessEN objge_InspectProcessEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_InspectProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!检查Id = [{0}]的数据已经存在!(in clsge_InspectProcessBL.AddNewRecord)", objge_InspectProcessEN.InspectId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true || clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId) == true)
 {
     objge_InspectProcessEN.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
 }
bool bolResult = clsge_InspectProcessBL.ge_InspectProcessDA.AddNewRecordBySQL2(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_InspectProcessEN objge_InspectProcessEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_InspectProcessEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_InspectProcessEN.CheckUniqueness() == false)
{
strMsg = string.Format("(检查Id(InspectId)=[{0}])已经存在,不能重复!", objge_InspectProcessEN.InspectId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true || clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId) == true)
 {
     objge_InspectProcessEN.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_InspectProcessEN.AddNewRecord();
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_InspectProcessEN objge_InspectProcessEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_InspectProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!检查Id = [{0}]的数据已经存在!(in clsge_InspectProcessBL.AddNewRecordWithMaxId)", objge_InspectProcessEN.InspectId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true || clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId) == true)
 {
     objge_InspectProcessEN.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
 }
string strInspectId = clsge_InspectProcessBL.ge_InspectProcessDA.AddNewRecordBySQL2WithReturnKey(objge_InspectProcessEN);
     objge_InspectProcessEN.InspectId = strInspectId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
}
return strInspectId;
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_InspectProcessEN objge_InspectProcessEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_InspectProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!检查Id = [{0}]的数据已经存在!(in clsge_InspectProcessBL.AddNewRecordWithReturnKey)", objge_InspectProcessEN.InspectId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true || clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId) == true)
 {
     objge_InspectProcessEN.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
 }
string strKey = clsge_InspectProcessBL.ge_InspectProcessDA.AddNewRecordBySQL2WithReturnKey(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetInspectId(this clsge_InspectProcessEN objge_InspectProcessEN, string strInspectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInspectId, 10, conge_InspectProcess.InspectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInspectId, 10, conge_InspectProcess.InspectId);
}
objge_InspectProcessEN.InspectId = strInspectId; //检查Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.InspectId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.InspectId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.InspectId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetOperationTypeId(this clsge_InspectProcessEN objge_InspectProcessEN, string strOperationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeId, conge_InspectProcess.OperationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conge_InspectProcess.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conge_InspectProcess.OperationTypeId);
}
objge_InspectProcessEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.OperationTypeId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.OperationTypeId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.OperationTypeId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetQuestionId(this clsge_InspectProcessEN objge_InspectProcessEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conge_InspectProcess.QuestionId);
objge_InspectProcessEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.QuestionId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.QuestionId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.QuestionId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetCourseId(this clsge_InspectProcessEN objge_InspectProcessEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_InspectProcess.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_InspectProcess.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_InspectProcess.CourseId);
}
objge_InspectProcessEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.CourseId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.CourseId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.CourseId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetControlId(this clsge_InspectProcessEN objge_InspectProcessEN, string strControlId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlId, 50, conge_InspectProcess.ControlId);
}
objge_InspectProcessEN.ControlId = strControlId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.ControlId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.ControlId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.ControlId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetControlTypeId(this clsge_InspectProcessEN objge_InspectProcessEN, string strControlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlTypeId, 4, conge_InspectProcess.ControlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strControlTypeId, 4, conge_InspectProcess.ControlTypeId);
}
objge_InspectProcessEN.ControlTypeId = strControlTypeId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.ControlTypeId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.ControlTypeId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.ControlTypeId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetCheckMemo(this clsge_InspectProcessEN objge_InspectProcessEN, string strCheckMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckMemo, 100, conge_InspectProcess.CheckMemo);
}
objge_InspectProcessEN.CheckMemo = strCheckMemo; //检查描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.CheckMemo) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.CheckMemo, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.CheckMemo] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetControlProp(this clsge_InspectProcessEN objge_InspectProcessEN, string strControlProp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlProp, 50, conge_InspectProcess.ControlProp);
}
objge_InspectProcessEN.ControlProp = strControlProp; //控件属性
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.ControlProp) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.ControlProp, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.ControlProp] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetAttributeId(this clsge_InspectProcessEN objge_InspectProcessEN, string strAttributeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAttributeId, 4, conge_InspectProcess.AttributeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAttributeId, 4, conge_InspectProcess.AttributeId);
}
objge_InspectProcessEN.AttributeId = strAttributeId; //控件属性Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.AttributeId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.AttributeId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.AttributeId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetControlValue(this clsge_InspectProcessEN objge_InspectProcessEN, string strControlValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlValue, 100, conge_InspectProcess.ControlValue);
}
objge_InspectProcessEN.ControlValue = strControlValue; //控件值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.ControlValue) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.ControlValue, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.ControlValue] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetOrderNum(this clsge_InspectProcessEN objge_InspectProcessEN, int? intOrderNum, string strComparisonOp="")
	{
objge_InspectProcessEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.OrderNum) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.OrderNum, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.OrderNum] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetUpdUser(this clsge_InspectProcessEN objge_InspectProcessEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_InspectProcess.UpdUser);
}
objge_InspectProcessEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.UpdUser) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.UpdUser, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.UpdUser] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetUpdDate(this clsge_InspectProcessEN objge_InspectProcessEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_InspectProcess.UpdDate);
}
objge_InspectProcessEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.UpdDate) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.UpdDate, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.UpdDate] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetMemo(this clsge_InspectProcessEN objge_InspectProcessEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_InspectProcess.Memo);
}
objge_InspectProcessEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.Memo) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.Memo, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.Memo] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetControlClass(this clsge_InspectProcessEN objge_InspectProcessEN, string strControlClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlClass, 100, conge_InspectProcess.ControlClass);
}
objge_InspectProcessEN.ControlClass = strControlClass; //控件样式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.ControlClass) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.ControlClass, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.ControlClass] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetEventTypeId(this clsge_InspectProcessEN objge_InspectProcessEN, string strEventTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventTypeId, 4, conge_InspectProcess.EventTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEventTypeId, 4, conge_InspectProcess.EventTypeId);
}
objge_InspectProcessEN.EventTypeId = strEventTypeId; //事件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.EventTypeId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.EventTypeId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.EventTypeId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetExaminationTypeId(this clsge_InspectProcessEN objge_InspectProcessEN, string strExaminationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExaminationTypeId, 4, conge_InspectProcess.ExaminationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExaminationTypeId, 4, conge_InspectProcess.ExaminationTypeId);
}
objge_InspectProcessEN.ExaminationTypeId = strExaminationTypeId; //检查类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.ExaminationTypeId) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.ExaminationTypeId, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.ExaminationTypeId] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_InspectProcessEN SetFunctionName(this clsge_InspectProcessEN objge_InspectProcessEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 100, conge_InspectProcess.FunctionName);
}
objge_InspectProcessEN.FunctionName = strFunctionName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_InspectProcessEN.dicFldComparisonOp.ContainsKey(conge_InspectProcess.FunctionName) == false)
{
objge_InspectProcessEN.dicFldComparisonOp.Add(conge_InspectProcess.FunctionName, strComparisonOp);
}
else
{
objge_InspectProcessEN.dicFldComparisonOp[conge_InspectProcess.FunctionName] = strComparisonOp;
}
}
return objge_InspectProcessEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_InspectProcessEN objge_InspectProcessEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_InspectProcessEN.CheckPropertyNew();
clsge_InspectProcessEN objge_InspectProcessCond = new clsge_InspectProcessEN();
string strCondition = objge_InspectProcessCond
.SetInspectId(objge_InspectProcessEN.InspectId, "<>")
.SetInspectId(objge_InspectProcessEN.InspectId, "=")
.GetCombineCondition();
objge_InspectProcessEN._IsCheckProperty = true;
bool bolIsExist = clsge_InspectProcessBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(InspectId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_InspectProcessEN.Update();
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
 /// <param name = "objge_InspectProcess">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_InspectProcessEN objge_InspectProcess)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_InspectProcessEN objge_InspectProcessCond = new clsge_InspectProcessEN();
string strCondition = objge_InspectProcessCond
.SetInspectId(objge_InspectProcess.InspectId, "=")
.GetCombineCondition();
objge_InspectProcess._IsCheckProperty = true;
bool bolIsExist = clsge_InspectProcessBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_InspectProcess.InspectId = clsge_InspectProcessBL.GetFirstID_S(strCondition);
objge_InspectProcess.UpdateWithCondition(strCondition);
}
else
{
objge_InspectProcess.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
objge_InspectProcess.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_InspectProcessEN objge_InspectProcessEN)
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_InspectProcessBL.ge_InspectProcessDA.UpdateBySql2(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_InspectProcessEN objge_InspectProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_InspectProcessBL.ge_InspectProcessDA.UpdateBySql2(objge_InspectProcessEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_InspectProcessEN objge_InspectProcessEN, string strWhereCond)
{
try
{
bool bolResult = clsge_InspectProcessBL.ge_InspectProcessDA.UpdateBySqlWithCondition(objge_InspectProcessEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_InspectProcessEN objge_InspectProcessEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_InspectProcessBL.ge_InspectProcessDA.UpdateBySqlWithConditionTransaction(objge_InspectProcessEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_InspectProcessEN objge_InspectProcessEN)
{
try
{
int intRecNum = clsge_InspectProcessBL.ge_InspectProcessDA.DelRecord(objge_InspectProcessEN.InspectId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessENS">源对象</param>
 /// <param name = "objge_InspectProcessENT">目标对象</param>
 public static void CopyTo(this clsge_InspectProcessEN objge_InspectProcessENS, clsge_InspectProcessEN objge_InspectProcessENT)
{
try
{
objge_InspectProcessENT.InspectId = objge_InspectProcessENS.InspectId; //检查Id
objge_InspectProcessENT.OperationTypeId = objge_InspectProcessENS.OperationTypeId; //操作类型ID
objge_InspectProcessENT.QuestionId = objge_InspectProcessENS.QuestionId; //题目Id
objge_InspectProcessENT.CourseId = objge_InspectProcessENS.CourseId; //课程Id
objge_InspectProcessENT.ControlId = objge_InspectProcessENS.ControlId; //控件Id
objge_InspectProcessENT.ControlTypeId = objge_InspectProcessENS.ControlTypeId; //控件Id
objge_InspectProcessENT.CheckMemo = objge_InspectProcessENS.CheckMemo; //检查描述
objge_InspectProcessENT.ControlProp = objge_InspectProcessENS.ControlProp; //控件属性
objge_InspectProcessENT.AttributeId = objge_InspectProcessENS.AttributeId; //控件属性Id
objge_InspectProcessENT.ControlValue = objge_InspectProcessENS.ControlValue; //控件值
objge_InspectProcessENT.OrderNum = objge_InspectProcessENS.OrderNum; //序号
objge_InspectProcessENT.UpdUser = objge_InspectProcessENS.UpdUser; //修改人
objge_InspectProcessENT.UpdDate = objge_InspectProcessENS.UpdDate; //修改日期
objge_InspectProcessENT.Memo = objge_InspectProcessENS.Memo; //备注
objge_InspectProcessENT.ControlClass = objge_InspectProcessENS.ControlClass; //控件样式
objge_InspectProcessENT.EventTypeId = objge_InspectProcessENS.EventTypeId; //事件Id
objge_InspectProcessENT.ExaminationTypeId = objge_InspectProcessENS.ExaminationTypeId; //检查类型Id
objge_InspectProcessENT.FunctionName = objge_InspectProcessENS.FunctionName; //函数名
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
 /// <param name = "objge_InspectProcessENS">源对象</param>
 /// <returns>目标对象=>clsge_InspectProcessEN:objge_InspectProcessENT</returns>
 public static clsge_InspectProcessEN CopyTo(this clsge_InspectProcessEN objge_InspectProcessENS)
{
try
{
 clsge_InspectProcessEN objge_InspectProcessENT = new clsge_InspectProcessEN()
{
InspectId = objge_InspectProcessENS.InspectId, //检查Id
OperationTypeId = objge_InspectProcessENS.OperationTypeId, //操作类型ID
QuestionId = objge_InspectProcessENS.QuestionId, //题目Id
CourseId = objge_InspectProcessENS.CourseId, //课程Id
ControlId = objge_InspectProcessENS.ControlId, //控件Id
ControlTypeId = objge_InspectProcessENS.ControlTypeId, //控件Id
CheckMemo = objge_InspectProcessENS.CheckMemo, //检查描述
ControlProp = objge_InspectProcessENS.ControlProp, //控件属性
AttributeId = objge_InspectProcessENS.AttributeId, //控件属性Id
ControlValue = objge_InspectProcessENS.ControlValue, //控件值
OrderNum = objge_InspectProcessENS.OrderNum, //序号
UpdUser = objge_InspectProcessENS.UpdUser, //修改人
UpdDate = objge_InspectProcessENS.UpdDate, //修改日期
Memo = objge_InspectProcessENS.Memo, //备注
ControlClass = objge_InspectProcessENS.ControlClass, //控件样式
EventTypeId = objge_InspectProcessENS.EventTypeId, //事件Id
ExaminationTypeId = objge_InspectProcessENS.ExaminationTypeId, //检查类型Id
FunctionName = objge_InspectProcessENS.FunctionName, //函数名
};
 return objge_InspectProcessENT;
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
public static void CheckPropertyNew(this clsge_InspectProcessEN objge_InspectProcessEN)
{
 clsge_InspectProcessBL.ge_InspectProcessDA.CheckPropertyNew(objge_InspectProcessEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_InspectProcessEN objge_InspectProcessEN)
{
 clsge_InspectProcessBL.ge_InspectProcessDA.CheckProperty4Condition(objge_InspectProcessEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_InspectProcessEN objge_InspectProcessCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.InspectId) == true)
{
string strComparisonOpInspectId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.InspectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.InspectId, objge_InspectProcessCond.InspectId, strComparisonOpInspectId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.OperationTypeId, objge_InspectProcessCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.QuestionId) == true)
{
string strComparisonOpQuestionId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_InspectProcess.QuestionId, objge_InspectProcessCond.QuestionId, strComparisonOpQuestionId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.CourseId) == true)
{
string strComparisonOpCourseId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.CourseId, objge_InspectProcessCond.CourseId, strComparisonOpCourseId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.ControlId) == true)
{
string strComparisonOpControlId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.ControlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.ControlId, objge_InspectProcessCond.ControlId, strComparisonOpControlId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.ControlTypeId) == true)
{
string strComparisonOpControlTypeId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.ControlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.ControlTypeId, objge_InspectProcessCond.ControlTypeId, strComparisonOpControlTypeId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.CheckMemo) == true)
{
string strComparisonOpCheckMemo = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.CheckMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.CheckMemo, objge_InspectProcessCond.CheckMemo, strComparisonOpCheckMemo);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.ControlProp) == true)
{
string strComparisonOpControlProp = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.ControlProp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.ControlProp, objge_InspectProcessCond.ControlProp, strComparisonOpControlProp);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.AttributeId) == true)
{
string strComparisonOpAttributeId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.AttributeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.AttributeId, objge_InspectProcessCond.AttributeId, strComparisonOpAttributeId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.ControlValue) == true)
{
string strComparisonOpControlValue = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.ControlValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.ControlValue, objge_InspectProcessCond.ControlValue, strComparisonOpControlValue);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.OrderNum) == true)
{
string strComparisonOpOrderNum = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_InspectProcess.OrderNum, objge_InspectProcessCond.OrderNum, strComparisonOpOrderNum);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.UpdUser, objge_InspectProcessCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.UpdDate, objge_InspectProcessCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.Memo) == true)
{
string strComparisonOpMemo = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.Memo, objge_InspectProcessCond.Memo, strComparisonOpMemo);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.ControlClass) == true)
{
string strComparisonOpControlClass = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.ControlClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.ControlClass, objge_InspectProcessCond.ControlClass, strComparisonOpControlClass);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.EventTypeId) == true)
{
string strComparisonOpEventTypeId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.EventTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.EventTypeId, objge_InspectProcessCond.EventTypeId, strComparisonOpEventTypeId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.ExaminationTypeId) == true)
{
string strComparisonOpExaminationTypeId = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.ExaminationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.ExaminationTypeId, objge_InspectProcessCond.ExaminationTypeId, strComparisonOpExaminationTypeId);
}
if (objge_InspectProcessCond.IsUpdated(conge_InspectProcess.FunctionName) == true)
{
string strComparisonOpFunctionName = objge_InspectProcessCond.dicFldComparisonOp[conge_InspectProcess.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_InspectProcess.FunctionName, objge_InspectProcessCond.FunctionName, strComparisonOpFunctionName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_InspectProcess(检查过程表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:InspectId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_InspectProcessEN objge_InspectProcessEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_InspectProcessEN == null) return true;
if (objge_InspectProcessEN.InspectId == null || objge_InspectProcessEN.InspectId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InspectId = '{0}'", objge_InspectProcessEN.InspectId);
if (clsge_InspectProcessBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("InspectId !=  '{0}'", objge_InspectProcessEN.InspectId);
 sbCondition.AppendFormat(" and InspectId = '{0}'", objge_InspectProcessEN.InspectId);
if (clsge_InspectProcessBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_InspectProcess(检查过程表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:InspectId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_InspectProcessEN objge_InspectProcessEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_InspectProcessEN == null) return "";
if (objge_InspectProcessEN.InspectId == null || objge_InspectProcessEN.InspectId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InspectId = '{0}'", objge_InspectProcessEN.InspectId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("InspectId !=  '{0}'", objge_InspectProcessEN.InspectId);
 sbCondition.AppendFormat(" and InspectId = '{0}'", objge_InspectProcessEN.InspectId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_InspectProcess
{
public virtual bool UpdRelaTabDate(string strInspectId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 检查过程表(ge_InspectProcess)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_InspectProcessBL
{
public static RelatedActions_ge_InspectProcess relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_InspectProcessDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_InspectProcessDA ge_InspectProcessDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_InspectProcessDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsge_InspectProcessBL()
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
if (string.IsNullOrEmpty(clsge_InspectProcessEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_InspectProcessEN._ConnectString);
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
public static DataTable GetDataTable_ge_InspectProcess(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_InspectProcessDA.GetDataTable_ge_InspectProcess(strWhereCond);
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
objDT = ge_InspectProcessDA.GetDataTable(strWhereCond);
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
objDT = ge_InspectProcessDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_InspectProcessDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_InspectProcessDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_InspectProcessDA.GetDataTable_Top(objTopPara);
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
objDT = ge_InspectProcessDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_InspectProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_InspectProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrInspectIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_InspectProcessEN> GetObjLstByInspectIdLst(List<string> arrInspectIdLst)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrInspectIdLst, true);
 string strWhereCond = string.Format("InspectId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrInspectIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_InspectProcessEN> GetObjLstByInspectIdLstCache(List<string> arrInspectIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_InspectProcessEN._CurrTabName, strCourseId);
List<clsge_InspectProcessEN> arrge_InspectProcessObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_InspectProcessEN> arrge_InspectProcessObjLst_Sel =
arrge_InspectProcessObjLstCache
.Where(x => arrInspectIdLst.Contains(x.InspectId));
return arrge_InspectProcessObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_InspectProcessEN> GetObjLst(string strWhereCond)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
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
public static List<clsge_InspectProcessEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_InspectProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_InspectProcessEN> GetSubObjLstCache(clsge_InspectProcessEN objge_InspectProcessCond)
{
 string strCourseId = objge_InspectProcessCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_InspectProcessBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_InspectProcessEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_InspectProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_InspectProcess.AttributeName)
{
if (objge_InspectProcessCond.IsUpdated(strFldName) == false) continue;
if (objge_InspectProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_InspectProcessCond[strFldName].ToString());
}
else
{
if (objge_InspectProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_InspectProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_InspectProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_InspectProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_InspectProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_InspectProcessCond[strFldName]));
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
public static List<clsge_InspectProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
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
public static List<clsge_InspectProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
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
List<clsge_InspectProcessEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_InspectProcessEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_InspectProcessEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_InspectProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
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
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
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
public static List<clsge_InspectProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_InspectProcessEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_InspectProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
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
public static List<clsge_InspectProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_InspectProcessEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_InspectProcessEN.InspectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_InspectProcessEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_InspectProcess(ref clsge_InspectProcessEN objge_InspectProcessEN)
{
bool bolResult = ge_InspectProcessDA.Getge_InspectProcess(ref objge_InspectProcessEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strInspectId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_InspectProcessEN GetObjByInspectId(string strInspectId)
{
if (strInspectId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strInspectId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strInspectId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strInspectId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_InspectProcessEN objge_InspectProcessEN = ge_InspectProcessDA.GetObjByInspectId(strInspectId);
return objge_InspectProcessEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_InspectProcessEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_InspectProcessEN objge_InspectProcessEN = ge_InspectProcessDA.GetFirstObj(strWhereCond);
 return objge_InspectProcessEN;
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
public static clsge_InspectProcessEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_InspectProcessEN objge_InspectProcessEN = ge_InspectProcessDA.GetObjByDataRow(objRow);
 return objge_InspectProcessEN;
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
public static clsge_InspectProcessEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_InspectProcessEN objge_InspectProcessEN = ge_InspectProcessDA.GetObjByDataRow(objRow);
 return objge_InspectProcessEN;
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
 /// <param name = "strInspectId">所给的关键字</param>
 /// <param name = "lstge_InspectProcessObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_InspectProcessEN GetObjByInspectIdFromList(string strInspectId, List<clsge_InspectProcessEN> lstge_InspectProcessObjLst)
{
foreach (clsge_InspectProcessEN objge_InspectProcessEN in lstge_InspectProcessObjLst)
{
if (objge_InspectProcessEN.InspectId == strInspectId)
{
return objge_InspectProcessEN;
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
 string strMaxInspectId;
 try
 {
 strMaxInspectId = clsge_InspectProcessDA.GetMaxStrId();
 return strMaxInspectId;
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
 string strInspectId;
 try
 {
 strInspectId = new clsge_InspectProcessDA().GetFirstID(strWhereCond);
 return strInspectId;
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
 arrList = ge_InspectProcessDA.GetID(strWhereCond);
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
bool bolIsExist = ge_InspectProcessDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strInspectId)
{
if (string.IsNullOrEmpty(strInspectId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strInspectId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_InspectProcessDA.IsExist(strInspectId);
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
 bolIsExist = clsge_InspectProcessDA.IsExistTable();
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
 bolIsExist = ge_InspectProcessDA.IsExistTable(strTabName);
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_InspectProcessEN objge_InspectProcessEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_InspectProcessEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!检查Id = [{0}]的数据已经存在!(in clsge_InspectProcessBL.AddNewRecordBySql2)", objge_InspectProcessEN.InspectId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true || clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId) == true)
 {
     objge_InspectProcessEN.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
 }
bool bolResult = ge_InspectProcessDA.AddNewRecordBySQL2(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_InspectProcessEN objge_InspectProcessEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_InspectProcessEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!检查Id = [{0}]的数据已经存在!(in clsge_InspectProcessBL.AddNewRecordBySql2WithReturnKey)", objge_InspectProcessEN.InspectId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true || clsge_InspectProcessBL.IsExist(objge_InspectProcessEN.InspectId) == true)
 {
     objge_InspectProcessEN.InspectId = clsge_InspectProcessBL.GetMaxStrId_S();
 }
string strKey = ge_InspectProcessDA.AddNewRecordBySQL2WithReturnKey(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_InspectProcessEN objge_InspectProcessEN)
{
try
{
bool bolResult = ge_InspectProcessDA.Update(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_InspectProcessEN objge_InspectProcessEN)
{
 if (string.IsNullOrEmpty(objge_InspectProcessEN.InspectId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_InspectProcessDA.UpdateBySql2(objge_InspectProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_InspectProcessBL.ReFreshCache(objge_InspectProcessEN.CourseId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
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
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strInspectId)
{
try
{
 clsge_InspectProcessEN objge_InspectProcessEN = clsge_InspectProcessBL.GetObjByInspectId(strInspectId);

if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(objge_InspectProcessEN.InspectId, "SetUpdDate");
}
if (objge_InspectProcessEN != null)
{
int intRecNum = ge_InspectProcessDA.DelRecord(strInspectId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_InspectProcessEN.CourseId);
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
/// <param name="strInspectId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strInspectId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
//删除与表:[ge_InspectProcess]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_InspectProcess.InspectId,
//strInspectId);
//        clsge_InspectProcessBL.Delge_InspectProcesssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_InspectProcessBL.DelRecord(strInspectId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_InspectProcessBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strInspectId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strInspectId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_InspectProcessBL.relatedActions != null)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(strInspectId, "UpdRelaTabDate");
}
bool bolResult = ge_InspectProcessDA.DelRecord(strInspectId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrInspectIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_InspectProcesss(List<string> arrInspectIdLst)
{
if (arrInspectIdLst.Count == 0) return 0;
try
{
if (clsge_InspectProcessBL.relatedActions != null)
{
foreach (var strInspectId in arrInspectIdLst)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(strInspectId, "UpdRelaTabDate");
}
}
 clsge_InspectProcessEN objge_InspectProcessEN = clsge_InspectProcessBL.GetObjByInspectId(arrInspectIdLst[0]);
int intDelRecNum = ge_InspectProcessDA.Delge_InspectProcess(arrInspectIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_InspectProcessEN.CourseId);
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
public static int Delge_InspectProcesssByCond(string strWhereCond)
{
try
{
if (clsge_InspectProcessBL.relatedActions != null)
{
List<string> arrInspectId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strInspectId in arrInspectId)
{
clsge_InspectProcessBL.relatedActions.UpdRelaTabDate(strInspectId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_InspectProcess.CourseId, strWhereCond);
int intRecNum = ge_InspectProcessDA.Delge_InspectProcess(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_InspectProcess]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strInspectId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strInspectId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
//删除与表:[ge_InspectProcess]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_InspectProcessBL.DelRecord(strInspectId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_InspectProcessBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strInspectId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_InspectProcessENS">源对象</param>
 /// <param name = "objge_InspectProcessENT">目标对象</param>
 public static void CopyTo(clsge_InspectProcessEN objge_InspectProcessENS, clsge_InspectProcessEN objge_InspectProcessENT)
{
try
{
objge_InspectProcessENT.InspectId = objge_InspectProcessENS.InspectId; //检查Id
objge_InspectProcessENT.OperationTypeId = objge_InspectProcessENS.OperationTypeId; //操作类型ID
objge_InspectProcessENT.QuestionId = objge_InspectProcessENS.QuestionId; //题目Id
objge_InspectProcessENT.CourseId = objge_InspectProcessENS.CourseId; //课程Id
objge_InspectProcessENT.ControlId = objge_InspectProcessENS.ControlId; //控件Id
objge_InspectProcessENT.ControlTypeId = objge_InspectProcessENS.ControlTypeId; //控件Id
objge_InspectProcessENT.CheckMemo = objge_InspectProcessENS.CheckMemo; //检查描述
objge_InspectProcessENT.ControlProp = objge_InspectProcessENS.ControlProp; //控件属性
objge_InspectProcessENT.AttributeId = objge_InspectProcessENS.AttributeId; //控件属性Id
objge_InspectProcessENT.ControlValue = objge_InspectProcessENS.ControlValue; //控件值
objge_InspectProcessENT.OrderNum = objge_InspectProcessENS.OrderNum; //序号
objge_InspectProcessENT.UpdUser = objge_InspectProcessENS.UpdUser; //修改人
objge_InspectProcessENT.UpdDate = objge_InspectProcessENS.UpdDate; //修改日期
objge_InspectProcessENT.Memo = objge_InspectProcessENS.Memo; //备注
objge_InspectProcessENT.ControlClass = objge_InspectProcessENS.ControlClass; //控件样式
objge_InspectProcessENT.EventTypeId = objge_InspectProcessENS.EventTypeId; //事件Id
objge_InspectProcessENT.ExaminationTypeId = objge_InspectProcessENS.ExaminationTypeId; //检查类型Id
objge_InspectProcessENT.FunctionName = objge_InspectProcessENS.FunctionName; //函数名
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
 /// <param name = "objge_InspectProcessEN">源简化对象</param>
 public static void SetUpdFlag(clsge_InspectProcessEN objge_InspectProcessEN)
{
try
{
objge_InspectProcessEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_InspectProcessEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_InspectProcess.InspectId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.InspectId = objge_InspectProcessEN.InspectId; //检查Id
}
if (arrFldSet.Contains(conge_InspectProcess.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.OperationTypeId = objge_InspectProcessEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conge_InspectProcess.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.QuestionId = objge_InspectProcessEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conge_InspectProcess.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.CourseId = objge_InspectProcessEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_InspectProcess.ControlId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.ControlId = objge_InspectProcessEN.ControlId == "[null]" ? null :  objge_InspectProcessEN.ControlId; //控件Id
}
if (arrFldSet.Contains(conge_InspectProcess.ControlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.ControlTypeId = objge_InspectProcessEN.ControlTypeId == "[null]" ? null :  objge_InspectProcessEN.ControlTypeId; //控件Id
}
if (arrFldSet.Contains(conge_InspectProcess.CheckMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.CheckMemo = objge_InspectProcessEN.CheckMemo == "[null]" ? null :  objge_InspectProcessEN.CheckMemo; //检查描述
}
if (arrFldSet.Contains(conge_InspectProcess.ControlProp, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.ControlProp = objge_InspectProcessEN.ControlProp == "[null]" ? null :  objge_InspectProcessEN.ControlProp; //控件属性
}
if (arrFldSet.Contains(conge_InspectProcess.AttributeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.AttributeId = objge_InspectProcessEN.AttributeId == "[null]" ? null :  objge_InspectProcessEN.AttributeId; //控件属性Id
}
if (arrFldSet.Contains(conge_InspectProcess.ControlValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.ControlValue = objge_InspectProcessEN.ControlValue == "[null]" ? null :  objge_InspectProcessEN.ControlValue; //控件值
}
if (arrFldSet.Contains(conge_InspectProcess.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.OrderNum = objge_InspectProcessEN.OrderNum; //序号
}
if (arrFldSet.Contains(conge_InspectProcess.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.UpdUser = objge_InspectProcessEN.UpdUser == "[null]" ? null :  objge_InspectProcessEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_InspectProcess.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.UpdDate = objge_InspectProcessEN.UpdDate == "[null]" ? null :  objge_InspectProcessEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_InspectProcess.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.Memo = objge_InspectProcessEN.Memo == "[null]" ? null :  objge_InspectProcessEN.Memo; //备注
}
if (arrFldSet.Contains(conge_InspectProcess.ControlClass, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.ControlClass = objge_InspectProcessEN.ControlClass == "[null]" ? null :  objge_InspectProcessEN.ControlClass; //控件样式
}
if (arrFldSet.Contains(conge_InspectProcess.EventTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.EventTypeId = objge_InspectProcessEN.EventTypeId == "[null]" ? null :  objge_InspectProcessEN.EventTypeId; //事件Id
}
if (arrFldSet.Contains(conge_InspectProcess.ExaminationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.ExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId == "[null]" ? null :  objge_InspectProcessEN.ExaminationTypeId; //检查类型Id
}
if (arrFldSet.Contains(conge_InspectProcess.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_InspectProcessEN.FunctionName = objge_InspectProcessEN.FunctionName == "[null]" ? null :  objge_InspectProcessEN.FunctionName; //函数名
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
 /// <param name = "objge_InspectProcessEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_InspectProcessEN objge_InspectProcessEN)
{
try
{
if (objge_InspectProcessEN.ControlId == "[null]") objge_InspectProcessEN.ControlId = null; //控件Id
if (objge_InspectProcessEN.ControlTypeId == "[null]") objge_InspectProcessEN.ControlTypeId = null; //控件Id
if (objge_InspectProcessEN.CheckMemo == "[null]") objge_InspectProcessEN.CheckMemo = null; //检查描述
if (objge_InspectProcessEN.ControlProp == "[null]") objge_InspectProcessEN.ControlProp = null; //控件属性
if (objge_InspectProcessEN.AttributeId == "[null]") objge_InspectProcessEN.AttributeId = null; //控件属性Id
if (objge_InspectProcessEN.ControlValue == "[null]") objge_InspectProcessEN.ControlValue = null; //控件值
if (objge_InspectProcessEN.UpdUser == "[null]") objge_InspectProcessEN.UpdUser = null; //修改人
if (objge_InspectProcessEN.UpdDate == "[null]") objge_InspectProcessEN.UpdDate = null; //修改日期
if (objge_InspectProcessEN.Memo == "[null]") objge_InspectProcessEN.Memo = null; //备注
if (objge_InspectProcessEN.ControlClass == "[null]") objge_InspectProcessEN.ControlClass = null; //控件样式
if (objge_InspectProcessEN.EventTypeId == "[null]") objge_InspectProcessEN.EventTypeId = null; //事件Id
if (objge_InspectProcessEN.ExaminationTypeId == "[null]") objge_InspectProcessEN.ExaminationTypeId = null; //检查类型Id
if (objge_InspectProcessEN.FunctionName == "[null]") objge_InspectProcessEN.FunctionName = null; //函数名
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
public static void CheckPropertyNew(clsge_InspectProcessEN objge_InspectProcessEN)
{
 ge_InspectProcessDA.CheckPropertyNew(objge_InspectProcessEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_InspectProcessEN objge_InspectProcessEN)
{
 ge_InspectProcessDA.CheckProperty4Condition(objge_InspectProcessEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_InspectId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conge_InspectProcess.InspectId); 
List<clsge_InspectProcessEN> arrObjLst = clsge_InspectProcessBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN()
{
InspectId = "0",
OperationTypeId = "选[检查过程表]..."
};
arrObjLstSel.Insert(0, objge_InspectProcessEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conge_InspectProcess.InspectId;
objComboBox.DisplayMember = conge_InspectProcess.OperationTypeId;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_InspectId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[检查过程表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conge_InspectProcess.InspectId); 
IEnumerable<clsge_InspectProcessEN> arrObjLst = clsge_InspectProcessBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conge_InspectProcess.InspectId;
objDDL.DataTextField = conge_InspectProcess.OperationTypeId;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_InspectIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[检查过程表]...","0");
List<clsge_InspectProcessEN> arrge_InspectProcessObjLst = GetAllge_InspectProcessObjLstCache(strCourseId); 
arrge_InspectProcessObjLst = arrge_InspectProcessObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conge_InspectProcess.InspectId;
objDDL.DataTextField = conge_InspectProcess.OperationTypeId;
objDDL.DataSource = arrge_InspectProcessObjLst;
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
if (clsge_InspectProcessBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_InspectProcessBL没有刷新缓存机制(clsge_InspectProcessBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by InspectId");
//if (arrge_InspectProcessObjLstCache == null)
//{
//arrge_InspectProcessObjLstCache = ge_InspectProcessDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strInspectId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_InspectProcessEN GetObjByInspectIdCache(string strInspectId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsge_InspectProcessEN._CurrTabName, strCourseId);
List<clsge_InspectProcessEN> arrge_InspectProcessObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_InspectProcessEN> arrge_InspectProcessObjLst_Sel =
arrge_InspectProcessObjLstCache
.Where(x=> x.InspectId == strInspectId 
);
if (arrge_InspectProcessObjLst_Sel.Count() == 0)
{
   clsge_InspectProcessEN obj = clsge_InspectProcessBL.GetObjByInspectId(strInspectId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strInspectId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_InspectProcessObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strInspectId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOperationTypeIdByInspectIdCache(string strInspectId, string strCourseId)
{
if (string.IsNullOrEmpty(strInspectId) == true) return "";
//获取缓存中的对象列表
clsge_InspectProcessEN objge_InspectProcess = GetObjByInspectIdCache(strInspectId, strCourseId);
if (objge_InspectProcess == null) return "";
return objge_InspectProcess.OperationTypeId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strInspectId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByInspectIdCache(string strInspectId, string strCourseId)
{
if (string.IsNullOrEmpty(strInspectId) == true) return "";
//获取缓存中的对象列表
clsge_InspectProcessEN objge_InspectProcess = GetObjByInspectIdCache(strInspectId, strCourseId);
if (objge_InspectProcess == null) return "";
return objge_InspectProcess.OperationTypeId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_InspectProcessEN> GetAllge_InspectProcessObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_InspectProcessEN> arrge_InspectProcessObjLstCache = GetObjLstCache(strCourseId); 
return arrge_InspectProcessObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_InspectProcessEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsge_InspectProcessEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_InspectProcessEN> arrge_InspectProcessObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_InspectProcessObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsge_InspectProcessEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_InspectProcessEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_InspectProcessEN._RefreshTimeLst.Count == 0) return "";
return clsge_InspectProcessEN._RefreshTimeLst[clsge_InspectProcessEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsge_InspectProcessBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_InspectProcessEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_InspectProcessEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_InspectProcessBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_InspectProcess(检查过程表)
 /// 唯一性条件:InspectId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_InspectProcessEN objge_InspectProcessEN)
{
//检测记录是否存在
string strResult = ge_InspectProcessDA.GetUniCondStr(objge_InspectProcessEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strInspectId, string strCourseId)
{
if (strInFldName != conge_InspectProcess.InspectId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_InspectProcess.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_InspectProcess.AttributeName));
throw new Exception(strMsg);
}
var objge_InspectProcess = clsge_InspectProcessBL.GetObjByInspectIdCache(strInspectId, strCourseId);
if (objge_InspectProcess == null) return "";
return objge_InspectProcess[strOutFldName].ToString();
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
int intRecCount = clsge_InspectProcessDA.GetRecCount(strTabName);
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
int intRecCount = clsge_InspectProcessDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_InspectProcessDA.GetRecCount();
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
int intRecCount = clsge_InspectProcessDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_InspectProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_InspectProcessEN objge_InspectProcessCond)
{
 string strCourseId = objge_InspectProcessCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_InspectProcessBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_InspectProcessEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_InspectProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_InspectProcess.AttributeName)
{
if (objge_InspectProcessCond.IsUpdated(strFldName) == false) continue;
if (objge_InspectProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_InspectProcessCond[strFldName].ToString());
}
else
{
if (objge_InspectProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_InspectProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_InspectProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_InspectProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_InspectProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_InspectProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_InspectProcessCond[strFldName]));
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
 List<string> arrList = clsge_InspectProcessDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_InspectProcessDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_InspectProcessDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_InspectProcessDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_InspectProcessDA.SetFldValue(clsge_InspectProcessEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_InspectProcessDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_InspectProcessDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_InspectProcessDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_InspectProcessDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_InspectProcess] "); 
 strCreateTabCode.Append(" ( "); 
 // /**检查Id*/ 
 strCreateTabCode.Append(" InspectId char(10) primary key, "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" OperationTypeId char(4) not Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" ControlId varchar(50) Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" ControlTypeId char(4) Null, "); 
 // /**检查描述*/ 
 strCreateTabCode.Append(" CheckMemo varchar(100) Null, "); 
 // /**控件属性*/ 
 strCreateTabCode.Append(" ControlProp varchar(50) Null, "); 
 // /**控件属性Id*/ 
 strCreateTabCode.Append(" AttributeId char(4) Null, "); 
 // /**控件值*/ 
 strCreateTabCode.Append(" ControlValue varchar(100) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**控件样式*/ 
 strCreateTabCode.Append(" ControlClass varchar(100) Null, "); 
 // /**事件Id*/ 
 strCreateTabCode.Append(" EventTypeId char(4) Null, "); 
 // /**检查类型Id*/ 
 strCreateTabCode.Append(" ExaminationTypeId char(4) Null, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FunctionName varchar(100) Null, "); 
 // /**事件名称*/ 
 strCreateTabCode.Append(" EventTypeName varchar(100) Null, "); 
 // /**控件名称*/ 
 strCreateTabCode.Append(" ControlTypeName varchar(100) Null, "); 
 // /**操作类型名*/ 
 strCreateTabCode.Append(" OperationTypeName varchar(50) Null, "); 
 // /**属性名称*/ 
 strCreateTabCode.Append(" ControlAttributeName varchar(100) Null, "); 
 // /**属性名称*/ 
 strCreateTabCode.Append(" TypeDescribe varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="lngQuestionId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(long lngQuestionId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_InspectProcess.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OrderNum ");
List<clsge_InspectProcessEN> arrge_InspectProcessObjList = new clsge_InspectProcessDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_InspectProcessEN objge_InspectProcess in arrge_InspectProcessObjList)
{
objge_InspectProcess.OrderNum = intIndex;
UpdateBySql2(objge_InspectProcess);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strInspectId">所给的关键字</param>
/// <param name="lngQuestionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strInspectId ,long lngQuestionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[InspectId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字InspectId
//5、把当前关键字InspectId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字InspectId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevInspectId = "";    //上一条序号的关键字InspectId
string strNextInspectId = "";    //下一条序号的关键字InspectId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[InspectId],获取相应的序号[OrderNum]。

clsge_InspectProcessEN objge_InspectProcess = clsge_InspectProcessBL.GetObjByInspectId(strInspectId);

intOrderNum = objge_InspectProcess.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_InspectProcess.QuestionId, lngQuestionId);
intTabRecNum = clsge_InspectProcessBL.GetRecCountByCond(clsge_InspectProcessEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conge_InspectProcess.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conge_InspectProcess.QuestionId, lngQuestionId);
//4、获取上一个序号字段的关键字InspectId
strPrevInspectId = clsge_InspectProcessBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevInspectId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字InspectId所对应记录的序号减1
//6、把下(上)一个序号关键字InspectId所对应的记录序号加1
clsge_InspectProcessBL.SetFldValue(clsge_InspectProcessEN._CurrTabName, conge_InspectProcess.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conge_InspectProcess.InspectId, strInspectId));
clsge_InspectProcessBL.SetFldValue(clsge_InspectProcessEN._CurrTabName, conge_InspectProcess.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conge_InspectProcess.InspectId, strPrevInspectId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字InspectId
sbCondition.AppendFormat(" {0} = {1} ", conge_InspectProcess.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conge_InspectProcess.QuestionId, lngQuestionId);

strNextInspectId = clsge_InspectProcessBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextInspectId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字InspectId所对应记录的序号加1
//6、把下(上)一个序号关键字InspectId所对应的记录序号减1
clsge_InspectProcessBL.SetFldValue(clsge_InspectProcessEN._CurrTabName, conge_InspectProcess.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conge_InspectProcess.InspectId, strInspectId));
clsge_InspectProcessBL.SetFldValue(clsge_InspectProcessEN._CurrTabName, conge_InspectProcess.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conge_InspectProcess.InspectId, strNextInspectId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,long lngQuestionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conge_InspectProcess.InspectId, strKeyList);
List<clsge_InspectProcessEN> arrge_InspectProcessLst = GetObjLst(strCondition);
foreach (clsge_InspectProcessEN objge_InspectProcess in arrge_InspectProcessLst)
{
objge_InspectProcess.OrderNum = objge_InspectProcess.OrderNum + 10000;
UpdateBySql2(objge_InspectProcess);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_InspectProcess.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OrderNum ");
List<clsge_InspectProcessEN> arrge_InspectProcessObjList = new clsge_InspectProcessDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_InspectProcessEN objge_InspectProcess in arrge_InspectProcessObjList)
{
objge_InspectProcess.OrderNum = intIndex;
UpdateBySql2(objge_InspectProcess);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="lngQuestionId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,long lngQuestionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conge_InspectProcess.InspectId, strKeyList);
List<clsge_InspectProcessEN> arrge_InspectProcessLst = GetObjLst(strCondition);
foreach (clsge_InspectProcessEN objge_InspectProcess in arrge_InspectProcessLst)
{
objge_InspectProcess.OrderNum = objge_InspectProcess.OrderNum - 10000;
UpdateBySql2(objge_InspectProcess);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_InspectProcess.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OrderNum ");
List<clsge_InspectProcessEN> arrge_InspectProcessObjList = new clsge_InspectProcessDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_InspectProcessEN objge_InspectProcess in arrge_InspectProcessObjList)
{
objge_InspectProcess.OrderNum = intIndex;
UpdateBySql2(objge_InspectProcess);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 检查过程表(ge_InspectProcess)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_InspectProcess : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsge_InspectProcessBL.ReFreshThisCache(strCourseId);
}
}

}