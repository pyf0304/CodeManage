
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ExaminationCriteriaBL
 表名:ge_ExaminationCriteria(01120898)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:05
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
public static class  clsge_ExaminationCriteriaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCriteriaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ExaminationCriteriaEN GetObj(this K_CriteriaId_ge_ExaminationCriteria myKey)
{
clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.GetObjByCriteriaId(myKey.Value);
return objge_ExaminationCriteriaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ExaminationCriteriaEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],控件Id = [{1}],事件Id = [{2}]的数据已经存在!(in clsge_ExaminationCriteriaBL.AddNewRecord)", objge_ExaminationCriteriaEN.QuestionId,objge_ExaminationCriteriaEN.ControlTypeId,objge_ExaminationCriteriaEN.EventTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true || clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
     objge_ExaminationCriteriaEN.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
 }
bool bolResult = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.AddNewRecordBySQL2(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_ExaminationCriteriaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_ExaminationCriteriaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目Id(QuestionId)=[{0}],控件Id(ControlTypeId)=[{1}],事件Id(EventTypeId)=[{2}])已经存在,不能重复!", objge_ExaminationCriteriaEN.QuestionId, objge_ExaminationCriteriaEN.ControlTypeId, objge_ExaminationCriteriaEN.EventTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true || clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
     objge_ExaminationCriteriaEN.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_ExaminationCriteriaEN.AddNewRecord();
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ExaminationCriteriaEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],控件Id = [{1}],事件Id = [{2}]的数据已经存在!(in clsge_ExaminationCriteriaBL.AddNewRecordWithMaxId)", objge_ExaminationCriteriaEN.QuestionId,objge_ExaminationCriteriaEN.ControlTypeId,objge_ExaminationCriteriaEN.EventTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true || clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
     objge_ExaminationCriteriaEN.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
 }
string strCriteriaId = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.AddNewRecordBySQL2WithReturnKey(objge_ExaminationCriteriaEN);
     objge_ExaminationCriteriaEN.CriteriaId = strCriteriaId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
}
return strCriteriaId;
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ExaminationCriteriaEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],控件Id = [{1}],事件Id = [{2}]的数据已经存在!(in clsge_ExaminationCriteriaBL.AddNewRecordWithReturnKey)", objge_ExaminationCriteriaEN.QuestionId,objge_ExaminationCriteriaEN.ControlTypeId,objge_ExaminationCriteriaEN.EventTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true || clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
     objge_ExaminationCriteriaEN.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
 }
string strKey = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.AddNewRecordBySQL2WithReturnKey(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetCriteriaId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strCriteriaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCriteriaId, 10, conge_ExaminationCriteria.CriteriaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCriteriaId, 10, conge_ExaminationCriteria.CriteriaId);
}
objge_ExaminationCriteriaEN.CriteriaId = strCriteriaId; //标准Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.CriteriaId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.CriteriaId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.CriteriaId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetQuestionId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conge_ExaminationCriteria.QuestionId);
objge_ExaminationCriteriaEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.QuestionId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.QuestionId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.QuestionId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetCourseId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_ExaminationCriteria.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_ExaminationCriteria.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_ExaminationCriteria.CourseId);
}
objge_ExaminationCriteriaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.CourseId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.CourseId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.CourseId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetDescribe(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strDescribe, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDescribe, 1000, conge_ExaminationCriteria.Describe);
}
objge_ExaminationCriteriaEN.Describe = strDescribe; //标准描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.Describe) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.Describe, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.Describe] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetControlTypeId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strControlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strControlTypeId, conge_ExaminationCriteria.ControlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlTypeId, 4, conge_ExaminationCriteria.ControlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strControlTypeId, 4, conge_ExaminationCriteria.ControlTypeId);
}
objge_ExaminationCriteriaEN.ControlTypeId = strControlTypeId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.ControlTypeId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.ControlTypeId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.ControlTypeId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetEventTypeId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strEventTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventTypeId, 4, conge_ExaminationCriteria.EventTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEventTypeId, 4, conge_ExaminationCriteria.EventTypeId);
}
objge_ExaminationCriteriaEN.EventTypeId = strEventTypeId; //事件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.EventTypeId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.EventTypeId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.EventTypeId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetExaminationTypeId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strExaminationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExaminationTypeId, 4, conge_ExaminationCriteria.ExaminationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExaminationTypeId, 4, conge_ExaminationCriteria.ExaminationTypeId);
}
objge_ExaminationCriteriaEN.ExaminationTypeId = strExaminationTypeId; //检查类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.ExaminationTypeId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.ExaminationTypeId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.ExaminationTypeId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetControlId(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strControlId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlId, 50, conge_ExaminationCriteria.ControlId);
}
objge_ExaminationCriteriaEN.ControlId = strControlId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.ControlId) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.ControlId, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.ControlId] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetControlClass(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strControlClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlClass, 100, conge_ExaminationCriteria.ControlClass);
}
objge_ExaminationCriteriaEN.ControlClass = strControlClass; //控件样式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.ControlClass) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.ControlClass, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.ControlClass] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetControlValue(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strControlValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlValue, 100, conge_ExaminationCriteria.ControlValue);
}
objge_ExaminationCriteriaEN.ControlValue = strControlValue; //控件值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.ControlValue) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.ControlValue, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.ControlValue] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetControlHtml(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strControlHtml, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlHtml, 100, conge_ExaminationCriteria.ControlHtml);
}
objge_ExaminationCriteriaEN.ControlHtml = strControlHtml; //控件html
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.ControlHtml) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.ControlHtml, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.ControlHtml] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetUpdDate(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_ExaminationCriteria.UpdDate);
}
objge_ExaminationCriteriaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.UpdDate) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.UpdDate, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.UpdDate] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetUpdUser(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_ExaminationCriteria.UpdUser);
}
objge_ExaminationCriteriaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.UpdUser) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.UpdUser, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.UpdUser] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetMemo(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_ExaminationCriteria.Memo);
}
objge_ExaminationCriteriaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.Memo) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.Memo, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.Memo] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ExaminationCriteriaEN SetOrderNum(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, int? intOrderNum, string strComparisonOp="")
	{
objge_ExaminationCriteriaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ExaminationCriteriaEN.dicFldComparisonOp.ContainsKey(conge_ExaminationCriteria.OrderNum) == false)
{
objge_ExaminationCriteriaEN.dicFldComparisonOp.Add(conge_ExaminationCriteria.OrderNum, strComparisonOp);
}
else
{
objge_ExaminationCriteriaEN.dicFldComparisonOp[conge_ExaminationCriteria.OrderNum] = strComparisonOp;
}
}
return objge_ExaminationCriteriaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_ExaminationCriteriaEN.CheckPropertyNew();
clsge_ExaminationCriteriaEN objge_ExaminationCriteriaCond = new clsge_ExaminationCriteriaEN();
string strCondition = objge_ExaminationCriteriaCond
.SetCriteriaId(objge_ExaminationCriteriaEN.CriteriaId, "<>")
.SetQuestionId(objge_ExaminationCriteriaEN.QuestionId, "=")
.SetControlTypeId(objge_ExaminationCriteriaEN.ControlTypeId, "=")
.SetEventTypeId(objge_ExaminationCriteriaEN.EventTypeId, "=")
.GetCombineCondition();
objge_ExaminationCriteriaEN._IsCheckProperty = true;
bool bolIsExist = clsge_ExaminationCriteriaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionID_ControlTypeId_EventTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_ExaminationCriteriaEN.Update();
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
 /// <param name = "objge_ExaminationCriteria">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_ExaminationCriteriaEN objge_ExaminationCriteria)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_ExaminationCriteriaEN objge_ExaminationCriteriaCond = new clsge_ExaminationCriteriaEN();
string strCondition = objge_ExaminationCriteriaCond
.SetQuestionId(objge_ExaminationCriteria.QuestionId, "=")
.SetControlTypeId(objge_ExaminationCriteria.ControlTypeId, "=")
.SetEventTypeId(objge_ExaminationCriteria.EventTypeId, "=")
.GetCombineCondition();
objge_ExaminationCriteria._IsCheckProperty = true;
bool bolIsExist = clsge_ExaminationCriteriaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_ExaminationCriteria.CriteriaId = clsge_ExaminationCriteriaBL.GetFirstID_S(strCondition);
objge_ExaminationCriteria.UpdateWithCondition(strCondition);
}
else
{
objge_ExaminationCriteria.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
objge_ExaminationCriteria.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.UpdateBySql2(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.UpdateBySql2(objge_ExaminationCriteriaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strWhereCond)
{
try
{
bool bolResult = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.UpdateBySqlWithCondition(objge_ExaminationCriteriaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.UpdateBySqlWithConditionTransaction(objge_ExaminationCriteriaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
try
{
int intRecNum = clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.DelRecord(objge_ExaminationCriteriaEN.CriteriaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
 /// <param name = "objge_ExaminationCriteriaENT">目标对象</param>
 public static void CopyTo(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENS, clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENT)
{
try
{
objge_ExaminationCriteriaENT.CriteriaId = objge_ExaminationCriteriaENS.CriteriaId; //标准Id
objge_ExaminationCriteriaENT.QuestionId = objge_ExaminationCriteriaENS.QuestionId; //题目Id
objge_ExaminationCriteriaENT.CourseId = objge_ExaminationCriteriaENS.CourseId; //课程Id
objge_ExaminationCriteriaENT.Describe = objge_ExaminationCriteriaENS.Describe; //标准描述
objge_ExaminationCriteriaENT.ControlTypeId = objge_ExaminationCriteriaENS.ControlTypeId; //控件Id
objge_ExaminationCriteriaENT.EventTypeId = objge_ExaminationCriteriaENS.EventTypeId; //事件Id
objge_ExaminationCriteriaENT.ExaminationTypeId = objge_ExaminationCriteriaENS.ExaminationTypeId; //检查类型Id
objge_ExaminationCriteriaENT.ControlId = objge_ExaminationCriteriaENS.ControlId; //控件Id
objge_ExaminationCriteriaENT.ControlClass = objge_ExaminationCriteriaENS.ControlClass; //控件样式
objge_ExaminationCriteriaENT.ControlValue = objge_ExaminationCriteriaENS.ControlValue; //控件值
objge_ExaminationCriteriaENT.ControlHtml = objge_ExaminationCriteriaENS.ControlHtml; //控件html
objge_ExaminationCriteriaENT.UpdDate = objge_ExaminationCriteriaENS.UpdDate; //修改日期
objge_ExaminationCriteriaENT.UpdUser = objge_ExaminationCriteriaENS.UpdUser; //修改人
objge_ExaminationCriteriaENT.Memo = objge_ExaminationCriteriaENS.Memo; //备注
objge_ExaminationCriteriaENT.OrderNum = objge_ExaminationCriteriaENS.OrderNum; //序号
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
 /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
 /// <returns>目标对象=>clsge_ExaminationCriteriaEN:objge_ExaminationCriteriaENT</returns>
 public static clsge_ExaminationCriteriaEN CopyTo(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENS)
{
try
{
 clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENT = new clsge_ExaminationCriteriaEN()
{
CriteriaId = objge_ExaminationCriteriaENS.CriteriaId, //标准Id
QuestionId = objge_ExaminationCriteriaENS.QuestionId, //题目Id
CourseId = objge_ExaminationCriteriaENS.CourseId, //课程Id
Describe = objge_ExaminationCriteriaENS.Describe, //标准描述
ControlTypeId = objge_ExaminationCriteriaENS.ControlTypeId, //控件Id
EventTypeId = objge_ExaminationCriteriaENS.EventTypeId, //事件Id
ExaminationTypeId = objge_ExaminationCriteriaENS.ExaminationTypeId, //检查类型Id
ControlId = objge_ExaminationCriteriaENS.ControlId, //控件Id
ControlClass = objge_ExaminationCriteriaENS.ControlClass, //控件样式
ControlValue = objge_ExaminationCriteriaENS.ControlValue, //控件值
ControlHtml = objge_ExaminationCriteriaENS.ControlHtml, //控件html
UpdDate = objge_ExaminationCriteriaENS.UpdDate, //修改日期
UpdUser = objge_ExaminationCriteriaENS.UpdUser, //修改人
Memo = objge_ExaminationCriteriaENS.Memo, //备注
OrderNum = objge_ExaminationCriteriaENS.OrderNum, //序号
};
 return objge_ExaminationCriteriaENT;
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
public static void CheckPropertyNew(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.CheckPropertyNew(objge_ExaminationCriteriaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.CheckProperty4Condition(objge_ExaminationCriteriaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.CriteriaId) == true)
{
string strComparisonOpCriteriaId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.CriteriaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.CriteriaId, objge_ExaminationCriteriaCond.CriteriaId, strComparisonOpCriteriaId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.QuestionId) == true)
{
string strComparisonOpQuestionId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_ExaminationCriteria.QuestionId, objge_ExaminationCriteriaCond.QuestionId, strComparisonOpQuestionId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.CourseId) == true)
{
string strComparisonOpCourseId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.CourseId, objge_ExaminationCriteriaCond.CourseId, strComparisonOpCourseId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.Describe) == true)
{
string strComparisonOpDescribe = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.Describe];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.Describe, objge_ExaminationCriteriaCond.Describe, strComparisonOpDescribe);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.ControlTypeId) == true)
{
string strComparisonOpControlTypeId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.ControlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.ControlTypeId, objge_ExaminationCriteriaCond.ControlTypeId, strComparisonOpControlTypeId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.EventTypeId) == true)
{
string strComparisonOpEventTypeId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.EventTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.EventTypeId, objge_ExaminationCriteriaCond.EventTypeId, strComparisonOpEventTypeId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.ExaminationTypeId) == true)
{
string strComparisonOpExaminationTypeId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.ExaminationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.ExaminationTypeId, objge_ExaminationCriteriaCond.ExaminationTypeId, strComparisonOpExaminationTypeId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.ControlId) == true)
{
string strComparisonOpControlId = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.ControlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.ControlId, objge_ExaminationCriteriaCond.ControlId, strComparisonOpControlId);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.ControlClass) == true)
{
string strComparisonOpControlClass = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.ControlClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.ControlClass, objge_ExaminationCriteriaCond.ControlClass, strComparisonOpControlClass);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.ControlValue) == true)
{
string strComparisonOpControlValue = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.ControlValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.ControlValue, objge_ExaminationCriteriaCond.ControlValue, strComparisonOpControlValue);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.ControlHtml) == true)
{
string strComparisonOpControlHtml = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.ControlHtml];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.ControlHtml, objge_ExaminationCriteriaCond.ControlHtml, strComparisonOpControlHtml);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.UpdDate, objge_ExaminationCriteriaCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.UpdUser, objge_ExaminationCriteriaCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.Memo) == true)
{
string strComparisonOpMemo = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ExaminationCriteria.Memo, objge_ExaminationCriteriaCond.Memo, strComparisonOpMemo);
}
if (objge_ExaminationCriteriaCond.IsUpdated(conge_ExaminationCriteria.OrderNum) == true)
{
string strComparisonOpOrderNum = objge_ExaminationCriteriaCond.dicFldComparisonOp[conge_ExaminationCriteria.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_ExaminationCriteria.OrderNum, objge_ExaminationCriteriaCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_ExaminationCriteria(题目检查标准表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionID_ControlTypeId_EventTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_ExaminationCriteriaEN == null) return true;
if (objge_ExaminationCriteriaEN.CriteriaId == null || objge_ExaminationCriteriaEN.CriteriaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_ExaminationCriteriaEN.QuestionId);
 sbCondition.AppendFormat(" and ControlTypeId = '{0}'", objge_ExaminationCriteriaEN.ControlTypeId);
 if (objge_ExaminationCriteriaEN.EventTypeId == null)
{
 sbCondition.AppendFormat(" and EventTypeId is null", objge_ExaminationCriteriaEN.EventTypeId);
}
else
{
 sbCondition.AppendFormat(" and EventTypeId = '{0}'", objge_ExaminationCriteriaEN.EventTypeId);
}
if (clsge_ExaminationCriteriaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CriteriaId !=  '{0}'", objge_ExaminationCriteriaEN.CriteriaId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_ExaminationCriteriaEN.QuestionId);
 sbCondition.AppendFormat(" and ControlTypeId = '{0}'", objge_ExaminationCriteriaEN.ControlTypeId);
 sbCondition.AppendFormat(" and EventTypeId = '{0}'", objge_ExaminationCriteriaEN.EventTypeId);
if (clsge_ExaminationCriteriaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_ExaminationCriteria(题目检查标准表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionID_ControlTypeId_EventTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_ExaminationCriteriaEN == null) return "";
if (objge_ExaminationCriteriaEN.CriteriaId == null || objge_ExaminationCriteriaEN.CriteriaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_ExaminationCriteriaEN.QuestionId);
 sbCondition.AppendFormat(" and ControlTypeId = '{0}'", objge_ExaminationCriteriaEN.ControlTypeId);
 if (objge_ExaminationCriteriaEN.EventTypeId == null)
{
 sbCondition.AppendFormat(" and EventTypeId is null", objge_ExaminationCriteriaEN.EventTypeId);
}
else
{
 sbCondition.AppendFormat(" and EventTypeId = '{0}'", objge_ExaminationCriteriaEN.EventTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CriteriaId !=  '{0}'", objge_ExaminationCriteriaEN.CriteriaId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_ExaminationCriteriaEN.QuestionId);
 sbCondition.AppendFormat(" and ControlTypeId = '{0}'", objge_ExaminationCriteriaEN.ControlTypeId);
 sbCondition.AppendFormat(" and EventTypeId = '{0}'", objge_ExaminationCriteriaEN.EventTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_ExaminationCriteria
{
public virtual bool UpdRelaTabDate(string strCriteriaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 题目检查标准表(ge_ExaminationCriteria)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_ExaminationCriteriaBL
{
public static RelatedActions_ge_ExaminationCriteria relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_ExaminationCriteriaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_ExaminationCriteriaDA ge_ExaminationCriteriaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_ExaminationCriteriaDA();
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
 public clsge_ExaminationCriteriaBL()
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
if (string.IsNullOrEmpty(clsge_ExaminationCriteriaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_ExaminationCriteriaEN._ConnectString);
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
public static DataTable GetDataTable_ge_ExaminationCriteria(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_ExaminationCriteriaDA.GetDataTable_ge_ExaminationCriteria(strWhereCond);
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
objDT = ge_ExaminationCriteriaDA.GetDataTable(strWhereCond);
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
objDT = ge_ExaminationCriteriaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_ExaminationCriteriaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_ExaminationCriteriaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_ExaminationCriteriaDA.GetDataTable_Top(objTopPara);
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
objDT = ge_ExaminationCriteriaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_ExaminationCriteriaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_ExaminationCriteriaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCriteriaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetObjLstByCriteriaIdLst(List<string> arrCriteriaIdLst)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCriteriaIdLst, true);
 string strWhereCond = string.Format("CriteriaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCriteriaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_ExaminationCriteriaEN> GetObjLstByCriteriaIdLstCache(List<string> arrCriteriaIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_ExaminationCriteriaEN._CurrTabName, strCourseId);
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjLst_Sel =
arrge_ExaminationCriteriaObjLstCache
.Where(x => arrCriteriaIdLst.Contains(x.CriteriaId));
return arrge_ExaminationCriteriaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetObjLst(string strWhereCond)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
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
public static List<clsge_ExaminationCriteriaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_ExaminationCriteriaEN> GetSubObjLstCache(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaCond)
{
 string strCourseId = objge_ExaminationCriteriaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_ExaminationCriteriaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_ExaminationCriteriaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ExaminationCriteriaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ExaminationCriteria.AttributeName)
{
if (objge_ExaminationCriteriaCond.IsUpdated(strFldName) == false) continue;
if (objge_ExaminationCriteriaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ExaminationCriteriaCond[strFldName].ToString());
}
else
{
if (objge_ExaminationCriteriaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ExaminationCriteriaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ExaminationCriteriaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ExaminationCriteriaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ExaminationCriteriaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ExaminationCriteriaCond[strFldName]));
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
public static List<clsge_ExaminationCriteriaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
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
public static List<clsge_ExaminationCriteriaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
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
List<clsge_ExaminationCriteriaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_ExaminationCriteriaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_ExaminationCriteriaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
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
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
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
public static List<clsge_ExaminationCriteriaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_ExaminationCriteriaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
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
public static List<clsge_ExaminationCriteriaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ExaminationCriteriaEN.CriteriaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ExaminationCriteriaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_ExaminationCriteria(ref clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
bool bolResult = ge_ExaminationCriteriaDA.Getge_ExaminationCriteria(ref objge_ExaminationCriteriaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCriteriaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ExaminationCriteriaEN GetObjByCriteriaId(string strCriteriaId)
{
if (strCriteriaId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCriteriaId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCriteriaId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCriteriaId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = ge_ExaminationCriteriaDA.GetObjByCriteriaId(strCriteriaId);
return objge_ExaminationCriteriaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_ExaminationCriteriaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = ge_ExaminationCriteriaDA.GetFirstObj(strWhereCond);
 return objge_ExaminationCriteriaEN;
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
public static clsge_ExaminationCriteriaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = ge_ExaminationCriteriaDA.GetObjByDataRow(objRow);
 return objge_ExaminationCriteriaEN;
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
public static clsge_ExaminationCriteriaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = ge_ExaminationCriteriaDA.GetObjByDataRow(objRow);
 return objge_ExaminationCriteriaEN;
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
 /// <param name = "strCriteriaId">所给的关键字</param>
 /// <param name = "lstge_ExaminationCriteriaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ExaminationCriteriaEN GetObjByCriteriaIdFromList(string strCriteriaId, List<clsge_ExaminationCriteriaEN> lstge_ExaminationCriteriaObjLst)
{
foreach (clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN in lstge_ExaminationCriteriaObjLst)
{
if (objge_ExaminationCriteriaEN.CriteriaId == strCriteriaId)
{
return objge_ExaminationCriteriaEN;
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
 string strMaxCriteriaId;
 try
 {
 strMaxCriteriaId = clsge_ExaminationCriteriaDA.GetMaxStrId();
 return strMaxCriteriaId;
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
 string strCriteriaId;
 try
 {
 strCriteriaId = new clsge_ExaminationCriteriaDA().GetFirstID(strWhereCond);
 return strCriteriaId;
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
 arrList = ge_ExaminationCriteriaDA.GetID(strWhereCond);
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
bool bolIsExist = ge_ExaminationCriteriaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCriteriaId)
{
if (string.IsNullOrEmpty(strCriteriaId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCriteriaId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_ExaminationCriteriaDA.IsExist(strCriteriaId);
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
 bolIsExist = clsge_ExaminationCriteriaDA.IsExistTable();
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
 bolIsExist = ge_ExaminationCriteriaDA.IsExistTable(strTabName);
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_ExaminationCriteriaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],控件Id = [{1}],事件Id = [{2}]的数据已经存在!(in clsge_ExaminationCriteriaBL.AddNewRecordBySql2)", objge_ExaminationCriteriaEN.QuestionId,objge_ExaminationCriteriaEN.ControlTypeId,objge_ExaminationCriteriaEN.EventTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true || clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
     objge_ExaminationCriteriaEN.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
 }
bool bolResult = ge_ExaminationCriteriaDA.AddNewRecordBySQL2(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_ExaminationCriteriaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],控件Id = [{1}],事件Id = [{2}]的数据已经存在!(in clsge_ExaminationCriteriaBL.AddNewRecordBySql2WithReturnKey)", objge_ExaminationCriteriaEN.QuestionId,objge_ExaminationCriteriaEN.ControlTypeId,objge_ExaminationCriteriaEN.EventTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true || clsge_ExaminationCriteriaBL.IsExist(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
     objge_ExaminationCriteriaEN.CriteriaId = clsge_ExaminationCriteriaBL.GetMaxStrId_S();
 }
string strKey = ge_ExaminationCriteriaDA.AddNewRecordBySQL2WithReturnKey(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
try
{
bool bolResult = ge_ExaminationCriteriaDA.Update(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 if (string.IsNullOrEmpty(objge_ExaminationCriteriaEN.CriteriaId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_ExaminationCriteriaDA.UpdateBySql2(objge_ExaminationCriteriaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ExaminationCriteriaBL.ReFreshCache(objge_ExaminationCriteriaEN.CourseId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
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
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCriteriaId)
{
try
{
 clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = clsge_ExaminationCriteriaBL.GetObjByCriteriaId(strCriteriaId);

if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(objge_ExaminationCriteriaEN.CriteriaId, "SetUpdDate");
}
if (objge_ExaminationCriteriaEN != null)
{
int intRecNum = ge_ExaminationCriteriaDA.DelRecord(strCriteriaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_ExaminationCriteriaEN.CourseId);
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
/// <param name="strCriteriaId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCriteriaId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
//删除与表:[ge_ExaminationCriteria]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_ExaminationCriteria.CriteriaId,
//strCriteriaId);
//        clsge_ExaminationCriteriaBL.Delge_ExaminationCriteriasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ExaminationCriteriaBL.DelRecord(strCriteriaId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ExaminationCriteriaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCriteriaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCriteriaId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(strCriteriaId, "UpdRelaTabDate");
}
bool bolResult = ge_ExaminationCriteriaDA.DelRecord(strCriteriaId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCriteriaIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_ExaminationCriterias(List<string> arrCriteriaIdLst)
{
if (arrCriteriaIdLst.Count == 0) return 0;
try
{
if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
foreach (var strCriteriaId in arrCriteriaIdLst)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(strCriteriaId, "UpdRelaTabDate");
}
}
 clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = clsge_ExaminationCriteriaBL.GetObjByCriteriaId(arrCriteriaIdLst[0]);
int intDelRecNum = ge_ExaminationCriteriaDA.Delge_ExaminationCriteria(arrCriteriaIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_ExaminationCriteriaEN.CourseId);
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
public static int Delge_ExaminationCriteriasByCond(string strWhereCond)
{
try
{
if (clsge_ExaminationCriteriaBL.relatedActions != null)
{
List<string> arrCriteriaId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCriteriaId in arrCriteriaId)
{
clsge_ExaminationCriteriaBL.relatedActions.UpdRelaTabDate(strCriteriaId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_ExaminationCriteria.CourseId, strWhereCond);
int intRecNum = ge_ExaminationCriteriaDA.Delge_ExaminationCriteria(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_ExaminationCriteria]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCriteriaId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCriteriaId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
//删除与表:[ge_ExaminationCriteria]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ExaminationCriteriaBL.DelRecord(strCriteriaId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ExaminationCriteriaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCriteriaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
 /// <param name = "objge_ExaminationCriteriaENT">目标对象</param>
 public static void CopyTo(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENS, clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENT)
{
try
{
objge_ExaminationCriteriaENT.CriteriaId = objge_ExaminationCriteriaENS.CriteriaId; //标准Id
objge_ExaminationCriteriaENT.QuestionId = objge_ExaminationCriteriaENS.QuestionId; //题目Id
objge_ExaminationCriteriaENT.CourseId = objge_ExaminationCriteriaENS.CourseId; //课程Id
objge_ExaminationCriteriaENT.Describe = objge_ExaminationCriteriaENS.Describe; //标准描述
objge_ExaminationCriteriaENT.ControlTypeId = objge_ExaminationCriteriaENS.ControlTypeId; //控件Id
objge_ExaminationCriteriaENT.EventTypeId = objge_ExaminationCriteriaENS.EventTypeId; //事件Id
objge_ExaminationCriteriaENT.ExaminationTypeId = objge_ExaminationCriteriaENS.ExaminationTypeId; //检查类型Id
objge_ExaminationCriteriaENT.ControlId = objge_ExaminationCriteriaENS.ControlId; //控件Id
objge_ExaminationCriteriaENT.ControlClass = objge_ExaminationCriteriaENS.ControlClass; //控件样式
objge_ExaminationCriteriaENT.ControlValue = objge_ExaminationCriteriaENS.ControlValue; //控件值
objge_ExaminationCriteriaENT.ControlHtml = objge_ExaminationCriteriaENS.ControlHtml; //控件html
objge_ExaminationCriteriaENT.UpdDate = objge_ExaminationCriteriaENS.UpdDate; //修改日期
objge_ExaminationCriteriaENT.UpdUser = objge_ExaminationCriteriaENS.UpdUser; //修改人
objge_ExaminationCriteriaENT.Memo = objge_ExaminationCriteriaENS.Memo; //备注
objge_ExaminationCriteriaENT.OrderNum = objge_ExaminationCriteriaENS.OrderNum; //序号
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
 /// <param name = "objge_ExaminationCriteriaEN">源简化对象</param>
 public static void SetUpdFlag(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
try
{
objge_ExaminationCriteriaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_ExaminationCriteriaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_ExaminationCriteria.CriteriaId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.CriteriaId = objge_ExaminationCriteriaEN.CriteriaId; //标准Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.QuestionId = objge_ExaminationCriteriaEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.CourseId = objge_ExaminationCriteriaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.Describe, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.Describe = objge_ExaminationCriteriaEN.Describe == "[null]" ? null :  objge_ExaminationCriteriaEN.Describe; //标准描述
}
if (arrFldSet.Contains(conge_ExaminationCriteria.ControlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.ControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId; //控件Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.EventTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.EventTypeId = objge_ExaminationCriteriaEN.EventTypeId == "[null]" ? null :  objge_ExaminationCriteriaEN.EventTypeId; //事件Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.ExaminationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.ExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId == "[null]" ? null :  objge_ExaminationCriteriaEN.ExaminationTypeId; //检查类型Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.ControlId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.ControlId = objge_ExaminationCriteriaEN.ControlId == "[null]" ? null :  objge_ExaminationCriteriaEN.ControlId; //控件Id
}
if (arrFldSet.Contains(conge_ExaminationCriteria.ControlClass, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.ControlClass = objge_ExaminationCriteriaEN.ControlClass == "[null]" ? null :  objge_ExaminationCriteriaEN.ControlClass; //控件样式
}
if (arrFldSet.Contains(conge_ExaminationCriteria.ControlValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.ControlValue = objge_ExaminationCriteriaEN.ControlValue == "[null]" ? null :  objge_ExaminationCriteriaEN.ControlValue; //控件值
}
if (arrFldSet.Contains(conge_ExaminationCriteria.ControlHtml, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.ControlHtml = objge_ExaminationCriteriaEN.ControlHtml == "[null]" ? null :  objge_ExaminationCriteriaEN.ControlHtml; //控件html
}
if (arrFldSet.Contains(conge_ExaminationCriteria.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.UpdDate = objge_ExaminationCriteriaEN.UpdDate == "[null]" ? null :  objge_ExaminationCriteriaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_ExaminationCriteria.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.UpdUser = objge_ExaminationCriteriaEN.UpdUser == "[null]" ? null :  objge_ExaminationCriteriaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_ExaminationCriteria.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.Memo = objge_ExaminationCriteriaEN.Memo == "[null]" ? null :  objge_ExaminationCriteriaEN.Memo; //备注
}
if (arrFldSet.Contains(conge_ExaminationCriteria.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ExaminationCriteriaEN.OrderNum = objge_ExaminationCriteriaEN.OrderNum; //序号
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
 /// <param name = "objge_ExaminationCriteriaEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
try
{
if (objge_ExaminationCriteriaEN.Describe == "[null]") objge_ExaminationCriteriaEN.Describe = null; //标准描述
if (objge_ExaminationCriteriaEN.EventTypeId == "[null]") objge_ExaminationCriteriaEN.EventTypeId = null; //事件Id
if (objge_ExaminationCriteriaEN.ExaminationTypeId == "[null]") objge_ExaminationCriteriaEN.ExaminationTypeId = null; //检查类型Id
if (objge_ExaminationCriteriaEN.ControlId == "[null]") objge_ExaminationCriteriaEN.ControlId = null; //控件Id
if (objge_ExaminationCriteriaEN.ControlClass == "[null]") objge_ExaminationCriteriaEN.ControlClass = null; //控件样式
if (objge_ExaminationCriteriaEN.ControlValue == "[null]") objge_ExaminationCriteriaEN.ControlValue = null; //控件值
if (objge_ExaminationCriteriaEN.ControlHtml == "[null]") objge_ExaminationCriteriaEN.ControlHtml = null; //控件html
if (objge_ExaminationCriteriaEN.UpdDate == "[null]") objge_ExaminationCriteriaEN.UpdDate = null; //修改日期
if (objge_ExaminationCriteriaEN.UpdUser == "[null]") objge_ExaminationCriteriaEN.UpdUser = null; //修改人
if (objge_ExaminationCriteriaEN.Memo == "[null]") objge_ExaminationCriteriaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 ge_ExaminationCriteriaDA.CheckPropertyNew(objge_ExaminationCriteriaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 ge_ExaminationCriteriaDA.CheckProperty4Condition(objge_ExaminationCriteriaEN);
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
if (clsge_ExaminationCriteriaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_ExaminationCriteriaBL没有刷新缓存机制(clsge_ExaminationCriteriaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CriteriaId");
//if (arrge_ExaminationCriteriaObjLstCache == null)
//{
//arrge_ExaminationCriteriaObjLstCache = ge_ExaminationCriteriaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCriteriaId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ExaminationCriteriaEN GetObjByCriteriaIdCache(string strCriteriaId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_ExaminationCriteriaEN._CurrTabName, strCourseId);
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjLst_Sel =
arrge_ExaminationCriteriaObjLstCache
.Where(x=> x.CriteriaId == strCriteriaId 
);
if (arrge_ExaminationCriteriaObjLst_Sel.Count() == 0)
{
   clsge_ExaminationCriteriaEN obj = clsge_ExaminationCriteriaBL.GetObjByCriteriaId(strCriteriaId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCriteriaId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_ExaminationCriteriaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetAllge_ExaminationCriteriaObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjLstCache = GetObjLstCache(strCourseId); 
return arrge_ExaminationCriteriaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ExaminationCriteriaEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsge_ExaminationCriteriaEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_ExaminationCriteriaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_ExaminationCriteriaEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_ExaminationCriteriaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_ExaminationCriteriaEN._RefreshTimeLst.Count == 0) return "";
return clsge_ExaminationCriteriaEN._RefreshTimeLst[clsge_ExaminationCriteriaEN._RefreshTimeLst.Count - 1];
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
if (clsge_ExaminationCriteriaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_ExaminationCriteriaEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_ExaminationCriteriaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_ExaminationCriteriaBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_ExaminationCriteria(题目检查标准表)
 /// 唯一性条件:QuestionID_ControlTypeId_EventTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//检测记录是否存在
string strResult = ge_ExaminationCriteriaDA.GetUniCondStr(objge_ExaminationCriteriaEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCriteriaId, string strCourseId)
{
if (strInFldName != conge_ExaminationCriteria.CriteriaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_ExaminationCriteria.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_ExaminationCriteria.AttributeName));
throw new Exception(strMsg);
}
var objge_ExaminationCriteria = clsge_ExaminationCriteriaBL.GetObjByCriteriaIdCache(strCriteriaId, strCourseId);
if (objge_ExaminationCriteria == null) return "";
return objge_ExaminationCriteria[strOutFldName].ToString();
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
int intRecCount = clsge_ExaminationCriteriaDA.GetRecCount(strTabName);
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
int intRecCount = clsge_ExaminationCriteriaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_ExaminationCriteriaDA.GetRecCount();
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
int intRecCount = clsge_ExaminationCriteriaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaCond)
{
 string strCourseId = objge_ExaminationCriteriaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_ExaminationCriteriaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_ExaminationCriteriaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ExaminationCriteriaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ExaminationCriteria.AttributeName)
{
if (objge_ExaminationCriteriaCond.IsUpdated(strFldName) == false) continue;
if (objge_ExaminationCriteriaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ExaminationCriteriaCond[strFldName].ToString());
}
else
{
if (objge_ExaminationCriteriaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ExaminationCriteriaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ExaminationCriteriaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ExaminationCriteriaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ExaminationCriteriaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ExaminationCriteriaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ExaminationCriteriaCond[strFldName]));
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
 List<string> arrList = clsge_ExaminationCriteriaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_ExaminationCriteriaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_ExaminationCriteriaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_ExaminationCriteriaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ExaminationCriteriaDA.SetFldValue(clsge_ExaminationCriteriaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_ExaminationCriteriaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ExaminationCriteriaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ExaminationCriteriaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ExaminationCriteriaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_ExaminationCriteria] "); 
 strCreateTabCode.Append(" ( "); 
 // /**标准Id*/ 
 strCreateTabCode.Append(" CriteriaId char(10) primary key, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**标准描述*/ 
 strCreateTabCode.Append(" Describe varchar(1000) Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" ControlTypeId char(4) not Null, "); 
 // /**事件Id*/ 
 strCreateTabCode.Append(" EventTypeId char(4) Null, "); 
 // /**检查类型Id*/ 
 strCreateTabCode.Append(" ExaminationTypeId char(4) Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" ControlId varchar(50) Null, "); 
 // /**控件样式*/ 
 strCreateTabCode.Append(" ControlClass varchar(100) Null, "); 
 // /**控件值*/ 
 strCreateTabCode.Append(" ControlValue varchar(100) Null, "); 
 // /**控件html*/ 
 strCreateTabCode.Append(" ControlHtml varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**控件名称*/ 
 strCreateTabCode.Append(" ControlTypeName varchar(100) Null, "); 
 // /**事件名称*/ 
 strCreateTabCode.Append(" EventTypeName varchar(100) Null, "); 
 // /**属性名称*/ 
 strCreateTabCode.Append(" TypeDescribe varchar(1000) Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) Null ");
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
strCondition += string.Format(" And {0} = '{1}' ", conge_ExaminationCriteria.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OrderNum ");
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjList = new clsge_ExaminationCriteriaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_ExaminationCriteriaEN objge_ExaminationCriteria in arrge_ExaminationCriteriaObjList)
{
objge_ExaminationCriteria.OrderNum = intIndex;
UpdateBySql2(objge_ExaminationCriteria);
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
/// <param name="strCriteriaId">所给的关键字</param>
/// <param name="lngQuestionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strCriteriaId ,long lngQuestionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[CriteriaId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CriteriaId
//5、把当前关键字CriteriaId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CriteriaId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCriteriaId = "";    //上一条序号的关键字CriteriaId
string strNextCriteriaId = "";    //下一条序号的关键字CriteriaId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[CriteriaId],获取相应的序号[OrderNum]。

clsge_ExaminationCriteriaEN objge_ExaminationCriteria = clsge_ExaminationCriteriaBL.GetObjByCriteriaId(strCriteriaId);

intOrderNum = objge_ExaminationCriteria.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_ExaminationCriteria.QuestionId, lngQuestionId);
intTabRecNum = clsge_ExaminationCriteriaBL.GetRecCountByCond(clsge_ExaminationCriteriaEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conge_ExaminationCriteria.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conge_ExaminationCriteria.QuestionId, lngQuestionId);
//4、获取上一个序号字段的关键字CriteriaId
strPrevCriteriaId = clsge_ExaminationCriteriaBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevCriteriaId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CriteriaId所对应记录的序号减1
//6、把下(上)一个序号关键字CriteriaId所对应的记录序号加1
clsge_ExaminationCriteriaBL.SetFldValue(clsge_ExaminationCriteriaEN._CurrTabName, conge_ExaminationCriteria.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conge_ExaminationCriteria.CriteriaId, strCriteriaId));
clsge_ExaminationCriteriaBL.SetFldValue(clsge_ExaminationCriteriaEN._CurrTabName, conge_ExaminationCriteria.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conge_ExaminationCriteria.CriteriaId, strPrevCriteriaId));
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

//4、获取下一个序号字段的关键字CriteriaId
sbCondition.AppendFormat(" {0} = {1} ", conge_ExaminationCriteria.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conge_ExaminationCriteria.QuestionId, lngQuestionId);

strNextCriteriaId = clsge_ExaminationCriteriaBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextCriteriaId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CriteriaId所对应记录的序号加1
//6、把下(上)一个序号关键字CriteriaId所对应的记录序号减1
clsge_ExaminationCriteriaBL.SetFldValue(clsge_ExaminationCriteriaEN._CurrTabName, conge_ExaminationCriteria.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conge_ExaminationCriteria.CriteriaId, strCriteriaId));
clsge_ExaminationCriteriaBL.SetFldValue(clsge_ExaminationCriteriaEN._CurrTabName, conge_ExaminationCriteria.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conge_ExaminationCriteria.CriteriaId, strNextCriteriaId));
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
string strCondition = string.Format("{0} in ({1})", conge_ExaminationCriteria.CriteriaId, strKeyList);
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaLst = GetObjLst(strCondition);
foreach (clsge_ExaminationCriteriaEN objge_ExaminationCriteria in arrge_ExaminationCriteriaLst)
{
objge_ExaminationCriteria.OrderNum = objge_ExaminationCriteria.OrderNum + 10000;
UpdateBySql2(objge_ExaminationCriteria);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_ExaminationCriteria.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OrderNum ");
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjList = new clsge_ExaminationCriteriaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_ExaminationCriteriaEN objge_ExaminationCriteria in arrge_ExaminationCriteriaObjList)
{
objge_ExaminationCriteria.OrderNum = intIndex;
UpdateBySql2(objge_ExaminationCriteria);
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
string strCondition = string.Format("{0} in ({1})", conge_ExaminationCriteria.CriteriaId, strKeyList);
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaLst = GetObjLst(strCondition);
foreach (clsge_ExaminationCriteriaEN objge_ExaminationCriteria in arrge_ExaminationCriteriaLst)
{
objge_ExaminationCriteria.OrderNum = objge_ExaminationCriteria.OrderNum - 10000;
UpdateBySql2(objge_ExaminationCriteria);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conge_ExaminationCriteria.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by OrderNum ");
List<clsge_ExaminationCriteriaEN> arrge_ExaminationCriteriaObjList = new clsge_ExaminationCriteriaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_ExaminationCriteriaEN objge_ExaminationCriteria in arrge_ExaminationCriteriaObjList)
{
objge_ExaminationCriteria.OrderNum = intIndex;
UpdateBySql2(objge_ExaminationCriteria);
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
 /// 题目检查标准表(ge_ExaminationCriteria)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_ExaminationCriteria : clsCommFun4BLV2
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
clsge_ExaminationCriteriaBL.ReFreshThisCache(strCourseId);
}
}

}